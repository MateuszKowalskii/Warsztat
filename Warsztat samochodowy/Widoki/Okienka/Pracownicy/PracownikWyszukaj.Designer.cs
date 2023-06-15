namespace Warsztat_samochodowy.Okienka.OkienkaPracownicy
{
    partial class PracownikWyszukaj
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
            rolaWyszukaj = new TextBox();
            label8 = new Label();
            komunikat = new Label();
            label7 = new Label();
            sortowanie = new ListBox();
            telefonWyszukaj = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            peselWyszukaj = new TextBox();
            nazwiskoWyszukaj = new TextBox();
            imieWyszukaj = new TextBox();
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            szukaj = new Button();
            znalezioneWyniki = new ListView();
            kolumnaImie = new ColumnHeader();
            kolumnaNazwisko = new ColumnHeader();
            kolumnaPESEL = new ColumnHeader();
            kolumnaTelefon = new ColumnHeader();
            kolumnaRola = new ColumnHeader();
            SuspendLayout();
            // 
            // rolaWyszukaj
            // 
            rolaWyszukaj.Location = new Point(162, 368);
            rolaWyszukaj.Name = "rolaWyszukaj";
            rolaWyszukaj.Size = new Size(125, 27);
            rolaWyszukaj.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 368);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 39;
            label8.Text = "Rola";
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(37, 401);
            komunikat.MinimumSize = new Size(330, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(330, 20);
            komunikat.TabIndex = 38;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 203);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 37;
            label7.Text = "Sortuj wg.";
            // 
            // sortowanie
            // 
            sortowanie.FormattingEnabled = true;
            sortowanie.ItemHeight = 20;
            sortowanie.Items.AddRange(new object[] { "Imiona", "Nazwiska", "PESEL-e", "Telefony", "Role" });
            sortowanie.Location = new Point(337, 242);
            sortowanie.Name = "sortowanie";
            sortowanie.Size = new Size(98, 104);
            sortowanie.TabIndex = 36;
            // 
            // telefonWyszukaj
            // 
            telefonWyszukaj.Location = new Point(162, 305);
            telefonWyszukaj.Name = "telefonWyszukaj";
            telefonWyszukaj.Size = new Size(125, 27);
            telefonWyszukaj.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 305);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 34;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 242);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 33;
            label3.Text = "PESEL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 175);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 32;
            label5.Text = "Nazwisko";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 101);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 31;
            label6.Text = "Imię";
            // 
            // peselWyszukaj
            // 
            peselWyszukaj.Location = new Point(163, 242);
            peselWyszukaj.Name = "peselWyszukaj";
            peselWyszukaj.Size = new Size(125, 27);
            peselWyszukaj.TabIndex = 30;
            // 
            // nazwiskoWyszukaj
            // 
            nazwiskoWyszukaj.Location = new Point(163, 175);
            nazwiskoWyszukaj.Name = "nazwiskoWyszukaj";
            nazwiskoWyszukaj.Size = new Size(125, 27);
            nazwiskoWyszukaj.TabIndex = 29;
            // 
            // imieWyszukaj
            // 
            imieWyszukaj.Location = new Point(163, 101);
            imieWyszukaj.Name = "imieWyszukaj";
            imieWyszukaj.Size = new Size(125, 27);
            imieWyszukaj.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 50);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 27;
            label2.Text = "W razie braku potrzeby pozostaw pole puste";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 26;
            label1.Text = "Podaj dane jakimi mają charakteryzować się wyniki";
            // 
            // wroc
            // 
            wroc.Location = new Point(36, 451);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 25;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // szukaj
            // 
            szukaj.Location = new Point(194, 451);
            szukaj.Name = "szukaj";
            szukaj.Size = new Size(94, 29);
            szukaj.TabIndex = 24;
            szukaj.Text = "Szukaj";
            szukaj.UseVisualStyleBackColor = true;
            szukaj.Click += szukaj_Click;
            // 
            // znalezioneWyniki
            // 
            znalezioneWyniki.Columns.AddRange(new ColumnHeader[] { kolumnaImie, kolumnaNazwisko, kolumnaPESEL, kolumnaTelefon, kolumnaRola });
            znalezioneWyniki.FullRowSelect = true;
            znalezioneWyniki.GridLines = true;
            znalezioneWyniki.LabelWrap = false;
            znalezioneWyniki.Location = new Point(475, 26);
            znalezioneWyniki.Name = "znalezioneWyniki";
            znalezioneWyniki.Size = new Size(500, 454);
            znalezioneWyniki.TabIndex = 23;
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
            // kolumnaRola
            // 
            kolumnaRola.Text = "Rola";
            kolumnaRola.Width = 100;
            // 
            // PracownikWyszukaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 518);
            Controls.Add(rolaWyszukaj);
            Controls.Add(label8);
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
            Name = "PracownikWyszukaj";
            Text = "PracownikWyszukaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rolaWyszukaj;
        private Label label8;
        private Label komunikat;
        private Label label7;
        private ListBox sortowanie;
        private TextBox telefonWyszukaj;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox peselWyszukaj;
        private TextBox nazwiskoWyszukaj;
        private TextBox imieWyszukaj;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button szukaj;
        private ListView znalezioneWyniki;
        private ColumnHeader kolumnaImie;
        private ColumnHeader kolumnaNazwisko;
        private ColumnHeader kolumnaPESEL;
        private ColumnHeader kolumnaTelefon;
        private ColumnHeader kolumnaRola;
    }
}