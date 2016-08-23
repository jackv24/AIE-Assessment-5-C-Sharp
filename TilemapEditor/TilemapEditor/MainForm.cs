using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TilemapEditor
{
    public partial class MainForm : Form
    {
        //The tilemap image loaded
        public Image currentTilemap = null;
        //The path from which it was loaded
        string lastFilePath = "";

        //Ask to save if unsaved changes
        bool unsavedChanges = false;

        //Tile selection
        Tile selectedTile;
        Tile lastSelectedTile;

        //Individual tiles
        Tile[,] tiles;

        public enum Tools
        {
            Pencil,
            Eraser,
            Fill,
            EyeDropper
        }
        private Tools selectedTool = Tools.Pencil;
        public Tools SelectedTool
        {
            get { return selectedTool; }
            set
            {
                selectedTool = value;

                string tool = "None";

                toolPencilButton.Enabled = true;
                toolEraserButton.Enabled = true;
                toolFillButton.Enabled = true;
                toolColorPickerButton.Enabled = true;

                switch(selectedTool)
                {
                    case Tools.Pencil:
                        tool = "Pencil";
                        toolPencilButton.Enabled = false;
                        break;
                    case Tools.Eraser:
                        tool = "Eraser";
                        toolEraserButton.Enabled = false;
                        break;
                    case Tools.Fill:
                        tool = "Fill Bucket";
                        toolFillButton.Enabled = false;
                        break;
                    case Tools.EyeDropper:
                        tool = "Eye Dropper";
                        toolColorPickerButton.Enabled = false;
                        break;
                }

                toolStripToolStatus.Text = "Selected Tool: " + tool;
            }

        }

        public MainForm()
        {
            InitializeComponent();

            //Load default values from settings
            LoadPrefs();

            //Set default colors
            PrimaryColor = Color.Black;
            SecondaryColor = Color.White;

            SelectedTool = Tools.Pencil;
        }

        public void LoadPrefs()
        {
            tileWidthUpDown.Value = Properties.Settings.Default.TileWidth;
            tileHeightUpDown.Value = Properties.Settings.Default.TileHeight;

            tilePictureBox.BackColor = Properties.Settings.Default.BackgroundColor;
            tilemapPanel.BackColor = Properties.Settings.Default.BackgroundColor;
            tileMapPictureBox.BackColor = Properties.Settings.Default.BackgroundColor;
        }

        //Form events
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges)
            {
                //Display a confirmation dialog
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit the application?\nAll unsaved work will be lost!",
                    Application.ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                //If user clicks no, do not close the application
                if (result == DialogResult.No)
                    e.Cancel = true;
            }

            //Save settings
            Properties.Settings.Default.TileWidth = (int)tileWidthUpDown.Value;
            Properties.Settings.Default.TileHeight = (int)tileHeightUpDown.Value;

            Properties.Settings.Default.Save();
        }

        //Menu strip events
        //File Menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e) { CreateNew(); }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) { OpenFile(true); }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) { SaveFile(false); }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) { SaveFile(true); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attempt to close the application
            Application.Exit();
        }

        //File options buttons
        private void newButton_Click(object sender, EventArgs e) { CreateNew(); }

        private void openButton_Click(object sender, EventArgs e) { OpenFile(true); }

        private void saveButton_Click(object sender, EventArgs e) { SaveFile(false); }

        private void saveAsButton_Click(object sender, EventArgs e) { SaveFile(true); }

        private void refreshButton_Click(object sender, EventArgs e) { OpenFile(false); }

        //Edit menu
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences prefs = new Preferences();
            prefs.main = this;
            prefs.ShowDialog();
        }

        //Methods for multiple controls
        //Resets all values
        private void CreateNew()
        {
            //Display a confirmation dialog
            DialogResult result = DialogResult.Yes;

            if (unsavedChanges)
            {
                result = MessageBox.Show(
                    "Are you sure you want to create a new tilemap?\nThis will erase the current tilemap.",
                    Application.ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            }

            if (result == DialogResult.Yes)
            {
                //Remove pictureboxes
                while (tilemapPanel.Controls.Count > 0)
                    tilemapPanel.Controls[0].Dispose();

                tilePictureBox.Image = null;
                lastFilePath = "";

                CreateForm form = new CreateForm();
                form.main = this;
                form.ShowDialog();
            }
        }

        public void OpenFile(bool showDialog)
        {
            //If a new file is opened, it has not been changed yet
            unsavedChanges = false;

            if (showDialog)
            {
                using (OpenFileDialog selectFile = new OpenFileDialog())
                {
                    selectFile.Filter = "Image Files (*.jpeg, *.png, *.jpg, *.gif)|*.jpeg;*.png;*.jpg;*.gif|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                    selectFile.Title = "Please select a tile map to edit.";

                    if (selectFile.ShowDialog() == DialogResult.OK)
                    {
                        //load tilemap
                        currentTilemap = Image.FromFile(selectFile.FileName);

                        lastFilePath = selectFile.FileName;
                    }
                    else
                        return;
                }
            }

            //Cache values from form
            int tileWidth = (int)tileWidthUpDown.Value;
            int tileHeight = (int)tileHeightUpDown.Value;
            int zoomAmount = zoomTrackBar.Value;

            //Show an error if any values are zero
            if (tileWidth <= 0 || tileHeight <= 0)
            {
                MessageBox.Show(
                "Tilemap values can not be zero!",
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            if (currentTilemap != null)
            {
                tilePictureBox.Image = null;
                selectedTile = null;
                lastSelectedTile = null;

                //Calculate rows and columns
                int numRows = (int)Math.Round((float)currentTilemap.Height / tileHeight);
                int numColumns = (int)Math.Round((float)currentTilemap.Width / tileWidth);

                //Create new array at specified sizes
                tiles = new Tile[numColumns, numRows];

                //Set values for tiles
                for(int i = 0; i < tiles.GetLength(0); i++)
                    for(int j = 0; j < tiles.GetLength(1); j++)
                    {
                        tiles[i, j] = new Tile();

                        tiles[i, j].x = i;
                        tiles[i, j].y = j;

                        tiles[i, j].width = tileWidth;
                        tiles[i, j].height = tileHeight;

                        tiles[i, j].tileMap = currentTilemap;
                    }

                //Set tilemap image
                tileMapPictureBox.Image = currentTilemap;
                tileMapPictureBox.Size = new Size(currentTilemap.Width * zoomAmount, currentTilemap.Height * zoomAmount);
            }
        }

        private void SaveFile(bool showDialog)
        {
            //Only show the dialog if showdialog is true and there is a tilemap to save (also save as if there is no lastFilePath)
            if (showDialog && currentTilemap != null || lastFilePath == "")
            {
                using (SaveFileDialog selectFile = new SaveFileDialog())
                {
                    selectFile.Filter = "Image Files (*.jpeg, *.png, *.jpg, *.gif)|*.jpeg;*.png;*.jpg;*.gif|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                    selectFile.Title = "Please select a save location.";
                    selectFile.FilterIndex = 3;

                    if (selectFile.ShowDialog() == DialogResult.OK)
                        lastFilePath = selectFile.FileName;
                    else
                        return;
                }
            }
            //If the file already exists
            else if(File.Exists(lastFilePath))
            {
                //Confirm that the user wants to overwrite it
                DialogResult result = MessageBox.Show(
                "This file already exists.\n\nDo you want to overwrite it?",
                Application.ProductName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                //If the user chooses no, abort saving
                if (result == DialogResult.No)
                    return;
            }

            if(currentTilemap == null && lastFilePath != "")
                //load tilemap (may have been disposed
                currentTilemap = Image.FromFile(lastFilePath);

            if(currentTilemap != null)
            {
                //Create new bitmap for output tilemap
                Bitmap outputMap = new Bitmap(currentTilemap);

                //Free image so that it can be overwritten
                currentTilemap.Dispose();
                currentTilemap = null;

                //Try to save file (catches exception)
                try
                {
                    using (FileStream fs = new FileStream(lastFilePath, FileMode.Create, FileAccess.Write))
                    {
                        outputMap.Save(fs, System.Drawing.Imaging.ImageFormat.Png);

                        unsavedChanges = false;
                        MessageBox.Show("File saved!");
                    }
                }
                catch (Exception ex)
                {
                    //Show error if exception is thrown
                    MessageBox.Show("Error: Could not access the file.\n\n" + ex.Message, "Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("No file to save!");
        }

        private void tileMapPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentTilemap != null)
            {
                PixelPictureBox box = (PixelPictureBox)sender;

                //Cache width and height
                int width = tiles.GetLength(0);
                int height = tiles.GetLength(1);

                //Get ratio between picturebox size and tile array size
                float widthRatio = (float)width / box.Width;
                float heightRatio = (float)height / box.Height;

                //Convert picturebox coordinates to tile coordinates
                int x = (int)Math.Ceiling(e.X * widthRatio) - 1;
                int y = (int)Math.Ceiling(e.Y * heightRatio) - 1;

                //If click was made inside picture box
                if (x < width && x >= 0 && y < height && y >= 0)
                {
                    //Select tile
                    lastSelectedTile = selectedTile;
                    selectedTile = tiles[x, y];

                    //Load tile image in editor
                    tilePictureBox.Image = selectedTile.Image;
                }
            }
        }

        //Tile editor picturebox
        //Use property to access colour so displays can be updated
        private Color primaryColor = Color.Empty;
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                if(primaryColor != value && primaryColor != Color.Empty)
                    AddSwatch(primaryColor);

                primaryColor = value;
                colorPrimaryBox.BackColor = primaryColor;
            }
        }

        //Use property to access colour so displays can be updated
        private Color secondaryColor = Color.Empty;
        public Color SecondaryColor
        {
            get { return secondaryColor; }
            set
            {
                if(secondaryColor != value && secondaryColor != Color.Empty)
                    AddSwatch(secondaryColor);

                secondaryColor = value;
                colorSecondaryBox.BackColor = secondaryColor;
            }
        }

        List<PictureBox> colorSwatches = new List<PictureBox>();

        bool hasClicked = false;

        private void tilePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            hasClicked = true;
            tilePictureBox_MouseMove(sender, e);
        }

        private void tilePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (hasClicked)
            {
                PixelPictureBox box = (PixelPictureBox)sender;

                if (box.Image != null)
                {
                    //If left or right mouse button was clicked
                    if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                    {
                        Bitmap bmp = new Bitmap(box.Image);
                        float widthRatio = (float)bmp.Width / box.Width;
                        float heightRatio = (float)bmp.Height / box.Height;

                        int x = (int)Math.Ceiling(e.X * widthRatio) - 1;
                        int y = (int)Math.Ceiling(e.Y * heightRatio) - 1;

                        //If click was made inside picture box
                        if (x < bmp.Width && x >= 0 && y < bmp.Height && y >= 0)
                        {
                            //Get desired color based on left or right mouse click
                            Color color = Color.White;
                            if (e.Button == MouseButtons.Left)
                                color = PrimaryColor;
                            else if (e.Button == MouseButtons.Right)
                                color = SecondaryColor;

                            if (selectedTool == Tools.EyeDropper)
                            {
                                //Checks are needed for eyedropper as it modifies the colours
                                if (e.Button == MouseButtons.Left)
                                    PrimaryColor = bmp.GetPixel(x, y);
                                else if (e.Button == MouseButtons.Right)
                                    SecondaryColor = bmp.GetPixel(x, y);
                            }
                            else if (selectedTool == Tools.Pencil)
                            {
                                //Color pixel
                                bmp.SetPixel(x, y, color);
                            }
                            else if (selectedTool == Tools.Eraser)
                            {
                                //Erase pixel
                                bmp.SetPixel(x, y, Color.Transparent);
                            }
                            else if (selectedTool == Tools.Fill)
                            {
                                FloodFill(bmp, x, y, bmp.GetPixel(x, y), color);
                                hasClicked = false;
                            }

                            //Update editor and tilemap images to the new bitmap
                            box.Image = bmp;
                            selectedTile.Image = bmp;

                            //Refresh tilemap display
                            tileMapPictureBox.Refresh();
                        }

                        //Changes were made
                        unsavedChanges = true;
                    }
                }
            }
        }

        private void tilePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            hasClicked = false;
        }

        //Color picking
        private void colorPrimaryBox_Click(object sender, EventArgs e)
        {
            colorPicker.Color = primaryColor;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                PrimaryColor = colorPicker.Color;
            }
        }

        private void colorSecondaryBox_Click(object sender, EventArgs e)
        {
            colorPicker.Color = secondaryColor;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                SecondaryColor = colorPicker.Color;
            }
        }

        private void AddSwatch(Color color)
        {
            //Create new picturebox as child of tilemapPanel
            PictureBox box = new PictureBox();
            colorSwatches.Add(box);
            colorSwatchesPanel.Controls.Add(box);
            box.Size = new Size(20, 20);
            box.BackColor = color;
            box.BorderStyle = BorderStyle.FixedSingle;
            helpTooltip.SetToolTip(box, "Click to use swatch");
            box.MouseClick += new MouseEventHandler(colorSwatchBox_Click);

            //Reposition swatches
            for (int i = colorSwatches.Count - 1; i >= 0; i--)
            {
                //Position in reverse order (newest first)
                int index = colorSwatches.Count - 1 - i;

                int height = (int)Math.Floor((float)index / 3);
                //Flow to next line
                for (int j = height; j > 0; j--)
                {
                    index -= 3;
                }

                colorSwatches[i].Location = new Point(index * 22, height * 22);
            }
        }

        private void colorSwatchBox_Click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                PrimaryColor = ((PictureBox)sender).BackColor;
            else if (e.Button == MouseButtons.Right)
                SecondaryColor = ((PictureBox)sender).BackColor;
        }

        //Switch the primary and secondary colours
        private void SwitchColors()
        {
            //Swap colours (not using public property so logic is skipped)
            Color temp = primaryColor;
            primaryColor = secondaryColor;
            secondaryColor = temp;

            //Manually update display, skipping swatch creation
            colorPrimaryBox.BackColor = primaryColor;
            colorSecondaryBox.BackColor = secondaryColor;
        }

        private void switchColoursButton_Click(object sender, EventArgs e) { SwitchColors(); }

        //Modifiers when alt is held
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
                SelectedTool = Tools.EyeDropper;

            if (e.KeyCode == Keys.X)
                SwitchColors();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            SelectedTool = Tools.Pencil;
        }

        //Tool buttons
        private void toolPencilButton_Click(object sender, EventArgs e) { SelectedTool = Tools.Pencil; }
        private void toolEraserButton_Click(object sender, EventArgs e) { SelectedTool = Tools.Eraser; }
        private void toolFillButton_Click(object sender, EventArgs e) { SelectedTool = Tools.Fill; }
        private void toolColorPickerButton_Click(object sender, EventArgs e) { SelectedTool = Tools.EyeDropper; }

        //Reusable functions
        void FloodFill(Bitmap bmp, int x, int y, Color targetColor, Color replacementColor)
        {
            //Make sure it is within bounds
            if (x >= bmp.Width || x < 0 || y >= bmp.Height || y < 0)
                return;

            //Stop if same colour (to be contig
            if (targetColor == replacementColor)
                return;

            if (bmp.GetPixel(x, y) != targetColor)
                return;

            //Set the pixel color
            bmp.SetPixel(x, y, replacementColor);

            //Call recursively on surrounding pixels
            FloodFill(bmp, x, y - 1, targetColor, replacementColor);
            FloodFill(bmp, x, y + 1, targetColor, replacementColor);
            FloodFill(bmp, x - 1, y, targetColor, replacementColor);
            FloodFill(bmp, x + 1, y, targetColor, replacementColor);

            return;
        }
    }
}
