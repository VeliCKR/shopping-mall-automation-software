using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVM_YÖNETİM_SİSTEMİ
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }
        private void Formgosterme(Form goster) 
        {                                                                    // https://www.youtube.com/watch?v=4kiqXLJkMIY
                                                                                 // videodan yararlanılarak oluşturulmuştur
            anapanel.Controls.Clear();
            goster.MdiParent = this;
            goster.FormBorderStyle = FormBorderStyle.None;
            anapanel.Controls.Add(goster);
            goster.Show();
        }

        private void btndepartman_Click(object sender, EventArgs e)
        {
            Departmanlar departman = new Departmanlar();
            Formgosterme(departman);
        }

        public void AnaForm_Load(object sender, EventArgs e)
        {
         
          
            
        }

        private void btnbılanco_Click(object sender, EventArgs e)
        {
            Bilanço bilanco = new Bilanço();
            Formgosterme(bilanco);
        }

        private void btncks_Click(object sender, EventArgs e)
        {

            DialogResult secım = MessageBox.Show("Uygulamayı kapatmaya eminmisin?",
 "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (secım== DialogResult.Yes)
            {
              
                Application.Exit(); 
            }
            else
            {
                
            }

        }

        private void btnmagazalar_Click(object sender, EventArgs e)
        {
            Magazalar magaza = new Magazalar();
            Formgosterme(magaza);
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();
            Formgosterme(personel);
        }

        private void btnetkınlık_Click(object sender, EventArgs e)
        {
            Etkinlikler etkinlik = new Etkinlikler();
            Formgosterme(etkinlik);
        }

        private void btnhızmetler_Click(object sender, EventArgs e)
        {
            Hizmetler hizmet = new Hizmetler();
            Formgosterme(hizmet);
        }

        private void bsdbzbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonreklamlar_Click(object sender, EventArgs e)
        {
            Reklamlar reklam = new Reklamlar();
            Formgosterme(reklam);   
        }

        private void mAĞAZALARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magazalar magaza1 = new Magazalar();
            Formgosterme(magaza1);
        }

        private void fmfmmfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personeller personel1 = new Personeller();  
            Formgosterme(personel1);
        }

        private void dvzvzdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departmanlar departmanlar1 = new Departmanlar();
            Formgosterme(departmanlar1);
        }

        private void nxfgnxgnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etkinlikler etkınlık1 = new Etkinlikler();
            Formgosterme(etkınlık1);
        }

        private void rEKLAMLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reklamlar reklam1 = new Reklamlar();
            Formgosterme(reklam1);
        }

        private void hİZMETLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hizmetler hizmet1 = new Hizmetler();
            Formgosterme(hizmet1);
        }

        private void hGFDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilanço bilanco1 = new Bilanço();
            Formgosterme(bilanco1);
        }
    }
}
