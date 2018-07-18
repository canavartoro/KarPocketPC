namespace AmbarPPC
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public class ImageButtonTransparent : Control
    {
        private System.Drawing.Image image;
        private Bitmap m_bmpOffscreen;

        public ImageButtonTransparent()
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

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.m_bmpOffscreen == null)
            {
                this.m_bmpOffscreen = new Bitmap(base.ClientSize.Width, base.ClientSize.Height);
            }
            Graphics graphics = Graphics.FromImage(this.m_bmpOffscreen);
            graphics.Clear(this.BackColor);
            Brush brush = new SolidBrush(base.Parent.BackColor);
            graphics.FillRectangle(brush, base.ClientRectangle);
            if (this.image != null)
            {
                int x = (base.Width - this.image.Width) / 2;
                int y = (base.Height - this.image.Height) / 2;
                Rectangle destRect = new Rectangle(x, y, this.image.Width, this.image.Height);
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorKey(this.BackgroundImageColor(this.image), this.BackgroundImageColor(this.image));
                graphics.DrawImage(this.image, destRect, 0, 0, this.image.Width, this.image.Height, GraphicsUnit.Pixel, imageAttr);
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
    }
}

