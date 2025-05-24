using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
