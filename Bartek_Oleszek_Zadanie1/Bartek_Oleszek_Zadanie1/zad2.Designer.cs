namespace Bartek_Oleszek_Zadanie1
{
    partial class zad2
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
            this.oblicz1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Powrot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oblicz1
            // 
            this.oblicz1.Location = new System.Drawing.Point(27, 72);
            this.oblicz1.Name = "oblicz1";
            this.oblicz1.Size = new System.Drawing.Size(75, 23);
            this.oblicz1.TabIndex = 10;
            this.oblicz1.Text = "Oblicz";
            this.oblicz1.UseVisualStyleBackColor = true;
            this.oblicz1.Click += new System.EventHandler(this.oblicz1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Podaj wartosc z";
            // 
            // Powrot
            // 
            this.Powrot.Location = new System.Drawing.Point(176, 72);
            this.Powrot.Name = "Powrot";
            this.Powrot.Size = new System.Drawing.Size(75, 23);
            this.Powrot.TabIndex = 11;
            this.Powrot.Text = "Powrót";
            this.Powrot.UseVisualStyleBackColor = true;
            this.Powrot.Click += new System.EventHandler(this.Powrót_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // zad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Powrot);
            this.Controls.Add(this.oblicz1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Name = "zad2";
            this.Text = "zad2";
            this.Load += new System.EventHandler(this.zad2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button oblicz1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Powrot;
        private System.Windows.Forms.TextBox textBox1;
    }
}