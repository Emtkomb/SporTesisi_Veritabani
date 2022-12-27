
namespace SporTesisiProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsahalar = new System.Windows.Forms.Button();
            this.btniletisim = new System.Windows.Forms.Button();
            this.btnkirala = new System.Windows.Forms.Button();
            this.btnpersonel = new System.Windows.Forms.Button();
            this.datagridduyuru = new System.Windows.Forms.DataGridView();
            this.btnduyurugrntl = new System.Windows.Forms.Button();
            this.btnduyuru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridduyuru)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsahalar
            // 
            this.btnsahalar.Location = new System.Drawing.Point(67, 347);
            this.btnsahalar.Name = "btnsahalar";
            this.btnsahalar.Size = new System.Drawing.Size(130, 51);
            this.btnsahalar.TabIndex = 0;
            this.btnsahalar.Text = "Müşteri Bilgisi";
            this.btnsahalar.UseVisualStyleBackColor = true;
            this.btnsahalar.Click += new System.EventHandler(this.btnsahalar_Click_1);
            // 
            // btniletisim
            // 
            this.btniletisim.Location = new System.Drawing.Point(681, 347);
            this.btniletisim.Name = "btniletisim";
            this.btniletisim.Size = new System.Drawing.Size(130, 51);
            this.btniletisim.TabIndex = 3;
            this.btniletisim.Text = "İletişim";
            this.btniletisim.UseVisualStyleBackColor = true;
            this.btniletisim.Click += new System.EventHandler(this.btniletisim_Click);
            // 
            // btnkirala
            // 
            this.btnkirala.Location = new System.Drawing.Point(482, 347);
            this.btnkirala.Name = "btnkirala";
            this.btnkirala.Size = new System.Drawing.Size(130, 51);
            this.btnkirala.TabIndex = 2;
            this.btnkirala.Text = "Saha";
            this.btnkirala.UseVisualStyleBackColor = true;
            this.btnkirala.Click += new System.EventHandler(this.btnkirala_Click);
            // 
            // btnpersonel
            // 
            this.btnpersonel.Location = new System.Drawing.Point(286, 347);
            this.btnpersonel.Name = "btnpersonel";
            this.btnpersonel.Size = new System.Drawing.Size(130, 51);
            this.btnpersonel.TabIndex = 1;
            this.btnpersonel.Text = "Personelimiz";
            this.btnpersonel.UseVisualStyleBackColor = true;
            this.btnpersonel.Click += new System.EventHandler(this.btnpersonel_Click);
            // 
            // datagridduyuru
            // 
            this.datagridduyuru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridduyuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridduyuru.Location = new System.Drawing.Point(23, 12);
            this.datagridduyuru.Name = "datagridduyuru";
            this.datagridduyuru.RowHeadersWidth = 51;
            this.datagridduyuru.RowTemplate.Height = 24;
            this.datagridduyuru.Size = new System.Drawing.Size(890, 230);
            this.datagridduyuru.TabIndex = 4;
            // 
            // btnduyurugrntl
            // 
            this.btnduyurugrntl.Location = new System.Drawing.Point(557, 248);
            this.btnduyurugrntl.Name = "btnduyurugrntl";
            this.btnduyurugrntl.Size = new System.Drawing.Size(159, 36);
            this.btnduyurugrntl.TabIndex = 5;
            this.btnduyurugrntl.Text = "Duyuru Görüntüle";
            this.btnduyurugrntl.UseVisualStyleBackColor = true;
            this.btnduyurugrntl.Click += new System.EventHandler(this.btnduyurugrntl_Click);
            // 
            // btnduyuru
            // 
            this.btnduyuru.Location = new System.Drawing.Point(176, 248);
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.Size = new System.Drawing.Size(159, 36);
            this.btnduyuru.TabIndex = 6;
            this.btnduyuru.Text = "Duyuru";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.btnduyuru);
            this.Controls.Add(this.btnduyurugrntl);
            this.Controls.Add(this.datagridduyuru);
            this.Controls.Add(this.btniletisim);
            this.Controls.Add(this.btnkirala);
            this.Controls.Add(this.btnpersonel);
            this.Controls.Add(this.btnsahalar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridduyuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsahalar;
        private System.Windows.Forms.Button btniletisim;
        private System.Windows.Forms.Button btnkirala;
        private System.Windows.Forms.Button btnpersonel;
        private System.Windows.Forms.DataGridView datagridduyuru;
        private System.Windows.Forms.Button btnduyurugrntl;
        private System.Windows.Forms.Button btnduyuru;
    }
}

