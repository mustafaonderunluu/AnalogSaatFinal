namespace AnalogSaat
{
    public partial class Form1 : Form
    {
        Bitmap AkrepResim;
        int aci = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1akrep.Parent = Saat;
            pictureBox1akrep.Location = new Point(0, 0);
            AkrepResim = new Bitmap(AnalogSaat.Properties.Resources.akrep);
        }

        private void Çevir_Click(object sender, EventArgs e)
        {
            if (aci == 360) aci = 0; else aci += 6;
            pictureBox1akrep.Image = resimCevir(AkrepResim, aci);  
        }
        private Bitmap resimCevir(Bitmap eskiResim, float aci) {


            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using (Graphics g = Graphics.FromImage(yeniResim)) {

                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height / 2);
                g.DrawImage(eskiResim, new Point(0, 0));
            
            }
            return yeniResim;
        }
    }
}
