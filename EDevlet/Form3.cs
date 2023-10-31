using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDevlet
{
    public partial class FormKullanici : Form
    {
        public FormKullanici()
        {
            InitializeComponent();
        }

        private void FormKullanici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kullanıcıDataSet2.Kelimeler' table. You can move, or remove it, as needed.
            this.kelimelerTableAdapter.Fill(this.kullanıcıDataSet2.Kelimeler);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesajınız Yok", "MesajKutusu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        bool i = false;

        void cevir()
        {
            if (i == false)
            {
                kelimeturkce.Hide();
                kelimeingilizce.Show();
                i = true;
            }
            else
            {
                kelimeturkce.Show();
                kelimeingilizce.Hide();
                i = false;
            }
        }
        private void btnarka_Click(object sender, EventArgs e)
        {
            cevir();
        }
    }
}
