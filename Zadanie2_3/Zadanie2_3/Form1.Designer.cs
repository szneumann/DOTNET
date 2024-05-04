namespace Zadanie2_3
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
            this.lblCPU = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maxiram = new System.Windows.Forms.TextBox();
            this.thread_lbl = new System.Windows.Forms.TextBox();
            this.threadtotalbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCPU
            // 
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(101, 54);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.ReadOnly = true;
            this.lblCPU.Size = new System.Drawing.Size(313, 31);
            this.lblCPU.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(101, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(468, 31);
            this.textBox2.TabIndex = 3;
            // 
            // maxiram
            // 
            this.maxiram.Location = new System.Drawing.Point(101, 321);
            this.maxiram.Name = "maxiram";
            this.maxiram.Size = new System.Drawing.Size(474, 20);
            this.maxiram.TabIndex = 4;
            // 
            // thread_lbl
            // 
            this.thread_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread_lbl.Location = new System.Drawing.Point(101, 130);
            this.thread_lbl.Name = "thread_lbl";
            this.thread_lbl.Size = new System.Drawing.Size(606, 31);
            this.thread_lbl.TabIndex = 5;
            // 
            // threadtotalbox
            // 
            this.threadtotalbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadtotalbox.Location = new System.Drawing.Point(101, 194);
            this.threadtotalbox.Name = "threadtotalbox";
            this.threadtotalbox.Size = new System.Drawing.Size(606, 31);
            this.threadtotalbox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.threadtotalbox);
            this.Controls.Add(this.thread_lbl);
            this.Controls.Add(this.maxiram);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCPU);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblCPU;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox maxiram;
        private System.Windows.Forms.TextBox thread_lbl;
        private System.Windows.Forms.TextBox threadtotalbox;
    }
}

