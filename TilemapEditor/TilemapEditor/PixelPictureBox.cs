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
        [Description("Resizes vertically to keep aspect ratio"), Category("Layout")]
        public bool KeepAspect { get; set; }

        //Override image property and create new event handler
        public event EventHandler ImageChanged;
        public new Image Image
        {
            get { return base.Image; }
            set
            {
                base.Image = value;
                if (ImageChanged != null)
                    ImageChanged(this, new EventArgs());
            }
        }

        public PixelPictureBox()
        {
            InitializeComponent();

            Resize += new EventHandler(box_Resize);
            ImageChanged += new EventHandler(box_Resize);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //Pixel art should be drawn as nearest neighbour
            pe.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            //Fixes issue where image seemed to be shifted half a pixel
            pe.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            base.OnPaint(pe);
        }

        private void box_Resize(object sender, EventArgs e)
        {
            //Resize picturebox vertically to keep the aspect ratio of the image
            if (KeepAspect)
            {
                float ratio = 0;

                if (Image != null)
                    ratio = (float)Image.Height / Image.Width;
                //If no image, ratio is square (1)
                else
                    ratio = 1;

                Height = (int)(Width * ratio);
            }
        }
    }
}
