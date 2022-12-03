namespace RentACar2
{
    partial class frm_MaliDurum
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
            this.mtxt_Yil = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Goster = new System.Windows.Forms.Button();
            this.list_MaliDurum = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_FiyatBelirle = new System.Windows.Forms.Button();
            this.mtxt_vip = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_pro = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxt_lux = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxt_eko = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxt_Yil
            // 
            this.mtxt_Yil.Location = new System.Drawing.Point(187, 57);
            this.mtxt_Yil.Mask = "2\\000";
            this.mtxt_Yil.Name = "mtxt_Yil";
            this.mtxt_Yil.Size = new System.Drawing.Size(78, 27);
            this.mtxt_Yil.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(69, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yıl Seçimi:";
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(762, 605);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(108, 36);
            this.btn_Geri.TabIndex = 29;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Goster
            // 
            this.btn_Goster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Goster.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Goster.Location = new System.Drawing.Point(281, 54);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(109, 32);
            this.btn_Goster.TabIndex = 30;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.UseVisualStyleBackColor = true;
            this.btn_Goster.Click += new System.EventHandler(this.btn_Goster_Click);
            // 
            // list_MaliDurum
            // 
            this.list_MaliDurum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_MaliDurum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_MaliDurum.Location = new System.Drawing.Point(69, 120);
            this.list_MaliDurum.Name = "list_MaliDurum";
            this.list_MaliDurum.Size = new System.Drawing.Size(321, 455);
            this.list_MaliDurum.TabIndex = 31;
            this.list_MaliDurum.UseCompatibleStateImageBehavior = false;
            this.list_MaliDurum.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ay";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kazanç";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_MaliDurum);
            this.groupBox1.Controls.Add(this.btn_Goster);
            this.groupBox1.Controls.Add(this.mtxt_Yil);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 629);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mali Durum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_FiyatBelirle);
            this.groupBox2.Controls.Add(this.mtxt_vip);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mtxt_pro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mtxt_lux);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mtxt_eko);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(509, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 553);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Belirleme";
            // 
            // btn_FiyatBelirle
            // 
            this.btn_FiyatBelirle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FiyatBelirle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_FiyatBelirle.Location = new System.Drawing.Point(96, 289);
            this.btn_FiyatBelirle.Name = "btn_FiyatBelirle";
            this.btn_FiyatBelirle.Size = new System.Drawing.Size(156, 36);
            this.btn_FiyatBelirle.TabIndex = 30;
            this.btn_FiyatBelirle.Text = "Fiyat Belirle";
            this.btn_FiyatBelirle.UseVisualStyleBackColor = true;
            this.btn_FiyatBelirle.Click += new System.EventHandler(this.btn_FiyatBelirle_Click);
            // 
            // mtxt_vip
            // 
            this.mtxt_vip.Location = new System.Drawing.Point(174, 226);
            this.mtxt_vip.Mask = "00000";
            this.mtxt_vip.Name = "mtxt_vip";
            this.mtxt_vip.Size = new System.Drawing.Size(78, 27);
            this.mtxt_vip.TabIndex = 11;
            this.mtxt_vip.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(96, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "VİP:";
            // 
            // mtxt_pro
            // 
            this.mtxt_pro.Location = new System.Drawing.Point(174, 175);
            this.mtxt_pro.Mask = "00000";
            this.mtxt_pro.Name = "mtxt_pro";
            this.mtxt_pro.Size = new System.Drawing.Size(78, 27);
            this.mtxt_pro.TabIndex = 9;
            this.mtxt_pro.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(96, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "PRO:";
            // 
            // mtxt_lux
            // 
            this.mtxt_lux.Location = new System.Drawing.Point(174, 120);
            this.mtxt_lux.Mask = "00000";
            this.mtxt_lux.Name = "mtxt_lux";
            this.mtxt_lux.Size = new System.Drawing.Size(78, 27);
            this.mtxt_lux.TabIndex = 7;
            this.mtxt_lux.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(96, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "LUX:";
            // 
            // mtxt_eko
            // 
            this.mtxt_eko.Location = new System.Drawing.Point(174, 69);
            this.mtxt_eko.Mask = "00000";
            this.mtxt_eko.Name = "mtxt_eko";
            this.mtxt_eko.Size = new System.Drawing.Size(78, 27);
            this.mtxt_eko.TabIndex = 5;
            this.mtxt_eko.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(96, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "EKO:";
            // 
            // frm_MaliDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Geri);
            this.MaximizeBox = false;
            this.Name = "frm_MaliDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mali Durum İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaliDurum_FormClosing);
            this.Load += new System.EventHandler(this.frm_MaliDurum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaskedTextBox mtxt_Yil;
        private Label label4;
        private Button btn_Geri;
        private Button btn_Goster;
        private ListView list_MaliDurum;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaskedTextBox mtxt_vip;
        private Label label3;
        private MaskedTextBox mtxt_pro;
        private Label label5;
        private MaskedTextBox mtxt_lux;
        private Label label2;
        private MaskedTextBox mtxt_eko;
        private Label label1;
        private Button btn_FiyatBelirle;
    }
}