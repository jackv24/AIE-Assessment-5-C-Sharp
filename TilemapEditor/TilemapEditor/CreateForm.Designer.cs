namespace TilemapEditor
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.tilemapOptionsBox = new System.Windows.Forms.GroupBox();
            this.numRowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.numRowsLabel = new System.Windows.Forms.Label();
            this.numColumnsUpDown = new System.Windows.Forms.NumericUpDown();
            this.numColumnsLabel = new System.Windows.Forms.Label();
            this.tileHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.tileHeightLabel = new System.Windows.Forms.Label();
            this.tileWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.tileWidthLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.tilemapOptionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tilemapOptionsBox
            // 
            this.tilemapOptionsBox.Controls.Add(this.numRowsUpDown);
            this.tilemapOptionsBox.Controls.Add(this.numRowsLabel);
            this.tilemapOptionsBox.Controls.Add(this.numColumnsUpDown);
            this.tilemapOptionsBox.Controls.Add(this.numColumnsLabel);
            this.tilemapOptionsBox.Controls.Add(this.tileHeightUpDown);
            this.tilemapOptionsBox.Controls.Add(this.tileHeightLabel);
            this.tilemapOptionsBox.Controls.Add(this.tileWidthUpDown);
            this.tilemapOptionsBox.Controls.Add(this.tileWidthLabel);
            this.tilemapOptionsBox.Location = new System.Drawing.Point(12, 12);
            this.tilemapOptionsBox.Name = "tilemapOptionsBox";
            this.tilemapOptionsBox.Size = new System.Drawing.Size(210, 126);
            this.tilemapOptionsBox.TabIndex = 2;
            this.tilemapOptionsBox.TabStop = false;
            this.tilemapOptionsBox.Text = "Tilemap Options";
            // 
            // numRowsUpDown
            // 
            this.numRowsUpDown.Location = new System.Drawing.Point(153, 94);
            this.numRowsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRowsUpDown.Name = "numRowsUpDown";
            this.numRowsUpDown.Size = new System.Drawing.Size(40, 20);
            this.numRowsUpDown.TabIndex = 11;
            this.numRowsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRowsLabel
            // 
            this.numRowsLabel.AutoSize = true;
            this.numRowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRowsLabel.Location = new System.Drawing.Point(6, 94);
            this.numRowsLabel.Name = "numRowsLabel";
            this.numRowsLabel.Size = new System.Drawing.Size(107, 16);
            this.numRowsLabel.TabIndex = 10;
            this.numRowsLabel.Text = "Number of Rows";
            // 
            // numColumnsUpDown
            // 
            this.numColumnsUpDown.Location = new System.Drawing.Point(153, 68);
            this.numColumnsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumnsUpDown.Name = "numColumnsUpDown";
            this.numColumnsUpDown.Size = new System.Drawing.Size(40, 20);
            this.numColumnsUpDown.TabIndex = 9;
            this.numColumnsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numColumnsLabel
            // 
            this.numColumnsLabel.AutoSize = true;
            this.numColumnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numColumnsLabel.Location = new System.Drawing.Point(6, 68);
            this.numColumnsLabel.Name = "numColumnsLabel";
            this.numColumnsLabel.Size = new System.Drawing.Size(123, 16);
            this.numColumnsLabel.TabIndex = 8;
            this.numColumnsLabel.Text = "Number of columns";
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
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(147, 146);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create New";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CreateForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 182);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.tilemapOptionsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 220);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Tilemap";
            this.TopMost = true;
            this.tilemapOptionsBox.ResumeLayout(false);
            this.tilemapOptionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tilemapOptionsBox;
        private System.Windows.Forms.NumericUpDown tileHeightUpDown;
        private System.Windows.Forms.Label tileHeightLabel;
        private System.Windows.Forms.NumericUpDown tileWidthUpDown;
        private System.Windows.Forms.Label tileWidthLabel;
        private System.Windows.Forms.NumericUpDown numRowsUpDown;
        private System.Windows.Forms.Label numRowsLabel;
        private System.Windows.Forms.NumericUpDown numColumnsUpDown;
        private System.Windows.Forms.Label numColumnsLabel;
        private System.Windows.Forms.Button createButton;
    }
}