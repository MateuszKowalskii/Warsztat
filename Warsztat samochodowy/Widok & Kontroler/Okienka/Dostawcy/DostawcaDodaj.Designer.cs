namespace Warsztat.Okienka.OkienkaDostawcy
{
    partial class DostawcaDodaj
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
            telefon = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            wroc = new Button();
            dodaj = new Button();
            email = new TextBox();
            nazwa = new TextBox();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(111, 261);
            komunikat.MinimumSize = new Size(400, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(400, 20);
            komunikat.TabIndex = 21;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // telefon
            // 
            telefon.Location = new Point(305, 212);
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 212);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 19;
            label4.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 137);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 17;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 63);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 16;
            label1.Text = "Nazwa";
            // 
            // wroc
            // 
            wroc.Location = new Point(179, 294);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 15;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(337, 294);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(94, 29);
            dodaj.TabIndex = 14;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // email
            // 
            email.Location = new Point(305, 137);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 12;
            // 
            // nazwa
            // 
            nazwa.Location = new Point(305, 63);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(125, 27);
            nazwa.TabIndex = 11;
            nazwa.TextChanged += nazwa_TextChanged;
            // 
            // DostawcaDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 404);
            Controls.Add(komunikat);
            Controls.Add(telefon);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wroc);
            Controls.Add(dodaj);
            Controls.Add(email);
            Controls.Add(nazwa);
            Name = "DostawcaDodaj";
            Text = "DostawcaDodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private TextBox telefon;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button wroc;
        private Button dodaj;
        private TextBox email;
        private TextBox nazwa;
    }
}