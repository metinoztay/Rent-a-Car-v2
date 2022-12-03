namespace RentACar2
{
    partial class frm_MaliIslemler
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
            this.btn_MusteriIslemleri = new System.Windows.Forms.Button();
            this.btn_MaliDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MusteriIslemleri
            // 
            this.btn_MusteriIslemleri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MusteriIslemleri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_MusteriIslemleri.Location = new System.Drawing.Point(37, 44);
            this.btn_MusteriIslemleri.Name = "btn_MusteriIslemleri";
            this.btn_MusteriIslemleri.Size = new System.Drawing.Size(225, 64);
            this.btn_MusteriIslemleri.TabIndex = 7;
            this.btn_MusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btn_MusteriIslemleri.UseVisualStyleBackColor = true;
            this.btn_MusteriIslemleri.Click += new System.EventHandler(this.btn_MusteriIslemleri_Click);
            // 
            // btn_MaliDurum
            // 
            this.btn_MaliDurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MaliDurum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_MaliDurum.Location = new System.Drawing.Point(292, 44);
            this.btn_MaliDurum.Name = "btn_MaliDurum";
            this.btn_MaliDurum.Size = new System.Drawing.Size(225, 64);
            this.btn_MaliDurum.TabIndex = 8;
            this.btn_MaliDurum.Text = "Mali Durum";
            this.btn_MaliDurum.UseVisualStyleBackColor = true;
            this.btn_MaliDurum.Click += new System.EventHandler(this.btn_MaliDurum_Click);
            // 
            // frm_MaliIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(554, 151);
            this.ControlBox = false;
            this.Controls.Add(this.btn_MaliDurum);
            this.Controls.Add(this.btn_MusteriIslemleri);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MaliIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_MusteriIslemleri;
        private Button btn_MaliDurum;
    }
}