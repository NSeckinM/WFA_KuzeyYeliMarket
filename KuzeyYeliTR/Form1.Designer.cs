
namespace KuzeyYeliTR
{
    partial class Form1
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
            this.LstKategori = new System.Windows.Forms.ListBox();
            this.DgvUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboUrun = new System.Windows.Forms.PictureBox();
            this.BtnKategoriEkle = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.btnDuzenleKategori = new System.Windows.Forms.Button();
            this.BtnDuzenleUrun = new System.Windows.Forms.Button();
            this.BtnKategoriSil = new System.Windows.Forms.Button();
            this.BtnUrunSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resim = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // LstKategori
            // 
            this.LstKategori.FormattingEnabled = true;
            this.LstKategori.ItemHeight = 16;
            this.LstKategori.Location = new System.Drawing.Point(12, 216);
            this.LstKategori.Name = "LstKategori";
            this.LstKategori.Size = new System.Drawing.Size(290, 388);
            this.LstKategori.TabIndex = 0;
            this.LstKategori.SelectedIndexChanged += new System.EventHandler(this.LstKategori_SelectedIndexChanged);
            this.LstKategori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstKategori_KeyDown);
            // 
            // DgvUrunler
            // 
            this.DgvUrunler.AllowUserToAddRows = false;
            this.DgvUrunler.AllowUserToDeleteRows = false;
            this.DgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Resim});
            this.DgvUrunler.Location = new System.Drawing.Point(358, 135);
            this.DgvUrunler.MultiSelect = false;
            this.DgvUrunler.Name = "DgvUrunler";
            this.DgvUrunler.ReadOnly = true;
            this.DgvUrunler.RowHeadersVisible = false;
            this.DgvUrunler.RowHeadersWidth = 51;
            this.DgvUrunler.RowTemplate.Height = 80;
            this.DgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUrunler.Size = new System.Drawing.Size(807, 561);
            this.DgvUrunler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Kategorileri";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(630, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürünler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboUrun
            // 
            this.pboUrun.Location = new System.Drawing.Point(12, 12);
            this.pboUrun.Name = "pboUrun";
            this.pboUrun.Size = new System.Drawing.Size(284, 155);
            this.pboUrun.TabIndex = 4;
            this.pboUrun.TabStop = false;
            // 
            // BtnKategoriEkle
            // 
            this.BtnKategoriEkle.Location = new System.Drawing.Point(150, 619);
            this.BtnKategoriEkle.Name = "BtnKategoriEkle";
            this.BtnKategoriEkle.Size = new System.Drawing.Size(146, 37);
            this.BtnKategoriEkle.TabIndex = 5;
            this.BtnKategoriEkle.Text = "Kategori Ekle +";
            this.BtnKategoriEkle.UseVisualStyleBackColor = true;
            this.BtnKategoriEkle.Click += new System.EventHandler(this.BtnKategoriEkle_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(535, 90);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(120, 39);
            this.BtnUrunEkle.TabIndex = 6;
            this.BtnUrunEkle.Text = "Urun Ekle +";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // btnDuzenleKategori
            // 
            this.btnDuzenleKategori.Location = new System.Drawing.Point(12, 620);
            this.btnDuzenleKategori.Name = "btnDuzenleKategori";
            this.btnDuzenleKategori.Size = new System.Drawing.Size(132, 36);
            this.btnDuzenleKategori.TabIndex = 7;
            this.btnDuzenleKategori.Text = "Kategori Duzenle";
            this.btnDuzenleKategori.UseVisualStyleBackColor = true;
            this.btnDuzenleKategori.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // BtnDuzenleUrun
            // 
            this.BtnDuzenleUrun.Location = new System.Drawing.Point(682, 90);
            this.BtnDuzenleUrun.Name = "BtnDuzenleUrun";
            this.BtnDuzenleUrun.Size = new System.Drawing.Size(124, 38);
            this.BtnDuzenleUrun.TabIndex = 8;
            this.BtnDuzenleUrun.Text = "Ürün Düzenle";
            this.BtnDuzenleUrun.UseVisualStyleBackColor = true;
            this.BtnDuzenleUrun.Click += new System.EventHandler(this.BtnDuzenleUrun_Click);
            // 
            // BtnKategoriSil
            // 
            this.BtnKategoriSil.Location = new System.Drawing.Point(12, 662);
            this.BtnKategoriSil.Name = "BtnKategoriSil";
            this.BtnKategoriSil.Size = new System.Drawing.Size(284, 34);
            this.BtnKategoriSil.TabIndex = 9;
            this.BtnKategoriSil.Text = "Kategori Sil";
            this.BtnKategoriSil.UseVisualStyleBackColor = true;
            this.BtnKategoriSil.Click += new System.EventHandler(this.BtnKategoriSil_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Location = new System.Drawing.Point(833, 90);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(129, 39);
            this.BtnUrunSil.TabIndex = 10;
            this.BtnUrunSil.Text = "Ürün Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = true;
            this.BtnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(310, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 684);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UrunAd";
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BirimFiyat";
            this.Column3.HeaderText = "Birim Fiyat ₺";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StokAdet";
            this.Column4.HeaderText = "Stok adet";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Resim
            // 
            this.Resim.DataPropertyName = "Resim";
            this.Resim.HeaderText = "Ürün görseli";
            this.Resim.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Resim.MinimumWidth = 6;
            this.Resim.Name = "Resim";
            this.Resim.ReadOnly = true;
            this.Resim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Resim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Resim.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUrunSil);
            this.Controls.Add(this.BtnKategoriSil);
            this.Controls.Add(this.BtnDuzenleUrun);
            this.Controls.Add(this.btnDuzenleKategori);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.BtnKategoriEkle);
            this.Controls.Add(this.pboUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvUrunler);
            this.Controls.Add(this.LstKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstKategori;
        private System.Windows.Forms.DataGridView DgvUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboUrun;
        private System.Windows.Forms.Button BtnKategoriEkle;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button btnDuzenleKategori;
        private System.Windows.Forms.Button BtnDuzenleUrun;
        private System.Windows.Forms.Button BtnKategoriSil;
        private System.Windows.Forms.Button BtnUrunSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Resim;
    }
}

