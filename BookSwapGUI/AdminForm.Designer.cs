namespace BookSwapGUI
{
    partial class AdminForm
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
            btnHanteraKurser = new Button();
            btnHanteraAnnonser = new Button();
            btnLoggaUt = new Button();
            SuspendLayout();
            // 
            // btnHanteraKurser
            // 
            btnHanteraKurser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHanteraKurser.Location = new Point(347, 150);
            btnHanteraKurser.Name = "btnHanteraKurser";
            btnHanteraKurser.Size = new Size(128, 38);
            btnHanteraKurser.TabIndex = 0;
            btnHanteraKurser.Text = "Hantera kurser";
            btnHanteraKurser.UseVisualStyleBackColor = true;
            btnHanteraKurser.Click += btnHanteraKurser_Click;
            // 
            // btnHanteraAnnonser
            // 
            btnHanteraAnnonser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHanteraAnnonser.Location = new Point(347, 206);
            btnHanteraAnnonser.Name = "btnHanteraAnnonser";
            btnHanteraAnnonser.Size = new Size(128, 31);
            btnHanteraAnnonser.TabIndex = 1;
            btnHanteraAnnonser.Text = "Hantera annonser";
            btnHanteraAnnonser.UseVisualStyleBackColor = true;
            btnHanteraAnnonser.Click += btnHanteraAnnonser_Click;
            // 
            // btnLoggaUt
            // 
            btnLoggaUt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoggaUt.Location = new Point(347, 260);
            btnLoggaUt.Name = "btnLoggaUt";
            btnLoggaUt.Size = new Size(128, 40);
            btnLoggaUt.TabIndex = 2;
            btnLoggaUt.Text = "Logga ut";
            btnLoggaUt.UseVisualStyleBackColor = true;
            btnLoggaUt.Click += btnLoggaUt_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoggaUt);
            Controls.Add(btnHanteraAnnonser);
            Controls.Add(btnHanteraKurser);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHanteraKurser;
        private Button btnHanteraAnnonser;
        private Button btnLoggaUt;
    }
}