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
    public partial class Magazalar : Form
    {
        public Magazalar()
        {
            InitializeComponent();        //bir çok işlemin kaynağı aynıdır diğer sayfalarda belirtilmiştir
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void buttonmagazakirala_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "insert into magaza(idmagaza,magazaadı,sırketadı,magazaturu,magazakıra,magazacalısan,magazasorumlusu) values (@idmagaza,@Magazaadı,@Sırketadı,@Magazaturu,@Magazakıra,@Magazacalısan,@Magazasorumlusu)";
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlCommand com1 = new MySqlCommand(sql, con);
            MySqlDataReader dr;
            com1.CommandText = "SELECT * FROM magaza where idmagaza='" + comboBoxmagazaid.Text + "' ";
            dr = com1.ExecuteReader();

            if (comboBoxmagazaid.Text == "" || dr.Read()) { MessageBox.Show("LÜTFEN İD GİRİNİZ VEYA İD KONTROL EDİNİZ"); }
            else
            {
                com1.Dispose();
                dr.Close();


                com.Parameters.AddWithValue("@idmagaza", comboBoxmagazaid.Text);
                com.Parameters.AddWithValue("@Magazaadı", textBoxmagazaad.Text);
                com.Parameters.AddWithValue("@Sırketadı", textBoxsirketad.Text);
                com.Parameters.AddWithValue("@Magazaturu", comboBoxmagazatur.Text);
                com.Parameters.AddWithValue("@Magazakıra", Convert.ToInt32(textBoxmagazakira.Text));
                com.Parameters.AddWithValue("@Magazacalısan", Convert.ToInt32(textBoxmagazacalısansayı.Text));
                com.Parameters.AddWithValue("@Magazasorumlusu", textBoxmagazasorumlusu.Text);



                com.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                com.Dispose();

                MessageBox.Show("MAĞAZA SÖZLEŞMESİ YAPILMIŞTIR");
                griddoldur();
                
                textBoxmagazaad.Clear();
                textBoxsirketad.Clear();
                textBoxmagazasorumlusu.Clear();
                textBoxmagazakira.Clear();
                textBoxmagazacalısansayı.Clear();

            }
        }
        void griddoldur()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From magaza", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "magaza");
            dataGridView1.DataSource = ds.Tables["magaza"];
            con.Close();
        }

     
        private void buttonmagazaduzenle_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "update magaza set idmagaza=@idmagaza,magazaadı=@Magazaadı,sırketadı=@Sırketadı,magazaturu=@Magazaturu,magazakıra=@Magazakıra,magazacalısan=@Magazacalısan,magazasorumlusu=@Magazasorumlusu   where idmagaza=@idmagaza ";


            MySqlCommand com = new MySqlCommand(sql, con);

            com.Parameters.AddWithValue("@idmagaza", comboBoxmagazaid.Text);
            com.Parameters.AddWithValue("@Magazaadı", textBoxmagazaad.Text);
            com.Parameters.AddWithValue("@Sırketadı", textBoxsirketad.Text);
            com.Parameters.AddWithValue("@Magazaturu", comboBoxmagazatur.Text);
            com.Parameters.AddWithValue("@Magazakıra", Convert.ToInt32(textBoxmagazakira.Text));
            com.Parameters.AddWithValue("@Magazacalısan", Convert.ToInt32(textBoxmagazacalısansayı.Text));
            com.Parameters.AddWithValue("@Magazasorumlusu", textBoxmagazasorumlusu.Text);



            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("MAĞAZA KİRALAMASI YENİDEN DÜZENLENMİŞTİR");
            griddoldur();
            
            textBoxmagazaad.Clear();
            textBoxsirketad.Clear();
            textBoxmagazasorumlusu.Clear();
            textBoxmagazakira.Clear();
            textBoxmagazacalısansayı.Clear();
        }

        private void buttonmagazakiraiptal_Click(object sender, EventArgs e)
        {

            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "DELETE FROM magaza WHERE idmagaza=@idmagaza";
            MySqlCommand com = new MySqlCommand(sql, con);


            com.Parameters.AddWithValue("@idmagaza", comboBoxmagazaid.Text);


            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("MAĞAZA KİRALAMASI FESİH EDİLMİŞTİR");
            griddoldur();
            
            textBoxmagazaad.Clear();
            textBoxsirketad.Clear();
            textBoxmagazasorumlusu.Clear();
            textBoxmagazakira.Clear();
            textBoxmagazacalısansayı.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelmagazasorumlusu_Click(object sender, EventArgs e)
        {

        }

        private void Magazalar_Load(object sender, EventArgs e)
        {
            griddoldur();


            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            MySqlCommand komut = new MySqlCommand("select *  from magaza where idmagaza='" + comboBoxmagazaid.Text + "' ", con);

            MySqlDataReader read = komut.ExecuteReader();

             while (read.Read())
             {
                
                    m1.Text = read[1].ToString()+"  "+read[3].ToString();
                    m2.Text = read[2].ToString() + " " + read[3].ToString();
                
                





            }



            con.Close();





        }

        private void comboBoxmagazagetır_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departman = comboBoxmagazagetır.Text;
            griddoldur1(departman);
        }
        void griddoldur1(string getir)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From magaza where magazaturu like '" + comboBoxmagazagetır.Text + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "magaza");
            dataGridView1.DataSource = ds.Tables["magaza"];
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonmagazaara_Click(object sender, EventArgs e)
        {

            textBoxad.Clear();
            textBoxsorumlu.Clear();
            textBoxkıra.Clear();
            textBoxturu.Clear();
            textBoxsırket.Clear();
            textBoxcalısan.Clear();

            panel1.Visible = true;
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            MySqlCommand komut = new MySqlCommand("select *  from magaza  where idmagaza like '" + comboBox1.Text + "'", con);

            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())                                            //buradaki veri çekme işleminin kaynagı
            {                                                                     //https://www.youtube.com/watch?v=7D01DCbE-Ts&list=LL&index=3
                textBoxad.Text = read[1].ToString();
                textBoxsorumlu.Text = read[5].ToString();
                textBoxkıra.Text = read[6].ToString();
                textBoxturu.Text = read[3].ToString();
                textBoxcalısan.Text = read[4].ToString();
                textBoxsırket.Text = read[2].ToString();
               
            }
            con.Close();
        }

        private void buttonmagazaara2_Click(object sender, EventArgs e)
        {

            textBoxad2.Clear();
            textBoxsorumlu2.Clear();
            textBoxkıra2.Clear();
            textBoxturu2.Clear();
            textBoxsırket2.Clear();
            textBoxcalısan2.Clear();


            panel3.Visible = true;
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            MySqlCommand komut = new MySqlCommand("select *  from magaza  where idmagaza like '" + comboBox2.Text + "'", con);

            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                textBoxad2.Text = read[1].ToString();
                textBoxsorumlu2.Text = read[5].ToString();
                textBoxkıra2.Text = read[6].ToString();
                textBoxturu2.Text = read[3].ToString();
                textBoxcalısan2.Text = read[4].ToString();
                textBoxsırket2.Text = read[2].ToString();
            }
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
