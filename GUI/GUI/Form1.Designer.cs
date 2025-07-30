namespace GUI
{
    partial class Form1
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
            lblTesto = new Label();
            txtTesto = new TextBox();
            btnInvia = new Button();
            SuspendLayout();
            // 
            // lblTesto
            // 
            lblTesto.AutoSize = true;
            lblTesto.Location = new Point(128, 87);
            lblTesto.Name = "lblTesto";
            lblTesto.Size = new Size(95, 15);
            lblTesto.TabIndex = 0;
            lblTesto.Text = "Inserisci un testo";
            // 
            // txtTesto
            // 
            txtTesto.Location = new Point(240, 87);
            txtTesto.Name = "txtTesto";
            txtTesto.Size = new Size(400, 23);
            txtTesto.TabIndex = 1;
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(646, 87);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(58, 23);
            btnInvia.TabIndex = 2;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvia);
            Controls.Add(txtTesto);
            Controls.Add(lblTesto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTesto;
        private TextBox txtTesto;
        private Button btnInvia;
    }
}
