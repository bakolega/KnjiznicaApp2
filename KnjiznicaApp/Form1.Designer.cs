namespace KnjiznicaApp
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
            this.OpenKnjFormButton = new System.Windows.Forms.Button();
            this.OpenClFormButton = new System.Windows.Forms.Button();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenKnjFormButton
            // 
            this.OpenKnjFormButton.Location = new System.Drawing.Point(92, 254);
            this.OpenKnjFormButton.Name = "OpenKnjFormButton";
            this.OpenKnjFormButton.Size = new System.Drawing.Size(127, 49);
            this.OpenKnjFormButton.TabIndex = 4;
            this.OpenKnjFormButton.Text = "Knjižničar";
            this.OpenKnjFormButton.UseVisualStyleBackColor = true;
            this.OpenKnjFormButton.Click += new System.EventHandler(this.OpenKnjFormButton_Click);
            // 
            // OpenClFormButton
            // 
            this.OpenClFormButton.Location = new System.Drawing.Point(225, 254);
            this.OpenClFormButton.Name = "OpenClFormButton";
            this.OpenClFormButton.Size = new System.Drawing.Size(127, 49);
            this.OpenClFormButton.TabIndex = 5;
            this.OpenClFormButton.Text = "Član";
            this.OpenClFormButton.UseVisualStyleBackColor = true;
            this.OpenClFormButton.Click += new System.EventHandler(this.OpenClFormButton_Click);
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Location = new System.Drawing.Point(161, 103);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(127, 20);
            this.UsernameTxtBox.TabIndex = 8;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(161, 166);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(127, 20);
            this.PasswordTxtBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Korisnicko Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lozinka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.OpenClFormButton);
            this.Controls.Add(this.OpenKnjFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenKnjFormButton;
        private System.Windows.Forms.Button OpenClFormButton;
        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

