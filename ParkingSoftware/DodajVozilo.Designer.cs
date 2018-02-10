namespace ParkingSoftware
{
    partial class DodajVozilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajVozilo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTablice = new System.Windows.Forms.TextBox();
            this.buttonDodajVozilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablice:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTablice
            // 
            this.textBoxTablice.Location = new System.Drawing.Point(169, 118);
            this.textBoxTablice.MaxLength = 8;
            this.textBoxTablice.Name = "textBoxTablice";
            this.textBoxTablice.Size = new System.Drawing.Size(176, 31);
            this.textBoxTablice.TabIndex = 1;
            this.textBoxTablice.TextChanged += new System.EventHandler(this.textBoxTablice_TextChanged);
            // 
            // buttonDodajVozilo
            // 
            this.buttonDodajVozilo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDodajVozilo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDodajVozilo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDodajVozilo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajVozilo.Location = new System.Drawing.Point(169, 179);
            this.buttonDodajVozilo.Name = "buttonDodajVozilo";
            this.buttonDodajVozilo.Size = new System.Drawing.Size(176, 51);
            this.buttonDodajVozilo.TabIndex = 5;
            this.buttonDodajVozilo.Text = "Dodaj Vozilo";
            this.buttonDodajVozilo.UseVisualStyleBackColor = true;
            this.buttonDodajVozilo.Click += new System.EventHandler(this.buttonDodajVozilo_Click);
            // 
            // DodajVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ParkingSoftware.Properties.Resources.logo_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(517, 344);
            this.Controls.Add(this.buttonDodajVozilo);
            this.Controls.Add(this.textBoxTablice);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "DodajVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTablice;
        private System.Windows.Forms.Button buttonDodajVozilo;
    }
}