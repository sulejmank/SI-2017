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
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.trenutnoStanjeToolStripMenuItem});
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
            this.uvidUPoslovanjeToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.uvidUPoslovanjeToolStripMenuItem.Text = "Uvid u Poslovanje";
            // 
            // trenutnoStanjeToolStripMenuItem
            // 
            this.trenutnoStanjeToolStripMenuItem.Name = "trenutnoStanjeToolStripMenuItem";
            this.trenutnoStanjeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trenutnoStanjeToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.trenutnoStanjeToolStripMenuItem.Text = "Trenutno Stanje";
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
            this.dodajNalogToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.dodajNalogToolStripMenuItem.Text = "Dodaj Nalog";
            // 
            // izmeniNalogToolStripMenuItem
            // 
            this.izmeniNalogToolStripMenuItem.Name = "izmeniNalogToolStripMenuItem";
            this.izmeniNalogToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.izmeniNalogToolStripMenuItem.Text = "Izmeni nalog";
            // 
            // obrišiNalogToolStripMenuItem
            // 
            this.obrišiNalogToolStripMenuItem.Name = "obrišiNalogToolStripMenuItem";
            this.obrišiNalogToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.obrišiNalogToolStripMenuItem.Text = "Obriši Nalog";
            // 
            // parkingToolStripMenuItem
            // 
            this.parkingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmeniCeneToolStripMenuItem,
            this.izmeniBrojMestaToolStripMenuItem});
            this.parkingToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.parkingToolStripMenuItem.Name = "parkingToolStripMenuItem";
            this.parkingToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.parkingToolStripMenuItem.Text = "Parking";
            // 
            // izmeniCeneToolStripMenuItem
            // 
            this.izmeniCeneToolStripMenuItem.Name = "izmeniCeneToolStripMenuItem";
            this.izmeniCeneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniCeneToolStripMenuItem.Text = "Izmeni Cene";
            // 
            // izmeniBrojMestaToolStripMenuItem
            // 
            this.izmeniBrojMestaToolStripMenuItem.Name = "izmeniBrojMestaToolStripMenuItem";
            this.izmeniBrojMestaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniBrojMestaToolStripMenuItem.Text = "Izmeni Broj Mesta";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // SefForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ParkingSoftware.Properties.Resources.logo_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(788, 497);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SefForma";
            this.Text = "ParkingSoft";
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
    }
}