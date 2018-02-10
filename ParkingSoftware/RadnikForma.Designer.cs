namespace ParkingSoftware
{
    partial class RadnikForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadnikForma));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrojSlobodnih = new System.Windows.Forms.TextBox();
            this.textBoxBrojVozila = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodajVozilo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.textBoxRadnik = new System.Windows.Forms.TextBox();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj Slobodnih Parking Mesta:";
            // 
            // textBoxBrojSlobodnih
            // 
            this.textBoxBrojSlobodnih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBrojSlobodnih.BackColor = System.Drawing.Color.White;
            this.textBoxBrojSlobodnih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBrojSlobodnih.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textBoxBrojSlobodnih.Location = new System.Drawing.Point(293, 23);
            this.textBoxBrojSlobodnih.Name = "textBoxBrojSlobodnih";
            this.textBoxBrojSlobodnih.ReadOnly = true;
            this.textBoxBrojSlobodnih.Size = new System.Drawing.Size(47, 23);
            this.textBoxBrojSlobodnih.TabIndex = 1;
            this.textBoxBrojSlobodnih.Text = "0";
            // 
            // textBoxBrojVozila
            // 
            this.textBoxBrojVozila.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBrojVozila.BackColor = System.Drawing.Color.White;
            this.textBoxBrojVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBrojVozila.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textBoxBrojVozila.Location = new System.Drawing.Point(252, 75);
            this.textBoxBrojVozila.Name = "textBoxBrojVozila";
            this.textBoxBrojVozila.ReadOnly = true;
            this.textBoxBrojVozila.Size = new System.Drawing.Size(47, 23);
            this.textBoxBrojVozila.TabIndex = 3;
            this.textBoxBrojVozila.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj Vozila Na Parkingu:";
            // 
            // buttonDodajVozilo
            // 
            this.buttonDodajVozilo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDodajVozilo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDodajVozilo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDodajVozilo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.buttonDodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajVozilo.Location = new System.Drawing.Point(16, 192);
            this.buttonDodajVozilo.Name = "buttonDodajVozilo";
            this.buttonDodajVozilo.Size = new System.Drawing.Size(166, 49);
            this.buttonDodajVozilo.TabIndex = 4;
            this.buttonDodajVozilo.Text = "Dodaj Vozilo";
            this.buttonDodajVozilo.UseVisualStyleBackColor = true;
            this.buttonDodajVozilo.Click += new System.EventHandler(this.buttonDodajVozilo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Naplati";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOdjava.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOdjava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonOdjava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.buttonOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOdjava.Location = new System.Drawing.Point(703, 274);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(151, 49);
            this.buttonOdjava.TabIndex = 8;
            this.buttonOdjava.Text = "Odjavi se";
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // textBoxRadnik
            // 
            this.textBoxRadnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRadnik.BackColor = System.Drawing.Color.White;
            this.textBoxRadnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRadnik.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textBoxRadnik.Location = new System.Drawing.Point(778, 26);
            this.textBoxRadnik.Name = "textBoxRadnik";
            this.textBoxRadnik.ReadOnly = true;
            this.textBoxRadnik.Size = new System.Drawing.Size(95, 23);
            this.textBoxRadnik.TabIndex = 9;
            this.textBoxRadnik.TextChanged += new System.EventHandler(this.textBoxRadnik_TextChanged);
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonZavrsi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonZavrsi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonZavrsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.buttonZavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZavrsi.Location = new System.Drawing.Point(703, 192);
            this.buttonZavrsi.Name = "buttonZavrsi";
            this.buttonZavrsi.Size = new System.Drawing.Size(151, 49);
            this.buttonZavrsi.TabIndex = 11;
            this.buttonZavrsi.Text = "Završi Smenu";
            this.buttonZavrsi.UseVisualStyleBackColor = true;
            this.buttonZavrsi.Click += new System.EventHandler(this.buttonZavrsi_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(340, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ulogovani ste kao:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RadnikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ParkingSoftware.Properties.Resources.logo_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonZavrsi);
            this.Controls.Add(this.textBoxRadnik);
            this.Controls.Add(this.buttonOdjava);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDodajVozilo);
            this.Controls.Add(this.textBoxBrojVozila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrojSlobodnih);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RadnikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingSoft";
            this.Load += new System.EventHandler(this.RadnikForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrojSlobodnih;
        private System.Windows.Forms.TextBox textBoxBrojVozila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDodajVozilo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.TextBox textBoxRadnik;
        private System.Windows.Forms.Button buttonZavrsi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}