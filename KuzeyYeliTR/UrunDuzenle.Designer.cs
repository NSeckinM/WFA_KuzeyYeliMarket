
namespace KuzeyYeliTR
{
    partial class UrunDuzenle
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
            this.components = new System.ComponentModel.Container();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnTamam = new System.Windows.Forms.Button();
            this.pboResim = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategoriUrun = new System.Windows.Forms.ComboBox();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuzeyYeliDataSet1 = new KuzeyYeliTR.KuzeyYeliDataSet1();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuzeyYeliDataSet = new KuzeyYeliTR.KuzeyYeliDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyatUrun = new System.Windows.Forms.TextBox();
            this.txtStokAdetUrun = new System.Windows.Forms.TextBox();
            this.txtAdUrun = new System.Windows.Forms.TextBox();
            this.txtIdUrun = new System.Windows.Forms.TextBox();
            this.urunlerTableAdapter = new KuzeyYeliTR.KuzeyYeliDataSetTableAdapters.UrunlerTableAdapter();
            this.kategorilerTableAdapter = new KuzeyYeliTR.KuzeyYeliDataSet1TableAdapters.KategorilerTableAdapter();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(523, 117);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(115, 45);
            this.BtnIptal.TabIndex = 27;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // BtnTamam
            // 
            this.BtnTamam.Location = new System.Drawing.Point(523, 26);
            this.BtnTamam.Name = "BtnTamam";
            this.BtnTamam.Size = new System.Drawing.Size(115, 57);
            this.BtnTamam.TabIndex = 26;
            this.BtnTamam.Text = "Tamam";
            this.BtnTamam.UseVisualStyleBackColor = true;
            this.BtnTamam.Click += new System.EventHandler(this.BtnTamam_Click);
            // 
            // pboResim
            // 
            this.pboResim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pboResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboResim.Location = new System.Drawing.Point(339, 26);
            this.pboResim.Name = "pboResim";
            this.pboResim.Size = new System.Drawing.Size(168, 136);
            this.pboResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboResim.TabIndex = 24;
            this.pboResim.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kategori:";
            // 
            // cmbKategoriUrun
            // 
            this.cmbKategoriUrun.DataSource = this.kategorilerBindingSource;
            this.cmbKategoriUrun.DisplayMember = "Id";
            this.cmbKategoriUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriUrun.FormattingEnabled = true;
            this.cmbKategoriUrun.Location = new System.Drawing.Point(117, 138);
            this.cmbKategoriUrun.Name = "cmbKategoriUrun";
            this.cmbKategoriUrun.Size = new System.Drawing.Size(201, 24);
            this.cmbKategoriUrun.TabIndex = 22;
            this.cmbKategoriUrun.ValueMember = "Id";
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.kuzeyYeliDataSet1;
            // 
            // kuzeyYeliDataSet1
            // 
            this.kuzeyYeliDataSet1.DataSetName = "KuzeyYeliDataSet1";
            this.kuzeyYeliDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.kuzeyYeliDataSet;
            // 
            // kuzeyYeliDataSet
            // 
            this.kuzeyYeliDataSet.DataSetName = "KuzeyYeliDataSet";
            this.kuzeyYeliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Stok Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id:";
            // 
            // txtFiyatUrun
            // 
            this.txtFiyatUrun.Location = new System.Drawing.Point(117, 82);
            this.txtFiyatUrun.Name = "txtFiyatUrun";
            this.txtFiyatUrun.Size = new System.Drawing.Size(201, 22);
            this.txtFiyatUrun.TabIndex = 17;
            // 
            // txtStokAdetUrun
            // 
            this.txtStokAdetUrun.Location = new System.Drawing.Point(117, 110);
            this.txtStokAdetUrun.Name = "txtStokAdetUrun";
            this.txtStokAdetUrun.Size = new System.Drawing.Size(201, 22);
            this.txtStokAdetUrun.TabIndex = 16;
            // 
            // txtAdUrun
            // 
            this.txtAdUrun.Location = new System.Drawing.Point(117, 54);
            this.txtAdUrun.Name = "txtAdUrun";
            this.txtAdUrun.Size = new System.Drawing.Size(201, 22);
            this.txtAdUrun.TabIndex = 15;
            // 
            // txtIdUrun
            // 
            this.txtIdUrun.Location = new System.Drawing.Point(117, 26);
            this.txtIdUrun.Name = "txtIdUrun";
            this.txtIdUrun.ReadOnly = true;
            this.txtIdUrun.Size = new System.Drawing.Size(201, 22);
            this.txtIdUrun.TabIndex = 14;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.Location = new System.Drawing.Point(339, 168);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(168, 34);
            this.BtnResimSec.TabIndex = 28;
            this.BtnResimSec.Text = "resim seç";
            this.BtnResimSec.UseVisualStyleBackColor = true;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "openFileDialog1";
            this.ofdResim.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // UrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 207);
            this.Controls.Add(this.BtnResimSec);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnTamam);
            this.Controls.Add(this.pboResim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKategoriUrun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyatUrun);
            this.Controls.Add(this.txtStokAdetUrun);
            this.Controls.Add(this.txtAdUrun);
            this.Controls.Add(this.txtIdUrun);
            this.Name = "UrunDuzenle";
            this.Text = "UrunDuzenle";
            this.Load += new System.EventHandler(this.UrunDuzenle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnTamam;
        private System.Windows.Forms.PictureBox pboResim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategoriUrun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiyatUrun;
        private System.Windows.Forms.TextBox txtStokAdetUrun;
        private System.Windows.Forms.TextBox txtAdUrun;
        private System.Windows.Forms.TextBox txtIdUrun;
        private KuzeyYeliDataSet kuzeyYeliDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private KuzeyYeliDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private KuzeyYeliDataSet1 kuzeyYeliDataSet1;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private KuzeyYeliDataSet1TableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.OpenFileDialog ofdResim;
    }
}