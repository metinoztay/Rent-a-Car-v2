namespace RentACar2
{
    partial class frm_AracTeslimAl
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
            this.label2 = new System.Windows.Forms.Label();
            this.list_Araclar = new System.Windows.Forms.ListView();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_TeslimAl = new System.Windows.Forms.Button();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_isimSoyisim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Araçlar";
            // 
            // list_Araclar
            // 
            this.list_Araclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.list_Araclar.Location = new System.Drawing.Point(21, 120);
            this.list_Araclar.Name = "list_Araclar";
            this.list_Araclar.Size = new System.Drawing.Size(836, 457);
            this.list_Araclar.TabIndex = 27;
            this.list_Araclar.UseCompatibleStateImageBehavior = false;
            this.list_Araclar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Plaka";
            this.columnHeader13.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Uygunluk";
            this.columnHeader6.Width = 150;
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(589, 583);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(108, 47);
            this.btn_Geri.TabIndex = 30;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_TeslimAl
            // 
            this.btn_TeslimAl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TeslimAl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_TeslimAl.Location = new System.Drawing.Point(703, 583);
            this.btn_TeslimAl.Name = "btn_TeslimAl";
            this.btn_TeslimAl.Size = new System.Drawing.Size(154, 47);
            this.btn_TeslimAl.TabIndex = 29;
            this.btn_TeslimAl.Text = "Teslim Al";
            this.btn_TeslimAl.UseVisualStyleBackColor = true;
            this.btn_TeslimAl.Click += new System.EventHandler(this.btn_TeslimAl_Click);
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ara.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Ara.Location = new System.Drawing.Point(231, 15);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(69, 31);
            this.btn_Ara.TabIndex = 39;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(668, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(316, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "İsim / Soyisim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "TC NO:";
            // 
            // mtxt_telefon
            // 
            this.mtxt_telefon.Enabled = false;
            this.mtxt_telefon.Location = new System.Drawing.Point(754, 17);
            this.mtxt_telefon.Mask = "(999) 000-0000";
            this.mtxt_telefon.Name = "mtxt_telefon";
            this.mtxt_telefon.Size = new System.Drawing.Size(113, 27);
            this.mtxt_telefon.TabIndex = 35;
            // 
            // mtxt_TC
            // 
            this.mtxt_TC.Location = new System.Drawing.Point(89, 19);
            this.mtxt_TC.Mask = "00000000000";
            this.mtxt_TC.Name = "mtxt_TC";
            this.mtxt_TC.Size = new System.Drawing.Size(136, 27);
            this.mtxt_TC.TabIndex = 31;
            this.mtxt_TC.ValidatingType = typeof(int);
            // 
            // txt_isimSoyisim
            // 
            this.txt_isimSoyisim.Enabled = false;
            this.txt_isimSoyisim.Location = new System.Drawing.Point(450, 18);
            this.txt_isimSoyisim.Name = "txt_isimSoyisim";
            this.txt_isimSoyisim.Size = new System.Drawing.Size(209, 27);
            this.txt_isimSoyisim.TabIndex = 32;
            // 
            // frm_AracTeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxt_telefon);
            this.Controls.Add(this.mtxt_TC);
            this.Controls.Add(this.txt_isimSoyisim);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_TeslimAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_Araclar);
            this.MaximizeBox = false;
            this.Name = "frm_AracTeslimAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Teslim Al";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_AracTeslimAl_FormClosing);
            this.Load += new System.EventHandler(this.frm_AracTeslimAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private ListView list_Araclar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader13;
        private Button btn_Geri;
        private Button btn_TeslimAl;
        private Button btn_Ara;
        private Label label4;
        private Label label1;
        private Label label5;
        private MaskedTextBox mtxt_telefon;
        private MaskedTextBox mtxt_TC;
        private TextBox txt_isimSoyisim;
    }
}