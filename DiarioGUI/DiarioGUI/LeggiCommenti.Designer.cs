namespace DiarioGUI
{
    partial class LeggiCommenti
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
            lblTitolo = new Label();
            lblNumeroCommenti = new Label();
            txtElencoCommenti = new TextBox();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(367, 24);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(102, 15);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Elenco Commenti";
            // 
            // lblNumeroCommenti
            // 
            lblNumeroCommenti.AutoSize = true;
            lblNumeroCommenti.Location = new Point(67, 67);
            lblNumeroCommenti.Name = "lblNumeroCommenti";
            lblNumeroCommenti.Size = new Size(152, 15);
            lblNumeroCommenti.TabIndex = 1;
            lblNumeroCommenti.Text = "Numero commenti trovati: ";
            // 
            // txtElencoCommenti
            // 
            txtElencoCommenti.Location = new Point(66, 107);
            txtElencoCommenti.Multiline = true;
            txtElencoCommenti.Name = "txtElencoCommenti";
            txtElencoCommenti.Size = new Size(681, 290);
            txtElencoCommenti.TabIndex = 2;
            // 
            // LeggiCommenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtElencoCommenti);
            Controls.Add(lblNumeroCommenti);
            Controls.Add(lblTitolo);
            Name = "LeggiCommenti";
            Text = "Leggi Commenti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Label lblNumeroCommenti;
        private TextBox txtElencoCommenti;
    }
}