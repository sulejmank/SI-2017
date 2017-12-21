namespace ParkingSoftware
{
    partial class Uvid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uvid));
            this.dataGridViewVozila = new System.Windows.Forms.DataGridView();
            this.Tablice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labUkupnoDan = new System.Windows.Forms.Label();
            this.labelUkuonoMesec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVozila
            // 
            this.dataGridViewVozila.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tablice,
            this.Dolazak,
            this.Radnik});
            this.dataGridViewVozila.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewVozila.Location = new System.Drawing.Point(-1, 33);
            this.dataGridViewVozila.Name = "dataGridViewVozila";
            this.dataGridViewVozila.Size = new System.Drawing.Size(329, 345);
            this.dataGridViewVozila.TabIndex = 1;
            // 
            // Tablice
            // 
            this.Tablice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tablice.HeaderText = "Datum";
            this.Tablice.Name = "Tablice";
            this.Tablice.ReadOnly = true;
            // 
            // Dolazak
            // 
            this.Dolazak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dolazak.HeaderText = "Naplata";
            this.Dolazak.Name = "Dolazak";
            this.Dolazak.ReadOnly = true;
            // 
            // Radnik
            // 
            this.Radnik.HeaderText = "Radnik";
            this.Radnik.Name = "Radnik";
            this.Radnik.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(470, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Naplata";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Radnik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dnevni Izveštaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesecni Izveštaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ukupno:";
            // 
            // labUkupnoDan
            // 
            this.labUkupnoDan.AutoSize = true;
            this.labUkupnoDan.Location = new System.Drawing.Point(105, 381);
            this.labUkupnoDan.Name = "labUkupnoDan";
            this.labUkupnoDan.Size = new System.Drawing.Size(0, 20);
            this.labUkupnoDan.TabIndex = 6;
            // 
            // labelUkuonoMesec
            // 
            this.labelUkuonoMesec.AutoSize = true;
            this.labelUkuonoMesec.Location = new System.Drawing.Point(542, 381);
            this.labelUkuonoMesec.Name = "labelUkuonoMesec";
            this.labelUkuonoMesec.Size = new System.Drawing.Size(0, 20);
            this.labelUkuonoMesec.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ukupno:";
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZavrsi.Location = new System.Drawing.Point(301, 428);
            this.buttonZavrsi.Name = "buttonZavrsi";
            this.buttonZavrsi.Size = new System.Drawing.Size(176, 51);
            this.buttonZavrsi.TabIndex = 11;
            this.buttonZavrsi.Text = "Završi";
            this.buttonZavrsi.UseVisualStyleBackColor = true;
            this.buttonZavrsi.Click += new System.EventHandler(this.buttonZavrsi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "(din)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(din)";
            // 
            // Uvid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonZavrsi);
            this.Controls.Add(this.labelUkuonoMesec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labUkupnoDan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewVozila);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Uvid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uvid";
            this.Load += new System.EventHandler(this.Uvid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labUkupnoDan;
        private System.Windows.Forms.Label labelUkuonoMesec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablice;
        private System.Windows.Forms.Button buttonZavrsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}