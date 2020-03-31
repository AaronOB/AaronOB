namespace Bartek_Oleszek_Zadanie1
{
    partial class zad5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.oblicz1 = new System.Windows.Forms.Button();
            this.Powrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Podaj wartosc k";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // oblicz1
            // 
            this.oblicz1.Location = new System.Drawing.Point(28, 76);
            this.oblicz1.Name = "oblicz1";
            this.oblicz1.Size = new System.Drawing.Size(75, 23);
            this.oblicz1.TabIndex = 20;
            this.oblicz1.Text = "Oblicz";
            this.oblicz1.UseVisualStyleBackColor = true;
            this.oblicz1.Click += new System.EventHandler(this.oblicz1_Click);
            // 
            // Powrot
            // 
            this.Powrot.Location = new System.Drawing.Point(177, 76);
            this.Powrot.Name = "Powrot";
            this.Powrot.Size = new System.Drawing.Size(75, 23);
            this.Powrot.TabIndex = 25;
            this.Powrot.Text = "Powrót";
            this.Powrot.UseVisualStyleBackColor = true;
            this.Powrot.Click += new System.EventHandler(this.Powrot_Click);
            // 
            // zad5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Powrot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.oblicz1);
            this.Name = "zad5";
            this.Text = "zad5";
            this.Load += new System.EventHandler(this.zad5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button oblicz1;
        private System.Windows.Forms.Button Powrot;
    }
}