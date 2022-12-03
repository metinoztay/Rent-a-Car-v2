namespace RentACar2
{
    partial class frm_AracBilgisiDuzenle
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
            this.cbx_Araclar = new System.Windows.Forms.ComboBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.cbx_uygunluk = new System.Windows.Forms.ComboBox();
            this.mtxt_kasko = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_sigorta = new System.Windows.Forms.MaskedTextBox();
            this.cbx_vites = new System.Windows.Forms.ComboBox();
            this.cbx_yakit = new System.Windows.Forms.ComboBox();
            this.cbx_tip = new System.Windows.Forms.ComboBox();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_Araclar
            // 
            this.cbx_Araclar.FormattingEnabled = true;
            this.cbx_Araclar.Location = new System.Drawing.Point(48, 51);
            this.cbx_Araclar.Name = "cbx_Araclar";
            this.cbx_Araclar.Size = new System.Drawing.Size(780, 28);
            this.cbx_Araclar.TabIndex = 0;
            this.cbx_Araclar.SelectedIndexChanged += new System.EventHandler(this.cbx_Araclar_SelectedIndexChanged);
            // 
            // txt_model
            // 
            this.txt_model.Enabled = false;
            this.txt_model.Location = new System.Drawing.Point(216, 237);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(175, 27);
            this.txt_model.TabIndex = 31;
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(485, 410);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(100, 47);
            this.btn_Geri.TabIndex = 39;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Kaydet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Kaydet.Location = new System.Drawing.Point(593, 410);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(235, 47);
            this.btn_Kaydet.TabIndex = 38;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // cbx_uygunluk
            // 
            this.cbx_uygunluk.FormattingEnabled = true;
            this.cbx_uygunluk.Items.AddRange(new object[] {
            "UYGUN",
            "KİRADA",
            "UYGUN DEĞİL"});
            this.cbx_uygunluk.Location = new System.Drawing.Point(653, 347);
            this.cbx_uygunluk.Name = "cbx_uygunluk";
            this.cbx_uygunluk.Size = new System.Drawing.Size(175, 28);
            this.cbx_uygunluk.TabIndex = 37;
            // 
            // mtxt_kasko
            // 
            this.mtxt_kasko.Location = new System.Drawing.Point(653, 292);
            this.mtxt_kasko.Mask = "00/00/0000";
            this.mtxt_kasko.Name = "mtxt_kasko";
            this.mtxt_kasko.Size = new System.Drawing.Size(175, 27);
            this.mtxt_kasko.TabIndex = 36;
            this.mtxt_kasko.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_sigorta
            // 
            this.mtxt_sigorta.Location = new System.Drawing.Point(653, 237);
            this.mtxt_sigorta.Mask = "00/00/0000";
            this.mtxt_sigorta.Name = "mtxt_sigorta";
            this.mtxt_sigorta.Size = new System.Drawing.Size(175, 27);
            this.mtxt_sigorta.TabIndex = 35;
            this.mtxt_sigorta.ValidatingType = typeof(System.DateTime);
            // 
            // cbx_vites
            // 
            this.cbx_vites.Enabled = false;
            this.cbx_vites.FormattingEnabled = true;
            this.cbx_vites.Items.AddRange(new object[] {
            "MANUEL",
            "OTOMATİK",
            "YARI OTOMATİK"});
            this.cbx_vites.Location = new System.Drawing.Point(653, 178);
            this.cbx_vites.Name = "cbx_vites";
            this.cbx_vites.Size = new System.Drawing.Size(175, 28);
            this.cbx_vites.TabIndex = 34;
            // 
            // cbx_yakit
            // 
            this.cbx_yakit.Enabled = false;
            this.cbx_yakit.FormattingEnabled = true;
            this.cbx_yakit.Items.AddRange(new object[] {
            "BENZİN",
            "DİZEL",
            "BENZİN+LPG"});
            this.cbx_yakit.Location = new System.Drawing.Point(653, 123);
            this.cbx_yakit.Name = "cbx_yakit";
            this.cbx_yakit.Size = new System.Drawing.Size(175, 28);
            this.cbx_yakit.TabIndex = 33;
            // 
            // cbx_tip
            // 
            this.cbx_tip.FormattingEnabled = true;
            this.cbx_tip.Items.AddRange(new object[] {
            "EKO",
            "LUX",
            "PRO",
            "VİP"});
            this.cbx_tip.Location = new System.Drawing.Point(216, 291);
            this.cbx_tip.Name = "cbx_tip";
            this.cbx_tip.Size = new System.Drawing.Size(175, 28);
            this.cbx_tip.TabIndex = 32;
            // 
            // txt_marka
            // 
            this.txt_marka.Enabled = false;
            this.txt_marka.Location = new System.Drawing.Point(216, 182);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(175, 27);
            this.txt_marka.TabIndex = 30;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Enabled = false;
            this.txt_plaka.Location = new System.Drawing.Point(216, 126);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(175, 27);
            this.txt_plaka.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(485, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Uygunluk:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(485, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kasko Btş.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(485, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sigorta Btş.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(485, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Vites:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(485, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Yakıt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(48, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(48, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(48, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(48, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Plaka:";
            // 
            // frm_AracBilgisiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.cbx_uygunluk);
            this.Controls.Add(this.mtxt_kasko);
            this.Controls.Add(this.mtxt_sigorta);
            this.Controls.Add(this.cbx_vites);
            this.Controls.Add(this.cbx_yakit);
            this.Controls.Add(this.cbx_tip);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Araclar);
            this.MaximizeBox = false;
            this.Name = "frm_AracBilgisiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracBilgisiDuzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_AracBilgisiDuzenle_FormClosing);
            this.Load += new System.EventHandler(this.AracBilgisiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbx_Araclar;
        private TextBox txt_model;
        private Button btn_Geri;
        private Button btn_Kaydet;
        private ComboBox cbx_uygunluk;
        private MaskedTextBox mtxt_kasko;
        private MaskedTextBox mtxt_sigorta;
        private ComboBox cbx_vites;
        private ComboBox cbx_yakit;
        private ComboBox cbx_tip;
        private TextBox txt_marka;
        private TextBox txt_plaka;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}