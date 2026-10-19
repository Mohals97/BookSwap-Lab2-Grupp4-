namespace BookSwapGUI
{
    partial class HanteraAnnonserForm
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
            btnGranskaAnnons = new Button();
            dgvAnnonser = new DataGridView();
            btnTaBortAnnons = new Button();
            btnTillbaka = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnnonser).BeginInit();
            SuspendLayout();
            // 
            // btnGranskaAnnons
            // 
            btnGranskaAnnons.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGranskaAnnons.Location = new Point(727, 354);
            btnGranskaAnnons.Name = "btnGranskaAnnons";
            btnGranskaAnnons.Size = new Size(75, 23);
            btnGranskaAnnons.TabIndex = 0;
            btnGranskaAnnons.Text = "Granska annons";
            btnGranskaAnnons.UseVisualStyleBackColor = true;
            btnGranskaAnnons.Click += btnGranskaAnnons_Click;
            // 
            // dgvAnnonser
            // 
            dgvAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnnonser.Location = new Point(-1, 2);
            dgvAnnonser.Name = "dgvAnnonser";
            dgvAnnonser.Size = new Size(945, 247);
            dgvAnnonser.TabIndex = 1;
            // 
            // btnTaBortAnnons
            // 
            btnTaBortAnnons.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaBortAnnons.Location = new Point(478, 354);
            btnTaBortAnnons.Name = "btnTaBortAnnons";
            btnTaBortAnnons.Size = new Size(75, 23);
            btnTaBortAnnons.TabIndex = 2;
            btnTaBortAnnons.Text = "Ta bort annons";
            btnTaBortAnnons.UseVisualStyleBackColor = true;
            btnTaBortAnnons.Click += btnTaBortAnnons_Click;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTillbaka.Location = new Point(259, 354);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(75, 23);
            btnTillbaka.TabIndex = 3;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // HanteraAnnonserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 473);
            Controls.Add(btnTillbaka);
            Controls.Add(btnTaBortAnnons);
            Controls.Add(dgvAnnonser);
            Controls.Add(btnGranskaAnnons);
            Name = "HanteraAnnonserForm";
            Text = "HanteraAnnonserForm";
            ((System.ComponentModel.ISupportInitialize)dgvAnnonser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGranskaAnnons;
        private DataGridView dgvAnnonser;
        private Button btnTaBortAnnons;
        private Button btnTillbaka;
    }
}