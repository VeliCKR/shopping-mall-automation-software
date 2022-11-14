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
    public partial class Hizmetler : Form
    {
        public Hizmetler()
        {
            InitializeComponent();                  //bu sayfadaki kaynak aynıdır (veri ekleme guncelleme sılme )
        }                                                     //https://www.youtube.com/watch?v=_Yo6FCyitwc&list=LL&index=7
        void griddoldur()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From hızmetler", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "hızmetler");
            dataGridView1.DataSource = ds.Tables["hızmetler"];
            con.Close();
        }

        private void buttonhizmetekle_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "insert into hızmetler(idhızmetler,hızmetturu,hızmetsaglayıcı,hızmetbaslangıc,hızmetbıtıs,hızmetmalıyetı) values (@idHızmetler,@Hızmetturu,@Hızmetsaglayıcı,@Hızmetbaslangıc,@Hızmetbıtıs,@Hızmetmalıyetı)";
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlCommand com1 = new MySqlCommand(sql, con);
            MySqlDataReader dr;
            com1.CommandText = "SELECT * FROM hızmetler where idhızmetler='" + textBoxhizmetid.Text + "' ";
            dr = com1.ExecuteReader();

            if (textBoxhizmetid.Text == "" || dr.Read()) { MessageBox.Show("LÜTFEN İD GİRİNİZ VEYA İD KONTROL EDİNİZ"); }
            else
            {
                com1.Dispose();
                dr.Close();



                com.Parameters.AddWithValue("@idHızmetler", textBoxhizmetid.Text);
                com.Parameters.AddWithValue("@Hızmetturu", comboBoxhizmetturu.Text);
                com.Parameters.AddWithValue("@Hızmetsaglayıcı", textBoxhizmetsaglayıcı.Text);
                com.Parameters.AddWithValue("@Hızmetbaslangıc", dateTimehizmetbaslangıc.Value);
                com.Parameters.AddWithValue("@Hızmetbıtıs", dateTimehizmetbitis.Value);
                com.Parameters.AddWithValue("@Hızmetmalıyetı", Convert.ToInt32(textBoxhizmetmaliyeti.Text));

                com.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                com.Dispose();

                MessageBox.Show("HİZMET KAYDI YAPILMIŞTIR");
                griddoldur();
                textBoxhizmetmaliyeti.Clear();
                textBoxhizmetid.Clear();
                textBoxhizmetsaglayıcı.Clear();
            }
        }

        private void buttonhizmetgüncel_Click(object sender, EventArgs e)
        {

            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "update  hızmetler set idhızmetler=@idHızmetler,hızmetturu=@Hızmetturu,hızmetsaglayıcı=@Hızmetsaglayıcı,hızmetbaslangıc=@Hızmetbaslangıc,hızmetbıtıs=@Hızmetbıtıs,hızmetmalıyetı=@Hızmetmalıyetı   where idhızmetler=@idHızmetler ";


            MySqlCommand com = new MySqlCommand(sql, con);

            com.Parameters.AddWithValue("@idHızmetler", textBoxhizmetid.Text);
            com.Parameters.AddWithValue("@Hızmetturu", comboBoxhizmetturu.Text);
            com.Parameters.AddWithValue("@Hızmetsaglayıcı", textBoxhizmetsaglayıcı.Text);
            com.Parameters.AddWithValue("@Hızmetbaslangıc", dateTimehizmetbaslangıc.Value);
            com.Parameters.AddWithValue("@Hızmetbıtıs", dateTimehizmetbitis.Value);
            com.Parameters.AddWithValue("@Hızmetmalıyetı", Convert.ToInt32(textBoxhizmetmaliyeti.Text));

            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("HİZMET KAYDI GÜNCELLENMİŞTİR");
            griddoldur();
            textBoxhizmetmaliyeti.Clear();
            textBoxhizmetid.Clear();
            textBoxhizmetsaglayıcı.Clear();
        }

        private void buttonhizmetsil_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "DELETE FROM hızmetler WHERE idhızmetler=@idhızmetler";
            MySqlCommand com = new MySqlCommand(sql, con);


            com.Parameters.AddWithValue("@idhızmetler", textBoxhizmetid.Text);


            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("HİZMET KAYDI SİLİNMİŞTİR");
            griddoldur();
            textBoxhizmetmaliyeti.Clear();
            textBoxhizmetid.Clear();
            textBoxhizmetsaglayıcı.Clear();
        }

        private void Hizmetler_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void comboBoxhizmetperiyot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxhizmetperiyot.SelectedIndex == 0)
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM hızmetler WHERE hızmetbıtıs >= NOW() - INTERVAL 1 month", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "hızmetler");
                dataGridView1.DataSource = ds.Tables["hızmetler"];
                con.Close();
            }
            else if (comboBoxhizmetperiyot.SelectedIndex == 1)
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM hızmetler WHERE hızmetbıtıs >= NOW() - INTERVAL 3 month", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "hızmetler");
                dataGridView1.DataSource = ds.Tables["hızmetler"];
                con.Close();
            }
            else if (comboBoxhizmetperiyot.SelectedIndex == 2)
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM hızmetler WHERE hızmetbıtıs >= NOW() - INTERVAL 6 month", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "hızmetler");
                dataGridView1.DataSource = ds.Tables["hızmetler"];
                con.Close();
            }
            else if (comboBoxhizmetperiyot.SelectedIndex == 3)
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM hızmetler WHERE hızmetbıtıs >= NOW() - INTERVAL 12 month", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "hızmetler");
                dataGridView1.DataSource = ds.Tables["hızmetler"];
                con.Close();
            }
            else if (comboBoxhizmetperiyot.SelectedIndex == 4)
            {
                griddoldur();
            }
            else {
                griddoldur();
            }
        }
    }
}
