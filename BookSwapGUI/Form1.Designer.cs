namespace BookSwapGUI
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
            lblRubrik = new Label();
            dgvAnnonser = new DataGridView();
            btnReservera = new Button();
            btnBekraftaKop = new Button();
            btnMinaAnnonser = new Button();
            btnVisaAlla = new Button();
            btnTaBortAnnons = new Button();
            lblNyTitel = new Label();
            lblNyttPris = new Label();
            txtNyttPris = new TextBox();
            txtNyTitel = new TextBox();
            btnSparaAndringar = new Button();
            btnSkapaAnnons = new Button();
            lblTitel = new Label();
            lblPris = new Label();
            lblSkick = new Label();
            txtSkick = new TextBox();
            txtTitel = new TextBox();
            txtPris = new TextBox();
            cmbAnnonsTyp = new ComboBox();
            label1 = new Label();
            cmbKurs = new ComboBox();
            label2 = new Label();
            btnMinaKop = new Button();
            btnLoggaUt = new Button();
            btnSokAnnons = new Button();
            txtSokAnnons = new TextBox();
            cmbFilterKurs = new ComboBox();
            lblFilterKurs = new Label();
            btnFiltrera = new Button();
            cmbFilterTyp = new ComboBox();
            lblFilterTyp = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAnnonser).BeginInit();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(22, 5);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(230, 30);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Tillgängliga Annonser";
            // 
            // dgvAnnonser
            // 
            dgvAnnonser.AllowUserToAddRows = false;
            dgvAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnnonser.Location = new Point(12, 142);
            dgvAnnonser.MultiSelect = false;
            dgvAnnonser.Name = "dgvAnnonser";
            dgvAnnonser.ReadOnly = true;
            dgvAnnonser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnnonser.Size = new Size(926, 305);
            dgvAnnonser.TabIndex = 1;
            // 
            // btnReservera
            // 
            btnReservera.AutoSize = true;
            btnReservera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservera.Location = new Point(944, 16);
            btnReservera.Name = "btnReservera";
            btnReservera.Size = new Size(163, 48);
            btnReservera.TabIndex = 2;
            btnReservera.Text = "Reservera vald annons";
            btnReservera.UseVisualStyleBackColor = true;
            btnReservera.Click += btnReservera_Click;
            // 
            // btnBekraftaKop
            // 
            btnBekraftaKop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBekraftaKop.Location = new Point(944, 70);
            btnBekraftaKop.Name = "btnBekraftaKop";
            btnBekraftaKop.Size = new Size(163, 57);
            btnBekraftaKop.TabIndex = 3;
            btnBekraftaKop.Text = "Bekräfta köp";
            btnBekraftaKop.UseVisualStyleBackColor = true;
            btnBekraftaKop.Click += btnBekraftaKop_Click;
            // 
            // btnMinaAnnonser
            // 
            btnMinaAnnonser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinaAnnonser.Location = new Point(944, 133);
            btnMinaAnnonser.Name = "btnMinaAnnonser";
            btnMinaAnnonser.Size = new Size(163, 46);
            btnMinaAnnonser.TabIndex = 4;
            btnMinaAnnonser.Text = "Mina annonser";
            btnMinaAnnonser.UseVisualStyleBackColor = true;
            btnMinaAnnonser.Click += btnMinaAnnonser_Click;
            // 
            // btnVisaAlla
            // 
            btnVisaAlla.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisaAlla.Location = new Point(944, 185);
            btnVisaAlla.Name = "btnVisaAlla";
            btnVisaAlla.Size = new Size(163, 57);
            btnVisaAlla.TabIndex = 5;
            btnVisaAlla.Text = "Visa alla annonser";
            btnVisaAlla.UseVisualStyleBackColor = true;
            btnVisaAlla.Click += btnVisaAlla_Click;
            // 
            // btnTaBortAnnons
            // 
            btnTaBortAnnons.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaBortAnnons.Location = new Point(944, 248);
            btnTaBortAnnons.Name = "btnTaBortAnnons";
            btnTaBortAnnons.Size = new Size(163, 65);
            btnTaBortAnnons.TabIndex = 6;
            btnTaBortAnnons.Text = "Ta bort annons";
            btnTaBortAnnons.UseVisualStyleBackColor = true;
            btnTaBortAnnons.Click += btnTaBortAnnons_Click;
            // 
            // lblNyTitel
            // 
            lblNyTitel.AutoSize = true;
            lblNyTitel.Location = new Point(676, 479);
            lblNyTitel.Name = "lblNyTitel";
            lblNyTitel.Size = new Size(48, 15);
            lblNyTitel.TabIndex = 7;
            lblNyTitel.Text = "Ny titel:";
            lblNyTitel.Click += lblNyTitel_Click;
            // 
            // lblNyttPris
            // 
            lblNyttPris.AutoSize = true;
            lblNyttPris.Location = new Point(676, 533);
            lblNyttPris.Name = "lblNyttPris";
            lblNyttPris.Size = new Size(55, 15);
            lblNyttPris.TabIndex = 8;
            lblNyttPris.Text = "Nytt pris:";
            lblNyttPris.Click += lblNyttPris_Click;
            // 
            // txtNyttPris
            // 
            txtNyttPris.Location = new Point(743, 525);
            txtNyttPris.Name = "txtNyttPris";
            txtNyttPris.Size = new Size(158, 23);
            txtNyttPris.TabIndex = 9;
            // 
            // txtNyTitel
            // 
            txtNyTitel.Location = new Point(743, 471);
            txtNyTitel.Name = "txtNyTitel";
            txtNyTitel.Size = new Size(158, 23);
            txtNyTitel.TabIndex = 10;
            // 
            // btnSparaAndringar
            // 
            btnSparaAndringar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSparaAndringar.Location = new Point(944, 324);
            btnSparaAndringar.Name = "btnSparaAndringar";
            btnSparaAndringar.Size = new Size(163, 50);
            btnSparaAndringar.TabIndex = 11;
            btnSparaAndringar.Text = "Spara ändringar";
            btnSparaAndringar.UseVisualStyleBackColor = true;
            btnSparaAndringar.Click += btnSparaAndringar_Click;
            // 
            // btnSkapaAnnons
            // 
            btnSkapaAnnons.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSkapaAnnons.Location = new Point(944, 380);
            btnSkapaAnnons.Name = "btnSkapaAnnons";
            btnSkapaAnnons.Size = new Size(163, 51);
            btnSkapaAnnons.TabIndex = 12;
            btnSkapaAnnons.Text = "Skapa annons";
            btnSkapaAnnons.UseVisualStyleBackColor = true;
            btnSkapaAnnons.Click += btnSkapaAnnons_Click;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(21, 479);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(33, 15);
            lblTitel.TabIndex = 13;
            lblTitel.Text = "Titel:";
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(21, 533);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(29, 15);
            lblPris.TabIndex = 14;
            lblPris.Text = "Pris:";
            // 
            // lblSkick
            // 
            lblSkick.AutoSize = true;
            lblSkick.Location = new Point(21, 581);
            lblSkick.Name = "lblSkick";
            lblSkick.Size = new Size(37, 15);
            lblSkick.TabIndex = 15;
            lblSkick.Text = "Skick:";
            // 
            // txtSkick
            // 
            txtSkick.Location = new Point(98, 578);
            txtSkick.Name = "txtSkick";
            txtSkick.Size = new Size(201, 23);
            txtSkick.TabIndex = 16;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(98, 479);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(201, 23);
            txtTitel.TabIndex = 17;
            // 
            // txtPris
            // 
            txtPris.Location = new Point(98, 525);
            txtPris.Name = "txtPris";
            txtPris.Size = new Size(201, 23);
            txtPris.TabIndex = 18;
            // 
            // cmbAnnonsTyp
            // 
            cmbAnnonsTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnnonsTyp.FormattingEnabled = true;
            cmbAnnonsTyp.Location = new Point(98, 617);
            cmbAnnonsTyp.Name = "cmbAnnonsTyp";
            cmbAnnonsTyp.Size = new Size(201, 23);
            cmbAnnonsTyp.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 620);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 20;
            label1.Text = "Annonstyp:";
            // 
            // cmbKurs
            // 
            cmbKurs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKurs.FormattingEnabled = true;
            cmbKurs.Location = new Point(98, 662);
            cmbKurs.Name = "cmbKurs";
            cmbKurs.Size = new Size(201, 23);
            cmbKurs.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 670);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 22;
            label2.Text = "Kurs:";
            // 
            // btnMinaKop
            // 
            btnMinaKop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinaKop.Location = new Point(944, 447);
            btnMinaKop.Name = "btnMinaKop";
            btnMinaKop.Size = new Size(163, 49);
            btnMinaKop.TabIndex = 23;
            btnMinaKop.Text = "Mina köp";
            btnMinaKop.UseVisualStyleBackColor = true;
            btnMinaKop.Click += btnMinaKop_Click;
            // 
            // btnLoggaUt
            // 
            btnLoggaUt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoggaUt.Location = new Point(944, 509);
            btnLoggaUt.Name = "btnLoggaUt";
            btnLoggaUt.Size = new Size(163, 51);
            btnLoggaUt.TabIndex = 24;
            btnLoggaUt.Text = "Logga ut";
            btnLoggaUt.UseVisualStyleBackColor = true;
            btnLoggaUt.Click += btnLoggaUt_Click;
            // 
            // btnSokAnnons
            // 
            btnSokAnnons.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSokAnnons.Location = new Point(22, 49);
            btnSokAnnons.Name = "btnSokAnnons";
            btnSokAnnons.Size = new Size(93, 40);
            btnSokAnnons.TabIndex = 25;
            btnSokAnnons.Text = "Sök annons";
            btnSokAnnons.UseVisualStyleBackColor = true;
            btnSokAnnons.Click += btnSokAnnons_Click;
            // 
            // txtSokAnnons
            // 
            txtSokAnnons.Location = new Point(121, 60);
            txtSokAnnons.Name = "txtSokAnnons";
            txtSokAnnons.Size = new Size(808, 23);
            txtSokAnnons.TabIndex = 26;
            // 
            // cmbFilterKurs
            // 
            cmbFilterKurs.FormattingEnabled = true;
            cmbFilterKurs.Location = new Point(137, 104);
            cmbFilterKurs.Name = "cmbFilterKurs";
            cmbFilterKurs.Size = new Size(182, 23);
            cmbFilterKurs.TabIndex = 27;
            // 
            // lblFilterKurs
            // 
            lblFilterKurs.AutoSize = true;
            lblFilterKurs.Location = new Point(22, 108);
            lblFilterKurs.Name = "lblFilterKurs";
            lblFilterKurs.Size = new Size(95, 15);
            lblFilterKurs.TabIndex = 28;
            lblFilterKurs.Text = "Filtrera efter kurs";
            // 
            // btnFiltrera
            // 
            btnFiltrera.Location = new Point(775, 104);
            btnFiltrera.Name = "btnFiltrera";
            btnFiltrera.Size = new Size(75, 23);
            btnFiltrera.TabIndex = 29;
            btnFiltrera.Text = "Filtrera";
            btnFiltrera.UseVisualStyleBackColor = true;
            btnFiltrera.Click += btnFiltrera_Click;
            // 
            // cmbFilterTyp
            // 
            cmbFilterTyp.FormattingEnabled = true;
            cmbFilterTyp.Location = new Point(587, 104);
            cmbFilterTyp.Name = "cmbFilterTyp";
            cmbFilterTyp.Size = new Size(182, 23);
            cmbFilterTyp.TabIndex = 30;
            // 
            // lblFilterTyp
            // 
            lblFilterTyp.AutoSize = true;
            lblFilterTyp.Location = new Point(452, 108);
            lblFilterTyp.Name = "lblFilterTyp";
            lblFilterTyp.Size = new Size(129, 15);
            lblFilterTyp.TabIndex = 31;
            lblFilterTyp.Text = "Filtrera efter annonstyp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 728);
            Controls.Add(lblFilterTyp);
            Controls.Add(cmbFilterTyp);
            Controls.Add(btnFiltrera);
            Controls.Add(lblFilterKurs);
            Controls.Add(cmbFilterKurs);
            Controls.Add(txtSokAnnons);
            Controls.Add(btnSokAnnons);
            Controls.Add(btnLoggaUt);
            Controls.Add(btnMinaKop);
            Controls.Add(label2);
            Controls.Add(cmbKurs);
            Controls.Add(label1);
            Controls.Add(cmbAnnonsTyp);
            Controls.Add(txtPris);
            Controls.Add(txtTitel);
            Controls.Add(txtSkick);
            Controls.Add(lblSkick);
            Controls.Add(lblPris);
            Controls.Add(lblTitel);
            Controls.Add(btnSkapaAnnons);
            Controls.Add(btnSparaAndringar);
            Controls.Add(txtNyTitel);
            Controls.Add(txtNyttPris);
            Controls.Add(lblNyttPris);
            Controls.Add(lblNyTitel);
            Controls.Add(btnTaBortAnnons);
            Controls.Add(btnVisaAlla);
            Controls.Add(btnMinaAnnonser);
            Controls.Add(btnBekraftaKop);
            Controls.Add(btnReservera);
            Controls.Add(dgvAnnonser);
            Controls.Add(lblRubrik);
            Name = "Form1";
            Text = "BookSwap – Tillgängliga annonser";
            ((System.ComponentModel.ISupportInitialize)dgvAnnonser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRubrik;
        private DataGridView dgvAnnonser;
        private Button btnReservera;
        private Button btnBekraftaKop;
        private Button btnMinaAnnonser;
        private Button btnVisaAlla;
        private Button btnTaBortAnnons;
        private Label lblNyTitel;
        private Label lblNyttPris;
        private TextBox txtNyttPris;
        private TextBox txtNyTitel;
        private Button btnSparaAndringar;
        private Button btnSkapaAnnons;
        private Label lblTitel;
        private Label lblPris;
        private Label lblSkick;
        private TextBox txtSkick;
        private TextBox txtTitel;
        private TextBox txtPris;
        private ComboBox cmbAnnonsTyp;
        private Label label1;
        private ComboBox cmbKurs;
        private Label label2;
        private Button btnMinaKop;
        private Button btnLoggaUt;
        private Button btnSokAnnons;
        private TextBox txtSokAnnons;
        private ComboBox cmbFilterKurs;
        private Label lblFilterKurs;
        private Button btnFiltrera;
        private ComboBox cmbFilterTyp;
        private Label lblFilterTyp;
    }
}
