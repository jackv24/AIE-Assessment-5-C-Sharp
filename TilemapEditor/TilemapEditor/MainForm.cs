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

        public MainForm()
        {
            InitializeComponent();

            //Load default values from settings
            tileWidthUpDown.Value = Properties.Settings.Default.TileWidth;
            tileHeightUpDown.Value = Properties.Settings.Default.TileHeight;
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

                        //Set picturebox event handlers
                        box.Paint += new PaintEventHandler(pictureBoxes_Paint);
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
        private void pictureBoxes_Paint(object sender, PaintEventArgs e)
        {
            PixelPictureBox box = (PixelPictureBox)sender;

            //Set default color
            if (box.Tag == null)
                box.Tag = Properties.Settings.Default.TileOutlineColor;

            if (box == selectedTile)
                box.Tag = Properties.Settings.Default.TileSelectedOutlineColor;

            //Draw border that is the color of the tag
            ControlPaint.DrawBorder(e.Graphics, box.ClientRectangle, (Color)box.Tag, ButtonBorderStyle.Solid);
        }

        private void pictureBoxes_MouseEnter(object sender, EventArgs e)
        {
            PixelPictureBox box = (PixelPictureBox)sender;

            box.Tag = Properties.Settings.Default.TileHoverOutlineColor;
            box.Refresh();
        }

        private void pictureBoxes_MouseLeave(object sender, EventArgs e)
        {
            PixelPictureBox box = (PixelPictureBox)sender;

            box.Tag = Properties.Settings.Default.TileOutlineColor;
            box.Refresh();
        }

        private void pictureBoxes_Click(object sender, EventArgs e)
        {
            PixelPictureBox box = (PixelPictureBox)sender;

            //Cache last tle and select new tile
            lastSelectedTile = selectedTile;
            selectedTile = box;

            if (lastSelectedTile != null)
            {
                //Clear last tile
                lastSelectedTile.Tag = Properties.Settings.Default.TileOutlineColor;
                lastSelectedTile.Refresh();
            }
            box.Refresh();

            tilePictureBox.Image = selectedTile.Image;
        }
    }
}
