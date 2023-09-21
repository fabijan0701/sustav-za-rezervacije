namespace sustav_za_rezervacije.Forms
{
    partial class TimeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.numMinPoc = new System.Windows.Forms.NumericUpDown();
            this.numMinKraj = new System.Windows.Forms.NumericUpDown();
            this.numHPoc = new System.Windows.Forms.NumericUpDown();
            this.numHKraj = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDalje = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinKraj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHKraj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Odaberite datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Odaberite početak";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Odaberite kraj";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(247, 36);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 31;
            // 
            // numMinPoc
            // 
            this.numMinPoc.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numMinPoc.Location = new System.Drawing.Point(351, 131);
            this.numMinPoc.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinPoc.Name = "numMinPoc";
            this.numMinPoc.Size = new System.Drawing.Size(41, 22);
            this.numMinPoc.TabIndex = 32;
            // 
            // numMinKraj
            // 
            this.numMinKraj.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numMinKraj.Location = new System.Drawing.Point(351, 183);
            this.numMinKraj.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinKraj.Name = "numMinKraj";
            this.numMinKraj.Size = new System.Drawing.Size(41, 22);
            this.numMinKraj.TabIndex = 33;
            // 
            // numHPoc
            // 
            this.numHPoc.Location = new System.Drawing.Point(239, 131);
            this.numHPoc.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHPoc.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numHPoc.Name = "numHPoc";
            this.numHPoc.Size = new System.Drawing.Size(59, 22);
            this.numHPoc.TabIndex = 34;
            this.numHPoc.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // numHKraj
            // 
            this.numHKraj.Location = new System.Drawing.Point(239, 184);
            this.numHKraj.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHKraj.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numHKraj.Name = "numHKraj";
            this.numHKraj.Size = new System.Drawing.Size(59, 22);
            this.numHKraj.TabIndex = 35;
            this.numHKraj.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "min";
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(171, 272);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(94, 36);
            this.btnDalje.TabIndex = 40;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(271, 272);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(94, 36);
            this.btnOdustani.TabIndex = 41;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // TimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 352);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numHKraj);
            this.Controls.Add(this.numHPoc);
            this.Controls.Add(this.numMinKraj);
            this.Controls.Add(this.numMinPoc);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimeForm";
            this.Text = "TimeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numMinPoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinKraj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHKraj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown numMinPoc;
        private System.Windows.Forms.NumericUpDown numMinKraj;
        private System.Windows.Forms.NumericUpDown numHPoc;
        private System.Windows.Forms.NumericUpDown numHKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Button btnOdustani;
    }
}