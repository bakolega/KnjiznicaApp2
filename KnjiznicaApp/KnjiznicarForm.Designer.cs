namespace KnjiznicaApp
{
    partial class KnjiznicarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UrediKatalogButton = new System.Windows.Forms.Button();
            this.KnjiznicarDataGridView = new System.Windows.Forms.DataGridView();
            this.KnjigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prevoditelji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoriUlogeListView = new System.Windows.Forms.ListView();
            this.AutorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzdavacTxtBox = new System.Windows.Forms.TextBox();
            this.MjestoIzdavanjaTxtBox = new System.Windows.Forms.TextBox();
            this.JezikTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDUrediTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UrediNazivTxtBox = new System.Windows.Forms.TextBox();
            this.kopijeDG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RezerviraniClan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosudbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KnjiznicarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopijeDG)).BeginInit();
            this.SuspendLayout();
            // 
            // UrediKatalogButton
            // 
            this.UrediKatalogButton.Location = new System.Drawing.Point(726, 573);
            this.UrediKatalogButton.Name = "UrediKatalogButton";
            this.UrediKatalogButton.Size = new System.Drawing.Size(181, 61);
            this.UrediKatalogButton.TabIndex = 1;
            this.UrediKatalogButton.Text = "Uredi Katalog";
            this.UrediKatalogButton.UseVisualStyleBackColor = true;
            this.UrediKatalogButton.Click += new System.EventHandler(this.UrediKatalogButton_Click);
            // 
            // KnjiznicarDataGridView
            // 
            this.KnjiznicarDataGridView.AllowUserToAddRows = false;
            this.KnjiznicarDataGridView.AllowUserToDeleteRows = false;
            this.KnjiznicarDataGridView.AllowUserToResizeRows = false;
            this.KnjiznicarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KnjiznicarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KnjigaID,
            this.Naziv,
            this.Autori,
            this.Prevoditelji,
            this.Godina,
            this.MjestoIzdavanja,
            this.Izdavac});
            this.KnjiznicarDataGridView.Location = new System.Drawing.Point(12, 40);
            this.KnjiznicarDataGridView.MultiSelect = false;
            this.KnjiznicarDataGridView.Name = "KnjiznicarDataGridView";
            this.KnjiznicarDataGridView.ReadOnly = true;
            this.KnjiznicarDataGridView.RowHeadersVisible = false;
            this.KnjiznicarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KnjiznicarDataGridView.Size = new System.Drawing.Size(704, 594);
            this.KnjiznicarDataGridView.TabIndex = 6;
            this.KnjiznicarDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KnjiznicarDataGridView_CellDoubleClick);
            // 
            // KnjigaID
            // 
            this.KnjigaID.DataPropertyName = "KnjigaID";
            this.KnjigaID.HeaderText = "KnjigaID";
            this.KnjigaID.Name = "KnjigaID";
            this.KnjigaID.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Autori
            // 
            this.Autori.DataPropertyName = "Autori";
            this.Autori.HeaderText = "Autori";
            this.Autori.Name = "Autori";
            this.Autori.ReadOnly = true;
            // 
            // Prevoditelji
            // 
            this.Prevoditelji.DataPropertyName = "Prevoditelji";
            this.Prevoditelji.HeaderText = "Prevoditelji";
            this.Prevoditelji.Name = "Prevoditelji";
            this.Prevoditelji.ReadOnly = true;
            // 
            // Godina
            // 
            this.Godina.DataPropertyName = "Godina";
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            // 
            // MjestoIzdavanja
            // 
            this.MjestoIzdavanja.DataPropertyName = "MjestoIzdavanja";
            this.MjestoIzdavanja.HeaderText = "Mjesto Izdavanja";
            this.MjestoIzdavanja.Name = "MjestoIzdavanja";
            this.MjestoIzdavanja.ReadOnly = true;
            // 
            // Izdavac
            // 
            this.Izdavac.DataPropertyName = "Izdavac";
            this.Izdavac.HeaderText = "Izdavač";
            this.Izdavac.Name = "Izdavac";
            this.Izdavac.ReadOnly = true;
            // 
            // AutoriUlogeListView
            // 
            this.AutoriUlogeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AutorColumn});
            this.AutoriUlogeListView.HideSelection = false;
            this.AutoriUlogeListView.Location = new System.Drawing.Point(726, 256);
            this.AutoriUlogeListView.Name = "AutoriUlogeListView";
            this.AutoriUlogeListView.Size = new System.Drawing.Size(235, 311);
            this.AutoriUlogeListView.TabIndex = 39;
            this.AutoriUlogeListView.UseCompatibleStateImageBehavior = false;
            this.AutoriUlogeListView.View = System.Windows.Forms.View.Details;
            // 
            // AutorColumn
            // 
            this.AutorColumn.Text = "Autori";
            this.AutorColumn.Width = 231;
            // 
            // IzdavacTxtBox
            // 
            this.IzdavacTxtBox.Location = new System.Drawing.Point(777, 211);
            this.IzdavacTxtBox.Name = "IzdavacTxtBox";
            this.IzdavacTxtBox.ReadOnly = true;
            this.IzdavacTxtBox.Size = new System.Drawing.Size(100, 20);
            this.IzdavacTxtBox.TabIndex = 38;
            // 
            // MjestoIzdavanjaTxtBox
            // 
            this.MjestoIzdavanjaTxtBox.Location = new System.Drawing.Point(821, 174);
            this.MjestoIzdavanjaTxtBox.Name = "MjestoIzdavanjaTxtBox";
            this.MjestoIzdavanjaTxtBox.ReadOnly = true;
            this.MjestoIzdavanjaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MjestoIzdavanjaTxtBox.TabIndex = 37;
            // 
            // JezikTextBox
            // 
            this.JezikTextBox.Location = new System.Drawing.Point(767, 138);
            this.JezikTextBox.Name = "JezikTextBox";
            this.JezikTextBox.ReadOnly = true;
            this.JezikTextBox.Size = new System.Drawing.Size(100, 20);
            this.JezikTextBox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(726, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Izdavac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mjesto izdavanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Jezik:";
            // 
            // IDUrediTxtBox
            // 
            this.IDUrediTxtBox.Enabled = false;
            this.IDUrediTxtBox.Location = new System.Drawing.Point(753, 61);
            this.IDUrediTxtBox.Name = "IDUrediTxtBox";
            this.IDUrediTxtBox.ReadOnly = true;
            this.IDUrediTxtBox.Size = new System.Drawing.Size(144, 20);
            this.IDUrediTxtBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Naziv knjige:";
            // 
            // UrediNazivTxtBox
            // 
            this.UrediNazivTxtBox.Enabled = false;
            this.UrediNazivTxtBox.Location = new System.Drawing.Point(797, 96);
            this.UrediNazivTxtBox.Name = "UrediNazivTxtBox";
            this.UrediNazivTxtBox.ReadOnly = true;
            this.UrediNazivTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UrediNazivTxtBox.TabIndex = 29;
            // 
            // kopijeDG
            // 
            this.kopijeDG.AllowUserToAddRows = false;
            this.kopijeDG.AllowUserToDeleteRows = false;
            this.kopijeDG.AllowUserToResizeRows = false;
            this.kopijeDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kopijeDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Lokacija,
            this.Dostupno,
            this.Opcije,
            this.RezerviraniClan,
            this.PosudbaID});
            this.kopijeDG.Location = new System.Drawing.Point(967, 40);
            this.kopijeDG.MultiSelect = false;
            this.kopijeDG.Name = "kopijeDG";
            this.kopijeDG.ReadOnly = true;
            this.kopijeDG.RowHeadersVisible = false;
            this.kopijeDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kopijeDG.ShowEditingIcon = false;
            this.kopijeDG.Size = new System.Drawing.Size(404, 367);
            this.kopijeDG.TabIndex = 40;
            this.kopijeDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kopijeDG_CellContentClick);
            this.kopijeDG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.kopijeDG_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "Lokacija";
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            this.Lokacija.ReadOnly = true;
            // 
            // Dostupno
            // 
            this.Dostupno.DataPropertyName = "Dostupno";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dostupno.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dostupno.HeaderText = "Dostupno";
            this.Dostupno.Name = "Dostupno";
            this.Dostupno.ReadOnly = true;
            // 
            // Opcije
            // 
            this.Opcije.HeaderText = "Opcije";
            this.Opcije.Name = "Opcije";
            this.Opcije.ReadOnly = true;
            // 
            // RezerviraniClan
            // 
            this.RezerviraniClan.DataPropertyName = "RezerviraniClan";
            this.RezerviraniClan.HeaderText = "RezerviraniClan";
            this.RezerviraniClan.Name = "RezerviraniClan";
            this.RezerviraniClan.ReadOnly = true;
            this.RezerviraniClan.Visible = false;
            // 
            // PosudbaID
            // 
            this.PosudbaID.HeaderText = "PosudbaID";
            this.PosudbaID.Name = "PosudbaID";
            this.PosudbaID.ReadOnly = true;
            this.PosudbaID.Visible = false;
            // 
            // KnjiznicarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 646);
            this.Controls.Add(this.kopijeDG);
            this.Controls.Add(this.AutoriUlogeListView);
            this.Controls.Add(this.IzdavacTxtBox);
            this.Controls.Add(this.MjestoIzdavanjaTxtBox);
            this.Controls.Add(this.JezikTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDUrediTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UrediNazivTxtBox);
            this.Controls.Add(this.KnjiznicarDataGridView);
            this.Controls.Add(this.UrediKatalogButton);
            this.Name = "KnjiznicarForm";
            this.Text = "KnjiznicarForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KnjiznicarForm_FormClosed);
            this.Load += new System.EventHandler(this.KnjiznicarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KnjiznicarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopijeDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UrediKatalogButton;
        private System.Windows.Forms.DataGridView KnjiznicarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnjigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prevoditelji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izdavac;
        private System.Windows.Forms.ListView AutoriUlogeListView;
        private System.Windows.Forms.ColumnHeader AutorColumn;
        private System.Windows.Forms.TextBox IzdavacTxtBox;
        private System.Windows.Forms.TextBox MjestoIzdavanjaTxtBox;
        private System.Windows.Forms.TextBox JezikTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDUrediTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UrediNazivTxtBox;
        private System.Windows.Forms.DataGridView kopijeDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostupno;
        private System.Windows.Forms.DataGridViewButtonColumn Opcije;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezerviraniClan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosudbaID;
    }
}