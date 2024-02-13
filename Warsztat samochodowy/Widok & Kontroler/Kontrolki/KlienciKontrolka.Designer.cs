namespace Warsztat
{
    partial class KlienciKontrolka
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
            dodaj = new Button();
            usun = new Button();
            wyszukaj = new Button();
            edytuj = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Location = new Point(146, 316);
            menu.Name = "menu";
            menu.Size = new Size(94, 29);
            menu.TabIndex = 0;
            menu.Text = "<< Menu";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(146, 125);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(94, 29);
            dodaj.TabIndex = 1;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // usun
            // 
            usun.Location = new Point(339, 224);
            usun.Name = "usun";
            usun.Size = new Size(94, 29);
            usun.TabIndex = 2;
            usun.Text = "Usuń";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // wyszukaj
            // 
            wyszukaj.Location = new Point(146, 224);
            wyszukaj.Name = "wyszukaj";
            wyszukaj.Size = new Size(94, 29);
            wyszukaj.TabIndex = 3;
            wyszukaj.Text = "Wyszukaj";
            wyszukaj.UseVisualStyleBackColor = true;
            wyszukaj.Click += wyszukaj_Click;
            // 
            // edytuj
            // 
            edytuj.Location = new Point(339, 125);
            edytuj.Name = "edytuj";
            edytuj.Size = new Size(94, 29);
            edytuj.TabIndex = 4;
            edytuj.Text = "Edytuj";
            edytuj.UseVisualStyleBackColor = true;
            edytuj.Click += edytuj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(226, 37);
            label1.Name = "label1";
            label1.Size = new Size(137, 46);
            label1.TabIndex = 5;
            label1.Text = "KLIENCI";
            // 
            // KlienciKontrolka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(edytuj);
            Controls.Add(wyszukaj);
            Controls.Add(usun);
            Controls.Add(dodaj);
            Controls.Add(menu);
            Name = "KlienciKontrolka";
            Size = new Size(631, 395);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menu;
        private Button dodaj;
        private Button usun;
        private Button wyszukaj;
        private Button edytuj;
        private Label label1;
    }
}
