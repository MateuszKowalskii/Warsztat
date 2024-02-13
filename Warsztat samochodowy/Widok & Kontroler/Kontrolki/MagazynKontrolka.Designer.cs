namespace Warsztat
{
    partial class MagazynKontrolka
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new Button();
            label1 = new Label();
            wyszukajZamowienie = new Button();
            dodajZamowienie = new Button();
            stanMagazynu = new Button();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Location = new Point(232, 318);
            menu.Name = "menu";
            menu.Size = new Size(167, 29);
            menu.TabIndex = 2;
            menu.Text = "<< Menu";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 48);
            label1.Name = "label1";
            label1.Size = new Size(181, 46);
            label1.TabIndex = 15;
            label1.Text = "MAGAZYN";
            // 
            // wyszukajZamowienie
            // 
            wyszukajZamowienie.Location = new Point(232, 250);
            wyszukajZamowienie.Name = "wyszukajZamowienie";
            wyszukajZamowienie.Size = new Size(167, 29);
            wyszukajZamowienie.TabIndex = 13;
            wyszukajZamowienie.Text = "Wyszukaj zamówienie";
            wyszukajZamowienie.UseVisualStyleBackColor = true;
            wyszukajZamowienie.Click += wyszukajZamowienie_Click;
            // 
            // dodajZamowienie
            // 
            dodajZamowienie.Location = new Point(232, 125);
            dodajZamowienie.Name = "dodajZamowienie";
            dodajZamowienie.Size = new Size(167, 29);
            dodajZamowienie.TabIndex = 11;
            dodajZamowienie.Text = "Dodaj zamówienie";
            dodajZamowienie.UseVisualStyleBackColor = true;
            dodajZamowienie.Click += dodajZamowienie_Click;
            // 
            // stanMagazynu
            // 
            stanMagazynu.Location = new Point(232, 190);
            stanMagazynu.Name = "stanMagazynu";
            stanMagazynu.Size = new Size(167, 29);
            stanMagazynu.TabIndex = 16;
            stanMagazynu.Text = "Stan magazynu";
            stanMagazynu.UseVisualStyleBackColor = true;
            stanMagazynu.Click += stanMagazynu_Click;
            // 
            // MagazynKontrolka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(stanMagazynu);
            Controls.Add(label1);
            Controls.Add(wyszukajZamowienie);
            Controls.Add(dodajZamowienie);
            Controls.Add(menu);
            Name = "MagazynKontrolka";
            Size = new Size(631, 395);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menu;
        private Label label1;
        private Button wyszukajZamowienie;
        private Button dodajZamowienie;
        private Button stanMagazynu;
    }
}
