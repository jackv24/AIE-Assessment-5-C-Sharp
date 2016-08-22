namespace TilemapEditor
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.tileOutlineColorLabel = new System.Windows.Forms.Label();
            this.tileOutlineColorBox = new System.Windows.Forms.PictureBox();
            this.selectedTileColorBox = new System.Windows.Forms.PictureBox();
            this.selectedTileColorLabel = new System.Windows.Forms.Label();
            this.tileHoverColorBox = new System.Windows.Forms.PictureBox();
            this.tileHoverColorLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.backgroundColorBox = new System.Windows.Forms.PictureBox();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tileOutlineColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedTileColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHoverColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tileOutlineColorLabel
            // 
            this.tileOutlineColorLabel.AutoSize = true;
            this.tileOutlineColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileOutlineColorLabel.Location = new System.Drawing.Point(12, 9);
            this.tileOutlineColorLabel.Name = "tileOutlineColorLabel";
            this.tileOutlineColorLabel.Size = new System.Drawing.Size(106, 16);
            this.tileOutlineColorLabel.TabIndex = 5;
            this.tileOutlineColorLabel.Text = "Tile outline color";
            // 
            // tileOutlineColorBox
            // 
            this.tileOutlineColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tileOutlineColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tileOutlineColorBox.Location = new System.Drawing.Point(242, 9);
            this.tileOutlineColorBox.Name = "tileOutlineColorBox";
            this.tileOutlineColorBox.Size = new System.Drawing.Size(30, 30);
            this.tileOutlineColorBox.TabIndex = 6;
            this.tileOutlineColorBox.TabStop = false;
            this.tileOutlineColorBox.Click += new System.EventHandler(this.tileOutlineColorBox_Click);
            // 
            // selectedTileColorBox
            // 
            this.selectedTileColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTileColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedTileColorBox.Location = new System.Drawing.Point(242, 45);
            this.selectedTileColorBox.Name = "selectedTileColorBox";
            this.selectedTileColorBox.Size = new System.Drawing.Size(30, 30);
            this.selectedTileColorBox.TabIndex = 8;
            this.selectedTileColorBox.TabStop = false;
            this.selectedTileColorBox.Click += new System.EventHandler(this.selectedTileColorBox_Click);
            // 
            // selectedTileColorLabel
            // 
            this.selectedTileColorLabel.AutoSize = true;
            this.selectedTileColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTileColorLabel.Location = new System.Drawing.Point(12, 45);
            this.selectedTileColorLabel.Name = "selectedTileColorLabel";
            this.selectedTileColorLabel.Size = new System.Drawing.Size(115, 16);
            this.selectedTileColorLabel.TabIndex = 7;
            this.selectedTileColorLabel.Text = "Selected tile color";
            // 
            // tileHoverColorBox
            // 
            this.tileHoverColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tileHoverColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tileHoverColorBox.Location = new System.Drawing.Point(242, 81);
            this.tileHoverColorBox.Name = "tileHoverColorBox";
            this.tileHoverColorBox.Size = new System.Drawing.Size(30, 30);
            this.tileHoverColorBox.TabIndex = 10;
            this.tileHoverColorBox.TabStop = false;
            this.tileHoverColorBox.Click += new System.EventHandler(this.tileHoverColorBox_Click);
            // 
            // tileHoverColorLabel
            // 
            this.tileHoverColorLabel.AutoSize = true;
            this.tileHoverColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileHoverColorLabel.Location = new System.Drawing.Point(12, 81);
            this.tileHoverColorLabel.Name = "tileHoverColorLabel";
            this.tileHoverColorLabel.Size = new System.Drawing.Size(104, 16);
            this.tileHoverColorLabel.TabIndex = 9;
            this.tileHoverColorLabel.Text = "Tile hover  color";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(116, 176);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(35, 176);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.AnyColor = true;
            this.colorPicker.FullOpen = true;
            this.colorPicker.SolidColorOnly = true;
            // 
            // backgroundColorBox
            // 
            this.backgroundColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundColorBox.Location = new System.Drawing.Point(242, 117);
            this.backgroundColorBox.Name = "backgroundColorBox";
            this.backgroundColorBox.Size = new System.Drawing.Size(30, 30);
            this.backgroundColorBox.TabIndex = 14;
            this.backgroundColorBox.TabStop = false;
            this.backgroundColorBox.Click += new System.EventHandler(this.backgroundColorBox_Click);
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundColorLabel.Location = new System.Drawing.Point(12, 117);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(114, 16);
            this.backgroundColorLabel.TabIndex = 13;
            this.backgroundColorLabel.Text = "Background color";
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(197, 176);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Default";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Preferences
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.backgroundColorBox);
            this.Controls.Add(this.backgroundColorLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.tileHoverColorBox);
            this.Controls.Add(this.tileHoverColorLabel);
            this.Controls.Add(this.selectedTileColorBox);
            this.Controls.Add(this.selectedTileColorLabel);
            this.Controls.Add(this.tileOutlineColorBox);
            this.Controls.Add(this.tileOutlineColorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(288, 232);
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tileOutlineColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedTileColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHoverColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tileOutlineColorLabel;
        private System.Windows.Forms.PictureBox tileOutlineColorBox;
        private System.Windows.Forms.PictureBox selectedTileColorBox;
        private System.Windows.Forms.Label selectedTileColorLabel;
        private System.Windows.Forms.PictureBox tileHoverColorBox;
        private System.Windows.Forms.Label tileHoverColorLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.PictureBox backgroundColorBox;
        private System.Windows.Forms.Label backgroundColorLabel;
        private System.Windows.Forms.Button resetButton;
    }
}