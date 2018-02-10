namespace ParkingSoftware
{
    partial class SefForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SefForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.naloziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uvidUPoslovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenutnoStanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naloziToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniCeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniBrojMestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaljiFirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriProzorZaRadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrojVozila = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrojSlobodnih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naloziToolStripMenuItem,
            this.naloziToolStripMenuItem1,
            this.parkingToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // naloziToolStripMenuItem
            // 
            this.naloziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uvidUPoslovanjeToolStripMenuItem,
            this.trenutnoStanjeToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.naloziToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naloziToolStripMenuItem.Name = "naloziToolStripMenuItem";
            this.naloziToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.naloziToolStripMenuItem.Text = "Opšte";
            this.naloziToolStripMenuItem.Click += new System.EventHandler(this.naloziToolStripMenuItem_Click);
            // 
            // uvidUPoslovanjeToolStripMenuItem
            // 
            this.uvidUPoslovanjeToolStripMenuItem.Name = "uvidUPoslovanjeToolStripMenuItem";
            this.uvidUPoslovanjeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.uvidUPoslovanjeToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.uvidUPoslovanjeToolStripMenuItem.Text = "Uvid u poslovanje";
            this.uvidUPoslovanjeToolStripMenuItem.Click += new System.EventHandler(this.uvidUPoslovanjeToolStripMenuItem_Click);
            // 
            // trenutnoStanjeToolStripMenuItem
            // 
            this.trenutnoStanjeToolStripMenuItem.Name = "trenutnoStanjeToolStripMenuItem";
            this.trenutnoStanjeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trenutnoStanjeToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.trenutnoStanjeToolStripMenuItem.Text = "Trenutno stanje";
            this.trenutnoStanjeToolStripMenuItem.Click += new System.EventHandler(this.trenutnoStanjeToolStripMenuItem_Click);
            // 
            // naloziToolStripMenuItem1
            // 
            this.naloziToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNalogToolStripMenuItem,
            this.izmeniNalogToolStripMenuItem,
            this.obrišiNalogToolStripMenuItem});
            this.naloziToolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.naloziToolStripMenuItem1.Name = "naloziToolStripMenuItem1";
            this.naloziToolStripMenuItem1.Size = new System.Drawing.Size(71, 25);
            this.naloziToolStripMenuItem1.Text = "Nalozi";
            // 
            // dodajNalogToolStripMenuItem
            // 
            this.dodajNalogToolStripMenuItem.Name = "dodajNalogToolStripMenuItem";
            this.dodajNalogToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.dodajNalogToolStripMenuItem.Text = "Dodaj nalog";
            this.dodajNalogToolStripMenuItem.Click += new System.EventHandler(this.dodajNalogToolStripMenuItem_Click_1);
            // 
            // izmeniNalogToolStripMenuItem
            // 
            this.izmeniNalogToolStripMenuItem.Name = "izmeniNalogToolStripMenuItem";
            this.izmeniNalogToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.izmeniNalogToolStripMenuItem.Text = "Izmeni nalog";
            this.izmeniNalogToolStripMenuItem.Click += new System.EventHandler(this.izmeniNalogToolStripMenuItem_Click);
            // 
            // obrišiNalogToolStripMenuItem
            // 
            this.obrišiNalogToolStripMenuItem.Name = "obrišiNalogToolStripMenuItem";
            this.obrišiNalogToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.obrišiNalogToolStripMenuItem.Text = "Obriši nalog";
            this.obrišiNalogToolStripMenuItem.Click += new System.EventHandler(this.obrišiNalogToolStripMenuItem_Click);
            // 
            // parkingToolStripMenuItem
            // 
            this.parkingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmeniCeneToolStripMenuItem,
            this.izmeniBrojMestaToolStripMenuItem,
            this.detaljiFirmeToolStripMenuItem});
            this.parkingToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.parkingToolStripMenuItem.Name = "parkingToolStripMenuItem";
            this.parkingToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.parkingToolStripMenuItem.Text = "Parking";
            // 
            // izmeniCeneToolStripMenuItem
            // 
            this.izmeniCeneToolStripMenuItem.Name = "izmeniCeneToolStripMenuItem";
            this.izmeniCeneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniCeneToolStripMenuItem.Text = "Izmeni cene";
            this.izmeniCeneToolStripMenuItem.Click += new System.EventHandler(this.izmeniCeneToolStripMenuItem_Click);
            // 
            // izmeniBrojMestaToolStripMenuItem
            // 
            this.izmeniBrojMestaToolStripMenuItem.Name = "izmeniBrojMestaToolStripMenuItem";
            this.izmeniBrojMestaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniBrojMestaToolStripMenuItem.Text = "Izmeni broj mesta";
            this.izmeniBrojMestaToolStripMenuItem.Click += new System.EventHandler(this.izmeniBrojMestaToolStripMenuItem_Click);
            // 
            // detaljiFirmeToolStripMenuItem
            // 
            this.detaljiFirmeToolStripMenuItem.Name = "detaljiFirmeToolStripMenuItem";
            this.detaljiFirmeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detaljiFirmeToolStripMenuItem.Text = "Detalji firme";
            this.detaljiFirmeToolStripMenuItem.Click += new System.EventHandler(this.detaljiFirmeToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriProzorZaRadToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.odjavaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // otvoriProzorZaRadToolStripMenuItem
            // 
            this.otvoriProzorZaRadToolStripMenuItem.Name = "otvoriProzorZaRadToolStripMenuItem";
            this.otvoriProzorZaRadToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.otvoriProzorZaRadToolStripMenuItem.Text = "Otvori prozor za rad";
            this.otvoriProzorZaRadToolStripMenuItem.Click += new System.EventHandler(this.otvoriProzorZaRadToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // labelIme
            // 
            this.labelIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.Location = new System.Drawing.Point(703, 43);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(0, 22);
            this.labelIme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ulogovani ste kao:";
            // 
            // textBoxBrojVozila
            // 
            this.textBoxBrojVozila.BackColor = System.Drawing.Color.White;
            this.textBoxBrojVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBrojVozila.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textBoxBrojVozila.Location = new System.Drawing.Point(252, 94);
            this.textBoxBrojVozila.Name = "textBoxBrojVozila";
            this.textBoxBrojVozila.ReadOnly = true;
            this.textBoxBrojVozila.Size = new System.Drawing.Size(47, 23);
            this.textBoxBrojVozila.TabIndex = 7;
            this.textBoxBrojVozila.Text = "0";
            this.textBoxBrojVozila.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj vozila na parkingu:";
            this.label2.Visible = false;
            // 
            // textBoxBrojSlobodnih
            // 
            this.textBoxBrojSlobodnih.BackColor = System.Drawing.Color.White;
            this.textBoxBrojSlobodnih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBrojSlobodnih.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textBoxBrojSlobodnih.Location = new System.Drawing.Point(293, 42);
            this.textBoxBrojSlobodnih.Name = "textBoxBrojSlobodnih";
            this.textBoxBrojSlobodnih.ReadOnly = true;
            this.textBoxBrojSlobodnih.Size = new System.Drawing.Size(47, 23);
            this.textBoxBrojSlobodnih.TabIndex = 5;
            this.textBoxBrojSlobodnih.Text = "0";
            this.textBoxBrojSlobodnih.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj slobodnih parking mesta:";
            this.label3.Visible = false;
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // SefForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ParkingSoftware.Properties.Resources.logo_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(788, 497);
            this.Controls.Add(this.textBoxBrojVozila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrojSlobodnih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SefForma";
            this.Text = "ParkingSoft";
            this.Load += new System.EventHandler(this.SefForma_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SefForma_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem naloziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uvidUPoslovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trenutnoStanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naloziToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obrišiNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniCeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniBrojMestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrojVozila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrojSlobodnih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem otvoriProzorZaRadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaljiFirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
    }
}