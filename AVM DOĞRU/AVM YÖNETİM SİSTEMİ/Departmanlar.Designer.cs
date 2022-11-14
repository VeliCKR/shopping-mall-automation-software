namespace AVM_YÖNETİM_SİSTEMİ
{
    partial class Departmanlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labeldepartman = new System.Windows.Forms.Label();
            this.comboBoxdepartman = new System.Windows.Forms.ComboBox();
            this.labeldepartmansec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 365);
            this.dataGridView1.TabIndex = 3;
            // 
            // labeldepartman
            // 
            this.labeldepartman.AutoSize = true;
            this.labeldepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldepartman.Location = new System.Drawing.Point(336, 29);
            this.labeldepartman.Name = "labeldepartman";
            this.labeldepartman.Size = new System.Drawing.Size(310, 39);
            this.labeldepartman.TabIndex = 4;
            this.labeldepartman.Text = " DEPARTMANLAR";
            // 
            // comboBoxdepartman
            // 
            this.comboBoxdepartman.FormattingEnabled = true;
            this.comboBoxdepartman.Items.AddRange(new object[] {
            "GÜVENLİK",
            "TEMİZLİK İŞLERİ",
            "İNSAN KAYNAKLARI ",
            "HUKUK",
            "FİNANS",
            "KİRALAMA"});
            this.comboBoxdepartman.Location = new System.Drawing.Point(200, 118);
            this.comboBoxdepartman.Name = "comboBoxdepartman";
            this.comboBoxdepartman.Size = new System.Drawing.Size(121, 21);
            this.comboBoxdepartman.TabIndex = 5;
            this.comboBoxdepartman.SelectedIndexChanged += new System.EventHandler(this.comboBoxdepartman_SelectedIndexChanged);
            // 
            // labeldepartmansec
            // 
            this.labeldepartmansec.AutoSize = true;
            this.labeldepartmansec.Location = new System.Drawing.Point(40, 121);
            this.labeldepartmansec.Name = "labeldepartmansec";
            this.labeldepartmansec.Size = new System.Drawing.Size(123, 13);
            this.labeldepartmansec.TabIndex = 6;
            this.labeldepartmansec.Text = "DEPARTMAN SEÇİNİZ ";
            // 
            // Departmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1178, 638);
            this.Controls.Add(this.labeldepartmansec);
            this.Controls.Add(this.comboBoxdepartman);
            this.Controls.Add(this.labeldepartman);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Departmanlar";
            this.Text = "Departmanlar";
            this.Load += new System.EventHandler(this.Departmanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labeldepartman;
        private System.Windows.Forms.ComboBox comboBoxdepartman;
        private System.Windows.Forms.Label labeldepartmansec;
    }
}