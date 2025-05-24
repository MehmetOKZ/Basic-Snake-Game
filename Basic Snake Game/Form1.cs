using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Snake_Game
{
    public partial class YılanOyunu : Form
    {
        private List<Point> yılan=new List<Point>();
        private Point yem;
        private int yon = 3; //0:Yukarı, 1:Aşağı, 2:Sol, 3:Sağa hareket edecek
        private int kareboyutu = 20;
        private Timer oyunZamanı;
        private bool oyunBitti;
        private Random rastgele=new Random();
        public YılanOyunu()
        {
            this.Width = 400;
            this.Height = 400;
            this.DoubleBuffered= true;
            this.KeyDown += new KeyEventHandler(TusBasıldı);

            oyunZamanı= new Timer();
            oyunZamanı.Interval = 100;
            oyunZamanı.Tick += OyunuGuncelle;

            OyunuBaslat();
        }
        private void OyunuBaslat()
        {
            yılan.Clear();
            yılan.Add(new Point(10, 10));
            YemOlustur();
            yon = 3;
            oyunZamanı.Start();
        }

        private void YemOlustur()
        {
        yem = new Point(rastgele.Next(0,this.ClientSize.Width/kareboyutu), (rastgele.Next(0, this.ClientSize.Height / kareboyutu)));
        }

        private void OyunuGuncelle(object sender, EventArgs e)
        {
            if (oyunBitti)
            {
                return;  //oyun bitmişse güncelleme duracak.
            }
            Point yeniBaş = yılan[0];
            switch (yon)
            {
                case 0: yeniBaş.Y--; break;//YUKARI YÖN
                case 1: yeniBaş.Y++; break;//AŞAĞI YÖN
                case 2: yeniBaş.X--; break;//SOLA YÖN
                case 3: yeniBaş.X++; break;//SAĞA YÖN


            }
            if (yeniBaş.X < 0 || yeniBaş.Y < 0 || yeniBaş.X >= this.ClientSize.Width / kareboyutu || yeniBaş.Y >= this.ClientSize.Height / kareboyutu || yılan.Contains(yeniBaş))
            {
                oyunBitti = true;
                oyunZamanı.Stop();
                MessageBox.Show("Oyun Bitti!");
                return;
            }
            yılan.Insert(0, yeniBaş);
            if (yeniBaş == yem)
            {
                YemOlustur();
            }
            else
            {
                yılan.RemoveAt(yılan.Count - 1);
            }
            this.Invalidate();
        }
        private void TusBasıldı(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && yon != 1)
            {
                yon = 0;
            }

            else if (e.KeyCode == Keys.Down && yon != 0)
            {
                yon = 1;
            }
            else if (e.KeyCode == Keys.Left && yon != 3)
            {
                yon = 2;
            }

            else if (e.KeyCode == Keys.Right && yon != 2)
            {
                yon = 3;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            foreach (var parca in yılan)
            {
                g.FillRectangle(Brushes.LightGreen,
                    parca.X * kareboyutu,
                    parca.Y * kareboyutu,
                    kareboyutu,
                    kareboyutu);

                g.FillRectangle(Brushes.Red,
                    yem.X * kareboyutu,
                    yem.Y * kareboyutu,
                    kareboyutu,
                    kareboyutu);
            }
        }


    }
}
