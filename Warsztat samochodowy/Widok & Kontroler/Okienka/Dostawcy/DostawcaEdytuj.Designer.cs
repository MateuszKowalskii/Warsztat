namespace Warsztat.Okienka.OkienkaDostawcy
{
    partial class DostawcaEdytuj
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
            telefon = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            wroc = new Button();
            zmien = new Button();
            id = new TextBox();
            email = new TextBox();
            nazwa = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(459, 160);
            komunikat.MinimumSize = new Size(200, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(200, 20);
            komunikat.TabIndex = 33;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 112);
            label5.Name = "label5";
            label5.Size = new Size(517, 20);
            label5.TabIndex = 32;
            label5.Text = "Ustaw nowe dane. Pola, których wartości nie chcesz zmieniać pozostaw puste";
            // 
            // telefon
            // 
            telefon.Location = new Point(269, 304);
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 31;
            telefon.TextChanged += telefon_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 304);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 30;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 36);
            label3.Name = "label3";
            label3.Size = new Size(329, 20);
            label3.TabIndex = 29;
            label3.Text = "Podaj ID dostawcy, którego dane chcesz zmienić";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 234);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 28;
            label2.Text = "E-mail";
            // 
            // wroc
            // 
            wroc.Location = new Point(143, 386);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 26;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // zmien
            // 
            zmien.Location = new Point(301, 386);
            zmien.Name = "zmien";
            zmien.Size = new Size(94, 29);
            zmien.TabIndex = 25;
            zmien.Text = "Zmień";
            zmien.UseVisualStyleBackColor = true;
            zmien.Click += zmien_Click;
            // 
            // id
            // 
            id.Location = new Point(146, 69);
            id.Name = "id";
            id.Size = new Size(125, 27);
            id.TabIndex = 24;
            id.TextChanged += id_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(269, 234);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 23;
            email.TextChanged += email_TextChanged;
            // 
            // nazwa
            // 
            nazwa.Location = new Point(269, 160);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(125, 27);
            nazwa.TabIndex = 22;
            nazwa.TextChanged += nazwa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 163);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 34;
            label1.Text = "Nazwa";
            // 
            // DostawcaEdytuj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(komunikat);
            Controls.Add(label5);
            Controls.Add(telefon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(wroc);
            Controls.Add(zmien);
            Controls.Add(id);
            Controls.Add(email);
            Controls.Add(nazwa);
            Name = "DostawcaEdytuj";
            Text = "DostawcaEdytuj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private Label label5;
        private TextBox telefon;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button wroc;
        private Button zmien;
        private TextBox id;
        private TextBox email;
        private TextBox nazwa;
        private Label label1;
    }
}