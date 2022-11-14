using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AVM_YÖNETİM_SİSTEMİ
{
    public partial class formgrs : Form
    {
        public formgrs()
        {
            InitializeComponent();
        }

        private void lblavmad_Click(object sender, EventArgs e)
        {

        }

        private void btncks_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btncks_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btngrs_Click(object sender, EventArgs e)
        {

            //buradaki baglantının kaynagı 
            //https://www.yazilimkodlama.com/c-2/c-mysql-baglantisi-ile-basit-login-form-ornegi/

            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "insert into personel(idpersonel,personeladı,personelsoyadı,personelcinsiyeti,personeltel,personeldepartman,personeladres,personelmaası) values (@idpersonel,@Personeladı,@Personelsoyadı,@Personelcinsiyeti,@Personeltel,@Personeldepartman,@Personeladres,@Personelmaası)";
            MySqlCommand com = new MySqlCommand(sql,con);
            MySqlDataReader dr;

            com.Connection = con;
            com.CommandText = "SELECT * FROM yonetım where idyonetım='" + textBoxgiris.Text + "' AND yonetımsıfre='" + textBoxsıfre.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                this.Close();
                AnaForm ana = new AnaForm();
                ana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                textBoxgiris.Clear();
                textBoxsıfre.Clear();
            }


           
           
        }

        private void formgrs_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

      

        private void btncıkıs_Click(object sender, EventArgs e)
        {

           /* this.Close();
            AnaForm ana = new AnaForm();
            ana.ShowDialog();*/
            this.Close();
            Application.Exit(); 
        }
    }
}
