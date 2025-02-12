using System.Windows.Forms;

namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;

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
        void Kaydet()
        {
            
            
            if (!string.IsNullOrEmpty(dosyaAdi))
            {
                File.WriteAllText(dosyaAdi, txtbelge.Text);
                return;
            }

            saveFileDialog1.Filter = "Metin Dosyalarý|*.txt|Tüm Dosyalar|*.*";
            saveFileDialog1.DefaultExt = "*.txt";
            DialogResult cevap = saveFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                string secilenDosya = saveFileDialog1.FileName;

                
                File.WriteAllText(secilenDosya, txtbelge.Text);
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";
            }
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

            if (cevap == DialogResult.OK)

                if (cevap == DialogResult.OK)
                {
                    string secilenDosya = saveFileDialog1.FileName;

                    
                    File.WriteAllText(secilenDosya, txtbelge.Text);
                    dosyaAdi = secilenDosya;
                    Text = $"[{dosyaAdi}]";
                }
        }

        private void tsac_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            dialog.DefaultExt = "*.txt";

            DialogResult cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                string secilenDosya = dialog.FileName;
                string icerik = File.ReadAllText(secilenDosya);
                txtbelge.Text = icerik;
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
 
            var cevap = MessageBox.Show("Kayıt edilmemiş değişiklikleri kayıt etmek ister misiniz?",
                "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Kaydet();
            }
            else if (cevap == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            
        }
    }

}