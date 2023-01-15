namespace KnjiznicaApp
{
    partial class PopisClanovaForm
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
            this.PopisClanovaDGW = new System.Windows.Forms.DataGridView();
            this.ClanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.DodajPasswordTxb = new System.Windows.Forms.TextBox();
            this.DodajImeTxb = new System.Windows.Forms.TextBox();
            this.DodajPrezimeTxb = new System.Windows.Forms.TextBox();
            this.DodajUsernameTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PopisClanovaDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisClanovaDGW
            // 
            this.PopisClanovaDGW.AllowUserToAddRows = false;
            this.PopisClanovaDGW.AllowUserToDeleteRows = false;
            this.PopisClanovaDGW.AllowUserToResizeRows = false;
            this.PopisClanovaDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisClanovaDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanID,
            this.Username,
            this.Ime,
            this.Prezime});
            this.PopisClanovaDGW.Location = new System.Drawing.Point(12, 12);
            this.PopisClanovaDGW.MultiSelect = false;
            this.PopisClanovaDGW.Name = "PopisClanovaDGW";
            this.PopisClanovaDGW.ReadOnly = true;
            this.PopisClanovaDGW.RowHeadersVisible = false;
            this.PopisClanovaDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PopisClanovaDGW.Size = new System.Drawing.Size(405, 620);
            this.PopisClanovaDGW.TabIndex = 7;
            // 
            // ClanID
            // 
            this.ClanID.DataPropertyName = "ClanID";
            this.ClanID.HeaderText = "ClanID";
            this.ClanID.Name = "ClanID";
            this.ClanID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj Clana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajPasswordTxb
            // 
            this.DodajPasswordTxb.Location = new System.Drawing.Point(536, 41);
            this.DodajPasswordTxb.Name = "DodajPasswordTxb";
            this.DodajPasswordTxb.Size = new System.Drawing.Size(100, 20);
            this.DodajPasswordTxb.TabIndex = 9;
            // 
            // DodajImeTxb
            // 
            this.DodajImeTxb.Location = new System.Drawing.Point(536, 67);
            this.DodajImeTxb.Name = "DodajImeTxb";
            this.DodajImeTxb.Size = new System.Drawing.Size(100, 20);
            this.DodajImeTxb.TabIndex = 10;
            // 
            // DodajPrezimeTxb
            // 
            this.DodajPrezimeTxb.Location = new System.Drawing.Point(536, 93);
            this.DodajPrezimeTxb.Name = "DodajPrezimeTxb";
            this.DodajPrezimeTxb.Size = new System.Drawing.Size(100, 20);
            this.DodajPrezimeTxb.TabIndex = 12;
            // 
            // DodajUsernameTxb
            // 
            this.DodajUsernameTxb.Location = new System.Drawing.Point(536, 15);
            this.DodajUsernameTxb.Name = "DodajUsernameTxb";
            this.DodajUsernameTxb.Size = new System.Drawing.Size(100, 20);
            this.DodajUsernameTxb.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Prezime";
            // 
            // PopisClanovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 644);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajUsernameTxb);
            this.Controls.Add(this.DodajPrezimeTxb);
            this.Controls.Add(this.DodajImeTxb);
            this.Controls.Add(this.DodajPasswordTxb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PopisClanovaDGW);
            this.Name = "PopisClanovaForm";
            this.Text = "PopisClanovaForm";
            this.Load += new System.EventHandler(this.PopisClanovaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopisClanovaDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PopisClanovaDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DodajPasswordTxb;
        private System.Windows.Forms.TextBox DodajImeTxb;
        private System.Windows.Forms.TextBox DodajPrezimeTxb;
        private System.Windows.Forms.TextBox DodajUsernameTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}