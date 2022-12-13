namespace KnjiznicaApp
{
    partial class UrediKatalogForm
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
            this.UrediNazivTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoriCombobox = new System.Windows.Forms.ComboBox();
            this.UlogaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AutoriUlogeListView = new System.Windows.Forms.ListView();
            this.AutorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UlogaColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrediDataGridView = new System.Windows.Forms.DataGridView();
            this.knjigaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevoditeljiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllKnjigeForIspisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaDataSet = new KnjiznicaApp.KnjiznicaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.IDUrediTxtBox = new System.Windows.Forms.TextBox();
            this.DodajKnjiguButton = new System.Windows.Forms.Button();
            this.UrediGodinaTxtBox = new System.Windows.Forms.TextBox();
            this.GodinaLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TraziTxtBox = new System.Windows.Forms.TextBox();
            this.getAllKnjigeForIspisTableAdapter = new KnjiznicaApp.KnjiznicaDataSetTableAdapters.GetAllKnjigeForIspisTableAdapter();
            this.TraziButton = new System.Windows.Forms.Button();
            this.getWhereNazivKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getWhereNazivKnjigeTableAdapter = new KnjiznicaApp.KnjiznicaDataSetTableAdapters.GetWhereNazivKnjigeTableAdapter();
            this.IzdavciComboboc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteKnjiga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UrediDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWhereNazivKnjigeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UrediNazivTxtBox
            // 
            this.UrediNazivTxtBox.Location = new System.Drawing.Point(777, 85);
            this.UrediNazivTxtBox.Name = "UrediNazivTxtBox";
            this.UrediNazivTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UrediNazivTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv knjige:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autori";
            // 
            // AutoriCombobox
            // 
            this.AutoriCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AutoriCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AutoriCombobox.DisplayMember = "AutorID";
            this.AutoriCombobox.FormattingEnabled = true;
            this.AutoriCombobox.Location = new System.Drawing.Point(777, 124);
            this.AutoriCombobox.Name = "AutoriCombobox";
            this.AutoriCombobox.Size = new System.Drawing.Size(121, 21);
            this.AutoriCombobox.TabIndex = 3;
            this.AutoriCombobox.ValueMember = "AutorID";
            // 
            // UlogaComboBox
            // 
            this.UlogaComboBox.FormattingEnabled = true;
            this.UlogaComboBox.Location = new System.Drawing.Point(777, 168);
            this.UlogaComboBox.Name = "UlogaComboBox";
            this.UlogaComboBox.Size = new System.Drawing.Size(121, 21);
            this.UlogaComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uloga";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AutoriUlogeListView
            // 
            this.AutoriUlogeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AutorColumn,
            this.UlogaColumn});
            this.AutoriUlogeListView.HideSelection = false;
            this.AutoriUlogeListView.Location = new System.Drawing.Point(1017, 108);
            this.AutoriUlogeListView.Name = "AutoriUlogeListView";
            this.AutoriUlogeListView.Size = new System.Drawing.Size(239, 81);
            this.AutoriUlogeListView.TabIndex = 7;
            this.AutoriUlogeListView.UseCompatibleStateImageBehavior = false;
            this.AutoriUlogeListView.View = System.Windows.Forms.View.Details;
            // 
            // AutorColumn
            // 
            this.AutorColumn.Text = "Autor";
            this.AutorColumn.Width = 118;
            // 
            // UlogaColumn
            // 
            this.UlogaColumn.Text = "Uloga";
            this.UlogaColumn.Width = 172;
            // 
            // UrediDataGridView
            // 
            this.UrediDataGridView.AllowUserToAddRows = false;
            this.UrediDataGridView.AllowUserToDeleteRows = false;
            this.UrediDataGridView.AutoGenerateColumns = false;
            this.UrediDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrediDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.autoriDataGridViewTextBoxColumn,
            this.prevoditeljiDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.mjestoIzdavanjaDataGridViewTextBoxColumn,
            this.izdavacDataGridViewTextBoxColumn});
            this.UrediDataGridView.DataSource = this.getAllKnjigeForIspisBindingSource;
            this.UrediDataGridView.Location = new System.Drawing.Point(13, 32);
            this.UrediDataGridView.Name = "UrediDataGridView";
            this.UrediDataGridView.ReadOnly = true;
            this.UrediDataGridView.RowHeadersVisible = false;
            this.UrediDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UrediDataGridView.Size = new System.Drawing.Size(694, 541);
            this.UrediDataGridView.TabIndex = 8;
            this.UrediDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrediDataGridView_CellContentDoubleClick);
            this.UrediDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrediDataGridView_CellDoubleClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // IDUrediTxtBox
            // 
            this.IDUrediTxtBox.Enabled = false;
            this.IDUrediTxtBox.Location = new System.Drawing.Point(804, 41);
            this.IDUrediTxtBox.Name = "IDUrediTxtBox";
            this.IDUrediTxtBox.Size = new System.Drawing.Size(358, 20);
            this.IDUrediTxtBox.TabIndex = 10;
            // 
            // DodajKnjiguButton
            // 
            this.DodajKnjiguButton.Location = new System.Drawing.Point(859, 439);
            this.DodajKnjiguButton.Name = "DodajKnjiguButton";
            this.DodajKnjiguButton.Size = new System.Drawing.Size(75, 23);
            this.DodajKnjiguButton.TabIndex = 11;
            this.DodajKnjiguButton.Text = "Dodaj Knjigu";
            this.DodajKnjiguButton.UseVisualStyleBackColor = true;
            this.DodajKnjiguButton.Click += new System.EventHandler(this.DodajKnjiguButton_Click);
            // 
            // UrediGodinaTxtBox
            // 
            this.UrediGodinaTxtBox.Location = new System.Drawing.Point(883, 85);
            this.UrediGodinaTxtBox.Name = "UrediGodinaTxtBox";
            this.UrediGodinaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UrediGodinaTxtBox.TabIndex = 12;
            // 
            // GodinaLabel
            // 
            this.GodinaLabel.AutoSize = true;
            this.GodinaLabel.Location = new System.Drawing.Point(880, 69);
            this.GodinaLabel.Name = "GodinaLabel";
            this.GodinaLabel.Size = new System.Drawing.Size(44, 13);
            this.GodinaLabel.TabIndex = 13;
            this.GodinaLabel.Text = "Godina:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Katalog";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pretraga";
            // 
            // TraziTxtBox
            // 
            this.TraziTxtBox.Location = new System.Drawing.Point(65, 5);
            this.TraziTxtBox.Name = "TraziTxtBox";
            this.TraziTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TraziTxtBox.TabIndex = 14;
            // 
            // getAllKnjigeForIspisTableAdapter
            // 
            this.getAllKnjigeForIspisTableAdapter.ClearBeforeFill = true;
            // 
            // TraziButton
            // 
            this.TraziButton.Location = new System.Drawing.Point(298, 3);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(75, 23);
            this.TraziButton.TabIndex = 17;
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
            // IzdavciComboboc
            // 
            this.IzdavciComboboc.FormattingEnabled = true;
            this.IzdavciComboboc.Location = new System.Drawing.Point(777, 222);
            this.IzdavciComboboc.Name = "IzdavciComboboc";
            this.IzdavciComboboc.Size = new System.Drawing.Size(121, 21);
            this.IzdavciComboboc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Izdavac:";
            // 
            // DeleteKnjiga
            // 
            this.DeleteKnjiga.Location = new System.Drawing.Point(954, 439);
            this.DeleteKnjiga.Name = "DeleteKnjiga";
            this.DeleteKnjiga.Size = new System.Drawing.Size(75, 23);
            this.DeleteKnjiga.TabIndex = 20;
            this.DeleteKnjiga.Text = "Izbrisi Knjigu";
            this.DeleteKnjiga.UseVisualStyleBackColor = true;
            this.DeleteKnjiga.Click += new System.EventHandler(this.DeleteKnjiga_Click);
            // 
            // UrediKatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 595);
            this.Controls.Add(this.DeleteKnjiga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IzdavciComboboc);
            this.Controls.Add(this.TraziButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TraziTxtBox);
            this.Controls.Add(this.GodinaLabel);
            this.Controls.Add(this.UrediGodinaTxtBox);
            this.Controls.Add(this.DodajKnjiguButton);
            this.Controls.Add(this.IDUrediTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UrediDataGridView);
            this.Controls.Add(this.AutoriUlogeListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UlogaComboBox);
            this.Controls.Add(this.AutoriCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrediNazivTxtBox);
            this.Name = "UrediKatalogForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UrediKatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UrediDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWhereNazivKnjigeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrediNazivTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AutoriCombobox;
        private System.Windows.Forms.ComboBox UlogaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView AutoriUlogeListView;
        private System.Windows.Forms.DataGridView UrediDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDUrediTxtBox;
        private System.Windows.Forms.ColumnHeader AutorColumn;
        private System.Windows.Forms.ColumnHeader UlogaColumn;
        private System.Windows.Forms.Button DodajKnjiguButton;
        private System.Windows.Forms.TextBox UrediGodinaTxtBox;
        private System.Windows.Forms.Label GodinaLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TraziTxtBox;
        private KnjiznicaDataSet knjiznicaDataSet;
        private System.Windows.Forms.BindingSource getAllKnjigeForIspisBindingSource;
        private KnjiznicaDataSetTableAdapters.GetAllKnjigeForIspisTableAdapter getAllKnjigeForIspisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevoditeljiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavacDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.BindingSource getWhereNazivKnjigeBindingSource;
        private KnjiznicaDataSetTableAdapters.GetWhereNazivKnjigeTableAdapter getWhereNazivKnjigeTableAdapter;
        private System.Windows.Forms.ComboBox IzdavciComboboc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteKnjiga;
    }
}