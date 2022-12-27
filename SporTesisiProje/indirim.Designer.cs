
namespace SporTesisiProje
{
    partial class indirim
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
            this.txtioran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnindirimara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtikod = new System.Windows.Forms.TextBox();
            this.datagridindirm = new System.Windows.Forms.DataGridView();
            this.btngrntle = new System.Windows.Forms.Button();
            this.btngncl = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridindirm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtioran
            // 
            this.txtioran.Location = new System.Drawing.Point(736, 266);
            this.txtioran.Name = "txtioran";
            this.txtioran.Size = new System.Drawing.Size(100, 22);
            this.txtioran.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "İndirim Oranı :";
            // 
            // btnindirimara
            // 
            this.btnindirimara.Location = new System.Drawing.Point(529, 134);
            this.btnindirimara.Name = "btnindirimara";
            this.btnindirimara.Size = new System.Drawing.Size(112, 43);
            this.btnindirimara.TabIndex = 24;
            this.btnindirimara.Text = "Ara";
            this.btnindirimara.UseVisualStyleBackColor = true;
            this.btnindirimara.Click += new System.EventHandler(this.btnindirimara_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "İndirim Kodu :";
            // 
            // txtikod
            // 
            this.txtikod.Location = new System.Drawing.Point(736, 233);
            this.txtikod.Name = "txtikod";
            this.txtikod.Size = new System.Drawing.Size(100, 22);
            this.txtikod.TabIndex = 21;
            // 
            // datagridindirm
            // 
            this.datagridindirm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridindirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridindirm.Location = new System.Drawing.Point(30, 12);
            this.datagridindirm.Name = "datagridindirm";
            this.datagridindirm.RowHeadersWidth = 51;
            this.datagridindirm.RowTemplate.Height = 24;
            this.datagridindirm.Size = new System.Drawing.Size(493, 238);
            this.datagridindirm.TabIndex = 19;
            // 
            // btngrntle
            // 
            this.btngrntle.Location = new System.Drawing.Point(529, 85);
            this.btngrntle.Name = "btngrntle";
            this.btngrntle.Size = new System.Drawing.Size(112, 43);
            this.btngrntle.TabIndex = 18;
            this.btngrntle.Text = "Görüntüle";
            this.btngrntle.UseVisualStyleBackColor = true;
            this.btngrntle.Click += new System.EventHandler(this.btngrntle_Click);
            // 
            // btngncl
            // 
            this.btngncl.Location = new System.Drawing.Point(208, 266);
            this.btngncl.Name = "btngncl";
            this.btngncl.Size = new System.Drawing.Size(112, 43);
            this.btngncl.TabIndex = 17;
            this.btngncl.Text = "İndirim Güncelleme";
            this.btngncl.UseVisualStyleBackColor = true;
            this.btngncl.Click += new System.EventHandler(this.btngncl_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(160, 430);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(112, 43);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Visible = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(30, 430);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(112, 43);
            this.btnekle.TabIndex = 15;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Visible = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // indirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 512);
            this.Controls.Add(this.txtioran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnindirimara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtikod);
            this.Controls.Add(this.datagridindirm);
            this.Controls.Add(this.btngrntle);
            this.Controls.Add(this.btngncl);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Name = "indirim";
            this.Text = "indirim";
            ((System.ComponentModel.ISupportInitialize)(this.datagridindirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtioran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnindirimara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtikod;
        private System.Windows.Forms.DataGridView datagridindirm;
        private System.Windows.Forms.Button btngrntle;
        private System.Windows.Forms.Button btngncl;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
    }
}