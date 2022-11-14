namespace AVM_YÖNETİM_SİSTEMİ
{
    partial class Hizmetler
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
            this.buttonhizmetekle = new System.Windows.Forms.Button();
            this.buttonhizmetgüncel = new System.Windows.Forms.Button();
            this.buttonhizmetsil = new System.Windows.Forms.Button();
            this.labelhizmettürü = new System.Windows.Forms.Label();
            this.labelhizmetsaglayıcı = new System.Windows.Forms.Label();
            this.labelhizmetmaliyet = new System.Windows.Forms.Label();
            this.labelhizmetperiyot = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxhizmetperiyot = new System.Windows.Forms.ComboBox();
            this.comboBoxhizmetturu = new System.Windows.Forms.ComboBox();
            this.textBoxhizmetsaglayıcı = new System.Windows.Forms.TextBox();
            this.textBoxhizmetmaliyeti = new System.Windows.Forms.TextBox();
            this.labelhizmetbaslangıct = new System.Windows.Forms.Label();
            this.labelhizmetbitist = new System.Windows.Forms.Label();
            this.dateTimehizmetbaslangıc = new System.Windows.Forms.DateTimePicker();
            this.dateTimehizmetbitis = new System.Windows.Forms.DateTimePicker();
            this.textBoxhizmetid = new System.Windows.Forms.TextBox();
            this.labelhizmetid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonhizmetekle
            // 
            this.buttonhizmetekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonhizmetekle.FlatAppearance.BorderSize = 0;
            this.buttonhizmetekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhizmetekle.Location = new System.Drawing.Point(624, 47);
            this.buttonhizmetekle.Name = "buttonhizmetekle";
            this.buttonhizmetekle.Size = new System.Drawing.Size(124, 23);
            this.buttonhizmetekle.TabIndex = 0;
            this.buttonhizmetekle.Text = "HİZMET EKLE";
            this.buttonhizmetekle.UseVisualStyleBackColor = false;
            this.buttonhizmetekle.Click += new System.EventHandler(this.buttonhizmetekle_Click);
            // 
            // buttonhizmetgüncel
            // 
            this.buttonhizmetgüncel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonhizmetgüncel.FlatAppearance.BorderSize = 0;
            this.buttonhizmetgüncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhizmetgüncel.Location = new System.Drawing.Point(624, 89);
            this.buttonhizmetgüncel.Name = "buttonhizmetgüncel";
            this.buttonhizmetgüncel.Size = new System.Drawing.Size(124, 23);
            this.buttonhizmetgüncel.TabIndex = 1;
            this.buttonhizmetgüncel.Text = "HİZMET GÜNCELLE";
            this.buttonhizmetgüncel.UseVisualStyleBackColor = false;
            this.buttonhizmetgüncel.Click += new System.EventHandler(this.buttonhizmetgüncel_Click);
            // 
            // buttonhizmetsil
            // 
            this.buttonhizmetsil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonhizmetsil.FlatAppearance.BorderSize = 0;
            this.buttonhizmetsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhizmetsil.Location = new System.Drawing.Point(624, 136);
            this.buttonhizmetsil.Name = "buttonhizmetsil";
            this.buttonhizmetsil.Size = new System.Drawing.Size(124, 23);
            this.buttonhizmetsil.TabIndex = 2;
            this.buttonhizmetsil.Text = "HİZMET SİL";
            this.buttonhizmetsil.UseVisualStyleBackColor = false;
            this.buttonhizmetsil.Click += new System.EventHandler(this.buttonhizmetsil_Click);
            // 
            // labelhizmettürü
            // 
            this.labelhizmettürü.AutoSize = true;
            this.labelhizmettürü.Location = new System.Drawing.Point(64, 26);
            this.labelhizmettürü.Name = "labelhizmettürü";
            this.labelhizmettürü.Size = new System.Drawing.Size(82, 13);
            this.labelhizmettürü.TabIndex = 3;
            this.labelhizmettürü.Text = "HİZMET TÜRÜ";
            // 
            // labelhizmetsaglayıcı
            // 
            this.labelhizmetsaglayıcı.AutoSize = true;
            this.labelhizmetsaglayıcı.Location = new System.Drawing.Point(64, 69);
            this.labelhizmetsaglayıcı.Name = "labelhizmetsaglayıcı";
            this.labelhizmetsaglayıcı.Size = new System.Drawing.Size(106, 13);
            this.labelhizmetsaglayıcı.TabIndex = 4;
            this.labelhizmetsaglayıcı.Text = "HİZMET SAĞLAYICI";
            // 
            // labelhizmetmaliyet
            // 
            this.labelhizmetmaliyet.AutoSize = true;
            this.labelhizmetmaliyet.Location = new System.Drawing.Point(64, 196);
            this.labelhizmetmaliyet.Name = "labelhizmetmaliyet";
            this.labelhizmetmaliyet.Size = new System.Drawing.Size(100, 13);
            this.labelhizmetmaliyet.TabIndex = 5;
            this.labelhizmetmaliyet.Text = "HİZMET MALİYETİ";
            // 
            // labelhizmetperiyot
            // 
            this.labelhizmetperiyot.AutoSize = true;
            this.labelhizmetperiyot.Location = new System.Drawing.Point(271, 243);
            this.labelhizmetperiyot.Name = "labelhizmetperiyot";
            this.labelhizmetperiyot.Size = new System.Drawing.Size(54, 13);
            this.labelhizmetperiyot.TabIndex = 6;
            this.labelhizmetperiyot.Text = "PERİYOT";
            this.labelhizmetperiyot.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 215);
            this.dataGridView1.TabIndex = 7;
            // 
            // comboBoxhizmetperiyot
            // 
            this.comboBoxhizmetperiyot.FormattingEnabled = true;
            this.comboBoxhizmetperiyot.Items.AddRange(new object[] {
            "1 AYLIK ",
            "3 AYLIK",
            "6 AYLIK ",
            "12 AYLIK",
            "TÜMÜ"});
            this.comboBoxhizmetperiyot.Location = new System.Drawing.Point(385, 235);
            this.comboBoxhizmetperiyot.Name = "comboBoxhizmetperiyot";
            this.comboBoxhizmetperiyot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxhizmetperiyot.TabIndex = 8;
            this.comboBoxhizmetperiyot.Visible = false;
            this.comboBoxhizmetperiyot.SelectedIndexChanged += new System.EventHandler(this.comboBoxhizmetperiyot_SelectedIndexChanged);
            // 
            // comboBoxhizmetturu
            // 
            this.comboBoxhizmetturu.FormattingEnabled = true;
            this.comboBoxhizmetturu.Items.AddRange(new object[] {
            "ELEKTRİK ",
            "SU ",
            "ISITMA ",
            "TAMİRAT TADİLAT ",
            "DİĞER"});
            this.comboBoxhizmetturu.Location = new System.Drawing.Point(274, 23);
            this.comboBoxhizmetturu.Name = "comboBoxhizmetturu";
            this.comboBoxhizmetturu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxhizmetturu.TabIndex = 9;
            // 
            // textBoxhizmetsaglayıcı
            // 
            this.textBoxhizmetsaglayıcı.Location = new System.Drawing.Point(274, 69);
            this.textBoxhizmetsaglayıcı.Name = "textBoxhizmetsaglayıcı";
            this.textBoxhizmetsaglayıcı.Size = new System.Drawing.Size(121, 20);
            this.textBoxhizmetsaglayıcı.TabIndex = 10;
            // 
            // textBoxhizmetmaliyeti
            // 
            this.textBoxhizmetmaliyeti.Location = new System.Drawing.Point(274, 196);
            this.textBoxhizmetmaliyeti.Name = "textBoxhizmetmaliyeti";
            this.textBoxhizmetmaliyeti.Size = new System.Drawing.Size(121, 20);
            this.textBoxhizmetmaliyeti.TabIndex = 11;
            // 
            // labelhizmetbaslangıct
            // 
            this.labelhizmetbaslangıct.AutoSize = true;
            this.labelhizmetbaslangıct.Location = new System.Drawing.Point(64, 113);
            this.labelhizmetbaslangıct.Name = "labelhizmetbaslangıct";
            this.labelhizmetbaslangıct.Size = new System.Drawing.Size(150, 13);
            this.labelhizmetbaslangıct.TabIndex = 12;
            this.labelhizmetbaslangıct.Text = "HİZMET BAŞLANGIÇ TARİHİ";
            // 
            // labelhizmetbitist
            // 
            this.labelhizmetbitist.AutoSize = true;
            this.labelhizmetbitist.Location = new System.Drawing.Point(64, 159);
            this.labelhizmetbitist.Name = "labelhizmetbitist";
            this.labelhizmetbitist.Size = new System.Drawing.Size(120, 13);
            this.labelhizmetbitist.TabIndex = 13;
            this.labelhizmetbitist.Text = "HİZMET BİTİŞ TARİHİ ";
            // 
            // dateTimehizmetbaslangıc
            // 
            this.dateTimehizmetbaslangıc.Location = new System.Drawing.Point(274, 113);
            this.dateTimehizmetbaslangıc.Name = "dateTimehizmetbaslangıc";
            this.dateTimehizmetbaslangıc.Size = new System.Drawing.Size(169, 20);
            this.dateTimehizmetbaslangıc.TabIndex = 14;
            // 
            // dateTimehizmetbitis
            // 
            this.dateTimehizmetbitis.Location = new System.Drawing.Point(274, 153);
            this.dateTimehizmetbitis.Name = "dateTimehizmetbitis";
            this.dateTimehizmetbitis.Size = new System.Drawing.Size(169, 20);
            this.dateTimehizmetbitis.TabIndex = 15;
            // 
            // textBoxhizmetid
            // 
            this.textBoxhizmetid.Location = new System.Drawing.Point(464, 50);
            this.textBoxhizmetid.Name = "textBoxhizmetid";
            this.textBoxhizmetid.Size = new System.Drawing.Size(100, 20);
            this.textBoxhizmetid.TabIndex = 17;
            // 
            // labelhizmetid
            // 
            this.labelhizmetid.AutoSize = true;
            this.labelhizmetid.Location = new System.Drawing.Point(486, 26);
            this.labelhizmetid.Name = "labelhizmetid";
            this.labelhizmetid.Size = new System.Drawing.Size(62, 13);
            this.labelhizmetid.TabIndex = 18;
            this.labelhizmetid.Text = "HİZMET İD";
            // 
            // Hizmetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 501);
            this.Controls.Add(this.labelhizmetid);
            this.Controls.Add(this.textBoxhizmetid);
            this.Controls.Add(this.dateTimehizmetbitis);
            this.Controls.Add(this.dateTimehizmetbaslangıc);
            this.Controls.Add(this.labelhizmetbitist);
            this.Controls.Add(this.labelhizmetbaslangıct);
            this.Controls.Add(this.textBoxhizmetmaliyeti);
            this.Controls.Add(this.textBoxhizmetsaglayıcı);
            this.Controls.Add(this.comboBoxhizmetturu);
            this.Controls.Add(this.comboBoxhizmetperiyot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelhizmetperiyot);
            this.Controls.Add(this.labelhizmetmaliyet);
            this.Controls.Add(this.labelhizmetsaglayıcı);
            this.Controls.Add(this.labelhizmettürü);
            this.Controls.Add(this.buttonhizmetsil);
            this.Controls.Add(this.buttonhizmetgüncel);
            this.Controls.Add(this.buttonhizmetekle);
            this.Name = "Hizmetler";
            this.Text = "Hizmetler";
            this.Load += new System.EventHandler(this.Hizmetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonhizmetekle;
        private System.Windows.Forms.Button buttonhizmetgüncel;
        private System.Windows.Forms.Button buttonhizmetsil;
        private System.Windows.Forms.Label labelhizmettürü;
        private System.Windows.Forms.Label labelhizmetsaglayıcı;
        private System.Windows.Forms.Label labelhizmetmaliyet;
        private System.Windows.Forms.Label labelhizmetperiyot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxhizmetperiyot;
        private System.Windows.Forms.ComboBox comboBoxhizmetturu;
        private System.Windows.Forms.TextBox textBoxhizmetsaglayıcı;
        private System.Windows.Forms.TextBox textBoxhizmetmaliyeti;
        private System.Windows.Forms.Label labelhizmetbaslangıct;
        private System.Windows.Forms.Label labelhizmetbitist;
        private System.Windows.Forms.DateTimePicker dateTimehizmetbaslangıc;
        private System.Windows.Forms.DateTimePicker dateTimehizmetbitis;
        private System.Windows.Forms.TextBox textBoxhizmetid;
        private System.Windows.Forms.Label labelhizmetid;
    }
}