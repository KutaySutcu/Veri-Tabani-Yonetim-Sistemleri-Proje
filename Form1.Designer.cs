namespace UniversiteArayuz
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolumNo = new System.Windows.Forms.TextBox();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDanisman = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(586, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(637, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Numarası:";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciNo.ForeColor = System.Drawing.Color.White;
            this.txtOgrenciNo.Location = new System.Drawing.Point(857, 82);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(194, 28);
            this.txtOgrenciNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(637, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm Numarası:";
            // 
            // txtBolumNo
            // 
            this.txtBolumNo.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtBolumNo.ForeColor = System.Drawing.Color.White;
            this.txtBolumNo.Location = new System.Drawing.Point(857, 116);
            this.txtBolumNo.Name = "txtBolumNo";
            this.txtBolumNo.Size = new System.Drawing.Size(194, 28);
            this.txtBolumNo.TabIndex = 5;
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleme.Location = new System.Drawing.Point(855, 279);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(195, 39);
            this.btnEkleme.TabIndex = 6;
            this.btnEkleme.Text = "Ekleme";
            this.btnEkleme.UseVisualStyleBackColor = false;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilme.Location = new System.Drawing.Point(855, 324);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(195, 39);
            this.btnSilme.TabIndex = 7;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = false;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuncelleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelleme.Location = new System.Drawing.Point(855, 369);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(195, 39);
            this.btnGuncelleme.TabIndex = 8;
            this.btnGuncelleme.Text = "Güncelleme";
            this.btnGuncelleme.UseVisualStyleBackColor = false;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(637, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danışman Adı Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(637, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Öğrenci Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(637, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Öğrenci Soyadı:";
            // 
            // txtDanisman
            // 
            this.txtDanisman.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtDanisman.ForeColor = System.Drawing.Color.White;
            this.txtDanisman.Location = new System.Drawing.Point(857, 150);
            this.txtDanisman.Name = "txtDanisman";
            this.txtDanisman.Size = new System.Drawing.Size(194, 28);
            this.txtDanisman.TabIndex = 12;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciAd.ForeColor = System.Drawing.Color.White;
            this.txtOgrenciAd.Location = new System.Drawing.Point(857, 184);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(194, 28);
            this.txtOgrenciAd.TabIndex = 13;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciSoyad.ForeColor = System.Drawing.Color.White;
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(857, 218);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(194, 28);
            this.txtOgrenciSoyad.TabIndex = 14;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruntule.Location = new System.Drawing.Point(627, 279);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(195, 174);
            this.btnGoruntule.TabIndex = 15;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(774, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ara:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(828, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 28);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1100, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.txtOgrenciSoyad);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.txtDanisman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnEkleme);
            this.Controls.Add(this.txtBolumNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolumNo;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDanisman;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

