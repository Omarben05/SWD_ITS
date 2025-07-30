namespace CalcolatriceGUI
{
    partial class frmCalcolatrice
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
            lblN1 = new Label();
            lblN2 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            btnSomma = new Button();
            txtRisultato = new TextBox();
            btnSottrazione = new Button();
            btnMoltiplicazione = new Button();
            btnDivisione = new Button();
            btnResto = new Button();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.BackColor = Color.FromArgb(192, 255, 192);
            lblTitolo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitolo.ForeColor = Color.Red;
            lblTitolo.Location = new Point(566, 27);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(134, 30);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Calcolatrice";
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(228, 116);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(22, 15);
            lblN1.TabIndex = 1;
            lblN1.Text = "N1";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(228, 176);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(22, 15);
            lblN2.TabIndex = 2;
            lblN2.Text = "N2";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(266, 116);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 3;
            txtN1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(266, 173);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 4;
            txtN2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSomma
            // 
            btnSomma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSomma.Location = new Point(398, 115);
            btnSomma.Name = "btnSomma";
            btnSomma.Size = new Size(40, 23);
            btnSomma.TabIndex = 5;
            btnSomma.Text = "+";
            btnSomma.UseVisualStyleBackColor = true;
            btnSomma.Click += btnSomma_Click;
            // 
            // txtRisultato
            // 
            txtRisultato.Location = new Point(524, 118);
            txtRisultato.Name = "txtRisultato";
            txtRisultato.Size = new Size(176, 23);
            txtRisultato.TabIndex = 6;
            txtRisultato.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSottrazione
            // 
            btnSottrazione.Location = new Point(444, 115);
            btnSottrazione.Name = "btnSottrazione";
            btnSottrazione.Size = new Size(40, 23);
            btnSottrazione.TabIndex = 7;
            btnSottrazione.Text = "-";
            btnSottrazione.UseVisualStyleBackColor = true;
            btnSottrazione.Click += btnSottrazione_Click;
            // 
            // btnMoltiplicazione
            // 
            btnMoltiplicazione.Location = new Point(398, 144);
            btnMoltiplicazione.Name = "btnMoltiplicazione";
            btnMoltiplicazione.Size = new Size(40, 23);
            btnMoltiplicazione.TabIndex = 8;
            btnMoltiplicazione.Text = "*";
            btnMoltiplicazione.UseVisualStyleBackColor = true;
            btnMoltiplicazione.Click += btnMoltiplicazione_Click;
            // 
            // btnDivisione
            // 
            btnDivisione.Location = new Point(444, 147);
            btnDivisione.Name = "btnDivisione";
            btnDivisione.Size = new Size(40, 23);
            btnDivisione.TabIndex = 9;
            btnDivisione.Text = "/";
            btnDivisione.UseVisualStyleBackColor = true;
            btnDivisione.Click += btnDivisione_Click;
            // 
            // btnResto
            // 
            btnResto.Location = new Point(398, 173);
            btnResto.Name = "btnResto";
            btnResto.Size = new Size(40, 23);
            btnResto.TabIndex = 10;
            btnResto.Text = "%";
            btnResto.UseVisualStyleBackColor = true;
            btnResto.Click += btnResto_Click;
            // 
            // frmCalcolatrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1184, 561);
            Controls.Add(btnResto);
            Controls.Add(btnDivisione);
            Controls.Add(btnMoltiplicazione);
            Controls.Add(btnSottrazione);
            Controls.Add(txtRisultato);
            Controls.Add(btnSomma);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(lblTitolo);
            Name = "frmCalcolatrice";
            Text = "Calcolatrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Label lblN1;
        private Label lblN2;
        private TextBox txtN1;
        private TextBox txtN2;
        private Button btnSomma;
        private TextBox txtRisultato;
        private Button btnSottrazione;
        private Button btnMoltiplicazione;
        private Button btnDivisione;
        private Button btnResto;
    }
}
