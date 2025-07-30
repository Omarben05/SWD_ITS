namespace StudentiGUI
{
    partial class ElencoStudenti
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitolo = new Label();
            lblNumeroStudentiTrovati = new Label();
            txtElencoStudenti = new TextBox();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(370, 20);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(89, 15);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Elenco Studenti";
            // 
            // lblNumeroStudentiTrovati
            // 
            lblNumeroStudentiTrovati.AutoSize = true;
            lblNumeroStudentiTrovati.Location = new Point(62, 76);
            lblNumeroStudentiTrovati.Name = "lblNumeroStudentiTrovati";
            lblNumeroStudentiTrovati.Size = new Size(141, 15);
            lblNumeroStudentiTrovati.TabIndex = 1;
            lblNumeroStudentiTrovati.Text = "Numero Studenti trovati: ";
            // 
            // txtElencoStudenti
            // 
            txtElencoStudenti.Location = new Point(60, 113);
            txtElencoStudenti.Multiline = true;
            txtElencoStudenti.Name = "txtElencoStudenti";
            txtElencoStudenti.Size = new Size(690, 309);
            txtElencoStudenti.TabIndex = 2;
            // 
            // ElencoStudenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtElencoStudenti);
            Controls.Add(lblNumeroStudentiTrovati);
            Controls.Add(lblTitolo);
            Name = "ElencoStudenti";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Label lblNumeroStudentiTrovati;
        private TextBox txtElencoStudenti;
    }
}
