namespace Warsztat.Okienka.OkienkaZlecenia
{
    partial class ZlecenieDodaj
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
            label5 = new Label();
            komunikat = new Label();
            label3 = new Label();
            label1 = new Label();
            wroc = new Button();
            dodaj = new Button();
            wynagrodzenie = new TextBox();
            data = new MonthCalendar();
            pesel = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 197);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 35;
            label5.Text = "Ustalona data realizacji";
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(90, 453);
            komunikat.MinimumSize = new Size(400, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(400, 20);
            komunikat.TabIndex = 34;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 133);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 31;
            label3.Text = "Wynagrodzenie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 59);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 29;
            label1.Text = "PESEL zleceniodawcy";
            // 
            // wroc
            // 
            wroc.Location = new Point(165, 498);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 28;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(322, 498);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(94, 29);
            dodaj.TabIndex = 27;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // wynagrodzenie
            // 
            wynagrodzenie.Location = new Point(291, 133);
            wynagrodzenie.Name = "wynagrodzenie";
            wynagrodzenie.Size = new Size(151, 27);
            wynagrodzenie.TabIndex = 26;
            wynagrodzenie.TextChanged += wynagrodzenie_TextChanged;
            // 
            // data
            // 
            data.Location = new Point(132, 237);
            data.MaxSelectionCount = 1;
            data.Name = "data";
            data.TabIndex = 37;
            data.DateChanged += data_DateChanged;
            // 
            // pesel
            // 
            pesel.FormattingEnabled = true;
            pesel.Location = new Point(291, 59);
            pesel.Name = "pesel";
            pesel.Size = new Size(151, 28);
            pesel.TabIndex = 38;
            pesel.SelectedIndexChanged += pesel_SelectedIndexChanged;
            // 
            // ZlecenieDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 539);
            Controls.Add(pesel);
            Controls.Add(data);
            Controls.Add(label5);
            Controls.Add(komunikat);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(dodaj);
            Controls.Add(wynagrodzenie);
            Name = "ZlecenieDodaj";
            Text = "ZlecenieDodaj";
            Load += ZlecenieDodaj_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label komunikat;
        private Label label3;
        private Label label1;
        private Button wroc;
        private Button dodaj;
        private TextBox wynagrodzenie;
        private MonthCalendar data;
        private ComboBox pesel;
    }
}