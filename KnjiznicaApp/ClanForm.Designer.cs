﻿namespace KnjiznicaApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OdjavaButton = new System.Windows.Forms.Button();
            this.ClanDataGridView = new System.Windows.Forms.DataGridView();
            this.IDUrediTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AutoriUlogeListView = new System.Windows.Forms.ListView();
            this.AutorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UlogaColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.UrediNazivTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.JezikTextBox = new System.Windows.Forms.TextBox();
            this.MjestoIzdavanjaTxtBox = new System.Windows.Forms.TextBox();
            this.IzdavacTxtBox = new System.Windows.Forms.TextBox();
            this.knjiznicaDataSet4 = new KnjiznicaApp.KnjiznicaDataSet4();
            this.getAllKnjigeForIspisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllKnjigeForIspisTableAdapter = new KnjiznicaApp.KnjiznicaDataSet4TableAdapters.GetAllKnjigeForIspisTableAdapter();
            this.knjigaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevoditeljiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.OdjavaButton.Location = new System.Drawing.Point(1032, 604);
            this.OdjavaButton.Name = "OdjavaButton";
            this.OdjavaButton.Size = new System.Drawing.Size(75, 23);
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
            this.ClanDataGridView.Size = new System.Drawing.Size(524, 594);
            this.ClanDataGridView.TabIndex = 5;
            this.ClanDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClanDataGridView_CellContentClick);
            this.ClanDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClanDataGridView_CellDoubleClick);
            // 
            // IDUrediTxtBox
            // 
            this.IDUrediTxtBox.Enabled = false;
            this.IDUrediTxtBox.Location = new System.Drawing.Point(614, 54);
            this.IDUrediTxtBox.Name = "IDUrediTxtBox";
            this.IDUrediTxtBox.Size = new System.Drawing.Size(144, 20);
            this.IDUrediTxtBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID:";
            // 
            // AutoriUlogeListView
            // 
            this.AutoriUlogeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AutorColumn,
            this.UlogaColumn});
            this.AutoriUlogeListView.HideSelection = false;
            this.AutoriUlogeListView.Location = new System.Drawing.Point(587, 134);
            this.AutoriUlogeListView.Name = "AutoriUlogeListView";
            this.AutoriUlogeListView.Size = new System.Drawing.Size(295, 96);
            this.AutoriUlogeListView.TabIndex = 18;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Naziv knjige:";
            // 
            // UrediNazivTxtBox
            // 
            this.UrediNazivTxtBox.Enabled = false;
            this.UrediNazivTxtBox.Location = new System.Drawing.Point(658, 89);
            this.UrediNazivTxtBox.Name = "UrediNazivTxtBox";
            this.UrediNazivTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UrediNazivTxtBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Jezik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mjesto izdavanja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Izdavac";
            // 
            // JezikTextBox
            // 
            this.JezikTextBox.Location = new System.Drawing.Point(625, 269);
            this.JezikTextBox.Name = "JezikTextBox";
            this.JezikTextBox.Size = new System.Drawing.Size(100, 20);
            this.JezikTextBox.TabIndex = 24;
            // 
            // MjestoIzdavanjaTxtBox
            // 
            this.MjestoIzdavanjaTxtBox.Location = new System.Drawing.Point(679, 305);
            this.MjestoIzdavanjaTxtBox.Name = "MjestoIzdavanjaTxtBox";
            this.MjestoIzdavanjaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MjestoIzdavanjaTxtBox.TabIndex = 25;
            // 
            // IzdavacTxtBox
            // 
            this.IzdavacTxtBox.Location = new System.Drawing.Point(635, 342);
            this.IzdavacTxtBox.Name = "IzdavacTxtBox";
            this.IzdavacTxtBox.Size = new System.Drawing.Size(100, 20);
            this.IzdavacTxtBox.TabIndex = 26;
            // 
            // knjiznicaDataSet4
            // 
            this.knjiznicaDataSet4.DataSetName = "KnjiznicaDataSet4";
            this.knjiznicaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllKnjigeForIspisBindingSource
            // 
            this.getAllKnjigeForIspisBindingSource.DataMember = "GetAllKnjigeForIspis";
            this.getAllKnjigeForIspisBindingSource.DataSource = this.knjiznicaDataSet4;
            // 
            // getAllKnjigeForIspisTableAdapter
            // 
            this.getAllKnjigeForIspisTableAdapter.ClearBeforeFill = true;
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
            // ClanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 639);
            this.Controls.Add(this.IzdavacTxtBox);
            this.Controls.Add(this.MjestoIzdavanjaTxtBox);
            this.Controls.Add(this.JezikTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDUrediTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AutoriUlogeListView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UrediNazivTxtBox);
            this.Controls.Add(this.ClanDataGridView);
            this.Controls.Add(this.OdjavaButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ClanForm";
            this.Text = "User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClanForm_FormClosed);
            this.Load += new System.EventHandler(this.ClanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button OdjavaButton;
        private System.Windows.Forms.DataGridView ClanDataGridView;
        private System.Windows.Forms.TextBox IDUrediTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView AutoriUlogeListView;
        private System.Windows.Forms.ColumnHeader AutorColumn;
        private System.Windows.Forms.ColumnHeader UlogaColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UrediNazivTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JezikTextBox;
        private System.Windows.Forms.TextBox MjestoIzdavanjaTxtBox;
        private System.Windows.Forms.TextBox IzdavacTxtBox;
        private KnjiznicaDataSet4 knjiznicaDataSet4;
        private System.Windows.Forms.BindingSource getAllKnjigeForIspisBindingSource;
        private KnjiznicaDataSet4TableAdapters.GetAllKnjigeForIspisTableAdapter getAllKnjigeForIspisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevoditeljiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavacDataGridViewTextBoxColumn;
    }
}