namespace AmbarPPC
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class Animate : Control
    {
        private Color bgColor;
        private System.Drawing.Bitmap bitmap;
        private int currentFrame = 0;
        private int frameCount;
        private int frameHeight;
        private int frameWidth;
        private Timer fTimer;
        private Graphics graphics;
        private int loopCount = 0;
        private int loopCounter = 0;

        public Animate()
        {
            this.graphics = base.CreateGraphics();
            this.fTimer = new Timer();
            this.fTimer.Tick += new EventHandler(this.timer1_Tick);
        }

        private Color BackgroundImageColor(Image image)
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);
            return bitmap.GetPixel(0, 0);
        }

        private void Draw(int iframe)
        {
            int y = iframe * this.frameHeight;
            Rectangle srcRect = new Rectangle(0, y, this.frameWidth, this.frameHeight);
            this.graphics.DrawImage(this.bitmap, 0, 0, srcRect, GraphicsUnit.Pixel);
        }

        private void DrawFrame()
        {
            if (this.currentFrame < (this.frameCount - 1))
            {
                this.currentFrame++;
            }
            else
            {
                this.loopCounter++;
                this.currentFrame = 0;
            }
            this.Draw(this.currentFrame);
        }

        public void StartAnimation(int frHeight, int DelayInterval, int LoopCount)
        {
            this.frameHeight = frHeight;
            this.loopCount = LoopCount;
            this.loopCounter = 0;
            this.frameCount = this.bitmap.Height / this.frameHeight;
            this.frameWidth = this.bitmap.Width;
            base.Size = new Size(this.frameWidth, this.frameHeight);
            this.bgColor = this.BackgroundImageColor(this.bitmap);
            this.fTimer.Interval = DelayInterval;
            this.fTimer.Enabled = true;
        }

        public void StopAnimation()
        {
            this.fTimer.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.loopCount == -1)
                {
                    this.DrawFrame();
                }
                else if (this.loopCount == this.loopCounter)
                {
                    this.fTimer.Enabled = false;
                }
                else
                {
                    this.DrawFrame();
                }
            }
            catch (Exception)
            {
            }
        }

        public System.Drawing.Bitmap Bitmap
        {
            get
            {
                return this.bitmap;
            }
            set
            {
                this.bitmap = value;
            }
        }
    }
}

