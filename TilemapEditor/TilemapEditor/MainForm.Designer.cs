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
            this.toolsBox = new System.Windows.Forms.GroupBox();
            this.toolColorPickerButton = new System.Windows.Forms.Button();
            this.toolFillButton = new System.Windows.Forms.Button();
            this.toolEraserButton = new System.Windows.Forms.Button();
            this.toolPencilButton = new System.Windows.Forms.Button();
            this.helpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.colorSwatchesPanel = new System.Windows.Forms.Panel();
            this.colorPrimaryBox = new System.Windows.Forms.PictureBox();
            this.colorSecondaryBox = new System.Windows.Forms.PictureBox();
            this.switchColoursButton = new System.Windows.Forms.Button();
            this.colourBox = new System.Windows.Forms.GroupBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.toolStripToolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tileSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tileEditorBox = new System.Windows.Forms.GroupBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilePictureBox = new TilemapEditor.PixelPictureBox();
            this.menuStrip1.SuspendLayout();
            this.tilemapOptionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthUpDown)).BeginInit();
            this.fileOptionsBox.SuspendLayout();
            this.tilemapBox.SuspendLayout();
            this.toolsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPrimaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSecondaryBox)).BeginInit();
            this.colourBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileSplitContainer)).BeginInit();
            this.tileSplitContainer.Panel1.SuspendLayout();
            this.tileSplitContainer.Panel2.SuspendLayout();
            this.tileSplitContainer.SuspendLayout();
            this.tileEditorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
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
            this.refreshButton.Text = "Reload";
            this.helpTooltip.SetToolTip(this.refreshButton, "Updates the tilemap with the new values");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // tileHeightUpDown
            // 
            this.tileHeightUpDown.Location = new System.Drawing.Point(153, 42);
            this.tileHeightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tileHeightUpDown.Name = "tileHeightUpDown";
            this.tileHeightUpDown.Size = new System.Drawing.Size(40, 20);
            this.tileHeightUpDown.TabIndex = 7;
            this.tileHeightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.tileWidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tileWidthUpDown.Name = "tileWidthUpDown";
            this.tileWidthUpDown.Size = new System.Drawing.Size(40, 20);
            this.tileWidthUpDown.TabIndex = 5;
            this.tileWidthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
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
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.tilemapBox.Controls.Add(this.tilemapPanel);
            this.tilemapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilemapBox.Location = new System.Drawing.Point(0, 0);
            this.tilemapBox.Name = "tilemapBox";
            this.tilemapBox.Padding = new System.Windows.Forms.Padding(5);
            this.tilemapBox.Size = new System.Drawing.Size(400, 500);
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
            this.tilemapPanel.Size = new System.Drawing.Size(390, 477);
            this.tilemapPanel.TabIndex = 0;
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
            // toolColorPickerButton
            // 
            this.toolColorPickerButton.Image = global::TilemapEditor.Properties.Resources.eyedropper;
            this.toolColorPickerButton.Location = new System.Drawing.Point(43, 56);
            this.toolColorPickerButton.Name = "toolColorPickerButton";
            this.toolColorPickerButton.Size = new System.Drawing.Size(32, 32);
            this.toolColorPickerButton.TabIndex = 3;
            this.helpTooltip.SetToolTip(this.toolColorPickerButton, "Eye dropper (ALT + Left/Right)");
            this.toolColorPickerButton.UseVisualStyleBackColor = true;
            this.toolColorPickerButton.Click += new System.EventHandler(this.toolColorPickerButton_Click);
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
            this.toolFillButton.Click += new System.EventHandler(this.toolFillButton_Click);
            // 
            // toolEraserButton
            // 
            this.toolEraserButton.Image = global::TilemapEditor.Properties.Resources.eraser;
            this.toolEraserButton.Location = new System.Drawing.Point(43, 20);
            this.toolEraserButton.Name = "toolEraserButton";
            this.toolEraserButton.Size = new System.Drawing.Size(32, 32);
            this.toolEraserButton.TabIndex = 1;
            this.helpTooltip.SetToolTip(this.toolEraserButton, "Eraser");
            this.toolEraserButton.UseVisualStyleBackColor = true;
            this.toolEraserButton.Click += new System.EventHandler(this.toolEraserButton_Click);
            // 
            // toolPencilButton
            // 
            this.toolPencilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolPencilButton.Image = global::TilemapEditor.Properties.Resources.pencil;
            this.toolPencilButton.Location = new System.Drawing.Point(7, 20);
            this.toolPencilButton.Name = "toolPencilButton";
            this.toolPencilButton.Size = new System.Drawing.Size(32, 32);
            this.toolPencilButton.TabIndex = 0;
            this.helpTooltip.SetToolTip(this.toolPencilButton, "Pencil (left/right click)");
            this.toolPencilButton.UseVisualStyleBackColor = true;
            this.toolPencilButton.Click += new System.EventHandler(this.toolPencilButton_Click);
            // 
            // colorSwatchesPanel
            // 
            this.colorSwatchesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colorSwatchesPanel.Location = new System.Drawing.Point(7, 82);
            this.colorSwatchesPanel.Name = "colorSwatchesPanel";
            this.colorSwatchesPanel.Size = new System.Drawing.Size(66, 294);
            this.colorSwatchesPanel.TabIndex = 1;
            this.helpTooltip.SetToolTip(this.colorSwatchesPanel, "Click to use swatch");
            // 
            // colorPrimaryBox
            // 
            this.colorPrimaryBox.BackColor = System.Drawing.Color.Black;
            this.colorPrimaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPrimaryBox.Location = new System.Drawing.Point(7, 36);
            this.colorPrimaryBox.Name = "colorPrimaryBox";
            this.colorPrimaryBox.Size = new System.Drawing.Size(40, 40);
            this.colorPrimaryBox.TabIndex = 0;
            this.colorPrimaryBox.TabStop = false;
            this.helpTooltip.SetToolTip(this.colorPrimaryBox, "Primary color (left click)");
            this.colorPrimaryBox.Click += new System.EventHandler(this.colorPrimaryBox_Click);
            // 
            // colorSecondaryBox
            // 
            this.colorSecondaryBox.BackColor = System.Drawing.Color.DimGray;
            this.colorSecondaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSecondaryBox.Location = new System.Drawing.Point(33, 19);
            this.colorSecondaryBox.Name = "colorSecondaryBox";
            this.colorSecondaryBox.Size = new System.Drawing.Size(40, 40);
            this.colorSecondaryBox.TabIndex = 2;
            this.colorSecondaryBox.TabStop = false;
            this.helpTooltip.SetToolTip(this.colorSecondaryBox, "Secondary color (right click)");
            this.colorSecondaryBox.Click += new System.EventHandler(this.colorSecondaryBox_Click);
            // 
            // switchColoursButton
            // 
            this.switchColoursButton.Location = new System.Drawing.Point(50, 60);
            this.switchColoursButton.Name = "switchColoursButton";
            this.switchColoursButton.Size = new System.Drawing.Size(18, 18);
            this.switchColoursButton.TabIndex = 3;
            this.switchColoursButton.Text = "<";
            this.helpTooltip.SetToolTip(this.switchColoursButton, "Switch colours (X)");
            this.switchColoursButton.UseVisualStyleBackColor = true;
            this.switchColoursButton.Click += new System.EventHandler(this.switchColoursButton_Click);
            // 
            // colourBox
            // 
            this.colourBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colourBox.Controls.Add(this.switchColoursButton);
            this.colourBox.Controls.Add(this.colorPrimaryBox);
            this.colourBox.Controls.Add(this.colorSecondaryBox);
            this.colourBox.Controls.Add(this.colorSwatchesPanel);
            this.colourBox.Location = new System.Drawing.Point(899, 152);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(79, 382);
            this.colourBox.TabIndex = 6;
            this.colourBox.TabStop = false;
            this.colourBox.Text = "Colours";
            // 
            // colorPicker
            // 
            this.colorPicker.AnyColor = true;
            this.colorPicker.FullOpen = true;
            this.colorPicker.SolidColorOnly = true;
            // 
            // toolStripToolStatus
            // 
            this.toolStripToolStatus.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripToolStatus.Name = "toolStripToolStatus";
            this.toolStripToolStatus.Size = new System.Drawing.Size(115, 17);
            this.toolStripToolStatus.Text = "Selected Tool: Pencil";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripToolStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tileSplitContainer
            // 
            this.tileSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSplitContainer.Location = new System.Drawing.Point(219, 28);
            this.tileSplitContainer.Name = "tileSplitContainer";
            // 
            // tileSplitContainer.Panel1
            // 
            this.tileSplitContainer.Panel1.Controls.Add(this.tilemapBox);
            // 
            // tileSplitContainer.Panel2
            // 
            this.tileSplitContainer.Panel2.Controls.Add(this.tileEditorBox);
            this.tileSplitContainer.Size = new System.Drawing.Size(674, 500);
            this.tileSplitContainer.SplitterDistance = 400;
            this.tileSplitContainer.TabIndex = 8;
            // 
            // tileEditorBox
            // 
            this.tileEditorBox.Controls.Add(this.tilePictureBox);
            this.tileEditorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileEditorBox.Location = new System.Drawing.Point(0, 0);
            this.tileEditorBox.Name = "tileEditorBox";
            this.tileEditorBox.Padding = new System.Windows.Forms.Padding(5);
            this.tileEditorBox.Size = new System.Drawing.Size(270, 500);
            this.tileEditorBox.TabIndex = 4;
            this.tileEditorBox.TabStop = false;
            this.tileEditorBox.Text = "Tile Editor";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // tilePictureBox
            // 
            this.tilePictureBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tilePictureBox.BorderColor = System.Drawing.Color.Empty;
            this.tilePictureBox.BorderWidth = 1;
            this.tilePictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tilePictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tilePictureBox.Image = null;
            this.tilePictureBox.KeepAspect = true;
            this.tilePictureBox.Location = new System.Drawing.Point(5, 18);
            this.tilePictureBox.Name = "tilePictureBox";
            this.tilePictureBox.Size = new System.Drawing.Size(260, 260);
            this.tilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tilePictureBox.TabIndex = 6;
            this.tilePictureBox.TabStop = false;
            this.tilePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tilePictureBox_MouseDown);
            this.tilePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tilePictureBox_MouseMove);
            this.tilePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tilePictureBox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tileSplitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.toolsBox);
            this.Controls.Add(this.fileOptionsBox);
            this.Controls.Add(this.tilemapOptionsBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "MainForm";
            this.Text = "Tilemap Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tilemapOptionsBox.ResumeLayout(false);
            this.tilemapOptionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthUpDown)).EndInit();
            this.fileOptionsBox.ResumeLayout(false);
            this.tilemapBox.ResumeLayout(false);
            this.toolsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPrimaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSecondaryBox)).EndInit();
            this.colourBox.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tileSplitContainer.Panel1.ResumeLayout(false);
            this.tileSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tileSplitContainer)).EndInit();
            this.tileSplitContainer.ResumeLayout(false);
            this.tileEditorBox.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox colorPrimaryBox;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Panel colorSwatchesPanel;
        private System.Windows.Forms.PictureBox colorSecondaryBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripToolStatus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button switchColoursButton;
        private System.Windows.Forms.SplitContainer tileSplitContainer;
        private System.Windows.Forms.GroupBox tileEditorBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}

