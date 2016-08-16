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
        public MainForm()
        {
            InitializeComponent();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e) { OpenFile(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attempt to close the application
            Application.Exit();
        }

        //File options buttons
        private void newButton_Click(object sender, EventArgs e) { CreateNew(); }

        private void openButton_Click(object sender, EventArgs e) { OpenFile(); }

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
                tilemapPictureBox.Image = null;
            }
        }

        private void OpenFile()
        {
            using (OpenFileDialog selectFile = new OpenFileDialog())
            {
                if (selectFile.ShowDialog() == DialogResult.OK)
                {
                    tilemapPictureBox.ImageLocation = selectFile.FileName;
                }
            }
        }
    }
}
