namespace Warsztat_samochodowy.Okienka.OkienkaKlienci
{
    partial class KlientUsun
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
            label1 = new Label();
            pesel = new TextBox();
            wroc = new Button();
            usun = new Button();
            komunikat = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 84);
            label1.Name = "label1";
            label1.Size = new Size(312, 20);
            label1.TabIndex = 0;
            label1.Text = "Podaj nr. PESEL klienta, ktorego chcesz usunąć";
            // 
            // pesel
            // 
            pesel.Location = new Point(71, 122);
            pesel.Name = "pesel";
            pesel.Size = new Size(125, 27);
            pesel.TabIndex = 1;
            pesel.TextChanged += pesel_TextChanged;
            // 
            // wroc
            // 
            wroc.Location = new Point(71, 198);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 2;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // usun
            // 
            usun.Location = new Point(289, 198);
            usun.Name = "usun";
            usun.Size = new Size(94, 29);
            usun.TabIndex = 3;
            usun.Text = "Usuń";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(72, 162);
            komunikat.MinimumSize = new Size(310, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(310, 20);
            komunikat.TabIndex = 4;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KlientUsun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 320);
            Controls.Add(komunikat);
            Controls.Add(usun);
            Controls.Add(wroc);
            Controls.Add(pesel);
            Controls.Add(label1);
            Name = "KlientUsun";
            Text = "KlientUsun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox pesel;
        private Button wroc;
        private Button usun;
        private Label komunikat;
    }
}