namespace Warsztat.Okienka.OkienkaDostawcy
{
    partial class DostawcaWyszukaj
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
            telefonWyszukaj = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            emailWyszukaj = new TextBox();
            nazwaWyszukaj = new TextBox();
            idWyszukaj = new TextBox();
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            szukaj = new Button();
            znalezioneWyniki = new ListView();
            kolumnaID = new ColumnHeader();
            kolumnaNazwa = new ColumnHeader();
            kolumnaEmail = new ColumnHeader();
            kolumnaTelefon = new ColumnHeader();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(55, 352);
            komunikat.MinimumSize = new Size(330, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(330, 20);
            komunikat.TabIndex = 36;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(359, 197);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 35;
            label7.Text = "Sortuj wg.";
            // 
            // sortowanie
            // 
            sortowanie.FormattingEnabled = true;
            sortowanie.ItemHeight = 20;
            sortowanie.Items.AddRange(new object[] { "ID", "Nazwy", "E-maile", "Telefony" });
            sortowanie.Location = new Point(359, 236);
            sortowanie.Name = "sortowanie";
            sortowanie.Size = new Size(98, 104);
            sortowanie.TabIndex = 34;
            // 
            // telefonWyszukaj
            // 
            telefonWyszukaj.Location = new Point(184, 299);
            telefonWyszukaj.Name = "telefonWyszukaj";
            telefonWyszukaj.Size = new Size(125, 27);
            telefonWyszukaj.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 299);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 32;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 236);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 31;
            label3.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 169);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 30;
            label5.Text = "Nazwa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 95);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 29;
            label6.Text = "ID";
            // 
            // emailWyszukaj
            // 
            emailWyszukaj.Location = new Point(185, 236);
            emailWyszukaj.Name = "emailWyszukaj";
            emailWyszukaj.Size = new Size(125, 27);
            emailWyszukaj.TabIndex = 28;
            // 
            // nazwaWyszukaj
            // 
            nazwaWyszukaj.Location = new Point(185, 169);
            nazwaWyszukaj.Name = "nazwaWyszukaj";
            nazwaWyszukaj.Size = new Size(125, 27);
            nazwaWyszukaj.TabIndex = 27;
            // 
            // idWyszukaj
            // 
            idWyszukaj.Location = new Point(185, 95);
            idWyszukaj.Name = "idWyszukaj";
            idWyszukaj.Size = new Size(125, 27);
            idWyszukaj.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 44);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 25;
            label2.Text = "W razie braku potrzeby pozostaw pole puste";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 24);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 24;
            label1.Text = "Podaj dane jakimi mają charakteryzować się wyniki";
            // 
            // wroc
            // 
            wroc.Location = new Point(54, 402);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 23;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // szukaj
            // 
            szukaj.Location = new Point(212, 402);
            szukaj.Name = "szukaj";
            szukaj.Size = new Size(94, 29);
            szukaj.TabIndex = 22;
            szukaj.Text = "Szukaj";
            szukaj.UseVisualStyleBackColor = true;
            szukaj.Click += szukaj_Click;
            // 
            // znalezioneWyniki
            // 
            znalezioneWyniki.Columns.AddRange(new ColumnHeader[] { kolumnaID, kolumnaNazwa, kolumnaEmail, kolumnaTelefon });
            znalezioneWyniki.FullRowSelect = true;
            znalezioneWyniki.GridLines = true;
            znalezioneWyniki.LabelWrap = false;
            znalezioneWyniki.Location = new Point(497, 20);
            znalezioneWyniki.Name = "znalezioneWyniki";
            znalezioneWyniki.Size = new Size(500, 411);
            znalezioneWyniki.TabIndex = 21;
            znalezioneWyniki.UseCompatibleStateImageBehavior = false;
            znalezioneWyniki.View = View.Details;
            // 
            // kolumnaID
            // 
            kolumnaID.Text = "ID";
            kolumnaID.Width = 100;
            // 
            // kolumnaNazwa
            // 
            kolumnaNazwa.Text = "Nazwa";
            kolumnaNazwa.Width = 100;
            // 
            // kolumnaEmail
            // 
            kolumnaEmail.Text = "E-mail";
            kolumnaEmail.Width = 200;
            // 
            // kolumnaTelefon
            // 
            kolumnaTelefon.Text = "Telefon";
            kolumnaTelefon.Width = 100;
            // 
            // DostawcaWyszukaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 450);
            Controls.Add(komunikat);
            Controls.Add(label7);
            Controls.Add(sortowanie);
            Controls.Add(telefonWyszukaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(emailWyszukaj);
            Controls.Add(nazwaWyszukaj);
            Controls.Add(idWyszukaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(szukaj);
            Controls.Add(znalezioneWyniki);
            Name = "DostawcaWyszukaj";
            Text = "DostawcaWyszukaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private Label label7;
        private ListBox sortowanie;
        private TextBox telefonWyszukaj;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox emailWyszukaj;
        private TextBox nazwaWyszukaj;
        private TextBox idWyszukaj;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button szukaj;
        private ListView znalezioneWyniki;
        private ColumnHeader kolumnaID;
        private ColumnHeader kolumnaNazwa;
        private ColumnHeader kolumnaEmail;
        private ColumnHeader kolumnaTelefon;
    }
}