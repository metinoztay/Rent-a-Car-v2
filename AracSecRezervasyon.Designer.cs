namespace RentACar2
{
    partial class frm_AracSecRezervasyon
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
            this.list_Araclar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_devamEt = new System.Windows.Forms.Button();
            this.mtxt_teslimSaati = new System.Windows.Forms.MaskedTextBox();
            this.dtp_teslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.mtxt_kiraSaati = new System.Windows.Forms.MaskedTextBox();
            this.dtp_kiraTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_RezervasyonEkle = new System.Windows.Forms.Button();
            this.list_Rezervasyonlar = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Araclar
            // 
            this.list_Araclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader12});
            this.list_Araclar.Enabled = false;
            this.list_Araclar.Location = new System.Drawing.Point(21, 103);
            this.list_Araclar.Name = "list_Araclar";
            this.list_Araclar.Size = new System.Drawing.Size(836, 248);
            this.list_Araclar.TabIndex = 1;
            this.list_Araclar.UseCompatibleStateImageBehavior = false;
            this.list_Araclar.View = System.Windows.Forms.View.Details;
            this.list_Araclar.SelectedIndexChanged += new System.EventHandler(this.list_Araclar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yakıt";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vites";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Uygunluk";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Plaka";
            this.columnHeader12.Width = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(401, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Teslim Tarihi/Saati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(21, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kira Tarihi/Saati";
            // 
            // btn_devamEt
            // 
            this.btn_devamEt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_devamEt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_devamEt.Location = new System.Drawing.Point(763, 61);
            this.btn_devamEt.Name = "btn_devamEt";
            this.btn_devamEt.Size = new System.Drawing.Size(94, 36);
            this.btn_devamEt.TabIndex = 18;
            this.btn_devamEt.Text = "Devam Et";
            this.btn_devamEt.UseVisualStyleBackColor = true;
            this.btn_devamEt.Click += new System.EventHandler(this.btn_devamEt_Click);
            // 
            // mtxt_teslimSaati
            // 
            this.mtxt_teslimSaati.Location = new System.Drawing.Point(676, 70);
            this.mtxt_teslimSaati.Mask = "00:00";
            this.mtxt_teslimSaati.Name = "mtxt_teslimSaati";
            this.mtxt_teslimSaati.Size = new System.Drawing.Size(59, 27);
            this.mtxt_teslimSaati.TabIndex = 17;
            this.mtxt_teslimSaati.ValidatingType = typeof(System.DateTime);
            // 
            // dtp_teslimTarihi
            // 
            this.dtp_teslimTarihi.Location = new System.Drawing.Point(401, 70);
            this.dtp_teslimTarihi.Name = "dtp_teslimTarihi";
            this.dtp_teslimTarihi.Size = new System.Drawing.Size(269, 27);
            this.dtp_teslimTarihi.TabIndex = 16;
            // 
            // mtxt_kiraSaati
            // 
            this.mtxt_kiraSaati.Location = new System.Drawing.Point(296, 70);
            this.mtxt_kiraSaati.Mask = "00:00";
            this.mtxt_kiraSaati.Name = "mtxt_kiraSaati";
            this.mtxt_kiraSaati.Size = new System.Drawing.Size(59, 27);
            this.mtxt_kiraSaati.TabIndex = 15;
            this.mtxt_kiraSaati.ValidatingType = typeof(System.DateTime);
            // 
            // dtp_kiraTarihi
            // 
            this.dtp_kiraTarihi.Location = new System.Drawing.Point(21, 70);
            this.dtp_kiraTarihi.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtp_kiraTarihi.Name = "dtp_kiraTarihi";
            this.dtp_kiraTarihi.Size = new System.Drawing.Size(269, 27);
            this.dtp_kiraTarihi.TabIndex = 14;
            this.dtp_kiraTarihi.ValueChanged += new System.EventHandler(this.dtp_kiraTarihi_ValueChanged);
            // 
            // btn_RezervasyonEkle
            // 
            this.btn_RezervasyonEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RezervasyonEkle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RezervasyonEkle.Location = new System.Drawing.Point(703, 605);
            this.btn_RezervasyonEkle.Name = "btn_RezervasyonEkle";
            this.btn_RezervasyonEkle.Size = new System.Drawing.Size(154, 36);
            this.btn_RezervasyonEkle.TabIndex = 21;
            this.btn_RezervasyonEkle.Text = "Rezervasyon Ekle";
            this.btn_RezervasyonEkle.UseVisualStyleBackColor = true;
            this.btn_RezervasyonEkle.Click += new System.EventHandler(this.btn_RezervasyonEkle_Click);
            // 
            // list_Rezervasyonlar
            // 
            this.list_Rezervasyonlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.list_Rezervasyonlar.Enabled = false;
            this.list_Rezervasyonlar.Location = new System.Drawing.Point(21, 391);
            this.list_Rezervasyonlar.Name = "list_Rezervasyonlar";
            this.list_Rezervasyonlar.Size = new System.Drawing.Size(836, 208);
            this.list_Rezervasyonlar.TabIndex = 22;
            this.list_Rezervasyonlar.UseCompatibleStateImageBehavior = false;
            this.list_Rezervasyonlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müsteri Bilgileri";
            this.columnHeader7.Width = 250;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kira Tarihi";
            this.columnHeader8.Width = 230;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Saati";
            this.columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Teslim Tarihi";
            this.columnHeader10.Width = 230;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Saati";
            this.columnHeader11.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(21, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Araca Ait Rezervasyon Bilgileri";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_toplam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_toplam.Location = new System.Drawing.Point(21, 605);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(0, 23);
            this.lbl_toplam.TabIndex = 30;
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(593, 605);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(94, 36);
            this.btn_Geri.TabIndex = 31;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_AracSecRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Rezervasyonlar);
            this.Controls.Add(this.btn_RezervasyonEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_devamEt);
            this.Controls.Add(this.mtxt_teslimSaati);
            this.Controls.Add(this.dtp_teslimTarihi);
            this.Controls.Add(this.mtxt_kiraSaati);
            this.Controls.Add(this.dtp_kiraTarihi);
            this.Controls.Add(this.list_Araclar);
            this.MaximizeBox = false;
            this.Name = "frm_AracSecRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Seçim";
            this.Load += new System.EventHandler(this.frm_AracSecRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView list_Araclar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label6;
        private Label label5;
        private Button btn_devamEt;
        private MaskedTextBox mtxt_teslimSaati;
        private DateTimePicker dtp_teslimTarihi;
        private MaskedTextBox mtxt_kiraSaati;
        private DateTimePicker dtp_kiraTarihi;
        private Button btn_RezervasyonEkle;
        private ListView list_Rezervasyonlar;
        private Label label1;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label lbl_toplam;
        private Button btn_Geri;
    }
}