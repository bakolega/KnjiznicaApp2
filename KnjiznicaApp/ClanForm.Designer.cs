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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TraziTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OdjavaButton = new System.Windows.Forms.Button();
            this.ClanDataGridView = new System.Windows.Forms.DataGridView();
            this.knjigaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevoditeljiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllKnjigeForIspisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaDataSet = new KnjiznicaApp.KnjiznicaDataSet();
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
            this.TraziButton = new System.Windows.Forms.Button();
            this.getWhereNazivKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getWhereNazivKnjigeTableAdapter = new KnjiznicaApp.KnjiznicaDataSetTableAdapters.GetWhereNazivKnjigeTableAdapter();
            this.getAllKnjigeForIspisTableAdapter = new KnjiznicaApp.KnjiznicaDataSetTableAdapters.GetAllKnjigeForIspisTableAdapter();
            this.AutoriUlogeListView = new System.Windows.Forms.ListView();
            this.AutorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kopijeDG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervacije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWhereNazivKnjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopijeDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TraziTxtBox
            // 
            this.TraziTxtBox.Location = new System.Drawing.Point(62, 6);
            this.TraziTxtBox.Name = "TraziTxtBox";
            this.TraziTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TraziTxtBox.TabIndex = 1;
            this.TraziTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Katalog";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.ClanDataGridView.AutoGenerateColumns = false;
            this.ClanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.autoriDataGridViewTextBoxColumn,
            this.prevoditeljiDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.mjestoIzdavanjaDataGridViewTextBoxColumn,
            this.izdavacDataGridViewTextBoxColumn});
            this.ClanDataGridView.DataSource = this.getAllKnjigeForIspisBindingSource;
            this.ClanDataGridView.Location = new System.Drawing.Point(12, 33);
            this.ClanDataGridView.Name = "ClanDataGridView";
            this.ClanDataGridView.ReadOnly = true;
            this.ClanDataGridView.RowHeadersVisible = false;
            this.ClanDataGridView.Size = new System.Drawing.Size(704, 594);
            this.ClanDataGridView.TabIndex = 5;
            this.ClanDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClanDataGridView_CellContentClick);
            this.ClanDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClanDataGridView_CellDoubleClick);
            // 
            // knjigaIDDataGridViewTextBoxColumn
            // 
            this.knjigaIDDataGridViewTextBoxColumn.DataPropertyName = "KnjigaID";
            this.knjigaIDDataGridViewTextBoxColumn.HeaderText = "KnjigaID";
            this.knjigaIDDataGridViewTextBoxColumn.Name = "knjigaIDDataGridViewTextBoxColumn";
            this.knjigaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autoriDataGridViewTextBoxColumn
            // 
            this.autoriDataGridViewTextBoxColumn.DataPropertyName = "Autori";
            this.autoriDataGridViewTextBoxColumn.HeaderText = "Autori";
            this.autoriDataGridViewTextBoxColumn.Name = "autoriDataGridViewTextBoxColumn";
            this.autoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prevoditeljiDataGridViewTextBoxColumn
            // 
            this.prevoditeljiDataGridViewTextBoxColumn.DataPropertyName = "Prevoditelji";
            this.prevoditeljiDataGridViewTextBoxColumn.HeaderText = "Prevoditelji";
            this.prevoditeljiDataGridViewTextBoxColumn.Name = "prevoditeljiDataGridViewTextBoxColumn";
            this.prevoditeljiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "Godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "Godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            this.godinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoIzdavanjaDataGridViewTextBoxColumn
            // 
            this.mjestoIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "MjestoIzdavanja";
            this.mjestoIzdavanjaDataGridViewTextBoxColumn.HeaderText = "MjestoIzdavanja";
            this.mjestoIzdavanjaDataGridViewTextBoxColumn.Name = "mjestoIzdavanjaDataGridViewTextBoxColumn";
            this.mjestoIzdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izdavacDataGridViewTextBoxColumn
            // 
            this.izdavacDataGridViewTextBoxColumn.DataPropertyName = "Izdavac";
            this.izdavacDataGridViewTextBoxColumn.HeaderText = "Izdavac";
            this.izdavacDataGridViewTextBoxColumn.Name = "izdavacDataGridViewTextBoxColumn";
            this.izdavacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getAllKnjigeForIspisBindingSource
            // 
            this.getAllKnjigeForIspisBindingSource.DataMember = "GetAllKnjigeForIspis";
            this.getAllKnjigeForIspisBindingSource.DataSource = this.knjiznicaDataSet;
            // 
            // knjiznicaDataSet
            // 
            this.knjiznicaDataSet.DataSetName = "KnjiznicaDataSet";
            this.knjiznicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // TraziButton
            // 
            this.TraziButton.Location = new System.Drawing.Point(295, 4);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(75, 23);
            this.TraziButton.TabIndex = 27;
            this.TraziButton.Text = "Traži";
            this.TraziButton.UseVisualStyleBackColor = true;
            this.TraziButton.Click += new System.EventHandler(this.TraziButton_Click);
            // 
            // getWhereNazivKnjigeBindingSource
            // 
            this.getWhereNazivKnjigeBindingSource.DataMember = "GetWhereNazivKnjige";
            this.getWhereNazivKnjigeBindingSource.DataSource = this.knjiznicaDataSet;
            // 
            // getWhereNazivKnjigeTableAdapter
            // 
            this.getWhereNazivKnjigeTableAdapter.ClearBeforeFill = true;
            // 
            // getAllKnjigeForIspisTableAdapter
            // 
            this.getAllKnjigeForIspisTableAdapter.ClearBeforeFill = true;
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
            this.AutorColumn.Text = "Autor";
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
            this.kopijeDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dostupno.DefaultCellStyle = dataGridViewCellStyle4;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "Posuđeno i rezervirano";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kopijeDG);
            this.Controls.Add(this.AutoriUlogeListView);
            this.Controls.Add(this.TraziButton);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TraziTxtBox);
            this.Name = "ClanForm";
            this.Text = "Član";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClanForm_FormClosed);
            this.Load += new System.EventHandler(this.ClanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWhereNazivKnjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopijeDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TraziTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevoditeljiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavacDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getWhereNazivKnjigeBindingSource;
        private KnjiznicaDataSet knjiznicaDataSet;
        private KnjiznicaDataSetTableAdapters.GetWhereNazivKnjigeTableAdapter getWhereNazivKnjigeTableAdapter;
        private System.Windows.Forms.BindingSource getAllKnjigeForIspisBindingSource;
        private KnjiznicaDataSetTableAdapters.GetAllKnjigeForIspisTableAdapter getAllKnjigeForIspisTableAdapter;
        private System.Windows.Forms.ListView AutoriUlogeListView;
        private System.Windows.Forms.ColumnHeader AutorColumn;
        private System.Windows.Forms.DataGridView kopijeDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostupno;
        private System.Windows.Forms.DataGridViewButtonColumn Rezervacije;
        private System.Windows.Forms.Button button1;
    }
}