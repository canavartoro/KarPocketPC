namespace AmbarPPC
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public class ImageButton : Control
    {
        private bool bPushed = false;
        private System.Drawing.Image image;
        private Bitmap m_bmpOffscreen;

        public ImageButton()
        {
            base.Size = new Size(0x15, 0x15);
        }

        private Color BackgroundImageColor(System.Drawing.Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            return bitmap.GetPixel(0, 0);
        }

        public void close_image()
        {
            this.Dispose(true);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.bPushed = true;
            base.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.bPushed = false;
            base.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush;
            if (this.m_bmpOffscreen == null)
            {
                this.m_bmpOffscreen = new Bitmap(base.ClientSize.Width, base.ClientSize.Height);
            }
            Graphics graphics = Graphics.FromImage(this.m_bmpOffscreen);
            graphics.Clear(this.BackColor);
            if (!this.bPushed)
            {
                brush = new SolidBrush(base.Parent.BackColor);
            }
            else
            {
                brush = new SolidBrush(Color.WhiteSmoke);
            }
            graphics.FillRectangle(brush, base.ClientRectangle);
            if (this.image != null)
            {
                Rectangle rectangle;
                int x = (base.Width - this.image.Width) / 2;
                int y = (base.Height - this.image.Height) / 2;
                if (!this.bPushed)
                {
                    rectangle = new Rectangle(x, y, this.image.Width, this.image.Height);
                }
                else
                {
                    rectangle = new Rectangle(x, y, this.image.Width, this.image.Height);
                }
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorKey(this.BackgroundImageColor(this.image), this.BackgroundImageColor(this.image));
                graphics.DrawImage(this.image, rectangle, 0, 0, this.image.Width, this.image.Height, GraphicsUnit.Pixel, imageAttr);

                SizeF sf = graphics.MeasureString(Text, Font);

                float xx = (Width / 2) - sf.Width / 2;
                if ((Width / 2) < sf.Width)
                    xx = 0;

                graphics.DrawString(Text, Font, new SolidBrush(ForeColor), (int)xx, Height - (sf.Height + 3));

            }
            if (this.bPushed)
            {
                Rectangle clientRectangle = base.ClientRectangle;
                clientRectangle.Width--;
                clientRectangle.Height--;
                graphics.DrawRectangle(new Pen(Color.Red), clientRectangle);
            }
            e.Graphics.DrawImage(this.m_bmpOffscreen, 0, 0);
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        public System.Drawing.Image Image
        {
            get
            {
                return this.image;
            }
            set
            {
                this.image = value;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
            base.OnResize(e);
        }
    }
}

