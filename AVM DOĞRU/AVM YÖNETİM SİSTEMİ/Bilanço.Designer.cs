namespace AVM_YÖNETİM_SİSTEMİ
{
    partial class Bilanço
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
            this.labelgelır = new System.Windows.Forms.Label();
            this.labelgıder = new System.Windows.Forms.Label();
            this.labeltoplam = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelciro = new System.Windows.Forms.Label();
            this.textBoxciro = new System.Windows.Forms.TextBox();
            this.textBoxkazanc = new System.Windows.Forms.TextBox();
            this.labelkazanc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelgelır
            // 
            this.labelgelır.AutoSize = true;
            this.labelgelır.Location = new System.Drawing.Point(41, 19);
            this.labelgelır.Name = "labelgelır";
            this.labelgelır.Size = new System.Drawing.Size(107, 13);
            this.labelgelır.TabIndex = 1;
            this.labelgelır.Text = "TOPLAM GELİRLER";
            // 
            // labelgıder
            // 
            this.labelgıder.AutoSize = true;
            this.labelgıder.Location = new System.Drawing.Point(41, 225);
            this.labelgıder.Name = "labelgıder";
            this.labelgıder.Size = new System.Drawing.Size(109, 13);
            this.labelgıder.TabIndex = 2;
            this.labelgıder.Text = "TOPLAM GİDERLER";
            // 
            // labeltoplam
            // 
            this.labeltoplam.AutoSize = true;
            this.labeltoplam.Location = new System.Drawing.Point(670, 19);
            this.labeltoplam.Name = "labeltoplam";
            this.labeltoplam.Size = new System.Drawing.Size(51, 13);
            this.labeltoplam.TabIndex = 3;
            this.labeltoplam.Text = "TOPLAM";
            this.labeltoplam.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 251);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(456, 173);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(612, 65);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(164, 173);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.Visible = false;
            // 
            // labelciro
            // 
            this.labelciro.AutoSize = true;
            this.labelciro.Location = new System.Drawing.Point(20, 14);
            this.labelciro.Name = "labelciro";
            this.labelciro.Size = new System.Drawing.Size(66, 13);
            this.labelciro.TabIndex = 6;
            this.labelciro.Text = "AYLIK CİRO";
            // 
            // textBoxciro
            // 
            this.textBoxciro.Location = new System.Drawing.Point(174, 7);
            this.textBoxciro.Name = "textBoxciro";
            this.textBoxciro.Size = new System.Drawing.Size(100, 20);
            this.textBoxciro.TabIndex = 7;
            // 
            // textBoxkazanc
            // 
            this.textBoxkazanc.Location = new System.Drawing.Point(174, 48);
            this.textBoxkazanc.Name = "textBoxkazanc";
            this.textBoxkazanc.Size = new System.Drawing.Size(100, 20);
            this.textBoxkazanc.TabIndex = 9;
            // 
            // labelkazanc
            // 
            this.labelkazanc.AutoSize = true;
            this.labelkazanc.Location = new System.Drawing.Point(20, 55);
            this.labelkazanc.Name = "labelkazanc";
            this.labelkazanc.Size = new System.Drawing.Size(83, 13);
            this.labelkazanc.TabIndex = 8;
            this.labelkazanc.Text = "AYLIK KAZANÇ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxkazanc);
            this.panel1.Controls.Add(this.labelciro);
            this.panel1.Controls.Add(this.labelkazanc);
            this.panel1.Controls.Add(this.textBoxciro);
            this.panel1.Location = new System.Drawing.Point(551, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 100);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // Bilanço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1023, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labeltoplam);
            this.Controls.Add(this.labelgıder);
            this.Controls.Add(this.labelgelır);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bilanço";
            this.Text = "Bilanço";
            this.Load += new System.EventHandler(this.Bilanço_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelgelır;
        private System.Windows.Forms.Label labelgıder;
        private System.Windows.Forms.Label labeltoplam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelciro;
        private System.Windows.Forms.TextBox textBoxciro;
        private System.Windows.Forms.TextBox textBoxkazanc;
        private System.Windows.Forms.Label labelkazanc;
        private System.Windows.Forms.Panel panel1;
    }
}