namespace sustav_za_rezervacije.Forms
{
    partial class ReservationMainForm
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
            this.btnInformacije = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lstRezervacije = new System.Windows.Forms.ListBox();
            this.btnStolovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInformacije
            // 
            this.btnInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInformacije.Location = new System.Drawing.Point(931, 177);
            this.btnInformacije.Name = "btnInformacije";
            this.btnInformacije.Size = new System.Drawing.Size(220, 44);
            this.btnInformacije.TabIndex = 29;
            this.btnInformacije.Text = "Informacije";
            this.btnInformacije.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vrijeme rezervacije";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(931, 520);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(220, 44);
            this.btnIzlaz.TabIndex = 27;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkloni.Location = new System.Drawing.Point(931, 127);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(220, 44);
            this.btnUkloni.TabIndex = 26;
            this.btnUkloni.Text = "Ukloni rezervaciju";
            this.btnUkloni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(931, 77);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(220, 44);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj rezervaciju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(234, 23);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 24;
            // 
            // lstRezervacije
            // 
            this.lstRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstRezervacije.FormattingEnabled = true;
            this.lstRezervacije.ItemHeight = 20;
            this.lstRezervacije.Location = new System.Drawing.Point(33, 77);
            this.lstRezervacije.Name = "lstRezervacije";
            this.lstRezervacije.Size = new System.Drawing.Size(861, 504);
            this.lstRezervacije.TabIndex = 23;
            // 
            // btnStolovi
            // 
            this.btnStolovi.Location = new System.Drawing.Point(933, 329);
            this.btnStolovi.Name = "btnStolovi";
            this.btnStolovi.Size = new System.Drawing.Size(220, 44);
            this.btnStolovi.TabIndex = 30;
            this.btnStolovi.Text = "Svi stolovi";
            this.btnStolovi.UseVisualStyleBackColor = true;
            this.btnStolovi.Click += new System.EventHandler(this.btnStolovi_Click);
            // 
            // ReservationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 605);
            this.Controls.Add(this.btnStolovi);
            this.Controls.Add(this.btnInformacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lstRezervacije);
            this.Name = "ReservationMainForm";
            this.Text = "ReservationMainForm";
            this.Load += new System.EventHandler(this.ReservationMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox lstRezervacije;
        private System.Windows.Forms.Button btnStolovi;
    }
}