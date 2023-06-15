namespace Warsztat_samochodowy
{
    partial class PracownicyKontrolka
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
            edytuj = new Button();
            wyszukaj = new Button();
            usun = new Button();
            dodaj = new Button();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Location = new Point(146, 316);
            menu.Name = "menu";
            menu.Size = new Size(94, 29);
            menu.TabIndex = 1;
            menu.Text = "<< Menu";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, 37);
            label1.Name = "label1";
            label1.Size = new Size(231, 46);
            label1.TabIndex = 10;
            label1.Text = "PRACOWNICY";
            // 
            // edytuj
            // 
            edytuj.Location = new Point(339, 125);
            edytuj.Name = "edytuj";
            edytuj.Size = new Size(94, 29);
            edytuj.TabIndex = 9;
            edytuj.Text = "Edytuj";
            edytuj.UseVisualStyleBackColor = true;
            edytuj.Click += edytuj_Click;
            // 
            // wyszukaj
            // 
            wyszukaj.Location = new Point(146, 224);
            wyszukaj.Name = "wyszukaj";
            wyszukaj.Size = new Size(94, 29);
            wyszukaj.TabIndex = 8;
            wyszukaj.Text = "Wyszukaj";
            wyszukaj.UseVisualStyleBackColor = true;
            wyszukaj.Click += wyszukaj_Click;
            // 
            // usun
            // 
            usun.Location = new Point(339, 224);
            usun.Name = "usun";
            usun.Size = new Size(94, 29);
            usun.TabIndex = 7;
            usun.Text = "Usuń";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(146, 125);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(94, 29);
            dodaj.TabIndex = 6;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // PracownicyKontrolka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(edytuj);
            Controls.Add(wyszukaj);
            Controls.Add(usun);
            Controls.Add(dodaj);
            Controls.Add(menu);
            Name = "PracownicyKontrolka";
            Size = new Size(631, 395);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menu;
        private Label label1;
        private Button edytuj;
        private Button wyszukaj;
        private Button usun;
        private Button dodaj;
    }
}
