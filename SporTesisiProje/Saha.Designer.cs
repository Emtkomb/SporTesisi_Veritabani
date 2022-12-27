
namespace SporTesisiProje
{
    partial class Saha
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
            this.btnsahalar = new System.Windows.Forms.Button();
            this.btnkirala = new System.Windows.Forms.Button();
            this.btnindrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsahalar
            // 
            this.btnsahalar.Location = new System.Drawing.Point(70, 104);
            this.btnsahalar.Name = "btnsahalar";
            this.btnsahalar.Size = new System.Drawing.Size(146, 51);
            this.btnsahalar.TabIndex = 0;
            this.btnsahalar.Text = "Sahalar";
            this.btnsahalar.UseVisualStyleBackColor = true;
            this.btnsahalar.Click += new System.EventHandler(this.btnsahalar_Click);
            // 
            // btnkirala
            // 
            this.btnkirala.Location = new System.Drawing.Point(261, 104);
            this.btnkirala.Name = "btnkirala";
            this.btnkirala.Size = new System.Drawing.Size(146, 51);
            this.btnkirala.TabIndex = 1;
            this.btnkirala.Text = "Kiralama";
            this.btnkirala.UseVisualStyleBackColor = true;
            this.btnkirala.Click += new System.EventHandler(this.btnkirala_Click);
            // 
            // btnindrm
            // 
            this.btnindrm.Location = new System.Drawing.Point(452, 104);
            this.btnindrm.Name = "btnindrm";
            this.btnindrm.Size = new System.Drawing.Size(146, 51);
            this.btnindrm.TabIndex = 2;
            this.btnindrm.Text = "İndirim";
            this.btnindrm.UseVisualStyleBackColor = true;
            this.btnindrm.Click += new System.EventHandler(this.btnindrm_Click);
            // 
            // Saha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 236);
            this.Controls.Add(this.btnindrm);
            this.Controls.Add(this.btnkirala);
            this.Controls.Add(this.btnsahalar);
            this.Name = "Saha";
            this.Text = "Saha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsahalar;
        private System.Windows.Forms.Button btnkirala;
        private System.Windows.Forms.Button btnindrm;
    }
}