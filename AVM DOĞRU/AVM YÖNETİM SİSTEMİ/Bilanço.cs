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
    public partial class Bilanço : Form
    {
        public Bilanço()
        {
            InitializeComponent();
        }

        private void Bilanço_Load(object sender, EventArgs e)
        {
            griddoldur();
            griddoldur1();                   //FONKSİYONLARDA KULLANILAN KAYNAK 
                                             //https://www.w3schools.com/sql/func_mysql_sum.asp
           //griddoldur2();

        }
        void griddoldur()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select SUM(etkınlıkbutce) AS TOPLAMETKINLIKBUTCESI , SUM(personelmaası) TOPLAMPERSONELGIDERI , SUM(hızmetmalıyetı) as TOPLAMHIZMETMALIYETI   From etkınlık,personel,hızmetler ", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "gider");                                                     
            dataGridView2.DataSource = ds.Tables["gider"];
            
            con.Close();

          

        }
        void griddoldur1()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT SUM(magazakıra) as toplamkırageliri, SUM(reklamfiyatı) as toplamreklamgeliri  FROM magaza,reklam ;", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "gelir");
            dataGridView1.DataSource = ds.Tables["gelir"];
       
            con.Close();
        }
       /* void griddoldur2()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT SUM(magazakıra) as toplamkırageliri, SUM(reklamfiyatı) as toplamreklamgeliri  FROM magaza,reklam ;", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "toplam");
            dataGridView3.DataSource = ds.Tables["toplam"];
           
            con.Close();
        }*/
    }
}
