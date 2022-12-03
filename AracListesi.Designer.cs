namespace RentACar2
{
    partial class frm_AracListesi
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
            this.btn_Geri = new System.Windows.Forms.Button();
            this.list_Araclar = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Geri.Location = new System.Drawing.Point(754, 594);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(94, 38);
            this.btn_Geri.TabIndex = 1;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // list_Araclar
            // 
            this.list_Araclar.Location = new System.Drawing.Point(21, 29);
            this.list_Araclar.Name = "list_Araclar";
            this.list_Araclar.Size = new System.Drawing.Size(836, 545);
            this.list_Araclar.TabIndex = 3;
            this.list_Araclar.UseCompatibleStateImageBehavior = false;
            this.list_Araclar.View = System.Windows.Forms.View.Details;
            this.list_Araclar.SelectedIndexChanged += new System.EventHandler(this.list_Araclar_SelectedIndexChanged);
            // 
            // frm_AracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.list_Araclar);
            this.Controls.Add(this.btn_Geri);
            this.MaximizeBox = false;
            this.Name = "frm_AracListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracListesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_AracListesi_FormClosing);
            this.Load += new System.EventHandler(this.AracListesi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_Geri;
        private ListView list_Araclar;
    }
}