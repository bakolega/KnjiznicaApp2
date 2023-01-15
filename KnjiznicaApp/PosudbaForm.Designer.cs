namespace KnjiznicaApp
{
    partial class PosudbaForm
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
            this.ClanComboBox = new System.Windows.Forms.ComboBox();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClanComboBox
            // 
            this.ClanComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ClanComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClanComboBox.DisplayMember = "ClanDisplay";
            this.ClanComboBox.FormattingEnabled = true;
            this.ClanComboBox.Location = new System.Drawing.Point(12, 12);
            this.ClanComboBox.Name = "ClanComboBox";
            this.ClanComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClanComboBox.TabIndex = 4;
            this.ClanComboBox.ValueMember = "ClanID";
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.Location = new System.Drawing.Point(220, 12);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(75, 23);
            this.OdustaniButton.TabIndex = 5;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(139, 12);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PosudbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 293);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.ClanComboBox);
            this.Name = "PosudbaForm";
            this.Text = "PosudbaForm";
            this.Load += new System.EventHandler(this.PosudbaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ClanComboBox;
        private System.Windows.Forms.Button OdustaniButton;
        private System.Windows.Forms.Button OKButton;
    }
}