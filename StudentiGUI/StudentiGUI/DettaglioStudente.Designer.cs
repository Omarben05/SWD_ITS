namespace StudentiGUI
{
    partial class DettaglioStudente
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
            pnlRicerca = new Panel();
            lblRicercaTesto = new Label();
            txtRicercaMatricola = new TextBox();
            btnCerca = new Button();
            txtRisultato = new TextBox();
            pnlRicerca.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRicerca
            // 
            pnlRicerca.Controls.Add(btnCerca);
            pnlRicerca.Controls.Add(txtRicercaMatricola);
            pnlRicerca.Controls.Add(lblRicercaTesto);
            pnlRicerca.Location = new Point(22, 12);
            pnlRicerca.Name = "pnlRicerca";
            pnlRicerca.Size = new Size(366, 100);
            pnlRicerca.TabIndex = 0;
            // 
            // lblRicercaTesto
            // 
            lblRicercaTesto.AutoSize = true;
            lblRicercaTesto.Location = new Point(12, 34);
            lblRicercaTesto.Name = "lblRicercaTesto";
            lblRicercaTesto.Size = new Size(117, 15);
            lblRicercaTesto.TabIndex = 0;
            lblRicercaTesto.Text = "Numero di matricola";
            // 
            // txtRicercaMatricola
            // 
            txtRicercaMatricola.Location = new Point(135, 35);
            txtRicercaMatricola.Name = "txtRicercaMatricola";
            txtRicercaMatricola.Size = new Size(100, 23);
            txtRicercaMatricola.TabIndex = 1;
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(241, 34);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(75, 23);
            btnCerca.TabIndex = 2;
            btnCerca.Text = "Cerca";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // txtRisultato
            // 
            txtRisultato.Location = new Point(22, 139);
            txtRisultato.Multiline = true;
            txtRisultato.Name = "txtRisultato";
            txtRisultato.ReadOnly = true;
            txtRisultato.Size = new Size(366, 273);
            txtRisultato.TabIndex = 1;
            // 
            // DettaglioStudente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 450);
            Controls.Add(txtRisultato);
            Controls.Add(pnlRicerca);
            Name = "DettaglioStudente";
            Text = "Dettaglio Studente";
            pnlRicerca.ResumeLayout(false);
            pnlRicerca.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRicerca;
        private Label lblRicercaTesto;
        private Button btnCerca;
        private TextBox txtRicercaMatricola;
        private TextBox txtRisultato;
    }
}