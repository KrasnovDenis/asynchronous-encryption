namespace AsynchronousEncryption
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
            this.input = new System.Windows.Forms.RichTextBox();
            this.public_key = new System.Windows.Forms.RichTextBox();
            this.private_key = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.save_key = new System.Windows.Forms.Button();
            this.open_key = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(43, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(316, 113);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // public_key
            // 
            this.public_key.Location = new System.Drawing.Point(65, 166);
            this.public_key.Name = "public_key";
            this.public_key.Size = new System.Drawing.Size(277, 58);
            this.public_key.TabIndex = 1;
            this.public_key.Text = "";
            // 
            // private_key
            // 
            this.private_key.Location = new System.Drawing.Point(65, 230);
            this.private_key.Name = "private_key";
            this.private_key.Size = new System.Drawing.Size(277, 58);
            this.private_key.TabIndex = 2;
            this.private_key.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(43, 359);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(316, 113);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // save_key
            // 
            this.save_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_key.Location = new System.Drawing.Point(65, 304);
            this.save_key.Name = "save_key";
            this.save_key.Size = new System.Drawing.Size(120, 32);
            this.save_key.TabIndex = 4;
            this.save_key.Text = "Save key";
            this.save_key.UseVisualStyleBackColor = true;
            this.save_key.Click += new System.EventHandler(this.save_key_Click);
            // 
            // open_key
            // 
            this.open_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_key.Location = new System.Drawing.Point(237, 304);
            this.open_key.Name = "open_key";
            this.open_key.Size = new System.Drawing.Size(105, 32);
            this.open_key.TabIndex = 5;
            this.open_key.Text = "Open Key";
            this.open_key.UseVisualStyleBackColor = true;
            this.open_key.Click += new System.EventHandler(this.open_key_Click);
            // 
            // encrypt
            // 
            this.encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt.Location = new System.Drawing.Point(65, 131);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(120, 29);
            this.encrypt.TabIndex = 6;
            this.encrypt.Text = "encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt.Location = new System.Drawing.Point(237, 131);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(105, 29);
            this.decrypt.TabIndex = 7;
            this.decrypt.Text = "decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 484);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.open_key);
            this.Controls.Add(this.save_key);
            this.Controls.Add(this.output);
            this.Controls.Add(this.private_key);
            this.Controls.Add(this.public_key);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox public_key;
        private System.Windows.Forms.RichTextBox private_key;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button save_key;
        private System.Windows.Forms.Button open_key;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

