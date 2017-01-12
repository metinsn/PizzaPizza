namespace PizzaPizza_OOP
{
    partial class Form1
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
            this.CBoxPizzaBoyut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxPizzaTuru = new System.Windows.Forms.ComboBox();
            this.GBoxPizzaKenar = new System.Windows.Forms.GroupBox();
            this.GBoXMalzemeler = new System.Windows.Forms.GroupBox();
            this.RadioBtnInceKenar = new System.Windows.Forms.RadioButton();
            this.RadioBtnKalinKenar = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LstBoxSiparis = new System.Windows.Forms.ListBox();
            this.BtnOdemeYap = new System.Windows.Forms.Button();
            this.TxtToplamTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumPizzaAdet = new System.Windows.Forms.NumericUpDown();
            this.GBoxPizzaKenar.SuspendLayout();
            this.GBoXMalzemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPizzaAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // CBoxPizzaBoyut
            // 
            this.CBoxPizzaBoyut.FormattingEnabled = true;
            this.CBoxPizzaBoyut.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük",
            "Maxi"});
            this.CBoxPizzaBoyut.Location = new System.Drawing.Point(67, 30);
            this.CBoxPizzaBoyut.Name = "CBoxPizzaBoyut";
            this.CBoxPizzaBoyut.Size = new System.Drawing.Size(148, 21);
            this.CBoxPizzaBoyut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boyut :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizzalar :";
            // 
            // CBoxPizzaTuru
            // 
            this.CBoxPizzaTuru.FormattingEnabled = true;
            this.CBoxPizzaTuru.Items.AddRange(new object[] {
            "Klasik",
            "Karışık",
            "Akdeniz",
            "Karadeniz"});
            this.CBoxPizzaTuru.Location = new System.Drawing.Point(67, 67);
            this.CBoxPizzaTuru.Name = "CBoxPizzaTuru";
            this.CBoxPizzaTuru.Size = new System.Drawing.Size(148, 21);
            this.CBoxPizzaTuru.TabIndex = 2;
            // 
            // GBoxPizzaKenar
            // 
            this.GBoxPizzaKenar.Controls.Add(this.RadioBtnKalinKenar);
            this.GBoxPizzaKenar.Controls.Add(this.RadioBtnInceKenar);
            this.GBoxPizzaKenar.Location = new System.Drawing.Point(15, 121);
            this.GBoxPizzaKenar.Name = "GBoxPizzaKenar";
            this.GBoxPizzaKenar.Size = new System.Drawing.Size(200, 56);
            this.GBoxPizzaKenar.TabIndex = 4;
            this.GBoxPizzaKenar.TabStop = false;
            this.GBoxPizzaKenar.Text = "Pizza Kenarı";
            // 
            // GBoXMalzemeler
            // 
            this.GBoXMalzemeler.Controls.Add(this.checkBox4);
            this.GBoXMalzemeler.Controls.Add(this.checkBox3);
            this.GBoXMalzemeler.Controls.Add(this.checkBox2);
            this.GBoXMalzemeler.Controls.Add(this.checkBox1);
            this.GBoXMalzemeler.Location = new System.Drawing.Point(15, 183);
            this.GBoXMalzemeler.Name = "GBoXMalzemeler";
            this.GBoXMalzemeler.Size = new System.Drawing.Size(200, 83);
            this.GBoXMalzemeler.TabIndex = 5;
            this.GBoXMalzemeler.TabStop = false;
            this.GBoXMalzemeler.Text = "Malzemeler";
            // 
            // RadioBtnInceKenar
            // 
            this.RadioBtnInceKenar.AutoSize = true;
            this.RadioBtnInceKenar.Location = new System.Drawing.Point(6, 19);
            this.RadioBtnInceKenar.Name = "RadioBtnInceKenar";
            this.RadioBtnInceKenar.Size = new System.Drawing.Size(77, 17);
            this.RadioBtnInceKenar.TabIndex = 6;
            this.RadioBtnInceKenar.TabStop = true;
            this.RadioBtnInceKenar.Text = "İnce Kenar";
            this.RadioBtnInceKenar.UseVisualStyleBackColor = true;
            // 
            // RadioBtnKalinKenar
            // 
            this.RadioBtnKalinKenar.AutoSize = true;
            this.RadioBtnKalinKenar.Location = new System.Drawing.Point(96, 19);
            this.RadioBtnKalinKenar.Name = "RadioBtnKalinKenar";
            this.RadioBtnKalinKenar.Size = new System.Drawing.Size(79, 17);
            this.RadioBtnKalinKenar.TabIndex = 7;
            this.RadioBtnKalinKenar.TabStop = true;
            this.RadioBtnKalinKenar.Text = "Kalın Kenar";
            this.RadioBtnKalinKenar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Mısır";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Salam";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(98, 26);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Sucuk";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(98, 49);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(55, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Peynir";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet :";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(130, 269);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(85, 23);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LstBoxSiparis
            // 
            this.LstBoxSiparis.FormattingEnabled = true;
            this.LstBoxSiparis.Location = new System.Drawing.Point(233, 30);
            this.LstBoxSiparis.Name = "LstBoxSiparis";
            this.LstBoxSiparis.Size = new System.Drawing.Size(251, 199);
            this.LstBoxSiparis.TabIndex = 9;
            this.LstBoxSiparis.DoubleClick += new System.EventHandler(this.LstBoxSiparis_DoubleClick);
            // 
            // BtnOdemeYap
            // 
            this.BtnOdemeYap.BackColor = System.Drawing.Color.Maroon;
            this.BtnOdemeYap.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOdemeYap.Location = new System.Drawing.Point(233, 259);
            this.BtnOdemeYap.Name = "BtnOdemeYap";
            this.BtnOdemeYap.Size = new System.Drawing.Size(251, 33);
            this.BtnOdemeYap.TabIndex = 12;
            this.BtnOdemeYap.Text = "ÖDEME";
            this.BtnOdemeYap.UseVisualStyleBackColor = false;
            // 
            // TxtToplamTutar
            // 
            this.TxtToplamTutar.Location = new System.Drawing.Point(418, 233);
            this.TxtToplamTutar.Name = "TxtToplamTutar";
            this.TxtToplamTutar.ReadOnly = true;
            this.TxtToplamTutar.Size = new System.Drawing.Size(65, 20);
            this.TxtToplamTutar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Toplam Tutar :";
            // 
            // NumPizzaAdet
            // 
            this.NumPizzaAdet.Location = new System.Drawing.Point(58, 272);
            this.NumPizzaAdet.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumPizzaAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPizzaAdet.Name = "NumPizzaAdet";
            this.NumPizzaAdet.Size = new System.Drawing.Size(66, 20);
            this.NumPizzaAdet.TabIndex = 13;
            this.NumPizzaAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 302);
            this.Controls.Add(this.NumPizzaAdet);
            this.Controls.Add(this.BtnOdemeYap);
            this.Controls.Add(this.TxtToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LstBoxSiparis);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GBoXMalzemeler);
            this.Controls.Add(this.GBoxPizzaKenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxPizzaTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxPizzaBoyut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBoxPizzaKenar.ResumeLayout(false);
            this.GBoxPizzaKenar.PerformLayout();
            this.GBoXMalzemeler.ResumeLayout(false);
            this.GBoXMalzemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPizzaAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxPizzaBoyut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxPizzaTuru;
        private System.Windows.Forms.GroupBox GBoxPizzaKenar;
        private System.Windows.Forms.GroupBox GBoXMalzemeler;
        private System.Windows.Forms.RadioButton RadioBtnKalinKenar;
        private System.Windows.Forms.RadioButton RadioBtnInceKenar;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ListBox LstBoxSiparis;
        private System.Windows.Forms.Button BtnOdemeYap;
        private System.Windows.Forms.TextBox TxtToplamTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumPizzaAdet;
    }
}

