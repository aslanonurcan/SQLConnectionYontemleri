namespace Disconnected2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnIdUrunGetır = new System.Windows.Forms.Button();
            this.txtIdUrunGetir = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "ÜRÜN GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIdUrunGetır
            // 
            this.btnIdUrunGetır.Location = new System.Drawing.Point(2, 37);
            this.btnIdUrunGetır.Name = "btnIdUrunGetır";
            this.btnIdUrunGetır.Size = new System.Drawing.Size(108, 28);
            this.btnIdUrunGetır.TabIndex = 2;
            this.btnIdUrunGetır.Text = "(ID) ÜRÜN GETİR";
            this.btnIdUrunGetır.UseVisualStyleBackColor = true;
            this.btnIdUrunGetır.Click += new System.EventHandler(this.btnIdUrunGetır_Click);
            // 
            // txtIdUrunGetir
            // 
            this.txtIdUrunGetir.Location = new System.Drawing.Point(116, 37);
            this.txtIdUrunGetir.Multiline = true;
            this.txtIdUrunGetir.Name = "txtIdUrunGetir";
            this.txtIdUrunGetir.Size = new System.Drawing.Size(78, 28);
            this.txtIdUrunGetir.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(229, 11);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stok";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(403, 11);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 20);
            this.txtStok.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(567, 12);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(690, 10);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 390);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtIdUrunGetir);
            this.Controls.Add(this.btnIdUrunGetır);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIdUrunGetır;
        private System.Windows.Forms.TextBox txtIdUrunGetir;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnEkle;
    }
}

