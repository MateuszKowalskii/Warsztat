namespace Warsztat_samochodowy.Okienka.OkienkaPracownicy
{
    partial class PracownikUsun
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
            usun = new Button();
            wroc = new Button();
            pesel = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(100, 167);
            komunikat.MinimumSize = new Size(310, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(310, 20);
            komunikat.TabIndex = 9;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usun
            // 
            usun.Location = new Point(317, 203);
            usun.Name = "usun";
            usun.Size = new Size(94, 29);
            usun.TabIndex = 8;
            usun.Text = "Usuń";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // wroc
            // 
            wroc.Location = new Point(99, 203);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 7;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // pesel
            // 
            pesel.Location = new Point(99, 127);
            pesel.Name = "pesel";
            pesel.Size = new Size(125, 27);
            pesel.TabIndex = 6;
            pesel.TextChanged += pesel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 89);
            label1.Name = "label1";
            label1.Size = new Size(344, 20);
            label1.TabIndex = 5;
            label1.Text = "Podaj nr. PESEL pracownika, ktorego chcesz usunąć";
            // 
            // PracownikUsun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 320);
            Controls.Add(komunikat);
            Controls.Add(usun);
            Controls.Add(wroc);
            Controls.Add(pesel);
            Controls.Add(label1);
            Name = "PracownikUsun";
            Text = "PracownikUsun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label komunikat;
        private Button usun;
        private Button wroc;
        private TextBox pesel;
        private Label label1;
    }
}