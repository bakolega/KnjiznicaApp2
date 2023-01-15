namespace KnjiznicaApp
{
    partial class ClanForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TraziTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIzborComboBox = new System.Windows.Forms.ComboBox();
            this.OdjavaButton = new System.Windows.Forms.Button();
            this.ClanDataGridView = new System.Windows.Forms.DataGridView();
            this.KnjigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prevoditelji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUrediTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UrediNazivTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.JezikTextBox = new System.Windows.Forms.TextBox();
            this.MjestoIzdavanjaTxtBox = new System.Windows.Forms.TextBox();
            this.IzdavacTxtBox = new System.Windows.Forms.TextBox();
            this.AutoriUlogeListView = new System.Windows.Forms.ListView();
            this.AutorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kopijeDG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervacije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpenPosudenoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopijeDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TraziTxtBox
            // 
            this.TraziTxtBox.Location = new System.Drawing.Point(62, 6);
            this.TraziTxtBox.Name = "TraziTxtBox";
            this.TraziTxtBox.Size = new System.Drawing.Size(251, 20);
            this.TraziTxtBox.TabIndex = 1;
            this.TraziTxtBox.TextChanged += new System.EventHandler(this.TraziTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraga";
            // 
            // searchIzborComboBox
            // 
            this.searchIzborComboBox.FormattingEnabled = true;
            this.searchIzborComboBox.Items.AddRange(new object[] {
            "Katalog",
            "Naziv",
            "Autor",
            "KnjigaID"});
            this.searchIzborComboBox.Location = new System.Drawing.Point(319, 6);
            this.searchIzborComboBox.Name = "searchIzborComboBox";
            this.searchIzborComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchIzborComboBox.TabIndex = 3;
            // 
            // OdjavaButton
            // 
            this.OdjavaButton.Location = new System.Drawing.Point(1432, 630);
            this.OdjavaButton.Name = "OdjavaButton";
            this.OdjavaButton.Size = new System.Drawing.Size(115, 52);
            this.OdjavaButton.TabIndex = 4;
            this.OdjavaButton.Text = "Odjava";
            this.OdjavaButton.UseVisualStyleBackColor = true;
            this.OdjavaButton.Click += new System.EventHandler(this.OdjavaButton_Click);
            // 
            // ClanDataGridView
            // 
            this.ClanDataGridView.AllowUserToAddRows = false;
            this.ClanDataGridView.AllowUserToDeleteRows = false;
            this.ClanDataGridView.AllowUserToResizeRows = false;
            this.ClanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KnjigaID,
            this.Naziv,
            this.Autori,
            this.Prevoditelji,
            this.Godina,
            this.MjestoIzdavanja,
            this.Izdavac});
            this.ClanDataGridView.Location = new System.Drawing.Point(12, 33);
            this.ClanDataGridView.MultiSelect = false;
            this.ClanDataGridView.Name = "ClanDataGridView";
            this.ClanDataGridView.ReadOnly = true;
            this.ClanDataGridView.RowHeadersVisible = false;
            this.ClanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClanDataGridView.Size = new System.Drawing.Size(704, 594);
            this.ClanDataGridView.TabIndex = 5;
            this.ClanDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClanDataGridView_CellDoubleClick);
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
            // IDUrediTxtBox
            // 
            this.IDUrediTxtBox.Enabled = false;
            this.IDUrediTxtBox.Location = new System.Drawing.Point(799, 34);
            this.IDUrediTxtBox.Name = "IDUrediTxtBox";
            this.IDUrediTxtBox.ReadOnly = true;
            this.IDUrediTxtBox.Size = new System.Drawing.Size(144, 20);
            this.IDUrediTxtBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Naziv knjige:";
            // 
            // UrediNazivTxtBox
            // 
            this.UrediNazivTxtBox.Enabled = false;
            this.UrediNazivTxtBox.Location = new System.Drawing.Point(843, 69);
            this.UrediNazivTxtBox.Name = "UrediNazivTxtBox";
            this.UrediNazivTxtBox.ReadOnly = true;
            this.UrediNazivTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UrediNazivTxtBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Jezik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mjesto izdavanja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Izdavac";
            // 
            // JezikTextBox
            // 
            this.JezikTextBox.Location = new System.Drawing.Point(813, 111);
            this.JezikTextBox.Name = "JezikTextBox";
            this.JezikTextBox.ReadOnly = true;
            this.JezikTextBox.Size = new System.Drawing.Size(100, 20);
            this.JezikTextBox.TabIndex = 24;
            // 
            // MjestoIzdavanjaTxtBox
            // 
            this.MjestoIzdavanjaTxtBox.Location = new System.Drawing.Point(867, 147);
            this.MjestoIzdavanjaTxtBox.Name = "MjestoIzdavanjaTxtBox";
            this.MjestoIzdavanjaTxtBox.ReadOnly = true;
            this.MjestoIzdavanjaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MjestoIzdavanjaTxtBox.TabIndex = 25;
            // 
            // IzdavacTxtBox
            // 
            this.IzdavacTxtBox.Location = new System.Drawing.Point(823, 184);
            this.IzdavacTxtBox.Name = "IzdavacTxtBox";
            this.IzdavacTxtBox.ReadOnly = true;
            this.IzdavacTxtBox.Size = new System.Drawing.Size(100, 20);
            this.IzdavacTxtBox.TabIndex = 26;
            // 
            // AutoriUlogeListView
            // 
            this.AutoriUlogeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AutorColumn});
            this.AutoriUlogeListView.HideSelection = false;
            this.AutoriUlogeListView.Location = new System.Drawing.Point(772, 229);
            this.AutoriUlogeListView.Name = "AutoriUlogeListView";
            this.AutoriUlogeListView.Size = new System.Drawing.Size(235, 311);
            this.AutoriUlogeListView.TabIndex = 28;
            this.AutoriUlogeListView.UseCompatibleStateImageBehavior = false;
            this.AutoriUlogeListView.View = System.Windows.Forms.View.Details;
            // 
            // AutorColumn
            // 
            this.AutorColumn.Text = "Autori";
            this.AutorColumn.Width = 231;
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
            this.Rezervacije});
            this.kopijeDG.Location = new System.Drawing.Point(1013, 173);
            this.kopijeDG.MultiSelect = false;
            this.kopijeDG.Name = "kopijeDG";
            this.kopijeDG.ReadOnly = true;
            this.kopijeDG.RowHeadersVisible = false;
            this.kopijeDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kopijeDG.ShowEditingIcon = false;
            this.kopijeDG.Size = new System.Drawing.Size(412, 367);
            this.kopijeDG.TabIndex = 29;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dostupno.DefaultCellStyle = dataGridViewCellStyle8;
            this.Dostupno.HeaderText = "Dostupno";
            this.Dostupno.Name = "Dostupno";
            this.Dostupno.ReadOnly = true;
            // 
            // Rezervacije
            // 
            this.Rezervacije.HeaderText = "Rezervacije";
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.ReadOnly = true;
            // 
            // OpenPosudenoButton
            // 
            this.OpenPosudenoButton.Location = new System.Drawing.Point(12, 633);
            this.OpenPosudenoButton.Name = "OpenPosudenoButton";
            this.OpenPosudenoButton.Size = new System.Drawing.Size(115, 50);
            this.OpenPosudenoButton.TabIndex = 30;
            this.OpenPosudenoButton.Text = "Posuđeno i rezervirano";
            this.OpenPosudenoButton.UseVisualStyleBackColor = true;
            this.OpenPosudenoButton.Click += new System.EventHandler(this.OpenPosudenoButton_Click);
            // 
            // ClanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 694);
            this.Controls.Add(this.OpenPosudenoButton);
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
            this.Controls.Add(this.ClanDataGridView);
            this.Controls.Add(this.OdjavaButton);
            this.Controls.Add(this.searchIzborComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TraziTxtBox);
            this.Name = "ClanForm";
            this.Text = "Član";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClanForm_FormClosed);
            this.Load += new System.EventHandler(this.ClanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopijeDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TraziTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchIzborComboBox;
        private System.Windows.Forms.Button OdjavaButton;
        private System.Windows.Forms.DataGridView ClanDataGridView;
        private System.Windows.Forms.TextBox IDUrediTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UrediNazivTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JezikTextBox;
        private System.Windows.Forms.TextBox MjestoIzdavanjaTxtBox;
        private System.Windows.Forms.TextBox IzdavacTxtBox;
        private System.Windows.Forms.ListView AutoriUlogeListView;
        private System.Windows.Forms.ColumnHeader AutorColumn;
        private System.Windows.Forms.DataGridView kopijeDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostupno;
        private System.Windows.Forms.DataGridViewButtonColumn Rezervacije;
        private System.Windows.Forms.Button OpenPosudenoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnjigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prevoditelji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izdavac;
    }
}