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
    public partial class CreateForm : Form
    {
        public MainForm main;

        public CreateForm()
        {
            InitializeComponent();

            //Load default values from settings
            tileWidthUpDown.Value = Properties.Settings.Default.TileWidth;
            tileHeightUpDown.Value = Properties.Settings.Default.TileHeight;
            numColumnsUpDown.Value = Properties.Settings.Default.NewTilemapWidth;
            numRowsUpDown.Value = Properties.Settings.Default.NewTilemapHeight;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Remove tilemap
            if (main.currentTilemap != null)
            {
                main.currentTilemap.Dispose();
                main.currentTilemap = null;
            }

            //Cache values
            int tileWidth = (int)tileWidthUpDown.Value;
            int tileHeight = (int)tileHeightUpDown.Value;
            int numColumns = (int)numColumnsUpDown.Value;
            int numRows = (int)numRowsUpDown.Value;

            //Calculate widths and height in pixels of new image
            int width = tileWidth * numColumns;
            int height = tileHeight * numRows;

            if (width > 0 && height > 0)
            {
                //Create new image
                main.currentTilemap = new Bitmap(width, height);

                //Load image as tilemap
                main.OpenFile(false);

                //Close this form
                Close();
            }
            else
                MessageBox.Show(
                "Tilemap values can not be zero!",
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
