using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biathlon
{
    public partial class Participant : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private int number;
        private int place;
        private string name;
        private string country;
        private int[] misses = new int[4];
        private int totalMisses;
        private int minutes;
        private double seconds;
        private double time;
        private double bareTime;
        private int shtraf;

        public int Number
        {
            get { return number; }
        }

        public int Place
        {
            get { return place; }
            set
            {
                place = value;
                placeLbl.Text = place.ToString();
            }
        }

        public string PlayerName
        {
            get { return name; }
        }

        public string Country
        {
            get { return country; }
        }

        public int Misses
        {
            get { return totalMisses; }
        }

        public double Time
        {
            get { return time; }
        }

        public double BareTime
        {
            get { return bareTime; }
        }

        public void updateOffset(double timeOffset)
        {
            if (timeOffset == 0)
            {
                timeLbl.Text = (minutes + shtraf).ToString() + ":" + seconds.ToString("00.0").Replace(',', '.');
                tooltip1.SetToolTip(timeLbl, "Время финиша + штраф");
            }
            else if (timeOffset == -1)
            {
                timeLbl.Text = minutes.ToString() + ":" + seconds.ToString("00.0").Replace(',', '.');
                tooltip1.SetToolTip(timeLbl, "Время финиша");
            }
            else
            {
                int newMinutes = (int)Math.Truncate((time - timeOffset) / 60.0);
                double newSeconds = time - timeOffset - newMinutes * 60;
                timeLbl.Text = "+" + newMinutes.ToString() + ":" + newSeconds.ToString("00.0").Replace(',', '.');
                tooltip1.SetToolTip(timeLbl, "Время финиша + штраф - время победителя");
            }
        }

        public Participant(int number, string surname, string name, string country, int[] misses, int minutes, double seconds)
        {
            InitializeComponent();
            this.number = number;
            this.name = surname + " " + name;
            this.country = country;
            misses.CopyTo(this.misses, 0);
            this.totalMisses = this.misses.Sum();
            this.minutes = minutes;
            this.seconds = seconds;
            this.bareTime = minutes * 60 + seconds;
            this.shtraf = this.totalMisses;
            this.time = this.bareTime + this.shtraf * 60;
            
            numberLbl.Text = number.ToString();
            nameLbl.Text = this.name;
#if DEBUG
            flagImg.Image = Image.FromFile(@"..\..\..\Flags\" + country + ".png");
#else
            flagImg.Image = Image.FromFile(@"Flags\" + country + ".png");
#endif
            countryLbl.Text = country;
            missPan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, missPan.Width, missPan.Height, 32, 32));
            missLbl.Text = totalMisses.ToString();
            tooltip1.SetToolTip(placeLbl, "Занятое место");
            tooltip1.SetToolTip(numberLbl, "Номер участника");
            tooltip1.SetToolTip(nameLbl, "Фамилия и имя участника");
            tooltip1.SetToolTip(countryLbl, "IOC код страны");
            tooltip1.SetToolTip(flagImg, "Флаг страны");
            tooltip1.SetToolTip(missLbl, "Количество промахов");
            tooltip1.SetToolTip(timeLbl, "Время финиша + штраф");
        }
    }
}

