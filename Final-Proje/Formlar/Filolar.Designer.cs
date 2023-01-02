
namespace Final_Proje.Formlar
{
    partial class Filolar
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
            this.FiloTablo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FiloGuncelle = new System.Windows.Forms.Button();
            this.btnFiloekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FiloTablo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiloTablo
            // 
            this.FiloTablo.AllowUserToAddRows = false;
            this.FiloTablo.AllowUserToDeleteRows = false;
            this.FiloTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FiloTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FiloTablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiloTablo.Location = new System.Drawing.Point(0, 99);
            this.FiloTablo.Name = "FiloTablo";
            this.FiloTablo.ReadOnly = true;
            this.FiloTablo.RowHeadersWidth = 51;
            this.FiloTablo.RowTemplate.Height = 24;
            this.FiloTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FiloTablo.Size = new System.Drawing.Size(800, 351);
            this.FiloTablo.TabIndex = 5;
            this.FiloTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FiloTablo_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.FiloGuncelle);
            this.panel1.Controls.Add(this.btnFiloekle);
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
            this.button3.Text = "Filo Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FiloGuncelle
            // 
            this.FiloGuncelle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FiloGuncelle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.FiloGuncelle.FlatAppearance.BorderSize = 3;
            this.FiloGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiloGuncelle.Location = new System.Drawing.Point(116, 12);
            this.FiloGuncelle.Name = "FiloGuncelle";
            this.FiloGuncelle.Size = new System.Drawing.Size(98, 75);
            this.FiloGuncelle.TabIndex = 1;
            this.FiloGuncelle.Text = "Filo Güncelle";
            this.FiloGuncelle.UseVisualStyleBackColor = false;
            this.FiloGuncelle.Click += new System.EventHandler(this.FiloGuncelle_Click);
            // 
            // btnFiloekle
            // 
            this.btnFiloekle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFiloekle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnFiloekle.FlatAppearance.BorderSize = 3;
            this.btnFiloekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiloekle.Location = new System.Drawing.Point(12, 12);
            this.btnFiloekle.Name = "btnFiloekle";
            this.btnFiloekle.Size = new System.Drawing.Size(98, 75);
            this.btnFiloekle.TabIndex = 0;
            this.btnFiloekle.Text = "Filo Ekle";
            this.btnFiloekle.UseVisualStyleBackColor = false;
            this.btnFiloekle.Click += new System.EventHandler(this.btnFiloekle_Click);
            // 
            // Filolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiloTablo);
            this.Controls.Add(this.panel1);
            this.Name = "Filolar";
            this.Text = "Filolar";
            this.Load += new System.EventHandler(this.Filolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FiloTablo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FiloTablo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button FiloGuncelle;
        private System.Windows.Forms.Button btnFiloekle;
    }
}