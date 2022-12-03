namespace RentACar2
{
    partial class frm_AracSecTeslim
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
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.list_Rezervasyonlar = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TeslimEt = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.lbl_toplam = new System.Windows.Forms.Label();
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
            this.columnHeader13});
            this.list_Araclar.Location = new System.Drawing.Point(23, 38);
            this.list_Araclar.Name = "list_Araclar";
            this.list_Araclar.Size = new System.Drawing.Size(836, 320);
            this.list_Araclar.TabIndex = 0;
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
            // columnHeader13
            // 
            this.columnHeader13.Text = "Plaka";
            this.columnHeader13.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Araca Ait Rezervasyon Bilgileri";
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
            this.list_Rezervasyonlar.Location = new System.Drawing.Point(23, 391);
            this.list_Rezervasyonlar.Name = "list_Rezervasyonlar";
            this.list_Rezervasyonlar.Size = new System.Drawing.Size(836, 208);
            this.list_Rezervasyonlar.TabIndex = 24;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Araçlar";
            // 
            // btn_TeslimEt
            // 
            this.btn_TeslimEt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TeslimEt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_TeslimEt.Location = new System.Drawing.Point(705, 605);
            this.btn_TeslimEt.Name = "btn_TeslimEt";
            this.btn_TeslimEt.Size = new System.Drawing.Size(154, 36);
            this.btn_TeslimEt.TabIndex = 27;
            this.btn_TeslimEt.Text = "Teslim Et";
            this.btn_TeslimEt.UseVisualStyleBackColor = true;
            this.btn_TeslimEt.Click += new System.EventHandler(this.btn_TeslimEt_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(591, 605);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(108, 36);
            this.btn_Geri.TabIndex = 28;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_toplam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_toplam.Location = new System.Drawing.Point(25, 613);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(0, 23);
            this.lbl_toplam.TabIndex = 29;
            // 
            // frm_AracSecTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_TeslimEt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Rezervasyonlar);
            this.Controls.Add(this.list_Araclar);
            this.MinimizeBox = false;
            this.Name = "frm_AracSecTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Seçim";
            this.Load += new System.EventHandler(this.AracSecTeslim_Load);
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
        private Label label1;
        private ListView list_Rezervasyonlar;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Label label2;
        private Button btn_TeslimEt;
        private Button btn_Geri;
        private ColumnHeader columnHeader13;
        private Label lbl_toplam;
    }
}