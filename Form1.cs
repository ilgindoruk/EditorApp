using System.Windows.Forms;

namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;//editördeki dosyanýn adý

        public Form1()
        {
            InitializeComponent();
            YeniBelge();
        }

        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void görünümToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void YeniBelge()
        {
            txtbelge.Text = "";
            dosyaAdi = "";
            Text = "[Yeni Belge]";
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dtsyeni_Click(object sender, EventArgs e)
        {
            YeniBelge();

        }

        private void tsyenı_Click(object sender, EventArgs e)
        {
            YeniBelge();

        }

        private void txtbelge_TextChanged(object sender, EventArgs e)
        {

        }

        private void tskaydet_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            saveFileDialog1.DefaultExt = "*.txt";
            DialogResult cevap = saveFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)//kullanıcı tamam dediyse

                if (cevap == DialogResult.OK)
            {
                    string secilenDosya = saveFileDialog1.FileName;

                    //File sınıfı dosya işlemleri için kullanılır
                    File.WriteAllText(secilenDosya, txtbelge.Text);
                    dosyaAdi = secilenDosya;
                    Text = $"[{dosyaAdi}]";
                }
        }
    }

}