namespace DiarioGUI
{
    partial class frmGestioneDiario
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
            btnNuovoCommento = new Button();
            btnLeggiCommenti = new Button();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            lblTitolo.Location = new Point(353, 26);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(98, 37);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Diario";
            // 
            // btnNuovoCommento
            // 
            btnNuovoCommento.Location = new Point(156, 155);
            btnNuovoCommento.Name = "btnNuovoCommento";
            btnNuovoCommento.Size = new Size(200, 75);
            btnNuovoCommento.TabIndex = 1;
            btnNuovoCommento.Text = "Nuovo Commento";
            btnNuovoCommento.UseVisualStyleBackColor = true;
            btnNuovoCommento.Click += btnNuovoCommento_Click;
            // 
            // btnLeggiCommenti
            // 
            btnLeggiCommenti.Location = new Point(461, 155);
            btnLeggiCommenti.Name = "btnLeggiCommenti";
            btnLeggiCommenti.Size = new Size(200, 75);
            btnLeggiCommenti.TabIndex = 2;
            btnLeggiCommenti.Text = "Leggi Commenti";
            btnLeggiCommenti.UseVisualStyleBackColor = true;
            btnLeggiCommenti.Click += btnLeggiCommenti_Click;
            // 
            // frmGestioneDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeggiCommenti);
            Controls.Add(btnNuovoCommento);
            Controls.Add(lblTitolo);
            Name = "frmGestioneDiario";
            Text = "Gestione Diario";
            //Load += this.frmGestioneDiario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Button btnNuovoCommento;
        private Button btnLeggiCommenti;
    }
}
