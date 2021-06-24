
namespace KuzeyYeliTR
{
    partial class KategoriDuzenle
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
            if (disposing)
            {
                con.Close();
            }
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriId_Kategori = new System.Windows.Forms.TextBox();
            this.txtKategoriAd_Kategori = new System.Windows.Forms.TextBox();
            this.btnTamam_kategori = new System.Windows.Forms.Button();
            this.btnIptal_Kategori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Ad:";
            // 
            // txtKategoriId_Kategori
            // 
            this.txtKategoriId_Kategori.Location = new System.Drawing.Point(12, 45);
            this.txtKategoriId_Kategori.Name = "txtKategoriId_Kategori";
            this.txtKategoriId_Kategori.ReadOnly = true;
            this.txtKategoriId_Kategori.Size = new System.Drawing.Size(344, 22);
            this.txtKategoriId_Kategori.TabIndex = 2;
            // 
            // txtKategoriAd_Kategori
            // 
            this.txtKategoriAd_Kategori.Location = new System.Drawing.Point(12, 90);
            this.txtKategoriAd_Kategori.Name = "txtKategoriAd_Kategori";
            this.txtKategoriAd_Kategori.Size = new System.Drawing.Size(344, 22);
            this.txtKategoriAd_Kategori.TabIndex = 3;
            // 
            // btnTamam_kategori
            // 
            this.btnTamam_kategori.Location = new System.Drawing.Point(12, 118);
            this.btnTamam_kategori.Name = "btnTamam_kategori";
            this.btnTamam_kategori.Size = new System.Drawing.Size(344, 33);
            this.btnTamam_kategori.TabIndex = 4;
            this.btnTamam_kategori.Text = "Tamam";
            this.btnTamam_kategori.UseVisualStyleBackColor = true;
            this.btnTamam_kategori.Click += new System.EventHandler(this.btnTamam_kategori_Click);
            // 
            // btnIptal_Kategori
            // 
            this.btnIptal_Kategori.Location = new System.Drawing.Point(12, 157);
            this.btnIptal_Kategori.Name = "btnIptal_Kategori";
            this.btnIptal_Kategori.Size = new System.Drawing.Size(344, 36);
            this.btnIptal_Kategori.TabIndex = 5;
            this.btnIptal_Kategori.Text = "İptal";
            this.btnIptal_Kategori.UseVisualStyleBackColor = true;
            this.btnIptal_Kategori.Click += new System.EventHandler(this.btnIptal_Kategori_Click);
            // 
            // KategoriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 215);
            this.Controls.Add(this.btnIptal_Kategori);
            this.Controls.Add(this.btnTamam_kategori);
            this.Controls.Add(this.txtKategoriAd_Kategori);
            this.Controls.Add(this.txtKategoriId_Kategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KategoriDuzenle";
            this.Text = "KategoriDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategoriId_Kategori;
        private System.Windows.Forms.TextBox txtKategoriAd_Kategori;
        private System.Windows.Forms.Button btnTamam_kategori;
        private System.Windows.Forms.Button btnIptal_Kategori;
    }
}