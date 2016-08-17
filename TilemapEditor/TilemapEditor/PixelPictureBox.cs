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
    public partial class PixelPictureBox : PictureBox
    {
        private Color borderColor;
        private int borderWidth;
        [Browsable(true)]

        public bool drawOver = false;

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        public PixelPictureBox()
        {
            InitializeComponent();

            borderColor = Color.Empty;
            borderWidth = 1;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //Pixel art should be drawn as nearest neighbour
            pe.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            //Fixes issue where image seemed to be shifted half a pixel
            pe.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            //If basic outline, Draw rectangle UNDER image
            if (!drawOver)
                pe.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), borderWidth, borderWidth, Size.Width - borderWidth, Size.Height - borderWidth);

            base.OnPaint(pe);

            //If not basic outline, Draw rectangle OVER image
            if(drawOver)
                pe.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), borderWidth, borderWidth, Size.Width - borderWidth, Size.Height - borderWidth);
        }
    }
}
