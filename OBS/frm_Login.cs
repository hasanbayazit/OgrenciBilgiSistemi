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
using MySql.Data.MySqlClient;

namespace OBS
{
    public partial class frm_Login : Form
    {

        SQLConnect conn = new SQLConnect();
        SqlDataAdapter sqlDataAdap;
        SqlDataReader sqlDataRead;

        //MySqlDataAdapter sqlDataAdap;
        //MySqlDataReader sqlDataRead;
        int userID;

        public string user = "";
        public frm_Login()
        {
            InitializeComponent();
            txt_KullaniciNumarasi.GotFocus += txt_KullaniciNumarasi_GotFocus;
            txt_KullaniciNumarasi.LostFocus += txt_KullaniciNumarasi_LostFocus;
            txt_Sifre.GotFocus += txt_Sifre_GotFocus;
            txt_Sifre.LostFocus += txt_Sifre_LostFocus;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Main.Text = user + " Bilgi Sistemi";
            txt_KullaniciNumarasi.Text = user + " Numarası";
            txt_Sifre.Text = "Şifre";
        }

        private void txt_KullaniciNumarasi_GotFocus(object sender, EventArgs e)
        {
            if (txt_KullaniciNumarasi.Text == "Öğrenci Numarası" || txt_KullaniciNumarasi.Text == "Öğretmen Numarası")
                txt_KullaniciNumarasi.Clear();
        }
        private void txt_KullaniciNumarasi_LostFocus(object sender, EventArgs e)
        {
            if (txt_KullaniciNumarasi.Text == "")
                txt_KullaniciNumarasi.Text = user + " Numarası";
        }
        private void txt_Sifre_GotFocus(object sender, EventArgs e)
        {
            if (txt_Sifre.Text == "Şifre")
                txt_Sifre.Clear();
        }
        private void txt_Sifre_LostFocus(object sender, EventArgs e)
        {
            if (txt_Sifre.Text == "")
                txt_Sifre.Text = "Şifre";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string sorgu = "";
            int userID = int.Parse(txt_KullaniciNumarasi.Text);

            //Giriş yapan kullanıcıya göre SQL Sorgusu hazırlanıyor.
            if (user == "Öğretmen")
                sorgu = "Select * From obs_Teachers WHERE username=@userID AND password=@password";
            else if (user == "Öğrenci")
                sorgu = "Select * From obs_Students WHERE username=@userID AND password=@password";

            SqlCommand cmd = new SqlCommand(sorgu, conn.connect());
            cmd.Parameters.AddWithValue("@userID", txt_KullaniciNumarasi.Text);
            cmd.Parameters.AddWithValue("@password", txt_Sifre.Text);
            sqlDataRead = cmd.ExecuteReader();

            //Girişin başarılı ya da başarısız olması durumlarına göre ekrana bilgi mesajı.
            if (sqlDataRead.Read())
            {
                userID = Convert.ToInt32(sqlDataRead["id"]);
                if (user == "Öğretmen")
                {
                    frm_OgretmenNotGirisi frm = new frm_OgretmenNotGirisi();
                    frm.userIDAktar = userID;
                    this.Hide();
                    frm.ShowDialog();
                }
                else if (user == "Öğrenci")
                {
                    frm_OgrenciBilgiEkrani frm = new frm_OgrenciBilgiEkrani();
                    frm.userIDAktar = userID;
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            else
                MessageBox.Show(user + " numaranızı ve şifrenizi kontrol ediniz.");

            conn.connect().Close();
        }
    }
}
