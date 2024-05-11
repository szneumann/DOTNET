namespace Zadanie3_1
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
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.GenerateKeysButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.ivTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.ivLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.plainASCIItextBox = new System.Windows.Forms.TextBox();
            this.plainHEXtextBox = new System.Windows.Forms.TextBox();
            this.plaintextLabel = new System.Windows.Forms.Label();
            this.plainASCIIlabel = new System.Windows.Forms.Label();
            this.plainHEXLabel = new System.Windows.Forms.Label();
            this.ciphertextLabel = new System.Windows.Forms.Label();
            this.cipherASCIILabel = new System.Windows.Forms.Label();
            this.cipherHEXLabel = new System.Windows.Forms.Label();
            this.cipherASCIItextBox = new System.Windows.Forms.TextBox();
            this.cipherHEXtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeEncryptionlabel = new System.Windows.Forms.Label();
            this.timeDecryptionlabel = new System.Windows.Forms.Label();
            this.timeEncryptionTextBox = new System.Windows.Forms.TextBox();
            this.timeDecryptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Location = new System.Drawing.Point(91, 66);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(109, 21);
            this.algorithmComboBox.TabIndex = 0;
            // 
            // GenerateKeysButton
            // 
            this.GenerateKeysButton.Location = new System.Drawing.Point(77, 104);
            this.GenerateKeysButton.Name = "GenerateKeysButton";
            this.GenerateKeysButton.Size = new System.Drawing.Size(158, 23);
            this.GenerateKeysButton.TabIndex = 1;
            this.GenerateKeysButton.Text = "Generate Key and IV";
            this.GenerateKeysButton.UseVisualStyleBackColor = true;
            this.GenerateKeysButton.Click += new System.EventHandler(this.GenerateKeysButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(394, 66);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(127, 20);
            this.keyTextBox.TabIndex = 2;
            // 
            // ivTextBox
            // 
            this.ivTextBox.Location = new System.Drawing.Point(394, 107);
            this.ivTextBox.Name = "ivTextBox";
            this.ivTextBox.Size = new System.Drawing.Size(126, 20);
            this.ivTextBox.TabIndex = 3;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(391, 49);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Key";
            // 
            // ivLabel
            // 
            this.ivLabel.AutoSize = true;
            this.ivLabel.Location = new System.Drawing.Point(391, 91);
            this.ivLabel.Name = "ivLabel";
            this.ivLabel.Size = new System.Drawing.Size(17, 13);
            this.ivLabel.TabIndex = 5;
            this.ivLabel.Text = "IV";
            this.ivLabel.Click += new System.EventHandler(this.ivLabel_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(72, 178);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(178, 33);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(58, 308);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(177, 37);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // plainASCIItextBox
            // 
            this.plainASCIItextBox.Location = new System.Drawing.Point(394, 185);
            this.plainASCIItextBox.Name = "plainASCIItextBox";
            this.plainASCIItextBox.Size = new System.Drawing.Size(166, 20);
            this.plainASCIItextBox.TabIndex = 8;
            // 
            // plainHEXtextBox
            // 
            this.plainHEXtextBox.Location = new System.Drawing.Point(394, 220);
            this.plainHEXtextBox.Name = "plainHEXtextBox";
            this.plainHEXtextBox.Size = new System.Drawing.Size(179, 20);
            this.plainHEXtextBox.TabIndex = 9;
            // 
            // plaintextLabel
            // 
            this.plaintextLabel.AutoSize = true;
            this.plaintextLabel.Location = new System.Drawing.Point(391, 169);
            this.plaintextLabel.Name = "plaintextLabel";
            this.plaintextLabel.Size = new System.Drawing.Size(54, 13);
            this.plaintextLabel.TabIndex = 10;
            this.plaintextLabel.Text = "Plain Text";
            // 
            // plainASCIIlabel
            // 
            this.plainASCIIlabel.AutoSize = true;
            this.plainASCIIlabel.Location = new System.Drawing.Point(354, 188);
            this.plainASCIIlabel.Name = "plainASCIIlabel";
            this.plainASCIIlabel.Size = new System.Drawing.Size(34, 13);
            this.plainASCIIlabel.TabIndex = 11;
            this.plainASCIIlabel.Text = "ASCII";
            // 
            // plainHEXLabel
            // 
            this.plainHEXLabel.AutoSize = true;
            this.plainHEXLabel.Location = new System.Drawing.Point(354, 223);
            this.plainHEXLabel.Name = "plainHEXLabel";
            this.plainHEXLabel.Size = new System.Drawing.Size(29, 13);
            this.plainHEXLabel.TabIndex = 12;
            this.plainHEXLabel.Text = "HEX";
            // 
            // ciphertextLabel
            // 
            this.ciphertextLabel.AutoSize = true;
            this.ciphertextLabel.Location = new System.Drawing.Point(395, 281);
            this.ciphertextLabel.Name = "ciphertextLabel";
            this.ciphertextLabel.Size = new System.Drawing.Size(61, 13);
            this.ciphertextLabel.TabIndex = 13;
            this.ciphertextLabel.Text = "Cipher Text";
            // 
            // cipherASCIILabel
            // 
            this.cipherASCIILabel.AutoSize = true;
            this.cipherASCIILabel.Location = new System.Drawing.Point(332, 320);
            this.cipherASCIILabel.Name = "cipherASCIILabel";
            this.cipherASCIILabel.Size = new System.Drawing.Size(34, 13);
            this.cipherASCIILabel.TabIndex = 14;
            this.cipherASCIILabel.Text = "ASCII";
            // 
            // cipherHEXLabel
            // 
            this.cipherHEXLabel.AutoSize = true;
            this.cipherHEXLabel.Location = new System.Drawing.Point(332, 351);
            this.cipherHEXLabel.Name = "cipherHEXLabel";
            this.cipherHEXLabel.Size = new System.Drawing.Size(29, 13);
            this.cipherHEXLabel.TabIndex = 15;
            this.cipherHEXLabel.Text = "HEX";
            // 
            // cipherASCIItextBox
            // 
            this.cipherASCIItextBox.Location = new System.Drawing.Point(376, 313);
            this.cipherASCIItextBox.Name = "cipherASCIItextBox";
            this.cipherASCIItextBox.Size = new System.Drawing.Size(144, 20);
            this.cipherASCIItextBox.TabIndex = 16;
            // 
            // cipherHEXtextBox
            // 
            this.cipherHEXtextBox.Location = new System.Drawing.Point(377, 346);
            this.cipherHEXtextBox.Name = "cipherHEXtextBox";
            this.cipherHEXtextBox.Size = new System.Drawing.Size(195, 20);
            this.cipherHEXtextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Wybierz rodzaj szyfrowania";
            // 
            // timeEncryptionlabel
            // 
            this.timeEncryptionlabel.AutoSize = true;
            this.timeEncryptionlabel.Location = new System.Drawing.Point(222, 410);
            this.timeEncryptionlabel.Name = "timeEncryptionlabel";
            this.timeEncryptionlabel.Size = new System.Drawing.Size(145, 13);
            this.timeEncryptionlabel.TabIndex = 21;
            this.timeEncryptionlabel.Text = "Time/Message at encryption:";
            // 
            // timeDecryptionlabel
            // 
            this.timeDecryptionlabel.AutoSize = true;
            this.timeDecryptionlabel.Location = new System.Drawing.Point(223, 466);
            this.timeDecryptionlabel.Name = "timeDecryptionlabel";
            this.timeDecryptionlabel.Size = new System.Drawing.Size(148, 13);
            this.timeDecryptionlabel.TabIndex = 22;
            this.timeDecryptionlabel.Text = "Time/Message at decryption: ";
            // 
            // timeEncryptionTextBox
            // 
            this.timeEncryptionTextBox.Location = new System.Drawing.Point(377, 407);
            this.timeEncryptionTextBox.Name = "timeEncryptionTextBox";
            this.timeEncryptionTextBox.Size = new System.Drawing.Size(127, 20);
            this.timeEncryptionTextBox.TabIndex = 23;
            // 
            // timeDecryptionTextBox
            // 
            this.timeDecryptionTextBox.Location = new System.Drawing.Point(377, 466);
            this.timeDecryptionTextBox.Name = "timeDecryptionTextBox";
            this.timeDecryptionTextBox.Size = new System.Drawing.Size(136, 20);
            this.timeDecryptionTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.timeDecryptionTextBox);
            this.Controls.Add(this.timeEncryptionTextBox);
            this.Controls.Add(this.timeDecryptionlabel);
            this.Controls.Add(this.timeEncryptionlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cipherHEXtextBox);
            this.Controls.Add(this.cipherASCIItextBox);
            this.Controls.Add(this.cipherHEXLabel);
            this.Controls.Add(this.cipherASCIILabel);
            this.Controls.Add(this.ciphertextLabel);
            this.Controls.Add(this.plainHEXLabel);
            this.Controls.Add(this.plainASCIIlabel);
            this.Controls.Add(this.plaintextLabel);
            this.Controls.Add(this.plainHEXtextBox);
            this.Controls.Add(this.plainASCIItextBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ivLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.ivTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.GenerateKeysButton);
            this.Controls.Add(this.algorithmComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.Button GenerateKeysButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox ivTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label ivLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox plainASCIItextBox;
        private System.Windows.Forms.TextBox plainHEXtextBox;
        private System.Windows.Forms.Label plaintextLabel;
        private System.Windows.Forms.Label plainASCIIlabel;
        private System.Windows.Forms.Label plainHEXLabel;
        private System.Windows.Forms.Label ciphertextLabel;
        private System.Windows.Forms.Label cipherASCIILabel;
        private System.Windows.Forms.Label cipherHEXLabel;
        private System.Windows.Forms.TextBox cipherASCIItextBox;
        private System.Windows.Forms.TextBox cipherHEXtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeEncryptionlabel;
        private System.Windows.Forms.Label timeDecryptionlabel;
        private System.Windows.Forms.TextBox timeEncryptionTextBox;
        private System.Windows.Forms.TextBox timeDecryptionTextBox;
    }
}

