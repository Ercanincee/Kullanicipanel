namespace EDevlet
{
    partial class FormKullanici
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullanici));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kelimeingilizce = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kelimeturkce = new System.Windows.Forms.Label();
            this.btnarka = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kelimeTürkcesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelimeingilizceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelimelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcıDataSet2 = new EDevlet.KullanıcıDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kullanıcıDataSet1 = new EDevlet.KullanıcıDataSet();
            this.kelimelerTableAdapter = new EDevlet.KullanıcıDataSet2TableAdapters.KelimelerTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kelimeingilizce);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kelimeturkce);
            this.panel1.Location = new System.Drawing.Point(41, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 221);
            this.panel1.TabIndex = 0;
            // 
            // kelimeingilizce
            // 
            this.kelimeingilizce.AutoSize = true;
            this.kelimeingilizce.Location = new System.Drawing.Point(96, 97);
            this.kelimeingilizce.Name = "kelimeingilizce";
            this.kelimeingilizce.Size = new System.Drawing.Size(44, 16);
            this.kelimeingilizce.TabIndex = 2;
            this.kelimeingilizce.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // kelimeturkce
            // 
            this.kelimeturkce.AutoSize = true;
            this.kelimeturkce.Location = new System.Drawing.Point(96, 81);
            this.kelimeturkce.Name = "kelimeturkce";
            this.kelimeturkce.Size = new System.Drawing.Size(44, 16);
            this.kelimeturkce.TabIndex = 0;
            this.kelimeturkce.Text = "label1";
            // 
            // btnarka
            // 
            this.btnarka.Location = new System.Drawing.Point(99, 352);
            this.btnarka.Name = "btnarka";
            this.btnarka.Size = new System.Drawing.Size(147, 23);
            this.btnarka.TabIndex = 1;
            this.btnarka.Text = "Arkasını Cevir";
            this.btnarka.UseVisualStyleBackColor = true;
            this.btnarka.Click += new System.EventHandler(this.btnarka_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kelimeTürkcesiDataGridViewTextBoxColumn,
            this.kelimeingilizceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kelimelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(321, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(270, 221);
            this.dataGridView1.TabIndex = 2;
            // 
            // kelimeTürkcesiDataGridViewTextBoxColumn
            // 
            this.kelimeTürkcesiDataGridViewTextBoxColumn.DataPropertyName = "KelimeTürkcesi";
            this.kelimeTürkcesiDataGridViewTextBoxColumn.HeaderText = "KelimeTürkcesi";
            this.kelimeTürkcesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kelimeTürkcesiDataGridViewTextBoxColumn.Name = "kelimeTürkcesiDataGridViewTextBoxColumn";
            this.kelimeTürkcesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kelimeingilizceDataGridViewTextBoxColumn
            // 
            this.kelimeingilizceDataGridViewTextBoxColumn.DataPropertyName = "kelimeingilizce";
            this.kelimeingilizceDataGridViewTextBoxColumn.HeaderText = "kelimeingilizce";
            this.kelimeingilizceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kelimeingilizceDataGridViewTextBoxColumn.Name = "kelimeingilizceDataGridViewTextBoxColumn";
            this.kelimeingilizceDataGridViewTextBoxColumn.Width = 125;
            // 
            // kelimelerBindingSource
            // 
            this.kelimelerBindingSource.DataMember = "Kelimeler";
            this.kelimelerBindingSource.DataSource = this.kullanıcıDataSet2;
            // 
            // kullanıcıDataSet2
            // 
            this.kullanıcıDataSet2.DataSetName = "KullanıcıDataSet2";
            this.kullanıcıDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelimeler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "mesajları ac";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanıcıDataSet1
            // 
            this.kullanıcıDataSet1.DataSetName = "KullanıcıDataSet";
            this.kullanıcıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimelerTableAdapter
            // 
            this.kelimelerTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FormKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnarka);
            this.Controls.Add(this.panel1);
            this.Name = "FormKullanici";
            this.Text = "KullanıcıPanel";
            this.Load += new System.EventHandler(this.FormKullanici_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kelimeingilizce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kelimeturkce;
        private System.Windows.Forms.Button btnarka;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private KullanıcıDataSet kullanıcıDataSet1;
        private KullanıcıDataSet2 kullanıcıDataSet2;
        private System.Windows.Forms.BindingSource kelimelerBindingSource;
        private KullanıcıDataSet2TableAdapters.KelimelerTableAdapter kelimelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelimeTürkcesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelimeingilizceDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}