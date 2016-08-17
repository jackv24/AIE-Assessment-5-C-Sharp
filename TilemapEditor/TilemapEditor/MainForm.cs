using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TilemapEditor
{
    public partial class MainForm : Form
    {
        Image currentTilemap;

        PixelPictureBox selectedTile;
        PixelPictureBox lastSelectedTile;

        Bitmap[,] tileBitmaps;
        PixelPictureBox[,] pictureBoxes;

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

                switch(selectedTool)
                {
                    case Tools.Pencil:
                        tool = "Pencil";
                        break;
                    case Tools.Eraser:
                        tool = "Eraser";
                        break;
                    case Tools.Fill:
                        tool = "Fill Bucket";
                        break;
                    case Tools.EyeDropper:
                        tool = "Eye Dropper";
                        break;
                }

                toolStripToolStatus.Text = "Selected Tool: " + tool;
            }

        }

        public MainForm()
        {
            InitializeComponent();

            //Load default values from settings
            tileWidthUpDown.Value = Properties.Settings.Default.TileWidth;
            tileHeightUpDown.Value = Properties.Settings.Default.TileHeight;

            //Set default colors
            PrimaryColor = Color.White;
            SecondaryColor = Color.Black;
        }

        //Form events
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        //Menu strip events
        //File Menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e) { CreateNew(); }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) { OpenFile(true); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attempt to close the application
            Application.Exit();
        }

        //File options buttons
        private void newButton_Click(object sender, EventArgs e) { CreateNew(); }

        private void openButton_Click(object sender, EventArgs e) { OpenFile(true); }

        private void refreshButton_Click(object sender, EventArgs e) { OpenFile(false); }

        //Methods for multiple controls
        //Resets all values
        private void CreateNew()
        {
            //Display a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to create a new tilemap?\nThis will erase the current tilemap.",
                Application.ProductName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Remove tilemap
                currentTilemap = null;

                //Remove pictureboxes
                while (tilemapPanel.Controls.Count > 0)
                    tilemapPanel.Controls[0].Dispose();

                tilePictureBox.Image = null;
            }
        }

        private void OpenFile(bool showDialog)
        {
            if (showDialog)
            {
                using (OpenFileDialog selectFile = new OpenFileDialog())
                {
                    selectFile.Filter = "Image Files (*.jpeg, *.png, *.jpg, *.gif)|*.jpeg;*.png;*.jpg;*.gif|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                    selectFile.Title = "Please select a tile map to edit.";

                    if (selectFile.ShowDialog() == DialogResult.OK)
                        //load tilemap
                        currentTilemap = Image.FromFile(selectFile.FileName);
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
                //Remove existing pictureboxes
                while (tilemapPanel.Controls.Count > 0)
                    tilemapPanel.Controls[0].Dispose();

                tilePictureBox.Image = null;

                //Calculate rows and columns
                int numRows = (int)Math.Round((float)currentTilemap.Height / tileHeight);
                int numColumns = (int)Math.Round((float)currentTilemap.Width / tileWidth);

                //Create new arrays at specified sizes
                tileBitmaps = new Bitmap[numColumns, numRows];
                pictureBoxes = new PixelPictureBox[numColumns, numRows];

                //Generate picturebox grid
                for (int i = 0; i < numColumns; i++)
                {
                    for (int j = 0; j < numRows; j++)
                    {
                        //Create new bitmap
                        Bitmap bmp = new Bitmap(tileWidth, tileHeight);
                        //Draw relevant pixels to bitmap
                        Graphics g = Graphics.FromImage(bmp);
                        g.DrawImage(currentTilemap, new Rectangle(0, 0, tileWidth, tileHeight), new Rectangle(i * tileWidth, j * tileHeight, tileWidth, tileHeight), GraphicsUnit.Pixel);
                        g.Dispose();

                        //Create new picturebox as child of tilemapPanel
                        PixelPictureBox box = new PixelPictureBox();
                        tilemapPanel.Controls.Add(box);
                        //Set properties
                        box.Location = new Point(i * tileWidth * zoomAmount, j * tileHeight * zoomAmount);
                        box.Size = new Size(tileWidth * zoomAmount, tileHeight * zoomAmount);
                        box.Image = bmp;
                        box.SizeMode = PictureBoxSizeMode.StretchImage;
                        box.BorderColor = Properties.Settings.Default.TileOutlineColor;

                        //Set picturebox event handlers
                        box.MouseEnter += new EventHandler(pictureBoxes_MouseEnter);
                        box.MouseLeave += new EventHandler(pictureBoxes_MouseLeave);
                        box.Click += new EventHandler(pictureBoxes_Click);

                        //Add to arrays
                        tileBitmaps[i, j] = bmp;
                        pictureBoxes[i, j] = box;
                    }
                }
            }
        }

        //Tileset Picture box event handlers
        private void pictureBoxes_MouseEnter(object sender, EventArgs e)
        {
            PixelPictureBox box = (PixelPictureBox)sender;

            if (box != selectedTile)
                box.BorderColor = Properties.Settings.Default.TileHoverOutlineColor;
        }

        private void pictureBoxes_MouseLeave(object sender, EventArgs e)
        {
            PixelPictureBox box = (PixelPictureBox)sender;

            if(box != selectedTile)
                box.BorderColor = Properties.Settings.Default.TileOutlineColor;
        }

        private void pictureBoxes_Click(object sender, EventArgs e)
        {
            PixelPictureBox box = (PixelPictureBox)sender;

            //Cache last tle and select new tile
            lastSelectedTile = selectedTile;
            selectedTile = box;

            //Deselect last tile
            if (lastSelectedTile != null)
            {
                lastSelectedTile.BorderColor = Properties.Settings.Default.TileOutlineColor;
            }

            //Set border color of selected tile
            selectedTile.BorderColor = Properties.Settings.Default.TileSelectedOutlineColor;

            //Display selected tile in editor
            tilePictureBox.Image = selectedTile.Image;
        }

        //Tile editor picturebox
        private Color primaryColor = Color.Black;
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                colorPrimaryBox.BackColor = primaryColor;
                AddSwatch(primaryColor);
            }
        }

        private Color secondaryColor = Color.Black;
        public Color SecondaryColor
        {
            get { return secondaryColor; }
            set
            {
                secondaryColor = value;
                colorSecondaryBox.BackColor = secondaryColor;
                AddSwatch(secondaryColor);
            }
        }

        List<Color> colorSwatches = new List<Color>();

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
                        float pixelRatio = (float)bmp.Width / box.Width;

                        int x = (int)Math.Ceiling(e.X * pixelRatio) - 1;
                        int y = (int)Math.Ceiling(e.Y * pixelRatio) - 1;

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
                            else if(selectedTool == Tools.Pencil)
                            {
                                //Color pixel
                                bmp.SetPixel(x, y, color);

                                //Update editor and tilemap images to the new bitmap
                                box.Image = bmp;
                                selectedTile.Image = bmp;
                            }
                        }
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
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                PrimaryColor = colorPicker.Color;
            }
        }

        private void colorSecondaryBox_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                SecondaryColor = colorPicker.Color;
            }
        }

        private void AddSwatch(Color color)
        {
            if (!colorSwatches.Contains(color))
            {
                colorSwatches.Add(color);
                int index = colorSwatches.Count - 1;

                int height = (int)Math.Floor((float)index / 3);
                for (int i = height; i > 0; i--)
                {
                    index -= 3;
                }

                //Create new picturebox as child of tilemapPanel
                PictureBox box = new PictureBox();
                colorSwatchesPanel.Controls.Add(box);
                box.Location = new Point(index * 22, height * 22);
                box.Size = new Size(20, 20);
                box.BackColor = color;
                box.MouseClick += new MouseEventHandler(colorSwatchBox_Click);
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
            Color temp = PrimaryColor;
            PrimaryColor = SecondaryColor;
            SecondaryColor = temp;
        }

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
    }
}
