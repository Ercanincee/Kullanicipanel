using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDevlet
{
    public partial class formsifre : Form
    {
        public formsifre()
        {
            InitializeComponent();
        }
        public string klaniciad { get { return txtf4kllaniciadi.Text; }set { txtf4kllaniciadi.Text = value; }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=ERCAN\\BENIMSQL;Initial Catalog=Kullanıcı;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connstr)) 
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT* From KullaniciTablo WHERE KullanıcıAdı=@kullaniciadi",connection)) { 
                    command.Parameters.AddWithValue("@kullaniciadi", klaniciad);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();

                            string sifreyenilead = txtf4kllaniciadi.Text;
                            string yenisifre = txtyenisifre.Text;
                            string sifretekrar = txtSifretekrar.Text;
                            if (yenisifre == sifretekrar)
                            {
                                using(SqlCommand updatecommand =new SqlCommand("UPDATE KullaniciTablo SET Sifre=@yenisifre WHERE KullanıcıAdı=@KullaniciAdi",connection)) {
                                    updatecommand.Parameters.AddWithValue("@yeniSifre",yenisifre);
                                    updatecommand.Parameters.AddWithValue("@KullaniciAdi", klaniciad);
                                updatecommand.ExecuteNonQuery();
                                    MessageBox.Show("Sifre Basarıyla Güncellendi", "Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                                }
                            }
                        

                    }
                    else { MessageBox.Show("Kullanıcı Adı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                connection.Close();
               
            }

        }
    }
}
