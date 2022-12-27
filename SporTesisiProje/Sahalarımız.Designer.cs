
namespace SporTesisiProje
{
    partial class Sahalarımız
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
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngncl = new System.Windows.Forms.Button();
            this.btngrntle = new System.Windows.Forms.Button();
            this.datagridsaha = new System.Windows.Forms.DataGridView();
            this.txtsahaNo = new System.Windows.Forms.TextBox();
            this.txtsahaadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsahara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsaha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 395);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(112, 43);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Visible = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(145, 395);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(112, 43);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Visible = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngncl
            // 
            this.btngncl.Location = new System.Drawing.Point(276, 266);
            this.btngncl.Name = "btngncl";
            this.btngncl.Size = new System.Drawing.Size(112, 43);
            this.btngncl.TabIndex = 2;
            this.btngncl.Text = "Ücret Güncelle";
            this.btngncl.UseVisualStyleBackColor = true;
            this.btngncl.Visible = false;
            this.btngncl.Click += new System.EventHandler(this.btngncl_Click);
            // 
            // btngrntle
            // 
            this.btngrntle.Location = new System.Drawing.Point(576, 85);
            this.btngrntle.Name = "btngrntle";
            this.btngrntle.Size = new System.Drawing.Size(112, 43);
            this.btngrntle.TabIndex = 4;
            this.btngrntle.Text = "Görüntüle";
            this.btngrntle.UseVisualStyleBackColor = true;
            this.btngrntle.Visible = false;
            this.btngrntle.Click += new System.EventHandler(this.btngrntle_Click);
            // 
            // datagridsaha
            // 
            this.datagridsaha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridsaha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridsaha.Location = new System.Drawing.Point(77, 12);
            this.datagridsaha.Name = "datagridsaha";
            this.datagridsaha.RowHeadersWidth = 51;
            this.datagridsaha.RowTemplate.Height = 24;
            this.datagridsaha.Size = new System.Drawing.Size(493, 238);
            this.datagridsaha.TabIndex = 5;
            this.datagridsaha.Visible = false;
            // 
            // txtsahaNo
            // 
            this.txtsahaNo.Location = new System.Drawing.Point(783, 209);
            this.txtsahaNo.Name = "txtsahaNo";
            this.txtsahaNo.Size = new System.Drawing.Size(100, 22);
            this.txtsahaNo.TabIndex = 6;
            this.txtsahaNo.Visible = false;
            // 
            // txtsahaadi
            // 
            this.txtsahaadi.Location = new System.Drawing.Point(358, 416);
            this.txtsahaadi.Name = "txtsahaadi";
            this.txtsahaadi.Size = new System.Drawing.Size(100, 22);
            this.txtsahaadi.TabIndex = 7;
            this.txtsahaadi.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Saha No :";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Saha Adı :";
            this.label3.Visible = false;
            // 
            // btnsahara
            // 
            this.btnsahara.Location = new System.Drawing.Point(576, 134);
            this.btnsahara.Name = "btnsahara";
            this.btnsahara.Size = new System.Drawing.Size(112, 43);
            this.btnsahara.TabIndex = 12;
            this.btnsahara.Text = "Ara";
            this.btnsahara.UseVisualStyleBackColor = true;
            this.btnsahara.Visible = false;
            this.btnsahara.Click += new System.EventHandler(this.btnsahara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ücret :";
            this.label2.Visible = false;
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(783, 237);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(100, 22);
            this.txtucret.TabIndex = 14;
            this.txtucret.Visible = false;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(426, 256);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(89, 35);
            this.btngiris.TabIndex = 15;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(394, 204);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(147, 22);
            this.txtsifre.TabIndex = 16;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(394, 144);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(147, 22);
            this.txtkullaniciadi.TabIndex = 17;
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(296, 144);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(92, 17);
            this.lblkullaniciadi.TabIndex = 18;
            this.lblkullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(343, 204);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(45, 17);
            this.lblsifre.TabIndex = 19;
            this.lblsifre.Text = "Şifre :";
            // 
            // Sahalarımız
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsahara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsahaadi);
            this.Controls.Add(this.txtsahaNo);
            this.Controls.Add(this.datagridsaha);
            this.Controls.Add(this.btngrntle);
            this.Controls.Add(this.btngncl);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Name = "Sahalarımız";
            this.Text = "Sahalarımız";
            ((System.ComponentModel.ISupportInitialize)(this.datagridsaha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngncl;
        private System.Windows.Forms.Button btngrntle;
        private System.Windows.Forms.DataGridView datagridsaha;
        private System.Windows.Forms.TextBox txtsahaNo;
        private System.Windows.Forms.TextBox txtsahaadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsahara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label lblsifre;
    }
}