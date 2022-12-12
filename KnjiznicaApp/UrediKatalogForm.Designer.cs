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
            this.label4 = new System.Windows.Forms.Label();
            this.IDUrediTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UrediDataGridView)).BeginInit();
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
            this.UrediDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrediDataGridView.Location = new System.Drawing.Point(13, 12);
            this.UrediDataGridView.Name = "UrediDataGridView";
            this.UrediDataGridView.ReadOnly = true;
            this.UrediDataGridView.Size = new System.Drawing.Size(741, 561);
            this.UrediDataGridView.TabIndex = 8;
            this.UrediDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrediDataGridView_CellDoubleClick);
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
            // UrediKatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 595);
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
    }
}