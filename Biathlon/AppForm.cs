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
using System.IO;
using System.Diagnostics;

namespace Biathlon
{
    public partial class AppForm : Form
    {
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private FlatComboBox sortTypeComboBox = new FlatComboBox();
        private Dropshadow shadow;
        private bool resizing;
        private int hRsz;
        private int vRsz;
        private int wParam;
        private bool scrollingRight = false;
        
        private List<Participant> participants = new List<Participant>();

        public AppForm()
        {
            InitializeComponent();
            shadow = new ShadowDemo.Dropshadow(this)
            {
                ShadowBlur = 15,
                ShadowSpread = -7,
                ShadowColor = Color.FromArgb(143, 0, 0, 0)
            };
            shadow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shadow_MouseMove);
            shadow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shadow_MouseDown);
            shadow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shadow_MouseUp);
            shadow.RefreshShadow();
            shadow.UpdateLocation();
            controlPanel1.changeCaption("Биатлон");
            controlPanel1.wndStateChanged += new EventHandler(updateContainer);
            sortTypeComboBox.Font = new Font("Microsoft Sans Serif", 10);
            sortTypeComboBox.Anchor = AnchorStyles.Bottom;
            sortTypeComboBox.Location = new Point(-1, -1);
            sortTypeComboBox.Size = new Size(256, 24);
            sortTypeComboBox.Items.Add("В порядке занятых мест");
            sortTypeComboBox.Items.Add("В порядке убывания скорости");
            sortTypeComboBox.Items.Add("В порядке убывания меткости");
            sortTypeComboBox.SelectedIndex = 0;
            sortTypeComboBox.Enter += new EventHandler(sortTypeComboBox_DropDownClosed);
            sortTypeComboBox.SelectedIndexChanged += new EventHandler(sortTypeComboBox_DropDownClosed);
            sortTypePan.Controls.Add(sortTypeComboBox);
            sortTypeComboBox_DropDownClosed(this, null);

            foreach (Button but in this.Controls.OfType<Button>())
            {
                but.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            }
        }

        public void updateContainer(object sender, EventArgs e)
        {
            int w = container.Width;
            container.Width = w + System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            container.Width = w;
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
                sortTypeComboBox_DropDownClosed(this, null);
                SendMessage(Handle, WM_NCLBUTTONDOWN, wParam, 0);
            }
            resizing = false;
            updateContainer(this, null);
            sortTypeComboBox_DropDownClosed(this, null);
        }

        private void shadow_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void AppForm_SizeChanged(object sender, EventArgs e)
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

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            int i = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        fileNameLbl.Text = openFileDialog1.SafeFileName;
                        if (fileNameLbl.Width > fileNamePan.Width)
                        {
                            fileLblScroller.Enabled = true;
                        }
                        else
                        {
                            fileLblScroller.Enabled = false;
                            fileNameLbl.Location = new Point(-1, -2);
                        }
                        using (StreamReader sr = new StreamReader(myStream))
                        {
                            string line;
                            string[] data;
                            participants = new List<Participant>();
                            while ((line = sr.ReadLine()) != null)
                            {
                                data = line.Split(' ');
                                try
                                {
                                    addParticipant(data, i);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ошибка: файл имеет неправильный формат содержимого.", "Ошибка", MessageBoxButtons.OK);
                                    fileNameLbl.Text = "Файл не выбран";
                                    fileLblScroller.Enabled = false;
                                    return;
                                }
                                i++;
                            }
                            updateBtn_Click(this, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: проблема при считывании файла. Тело ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void addParticipant(string[] s, int index)
        {
            Participant p;
            int[] misses = new int[4] { Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToInt32(s[6]), Convert.ToInt32(s[7]) };
            int number = Convert.ToInt32(s[0]);
            int minutes = Convert.ToInt32(s[8]);
            double seconds = Convert.ToDouble(s[9].Replace('.', ','));
            p = new Participant(number, s[1], s[2], s[3], misses, minutes, seconds);
            p.Dock = DockStyle.Top;
            p.Margin = new Padding(4);
            participants.Add(p);
        }

        private void showParticipants(ref List<Participant> participants, string country, int offset)
        {
            container.Controls.Clear();
            container.Update();
            container.RowStyles.Clear();
            container.RowCount = 0;
            container.ColumnStyles.Clear();
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            container.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            int i = 0;
            foreach (Participant p in participants)
            {
                if (i == 1)
                {
                    p.Margin = new Padding(4, 12, 4, 4);
                }
                else
                {
                    p.Margin = new Padding(4, 4, 4, 4);
                }
                if (country == "")
                {
                    container.Controls.Add(p, 0, i);
                    i++;
                }
                else if (p.Country == country)
                {
                    container.Controls.Add(p, 0, i);
                    i++;
                }
                if (i == offset && offset != 0)
                {
                    break;
                }
            }
            int w = container.Width;
            container.Width = w + System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            container.Width = w;
            container.Visible = true;
            Cursor.Current = Cursors.Arrow;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            sortTypeComboBox_DropDownClosed(this, null);
            if (participants.Count == 0)
            {
                MessageBox.Show("Ошибка: не выбран файл с данными.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (sortTypeComboBox.SelectedIndex == 0)
            {
                participants.Sort((x, y) => x.Time.CompareTo(y.Time));
                for (int i = 0; i < participants.Count; i++)
                {
                    participants[i].Place = i + 1;
                    participants[i].updateOffset(participants[0].Time);
                }
                participants[0].updateOffset(0);
            }
            else if (sortTypeComboBox.SelectedIndex == 1)
            {
                participants.Sort((x, y) => x.BareTime.CompareTo(y.BareTime));
                foreach (Participant p in participants)
                {
                    p.updateOffset(-1);
                }
            }
            else
            {
                participants.Sort((x, y) => x.Time.CompareTo(y.Time));
                participants = participants.OrderBy(p => p.Misses).ToList<Participant>();
                for (int i = 0; i < participants.Count; i++)
                {
                    participants[i].updateOffset(participants[0].Time);
                }
                participants[0].updateOffset(0);
            }
            showParticipants(ref participants, countryFilterBox.Text.ToUpper(), Convert.ToInt32(numericUpDown1.Value));
        }

        private void sortTypeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { sortTypeComboBox.Select(0, 0); }));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numericUpDown1.Value);
            if (10 < value && value < 15)
            {
                label2.Text = "участников";
                return;
            }
            switch (value % 10)
            {
                case 1:
                    label2.Text = "участник";
                    break;
                case 2:
                case 3:
                case 4:
                    label2.Text = "участника";
                    break;
                default:
                    label2.Text = "участников";
                    break;
            }
        }

        private void fileLblScroller_Tick(object sender, EventArgs e)
        {
            if (scrollingRight)
            {
                if (fileNameLbl.Location.X + fileNameLbl.Width >= fileNamePan.Width)
                {
                    fileNameLbl.Location = new Point(fileNameLbl.Location.X - 1, fileNameLbl.Location.Y);
                }
                else
                {
                    scrollingRight = false;
                }
            }
            else
            {
                if (fileNameLbl.Location.X <= 0)
                {
                    fileNameLbl.Location = new Point(fileNameLbl.Location.X + 1, fileNameLbl.Location.Y);
                }
                else
                {
                    scrollingRight = true;
                }
            }
        }

        private void flagUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = @"Python.exe";
            p.StartInfo.Arguments = "flagUpdater.py";
#if DEBUG
            p.StartInfo.WorkingDirectory = @"..\..\..\";
#else
            p.StartInfo.WorkingDirectory = @"";
#endif
            p.StartInfo.UseShellExecute = true;
            p.Start();
            p.WaitForExit();
        }
    }
}
