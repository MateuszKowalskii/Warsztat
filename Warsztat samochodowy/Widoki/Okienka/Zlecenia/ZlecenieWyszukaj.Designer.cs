namespace Warsztat_samochodowy.Okienka.OkienkaZlecenia
{
    partial class ZlecenieWyszukaj
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
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            szukaj = new Button();
            znalezioneWyniki = new ListView();
            kolumnaPESEL = new ColumnHeader();
            kolumnaId = new ColumnHeader();
            kolumnaOplata = new ColumnHeader();
            kolumnaStatus = new ColumnHeader();
            kolumnaData = new ColumnHeader();
            statusWyszukaj = new ComboBox();
            label3 = new Label();
            idWyszukaj = new TextBox();
            pesel = new TextBox();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(32, 407);
            komunikat.MinimumSize = new Size(330, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(330, 20);
            komunikat.TabIndex = 56;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 248);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 55;
            label7.Text = "Sortuj wg.";
            // 
            // sortowanie
            // 
            sortowanie.FormattingEnabled = true;
            sortowanie.ItemHeight = 20;
            sortowanie.Items.AddRange(new object[] { "ID", "Opłaty", "PESEL-e", "Daty" });
            sortowanie.Location = new Point(32, 287);
            sortowanie.Name = "sortowanie";
            sortowanie.Size = new Size(98, 84);
            sortowanie.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 203);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 50;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 150);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 49;
            label6.Text = "PESEL zleceniodawcy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 56);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 45;
            label2.Text = "W razie braku potrzeby pozostaw pole puste";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 44;
            label1.Text = "Podaj dane jakimi mają charakteryzować się wyniki";
            // 
            // wroc
            // 
            wroc.Location = new Point(31, 457);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 43;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // szukaj
            // 
            szukaj.Location = new Point(189, 457);
            szukaj.Name = "szukaj";
            szukaj.Size = new Size(94, 29);
            szukaj.TabIndex = 42;
            szukaj.Text = "Szukaj";
            szukaj.UseVisualStyleBackColor = true;
            szukaj.Click += szukaj_Click;
            // 
            // znalezioneWyniki
            // 
            znalezioneWyniki.Columns.AddRange(new ColumnHeader[] { kolumnaPESEL, kolumnaId, kolumnaOplata, kolumnaStatus, kolumnaData });
            znalezioneWyniki.FullRowSelect = true;
            znalezioneWyniki.GridLines = true;
            znalezioneWyniki.LabelWrap = false;
            znalezioneWyniki.Location = new Point(425, 36);
            znalezioneWyniki.Name = "znalezioneWyniki";
            znalezioneWyniki.Size = new Size(550, 450);
            znalezioneWyniki.TabIndex = 41;
            znalezioneWyniki.UseCompatibleStateImageBehavior = false;
            znalezioneWyniki.View = View.Details;
            // 
            // kolumnaPESEL
            // 
            kolumnaPESEL.Text = "PESEL";
            kolumnaPESEL.Width = 100;
            // 
            // kolumnaId
            // 
            kolumnaId.Text = "ID";
            kolumnaId.Width = 100;
            // 
            // kolumnaOplata
            // 
            kolumnaOplata.Text = "Opłata";
            kolumnaOplata.Width = 100;
            // 
            // kolumnaStatus
            // 
            kolumnaStatus.Text = "Zakończone";
            kolumnaStatus.Width = 100;
            // 
            // kolumnaData
            // 
            kolumnaData.Text = "Data realizacji";
            kolumnaData.Width = 150;
            // 
            // statusWyszukaj
            // 
            statusWyszukaj.FormattingEnabled = true;
            statusWyszukaj.Items.AddRange(new object[] { "Zakończone", "W trakcie" });
            statusWyszukaj.Location = new Point(190, 206);
            statusWyszukaj.Name = "statusWyszukaj";
            statusWyszukaj.Size = new Size(157, 28);
            statusWyszukaj.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 97);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 59;
            label3.Text = "ID zlecenia";
            // 
            // idWyszukaj
            // 
            idWyszukaj.Location = new Point(189, 94);
            idWyszukaj.Name = "idWyszukaj";
            idWyszukaj.Size = new Size(157, 27);
            idWyszukaj.TabIndex = 60;
            // 
            // pesel
            // 
            pesel.Location = new Point(191, 147);
            pesel.Name = "pesel";
            pesel.Size = new Size(156, 27);
            pesel.TabIndex = 61;
            // 
            // ZlecenieWyszukaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 518);
            Controls.Add(pesel);
            Controls.Add(idWyszukaj);
            Controls.Add(label3);
            Controls.Add(statusWyszukaj);
            Controls.Add(komunikat);
            Controls.Add(label7);
            Controls.Add(sortowanie);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(szukaj);
            Controls.Add(znalezioneWyniki);
            Name = "ZlecenieWyszukaj";
            Text = "ZlecenieWyszukaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private Label label7;
        private ListBox sortowanie;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button szukaj;
        private ListView znalezioneWyniki;
        private ColumnHeader kolumnaId;
        private ColumnHeader kolumnaOplata;
        private ColumnHeader kolumnaPESEL;
        private ColumnHeader kolumnaStatus;
        private ColumnHeader kolumnaData;
        private Label label3;
        private TextBox idWyszukaj;
        private TextBox pesel;
        public ComboBox statusWyszukaj;
    }
}