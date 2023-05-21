namespace Warsztat_samochodowy.Okienka.OkienkaZlecenia
{
    partial class ZlecenieWykonano
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
            zrealizowane = new Button();
            nieZrealizowane = new Button();
            komunikat = new Label();
            SuspendLayout();
            // 
            // zrealizowane
            // 
            zrealizowane.Location = new Point(112, 167);
            zrealizowane.Name = "zrealizowane";
            zrealizowane.Size = new Size(114, 29);
            zrealizowane.TabIndex = 0;
            zrealizowane.Text = "Zrealizowane";
            zrealizowane.UseVisualStyleBackColor = true;
            zrealizowane.Click += zrealizowane_Click;
            // 
            // nieZrealizowane
            // 
            nieZrealizowane.Location = new Point(298, 167);
            nieZrealizowane.Name = "nieZrealizowane";
            nieZrealizowane.Size = new Size(114, 29);
            nieZrealizowane.TabIndex = 1;
            nieZrealizowane.Text = "Jeszcze nie";
            nieZrealizowane.UseVisualStyleBackColor = true;
            nieZrealizowane.Click += nieZrealizowane_Click;
            // 
            // komunikat
            // 
            komunikat.Location = new Point(112, 73);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(300, 51);
            komunikat.TabIndex = 2;
            komunikat.Text = "Dzisiaj planowo miało zostać wykonane zlecenie nr. . Czy zostało zrealizowane?";
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ZlecenieWykonano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 274);
            Controls.Add(komunikat);
            Controls.Add(nieZrealizowane);
            Controls.Add(zrealizowane);
            Name = "ZlecenieWykonano";
            Text = "ZlecenieWykonano";
            ResumeLayout(false);
        }

        #endregion

        private Button zrealizowane;
        private Button nieZrealizowane;
        private Label komunikat;
    }
}