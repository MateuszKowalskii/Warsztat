namespace Warsztat_samochodowy.Okienka.OkienkaPracownicy
{
    partial class PracownikDodaj
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
            komunikat = new Label();
            telefon = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            dodaj = new Button();
            pesel = new TextBox();
            nazwisko = new TextBox();
            imie = new TextBox();
            label5 = new Label();
            rola = new TextBox();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(105, 396);
            komunikat.MinimumSize = new Size(400, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(400, 20);
            komunikat.TabIndex = 21;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // telefon
            // 
            telefon.Location = new Point(289, 273);
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 273);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 19;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 210);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 18;
            label3.Text = "PESEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 143);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 17;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 16;
            label1.Text = "Imię";
            // 
            // wroc
            // 
            wroc.Location = new Point(162, 432);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 15;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(320, 432);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(94, 29);
            dodaj.TabIndex = 14;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // pesel
            // 
            pesel.Location = new Point(290, 210);
            pesel.Name = "pesel";
            pesel.Size = new Size(125, 27);
            pesel.TabIndex = 13;
            pesel.TextChanged += pesel_TextChanged;
            // 
            // nazwisko
            // 
            nazwisko.Location = new Point(290, 143);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(125, 27);
            nazwisko.TabIndex = 12;
            // 
            // imie
            // 
            imie.Location = new Point(290, 69);
            imie.Name = "imie";
            imie.Size = new Size(125, 27);
            imie.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 340);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 22;
            label5.Text = "Rola";
            // 
            // rola
            // 
            rola.Location = new Point(289, 340);
            rola.Name = "rola";
            rola.Size = new Size(125, 27);
            rola.TabIndex = 23;
            // 
            // PracownikDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 511);
            Controls.Add(rola);
            Controls.Add(label5);
            Controls.Add(komunikat);
            Controls.Add(telefon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(dodaj);
            Controls.Add(pesel);
            Controls.Add(nazwisko);
            Controls.Add(imie);
            Name = "PracownikDodaj";
            Text = "PracownikDodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private TextBox telefon;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button dodaj;
        private TextBox pesel;
        private TextBox nazwisko;
        private TextBox imie;
        private Label label5;
        private TextBox rola;
    }
}