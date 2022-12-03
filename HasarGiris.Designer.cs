namespace RentACar2
{
    partial class frm_HasarGiris
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
            this.txt_hasar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_hasar
            // 
            this.txt_hasar.Location = new System.Drawing.Point(169, 43);
            this.txt_hasar.Name = "txt_hasar";
            this.txt_hasar.Size = new System.Drawing.Size(125, 27);
            this.txt_hasar.TabIndex = 0;
            this.txt_hasar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasar Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(300, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "₺";
            // 
            // btn_Onay
            // 
            this.btn_Onay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Onay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Onay.Location = new System.Drawing.Point(169, 111);
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.Size = new System.Drawing.Size(125, 38);
            this.btn_Onay.TabIndex = 3;
            this.btn_Onay.Text = "Onay";
            this.btn_Onay.UseVisualStyleBackColor = true;
            this.btn_Onay.Click += new System.EventHandler(this.btn_Onay_Click);
            // 
            // frm_HasarGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(356, 220);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Onay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hasar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HasarGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasar Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_HasarGiris_FormClosing);
            this.Load += new System.EventHandler(this.frm_HasarGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_hasar;
        private Label label1;
        private Label label2;
        private Button btn_Onay;
    }
}