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
            this.Vreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labUkupnoDan = new System.Windows.Forms.Label();
            this.labelUkuonoMesec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.Radnik,
            this.Vreme});
            this.dataGridViewVozila.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewVozila.Location = new System.Drawing.Point(-1, 33);
            this.dataGridViewVozila.Name = "dataGridViewVozila";
            this.dataGridViewVozila.RowTemplate.ReadOnly = true;
            this.dataGridViewVozila.Size = new System.Drawing.Size(441, 345);
            this.dataGridViewVozila.TabIndex = 1;
            this.dataGridViewVozila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVozila_CellContentClick);
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
            this.Dolazak.HeaderText = "Naplata(din)";
            this.Dolazak.Name = "Dolazak";
            this.Dolazak.ReadOnly = true;
            // 
            // Radnik
            // 
            this.Radnik.HeaderText = "Radnik";
            this.Radnik.Name = "Radnik";
            this.Radnik.ReadOnly = true;
            // 
            // Vreme
            // 
            this.Vreme.HeaderText = "Vreme(min)";
            this.Vreme.Name = "Vreme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dnevni izveštaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesecni izveštaj";
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
            this.labelUkuonoMesec.Location = new System.Drawing.Point(814, 381);
            this.labelUkuonoMesec.Name = "labelUkuonoMesec";
            this.labelUkuonoMesec.Size = new System.Drawing.Size(0, 20);
            this.labelUkuonoMesec.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ukupno:";
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZavrsi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonZavrsi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonZavrsi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonZavrsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.buttonZavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZavrsi.Location = new System.Drawing.Point(366, 428);
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
            this.label4.Location = new System.Drawing.Point(869, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "(din)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(din)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.LightSeaGreen;
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.LightSeaGreen;
            this.dateTimePicker2.Location = new System.Drawing.Point(712, 5);
            this.dateTimePicker2.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(470, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(441, 345);
            this.dataGridView1.TabIndex = 16;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Naplata(din)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Radnik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Vreme(min)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ParkingSoftware.Properties.Resources.save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ParkingSoftware.Properties.Resources.save;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(738, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sačuvaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Uvid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonZavrsi;
            this.ClientSize = new System.Drawing.Size(913, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonZavrsi);
            this.Controls.Add(this.labelUkuonoMesec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labUkupnoDan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVozila);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labUkupnoDan;
        private System.Windows.Forms.Label labelUkuonoMesec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonZavrsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}