namespace ParkingSoftware
{
    partial class Statistika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika));
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(836, 239);
            this.cartesianChart1.TabIndex = 6;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pieChart1.Location = new System.Drawing.Point(0, 239);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(435, 264);
            this.pieChart1.TabIndex = 7;
            this.pieChart1.Text = "pieChart1";
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZavrsi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonZavrsi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonZavrsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.buttonZavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZavrsi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZavrsi.Location = new System.Drawing.Point(610, 399);
            this.buttonZavrsi.Name = "buttonZavrsi";
            this.buttonZavrsi.Size = new System.Drawing.Size(176, 66);
            this.buttonZavrsi.TabIndex = 11;
            this.buttonZavrsi.Text = "Završi";
            this.buttonZavrsi.UseVisualStyleBackColor = true;
            this.buttonZavrsi.Click += new System.EventHandler(this.buttonZavrsi_Click);
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 503);
            this.Controls.Add(this.buttonZavrsi);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.cartesianChart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Statistika_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Button buttonZavrsi;
    }
}