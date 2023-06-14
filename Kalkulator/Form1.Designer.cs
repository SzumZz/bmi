namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mezczyzna = new System.Windows.Forms.RadioButton();
            this.kobieta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.waga = new System.Windows.Forms.NumericUpDown();
            this.wzrost = new System.Windows.Forms.NumericUpDown();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.lista_aktywnosc = new System.Windows.Forms.ComboBox();
            this.oblicz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            this.SuspendLayout();
            // 
            // mezczyzna
            // 
            this.mezczyzna.AutoSize = true;
            this.mezczyzna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mezczyzna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mezczyzna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mezczyzna.Location = new System.Drawing.Point(142, 42);
            this.mezczyzna.Name = "mezczyzna";
            this.mezczyzna.Size = new System.Drawing.Size(35, 19);
            this.mezczyzna.TabIndex = 0;
            this.mezczyzna.Text = "M";
            this.mezczyzna.UseVisualStyleBackColor = true;
            // 
            // kobieta
            // 
            this.kobieta.AutoSize = true;
            this.kobieta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kobieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kobieta.Location = new System.Drawing.Point(185, 42);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(32, 19);
            this.kobieta.TabIndex = 1;
            this.kobieta.Text = "K";
            this.kobieta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(74, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Płeć:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wiek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(74, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Waga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(74, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wzrost:";
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(142, 93);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(120, 20);
            this.waga.TabIndex = 7;
            this.waga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wzrost
            // 
            this.wzrost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wzrost.Location = new System.Drawing.Point(142, 119);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(120, 20);
            this.wzrost.TabIndex = 8;
            this.wzrost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wzrost.ValueChanged += new System.EventHandler(this.wzrost_ValueChanged);
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(142, 67);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(120, 20);
            this.wiek.TabIndex = 9;
            this.wiek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wiek.ValueChanged += new System.EventHandler(this.wiek_ValueChanged);
            // 
            // lista_aktywnosc
            // 
            this.lista_aktywnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lista_aktywnosc.FormattingEnabled = true;
            this.lista_aktywnosc.Items.AddRange(new object[] {
            "Brak aktywności",
            "Bardzo lekka aktywność (1 dzień w tygodniu)",
            "Lekka aktywność (2-3 dni w tygodniu)",
            "Średnia aktywność (4-5 dni w tygodniu)",
            "Duża aktywność (codziennie)",
            "Bardzo duża aktywność"});
            this.lista_aktywnosc.Location = new System.Drawing.Point(77, 145);
            this.lista_aktywnosc.Name = "lista_aktywnosc";
            this.lista_aktywnosc.Size = new System.Drawing.Size(185, 23);
            this.lista_aktywnosc.TabIndex = 11;
            this.lista_aktywnosc.Text = "Poziom aktywności fizycznej";
            // 
            // oblicz
            // 
            this.oblicz.BackColor = System.Drawing.Color.CornflowerBlue;
            this.oblicz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oblicz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.oblicz.Location = new System.Drawing.Point(77, 174);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(185, 29);
            this.oblicz.TabIndex = 12;
            this.oblicz.Text = "Oblicz";
            this.oblicz.UseVisualStyleBackColor = false;
            this.oblicz.Click += new System.EventHandler(this.oblicz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kalkulator BMI, CPM, PPM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(268, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(268, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(268, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "(18-99)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(254, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Trynka Mateusz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(361, 221);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.lista_aktywnosc);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kobieta);
            this.Controls.Add(this.mezczyzna);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            ((System.ComponentModel.ISupportInitialize)(this.waga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton mezczyzna;
        private System.Windows.Forms.RadioButton kobieta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown waga;
        private System.Windows.Forms.NumericUpDown wzrost;
        private System.Windows.Forms.NumericUpDown wiek;
        private System.Windows.Forms.ComboBox lista_aktywnosc;
        private System.Windows.Forms.Button oblicz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
    }
}

