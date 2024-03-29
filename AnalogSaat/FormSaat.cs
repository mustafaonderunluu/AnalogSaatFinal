using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogSaat
{
    public partial class FormSaat : Form
    {
        Bitmap akrepResim = new Bitmap(AnalogSaat.Properties.Resources.akrep);
        Bitmap yelkovanResim = new Bitmap(AnalogSaat.Properties.Resources.yelkovan);
        Bitmap saniyeResim = new Bitmap(AnalogSaat.Properties.Resources.saniye);
        Bitmap miliResim = new Bitmap(AnalogSaat.Properties.Resources.mili);
        int saat, dakika, saniye, mili;
        DateTime zaman;




        private Bitmap resimCevir(Bitmap eskiResim, float aci)
        {


            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using (Graphics g = Graphics.FromImage(yeniResim))
            {

                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height / 2);
                g.DrawImage(eskiResim, new Point(0, 0));

            }
            return yeniResim;
        }
        public FormSaat()
        {
            InitializeComponent();
        }

        private void timer1saat_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            saat = zaman.Hour;
            dakika = zaman.Minute;
            saniye = zaman.Second;
            mili = zaman.Millisecond;
            label1saat.Text= string.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                saat,dakika,saniye,mili);
            Single miliAci = mili * (float)(360) / (float)(1000);
            Single saniyeAci = saniye * 6 + miliAci / 1000;
            Single dakikaAci = dakika * 6 + saniyeAci / 60;
            Single saatAci = saat * 30 + dakikaAci / 12;

            pictureBox1akrep.Image = resimCevir(akrepResim, saatAci);
            pictureBox1yelkovan.Image = resimCevir(yelkovanResim, dakikaAci);
            pictureBox1saniye.Image = resimCevir(saniyeResim, saniyeAci);
            pictureBox1milisaniye.Image = resimCevir(miliResim, miliAci);
        }

        private void FormSaat_Load(object sender, EventArgs e)
        {
            pictureBox1akrep.Parent = pictureBox1saat;
            pictureBox1akrep.Location = new Point(0, 0);
            pictureBox1yelkovan.Parent = pictureBox1akrep;
            pictureBox1yelkovan.Location = new Point(0, 0);
            pictureBox1saniye.Parent = pictureBox1yelkovan;
            pictureBox1saniye.Location = new Point(0, 0);
            pictureBox1milisaniye.Parent = pictureBox1saniye;
            pictureBox1milisaniye.Location= new Point(0, 0);
            label1saat.Parent = pictureBox1milisaniye;

        }
    }
}
