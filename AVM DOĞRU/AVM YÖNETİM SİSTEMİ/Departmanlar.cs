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
    public partial class Departmanlar : Form
    {
        public Departmanlar()
        {
            InitializeComponent();
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {

        }
        void griddoldur(string getir)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Pwd=1734;Database=avm;Uid=root;Integrated Security=SSPI");
            MySqlDataAdapter da = new MySqlDataAdapter("Select *From personel where personeldepartman like '"+ comboBoxdepartman.Text +"'", con);
            DataSet ds = new DataSet();                         
            con.Open();
            da.Fill(ds, "personel");                                                // buradaki arama fonksiyonun kaynagı
            dataGridView1.DataSource = ds.Tables["personel"];                           //https://www.w3schools.com/sql/sql_where.asp
            con.Close();
        }

        private void comboBoxdepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departman = comboBoxdepartman.Text;
            griddoldur(departman);
        }
    }
}
