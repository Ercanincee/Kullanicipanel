using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace EDevlet
{
    public partial class KullanıcıGiris : Form
    {
        public KullanıcıGiris()
        {
            InitializeComponent();
        }

        formsifre frrmsifre=new formsifre();


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=ERCAN\\BENIMSQL;Initial Catalog=Kullanıcı;Integrated Security=True";
            //kullanıcı adını al
            string kullaniciadi = txtkullanici.Text;
            string sifre = txtsifre.Text;
            using (SqlConnection conn = new SqlConnection(connstr))
            {

                try { conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM KullaniciTablo WHERE KullanıcıAdı=@kullaniciadi AND Sifre=@Sifre", conn)) {
                        command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                        command.Parameters.AddWithValue("@Sifre", sifre);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) {
                            while (reader.Read())
                            {
                                bool isadmin = reader.GetBoolean(reader.GetOrdinal("isadmin"));
                                if (isadmin)
                                {
                                    AdminPanel formadmin = new AdminPanel();
                                    formadmin.Show();

                                }
                                else
                                {
                                    FormKullanici frmkullanici = new FormKullanici();
                                    frmkullanici.Show();

                                }
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanici Adi Veya Sifre Hatali", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex) {
                    Console.WriteLine("Hata", ex.Message);
                }
                finally { conn.Close(); }
            };
        }
        public string kullaniciadi { get; set; }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txtkllanici = txtkullanici.Text;
            string connstr = "Data Source=ERCAN\\BENIMSQL;Initial Catalog=Kullanıcı;Integrated Security=True";
            using(SqlConnection connection =new SqlConnection(connstr)) {
                using (SqlCommand command=new SqlCommand("SELECT * FROM KullaniciTablo;",connection)) {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows) {
                        int i = 0;
                        while (reader.Read()) {
                        string kullaniciadifromdb = reader["KullanıcıAdı"].ToString();

                            if (kullaniciadifromdb==txtkllanici) {
                                frrmsifre.klaniciad = txtkllanici; 
                                frrmsifre.Show();
                                this.Hide();
                                i++;
                               

                                break;
                            }
                            
                            while(i==0) { MessageBox.Show("kullanıcı adı hatalı","Kullanıcı Adı",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                i++;
                                break;
                            }
                           
                            
                        }
                        reader.Close();
                    }
                }connection.Close(); }

        }
    }
}
