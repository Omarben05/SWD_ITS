namespace DiarioGUI
{
    partial class NuovoCommento
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
            btnInvia = new Button();
            lblTitolo = new Label();
            txtCommento = new TextBox();
            lblCommento = new Label();
            btnCancella = new Button();
            SuspendLayout();
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(291, 278);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(75, 23);
            btnInvia.TabIndex = 0;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(362, 28);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(107, 15);
            lblTitolo.TabIndex = 1;
            lblTitolo.Text = "Nuovo Commento";
            // 
            // txtCommento
            // 
            txtCommento.Location = new Point(227, 88);
            txtCommento.Multiline = true;
            txtCommento.Name = "txtCommento";
            txtCommento.Size = new Size(330, 150);
            txtCommento.TabIndex = 5;
            // 
            // lblCommento
            // 
            lblCommento.AutoSize = true;
            lblCommento.Location = new Point(124, 150);
            lblCommento.Name = "lblCommento";
            lblCommento.Size = new Size(68, 15);
            lblCommento.TabIndex = 4;
            lblCommento.Text = "Commento";
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(424, 278);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(75, 23);
            btnCancella.TabIndex = 6;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // NuovoCommento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancella);
            Controls.Add(txtCommento);
            Controls.Add(lblCommento);
            Controls.Add(lblTitolo);
            Controls.Add(btnInvia);
            Name = "NuovoCommento";
            Text = "Nuovo Commento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInvia;
        private Label lblTitolo;
        private TextBox txtCommento;
        private Label lblCommento;
        private Button btnCancella;
    }
}