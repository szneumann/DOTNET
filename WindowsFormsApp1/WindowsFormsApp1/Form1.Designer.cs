namespace WindowsFormsApp1
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
            this.button_podziel = new System.Windows.Forms.Button();
            this.textBox_dzielna = new System.Windows.Forms.TextBox();
            this.label_dzielna = new System.Windows.Forms.Label();
            this.label_dzielnik = new System.Windows.Forms.Label();
            this.textBox_dzielnik = new System.Windows.Forms.TextBox();
            this.textBox_wynik = new System.Windows.Forms.TextBox();
            this.label_wynik_top = new System.Windows.Forms.Label();
            this.label_wynik_right = new System.Windows.Forms.Label();
            this.label_wynik_left = new System.Windows.Forms.Label();
            this.label_wynik_bottom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_podziel
            // 
            this.button_podziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_podziel.Location = new System.Drawing.Point(320, 118);
            this.button_podziel.Name = "button_podziel";
            this.button_podziel.Size = new System.Drawing.Size(116, 47);
            this.button_podziel.TabIndex = 0;
            this.button_podziel.Text = "PODZIEL";
            this.button_podziel.UseVisualStyleBackColor = true;
            this.button_podziel.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_dzielna
            // 
            this.textBox_dzielna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dzielna.Location = new System.Drawing.Point(204, 54);
            this.textBox_dzielna.Multiline = true;
            this.textBox_dzielna.Name = "textBox_dzielna";
            this.textBox_dzielna.Size = new System.Drawing.Size(87, 74);
            this.textBox_dzielna.TabIndex = 1;
            this.textBox_dzielna.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_dzielna
            // 
            this.label_dzielna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dzielna.Location = new System.Drawing.Point(114, 81);
            this.label_dzielna.Name = "label_dzielna";
            this.label_dzielna.Size = new System.Drawing.Size(84, 31);
            this.label_dzielna.TabIndex = 3;
            this.label_dzielna.Text = "dzielna";
            this.label_dzielna.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_dzielnik
            // 
            this.label_dzielnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dzielnik.Location = new System.Drawing.Point(111, 179);
            this.label_dzielnik.Name = "label_dzielnik";
            this.label_dzielnik.Size = new System.Drawing.Size(87, 31);
            this.label_dzielnik.TabIndex = 5;
            this.label_dzielnik.Text = "dzielnik";
            // 
            // textBox_dzielnik
            // 
            this.textBox_dzielnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dzielnik.Location = new System.Drawing.Point(204, 152);
            this.textBox_dzielnik.Multiline = true;
            this.textBox_dzielnik.Name = "textBox_dzielnik";
            this.textBox_dzielnik.Size = new System.Drawing.Size(87, 74);
            this.textBox_dzielnik.TabIndex = 4;
            // 
            // textBox_wynik
            // 
            this.textBox_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_wynik.Location = new System.Drawing.Point(503, 107);
            this.textBox_wynik.Multiline = true;
            this.textBox_wynik.Name = "textBox_wynik";
            this.textBox_wynik.Size = new System.Drawing.Size(87, 74);
            this.textBox_wynik.TabIndex = 6;
            // 
            // label_wynik_top
            // 
            this.label_wynik_top.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wynik_top.Location = new System.Drawing.Point(503, 73);
            this.label_wynik_top.Name = "label_wynik_top";
            this.label_wynik_top.Size = new System.Drawing.Size(87, 31);
            this.label_wynik_top.TabIndex = 7;
            this.label_wynik_top.Text = "wynik";
            this.label_wynik_top.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_wynik_top.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_wynik_right
            // 
            this.label_wynik_right.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wynik_right.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_wynik_right.Location = new System.Drawing.Point(596, 85);
            this.label_wynik_right.Name = "label_wynik_right";
            this.label_wynik_right.Size = new System.Drawing.Size(11, 119);
            this.label_wynik_right.TabIndex = 8;
            this.label_wynik_right.Text = "wynik";
            this.label_wynik_right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wynik_right.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_wynik_left
            // 
            this.label_wynik_left.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wynik_left.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_wynik_left.Location = new System.Drawing.Point(486, 85);
            this.label_wynik_left.Name = "label_wynik_left";
            this.label_wynik_left.Size = new System.Drawing.Size(11, 119);
            this.label_wynik_left.TabIndex = 9;
            this.label_wynik_left.Text = "wynik";
            this.label_wynik_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wynik_bottom
            // 
            this.label_wynik_bottom.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wynik_bottom.Location = new System.Drawing.Point(503, 184);
            this.label_wynik_bottom.Name = "label_wynik_bottom";
            this.label_wynik_bottom.Size = new System.Drawing.Size(87, 31);
            this.label_wynik_bottom.TabIndex = 10;
            this.label_wynik_bottom.Text = "wynik";
            this.label_wynik_bottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_wynik_bottom);
            this.Controls.Add(this.label_wynik_left);
            this.Controls.Add(this.label_wynik_right);
            this.Controls.Add(this.label_wynik_top);
            this.Controls.Add(this.textBox_wynik);
            this.Controls.Add(this.label_dzielnik);
            this.Controls.Add(this.textBox_dzielnik);
            this.Controls.Add(this.label_dzielna);
            this.Controls.Add(this.textBox_dzielna);
            this.Controls.Add(this.button_podziel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_podziel;
        private System.Windows.Forms.TextBox textBox_dzielna;
        private System.Windows.Forms.Label label_dzielna;
        private System.Windows.Forms.Label label_dzielnik;
        private System.Windows.Forms.TextBox textBox_dzielnik;
        private System.Windows.Forms.TextBox textBox_wynik;
        private System.Windows.Forms.Label label_wynik_top;
        private System.Windows.Forms.Label label_wynik_right;
        private System.Windows.Forms.Label label_wynik_left;
        private System.Windows.Forms.Label label_wynik_bottom;
    }
}

