namespace Warsztat.Okienka.OkienkaPracownicy
{
    partial class PracownikEdytuj
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
            label5 = new Label();
            telefon = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            zmien = new Button();
            pesel = new TextBox();
            nazwisko = new TextBox();
            imie = new TextBox();
            label6 = new Label();
            rola = new TextBox();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(459, 160);
            komunikat.MinimumSize = new Size(200, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(200, 20);
            komunikat.TabIndex = 33;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 112);
            label5.Name = "label5";
            label5.Size = new Size(517, 20);
            label5.TabIndex = 32;
            label5.Text = "Ustaw nowe dane. Pola, których wartości nie chcesz zmieniać pozostaw puste";
            // 
            // telefon
            // 
            telefon.Location = new Point(269, 304);
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 31;
            telefon.TextChanged += telefon_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 304);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 30;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 36);
            label3.Name = "label3";
            label3.Size = new Size(387, 20);
            label3.TabIndex = 29;
            label3.Text = "Podaj nr. PESEL pracownika, którego dane chcesz zmienić";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 234);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 28;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 160);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 27;
            label1.Text = "Imię";
            // 
            // wroc
            // 
            wroc.Location = new Point(142, 435);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 26;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // zmien
            // 
            zmien.Location = new Point(300, 435);
            zmien.Name = "zmien";
            zmien.Size = new Size(94, 29);
            zmien.TabIndex = 25;
            zmien.Text = "Zmień";
            zmien.UseVisualStyleBackColor = true;
            zmien.Click += zmien_Click;
            // 
            // pesel
            // 
            pesel.Location = new Point(146, 69);
            pesel.Name = "pesel";
            pesel.Size = new Size(125, 27);
            pesel.TabIndex = 24;
            pesel.TextChanged += pesel_TextChanged;
            // 
            // nazwisko
            // 
            nazwisko.Location = new Point(269, 234);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(125, 27);
            nazwisko.TabIndex = 23;
            nazwisko.TextChanged += nazwisko_TextChanged;
            // 
            // imie
            // 
            imie.Location = new Point(269, 160);
            imie.Name = "imie";
            imie.Size = new Size(125, 27);
            imie.TabIndex = 22;
            imie.TextChanged += imie_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 364);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 34;
            label6.Text = "Rola";
            // 
            // rola
            // 
            rola.Location = new Point(269, 364);
            rola.Name = "rola";
            rola.Size = new Size(125, 27);
            rola.TabIndex = 35;
            rola.TextChanged += rola_TextChanged;
            // 
            // PracownikEdytuj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(rola);
            Controls.Add(label6);
            Controls.Add(komunikat);
            Controls.Add(label5);
            Controls.Add(telefon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(zmien);
            Controls.Add(pesel);
            Controls.Add(nazwisko);
            Controls.Add(imie);
            Name = "PracownikEdytuj";
            Text = "PracownikEdytuj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private Label label5;
        private TextBox telefon;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button zmien;
        private TextBox pesel;
        private TextBox nazwisko;
        private TextBox imie;
        private Label label6;
        private TextBox rola;
    }
}