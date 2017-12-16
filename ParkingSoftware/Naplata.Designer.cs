namespace ParkingSoftware
{
    partial class Naplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Naplata));
            this.dataGridViewVozila = new System.Windows.Forms.DataGridView();
            this.Tablice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naplati = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonPronadji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVozila
            // 
            this.dataGridViewVozila.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tablice,
            this.Dolazak,
            this.Naplati});
            this.dataGridViewVozila.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewVozila.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVozila.Name = "dataGridViewVozila";
            this.dataGridViewVozila.Size = new System.Drawing.Size(807, 345);
            this.dataGridViewVozila.TabIndex = 0;
            this.dataGridViewVozila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVozila_CellContentClick);
            // 
            // Tablice
            // 
            this.Tablice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tablice.HeaderText = "Tablice";
            this.Tablice.Name = "Tablice";
            this.Tablice.ReadOnly = true;
            // 
            // Dolazak
            // 
            this.Dolazak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dolazak.HeaderText = "Dolazak";
            this.Dolazak.Name = "Dolazak";
            // 
            // Naplati
            // 
            this.Naplati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Naplati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Naplati.HeaderText = "Naplati";
            this.Naplati.Name = "Naplati";
            this.Naplati.Text = "Naplati";
            this.Naplati.UseColumnTextForButtonValue = true;
            this.Naplati.Width = 150;
            // 
            // buttonPronadji
            // 
            this.buttonPronadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPronadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPronadji.Location = new System.Drawing.Point(333, 351);
            this.buttonPronadji.Name = "buttonPronadji";
            this.buttonPronadji.Size = new System.Drawing.Size(176, 51);
            this.buttonPronadji.TabIndex = 7;
            this.buttonPronadji.Text = "Naplati";
            this.buttonPronadji.UseVisualStyleBackColor = true;
            this.buttonPronadji.Click += new System.EventHandler(this.buttonPronadji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(73, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tablice:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(158, 363);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZavrsi.Location = new System.Drawing.Point(624, 351);
            this.buttonZavrsi.Name = "buttonZavrsi";
            this.buttonZavrsi.Size = new System.Drawing.Size(176, 51);
            this.buttonZavrsi.TabIndex = 10;
            this.buttonZavrsi.Text = "Zavrsi";
            this.buttonZavrsi.UseVisualStyleBackColor = true;
            this.buttonZavrsi.Click += new System.EventHandler(this.buttonZavrsi_Click);
            // 
            // Naplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(807, 403);
            this.Controls.Add(this.buttonZavrsi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPronadji);
            this.Controls.Add(this.dataGridViewVozila);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Naplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naplata";
            this.Load += new System.EventHandler(this.Naplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolazak;
        private System.Windows.Forms.DataGridViewButtonColumn Naplati;
        private System.Windows.Forms.Button buttonPronadji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonZavrsi;
    }
}