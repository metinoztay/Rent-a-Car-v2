namespace RentACar2
{
    partial class frm_AracTeslimEt
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1. Maksimum Kilometre Sınırı: 1000km"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2. Yaş Sınırı: Minimum 21"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3. Ehliyet Yaşı: Minimum 2 Yıl"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4. En az bir adet kredi kartı gereklidir."}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            this.lst_kosullar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.grp_Musteri = new System.Windows.Forms.GroupBox();
            this.btn_DevamEt = new System.Windows.Forms.Button();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.mtxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.grp_tarih = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_devamEt2 = new System.Windows.Forms.Button();
            this.mtxt_teslimSaati = new System.Windows.Forms.MaskedTextBox();
            this.dtp_teslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.mtxt_kiraSaati = new System.Windows.Forms.MaskedTextBox();
            this.dtp_kiraTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.grp_Musteri.SuspendLayout();
            this.grp_tarih.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_kosullar
            // 
            this.lst_kosullar.CheckBoxes = true;
            this.lst_kosullar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.lst_kosullar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lst_kosullar.Location = new System.Drawing.Point(12, 22);
            this.lst_kosullar.Name = "lst_kosullar";
            this.lst_kosullar.Size = new System.Drawing.Size(858, 138);
            this.lst_kosullar.TabIndex = 1;
            this.lst_kosullar.UseCompatibleStateImageBehavior = false;
            this.lst_kosullar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Araç Kiralama Koşulları";
            this.columnHeader1.Width = 487;
            // 
            // grp_Musteri
            // 
            this.grp_Musteri.Controls.Add(this.btn_DevamEt);
            this.grp_Musteri.Controls.Add(this.btn_Ara);
            this.grp_Musteri.Controls.Add(this.label4);
            this.grp_Musteri.Controls.Add(this.label3);
            this.grp_Musteri.Controls.Add(this.label2);
            this.grp_Musteri.Controls.Add(this.label1);
            this.grp_Musteri.Controls.Add(this.mtxt_telefon);
            this.grp_Musteri.Controls.Add(this.txt_soyisim);
            this.grp_Musteri.Controls.Add(this.mtxt_TC);
            this.grp_Musteri.Controls.Add(this.txt_isim);
            this.grp_Musteri.Location = new System.Drawing.Point(12, 212);
            this.grp_Musteri.Name = "grp_Musteri";
            this.grp_Musteri.Size = new System.Drawing.Size(491, 429);
            this.grp_Musteri.TabIndex = 2;
            this.grp_Musteri.TabStop = false;
            this.grp_Musteri.Text = "Müşteri Bilgileri";
            this.grp_Musteri.Visible = false;
            // 
            // btn_DevamEt
            // 
            this.btn_DevamEt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DevamEt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DevamEt.Location = new System.Drawing.Point(261, 296);
            this.btn_DevamEt.Name = "btn_DevamEt";
            this.btn_DevamEt.Size = new System.Drawing.Size(143, 36);
            this.btn_DevamEt.TabIndex = 9;
            this.btn_DevamEt.Text = "Devam Et";
            this.btn_DevamEt.UseVisualStyleBackColor = true;
            this.btn_DevamEt.Click += new System.EventHandler(this.btn_DevamEt_Click);
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ara.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Ara.Location = new System.Drawing.Point(335, 76);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(69, 31);
            this.btn_Ara.TabIndex = 8;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(68, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(68, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(68, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(68, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC NO:";
            // 
            // mtxt_telefon
            // 
            this.mtxt_telefon.Location = new System.Drawing.Point(175, 231);
            this.mtxt_telefon.Mask = "(999) 000-0000";
            this.mtxt_telefon.Name = "mtxt_telefon";
            this.mtxt_telefon.Size = new System.Drawing.Size(136, 27);
            this.mtxt_telefon.TabIndex = 4;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(175, 178);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(136, 27);
            this.txt_soyisim.TabIndex = 3;
            // 
            // mtxt_TC
            // 
            this.mtxt_TC.Location = new System.Drawing.Point(175, 77);
            this.mtxt_TC.Mask = "00000000000";
            this.mtxt_TC.Name = "mtxt_TC";
            this.mtxt_TC.Size = new System.Drawing.Size(136, 27);
            this.mtxt_TC.TabIndex = 1;
            this.mtxt_TC.ValidatingType = typeof(int);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(175, 130);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(136, 27);
            this.txt_isim.TabIndex = 2;
            // 
            // btn_Onay
            // 
            this.btn_Onay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Onay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Onay.Location = new System.Drawing.Point(605, 166);
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.Size = new System.Drawing.Size(265, 40);
            this.btn_Onay.TabIndex = 3;
            this.btn_Onay.Text = "Tümünü Onaylıyorum";
            this.btn_Onay.UseVisualStyleBackColor = true;
            this.btn_Onay.Click += new System.EventHandler(this.btn_Onay_Click);
            // 
            // grp_tarih
            // 
            this.grp_tarih.Controls.Add(this.label6);
            this.grp_tarih.Controls.Add(this.label5);
            this.grp_tarih.Controls.Add(this.btn_devamEt2);
            this.grp_tarih.Controls.Add(this.mtxt_teslimSaati);
            this.grp_tarih.Controls.Add(this.dtp_teslimTarihi);
            this.grp_tarih.Controls.Add(this.mtxt_kiraSaati);
            this.grp_tarih.Controls.Add(this.dtp_kiraTarihi);
            this.grp_tarih.Enabled = false;
            this.grp_tarih.Location = new System.Drawing.Point(530, 212);
            this.grp_tarih.Name = "grp_tarih";
            this.grp_tarih.Size = new System.Drawing.Size(340, 429);
            this.grp_tarih.TabIndex = 4;
            this.grp_tarih.TabStop = false;
            this.grp_tarih.Text = "Tarih Seçimi";
            this.grp_tarih.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Teslim Tarihi/Saati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(26, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kira Tarihi/Saati";
            // 
            // btn_devamEt2
            // 
            this.btn_devamEt2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_devamEt2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_devamEt2.Location = new System.Drawing.Point(201, 329);
            this.btn_devamEt2.Name = "btn_devamEt2";
            this.btn_devamEt2.Size = new System.Drawing.Size(94, 36);
            this.btn_devamEt2.TabIndex = 11;
            this.btn_devamEt2.Text = "Devam Et";
            this.btn_devamEt2.UseVisualStyleBackColor = true;
            this.btn_devamEt2.Click += new System.EventHandler(this.btn_devamEt2_Click);
            // 
            // mtxt_teslimSaati
            // 
            this.mtxt_teslimSaati.Location = new System.Drawing.Point(26, 289);
            this.mtxt_teslimSaati.Mask = "00:00";
            this.mtxt_teslimSaati.Name = "mtxt_teslimSaati";
            this.mtxt_teslimSaati.Size = new System.Drawing.Size(59, 27);
            this.mtxt_teslimSaati.TabIndex = 3;
            this.mtxt_teslimSaati.ValidatingType = typeof(System.DateTime);
            // 
            // dtp_teslimTarihi
            // 
            this.dtp_teslimTarihi.Location = new System.Drawing.Point(26, 229);
            this.dtp_teslimTarihi.Name = "dtp_teslimTarihi";
            this.dtp_teslimTarihi.Size = new System.Drawing.Size(269, 27);
            this.dtp_teslimTarihi.TabIndex = 2;
            // 
            // mtxt_kiraSaati
            // 
            this.mtxt_kiraSaati.Location = new System.Drawing.Point(26, 131);
            this.mtxt_kiraSaati.Mask = "00:00";
            this.mtxt_kiraSaati.Name = "mtxt_kiraSaati";
            this.mtxt_kiraSaati.Size = new System.Drawing.Size(59, 27);
            this.mtxt_kiraSaati.TabIndex = 1;
            this.mtxt_kiraSaati.ValidatingType = typeof(System.DateTime);
            // 
            // dtp_kiraTarihi
            // 
            this.dtp_kiraTarihi.Location = new System.Drawing.Point(26, 75);
            this.dtp_kiraTarihi.MinDate = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            this.dtp_kiraTarihi.Name = "dtp_kiraTarihi";
            this.dtp_kiraTarihi.Size = new System.Drawing.Size(269, 27);
            this.dtp_kiraTarihi.TabIndex = 0;
            this.dtp_kiraTarihi.Value = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            this.dtp_kiraTarihi.ValueChanged += new System.EventHandler(this.dtp_kiraTarihi_ValueChanged);
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Geri.Location = new System.Drawing.Point(517, 166);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(82, 40);
            this.btn_Geri.TabIndex = 5;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_AracTeslimEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.grp_tarih);
            this.Controls.Add(this.grp_Musteri);
            this.Controls.Add(this.btn_Onay);
            this.Controls.Add(this.lst_kosullar);
            this.MaximizeBox = false;
            this.Name = "frm_AracTeslimEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracTeslimEt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_AracTeslimEt_FormClosing);
            this.Load += new System.EventHandler(this.frm_AracTeslimEt_Load);
            this.grp_Musteri.ResumeLayout(false);
            this.grp_Musteri.PerformLayout();
            this.grp_tarih.ResumeLayout(false);
            this.grp_tarih.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lst_kosullar;
        private ColumnHeader columnHeader1;
        private GroupBox grp_Musteri;
        private Button btn_Onay;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtxt_telefon;
        private TextBox txt_soyisim;
        private MaskedTextBox mtxt_TC;
        private TextBox txt_isim;
        private Button btn_Ara;
        private Button btn_DevamEt;
        private GroupBox grp_tarih;
        private MaskedTextBox mtxt_kiraSaati;
        private DateTimePicker dtp_kiraTarihi;
        private MaskedTextBox mtxt_teslimSaati;
        private DateTimePicker dtp_teslimTarihi;
        private Button btn_devamEt2;
        private Label label6;
        private Label label5;
        private Button btn_Geri;
    }
}