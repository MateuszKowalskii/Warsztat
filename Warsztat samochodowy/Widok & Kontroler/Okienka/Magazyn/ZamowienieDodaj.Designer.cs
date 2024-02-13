namespace Warsztat.Okienka.OkienkaMagazyn
{
    partial class ZamowienieDodaj
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
            nazwa = new TextBox();
            kod = new TextBox();
            ilosc = new TextBox();
            data = new MonthCalendar();
            dostawca = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            komunikat = new Label();
            wroc = new Button();
            dodaj = new Button();
            SuspendLayout();
            // 
            // nazwa
            // 
            nazwa.Location = new Point(195, 106);
            nazwa.Name = "nazwa";
            nazwa.Size = new Size(125, 27);
            nazwa.TabIndex = 0;
            nazwa.TextChanged += nazwa_TextChanged;
            // 
            // kod
            // 
            kod.Location = new Point(195, 182);
            kod.Name = "kod";
            kod.Size = new Size(125, 27);
            kod.TabIndex = 1;
            kod.TextChanged += kod_TextChanged;
            // 
            // ilosc
            // 
            ilosc.Location = new Point(195, 357);
            ilosc.Name = "ilosc";
            ilosc.Size = new Size(125, 27);
            ilosc.TabIndex = 2;
            ilosc.TextChanged += ilosc_TextChanged;
            // 
            // data
            // 
            data.Location = new Point(439, 170);
            data.MaxSelectionCount = 1;
            data.Name = "data";
            data.TabIndex = 3;
            // 
            // dostawca
            // 
            dostawca.FormattingEnabled = true;
            dostawca.Location = new Point(195, 265);
            dostawca.Name = "dostawca";
            dostawca.Size = new Size(151, 28);
            dostawca.TabIndex = 5;
            dostawca.SelectedIndexChanged += dostawca_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 106);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Nazwa produktu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 40);
            label2.Name = "label2";
            label2.Size = new Size(340, 20);
            label2.TabIndex = 7;
            label2.Text = "Uzupełnij dane dotyczące zamawianego produktu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 182);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 8;
            label3.Text = "Kod produktu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 265);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Dostawca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 357);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 10;
            label5.Text = "Ilość";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 106);
            label6.Name = "label6";
            label6.Size = new Size(181, 20);
            label6.TabIndex = 11;
            label6.Text = "Uzgodniona data odbioru";
            // 
            // komunikat
            // 
            komunikat.AutoSize = true;
            komunikat.Location = new Point(195, 423);
            komunikat.MinimumSize = new Size(400, 0);
            komunikat.Name = "komunikat";
            komunikat.Size = new Size(400, 20);
            komunikat.TabIndex = 24;
            komunikat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wroc
            // 
            wroc.Location = new Point(252, 459);
            wroc.Name = "wroc";
            wroc.Size = new Size(94, 29);
            wroc.TabIndex = 23;
            wroc.Text = "<< Wróć";
            wroc.UseVisualStyleBackColor = true;
            wroc.Click += wroc_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(410, 459);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(94, 29);
            dodaj.TabIndex = 22;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // ZamowienieDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(komunikat);
            Controls.Add(wroc);
            Controls.Add(dodaj);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dostawca);
            Controls.Add(data);
            Controls.Add(ilosc);
            Controls.Add(kod);
            Controls.Add(nazwa);
            Name = "ZamowienieDodaj";
            Text = "ZamowienieDodaj";
            Load += ZamowienieDodaj_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nazwa;
        private TextBox kod;
        private TextBox ilosc;
        private MonthCalendar data;
        private ComboBox dostawca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label komunikat;
        private Button wroc;
        private Button dodaj;
    }
}