namespace AVM_YÖNETİM_SİSTEMİ
{
    partial class formgrs
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxgiris = new System.Windows.Forms.TextBox();
            this.textBoxsıfre = new System.Windows.Forms.TextBox();
            this.lblyönetici = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btngrs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblavmad = new System.Windows.Forms.Label();
            this.btncıkıs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxgiris
            // 
            this.textBoxgiris.Location = new System.Drawing.Point(491, 79);
            this.textBoxgiris.Name = "textBoxgiris";
            this.textBoxgiris.Size = new System.Drawing.Size(123, 20);
            this.textBoxgiris.TabIndex = 1;
            // 
            // textBoxsıfre
            // 
            this.textBoxsıfre.Location = new System.Drawing.Point(491, 146);
            this.textBoxsıfre.Name = "textBoxsıfre";
            this.textBoxsıfre.PasswordChar = '*';
            this.textBoxsıfre.Size = new System.Drawing.Size(123, 20);
            this.textBoxsıfre.TabIndex = 2;
            // 
            // lblyönetici
            // 
            this.lblyönetici.AutoSize = true;
            this.lblyönetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyönetici.Location = new System.Drawing.Point(340, 86);
            this.lblyönetici.Name = "lblyönetici";
            this.lblyönetici.Size = new System.Drawing.Size(87, 13);
            this.lblyönetici.TabIndex = 3;
            this.lblyönetici.Text = "YÖNETİCİ NO";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(340, 149);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(43, 13);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "ŞİFRE";
            // 
            // btngrs
            // 
            this.btngrs.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btngrs.FlatAppearance.BorderSize = 0;
            this.btngrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrs.ImageKey = "(yok)";
            this.btngrs.Location = new System.Drawing.Point(491, 221);
            this.btngrs.Name = "btngrs";
            this.btngrs.Size = new System.Drawing.Size(123, 23);
            this.btngrs.TabIndex = 5;
            this.btngrs.Text = "GİRİŞ";
            this.btngrs.UseVisualStyleBackColor = false;
            this.btngrs.Click += new System.EventHandler(this.btngrs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifremi Unuttum";
            this.label3.Visible = false;
            // 
            // lblavmad
            // 
            this.lblavmad.AutoSize = true;
            this.lblavmad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblavmad.Location = new System.Drawing.Point(233, 19);
            this.lblavmad.Name = "lblavmad";
            this.lblavmad.Size = new System.Drawing.Size(134, 13);
            this.lblavmad.TabIndex = 8;
            this.lblavmad.Text = " ALIŞVERİŞ MERKEZİ";
            this.lblavmad.Click += new System.EventHandler(this.lblavmad_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncıkıs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncıkıs.FlatAppearance.BorderSize = 0;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncıkıs.Location = new System.Drawing.Point(343, 221);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(105, 23);
            this.btncıkıs.TabIndex = 9;
            this.btncıkıs.Text = "ÇIKIŞ";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // formgrs
            // 
            this.AcceptButton = this.btngrs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btncıkıs;
            this.ClientSize = new System.Drawing.Size(652, 288);
            this.ControlBox = false;
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.lblavmad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngrs);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblyönetici);
            this.Controls.Add(this.textBoxsıfre);
            this.Controls.Add(this.textBoxgiris);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formgrs";
            this.Text = "KULLANICI GİRİŞ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formgrs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxgiris;
        private System.Windows.Forms.TextBox textBoxsıfre;
        private System.Windows.Forms.Label lblyönetici;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Button btngrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblavmad;
        private System.Windows.Forms.Button btncıkıs;
    }
}

