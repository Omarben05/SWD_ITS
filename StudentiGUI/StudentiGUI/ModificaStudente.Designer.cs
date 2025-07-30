namespace StudentiGUI
{
    partial class ModificaStudente
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
            btnCerca = new Button();
            txtRicercaMatricola = new TextBox();
            lblRicercaTesto = new Label();
            lblTitolo = new Label();
            pnlContent = new Panel();
            btnCancella = new Button();
            btnInvia = new Button();
            txtClasse = new TextBox();
            lblClasse = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtCognome = new TextBox();
            lblCognome = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtMatricola = new TextBox();
            lblMatricola = new Label();
            pnlRicerca.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRicerca
            // 
            pnlRicerca.Controls.Add(btnCerca);
            pnlRicerca.Controls.Add(txtRicercaMatricola);
            pnlRicerca.Controls.Add(lblRicercaTesto);
            pnlRicerca.Location = new Point(18, 46);
            pnlRicerca.Name = "pnlRicerca";
            pnlRicerca.Size = new Size(360, 100);
            pnlRicerca.TabIndex = 1;
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
            // txtRicercaMatricola
            // 
            txtRicercaMatricola.Location = new Point(135, 35);
            txtRicercaMatricola.Name = "txtRicercaMatricola";
            txtRicercaMatricola.Size = new Size(100, 23);
            txtRicercaMatricola.TabIndex = 1;
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
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(157, 16);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(104, 15);
            lblTitolo.TabIndex = 2;
            lblTitolo.Text = "Modifica Studente";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(btnCancella);
            pnlContent.Controls.Add(btnInvia);
            pnlContent.Controls.Add(txtClasse);
            pnlContent.Controls.Add(lblClasse);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(txtCognome);
            pnlContent.Controls.Add(lblCognome);
            pnlContent.Controls.Add(txtNome);
            pnlContent.Controls.Add(lblNome);
            pnlContent.Controls.Add(txtMatricola);
            pnlContent.Controls.Add(lblMatricola);
            pnlContent.Location = new Point(18, 174);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(360, 400);
            pnlContent.TabIndex = 3;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(183, 297);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(75, 30);
            btnCancella.TabIndex = 24;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(76, 297);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(75, 30);
            btnInvia.TabIndex = 23;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // txtClasse
            // 
            txtClasse.Location = new Point(129, 246);
            txtClasse.Name = "txtClasse";
            txtClasse.Size = new Size(168, 23);
            txtClasse.TabIndex = 22;
            // 
            // lblClasse
            // 
            lblClasse.AutoSize = true;
            lblClasse.Location = new Point(71, 246);
            lblClasse.Name = "lblClasse";
            lblClasse.Size = new Size(40, 15);
            lblClasse.TabIndex = 21;
            lblClasse.Text = "Classe";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(71, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email";
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(129, 138);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(168, 23);
            txtCognome.TabIndex = 18;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(71, 138);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(60, 15);
            lblCognome.TabIndex = 17;
            lblCognome.Text = "Cognome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(129, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(168, 23);
            txtNome.TabIndex = 16;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(71, 82);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome";
            // 
            // txtMatricola
            // 
            txtMatricola.Location = new Point(129, 24);
            txtMatricola.Name = "txtMatricola";
            txtMatricola.ReadOnly = true;
            txtMatricola.Size = new Size(100, 23);
            txtMatricola.TabIndex = 14;
            // 
            // lblMatricola
            // 
            lblMatricola.AutoSize = true;
            lblMatricola.Location = new Point(71, 24);
            lblMatricola.Name = "lblMatricola";
            lblMatricola.Size = new Size(57, 15);
            lblMatricola.TabIndex = 13;
            lblMatricola.Text = "Matricola";
            // 
            // ModificaStudente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 611);
            Controls.Add(pnlContent);
            Controls.Add(lblTitolo);
            Controls.Add(pnlRicerca);
            Name = "ModificaStudente";
            Text = "ModificaStudente";
            pnlRicerca.ResumeLayout(false);
            pnlRicerca.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRicerca;
        private Button btnCerca;
        private TextBox txtRicercaMatricola;
        private Label lblRicercaTesto;
        private Label lblTitolo;
        private Panel pnlContent;
        private Button btnCancella;
        private Button btnInvia;
        private TextBox txtClasse;
        private Label lblClasse;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtCognome;
        private Label lblCognome;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtMatricola;
        private Label lblMatricola;
    }
}