namespace EDevlet
{
    partial class formsifre
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
            this.txtf4kllaniciadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifretekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyenisifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtf4kllaniciadi
            // 
            this.txtf4kllaniciadi.Location = new System.Drawing.Point(182, 54);
            this.txtf4kllaniciadi.Name = "txtf4kllaniciadi";
            this.txtf4kllaniciadi.Size = new System.Drawing.Size(100, 22);
            this.txtf4kllaniciadi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KullanıcıAdı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SifreTekrar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSifretekrar
            // 
            this.txtSifretekrar.Location = new System.Drawing.Point(182, 110);
            this.txtSifretekrar.Name = "txtSifretekrar";
            this.txtSifretekrar.Size = new System.Drawing.Size(100, 22);
            this.txtSifretekrar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "YeniSifre";
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.Location = new System.Drawing.Point(182, 82);
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.Size = new System.Drawing.Size(100, 22);
            this.txtyenisifre.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnyenile);
            this.groupBox1.Controls.Add(this.txtf4kllaniciadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtyenisifre);
            this.groupBox1.Controls.Add(this.txtSifretekrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(160, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sifre Yenile";
            // 
            // btnyenile
            // 
            this.btnyenile.Location = new System.Drawing.Point(206, 139);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(75, 23);
            this.btnyenile.TabIndex = 6;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = true;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // formsifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "formsifre";
            this.Text = "Sifre Yenile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtf4kllaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifretekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyenisifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnyenile;
    }
}