namespace Warsztat_samochodowy.Okienka.OkienkaMagazyn
{
    partial class CzescWyszukaj
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
            label7 = new Label();
            sortowanie = new ListBox();
            label5 = new Label();
            label6 = new Label();
            kodWyszukaj = new TextBox();
            nazwaWyszukaj = new TextBox();
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            szukaj = new Button();
            znalezioneWyniki = new ListView();
            kolumnaNazwa = new ColumnHeader();
            kolumnaKod = new ColumnHeader();
            kolumnaIlosc = new ColumnHeader();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(55, 352);
            komunikat.MinimumSize = new Size(330, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(330, 20);
            komunikat.TabIndex = 50;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 96);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 49;
            label7.Text = "Sortuj wg.";
            // 
            // sortowanie
            // 
            sortowanie.FormattingEnabled = true;
            sortowanie.ItemHeight = 20;
            sortowanie.Items.AddRange(new object[] { "Nazwa", "Kod", "Ilość" });
            sortowanie.Location = new Point(360, 135);
            sortowanie.Name = "sortowanie";
            sortowanie.Size = new Size(98, 104);
            sortowanie.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 209);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 46;
            label5.Text = "Kod produktu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 135);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 45;
            label6.Text = "Nazwa produktu";
            // 
            // kodWyszukaj
            // 
            kodWyszukaj.Location = new Point(181, 209);
            kodWyszukaj.Name = "kodWyszukaj";
            kodWyszukaj.Size = new Size(125, 27);
            kodWyszukaj.TabIndex = 43;
            // 
            // nazwaWyszukaj
            // 
            nazwaWyszukaj.Location = new Point(181, 135);
            nazwaWyszukaj.Name = "nazwaWyszukaj";
            nazwaWyszukaj.Size = new Size(125, 27);
            nazwaWyszukaj.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 44);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 41;
            label2.Text = "W razie braku potrzeby pozostaw pole puste";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 24);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 40;
            label1.Text = "Podaj dane jakimi mają charakteryzować się wyniki";
            // 
            // wroc
            // 
            wroc.Location = new Point(54, 402);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 39;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // szukaj
            // 
            szukaj.Location = new Point(212, 402);
            szukaj.Name = "szukaj";
            szukaj.Size = new Size(94, 29);
            szukaj.TabIndex = 38;
            szukaj.Text = "Szukaj";
            szukaj.UseVisualStyleBackColor = true;
            szukaj.Click += szukaj_Click;
            // 
            // znalezioneWyniki
            // 
            znalezioneWyniki.Columns.AddRange(new ColumnHeader[] { kolumnaNazwa, kolumnaKod, kolumnaIlosc });
            znalezioneWyniki.FullRowSelect = true;
            znalezioneWyniki.GridLines = true;
            znalezioneWyniki.LabelWrap = false;
            znalezioneWyniki.Location = new Point(497, 20);
            znalezioneWyniki.Name = "znalezioneWyniki";
            znalezioneWyniki.Size = new Size(300, 411);
            znalezioneWyniki.TabIndex = 37;
            znalezioneWyniki.UseCompatibleStateImageBehavior = false;
            znalezioneWyniki.View = View.Details;
            // 
            // kolumnaNazwa
            // 
            kolumnaNazwa.Text = "Produkt";
            kolumnaNazwa.Width = 100;
            // 
            // kolumnaKod
            // 
            kolumnaKod.Text = "Kod";
            kolumnaKod.Width = 100;
            // 
            // kolumnaIlosc
            // 
            kolumnaIlosc.Text = "Ilość";
            kolumnaIlosc.Width = 100;
            // 
            // CzescWyszukaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
            Controls.Add(komunikat);
            Controls.Add(label7);
            Controls.Add(sortowanie);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(kodWyszukaj);
            Controls.Add(nazwaWyszukaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(szukaj);
            Controls.Add(znalezioneWyniki);
            Name = "CzescWyszukaj";
            Text = "CzescWyszukaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private Label label7;
        private ListBox sortowanie;
        private Label label5;
        private Label label6;
        private TextBox kodWyszukaj;
        private TextBox nazwaWyszukaj;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button szukaj;
        private ListView znalezioneWyniki;
        private ColumnHeader kolumnaNazwa;
        private ColumnHeader kolumnaKod;
        private ColumnHeader kolumnaIlosc;
    }
}