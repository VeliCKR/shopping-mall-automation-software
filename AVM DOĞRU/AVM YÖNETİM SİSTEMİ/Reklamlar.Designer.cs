namespace AVM_YÖNETİM_SİSTEMİ
{
    partial class Reklamlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxreklamid = new System.Windows.Forms.TextBox();
            this.labelreklamıd = new System.Windows.Forms.Label();
            this.textBoxreklamfiyatı = new System.Windows.Forms.TextBox();
            this.labelreklamfiyatı = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonreklamsil = new System.Windows.Forms.Button();
            this.buttonreklamekle = new System.Windows.Forms.Button();
            this.comboBoxtur = new System.Windows.Forms.ComboBox();
            this.dateTimePickerbitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerbaslama = new System.Windows.Forms.DateTimePicker();
            this.buttonreklamgüncel = new System.Windows.Forms.Button();
            this.textBoxreklamadı = new System.Windows.Forms.TextBox();
            this.labelreklamtur = new System.Windows.Forms.Label();
            this.labelbıtıstarıhı = new System.Windows.Forms.Label();
            this.labelbaslamatarih = new System.Windows.Forms.Label();
            this.labelreklamad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxreklamid
            // 
            this.textBoxreklamid.Location = new System.Drawing.Point(518, 61);
            this.textBoxreklamid.Name = "textBoxreklamid";
            this.textBoxreklamid.Size = new System.Drawing.Size(100, 20);
            this.textBoxreklamid.TabIndex = 47;
            // 
            // labelreklamıd
            // 
            this.labelreklamıd.AutoSize = true;
            this.labelreklamıd.Location = new System.Drawing.Point(529, 32);
            this.labelreklamıd.Name = "labelreklamıd";
            this.labelreklamıd.Size = new System.Drawing.Size(65, 13);
            this.labelreklamıd.TabIndex = 46;
            this.labelreklamıd.Text = "REKLAM İD";
            // 
            // textBoxreklamfiyatı
            // 
            this.textBoxreklamfiyatı.Location = new System.Drawing.Point(227, 223);
            this.textBoxreklamfiyatı.Name = "textBoxreklamfiyatı";
            this.textBoxreklamfiyatı.Size = new System.Drawing.Size(121, 20);
            this.textBoxreklamfiyatı.TabIndex = 45;
            // 
            // labelreklamfiyatı
            // 
            this.labelreklamfiyatı.AutoSize = true;
            this.labelreklamfiyatı.Location = new System.Drawing.Point(97, 223);
            this.labelreklamfiyatı.Name = "labelreklamfiyatı";
            this.labelreklamfiyatı.Size = new System.Drawing.Size(87, 13);
            this.labelreklamfiyatı.TabIndex = 44;
            this.labelreklamfiyatı.Text = "REKLAM FİYATI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 258);
            this.dataGridView1.TabIndex = 43;
            // 
            // buttonreklamsil
            // 
            this.buttonreklamsil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonreklamsil.FlatAppearance.BorderSize = 0;
            this.buttonreklamsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreklamsil.Location = new System.Drawing.Point(704, 126);
            this.buttonreklamsil.Name = "buttonreklamsil";
            this.buttonreklamsil.Size = new System.Drawing.Size(150, 23);
            this.buttonreklamsil.TabIndex = 42;
            this.buttonreklamsil.Text = "REKLAM SİL";
            this.buttonreklamsil.UseVisualStyleBackColor = false;
            this.buttonreklamsil.Click += new System.EventHandler(this.buttonreklamsil_Click);
            // 
            // buttonreklamekle
            // 
            this.buttonreklamekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonreklamekle.FlatAppearance.BorderSize = 0;
            this.buttonreklamekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreklamekle.Location = new System.Drawing.Point(704, 32);
            this.buttonreklamekle.Name = "buttonreklamekle";
            this.buttonreklamekle.Size = new System.Drawing.Size(150, 23);
            this.buttonreklamekle.TabIndex = 41;
            this.buttonreklamekle.Text = "REKLAM EKLE";
            this.buttonreklamekle.UseVisualStyleBackColor = false;
            this.buttonreklamekle.Click += new System.EventHandler(this.buttonreklamekle_Click);
            // 
            // comboBoxtur
            // 
            this.comboBoxtur.FormattingEnabled = true;
            this.comboBoxtur.Items.AddRange(new object[] {
            "GİYİM",
            "TEKNOLOJİ /BEYAZ EŞYA",
            "ZÜCCACİYE",
            "MARKET",
            "YEMEK"});
            this.comboBoxtur.Location = new System.Drawing.Point(227, 167);
            this.comboBoxtur.Name = "comboBoxtur";
            this.comboBoxtur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxtur.TabIndex = 40;
            // 
            // dateTimePickerbitis
            // 
            this.dateTimePickerbitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerbitis.Location = new System.Drawing.Point(227, 125);
            this.dateTimePickerbitis.Name = "dateTimePickerbitis";
            this.dateTimePickerbitis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerbitis.TabIndex = 39;
            // 
            // dateTimePickerbaslama
            // 
            this.dateTimePickerbaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerbaslama.Location = new System.Drawing.Point(227, 77);
            this.dateTimePickerbaslama.Name = "dateTimePickerbaslama";
            this.dateTimePickerbaslama.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerbaslama.TabIndex = 38;
            // 
            // buttonreklamgüncel
            // 
            this.buttonreklamgüncel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonreklamgüncel.FlatAppearance.BorderSize = 0;
            this.buttonreklamgüncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreklamgüncel.Location = new System.Drawing.Point(704, 78);
            this.buttonreklamgüncel.Name = "buttonreklamgüncel";
            this.buttonreklamgüncel.Size = new System.Drawing.Size(150, 23);
            this.buttonreklamgüncel.TabIndex = 37;
            this.buttonreklamgüncel.Text = "REKLAM GÜNCELLEME";
            this.buttonreklamgüncel.UseVisualStyleBackColor = false;
            this.buttonreklamgüncel.Click += new System.EventHandler(this.buttonreklamgüncel_Click);
            // 
            // textBoxreklamadı
            // 
            this.textBoxreklamadı.Location = new System.Drawing.Point(227, 32);
            this.textBoxreklamadı.Name = "textBoxreklamadı";
            this.textBoxreklamadı.Size = new System.Drawing.Size(100, 20);
            this.textBoxreklamadı.TabIndex = 36;
            // 
            // labelreklamtur
            // 
            this.labelreklamtur.AutoSize = true;
            this.labelreklamtur.Location = new System.Drawing.Point(94, 176);
            this.labelreklamtur.Name = "labelreklamtur";
            this.labelreklamtur.Size = new System.Drawing.Size(85, 13);
            this.labelreklamtur.TabIndex = 35;
            this.labelreklamtur.Text = "REKLAM TÜRÜ";
            // 
            // labelbıtıstarıhı
            // 
            this.labelbıtıstarıhı.AutoSize = true;
            this.labelbıtıstarıhı.Location = new System.Drawing.Point(94, 125);
            this.labelbıtıstarıhı.Name = "labelbıtıstarıhı";
            this.labelbıtıstarıhı.Size = new System.Drawing.Size(73, 13);
            this.labelbıtıstarıhı.TabIndex = 34;
            this.labelbıtıstarıhı.Text = "BİTİŞ TARİHİ";
            // 
            // labelbaslamatarih
            // 
            this.labelbaslamatarih.AutoSize = true;
            this.labelbaslamatarih.Location = new System.Drawing.Point(94, 77);
            this.labelbaslamatarih.Name = "labelbaslamatarih";
            this.labelbaslamatarih.Size = new System.Drawing.Size(99, 13);
            this.labelbaslamatarih.TabIndex = 33;
            this.labelbaslamatarih.Text = "BAŞLAMA TARİHİ ";
            // 
            // labelreklamad
            // 
            this.labelreklamad.AutoSize = true;
            this.labelreklamad.Location = new System.Drawing.Point(94, 32);
            this.labelreklamad.Name = "labelreklamad";
            this.labelreklamad.Size = new System.Drawing.Size(72, 13);
            this.labelreklamad.TabIndex = 32;
            this.labelreklamad.Text = "REKLAM ADI";
            // 
            // Reklamlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1165, 618);
            this.Controls.Add(this.textBoxreklamid);
            this.Controls.Add(this.labelreklamıd);
            this.Controls.Add(this.textBoxreklamfiyatı);
            this.Controls.Add(this.labelreklamfiyatı);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonreklamsil);
            this.Controls.Add(this.buttonreklamekle);
            this.Controls.Add(this.comboBoxtur);
            this.Controls.Add(this.dateTimePickerbitis);
            this.Controls.Add(this.dateTimePickerbaslama);
            this.Controls.Add(this.buttonreklamgüncel);
            this.Controls.Add(this.textBoxreklamadı);
            this.Controls.Add(this.labelreklamtur);
            this.Controls.Add(this.labelbıtıstarıhı);
            this.Controls.Add(this.labelbaslamatarih);
            this.Controls.Add(this.labelreklamad);
            this.Name = "Reklamlar";
            this.Text = "Reklamlar";
            this.Load += new System.EventHandler(this.Reklamlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxreklamid;
        private System.Windows.Forms.Label labelreklamıd;
        private System.Windows.Forms.TextBox textBoxreklamfiyatı;
        private System.Windows.Forms.Label labelreklamfiyatı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonreklamsil;
        private System.Windows.Forms.Button buttonreklamekle;
        private System.Windows.Forms.ComboBox comboBoxtur;
        private System.Windows.Forms.DateTimePicker dateTimePickerbitis;
        private System.Windows.Forms.DateTimePicker dateTimePickerbaslama;
        private System.Windows.Forms.Button buttonreklamgüncel;
        private System.Windows.Forms.TextBox textBoxreklamadı;
        private System.Windows.Forms.Label labelreklamtur;
        private System.Windows.Forms.Label labelbıtıstarıhı;
        private System.Windows.Forms.Label labelbaslamatarih;
        private System.Windows.Forms.Label labelreklamad;
    }
}