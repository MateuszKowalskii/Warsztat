namespace Warsztat.Okienka.OkienkaZlecenia
{
    partial class ZlecenieEdytuj
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            zmien = new Button();
            Id = new TextBox();
            oplata = new TextBox();
            label7 = new Label();
            listaPracownikow = new ComboBox();
            status = new ComboBox();
            dodajPracownika = new Button();
            data = new MonthCalendar();
            label4 = new Label();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(55, 350);
            komunikat.MinimumSize = new Size(200, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(200, 20);
            komunikat.TabIndex = 33;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 112);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(517, 20);
            label5.TabIndex = 32;
            label5.Text = "Ustaw nowe dane. Pola, których wartości nie chcesz zmieniać pozostaw puste";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 36);
            label3.Name = "label3";
            label3.Size = new Size(319, 20);
            label3.TabIndex = 29;
            label3.Text = "Podaj Id zlecenia, którego dane chcesz zmienić";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 234);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 28;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 160);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 27;
            label1.Text = "Opłata";
            // 
            // wroc
            // 
            wroc.Location = new Point(55, 412);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 26;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // zmien
            // 
            zmien.Location = new Point(213, 412);
            zmien.Name = "zmien";
            zmien.Size = new Size(94, 29);
            zmien.TabIndex = 25;
            zmien.Text = "Zmień";
            zmien.UseVisualStyleBackColor = true;
            zmien.Click += zmien_Click;
            // 
            // Id
            // 
            Id.Location = new Point(65, 69);
            Id.Name = "Id";
            Id.Size = new Size(125, 27);
            Id.TabIndex = 24;
            // 
            // oplata
            // 
            oplata.Location = new Point(188, 160);
            oplata.Name = "oplata";
            oplata.Size = new Size(151, 27);
            oplata.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(720, 158);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 36;
            label7.Text = "Pracownik";
            // 
            // listaPracownikow
            // 
            listaPracownikow.FormattingEnabled = true;
            listaPracownikow.Location = new Point(833, 162);
            listaPracownikow.Name = "listaPracownikow";
            listaPracownikow.Size = new Size(151, 28);
            listaPracownikow.TabIndex = 37;
            listaPracownikow.SelectedIndexChanged += listaPracownikow_SelectedIndexChanged;
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Zakończone", "W trakcie" });
            status.Location = new Point(188, 235);
            status.Name = "status";
            status.Size = new Size(151, 28);
            status.TabIndex = 40;
            // 
            // dodajPracownika
            // 
            dodajPracownika.Location = new Point(833, 235);
            dodajPracownika.Name = "dodajPracownika";
            dodajPracownika.Size = new Size(151, 29);
            dodajPracownika.TabIndex = 41;
            dodajPracownika.Text = "Dodaj pracownika";
            dodajPracownika.UseVisualStyleBackColor = true;
            dodajPracownika.Click += dodajPracownika_Click;
            // 
            // data
            // 
            data.Location = new Point(378, 209);
            data.MaxSelectionCount = 1;
            data.Name = "data";
            data.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 162);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 43;
            label4.Text = "Data realizacji";
            // 
            // ZlecenieEdytuj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 464);
            Controls.Add(label4);
            Controls.Add(data);
            Controls.Add(dodajPracownika);
            Controls.Add(status);
            Controls.Add(listaPracownikow);
            Controls.Add(label7);
            Controls.Add(komunikat);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(zmien);
            Controls.Add(Id);
            Controls.Add(oplata);
            Name = "ZlecenieEdytuj";
            Text = "ZlecenieEdytuj";
            Load += ZlecenieEdytuj_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button zmien;
        private TextBox Id;
        private TextBox oplata;
        private Label label7;
        private ComboBox listaPracownikow;
        private ComboBox status;
        private Button dodajPracownika;
        private MonthCalendar data;
        private Label label4;
    }
}