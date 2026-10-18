namespace BookSwapGUI
{
    partial class HanteraKurserForm
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
            dgvKurser = new DataGridView();
            lblKurskod = new Label();
            lblKursnamn = new Label();
            txtKurskod = new TextBox();
            txtKursnamn = new TextBox();
            btnLaggTillKurs = new Button();
            btnRedigeraKurs = new Button();
            btnTaBortKurs = new Button();
            btnTillbaka = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKurser).BeginInit();
            SuspendLayout();
            // 
            // dgvKurser
            // 
            dgvKurser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKurser.Location = new Point(12, 12);
            dgvKurser.Name = "dgvKurser";
            dgvKurser.Size = new Size(921, 221);
            dgvKurser.TabIndex = 0;
            dgvKurser.CellClick += dgvKurser_CellClick;
            // 
            // lblKurskod
            // 
            lblKurskod.AutoSize = true;
            lblKurskod.Location = new Point(204, 247);
            lblKurskod.Name = "lblKurskod";
            lblKurskod.Size = new Size(50, 15);
            lblKurskod.TabIndex = 1;
            lblKurskod.Text = "Kurskod";
            // 
            // lblKursnamn
            // 
            lblKursnamn.AutoSize = true;
            lblKursnamn.Location = new Point(417, 247);
            lblKursnamn.Name = "lblKursnamn";
            lblKursnamn.Size = new Size(61, 15);
            lblKursnamn.TabIndex = 2;
            lblKursnamn.Text = "Kursnamn";
            // 
            // txtKurskod
            // 
            txtKurskod.Location = new Point(204, 269);
            txtKurskod.Name = "txtKurskod";
            txtKurskod.Size = new Size(182, 23);
            txtKurskod.TabIndex = 3;
            // 
            // txtKursnamn
            // 
            txtKursnamn.Location = new Point(417, 269);
            txtKursnamn.Name = "txtKursnamn";
            txtKursnamn.Size = new Size(167, 23);
            txtKursnamn.TabIndex = 4;
            // 
            // btnLaggTillKurs
            // 
            btnLaggTillKurs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaggTillKurs.Location = new Point(190, 342);
            btnLaggTillKurs.Name = "btnLaggTillKurs";
            btnLaggTillKurs.Size = new Size(91, 31);
            btnLaggTillKurs.TabIndex = 5;
            btnLaggTillKurs.Text = "Lägg till";
            btnLaggTillKurs.UseVisualStyleBackColor = true;
            btnLaggTillKurs.Click += btnLaggTillKurs_Click;
            // 
            // btnRedigeraKurs
            // 
            btnRedigeraKurs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedigeraKurs.Location = new Point(390, 342);
            btnRedigeraKurs.Name = "btnRedigeraKurs";
            btnRedigeraKurs.Size = new Size(88, 31);
            btnRedigeraKurs.TabIndex = 6;
            btnRedigeraKurs.Text = "Redigera";
            btnRedigeraKurs.UseVisualStyleBackColor = true;
            btnRedigeraKurs.Click += btnRedigeraKurs_Click;
            // 
            // btnTaBortKurs
            // 
            btnTaBortKurs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaBortKurs.Location = new Point(581, 342);
            btnTaBortKurs.Name = "btnTaBortKurs";
            btnTaBortKurs.Size = new Size(89, 31);
            btnTaBortKurs.TabIndex = 7;
            btnTaBortKurs.Text = "Ta bort";
            btnTaBortKurs.UseVisualStyleBackColor = true;
            btnTaBortKurs.Click += btnTaBortKurs_Click;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTillbaka.Location = new Point(846, 410);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(87, 28);
            btnTillbaka.TabIndex = 8;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            // 
            // HanteraKurserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(btnTillbaka);
            Controls.Add(btnTaBortKurs);
            Controls.Add(btnRedigeraKurs);
            Controls.Add(btnLaggTillKurs);
            Controls.Add(txtKursnamn);
            Controls.Add(txtKurskod);
            Controls.Add(lblKursnamn);
            Controls.Add(lblKurskod);
            Controls.Add(dgvKurser);
            Name = "HanteraKurserForm";
            Text = "HanteraKurserForm";
            ((System.ComponentModel.ISupportInitialize)dgvKurser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKurser;
        private Label lblKurskod;
        private Label lblKursnamn;
        private TextBox txtKurskod;
        private TextBox txtKursnamn;
        private Button btnLaggTillKurs;
        private Button btnRedigeraKurs;
        private Button btnTaBortKurs;
        private Button btnTillbaka;
    }
}