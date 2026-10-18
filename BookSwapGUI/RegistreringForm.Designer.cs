namespace BookSwapGUI
{
    partial class RegistreringForm
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
            lblRubrik = new Label();
            lblEfternamn = new Label();
            lblEpost = new Label();
            lblTelefon = new Label();
            lblAnvandarnamn = new Label();
            lblLosenord = new Label();
            lblFornamn = new Label();
            txtFornamn = new TextBox();
            txtEfternamn = new TextBox();
            txtEpost = new TextBox();
            txtTelefon = new TextBox();
            txtAnvandarnamn = new TextBox();
            txtLosenord = new TextBox();
            btnRegistrera = new Button();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(325, 40);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(163, 21);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Skapa studentkonto";
            // 
            // lblEfternamn
            // 
            lblEfternamn.AutoSize = true;
            lblEfternamn.Location = new Point(338, 76);
            lblEfternamn.Name = "lblEfternamn";
            lblEfternamn.Size = new Size(65, 15);
            lblEfternamn.TabIndex = 1;
            lblEfternamn.Text = "Efternamn:";
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Location = new Point(163, 135);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(77, 15);
            lblEpost.TabIndex = 2;
            lblEpost.Text = "E-postadress:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(163, 188);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(95, 15);
            lblTelefon.TabIndex = 3;
            lblTelefon.Text = "Telefonnummer:";
            // 
            // lblAnvandarnamn
            // 
            lblAnvandarnamn.AutoSize = true;
            lblAnvandarnamn.Location = new Point(161, 238);
            lblAnvandarnamn.Name = "lblAnvandarnamn";
            lblAnvandarnamn.Size = new Size(92, 15);
            lblAnvandarnamn.TabIndex = 4;
            lblAnvandarnamn.Text = "Användarnamn:";
            // 
            // lblLosenord
            // 
            lblLosenord.AutoSize = true;
            lblLosenord.Location = new Point(163, 292);
            lblLosenord.Name = "lblLosenord";
            lblLosenord.Size = new Size(59, 15);
            lblLosenord.TabIndex = 5;
            lblLosenord.Text = "Lösenord:";
            
            // 
            // lblFornamn
            // 
            lblFornamn.AutoSize = true;
            lblFornamn.Location = new Point(163, 76);
            lblFornamn.Name = "lblFornamn";
            lblFornamn.Size = new Size(58, 15);
            lblFornamn.TabIndex = 6;
            lblFornamn.Text = "Förnamn:";
            // 
            // txtFornamn
            // 
            txtFornamn.Location = new Point(163, 94);
            txtFornamn.Name = "txtFornamn";
            txtFornamn.Size = new Size(150, 23);
            txtFornamn.TabIndex = 7;
            // 
            // txtEfternamn
            // 
            txtEfternamn.Location = new Point(338, 94);
            txtEfternamn.Name = "txtEfternamn";
            txtEfternamn.Size = new Size(150, 23);
            txtEfternamn.TabIndex = 8;
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(163, 153);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(150, 23);
            txtEpost.TabIndex = 9;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(163, 206);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(150, 23);
            txtTelefon.TabIndex = 10;
            // 
            // txtAnvandarnamn
            // 
            txtAnvandarnamn.Location = new Point(163, 256);
            txtAnvandarnamn.Name = "txtAnvandarnamn";
            txtAnvandarnamn.Size = new Size(150, 23);
            txtAnvandarnamn.TabIndex = 11;
            // 
            // txtLosenord
            // 
            txtLosenord.Location = new Point(163, 310);
            txtLosenord.Name = "txtLosenord";
            txtLosenord.Size = new Size(150, 23);
            txtLosenord.TabIndex = 12;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrera.Location = new Point(325, 370);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(150, 31);
            btnRegistrera.TabIndex = 13;
            btnRegistrera.Text = "Registrera konto";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += btnRegistrera_Click;
            // 
            // RegistreringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrera);
            Controls.Add(txtLosenord);
            Controls.Add(txtAnvandarnamn);
            Controls.Add(txtTelefon);
            Controls.Add(txtEpost);
            Controls.Add(txtEfternamn);
            Controls.Add(txtFornamn);
            Controls.Add(lblFornamn);
            Controls.Add(lblLosenord);
            Controls.Add(lblAnvandarnamn);
            Controls.Add(lblTelefon);
            Controls.Add(lblEpost);
            Controls.Add(lblEfternamn);
            Controls.Add(lblRubrik);
            Name = "RegistreringForm";
            Text = "RegistreringForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRubrik;
        private Label lblEfternamn;
        private Label lblEpost;
        private Label lblTelefon;
        private Label lblAnvandarnamn;
        private Label lblLosenord;
        private Label lblFornamn;
        private TextBox txtFornamn;
        private TextBox txtEfternamn;
        private TextBox txtEpost;
        private TextBox txtTelefon;
        private TextBox txtAnvandarnamn;
        private TextBox txtLosenord;
        private Button btnRegistrera;
    }
}