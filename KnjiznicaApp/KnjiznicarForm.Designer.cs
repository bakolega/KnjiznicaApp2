﻿namespace KnjiznicaApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrediKatalogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UrediKatalogButton;
    }
}