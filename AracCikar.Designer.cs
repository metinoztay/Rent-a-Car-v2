namespace RentACar2
{
    partial class frm_AracCikar
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
            this.plaka_c = new System.Windows.Forms.ColumnHeader();
            this.marka_c = new System.Windows.Forms.ColumnHeader();
            this.model_c = new System.Windows.Forms.ColumnHeader();
            this.tip_c = new System.Windows.Forms.ColumnHeader();
            this.yakit_c = new System.Windows.Forms.ColumnHeader();
            this.vites_c = new System.Windows.Forms.ColumnHeader();
            this.uygunluk_c = new System.Windows.Forms.ColumnHeader();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_AraciSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Araclar
            // 
            this.list_Araclar.CheckBoxes = true;
            this.list_Araclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.plaka_c,
            this.marka_c,
            this.model_c,
            this.tip_c,
            this.yakit_c,
            this.vites_c,
            this.uygunluk_c});
            this.list_Araclar.Location = new System.Drawing.Point(21, 12);
            this.list_Araclar.Name = "list_Araclar";
            this.list_Araclar.Size = new System.Drawing.Size(836, 545);
            this.list_Araclar.TabIndex = 4;
            this.list_Araclar.UseCompatibleStateImageBehavior = false;
            this.list_Araclar.View = System.Windows.Forms.View.Details;
            // 
            // plaka_c
            // 
            this.plaka_c.Text = "Plaka";
            this.plaka_c.Width = 120;
            // 
            // marka_c
            // 
            this.marka_c.Text = "Marka";
            this.marka_c.Width = 157;
            // 
            // model_c
            // 
            this.model_c.Text = "Model";
            this.model_c.Width = 120;
            // 
            // tip_c
            // 
            this.tip_c.Text = "Tip";
            this.tip_c.Width = 75;
            // 
            // yakit_c
            // 
            this.yakit_c.Text = "Yakıt";
            this.yakit_c.Width = 120;
            // 
            // vites_c
            // 
            this.vites_c.Text = "Vites";
            this.vites_c.Width = 120;
            // 
            // uygunluk_c
            // 
            this.uygunluk_c.Text = "Uygunluk";
            this.uygunluk_c.Width = 120;
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(21, 583);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(94, 46);
            this.btn_Geri.TabIndex = 5;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_AraciSil
            // 
            this.btn_AraciSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AraciSil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AraciSil.Location = new System.Drawing.Point(647, 577);
            this.btn_AraciSil.Name = "btn_AraciSil";
            this.btn_AraciSil.Size = new System.Drawing.Size(210, 52);
            this.btn_AraciSil.TabIndex = 6;
            this.btn_AraciSil.Text = "Araci Sil";
            this.btn_AraciSil.UseVisualStyleBackColor = true;
            this.btn_AraciSil.Click += new System.EventHandler(this.btn_AraciSil_Click);
            // 
            // frm_AracCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btn_AraciSil);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.list_Araclar);
            this.MaximizeBox = false;
            this.Name = "frm_AracCikar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracCikar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AracCikar_FormClosing);
            this.Load += new System.EventHandler(this.AracCikar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView list_Araclar;
        private Button btn_Geri;
        private Button btn_AraciSil;
        private ColumnHeader plaka_c;
        private ColumnHeader marka_c;
        private ColumnHeader model_c;
        private ColumnHeader tip_c;
        private ColumnHeader yakit_c;
        private ColumnHeader vites_c;
        private ColumnHeader uygunluk_c;
    }
}