namespace RentACar2
{
    partial class frm_Rezervasyon
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
            this.btn_RezervasyonEkle = new System.Windows.Forms.Button();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.mtxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.btn_RezervasyonSil = new System.Windows.Forms.Button();
            this.list_Rezervasyonlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RezervasyonEkle
            // 
            this.btn_RezervasyonEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RezervasyonEkle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RezervasyonEkle.Location = new System.Drawing.Point(651, 125);
            this.btn_RezervasyonEkle.Name = "btn_RezervasyonEkle";
            this.btn_RezervasyonEkle.Size = new System.Drawing.Size(143, 36);
            this.btn_RezervasyonEkle.TabIndex = 19;
            this.btn_RezervasyonEkle.Text = "Rezervasyon Ekle";
            this.btn_RezervasyonEkle.UseVisualStyleBackColor = true;
            this.btn_RezervasyonEkle.Click += new System.EventHandler(this.btn_RezervasyonEkle_Click);
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ara.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Ara.Location = new System.Drawing.Point(343, 27);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(69, 31);
            this.btn_Ara.TabIndex = 18;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(76, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(551, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(551, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC NO:";
            // 
            // mtxt_telefon
            // 
            this.mtxt_telefon.Location = new System.Drawing.Point(183, 78);
            this.mtxt_telefon.Mask = "(999) 000-0000";
            this.mtxt_telefon.Name = "mtxt_telefon";
            this.mtxt_telefon.Size = new System.Drawing.Size(136, 27);
            this.mtxt_telefon.TabIndex = 14;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(658, 78);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(136, 27);
            this.txt_soyisim.TabIndex = 12;
            // 
            // mtxt_TC
            // 
            this.mtxt_TC.Location = new System.Drawing.Point(183, 28);
            this.mtxt_TC.Mask = "00000000000";
            this.mtxt_TC.Name = "mtxt_TC";
            this.mtxt_TC.Size = new System.Drawing.Size(136, 27);
            this.mtxt_TC.TabIndex = 10;
            this.mtxt_TC.ValidatingType = typeof(int);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(658, 30);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(136, 27);
            this.txt_isim.TabIndex = 11;
            // 
            // btn_RezervasyonSil
            // 
            this.btn_RezervasyonSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RezervasyonSil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RezervasyonSil.Location = new System.Drawing.Point(659, 603);
            this.btn_RezervasyonSil.Name = "btn_RezervasyonSil";
            this.btn_RezervasyonSil.Size = new System.Drawing.Size(143, 36);
            this.btn_RezervasyonSil.TabIndex = 20;
            this.btn_RezervasyonSil.Text = "Rezervasyon Sil";
            this.btn_RezervasyonSil.UseVisualStyleBackColor = true;
            this.btn_RezervasyonSil.Click += new System.EventHandler(this.btn_RezervasyonSil_Click);
            // 
            // list_Rezervasyonlar
            // 
            this.list_Rezervasyonlar.CheckBoxes = true;
            this.list_Rezervasyonlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.list_Rezervasyonlar.Location = new System.Drawing.Point(65, 187);
            this.list_Rezervasyonlar.Name = "list_Rezervasyonlar";
            this.list_Rezervasyonlar.Size = new System.Drawing.Size(747, 393);
            this.list_Rezervasyonlar.TabIndex = 21;
            this.list_Rezervasyonlar.UseCompatibleStateImageBehavior = false;
            this.list_Rezervasyonlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kira Tarihi";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Saati";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Teslim Tarihi";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Saati";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Plaka";
            this.columnHeader7.Width = 0;
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(559, 603);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(94, 36);
            this.btn_Geri.TabIndex = 22;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.list_Rezervasyonlar);
            this.Controls.Add(this.btn_RezervasyonSil);
            this.Controls.Add(this.btn_RezervasyonEkle);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_telefon);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.mtxt_TC);
            this.Controls.Add(this.txt_isim);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "frm_Rezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Rezervasyon_FormClosing);
            this.Load += new System.EventHandler(this.frm_Rezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_RezervasyonEkle;
        private Button btn_Ara;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtxt_telefon;
        private TextBox txt_soyisim;
        private MaskedTextBox mtxt_TC;
        private TextBox txt_isim;
        private Button btn_RezervasyonSil;
        private ListView list_Rezervasyonlar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btn_Geri;
        private ColumnHeader columnHeader7;
    }
}