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
    public partial class Reklamlar : Form
    {
        public Reklamlar()
        {
            InitializeComponent();                      //bu sayfadaki kaynak aynıdır (veri ekleme guncelleme sılme )
        }                                                     //https://www.youtube.com/watch?v=_Yo6FCyitwc&list=LL&index=7
    

        private void buttonreklamekle_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "insert into reklam(idreklam,reklamadı,reklambaslangıc,reklambıtıs,reklamturu,reklamfiyatı) values (@idreklam,@Reklamadı,@Reklambaslangıc,@Reklambıtıs,@Reklamturu,@Reklamfiyatı)";
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlCommand com1 = new MySqlCommand(sql, con);
            MySqlDataReader dr;
            com1.CommandText = "SELECT * FROM reklam where idreklam='" + textBoxreklamid.Text + "' ";
            dr = com1.ExecuteReader();

            if (textBoxreklamid.Text == "" || dr.Read()) { MessageBox.Show("LÜTFEN İD GİRİNİZ VEYA İD KONTROL EDİNİZ"); }
            else
            {
                com1.Dispose();
                dr.Close();



                com.Parameters.AddWithValue("@idreklam", textBoxreklamid.Text);
                com.Parameters.AddWithValue("@Reklamadı", textBoxreklamadı.Text);
                com.Parameters.AddWithValue("@Reklambaslangıc", dateTimePickerbaslama.Value);
                com.Parameters.AddWithValue("@Reklambıtıs", dateTimePickerbitis.Value);
                com.Parameters.AddWithValue("@Reklamturu", comboBoxtur.SelectedItem.ToString());
                com.Parameters.AddWithValue("@Reklamfiyatı", Convert.ToInt32(textBoxreklamfiyatı.Text));

                com.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                com.Dispose();

                MessageBox.Show("REKLAM KAYDI YAPILMIŞTIR");
                griddoldur();
                textBoxreklamadı.Clear();
                textBoxreklamfiyatı.Clear();
                textBoxreklamid.Clear();
            }
        }

        private void buttonreklamgüncel_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "update  reklam set idreklam=@idreklam,reklamadı=@Reklamadı,reklambaslangıc=@Reklambaslangıc,reklambıtıs=@Reklambıtıs,reklamturu=@Reklamturu,reklamfiyatı=@Reklamfiyatı   where idreklam=@idreklam ";


            MySqlCommand com = new MySqlCommand(sql, con);

            com.Parameters.AddWithValue("@idreklam", textBoxreklamid.Text);
            com.Parameters.AddWithValue("@Reklamadı", textBoxreklamadı.Text);
            com.Parameters.AddWithValue("@Reklambaslangıc", dateTimePickerbaslama.Value);
            com.Parameters.AddWithValue("@Reklambıtıs", dateTimePickerbitis.Value);
            com.Parameters.AddWithValue("@Reklamturu", comboBoxtur.SelectedItem.ToString());
            com.Parameters.AddWithValue("@Reklamfiyatı", Convert.ToInt32(textBoxreklamfiyatı.Text));

            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("REKLAM KAYDI GÜNCELLENMİŞTİR");
            griddoldur();
            textBoxreklamadı.Clear();
            textBoxreklamfiyatı.Clear();
            textBoxreklamid.Clear();
        }

        private void buttonreklamsil_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "DELETE FROM reklam WHERE idreklam=@idreklam";
            MySqlCommand com = new MySqlCommand(sql, con);


            com.Parameters.AddWithValue("@idreklam", textBoxreklamid.Text);


            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("REKLAM KAYDI SİLİNMİŞTİR");
            griddoldur();
            textBoxreklamadı.Clear();
            textBoxreklamfiyatı.Clear();
            textBoxreklamid.Clear();
        }
        void griddoldur()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From reklam", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "reklam");
            dataGridView1.DataSource = ds.Tables["reklam"];
            con.Close();
        }

        private void Reklamlar_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
    }
}
