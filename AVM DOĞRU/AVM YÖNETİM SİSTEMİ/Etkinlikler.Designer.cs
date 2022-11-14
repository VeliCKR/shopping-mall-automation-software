namespace AVM_YÖNETİM_SİSTEMİ
{
    partial class Etkinlikler
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
            this.comboBoxtur = new System.Windows.Forms.ComboBox();
            this.dateTimePickerbitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerbaslama = new System.Windows.Forms.DateTimePicker();
            this.buttonetkinlikgüncel = new System.Windows.Forms.Button();
            this.textBoxetkinlikadı = new System.Windows.Forms.TextBox();
            this.labeletkinliktur = new System.Windows.Forms.Label();
            this.labelbıtıstarıhı = new System.Windows.Forms.Label();
            this.labelbaslamatarih = new System.Windows.Forms.Label();
            this.labeletkinlikad = new System.Windows.Forms.Label();
            this.buttonetkinlikekle = new System.Windows.Forms.Button();
            this.buttonetkinliksil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labeletkinlikbutcesi = new System.Windows.Forms.Label();
            this.textBoxetkinlikbutcesi = new System.Windows.Forms.TextBox();
            this.labeletkinlikıd = new System.Windows.Forms.Label();
            this.textBoxetkinlikid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxtur
            // 
            this.comboBoxtur.FormattingEnabled = true;
            this.comboBoxtur.Items.AddRange(new object[] {
            "BAYRAM ",
            "YILBAŞI",
            "ÖZEL ",
            "KURULUŞ"});
            this.comboBoxtur.Location = new System.Drawing.Point(260, 211);
            this.comboBoxtur.Name = "comboBoxtur";
            this.comboBoxtur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxtur.TabIndex = 24;
            // 
            // dateTimePickerbitis
            // 
            this.dateTimePickerbitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerbitis.Location = new System.Drawing.Point(260, 169);
            this.dateTimePickerbitis.Name = "dateTimePickerbitis";
            this.dateTimePickerbitis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerbitis.TabIndex = 23;
            // 
            // dateTimePickerbaslama
            // 
            this.dateTimePickerbaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerbaslama.Location = new System.Drawing.Point(260, 121);
            this.dateTimePickerbaslama.Name = "dateTimePickerbaslama";
            this.dateTimePickerbaslama.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerbaslama.TabIndex = 22;
            // 
            // buttonetkinlikgüncel
            // 
            this.buttonetkinlikgüncel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonetkinlikgüncel.FlatAppearance.BorderSize = 0;
            this.buttonetkinlikgüncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonetkinlikgüncel.Location = new System.Drawing.Point(737, 122);
            this.buttonetkinlikgüncel.Name = "buttonetkinlikgüncel";
            this.buttonetkinlikgüncel.Size = new System.Drawing.Size(150, 23);
            this.buttonetkinlikgüncel.TabIndex = 21;
            this.buttonetkinlikgüncel.Text = "ETKİNLİK GÜNCELLEME";
            this.buttonetkinlikgüncel.UseVisualStyleBackColor = false;
            this.buttonetkinlikgüncel.Click += new System.EventHandler(this.buttonetkinlikgüncel_Click);
            // 
            // textBoxetkinlikadı
            // 
            this.textBoxetkinlikadı.Location = new System.Drawing.Point(260, 76);
            this.textBoxetkinlikadı.Name = "textBoxetkinlikadı";
            this.textBoxetkinlikadı.Size = new System.Drawing.Size(100, 20);
            this.textBoxetkinlikadı.TabIndex = 19;
            // 
            // labeletkinliktur
            // 
            this.labeletkinliktur.AutoSize = true;
            this.labeletkinliktur.Location = new System.Drawing.Point(127, 220);
            this.labeletkinliktur.Name = "labeletkinliktur";
            this.labeletkinliktur.Size = new System.Drawing.Size(89, 13);
            this.labeletkinliktur.TabIndex = 17;
            this.labeletkinliktur.Text = "ETKİNLİK TÜRÜ";
            // 
            // labelbıtıstarıhı
            // 
            this.labelbıtıstarıhı.AutoSize = true;
            this.labelbıtıstarıhı.Location = new System.Drawing.Point(127, 169);
            this.labelbıtıstarıhı.Name = "labelbıtıstarıhı";
            this.labelbıtıstarıhı.Size = new System.Drawing.Size(73, 13);
            this.labelbıtıstarıhı.TabIndex = 16;
            this.labelbıtıstarıhı.Text = "BİTİŞ TARİHİ";
            // 
            // labelbaslamatarih
            // 
            this.labelbaslamatarih.AutoSize = true;
            this.labelbaslamatarih.Location = new System.Drawing.Point(127, 121);
            this.labelbaslamatarih.Name = "labelbaslamatarih";
            this.labelbaslamatarih.Size = new System.Drawing.Size(99, 13);
            this.labelbaslamatarih.TabIndex = 15;
            this.labelbaslamatarih.Text = "BAŞLAMA TARİHİ ";
            // 
            // labeletkinlikad
            // 
            this.labeletkinlikad.AutoSize = true;
            this.labeletkinlikad.Location = new System.Drawing.Point(127, 76);
            this.labeletkinlikad.Name = "labeletkinlikad";
            this.labeletkinlikad.Size = new System.Drawing.Size(76, 13);
            this.labeletkinlikad.TabIndex = 14;
            this.labeletkinlikad.Text = "ETKİNLİK ADI";
            // 
            // buttonetkinlikekle
            // 
            this.buttonetkinlikekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonetkinlikekle.FlatAppearance.BorderSize = 0;
            this.buttonetkinlikekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonetkinlikekle.Location = new System.Drawing.Point(737, 76);
            this.buttonetkinlikekle.Name = "buttonetkinlikekle";
            this.buttonetkinlikekle.Size = new System.Drawing.Size(150, 23);
            this.buttonetkinlikekle.TabIndex = 25;
            this.buttonetkinlikekle.Text = "ETKİNLİK EKLE";
            this.buttonetkinlikekle.UseVisualStyleBackColor = false;
            this.buttonetkinlikekle.Click += new System.EventHandler(this.buttonetkinlikekle_Click);
            // 
            // buttonetkinliksil
            // 
            this.buttonetkinliksil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonetkinliksil.FlatAppearance.BorderSize = 0;
            this.buttonetkinliksil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonetkinliksil.Location = new System.Drawing.Point(737, 170);
            this.buttonetkinliksil.Name = "buttonetkinliksil";
            this.buttonetkinliksil.Size = new System.Drawing.Size(150, 23);
            this.buttonetkinliksil.TabIndex = 26;
            this.buttonetkinliksil.Text = "ETKİNLİK SİL";
            this.buttonetkinliksil.UseVisualStyleBackColor = false;
            this.buttonetkinliksil.Click += new System.EventHandler(this.buttonetkinliksil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 258);
            this.dataGridView1.TabIndex = 27;
            // 
            // labeletkinlikbutcesi
            // 
            this.labeletkinlikbutcesi.AutoSize = true;
            this.labeletkinlikbutcesi.Location = new System.Drawing.Point(130, 267);
            this.labeletkinlikbutcesi.Name = "labeletkinlikbutcesi";
            this.labeletkinlikbutcesi.Size = new System.Drawing.Size(104, 13);
            this.labeletkinlikbutcesi.TabIndex = 28;
            this.labeletkinlikbutcesi.Text = "ETKİNLİK BÜTÇESİ";
            // 
            // textBoxetkinlikbutcesi
            // 
            this.textBoxetkinlikbutcesi.Location = new System.Drawing.Point(260, 267);
            this.textBoxetkinlikbutcesi.Name = "textBoxetkinlikbutcesi";
            this.textBoxetkinlikbutcesi.Size = new System.Drawing.Size(121, 20);
            this.textBoxetkinlikbutcesi.TabIndex = 29;
            // 
            // labeletkinlikıd
            // 
            this.labeletkinlikıd.AutoSize = true;
            this.labeletkinlikıd.Location = new System.Drawing.Point(562, 76);
            this.labeletkinlikıd.Name = "labeletkinlikıd";
            this.labeletkinlikıd.Size = new System.Drawing.Size(69, 13);
            this.labeletkinlikıd.TabIndex = 30;
            this.labeletkinlikıd.Text = "ETKİNLİK İD";
            // 
            // textBoxetkinlikid
            // 
            this.textBoxetkinlikid.Location = new System.Drawing.Point(551, 105);
            this.textBoxetkinlikid.Name = "textBoxetkinlikid";
            this.textBoxetkinlikid.Size = new System.Drawing.Size(100, 20);
            this.textBoxetkinlikid.TabIndex = 31;
            // 
            // Etkinlikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1044, 625);
            this.Controls.Add(this.textBoxetkinlikid);
            this.Controls.Add(this.labeletkinlikıd);
            this.Controls.Add(this.textBoxetkinlikbutcesi);
            this.Controls.Add(this.labeletkinlikbutcesi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonetkinliksil);
            this.Controls.Add(this.buttonetkinlikekle);
            this.Controls.Add(this.comboBoxtur);
            this.Controls.Add(this.dateTimePickerbitis);
            this.Controls.Add(this.dateTimePickerbaslama);
            this.Controls.Add(this.buttonetkinlikgüncel);
            this.Controls.Add(this.textBoxetkinlikadı);
            this.Controls.Add(this.labeletkinliktur);
            this.Controls.Add(this.labelbıtıstarıhı);
            this.Controls.Add(this.labelbaslamatarih);
            this.Controls.Add(this.labeletkinlikad);
            this.Name = "Etkinlikler";
            this.Text = "Etkinlikler";
            this.Load += new System.EventHandler(this.Etkinlikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxtur;
        private System.Windows.Forms.DateTimePicker dateTimePickerbitis;
        private System.Windows.Forms.DateTimePicker dateTimePickerbaslama;
        private System.Windows.Forms.Button buttonetkinlikgüncel;
        private System.Windows.Forms.TextBox textBoxetkinlikadı;
        private System.Windows.Forms.Label labeletkinliktur;
        private System.Windows.Forms.Label labelbıtıstarıhı;
        private System.Windows.Forms.Label labelbaslamatarih;
        private System.Windows.Forms.Label labeletkinlikad;
        private System.Windows.Forms.Button buttonetkinlikekle;
        private System.Windows.Forms.Button buttonetkinliksil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labeletkinlikbutcesi;
        private System.Windows.Forms.TextBox textBoxetkinlikbutcesi;
        private System.Windows.Forms.Label labeletkinlikıd;
        private System.Windows.Forms.TextBox textBoxetkinlikid;
    }
}