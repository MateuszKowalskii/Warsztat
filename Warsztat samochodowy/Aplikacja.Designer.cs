namespace Warsztat_samochodowy
{
    partial class Aplikacja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelGlowny = new Panel();
            zakoncz = new Button();
            powiadomienia = new ListBox();
            magazyn = new Button();
            dostawcy = new Button();
            zlecenia = new Button();
            pracownicy = new Button();
            klienci = new Button();
            klienciStrona = new KlienciKontrolka();
            pracownicyStrona = new PracownicyKontrolka();
            dostawcyStrona = new DostawcyKontrolka();
            magazynStrona = new MagazynKontrolka();
            zleceniaStrona = new ZleceniaKontrolka();
            panelGlowny.SuspendLayout();
            SuspendLayout();
            // 
            // panelGlowny
            // 
            panelGlowny.Controls.Add(zakoncz);
            panelGlowny.Controls.Add(powiadomienia);
            panelGlowny.Controls.Add(magazyn);
            panelGlowny.Controls.Add(dostawcy);
            panelGlowny.Controls.Add(zlecenia);
            panelGlowny.Controls.Add(pracownicy);
            panelGlowny.Controls.Add(klienci);
            panelGlowny.Location = new Point(58, 49);
            panelGlowny.Name = "panelGlowny";
            panelGlowny.Size = new Size(673, 355);
            panelGlowny.TabIndex = 0;
            // 
            // zakoncz
            // 
            zakoncz.Location = new Point(225, 261);
            zakoncz.Name = "zakoncz";
            zakoncz.Size = new Size(128, 45);
            zakoncz.TabIndex = 30;
            zakoncz.Text = "Zakończ";
            zakoncz.UseVisualStyleBackColor = true;
            zakoncz.Click += zakoncz_Click;
            // 
            // powiadomienia
            // 
            powiadomienia.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            powiadomienia.FormattingEnabled = true;
            powiadomienia.ItemHeight = 15;
            powiadomienia.Location = new Point(384, 45);
            powiadomienia.Name = "powiadomienia";
            powiadomienia.Size = new Size(276, 259);
            powiadomienia.TabIndex = 29;
            // 
            // magazyn
            // 
            magazyn.Location = new Point(31, 261);
            magazyn.Name = "magazyn";
            magazyn.Size = new Size(129, 45);
            magazyn.TabIndex = 28;
            magazyn.Text = "Magazyn";
            magazyn.UseVisualStyleBackColor = true;
            magazyn.Click += magazyn_Click;
            // 
            // dostawcy
            // 
            dostawcy.Location = new Point(224, 153);
            dostawcy.Name = "dostawcy";
            dostawcy.Size = new Size(129, 45);
            dostawcy.TabIndex = 27;
            dostawcy.Text = "Dostawcy";
            dostawcy.UseVisualStyleBackColor = true;
            dostawcy.Click += dostawcy_Click;
            // 
            // zlecenia
            // 
            zlecenia.Location = new Point(31, 153);
            zlecenia.Name = "zlecenia";
            zlecenia.Size = new Size(129, 45);
            zlecenia.TabIndex = 26;
            zlecenia.Text = "Zlecenia";
            zlecenia.UseVisualStyleBackColor = true;
            zlecenia.Click += zlecenia_Click;
            // 
            // pracownicy
            // 
            pracownicy.Location = new Point(224, 45);
            pracownicy.Name = "pracownicy";
            pracownicy.Size = new Size(129, 45);
            pracownicy.TabIndex = 25;
            pracownicy.Text = "Pracownicy";
            pracownicy.UseVisualStyleBackColor = true;
            pracownicy.Click += pracownicy_Click;
            // 
            // klienci
            // 
            klienci.Location = new Point(31, 45);
            klienci.Name = "klienci";
            klienci.Size = new Size(129, 45);
            klienci.TabIndex = 24;
            klienci.Text = "Klienci";
            klienci.UseVisualStyleBackColor = true;
            klienci.Click += klienci_Click;
            // 
            // klienciStrona
            // 
            klienciStrona.Location = new Point(58, 49);
            klienciStrona.Name = "klienciStrona";
            klienciStrona.Size = new Size(673, 355);
            klienciStrona.TabIndex = 1;
            klienciStrona.Visible = false;
            // 
            // pracownicyStrona
            // 
            pracownicyStrona.Location = new Point(58, 49);
            pracownicyStrona.Name = "pracownicyStrona";
            pracownicyStrona.Size = new Size(673, 355);
            pracownicyStrona.TabIndex = 31;
            pracownicyStrona.Visible = false;
            // 
            // dostawcyStrona
            // 
            dostawcyStrona.Location = new Point(58, 49);
            dostawcyStrona.Name = "dostawcyStrona";
            dostawcyStrona.Size = new Size(673, 355);
            dostawcyStrona.TabIndex = 32;
            dostawcyStrona.Visible = false;
            // 
            // magazynStrona
            // 
            magazynStrona.Location = new Point(58, 49);
            magazynStrona.Name = "magazynStrona";
            magazynStrona.Size = new Size(673, 355);
            magazynStrona.TabIndex = 33;
            magazynStrona.Visible = false;
            // 
            // zleceniaStrona
            // 
            zleceniaStrona.Location = new Point(58, 49);
            zleceniaStrona.Name = "zleceniaStrona";
            zleceniaStrona.Size = new Size(673, 355);
            zleceniaStrona.TabIndex = 34;
            zleceniaStrona.Visible = false;
            // 
            // Aplikacja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panelGlowny);
            Controls.Add(pracownicyStrona);
            Controls.Add(klienciStrona);
            Controls.Add(zleceniaStrona);
            Controls.Add(magazynStrona);
            Controls.Add(dostawcyStrona);
            Name = "Aplikacja";
            Text = "Auto Repair";
            Load += Aplikacja_Load;
            panelGlowny.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panelGlowny;
        public ListBox powiadomienia;
        private Button magazyn;
        private Button dostawcy;
        private Button zlecenia;
        private Button pracownicy;
        private Button klienci;
        public KlienciKontrolka klienciStrona;
        public PracownicyKontrolka pracownicyStrona;
        public DostawcyKontrolka dostawcyStrona;
        public MagazynKontrolka magazynStrona;
        public ZleceniaKontrolka zleceniaStrona;
        private Button zakoncz;
    }
}