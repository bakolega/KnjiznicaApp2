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
            this.SuspendLayout();
            // 
            // OpenKnjFormButton
            // 
            this.OpenKnjFormButton.Location = new System.Drawing.Point(194, 270);
            this.OpenKnjFormButton.Name = "OpenKnjFormButton";
            this.OpenKnjFormButton.Size = new System.Drawing.Size(127, 49);
            this.OpenKnjFormButton.TabIndex = 4;
            this.OpenKnjFormButton.Text = "Knjižničar";
            this.OpenKnjFormButton.UseVisualStyleBackColor = true;
            this.OpenKnjFormButton.Click += new System.EventHandler(this.OpenKnjFormButton_Click);
            // 
            // OpenClFormButton
            // 
            this.OpenClFormButton.Location = new System.Drawing.Point(386, 270);
            this.OpenClFormButton.Name = "OpenClFormButton";
            this.OpenClFormButton.Size = new System.Drawing.Size(127, 49);
            this.OpenClFormButton.TabIndex = 5;
            this.OpenClFormButton.Text = "Član";
            this.OpenClFormButton.UseVisualStyleBackColor = true;
            this.OpenClFormButton.Click += new System.EventHandler(this.OpenClFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenClFormButton);
            this.Controls.Add(this.OpenKnjFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenKnjFormButton;
        private System.Windows.Forms.Button OpenClFormButton;
    }
}

