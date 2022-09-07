using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstGame.Models;

namespace FirstGame
{
    public partial class Form1 : Form
    {
        private List<Chigivara> chigivaras;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            chigivaras = new List<Chigivara>(50);
            InitializeChigivaras();
            timer = new Timer();
            timer.Interval = 1000 / 60;
            timer.Tick += TimerTick;
            timer.Stop();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Stop();
            var rnd = new Random(DateTime.Now.Millisecond);
            var buffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            var bmpGraphics = Graphics.FromImage(buffer);
            bmpGraphics.DrawImage(Properties.Resources.Kuba, ClientRectangle);

            foreach (var item in chigivaras)
            {
                item.Y += item.Speed;
                if (item.Y > ClientRectangle.Height)
                {
                    item.Y = rnd.Next(0, 200) * -1;
                    item.X = rnd.Next(0, ClientRectangle.Width);
                    item.Speed = rnd.Next(5, 10);
                }

                var size = item.Speed * 10;
                bmpGraphics.DrawImage(Properties.Resources.Chigivara, new Rectangle(item.X, item.Y, size, size));
                pictureBox1.Image = buffer;
            }

            timer.Start();
        }

        private void InitializeChigivaras()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < chigivaras.Capacity; i++)
            {
                var chigivara = new Chigivara
                {
                    X = rnd.Next(0, 800),
                    Y = rnd.Next(0, 200) * -1,
                    Speed = rnd.Next(5, 10),
                };

                chigivaras.Add(chigivara);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                label1.Visible = true;
                timer.Stop();
            }
            else
            {
                label1.Visible = false;
                timer.Start();
            }
        }
    }
}
