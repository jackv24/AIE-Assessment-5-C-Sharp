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
    public partial class Preferences : Form
    {
        public MainForm main;

        bool unsavedChanges = false;

        public Preferences()
        {
            InitializeComponent();

            LoadPrefs();
        }

        private void LoadPrefs()
        {
            //Load preferences into color boxes
            tileOutlineColorBox.BackColor = Properties.Settings.Default.TileOutlineColor;
            selectedTileColorBox.BackColor = Properties.Settings.Default.TileSelectedOutlineColor;
            tileHoverColorBox.BackColor = Properties.Settings.Default.TileHoverOutlineColor;
            backgroundColorBox.BackColor = Properties.Settings.Default.BackgroundColor;
        }

        //Editing settings
        private void tileOutlineColorBox_Click(object sender, EventArgs e)
        {
            colorPicker.Color = Properties.Settings.Default.TileOutlineColor;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPicker.Color;

                tileOutlineColorBox.BackColor = color;
                Properties.Settings.Default.TileOutlineColor = color;

                unsavedChanges = true;
            }
        }

        private void selectedTileColorBox_Click(object sender, EventArgs e)
        {
            colorPicker.Color = Properties.Settings.Default.TileSelectedOutlineColor;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPicker.Color;

                selectedTileColorBox.BackColor = color;
                Properties.Settings.Default.TileSelectedOutlineColor = color;

                unsavedChanges = true;
            }
        }

        private void tileHoverColorBox_Click(object sender, EventArgs e)
        {
            colorPicker.Color = Properties.Settings.Default.TileHoverOutlineColor;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPicker.Color;

                tileHoverColorBox.BackColor = color;
                Properties.Settings.Default.TileHoverOutlineColor = color;

                unsavedChanges = true;
            }
        }

        private void backgroundColorBox_Click(object sender, EventArgs e)
        {
            colorPicker.Color = Properties.Settings.Default.BackgroundColor;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPicker.Color;

                backgroundColorBox.BackColor = color;
                Properties.Settings.Default.BackgroundColor = color;

                unsavedChanges = true;
            }
        }

        //Applying settings
        private void applyButton_Click(object sender, EventArgs e)
        {
            main.LoadPrefs();

            unsavedChanges = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Okay button applies first
            applyButton_Click(sender, e);

            //Close this form
            Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset and reload preferences
            Properties.Settings.Default.Reset();
            LoadPrefs();
            main.LoadPrefs();

            unsavedChanges = false;
        }

        private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Display confirmation if there are unsaved changes
            if (unsavedChanges)
            {
                //Display a confirmation dialog
                DialogResult result = MessageBox.Show(
                        "Do you want to save changes?",
                        "Preferences",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                    e.Cancel = true;
                else if (result == DialogResult.Yes)
                    applyButton_Click(sender, e);
                else if (result == DialogResult.No)
                    resetButton_Click(sender, e);
            }
        }
    }
}
