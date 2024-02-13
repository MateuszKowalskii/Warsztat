namespace Warsztat.Okienka.OkienkaKlienci
{
    partial class KlientDodaj
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
            imie = new TextBox();
            nazwisko = new TextBox();
            pesel = new TextBox();
            dodaj = new Button();
            wroc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            telefon = new TextBox();
            komunikat = new Label();
            SuspendLayout();
            // 
            // imie
            // 
            imie.Location = new Point(284, 68);
            imie.Name = "imie";
            imie.Size = new Size(125, 27);
            imie.TabIndex = 0;
            // 
            // nazwisko
            // 
            nazwisko.Location = new Point(284, 142);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(125, 27);
            nazwisko.TabIndex = 1;
            // 
            // pesel
            // 
            pesel.Location = new Point(284, 209);
            pesel.Name = "pesel";
            pesel.Size = new Size(125, 27);
            pesel.TabIndex = 2;
            pesel.TextChanged += pesel_TextChanged;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(315, 354);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(94, 29);
            dodaj.TabIndex = 3;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // wroc
            // 
            wroc.Location = new Point(157, 354);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 4;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 68);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 5;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 142);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 209);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "PESEL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 272);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 8;
            label4.Text = "Telefon";
            // 
            // telefon
            // 
            telefon.Location = new Point(283, 272);
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 9;
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(101, 319);
            komunikat.MinimumSize = new Size(400, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(400, 20);
            komunikat.TabIndex = 10;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KlientDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 453);
            Controls.Add(komunikat);
            Controls.Add(telefon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(dodaj);
            Controls.Add(pesel);
            Controls.Add(nazwisko);
            Controls.Add(imie);
            Name = "KlientDodaj";
            Text = "KlientDodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imie;
        private TextBox nazwisko;
        private TextBox pesel;
        private Button dodaj;
        private Button wroc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox telefon;
        private Label komunikat;
    }
}