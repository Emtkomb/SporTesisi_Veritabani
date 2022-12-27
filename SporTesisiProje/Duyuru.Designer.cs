
namespace SporTesisiProje
{
    partial class Duyuru
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
            this.txtduyuruno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnduyurusil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrichduyuru = new System.Windows.Forms.RichTextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtindirimkd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtduyuruno
            // 
            this.txtduyuruno.Location = new System.Drawing.Point(219, 47);
            this.txtduyuruno.Name = "txtduyuruno";
            this.txtduyuruno.Size = new System.Drawing.Size(84, 22);
            this.txtduyuruno.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Duyuru No :";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(504, 358);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(140, 63);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnduyurusil
            // 
            this.btnduyurusil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduyurusil.Location = new System.Drawing.Point(325, 358);
            this.btnduyurusil.Name = "btnduyurusil";
            this.btnduyurusil.Size = new System.Drawing.Size(140, 63);
            this.btnduyurusil.TabIndex = 13;
            this.btnduyurusil.Text = "Sil";
            this.btnduyurusil.UseVisualStyleBackColor = true;
            this.btnduyurusil.Click += new System.EventHandler(this.btnduyurusil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Duyuru :";
            // 
            // txtrichduyuru
            // 
            this.txtrichduyuru.Location = new System.Drawing.Point(219, 97);
            this.txtrichduyuru.Name = "txtrichduyuru";
            this.txtrichduyuru.Size = new System.Drawing.Size(385, 191);
            this.txtrichduyuru.TabIndex = 11;
            this.txtrichduyuru.Text = "";
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(152, 358);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(140, 63);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "İndirim Kodu : ";
            // 
            // txtindirimkd
            // 
            this.txtindirimkd.Location = new System.Drawing.Point(219, 319);
            this.txtindirimkd.Name = "txtindirimkd";
            this.txtindirimkd.Size = new System.Drawing.Size(100, 22);
            this.txtindirimkd.TabIndex = 18;
            // 
            // Duyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtindirimkd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtduyuruno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnduyurusil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrichduyuru);
            this.Controls.Add(this.btnekle);
            this.Name = "Duyuru";
            this.Text = "Duyuru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtduyuruno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnduyurusil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtrichduyuru;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtindirimkd;
    }
}