namespace RentACar2
{
    partial class frm_MusteriIslemleri
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
            this.btn_Ara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_isimSoyisim = new System.Windows.Forms.TextBox();
            this.list_Kiralar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.list_Odemeler = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Kira = new System.Windows.Forms.Label();
            this.lbl_Borc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Kira = new System.Windows.Forms.TextBox();
            this.txt_Odenen = new System.Windows.Forms.TextBox();
            this.txt_Borc = new System.Windows.Forms.TextBox();
            this.btn_odemeAl = new System.Windows.Forms.Button();
            this.dtp_odemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxt_odenenTutar = new System.Windows.Forms.MaskedTextBox();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ara.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Ara.Location = new System.Drawing.Point(231, 28);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(69, 31);
            this.btn_Ara.TabIndex = 46;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(668, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(316, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "İsim / Soyisim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "TC NO:";
            // 
            // mtxt_telefon
            // 
            this.mtxt_telefon.Enabled = false;
            this.mtxt_telefon.Location = new System.Drawing.Point(754, 32);
            this.mtxt_telefon.Mask = "(999) 000-0000";
            this.mtxt_telefon.Name = "mtxt_telefon";
            this.mtxt_telefon.Size = new System.Drawing.Size(113, 27);
            this.mtxt_telefon.TabIndex = 43;
            // 
            // mtxt_TC
            // 
            this.mtxt_TC.Location = new System.Drawing.Point(89, 32);
            this.mtxt_TC.Mask = "00000000000";
            this.mtxt_TC.Name = "mtxt_TC";
            this.mtxt_TC.Size = new System.Drawing.Size(136, 27);
            this.mtxt_TC.TabIndex = 40;
            this.mtxt_TC.ValidatingType = typeof(int);
            // 
            // txt_isimSoyisim
            // 
            this.txt_isimSoyisim.Enabled = false;
            this.txt_isimSoyisim.Location = new System.Drawing.Point(450, 32);
            this.txt_isimSoyisim.Name = "txt_isimSoyisim";
            this.txt_isimSoyisim.Size = new System.Drawing.Size(209, 27);
            this.txt_isimSoyisim.TabIndex = 41;
            // 
            // list_Kiralar
            // 
            this.list_Kiralar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_Kiralar.Location = new System.Drawing.Point(14, 117);
            this.list_Kiralar.Name = "list_Kiralar";
            this.list_Kiralar.Size = new System.Drawing.Size(525, 323);
            this.list_Kiralar.TabIndex = 47;
            this.list_Kiralar.UseCompatibleStateImageBehavior = false;
            this.list_Kiralar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kira Tarihi";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Teslim Tarihi";
            this.columnHeader3.Width = 175;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ücret";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 70;
            // 
            // list_Odemeler
            // 
            this.list_Odemeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9});
            this.list_Odemeler.Location = new System.Drawing.Point(545, 117);
            this.list_Odemeler.Name = "list_Odemeler";
            this.list_Odemeler.Size = new System.Drawing.Size(324, 323);
            this.list_Odemeler.TabIndex = 48;
            this.list_Odemeler.UseCompatibleStateImageBehavior = false;
            this.list_Odemeler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ödeme Tarihi";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ödenen Tutar";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Kira Geçmişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(545, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ödeme Geçmişi";
            // 
            // lbl_Kira
            // 
            this.lbl_Kira.AutoSize = true;
            this.lbl_Kira.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Kira.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Kira.Location = new System.Drawing.Point(14, 477);
            this.lbl_Kira.Name = "lbl_Kira";
            this.lbl_Kira.Size = new System.Drawing.Size(166, 23);
            this.lbl_Kira.TabIndex = 51;
            this.lbl_Kira.Text = "Toplam Kira Bedeli:";
            // 
            // lbl_Borc
            // 
            this.lbl_Borc.AutoSize = true;
            this.lbl_Borc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Borc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Borc.Location = new System.Drawing.Point(14, 516);
            this.lbl_Borc.Name = "lbl_Borc";
            this.lbl_Borc.Size = new System.Drawing.Size(189, 23);
            this.lbl_Borc.TabIndex = 52;
            this.lbl_Borc.Text = "Toplam Ödenen Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(14, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Borç Tutarı:";
            // 
            // txt_Kira
            // 
            this.txt_Kira.Enabled = false;
            this.txt_Kira.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Kira.Location = new System.Drawing.Point(231, 472);
            this.txt_Kira.Name = "txt_Kira";
            this.txt_Kira.Size = new System.Drawing.Size(125, 31);
            this.txt_Kira.TabIndex = 54;
            this.txt_Kira.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Odenen
            // 
            this.txt_Odenen.Enabled = false;
            this.txt_Odenen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Odenen.Location = new System.Drawing.Point(231, 511);
            this.txt_Odenen.Name = "txt_Odenen";
            this.txt_Odenen.Size = new System.Drawing.Size(125, 31);
            this.txt_Odenen.TabIndex = 55;
            this.txt_Odenen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Borc
            // 
            this.txt_Borc.Enabled = false;
            this.txt_Borc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Borc.Location = new System.Drawing.Point(231, 549);
            this.txt_Borc.Name = "txt_Borc";
            this.txt_Borc.Size = new System.Drawing.Size(125, 31);
            this.txt_Borc.TabIndex = 56;
            this.txt_Borc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_odemeAl
            // 
            this.btn_odemeAl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_odemeAl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_odemeAl.Location = new System.Drawing.Point(720, 508);
            this.btn_odemeAl.Name = "btn_odemeAl";
            this.btn_odemeAl.Size = new System.Drawing.Size(125, 40);
            this.btn_odemeAl.TabIndex = 57;
            this.btn_odemeAl.Text = "Ödeme Al";
            this.btn_odemeAl.UseVisualStyleBackColor = true;
            this.btn_odemeAl.Click += new System.EventHandler(this.btn_odemeAl_Click);
            // 
            // dtp_odemeTarihi
            // 
            this.dtp_odemeTarihi.Location = new System.Drawing.Point(572, 469);
            this.dtp_odemeTarihi.Name = "dtp_odemeTarihi";
            this.dtp_odemeTarihi.Size = new System.Drawing.Size(273, 27);
            this.dtp_odemeTarihi.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(438, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ödeme Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(438, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Ödenen Tutar:";
            // 
            // mtxt_odenenTutar
            // 
            this.mtxt_odenenTutar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_odenenTutar.Location = new System.Drawing.Point(572, 512);
            this.mtxt_odenenTutar.Mask = "0000000";
            this.mtxt_odenenTutar.Name = "mtxt_odenenTutar";
            this.mtxt_odenenTutar.Size = new System.Drawing.Size(125, 31);
            this.mtxt_odenenTutar.TabIndex = 62;
            this.mtxt_odenenTutar.ValidatingType = typeof(int);
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(720, 554);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(125, 37);
            this.btn_Geri.TabIndex = 63;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.mtxt_odenenTutar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_odemeTarihi);
            this.Controls.Add(this.btn_odemeAl);
            this.Controls.Add(this.txt_Borc);
            this.Controls.Add(this.txt_Odenen);
            this.Controls.Add(this.txt_Kira);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Borc);
            this.Controls.Add(this.lbl_Kira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_Odemeler);
            this.Controls.Add(this.list_Kiralar);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxt_telefon);
            this.Controls.Add(this.mtxt_TC);
            this.Controls.Add(this.txt_isimSoyisim);
            this.MaximizeBox = false;
            this.Name = "frm_MusteriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MusteriIslemleri_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Ara;
        private Label label4;
        private Label label1;
        private Label label5;
        private MaskedTextBox mtxt_telefon;
        private MaskedTextBox mtxt_TC;
        private TextBox txt_isimSoyisim;
        private ListView list_Kiralar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView list_Odemeler;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader9;
        private Label label2;
        private Label label3;
        private Label lbl_Kira;
        private Label lbl_Borc;
        private Label label6;
        private TextBox txt_Kira;
        private TextBox txt_Odenen;
        private TextBox txt_Borc;
        private Button btn_odemeAl;
        private DateTimePicker dtp_odemeTarihi;
        private Label label7;
        private Label label8;
        private MaskedTextBox mtxt_odenenTutar;
        private Button btn_Geri;
    }
}