
namespace Final_Proje.Formlar
{
    partial class Sigortalar
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
            this.sigortaTablo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSigortaGüncelle = new System.Windows.Forms.Button();
            this.btnSigortaEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaTablo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sigortaTablo
            // 
            this.sigortaTablo.AllowUserToAddRows = false;
            this.sigortaTablo.AllowUserToDeleteRows = false;
            this.sigortaTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sigortaTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sigortaTablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sigortaTablo.Location = new System.Drawing.Point(0, 99);
            this.sigortaTablo.Name = "sigortaTablo";
            this.sigortaTablo.ReadOnly = true;
            this.sigortaTablo.RowHeadersWidth = 51;
            this.sigortaTablo.RowTemplate.Height = 24;
            this.sigortaTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sigortaTablo.Size = new System.Drawing.Size(800, 351);
            this.sigortaTablo.TabIndex = 5;
            this.sigortaTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sigortaTablo_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnSigortaGüncelle);
            this.panel1.Controls.Add(this.btnSigortaEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 99);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(620, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "Filtrele";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(220, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sigorta Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSigortaGüncelle
            // 
            this.btnSigortaGüncelle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSigortaGüncelle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnSigortaGüncelle.FlatAppearance.BorderSize = 3;
            this.btnSigortaGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigortaGüncelle.Location = new System.Drawing.Point(116, 12);
            this.btnSigortaGüncelle.Name = "btnSigortaGüncelle";
            this.btnSigortaGüncelle.Size = new System.Drawing.Size(98, 75);
            this.btnSigortaGüncelle.TabIndex = 1;
            this.btnSigortaGüncelle.Text = "Sigorta Güncelle";
            this.btnSigortaGüncelle.UseVisualStyleBackColor = false;
            this.btnSigortaGüncelle.Click += new System.EventHandler(this.btnSigortaGüncelle_Click);
            // 
            // btnSigortaEkle
            // 
            this.btnSigortaEkle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSigortaEkle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnSigortaEkle.FlatAppearance.BorderSize = 3;
            this.btnSigortaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigortaEkle.Location = new System.Drawing.Point(12, 12);
            this.btnSigortaEkle.Name = "btnSigortaEkle";
            this.btnSigortaEkle.Size = new System.Drawing.Size(98, 75);
            this.btnSigortaEkle.TabIndex = 0;
            this.btnSigortaEkle.Text = "Sigorta Ekle";
            this.btnSigortaEkle.UseVisualStyleBackColor = false;
            this.btnSigortaEkle.Click += new System.EventHandler(this.btnSigortaEkle_Click);
            // 
            // Sigortalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sigortaTablo);
            this.Controls.Add(this.panel1);
            this.Name = "Sigortalar";
            this.Text = "Sigortalar";
            this.Load += new System.EventHandler(this.Sigortalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sigortaTablo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sigortaTablo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSigortaGüncelle;
        private System.Windows.Forms.Button btnSigortaEkle;
    }
}