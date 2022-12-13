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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrediKatalogButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.autoriDataGridViewTextBoxColumn,
            this.prevoditeljiDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.mjestoIzdavanjaDataGridViewTextBoxColumn,
            this.izdavacDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getAllKnjigeForIspisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(708, 622);
            this.dataGridView1.TabIndex = 0;
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
            // KnjiznicarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 646);
            this.Controls.Add(this.UrediKatalogButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KnjiznicarForm";
            this.Text = "KnjiznicarForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KnjiznicarForm_FormClosed);
            this.Load += new System.EventHandler(this.KnjiznicarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllKnjigeForIspisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UrediKatalogButton;
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