using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AVM_YÖNETİM_SİSTEMİ
{
    public partial class Etkinlikler : Form
    {
        public Etkinlikler()
        {
            InitializeComponent();
        }
       

        private void Etkinlikler_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
                        //bu sayfadaki kodların kaynagı 
                             //https://www.youtube.com/watch?v=_Yo6FCyitwc&list=LL&index=7
        void griddoldur()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From etkınlık", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "etkınlık");
            dataGridView1.DataSource = ds.Tables["etkınlık"];
            con.Close();
        }

        private void buttonetkinlikekle_Click(object sender, EventArgs e)
        {
           
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "insert into etkınlık(idetkınlık,Etkınlıkadı,Etkınlıkbaslangıc,Etkınlıkbıtıs,Etkınlıkturu,Etkınlıkbutce) values (@idetkınlık,@Etkınlıkadı,@Etkınlıkbaslangıc,@Etkınlıkbıtıs,@Etkınlıkturu,@Etkınlıkbutce)";
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlCommand com1 = new MySqlCommand(sql, con);
            MySqlDataReader dr;
            com1.CommandText = "SELECT * FROM etkınlık where idetkınlık='" + textBoxetkinlikid.Text + "' ";
            dr = com1.ExecuteReader();

            if (textBoxetkinlikid.Text == "" || dr.Read() ) { MessageBox.Show("LÜTFEN İD GİRİNİZ VEYA İD KONTROL EDİNİZ"); }
            else
            {
               com1.Dispose();
                dr.Close();
                
                

            com.Parameters.AddWithValue("@idetkınlık", textBoxetkinlikid.Text);
            com.Parameters.AddWithValue("@Etkınlıkadı", textBoxetkinlikadı.Text);
            com.Parameters.AddWithValue("@Etkınlıkbaslangıc", dateTimePickerbaslama.Value);
            com.Parameters.AddWithValue("@Etkınlıkbıtıs", dateTimePickerbitis.Value);
            com.Parameters.AddWithValue("@Etkınlıkturu", comboBoxtur.SelectedItem.ToString());
            com.Parameters.AddWithValue("@Etkınlıkbutce", Convert.ToInt32(textBoxetkinlikbutcesi.Text));

            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
           
                MessageBox.Show("ETKİNLİK KAYDI YAPILMIŞTIR");
                griddoldur();
                textBoxetkinlikadı.Clear();
                textBoxetkinlikbutcesi.Clear();
                textBoxetkinlikid.Clear();
            }
           
        }

        private void buttonetkinlikgüncel_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "update  etkınlık set idetkınlık=@idetkınlık,Etkınlıkadı=@Etkınlıkadı,Etkınlıkbaslangıc=@Etkınlıkbaslangıc,Etkınlıkbıtıs=@Etkınlıkbıtıs,Etkınlıkturu=@Etkınlıkturu,Etkınlıkbutce=@Etkınlıkbutce   where idetkınlık=@idetkınlık ";
           
            
            MySqlCommand com = new MySqlCommand(sql, con);
           
            com.Parameters.AddWithValue("@idetkınlık", textBoxetkinlikid.Text); 
            com.Parameters.AddWithValue("@Etkınlıkadı", textBoxetkinlikadı.Text);
            com.Parameters.AddWithValue("@Etkınlıkbaslangıc", dateTimePickerbaslama.Value);
            com.Parameters.AddWithValue("@Etkınlıkbıtıs", dateTimePickerbitis.Value);
            com.Parameters.AddWithValue("@Etkınlıkturu", comboBoxtur.SelectedItem.ToString());
            com.Parameters.AddWithValue("@Etkınlıkbutce", Convert.ToInt32(textBoxetkinlikbutcesi.Text));
            
            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("ETKİNLİK KAYDI GÜNCELLENMİŞTİR");
            griddoldur();
            textBoxetkinlikadı.Clear();
            textBoxetkinlikbutcesi.Clear();
            textBoxetkinlikid.Clear();
        }

        private void buttonetkinliksil_Click(object sender, EventArgs e)
        {
            string yol = "Server=localhost;Port=3306;Database=avm;Uid=root;Pwd=1734;";
            MySqlConnection con = new MySqlConnection(yol);
            con.Open();

            string sql = "DELETE FROM etkınlık WHERE idetkınlık=@idetkınlık";
            MySqlCommand com = new MySqlCommand(sql, con);
            
           
            com.Parameters.AddWithValue("@idetkınlık", textBoxetkinlikid.Text);
           

            com.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            com.Dispose();
            MessageBox.Show("ETKİNLİK KAYDI SİLİNMİŞTİR");
            griddoldur();
            textBoxetkinlikadı.Clear();
            textBoxetkinlikbutcesi.Clear();
            textBoxetkinlikid.Clear();
        }
    }
}
