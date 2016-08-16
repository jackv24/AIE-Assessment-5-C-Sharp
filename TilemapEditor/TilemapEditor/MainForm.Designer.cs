namespace TilemapEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilemapOptionsBox = new System.Windows.Forms.GroupBox();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.refreshButton = new System.Windows.Forms.Button();
            this.tileHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.tileHeightLabel = new System.Windows.Forms.Label();
            this.tileWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.tileWidthLabel = new System.Windows.Forms.Label();
            this.fileOptionsBox = new System.Windows.Forms.GroupBox();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.tilemapBox = new System.Windows.Forms.GroupBox();
            this.tilemapPanel = new System.Windows.Forms.Panel();
            this.tileEditorBox = new System.Windows.Forms.GroupBox();
            this.toolsBox = new System.Windows.Forms.GroupBox();
            this.helpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.colourBox = new System.Windows.Forms.GroupBox();
            this.toolColorPickerButton = new System.Windows.Forms.Button();
            this.toolFillButton = new System.Windows.Forms.Button();
            this.toolEraserButton = new System.Windows.Forms.Button();
            this.toolPencilButton = new System.Windows.Forms.Button();
            this.tilePictureBox = new TilemapEditor.PixelPictureBox();
            this.menuStrip1.SuspendLayout();
            this.tilemapOptionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthUpDown)).BeginInit();
            this.fileOptionsBox.SuspendLayout();
            this.tilemapBox.SuspendLayout();
            this.tileEditorBox.SuspendLayout();
            this.toolsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tilemapOptionsBox
            // 
            this.tilemapOptionsBox.Controls.Add(this.zoomLabel);
            this.tilemapOptionsBox.Controls.Add(this.zoomTrackBar);
            this.tilemapOptionsBox.Controls.Add(this.refreshButton);
            this.tilemapOptionsBox.Controls.Add(this.tileHeightUpDown);
            this.tilemapOptionsBox.Controls.Add(this.tileHeightLabel);
            this.tilemapOptionsBox.Controls.Add(this.tileWidthUpDown);
            this.tilemapOptionsBox.Controls.Add(this.tileWidthLabel);
            this.tilemapOptionsBox.Location = new System.Drawing.Point(13, 28);
            this.tilemapOptionsBox.Name = "tilemapOptionsBox";
            this.tilemapOptionsBox.Size = new System.Drawing.Size(200, 154);
            this.tilemapOptionsBox.TabIndex = 1;
            this.tilemapOptionsBox.TabStop = false;
            this.tilemapOptionsBox.Text = "Tilemap Options";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomLabel.Location = new System.Drawing.Point(6, 70);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(94, 16);
            this.zoomLabel.TabIndex = 10;
            this.zoomLabel.Text = "Preview Zoom";
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Location = new System.Drawing.Point(104, 68);
            this.zoomTrackBar.Maximum = 5;
            this.zoomTrackBar.Minimum = 1;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(89, 45);
            this.zoomTrackBar.TabIndex = 9;
            this.zoomTrackBar.Value = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(119, 119);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.helpTooltip.SetToolTip(this.refreshButton, "Updates the tilemap with the new values");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // tileHeightUpDown
            // 
            this.tileHeightUpDown.Location = new System.Drawing.Point(153, 42);
            this.tileHeightUpDown.Name = "tileHeightUpDown";
            this.tileHeightUpDown.Size = new System.Drawing.Size(40, 20);
            this.tileHeightUpDown.TabIndex = 7;
            // 
            // tileHeightLabel
            // 
            this.tileHeightLabel.AutoSize = true;
            this.tileHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileHeightLabel.Location = new System.Drawing.Point(6, 42);
            this.tileHeightLabel.Name = "tileHeightLabel";
            this.tileHeightLabel.Size = new System.Drawing.Size(70, 16);
            this.tileHeightLabel.TabIndex = 6;
            this.tileHeightLabel.Text = "Tile height";
            // 
            // tileWidthUpDown
            // 
            this.tileWidthUpDown.Location = new System.Drawing.Point(153, 16);
            this.tileWidthUpDown.Name = "tileWidthUpDown";
            this.tileWidthUpDown.Size = new System.Drawing.Size(40, 20);
            this.tileWidthUpDown.TabIndex = 5;
            // 
            // tileWidthLabel
            // 
            this.tileWidthLabel.AutoSize = true;
            this.tileWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileWidthLabel.Location = new System.Drawing.Point(6, 16);
            this.tileWidthLabel.Name = "tileWidthLabel";
            this.tileWidthLabel.Size = new System.Drawing.Size(64, 16);
            this.tileWidthLabel.TabIndex = 4;
            this.tileWidthLabel.Text = "Tile width";
            // 
            // fileOptionsBox
            // 
            this.fileOptionsBox.Controls.Add(this.saveAsButton);
            this.fileOptionsBox.Controls.Add(this.openButton);
            this.fileOptionsBox.Controls.Add(this.saveButton);
            this.fileOptionsBox.Controls.Add(this.newButton);
            this.fileOptionsBox.Location = new System.Drawing.Point(14, 188);
            this.fileOptionsBox.Name = "fileOptionsBox";
            this.fileOptionsBox.Size = new System.Drawing.Size(200, 80);
            this.fileOptionsBox.TabIndex = 2;
            this.fileOptionsBox.TabStop = false;
            this.fileOptionsBox.Text = "File Options";
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(103, 49);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(90, 23);
            this.saveAsButton.TabIndex = 3;
            this.saveAsButton.Text = "Save As";
            this.helpTooltip.SetToolTip(this.saveAsButton, "Save tile map as a new file");
            this.saveAsButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(7, 49);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(90, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open Existing";
            this.helpTooltip.SetToolTip(this.openButton, "Open an existing tile map");
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(103, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.helpTooltip.SetToolTip(this.saveButton, "Save tile map (overwriting previous file)");
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(7, 20);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(90, 23);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Create New";
            this.helpTooltip.SetToolTip(this.newButton, "Start from scratch");
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // tilemapBox
            // 
            this.tilemapBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tilemapBox.Controls.Add(this.tilemapPanel);
            this.tilemapBox.Location = new System.Drawing.Point(220, 28);
            this.tilemapBox.Name = "tilemapBox";
            this.tilemapBox.Padding = new System.Windows.Forms.Padding(5);
            this.tilemapBox.Size = new System.Drawing.Size(270, 407);
            this.tilemapBox.TabIndex = 3;
            this.tilemapBox.TabStop = false;
            this.tilemapBox.Text = "Tilemap";
            // 
            // tilemapPanel
            // 
            this.tilemapPanel.AutoScroll = true;
            this.tilemapPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tilemapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilemapPanel.Location = new System.Drawing.Point(5, 18);
            this.tilemapPanel.Name = "tilemapPanel";
            this.tilemapPanel.Size = new System.Drawing.Size(260, 384);
            this.tilemapPanel.TabIndex = 0;
            // 
            // tileEditorBox
            // 
            this.tileEditorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tileEditorBox.Controls.Add(this.tilePictureBox);
            this.tileEditorBox.Location = new System.Drawing.Point(497, 28);
            this.tileEditorBox.Name = "tileEditorBox";
            this.tileEditorBox.Padding = new System.Windows.Forms.Padding(5);
            this.tileEditorBox.Size = new System.Drawing.Size(395, 407);
            this.tileEditorBox.TabIndex = 4;
            this.tileEditorBox.TabStop = false;
            this.tileEditorBox.Text = "Tile Editor";
            // 
            // toolsBox
            // 
            this.toolsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsBox.Controls.Add(this.toolColorPickerButton);
            this.toolsBox.Controls.Add(this.toolFillButton);
            this.toolsBox.Controls.Add(this.toolEraserButton);
            this.toolsBox.Controls.Add(this.toolPencilButton);
            this.toolsBox.Location = new System.Drawing.Point(899, 28);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(79, 118);
            this.toolsBox.TabIndex = 5;
            this.toolsBox.TabStop = false;
            this.toolsBox.Text = "Tools";
            // 
            // colourBox
            // 
            this.colourBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colourBox.Location = new System.Drawing.Point(899, 152);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(79, 283);
            this.colourBox.TabIndex = 6;
            this.colourBox.TabStop = false;
            this.colourBox.Text = "Colours";
            // 
            // toolColorPickerButton
            // 
            this.toolColorPickerButton.Image = global::TilemapEditor.Properties.Resources.eyedropper;
            this.toolColorPickerButton.Location = new System.Drawing.Point(43, 56);
            this.toolColorPickerButton.Name = "toolColorPickerButton";
            this.toolColorPickerButton.Size = new System.Drawing.Size(32, 32);
            this.toolColorPickerButton.TabIndex = 3;
            this.helpTooltip.SetToolTip(this.toolColorPickerButton, "Samples a pixel colour");
            this.toolColorPickerButton.UseVisualStyleBackColor = true;
            // 
            // toolFillButton
            // 
            this.toolFillButton.Image = global::TilemapEditor.Properties.Resources.fill;
            this.toolFillButton.Location = new System.Drawing.Point(7, 56);
            this.toolFillButton.Name = "toolFillButton";
            this.toolFillButton.Size = new System.Drawing.Size(32, 32);
            this.toolFillButton.TabIndex = 2;
            this.helpTooltip.SetToolTip(this.toolFillButton, "Fill a large area of pixels");
            this.toolFillButton.UseVisualStyleBackColor = true;
            // 
            // toolEraserButton
            // 
            this.toolEraserButton.Image = global::TilemapEditor.Properties.Resources.eraser;
            this.toolEraserButton.Location = new System.Drawing.Point(43, 20);
            this.toolEraserButton.Name = "toolEraserButton";
            this.toolEraserButton.Size = new System.Drawing.Size(32, 32);
            this.toolEraserButton.TabIndex = 1;
            this.helpTooltip.SetToolTip(this.toolEraserButton, "Erase pixels");
            this.toolEraserButton.UseVisualStyleBackColor = true;
            // 
            // toolPencilButton
            // 
            this.toolPencilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolPencilButton.Image = global::TilemapEditor.Properties.Resources.pencil;
            this.toolPencilButton.Location = new System.Drawing.Point(7, 20);
            this.toolPencilButton.Name = "toolPencilButton";
            this.toolPencilButton.Size = new System.Drawing.Size(32, 32);
            this.toolPencilButton.TabIndex = 0;
            this.helpTooltip.SetToolTip(this.toolPencilButton, "Edit individual pixels");
            this.toolPencilButton.UseVisualStyleBackColor = true;
            // 
            // tilePictureBox
            // 
            this.tilePictureBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tilePictureBox.Location = new System.Drawing.Point(3, 16);
            this.tilePictureBox.Name = "tilePictureBox";
            this.tilePictureBox.Size = new System.Drawing.Size(389, 391);
            this.tilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tilePictureBox.TabIndex = 6;
            this.tilePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 447);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.toolsBox);
            this.Controls.Add(this.tileEditorBox);
            this.Controls.Add(this.tilemapBox);
            this.Controls.Add(this.fileOptionsBox);
            this.Controls.Add(this.tilemapOptionsBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "MainForm";
            this.Text = "Tilemap Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tilemapOptionsBox.ResumeLayout(false);
            this.tilemapOptionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthUpDown)).EndInit();
            this.fileOptionsBox.ResumeLayout(false);
            this.tilemapBox.ResumeLayout(false);
            this.tileEditorBox.ResumeLayout(false);
            this.toolsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox tilemapOptionsBox;
        private System.Windows.Forms.NumericUpDown tileHeightUpDown;
        private System.Windows.Forms.Label tileHeightLabel;
        private System.Windows.Forms.NumericUpDown tileWidthUpDown;
        private System.Windows.Forms.Label tileWidthLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox fileOptionsBox;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.GroupBox tilemapBox;
        private System.Windows.Forms.GroupBox tileEditorBox;
        private System.Windows.Forms.GroupBox toolsBox;
        private System.Windows.Forms.Button toolFillButton;
        private System.Windows.Forms.Button toolEraserButton;
        private System.Windows.Forms.Button toolPencilButton;
        private System.Windows.Forms.Panel tilemapPanel;
        private System.Windows.Forms.ToolTip helpTooltip;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private PixelPictureBox tilePictureBox;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.GroupBox colourBox;
        private System.Windows.Forms.Button toolColorPickerButton;
    }
}

