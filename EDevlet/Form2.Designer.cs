namespace EDevlet
{
    partial class AdminPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kullanıcıDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcıDataSet = new EDevlet.KullanıcıDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.kullanıcıDataSet11 = new EDevlet.KullanıcıDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kullaniciTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTabloTableAdapter = new EDevlet.KullanıcıDataSetTableAdapters.KullaniciTabloTableAdapter();
            this.kullanıcıİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelenMesajlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTabloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(50, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcılar";
            // 
            // kullanıcıDataSetBindingSource
            // 
            this.kullanıcıDataSetBindingSource.DataSource = this.kullanıcıDataSet;
            this.kullanıcıDataSetBindingSource.Position = 0;
            // 
            // kullanıcıDataSet
            // 
            this.kullanıcıDataSet.DataSetName = "KullanıcıDataSet";
            this.kullanıcıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(376, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MesajGönder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(45, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesaj:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btngonder);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(38, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kime";
            // 
            // btngonder
            // 
            this.btngonder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btngonder.Location = new System.Drawing.Point(70, 67);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(75, 23);
            this.btngonder.TabIndex = 2;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KullanıcıAdı";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(215, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // kullanıcıDataSet11
            // 
            this.kullanıcıDataSet11.DataSetName = "KullanıcıDataSet1";
            this.kullanıcıDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullanıcıİdDataGridViewTextBoxColumn,
            this.kullanıcıAdıDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.gelenMesajlarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kullaniciTabloBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(268, 312);
            this.dataGridView2.TabIndex = 2;
            // 
            // kullaniciTabloBindingSource
            // 
            this.kullaniciTabloBindingSource.DataMember = "KullaniciTablo";
            this.kullaniciTabloBindingSource.DataSource = this.kullanıcıDataSetBindingSource;
            // 
            // kullaniciTabloTableAdapter
            // 
            this.kullaniciTabloTableAdapter.ClearBeforeFill = true;
            // 
            // kullanıcıİdDataGridViewTextBoxColumn
            // 
            this.kullanıcıİdDataGridViewTextBoxColumn.DataPropertyName = "Kullanıcıİd";
            this.kullanıcıİdDataGridViewTextBoxColumn.HeaderText = "Kullanıcıİd";
            this.kullanıcıİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullanıcıİdDataGridViewTextBoxColumn.Name = "kullanıcıİdDataGridViewTextBoxColumn";
            this.kullanıcıİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullanıcıİdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullanıcıAdıDataGridViewTextBoxColumn
            // 
            this.kullanıcıAdıDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.HeaderText = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullanıcıAdıDataGridViewTextBoxColumn.Name = "kullanıcıAdıDataGridViewTextBoxColumn";
            this.kullanıcıAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // gelenMesajlarDataGridViewTextBoxColumn
            // 
            this.gelenMesajlarDataGridViewTextBoxColumn.DataPropertyName = "GelenMesajlar";
            this.gelenMesajlarDataGridViewTextBoxColumn.HeaderText = "GelenMesajlar";
            this.gelenMesajlarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gelenMesajlarDataGridViewTextBoxColumn.Name = "gelenMesajlarDataGridViewTextBoxColumn";
            this.gelenMesajlarDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTabloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kullanıcıDataSetBindingSource;
        private KullanıcıDataSet kullanıcıDataSet;
        private KullanıcıDataSet1 kullanıcıDataSet11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource kullaniciTabloBindingSource;
        private KullanıcıDataSetTableAdapters.KullaniciTabloTableAdapter kullaniciTabloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelenMesajlarDataGridViewTextBoxColumn;
    }
}