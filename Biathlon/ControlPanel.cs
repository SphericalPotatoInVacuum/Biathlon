using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Biathlon
{
    public partial class ControlPanel : UserControl
    {
        public event EventHandler wndStateChanged;

        private const double scale = 1.5;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private Form f;
        private Bitmap closeBlackImg = new Bitmap(30, 26);
        private Bitmap closeWhiteImg = new Bitmap(30, 26);
        private Bitmap minImg = new Bitmap(30, 26);
        private Bitmap maxImg = new Bitmap(30, 26);
        private Bitmap restrImg = new Bitmap(30, 26);
        private Graphics g;
        private Bitmap whiteRect = new Bitmap(30, 26);
        private Bitmap blackRect = new Bitmap(30, 26);
        private Bitmap closeMask = new Bitmap(30, 26);
        private Bitmap minMask = new Bitmap(30, 26);
        private Bitmap maxMask = new Bitmap(30, 26);
        private Bitmap restMask = new Bitmap(30, 26);

        public ControlPanel()
        {
            InitializeComponent();
        }

        public void changeCaption(String caption)
        {
            this.formCaption.Text = caption;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        protected override void WndProc(ref Message m)
        {
            bool fl = false;
            if (m.Msg == 0x112)
            {
                if (m.WParam == new IntPtr(0xF032))
                {
                    wndBtn.BackgroundImage = restrImg;
                }
                else
                {
                    wndBtn.BackgroundImage = maxImg;
                }
            }
            if (m.Msg == 0xa1 && f.WindowState == FormWindowState.Maximized)
            {
                fl = true;
                wndBtn.BackgroundImage = maxImg;
            }
            if (m.Msg == 0x84)
            {
                m.Result = (IntPtr)2;
            }
            if (m.Msg == 0x84 || m.Msg == 0x20 || m.Msg == 0xc216 || m.Msg == 0x200 || m.Msg == 0x2a1 || m.Msg == 0x21 || m.Msg == 202 || m.Msg == 0xa0 || m.Msg == 0xa1 || m.Msg == 0x112 || m.Msg == 0x231 || m.Msg == 0x216 || m.Msg == 0x3)
            {
                m.HWnd = this.Parent.Handle;
                SendMessage(m.HWnd, m.Msg, m.WParam, m.LParam);
                if (fl)
                {
                    wndStateChanged?.Invoke(this, null);
                    base.WndProc(ref m);
                }
                return;
            }
            base.WndProc(ref m);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            f.Close();
        }

        private void wndBtn_Click(object sender, EventArgs e)
        {
            if (f.WindowState == FormWindowState.Normal)
            {
                f.WindowState = FormWindowState.Maximized;
                wndStateChanged?.Invoke(this, null);
                wndBtn.BackgroundImage = restrImg;
            }
            else
            {
                f.WindowState = FormWindowState.Normal;
                wndStateChanged?.Invoke(this, null);
                wndBtn.BackgroundImage = maxImg;
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            f.WindowState = FormWindowState.Minimized;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            f = this.Parent as Form;
            closeMask = resize(Biathlon.Properties.Resources.title_button_close, scale);
            minMask = resize(Biathlon.Properties.Resources.title_button_minimize, scale);
            maxMask = resize(Biathlon.Properties.Resources.title_button_maximize, scale);
            restMask = resize(Biathlon.Properties.Resources.title_button_restore, scale);
            blackRect = resize(blackRect, scale);
            whiteRect = resize(whiteRect, scale);
            closeBlackImg = resize(closeBlackImg, scale);
            closeWhiteImg = resize(closeWhiteImg, scale);
            maxImg = resize(maxImg, scale);
            minImg = resize(minImg, scale);
            restrImg = resize(restrImg, scale);

            g = Graphics.FromImage(blackRect);
            g.FillRectangle(new SolidBrush(Color.Gray), 0, 0, blackRect.Width, blackRect.Height);
            g = Graphics.FromImage(whiteRect);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, whiteRect.Width, whiteRect.Height);
            g.Dispose();

            closeBlackImg = alphaMask(blackRect, closeMask);
            closeWhiteImg = alphaMask(whiteRect, closeMask);
            minImg = alphaMask(blackRect, minMask);
            maxImg = alphaMask(blackRect, maxMask);
            restrImg = alphaMask(blackRect, restMask);

            closeBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.BackgroundImageLayout = ImageLayout.Center;
            closeBtn.BackgroundImage = closeBlackImg;
            
            wndBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            wndBtn.FlatAppearance.BorderSize = 0;
            wndBtn.BackgroundImageLayout = ImageLayout.Center;
            wndBtn.BackgroundImage = maxImg;
            
            minBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            minBtn.FlatAppearance.BorderSize = 0;
            minBtn.BackgroundImageLayout = ImageLayout.Center;
            minBtn.BackgroundImage = minImg;
        }

        private Bitmap alphaMask(Bitmap input, Bitmap mask)
        {
            Bitmap output = new Bitmap(input.Width, input.Height, PixelFormat.Format32bppArgb);
            var rect = new Rectangle(0, 0, input.Width, input.Height);
            var bitsMask = mask.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            var bitsInput = input.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            var bitsOutput = output.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            unsafe
            {
                for (int y = 0; y < input.Height; y++)
                {
                    byte* ptrMask = (byte*)bitsMask.Scan0 + y * bitsMask.Stride;
                    byte* ptrInput = (byte*)bitsInput.Scan0 + y * bitsInput.Stride;
                    byte* ptrOutput = (byte*)bitsOutput.Scan0 + y * bitsOutput.Stride;
                    for (int x = 0; x < input.Width; x++)
                    {
                        ptrOutput[4 * x] = ptrInput[4 * x];           // blue
                        ptrOutput[4 * x + 1] = ptrInput[4 * x + 1];   // green
                        ptrOutput[4 * x + 2] = ptrInput[4 * x + 2];   // red
                        ptrOutput[4 * x + 3] = ptrMask[4 * x];        // alpha
                    }
                }
            }
            mask.UnlockBits(bitsMask);
            input.UnlockBits(bitsInput);
            output.UnlockBits(bitsOutput);

            return output;
        }

        private Bitmap resize(Bitmap original, double scale)
        {
            Bitmap result = new Bitmap((int)(original.Width / scale), (int)(original.Height / scale));
            Graphics g = Graphics.FromImage(result);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.DrawImage(original, 0, 0, result.Width, result.Height);
            return result;
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = closeWhiteImg;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = closeBlackImg;
        }

        private void ControlPanel_SizeChanged(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}
