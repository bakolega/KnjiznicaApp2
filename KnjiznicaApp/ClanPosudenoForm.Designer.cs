namespace KnjiznicaApp
{
    partial class ClanPosudenoForm
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
            this.PosudenoDG = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posudeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVracanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Br_Produzenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produzi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PosudbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zakasnina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezerviranoDG = new System.Windows.Forms.DataGridView();
            this.NazivRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KopijaIDRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LokacijaRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_Posudbe_Rez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dat_Vracanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrRezervacijaIspred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PosudenoDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezerviranoDG)).BeginInit();
            this.SuspendLayout();
            // 
            // PosudenoDG
            // 
            this.PosudenoDG.AllowUserToAddRows = false;
            this.PosudenoDG.AllowUserToDeleteRows = false;
            this.PosudenoDG.AllowUserToResizeRows = false;
            this.PosudenoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PosudenoDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.ID,
            this.Lokacija,
            this.Posudeno,
            this.DatumVracanja,
            this.Br_Produzenja,
            this.Produzi,
            this.PosudbaID,
            this.Zakasnina});
            this.PosudenoDG.Location = new System.Drawing.Point(12, 12);
            this.PosudenoDG.MultiSelect = false;
            this.PosudenoDG.Name = "PosudenoDG";
            this.PosudenoDG.ReadOnly = true;
            this.PosudenoDG.RowHeadersVisible = false;
            this.PosudenoDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PosudenoDG.ShowEditingIcon = false;
            this.PosudenoDG.Size = new System.Drawing.Size(781, 428);
            this.PosudenoDG.TabIndex = 0;
            this.PosudenoDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PosudenoDG_CellContentClick);
            this.PosudenoDG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PosudenoDG_CellFormatting);
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
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
            // Posudeno
            // 
            this.Posudeno.DataPropertyName = "Dat_Posudbe";
            this.Posudeno.HeaderText = "Posuđeno";
            this.Posudeno.Name = "Posudeno";
            this.Posudeno.ReadOnly = true;
            // 
            // DatumVracanja
            // 
            this.DatumVracanja.HeaderText = "Datum Povrata";
            this.DatumVracanja.Name = "DatumVracanja";
            this.DatumVracanja.ReadOnly = true;
            // 
            // Br_Produzenja
            // 
            this.Br_Produzenja.DataPropertyName = "Produzenja";
            this.Br_Produzenja.HeaderText = "Broj Produženja";
            this.Br_Produzenja.Name = "Br_Produzenja";
            this.Br_Produzenja.ReadOnly = true;
            // 
            // Produzi
            // 
            this.Produzi.HeaderText = "Produži";
            this.Produzi.Name = "Produzi";
            this.Produzi.ReadOnly = true;
            this.Produzi.Text = "Produži";
            this.Produzi.Width = 45;
            // 
            // PosudbaID
            // 
            this.PosudbaID.DataPropertyName = "PosudbaID";
            this.PosudbaID.HeaderText = "PosudbaID";
            this.PosudbaID.Name = "PosudbaID";
            this.PosudbaID.ReadOnly = true;
            this.PosudbaID.Visible = false;
            // 
            // Zakasnina
            // 
            this.Zakasnina.HeaderText = "Zakasnina";
            this.Zakasnina.Name = "Zakasnina";
            this.Zakasnina.ReadOnly = true;
            this.Zakasnina.Width = 130;
            // 
            // RezerviranoDG
            // 
            this.RezerviranoDG.AllowUserToAddRows = false;
            this.RezerviranoDG.AllowUserToDeleteRows = false;
            this.RezerviranoDG.AllowUserToResizeRows = false;
            this.RezerviranoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezerviranoDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivRez,
            this.KopijaIDRez,
            this.LokacijaRezervacije,
            this.Dostupno,
            this.Datum_Posudbe_Rez,
            this.Dat_Vracanja,
            this.BrRezervacijaIspred,
            this.RezervacijaID,
            this.Otkazi});
            this.RezerviranoDG.Location = new System.Drawing.Point(799, 11);
            this.RezerviranoDG.MultiSelect = false;
            this.RezerviranoDG.Name = "RezerviranoDG";
            this.RezerviranoDG.ReadOnly = true;
            this.RezerviranoDG.RowHeadersVisible = false;
            this.RezerviranoDG.Size = new System.Drawing.Size(506, 428);
            this.RezerviranoDG.TabIndex = 1;
            this.RezerviranoDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RezerviranoDG_CellContentClick);
            this.RezerviranoDG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RezerviranoDG_CellFormatting);
            // 
            // NazivRez
            // 
            this.NazivRez.DataPropertyName = "Naziv";
            this.NazivRez.HeaderText = "Naziv";
            this.NazivRez.Name = "NazivRez";
            this.NazivRez.ReadOnly = true;
            // 
            // KopijaIDRez
            // 
            this.KopijaIDRez.DataPropertyName = "KopijaID";
            this.KopijaIDRez.HeaderText = "ID";
            this.KopijaIDRez.Name = "KopijaIDRez";
            this.KopijaIDRez.ReadOnly = true;
            // 
            // LokacijaRezervacije
            // 
            this.LokacijaRezervacije.DataPropertyName = "NazivLokacije";
            this.LokacijaRezervacije.HeaderText = "Lokacija";
            this.LokacijaRezervacije.Name = "LokacijaRezervacije";
            this.LokacijaRezervacije.ReadOnly = true;
            // 
            // Dostupno
            // 
            this.Dostupno.HeaderText = "Dostupno";
            this.Dostupno.Name = "Dostupno";
            this.Dostupno.ReadOnly = true;
            // 
            // Datum_Posudbe_Rez
            // 
            this.Datum_Posudbe_Rez.DataPropertyName = "Dat_Posudbe";
            this.Datum_Posudbe_Rez.HeaderText = "Datum zadnje posudbe";
            this.Datum_Posudbe_Rez.Name = "Datum_Posudbe_Rez";
            this.Datum_Posudbe_Rez.ReadOnly = true;
            this.Datum_Posudbe_Rez.Visible = false;
            // 
            // Dat_Vracanja
            // 
            this.Dat_Vracanja.DataPropertyName = "Dat_Vracanja";
            this.Dat_Vracanja.HeaderText = "Dat_Vracanja";
            this.Dat_Vracanja.Name = "Dat_Vracanja";
            this.Dat_Vracanja.ReadOnly = true;
            this.Dat_Vracanja.Visible = false;
            // 
            // BrRezervacijaIspred
            // 
            this.BrRezervacijaIspred.DataPropertyName = "RezervacijaPrije";
            this.BrRezervacijaIspred.HeaderText = "BrRezervacijaIspred";
            this.BrRezervacijaIspred.Name = "BrRezervacijaIspred";
            this.BrRezervacijaIspred.ReadOnly = true;
            this.BrRezervacijaIspred.Visible = false;
            // 
            // RezervacijaID
            // 
            this.RezervacijaID.DataPropertyName = "RezervacijaID";
            this.RezervacijaID.HeaderText = "RezervacijaID";
            this.RezervacijaID.Name = "RezervacijaID";
            this.RezervacijaID.ReadOnly = true;
            this.RezervacijaID.Visible = false;
            // 
            // Otkazi
            // 
            this.Otkazi.HeaderText = "Otkaži";
            this.Otkazi.Name = "Otkazi";
            this.Otkazi.ReadOnly = true;
            this.Otkazi.Text = "Otkaži";
            // 
            // ClanPosudenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 451);
            this.Controls.Add(this.RezerviranoDG);
            this.Controls.Add(this.PosudenoDG);
            this.Name = "ClanPosudenoForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PosudenoDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezerviranoDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PosudenoDG;
        private System.Windows.Forms.DataGridView RezerviranoDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posudeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVracanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Br_Produzenja;
        private System.Windows.Forms.DataGridViewButtonColumn Produzi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosudbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zakasnina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn KopijaIDRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_Posudbe_Rez;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dat_Vracanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrRezervacijaIspred;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaID;
        private System.Windows.Forms.DataGridViewButtonColumn Otkazi;
    }
}