namespace StudentiGUI
{
    partial class NuovoStudente
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
            lblMatricola = new Label();
            txtMatricola = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCognome = new TextBox();
            lblCognome = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtClasse = new TextBox();
            lblClasse = new Label();
            btnInvia = new Button();
            btnCancella = new Button();
            pnlContent = new Panel();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(130, 20);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(93, 15);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Nuovo Studente";
            // 
            // lblMatricola
            // 
            lblMatricola.AutoSize = true;
            lblMatricola.Location = new Point(92, 41);
            lblMatricola.Name = "lblMatricola";
            lblMatricola.Size = new Size(57, 15);
            lblMatricola.TabIndex = 1;
            lblMatricola.Text = "Matricola";
            // 
            // txtMatricola
            // 
            txtMatricola.Location = new Point(150, 41);
            txtMatricola.Name = "txtMatricola";
            txtMatricola.Size = new Size(100, 23);
            txtMatricola.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(150, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(129, 23);
            txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(92, 99);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(158, 155);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(121, 23);
            txtCognome.TabIndex = 6;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(92, 155);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(60, 15);
            lblCognome.TabIndex = 5;
            lblCognome.Text = "Cognome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(129, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(92, 208);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtClasse
            // 
            txtClasse.Location = new Point(150, 263);
            txtClasse.Name = "txtClasse";
            txtClasse.Size = new Size(129, 23);
            txtClasse.TabIndex = 10;
            // 
            // lblClasse
            // 
            lblClasse.AutoSize = true;
            lblClasse.Location = new Point(92, 263);
            lblClasse.Name = "lblClasse";
            lblClasse.Size = new Size(40, 15);
            lblClasse.TabIndex = 9;
            lblClasse.Text = "Classe";
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(97, 314);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(75, 30);
            btnInvia.TabIndex = 11;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(204, 314);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(75, 30);
            btnCancella.TabIndex = 12;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(txtMatricola);
            pnlContent.Controls.Add(btnCancella);
            pnlContent.Controls.Add(lblMatricola);
            pnlContent.Controls.Add(btnInvia);
            pnlContent.Controls.Add(lblNome);
            pnlContent.Controls.Add(txtClasse);
            pnlContent.Controls.Add(txtNome);
            pnlContent.Controls.Add(lblClasse);
            pnlContent.Controls.Add(lblCognome);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(txtCognome);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Location = new Point(23, 38);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(360, 400);
            pnlContent.TabIndex = 13;
            // 
            // NuovoStudente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 461);
            Controls.Add(pnlContent);
            Controls.Add(lblTitolo);
            Name = "NuovoStudente";
            Text = "Nuovo Studente";
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Label lblMatricola;
        private TextBox txtMatricola;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCognome;
        private Label lblCognome;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtClasse;
        private Label lblClasse;
        private Button btnInvia;
        private Button btnCancella;
        private Panel pnlContent;
    }
}