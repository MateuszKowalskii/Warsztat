namespace Warsztat_samochodowy.Okienka.OkienkaKlienci
{
    partial class KlientWyszukaj
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
            znalezioneWyniki = new ListView();
            kolumnaImie = new ColumnHeader();
            kolumnaNazwisko = new ColumnHeader();
            kolumnaPESEL = new ColumnHeader();
            kolumnaTelefon = new ColumnHeader();
            wroc = new Button();
            szukaj = new Button();
            label1 = new Label();
            label2 = new Label();
            telefonWyszukaj = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            peselWyszukaj = new TextBox();
            nazwiskoWyszukaj = new TextBox();
            imieWyszukaj = new TextBox();
            sortowanie = new ListBox();
            label7 = new Label();
            komunikat = new Label();
            SuspendLayout();
            // 
            // znalezioneWyniki
            // 
            znalezioneWyniki.Columns.AddRange(new ColumnHeader[] { kolumnaImie, kolumnaNazwisko, kolumnaPESEL, kolumnaTelefon });
            znalezioneWyniki.FullRowSelect = true;
            znalezioneWyniki.GridLines = true;
            znalezioneWyniki.LabelWrap = false;
            znalezioneWyniki.Location = new Point(516, 27);
            znalezioneWyniki.Name = "znalezioneWyniki";
            znalezioneWyniki.Size = new Size(400, 411);
            znalezioneWyniki.TabIndex = 1;
            znalezioneWyniki.UseCompatibleStateImageBehavior = false;
            znalezioneWyniki.View = View.Details;
            // 
            // kolumnaImie
            // 
            kolumnaImie.Text = "Imie";
            kolumnaImie.Width = 100;
            // 
            // kolumnaNazwisko
            // 
            kolumnaNazwisko.Text = "Nazwisko";
            kolumnaNazwisko.Width = 100;
            // 
            // kolumnaPESEL
            // 
            kolumnaPESEL.Text = "PESEL";
            kolumnaPESEL.Width = 100;
            // 
            // kolumnaTelefon
            // 
            kolumnaTelefon.Text = "Telefon";
            kolumnaTelefon.Width = 100;
            // 
            // wroc
            // 
            wroc.Location = new Point(73, 409);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 6;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // szukaj
            // 
            szukaj.Location = new Point(231, 409);
            szukaj.Name = "szukaj";
            szukaj.Size = new Size(94, 29);
            szukaj.TabIndex = 5;
            szukaj.Text = "Szukaj";
            szukaj.UseVisualStyleBackColor = true;
            szukaj.Click += szukaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 31);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 7;
            label1.Text = "Podaj dane jakimi mają charakteryzować się wyniki";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 51);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 8;
            label2.Text = "W razie braku potrzeby pozostaw pole puste";
            // 
            // telefonWyszukaj
            // 
            telefonWyszukaj.Location = new Point(203, 306);
            telefonWyszukaj.Name = "telefonWyszukaj";
            telefonWyszukaj.Size = new Size(125, 27);
            telefonWyszukaj.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 306);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 16;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 243);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 15;
            label3.Text = "PESEL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 176);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 14;
            label5.Text = "Nazwisko";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 102);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 13;
            label6.Text = "Imię";
            // 
            // peselWyszukaj
            // 
            peselWyszukaj.Location = new Point(204, 243);
            peselWyszukaj.Name = "peselWyszukaj";
            peselWyszukaj.Size = new Size(125, 27);
            peselWyszukaj.TabIndex = 12;
            // 
            // nazwiskoWyszukaj
            // 
            nazwiskoWyszukaj.Location = new Point(204, 176);
            nazwiskoWyszukaj.Name = "nazwiskoWyszukaj";
            nazwiskoWyszukaj.Size = new Size(125, 27);
            nazwiskoWyszukaj.TabIndex = 11;
            // 
            // imieWyszukaj
            // 
            imieWyszukaj.Location = new Point(204, 102);
            imieWyszukaj.Name = "imieWyszukaj";
            imieWyszukaj.Size = new Size(125, 27);
            imieWyszukaj.TabIndex = 10;
            // 
            // sortowanie
            // 
            sortowanie.FormattingEnabled = true;
            sortowanie.ItemHeight = 20;
            sortowanie.Items.AddRange(new object[] { "Imiona", "Nazwiska", "PESEL-e", "Telefony" });
            sortowanie.Location = new Point(378, 243);
            sortowanie.Name = "sortowanie";
            sortowanie.Size = new Size(98, 104);
            sortowanie.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(378, 204);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 19;
            label7.Text = "Sortuj wg.";
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(74, 359);
            komunikat.MinimumSize = new Size(330, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(330, 20);
            komunikat.TabIndex = 20;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KlientWyszukaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(komunikat);
            Controls.Add(label7);
            Controls.Add(sortowanie);
            Controls.Add(telefonWyszukaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(peselWyszukaj);
            Controls.Add(nazwiskoWyszukaj);
            Controls.Add(imieWyszukaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(szukaj);
            Controls.Add(znalezioneWyniki);
            Name = "KlientWyszukaj";
            Text = "KlientWyszukaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView znalezioneWyniki;
        private Button wroc;
        private Button szukaj;
        private Label label1;
        private Label label2;
        private TextBox telefonWyszukaj;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox peselWyszukaj;
        private TextBox nazwiskoWyszukaj;
        private TextBox imieWyszukaj;
        private ListBox sortowanie;
        private Label label7;
        private Label komunikat;
        private ColumnHeader kolumnaImie;
        private ColumnHeader kolumnaNazwisko;
        private ColumnHeader kolumnaPESEL;
        private ColumnHeader kolumnaTelefon;
    }
}