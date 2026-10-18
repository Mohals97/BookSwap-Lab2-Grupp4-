namespace BookSwapGUI
{
    partial class LoginFoem
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
            lblRubrikLogin = new Label();
            lblEpost = new Label();
            txtEpost = new TextBox();
            lblLosenord = new Label();
            txtLosenord = new TextBox();
            btnLoggaIn = new Button();
            btnSkapaKonto = new Button();
            SuspendLayout();
            // 
            // lblRubrikLogin
            // 
            lblRubrikLogin.AutoSize = true;
            lblRubrikLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRubrikLogin.Location = new Point(302, 41);
            lblRubrikLogin.Name = "lblRubrikLogin";
            lblRubrikLogin.Size = new Size(192, 25);
            lblRubrikLogin.TabIndex = 0;
            lblRubrikLogin.Text = "BookSwap – Logga in";
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Location = new Point(242, 101);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(77, 15);
            lblEpost.TabIndex = 1;
            lblEpost.Text = "E-postadress:";
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(242, 119);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(218, 23);
            txtEpost.TabIndex = 2;
            // 
            // lblLosenord
            // 
            lblLosenord.AutoSize = true;
            lblLosenord.Location = new Point(242, 152);
            lblLosenord.Name = "lblLosenord";
            lblLosenord.Size = new Size(59, 15);
            lblLosenord.TabIndex = 3;
            lblLosenord.Text = "Lösenord:";
            // 
            // txtLosenord
            // 
            txtLosenord.Location = new Point(242, 170);
            txtLosenord.Name = "txtLosenord";
            txtLosenord.Size = new Size(218, 23);
            txtLosenord.TabIndex = 4;
            txtLosenord.UseSystemPasswordChar = true;
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoggaIn.Location = new Point(374, 232);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(120, 34);
            btnLoggaIn.TabIndex = 5;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // btnSkapaKonto
            // 
            btnSkapaKonto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSkapaKonto.Location = new Point(357, 272);
            btnSkapaKonto.Name = "btnSkapaKonto";
            btnSkapaKonto.Size = new Size(149, 43);
            btnSkapaKonto.TabIndex = 6;
            btnSkapaKonto.Text = "Skapa nytt konto";
            btnSkapaKonto.UseVisualStyleBackColor = true;
            btnSkapaKonto.Click += btnSkapaKonto_Click;
            // 
            // LoginFoem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSkapaKonto);
            Controls.Add(btnLoggaIn);
            Controls.Add(txtLosenord);
            Controls.Add(lblLosenord);
            Controls.Add(txtEpost);
            Controls.Add(lblEpost);
            Controls.Add(lblRubrikLogin);
            Name = "LoginFoem";
            Text = "LoginFoem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRubrikLogin;
        private Label lblEpost;
        private TextBox txtEpost;
        private Label lblLosenord;
        private TextBox txtLosenord;
        private Button btnLoggaIn;
        private Button btnSkapaKonto;
    }
}