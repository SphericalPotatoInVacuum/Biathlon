using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadowDemo;
using System.Runtime.InteropServices;

namespace Biathlon
{
    public partial class MenuForm : Form
    {
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;

        private Dropshadow shadow;
        private bool resizing;
        private int hRsz;
        private int vRsz;
        private int wParam;

        public MenuForm()
        {
            InitializeComponent();
            shadow = new ShadowDemo.Dropshadow(this)
            {
                ShadowBlur = 15,
                ShadowSpread = -7,
                ShadowColor = Color.FromArgb(127, 0, 0, 0)
            };
            shadow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shadow_MouseMove);
            shadow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shadow_MouseDown);
            shadow.RefreshShadow();
            shadow.UpdateLocation();
            controlPanel1.changeCaption("Главное меню");

            foreach (Button but in this.Controls.OfType<Button>())
            {
                but.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            foreach (Button but in this.Controls.OfType<Button>())
            {
                but.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            }
        }

        private void shadow_MouseMove(object sender, MouseEventArgs e)
        {
            if (!resizing)
            {
                if (e.X >= shadow.Width - 8)
                {
                    hRsz = 1;
                }
                else if (e.X <= 8)
                {
                    hRsz = -1;
                }
                else
                {
                    hRsz = 0;
                }
                if (e.Y >= shadow.Height - 8)
                {
                    vRsz = 1;
                }
                else if (e.Y <= 8)
                {
                    vRsz = -1;
                }
                else
                {
                    vRsz = 0;
                }
            }
            if (Convert.ToBoolean(hRsz) && !Convert.ToBoolean(vRsz))
            {
                Cursor.Current = Cursors.SizeWE;
            }
            else if (!Convert.ToBoolean(hRsz) && Convert.ToBoolean(vRsz))
            {
                Cursor.Current = Cursors.SizeNS;
            }
            else if (Convert.ToBoolean(hRsz + vRsz))
            {
                Cursor.Current = Cursors.SizeNWSE;
            }
            else
            {
                Cursor.Current = Cursors.SizeNESW;
            }
        }

        private void shadow_MouseDown(object sender, MouseEventArgs e)
        {
            resizing = true;

            if (hRsz == 1 && vRsz == 0)
            {
                Cursor.Current = Cursors.SizeWE;
                wParam = 0xB;
            }
            else if (hRsz == 1 && vRsz == 1)
            {
                Cursor.Current = Cursors.SizeNWSE;
                wParam = 0x11;
            }
            else if (hRsz == 1 && vRsz == -1)
            {
                Cursor.Current = Cursors.SizeNESW;
                wParam = 0xE;
            }
            else if (hRsz == 0 && vRsz == 1)
            {
                Cursor.Current = Cursors.SizeNS;
                wParam = 0xF;
            }
            else if (hRsz == 0 && vRsz == -1)
            {
                Cursor.Current = Cursors.SizeNS;
                wParam = 0xC;
            }
            else if (hRsz == -1 && vRsz == 1)
            {
                Cursor.Current = Cursors.SizeNESW;
                wParam = 0x10;
            }
            else if (hRsz == -1 && vRsz == 0)
            {
                Cursor.Current = Cursors.SizeWE;
                wParam = 0xA;
            }
            else
            {
                Cursor.Current = Cursors.SizeNWSE;
                wParam = 0xD;
            }
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, wParam, 0);
            }
            resizing = false;
        }

        private void MenuForm_SizeChanged(object sender, EventArgs e)
        {
            shadow.RefreshShadow(true);
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, 0x2, 0);
            }
        }

        private void app_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            AppForm app = new AppForm();
            app.FormClosing += app_FormClosing;
            app.Show();
            this.Hide();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.FormClosing += app_FormClosing;
            info.Show();
            this.Hide();
        }

        private void MenuForm_Resize(object sender, EventArgs e)
        {
            shadow.RefreshShadow(true);
        }
    }
}
