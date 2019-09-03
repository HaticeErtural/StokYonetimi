namespace Sy.Forms
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKayitEt = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblGirisBilgi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.btnKayitEt);
            this.groupBox1.Location = new System.Drawing.Point(41, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // btnKayitEt
            // 
            this.btnKayitEt.Location = new System.Drawing.Point(113, 19);
            this.btnKayitEt.Name = "btnKayitEt";
            this.btnKayitEt.Size = new System.Drawing.Size(90, 59);
            this.btnKayitEt.TabIndex = 0;
            this.btnKayitEt.Text = "Kayıt Et";
            this.btnKayitEt.UseVisualStyleBackColor = true;
            this.btnKayitEt.Click += new System.EventHandler(this.btnKayitEt_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(6, 19);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(91, 59);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblGirisBilgi
            // 
            this.lblGirisBilgi.AutoSize = true;
            this.lblGirisBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBilgi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGirisBilgi.Location = new System.Drawing.Point(37, 9);
            this.lblGirisBilgi.Name = "lblGirisBilgi";
            this.lblGirisBilgi.Size = new System.Drawing.Size(220, 24);
            this.lblGirisBilgi.TabIndex = 1;
            this.lblGirisBilgi.Text = "Hoşgeldin:  Kamil Fıdıl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 190);
            this.Controls.Add(this.lblGirisBilgi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayitEt;
        private System.Windows.Forms.Label lblGirisBilgi;
    }
}

