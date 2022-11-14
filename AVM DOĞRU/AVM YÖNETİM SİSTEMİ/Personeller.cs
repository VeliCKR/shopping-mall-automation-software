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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labeldepatman_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelpersoneldepartman_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {

            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "insert into personel(idpersonel,personeladı,personelsoyadı,personelcinsiyeti,personeltel,personeldepartman,personeladres,personelmaası) values (@idpersonel,@Personeladı,@Personelsoyadı,@Personelcinsiyeti,@Personeltel,@Personeldepartman,@Personeladres,@Personelmaası)";
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlCommand com1 = new MySqlCommand(sql, con);
            MySqlDataReader dr;
            com1.CommandText = "SELECT * FROM personel where idpersonel='" + textBoxpersonelekleid.Text + "' ";
            dr = com1.ExecuteReader();

            if (textBoxpersonelekleid.Text == "" || dr.Read()) { MessageBox.Show("LÜTFEN İD GİRİNİZ VEYA İD KONTROL EDİNİZ"); }
            else
            {
                com1.Dispose();
                dr.Close();
                

                com.Parameters.AddWithValue("@idPersonel", textBoxpersonelekleid.Text);
                com.Parameters.AddWithValue("@Personeladı", textBoxpersonelekleadı.Text);
                com.Parameters.AddWithValue("@Personelsoyadı", textBoxpersoneleklesoyadı.Text);
                com.Parameters.AddWithValue("@Personelcinsiyeti",comboBoxpersoneleklecinsiyet.Text);
                com.Parameters.AddWithValue("@Personeltel", textBoxpersonelekletel.Text);
                com.Parameters.AddWithValue("@Personeldepartman", comboBoxpersonelekledepartman.Text);
                com.Parameters.AddWithValue("@Personeladres", textBoxpersonelekleadres.Text);
                com.Parameters.AddWithValue("@Personelmaası", Convert.ToInt32(textBoxpersoneleklemaas.Text));



                com.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                com.Dispose();

                MessageBox.Show("PERSONEL KAYDI YAPILMIŞTIR");
                griddoldur();
                textBoxpersonelekleid.Clear();
                textBoxpersonelekleadı.Clear();
                textBoxpersoneleklesoyadı.Clear();
                textBoxpersonelekletel.Clear();
                textBoxpersoneleklemaas.Clear();
                textBoxpersonelekleadres.Clear();
            }
           
           
            
        }
        void griddoldur()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From personel", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables["personel"];
            con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonpersonelduzenle_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "update  personel set idpersonel=@idpersonel,Personeladı=@Personeladı,Personelsoyadı=@Personelsoyadı,Personelcinsiyeti=@Personelcinsiyeti,Personeltel=@Personeltel,Personeldepartman=@Personeldepartman,Personeladres=@Personeladres,Personelmaası=@Personelmaası   where idpersonel=@idpersonel ";


            MySqlCommand com = new MySqlCommand(sql, con);

            com.Parameters.AddWithValue("@idPersonel", textBoxpersonelekleid.Text);
            com.Parameters.AddWithValue("@Personeladı", textBoxpersonelekleadı.Text);
            com.Parameters.AddWithValue("@Personelsoyadı", textBoxpersoneleklesoyadı.Text);
            com.Parameters.AddWithValue("@Personelcinsiyeti", comboBoxpersoneleklecinsiyet.Text);
            com.Parameters.AddWithValue("@Personeltel", textBoxpersonelekletel.Text);
            com.Parameters.AddWithValue("@Personeldepartman", comboBoxpersonelekledepartman.Text);
            com.Parameters.AddWithValue("@Personeladres", textBoxpersonelekleadres.Text);
            com.Parameters.AddWithValue("@Personelmaası", Convert.ToInt32(textBoxpersoneleklemaas.Text));


            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("PERSONEL KAYDI GÜNCELLENMİŞTİR");
            griddoldur();
            textBoxpersonelekleid.Clear();
            textBoxpersonelekleadı.Clear();
            textBoxpersoneleklesoyadı.Clear();
            textBoxpersonelekletel.Clear();
            textBoxpersoneleklemaas.Clear();
            textBoxpersonelekleadres.Clear();
        }

        private void buttonpersonelsil_Click(object sender, EventArgs e)
        {

            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "DELETE FROM personel WHERE idpersonel=@idpersonel";
            MySqlCommand com = new MySqlCommand(sql, con);


            com.Parameters.AddWithValue("@idpersonel", textBoxpersonelekleid.Text);


            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("PERSONEL KAYDI SİLİNMİŞTİR");
            griddoldur();
            textBoxpersonelekleid.Clear();
            textBoxpersonelekleadı.Clear();
            textBoxpersoneleklesoyadı.Clear();
            textBoxpersonelekletel.Clear();
            textBoxpersoneleklemaas.Clear();
            textBoxpersonelekleadres.Clear();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            griddoldur();
            griddoldur1();
        }

        private void buttonpersonelileri_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            MySqlCommand komut = new MySqlCommand("select *  from personel  where idpersonel like '" + textBoxpersonelid.Text + "'",con);

            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())                                                      //bu sayfadaki veri cekme işlemlerinin kaynagı diger işlemlerin kaynagı aynıdır 
            {                                                                               //https://www.youtube.com/watch?v=7D01DCbE-Ts&list=LL&index=3
                textBoxpersonelid.Text = read[0].ToString();
                textBoxpersonelad.Text = read[1].ToString();
                textBoxpersonelsoyad.Text = read[2].ToString();
                textBoxpersonelcinsiyet.Text = read[3].ToString();
                textBoxpersoneltel.Text = read[4].ToString();
                textBoxpersoneldepartmanı.Text = read[5].ToString();
                textBoxpersoneladres.Text = read[6].ToString();
                textBoxpersonelmaası.Text = read[7].ToString();
            }
            con.Close();



        }

        private void buttonpersonelgeri_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBoxpersonelekledepartman_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panelyonetıcısifre_Paint(object sender, PaintEventArgs e)
        {

        }
        void griddoldur1()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From yonetım", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "yonetım");
            dataGridView2.DataSource = ds.Tables["yonetım"];
            con.Close();
        }

        private void buttonyonetıcıekle_Click(object sender, EventArgs e)
        {
            griddoldur1();


            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();


            string sql = "insert into yonetım(idyonetım,yonetıcıad,yonetımsıfre) values (@idyonetım,@yonetıcıad,@Yonetımsıfre)";
                MySqlCommand com = new MySqlCommand(sql, con);

                com.Parameters.AddWithValue("@idyonetım", Convert.ToInt32(textBoxyonetıcıid.Text));
                com.Parameters.AddWithValue("@yonetıcıad", textBoxyonetıcıad.Text);
                com.Parameters.AddWithValue("@Yonetımsıfre", textBoxyonetıcısıfre.Text);

                com.ExecuteNonQuery();
                com.Dispose();
            griddoldur1();

        }

        private void buttonyonetıcıduzenle_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "update  yonetım set idyonetım=@idyonetım,yonetıcıad=@yonetıcıad,yonetımsıfre=@yonetımsıfre   where idyonetım=@idyonetım ";
            MySqlCommand com = new MySqlCommand(sql, con);

            com.Parameters.AddWithValue("@idyonetım", Convert.ToInt32(textBoxyonetıcıid.Text));
            com.Parameters.AddWithValue("@yonetıcıad", textBoxyonetıcıad.Text);
            com.Parameters.AddWithValue("@Yonetımsıfre", textBoxyonetıcısıfre.Text);




            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("YÖNETİCİ KAYDI GÜNCELLENMİŞTİR");
            griddoldur1();
        }

        private void buttonyonetıcısıl_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "DELETE FROM yonetım WHERE idyonetım=@idyonetım";
            MySqlCommand com = new MySqlCommand(sql, con);


            com.Parameters.AddWithValue("@idyonetım", textBoxyonetıcıid.Text);


            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("YONETIM KAYDI SİLİNMİŞTİR");
            griddoldur1();
        }
    }
}
