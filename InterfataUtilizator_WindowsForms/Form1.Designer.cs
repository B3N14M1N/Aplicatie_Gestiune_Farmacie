﻿namespace InterfataUtilizator_WindowsForms
{
    partial class Form1
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
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.numericUpDownCantitate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPret = new System.Windows.Forms.NumericUpDown();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.rdbContainer = new System.Windows.Forms.Panel();
            this.rdbBandaje = new System.Windows.Forms.RadioButton();
            this.rdbPulbere = new System.Windows.Forms.RadioButton();
            this.rdbPicaturi = new System.Windows.Forms.RadioButton();
            this.rdbSupozitoare = new System.Windows.Forms.RadioButton();
            this.rdbCapsule = new System.Windows.Forms.RadioButton();
            this.rdbSirop = new System.Windows.Forms.RadioButton();
            this.rdbCrema = new System.Windows.Forms.RadioButton();
            this.rdbFiole = new System.Windows.Forms.RadioButton();
            this.rdbComprimate = new System.Windows.Forms.RadioButton();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.lblOptiuni = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbExpirare = new System.Windows.Forms.CheckBox();
            this.ckbPrescriptie = new System.Windows.Forms.CheckBox();
            this.pnlAdauga = new System.Windows.Forms.Panel();
            this.btnCautaMeniu = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.pnlCautare = new System.Windows.Forms.Panel();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnAdaugaMeniu = new System.Windows.Forms.Button();
            this.lblCautareMesaj = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownCautarePret = new System.Windows.Forms.NumericUpDown();
            this.lblCautarePret = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCautareTip = new System.Windows.Forms.Label();
            this.pnlCautareNume = new System.Windows.Forms.Panel();
            this.txtCautareNume = new System.Windows.Forms.TextBox();
            this.lblCautareNume = new System.Windows.Forms.Label();
            this.lblCriteriu = new System.Windows.Forms.Label();
            this.cmbFiltru = new System.Windows.Forms.ComboBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.pnlEditare = new System.Windows.Forms.Panel();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblEditareMesaj = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ckbEditareExpirare = new System.Windows.Forms.CheckBox();
            this.ckbEditarePrescriptie = new System.Windows.Forms.CheckBox();
            this.lblEditareOptiuni = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lblEditareTip = new System.Windows.Forms.Label();
            this.numericUpDownEditarePret = new System.Windows.Forms.NumericUpDown();
            this.lblEditarePret = new System.Windows.Forms.Label();
            this.numericUpDownEditareCantitate = new System.Windows.Forms.NumericUpDown();
            this.lblEditareCantitate = new System.Windows.Forms.Label();
            this.txtEditareDescriere = new System.Windows.Forms.TextBox();
            this.lblEditareDescriere = new System.Windows.Forms.Label();
            this.txtEditareNume = new System.Windows.Forms.TextBox();
            this.lblEditareNume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret)).BeginInit();
            this.rdbContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdauga.SuspendLayout();
            this.pnlCautare.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCautarePret)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlCautareNume.SuspendLayout();
            this.pnlEditare.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditarePret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditareCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNume.Location = new System.Drawing.Point(21, 31);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(71, 27);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(154, 38);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(291, 20);
            this.txtNume.TabIndex = 1;
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(154, 248);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(291, 77);
            this.txtDescriere.TabIndex = 3;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescriere.Location = new System.Drawing.Point(21, 241);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(109, 27);
            this.lblDescriere.TabIndex = 11;
            this.lblDescriere.Text = "Descriere:";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCantitate.Location = new System.Drawing.Point(21, 339);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(107, 27);
            this.lblCantitate.TabIndex = 12;
            this.lblCantitate.Text = "Cantitate:";
            // 
            // numericUpDownCantitate
            // 
            this.numericUpDownCantitate.Location = new System.Drawing.Point(154, 346);
            this.numericUpDownCantitate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCantitate.Name = "numericUpDownCantitate";
            this.numericUpDownCantitate.Size = new System.Drawing.Size(290, 20);
            this.numericUpDownCantitate.TabIndex = 4;
            this.numericUpDownCantitate.ThousandsSeparator = true;
            // 
            // numericUpDownPret
            // 
            this.numericUpDownPret.DecimalPlaces = 2;
            this.numericUpDownPret.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownPret.Location = new System.Drawing.Point(154, 396);
            this.numericUpDownPret.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPret.Name = "numericUpDownPret";
            this.numericUpDownPret.Size = new System.Drawing.Size(290, 20);
            this.numericUpDownPret.TabIndex = 5;
            this.numericUpDownPret.ThousandsSeparator = true;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPret.Location = new System.Drawing.Point(23, 389);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(59, 27);
            this.lblPret.TabIndex = 13;
            this.lblPret.Text = "Pret:";
            // 
            // lblTip
            // 
            this.lblTip.AutoEllipsis = true;
            this.lblTip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.Location = new System.Drawing.Point(21, 75);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(129, 54);
            this.lblTip.TabIndex = 10;
            this.lblTip.Text = "Tip medicament:";
            // 
            // rdbContainer
            // 
            this.rdbContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rdbContainer.Controls.Add(this.rdbBandaje);
            this.rdbContainer.Controls.Add(this.rdbPulbere);
            this.rdbContainer.Controls.Add(this.rdbPicaturi);
            this.rdbContainer.Controls.Add(this.rdbSupozitoare);
            this.rdbContainer.Controls.Add(this.rdbCapsule);
            this.rdbContainer.Controls.Add(this.rdbSirop);
            this.rdbContainer.Controls.Add(this.rdbCrema);
            this.rdbContainer.Controls.Add(this.rdbFiole);
            this.rdbContainer.Controls.Add(this.rdbComprimate);
            this.rdbContainer.Location = new System.Drawing.Point(155, 78);
            this.rdbContainer.Name = "rdbContainer";
            this.rdbContainer.Size = new System.Drawing.Size(290, 154);
            this.rdbContainer.TabIndex = 2;
            // 
            // rdbBandaje
            // 
            this.rdbBandaje.AutoSize = true;
            this.rdbBandaje.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbBandaje.Location = new System.Drawing.Point(167, 93);
            this.rdbBandaje.Name = "rdbBandaje";
            this.rdbBandaje.Size = new System.Drawing.Size(66, 20);
            this.rdbBandaje.TabIndex = 7;
            this.rdbBandaje.TabStop = true;
            this.rdbBandaje.Text = "Bandaje";
            this.rdbBandaje.UseVisualStyleBackColor = true;
            // 
            // rdbPulbere
            // 
            this.rdbPulbere.AutoSize = true;
            this.rdbPulbere.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbPulbere.Location = new System.Drawing.Point(37, 93);
            this.rdbPulbere.Name = "rdbPulbere";
            this.rdbPulbere.Size = new System.Drawing.Size(64, 20);
            this.rdbPulbere.TabIndex = 6;
            this.rdbPulbere.TabStop = true;
            this.rdbPulbere.Text = "Pulbere";
            this.rdbPulbere.UseVisualStyleBackColor = true;
            // 
            // rdbPicaturi
            // 
            this.rdbPicaturi.AutoSize = true;
            this.rdbPicaturi.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbPicaturi.Location = new System.Drawing.Point(167, 41);
            this.rdbPicaturi.Name = "rdbPicaturi";
            this.rdbPicaturi.Size = new System.Drawing.Size(65, 20);
            this.rdbPicaturi.TabIndex = 3;
            this.rdbPicaturi.TabStop = true;
            this.rdbPicaturi.Text = "Picaturi";
            this.rdbPicaturi.UseVisualStyleBackColor = true;
            // 
            // rdbSupozitoare
            // 
            this.rdbSupozitoare.AutoSize = true;
            this.rdbSupozitoare.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbSupozitoare.Location = new System.Drawing.Point(37, 67);
            this.rdbSupozitoare.Name = "rdbSupozitoare";
            this.rdbSupozitoare.Size = new System.Drawing.Size(88, 20);
            this.rdbSupozitoare.TabIndex = 4;
            this.rdbSupozitoare.TabStop = true;
            this.rdbSupozitoare.Text = "Supozitoare";
            this.rdbSupozitoare.UseVisualStyleBackColor = true;
            // 
            // rdbCapsule
            // 
            this.rdbCapsule.AutoSize = true;
            this.rdbCapsule.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbCapsule.Location = new System.Drawing.Point(37, 41);
            this.rdbCapsule.Name = "rdbCapsule";
            this.rdbCapsule.Size = new System.Drawing.Size(64, 20);
            this.rdbCapsule.TabIndex = 2;
            this.rdbCapsule.TabStop = true;
            this.rdbCapsule.Text = "Capsule";
            this.rdbCapsule.UseVisualStyleBackColor = true;
            // 
            // rdbSirop
            // 
            this.rdbSirop.AutoSize = true;
            this.rdbSirop.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbSirop.Location = new System.Drawing.Point(167, 67);
            this.rdbSirop.Name = "rdbSirop";
            this.rdbSirop.Size = new System.Drawing.Size(53, 20);
            this.rdbSirop.TabIndex = 5;
            this.rdbSirop.TabStop = true;
            this.rdbSirop.Text = "Sirop";
            this.rdbSirop.UseVisualStyleBackColor = true;
            // 
            // rdbCrema
            // 
            this.rdbCrema.AutoSize = true;
            this.rdbCrema.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbCrema.Location = new System.Drawing.Point(167, 15);
            this.rdbCrema.Name = "rdbCrema";
            this.rdbCrema.Size = new System.Drawing.Size(58, 20);
            this.rdbCrema.TabIndex = 1;
            this.rdbCrema.TabStop = true;
            this.rdbCrema.Text = "Crema";
            this.rdbCrema.UseVisualStyleBackColor = true;
            // 
            // rdbFiole
            // 
            this.rdbFiole.AutoSize = true;
            this.rdbFiole.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbFiole.Location = new System.Drawing.Point(37, 119);
            this.rdbFiole.Name = "rdbFiole";
            this.rdbFiole.Size = new System.Drawing.Size(50, 20);
            this.rdbFiole.TabIndex = 8;
            this.rdbFiole.TabStop = true;
            this.rdbFiole.Text = "Fiole";
            this.rdbFiole.UseVisualStyleBackColor = true;
            // 
            // rdbComprimate
            // 
            this.rdbComprimate.AutoSize = true;
            this.rdbComprimate.Checked = true;
            this.rdbComprimate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbComprimate.Location = new System.Drawing.Point(37, 15);
            this.rdbComprimate.Name = "rdbComprimate";
            this.rdbComprimate.Size = new System.Drawing.Size(87, 20);
            this.rdbComprimate.TabIndex = 0;
            this.rdbComprimate.TabStop = true;
            this.rdbComprimate.Text = "Comprimate";
            this.rdbComprimate.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdauga.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga.Location = new System.Drawing.Point(208, 587);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 39);
            this.btnAdauga.TabIndex = 7;
            this.btnAdauga.Text = "&Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAfiseaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAfiseaza.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAfiseaza.Location = new System.Drawing.Point(354, 587);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(124, 39);
            this.btnAfiseaza.TabIndex = 8;
            this.btnAfiseaza.Text = "A&fiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = false;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // lblOptiuni
            // 
            this.lblOptiuni.AutoSize = true;
            this.lblOptiuni.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOptiuni.Location = new System.Drawing.Point(23, 448);
            this.lblOptiuni.Name = "lblOptiuni";
            this.lblOptiuni.Size = new System.Drawing.Size(84, 27);
            this.lblOptiuni.TabIndex = 14;
            this.lblOptiuni.Text = "Optiuni:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ckbExpirare);
            this.panel1.Controls.Add(this.ckbPrescriptie);
            this.panel1.Location = new System.Drawing.Point(154, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 85);
            this.panel1.TabIndex = 6;
            // 
            // ckbExpirare
            // 
            this.ckbExpirare.AutoSize = true;
            this.ckbExpirare.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbExpirare.Location = new System.Drawing.Point(45, 45);
            this.ckbExpirare.Name = "ckbExpirare";
            this.ckbExpirare.Size = new System.Drawing.Size(175, 25);
            this.ckbExpirare.TabIndex = 1;
            this.ckbExpirare.Text = "Cu data de expirare";
            this.ckbExpirare.UseVisualStyleBackColor = true;
            this.ckbExpirare.CheckedChanged += new System.EventHandler(this.CkbOptiuni_CheckedChanged);
            // 
            // ckbPrescriptie
            // 
            this.ckbPrescriptie.AutoSize = true;
            this.ckbPrescriptie.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbPrescriptie.Location = new System.Drawing.Point(45, 14);
            this.ckbPrescriptie.Name = "ckbPrescriptie";
            this.ckbPrescriptie.Size = new System.Drawing.Size(197, 25);
            this.ckbPrescriptie.TabIndex = 0;
            this.ckbPrescriptie.Text = "Cu prescriptie medicala";
            this.ckbPrescriptie.UseVisualStyleBackColor = true;
            this.ckbPrescriptie.CheckedChanged += new System.EventHandler(this.CkbOptiuni_CheckedChanged);
            // 
            // pnlAdauga
            // 
            this.pnlAdauga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAdauga.Controls.Add(this.rdbContainer);
            this.pnlAdauga.Controls.Add(this.btnCautaMeniu);
            this.pnlAdauga.Controls.Add(this.lblMesaj);
            this.pnlAdauga.Controls.Add(this.panel1);
            this.pnlAdauga.Controls.Add(this.lblOptiuni);
            this.pnlAdauga.Controls.Add(this.btnAfiseaza);
            this.pnlAdauga.Controls.Add(this.btnAdauga);
            this.pnlAdauga.Controls.Add(this.lblTip);
            this.pnlAdauga.Controls.Add(this.numericUpDownPret);
            this.pnlAdauga.Controls.Add(this.lblPret);
            this.pnlAdauga.Controls.Add(this.numericUpDownCantitate);
            this.pnlAdauga.Controls.Add(this.lblCantitate);
            this.pnlAdauga.Controls.Add(this.txtDescriere);
            this.pnlAdauga.Controls.Add(this.lblDescriere);
            this.pnlAdauga.Controls.Add(this.txtNume);
            this.pnlAdauga.Controls.Add(this.lblNume);
            this.pnlAdauga.Location = new System.Drawing.Point(15, 9);
            this.pnlAdauga.Name = "pnlAdauga";
            this.pnlAdauga.Size = new System.Drawing.Size(530, 657);
            this.pnlAdauga.TabIndex = 16;
            this.pnlAdauga.Click += new System.EventHandler(this.PnlAdauga_Click);
            // 
            // btnCautaMeniu
            // 
            this.btnCautaMeniu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCautaMeniu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCautaMeniu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCautaMeniu.Location = new System.Drawing.Point(26, 587);
            this.btnCautaMeniu.Name = "btnCautaMeniu";
            this.btnCautaMeniu.Size = new System.Drawing.Size(124, 39);
            this.btnCautaMeniu.TabIndex = 16;
            this.btnCautaMeniu.Text = "Cau&ta";
            this.btnCautaMeniu.UseVisualStyleBackColor = false;
            this.btnCautaMeniu.Click += new System.EventHandler(this.BtnSelecteazaCautarea_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMesaj.Location = new System.Drawing.Point(165, 547);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMesaj.Size = new System.Drawing.Size(270, 27);
            this.lblMesaj.TabIndex = 15;
            this.lblMesaj.Text = "ADAUGAT CU SUCCES";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMesaj.Visible = false;
            // 
            // pnlCautare
            // 
            this.pnlCautare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCautare.Controls.Add(this.btnEditeaza);
            this.pnlCautare.Controls.Add(this.btnAdaugaMeniu);
            this.pnlCautare.Controls.Add(this.lblCautareMesaj);
            this.pnlCautare.Controls.Add(this.panel4);
            this.pnlCautare.Controls.Add(this.panel2);
            this.pnlCautare.Controls.Add(this.pnlCautareNume);
            this.pnlCautare.Controls.Add(this.lblCriteriu);
            this.pnlCautare.Controls.Add(this.cmbFiltru);
            this.pnlCautare.Controls.Add(this.btnCauta);
            this.pnlCautare.Enabled = false;
            this.pnlCautare.Location = new System.Drawing.Point(18, 7);
            this.pnlCautare.Name = "pnlCautare";
            this.pnlCautare.Size = new System.Drawing.Size(530, 657);
            this.pnlCautare.TabIndex = 17;
            this.pnlCautare.Visible = false;
            this.pnlCautare.Click += new System.EventHandler(this.PnlCauta_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditeaza.Enabled = false;
            this.btnEditeaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditeaza.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditeaza.Location = new System.Drawing.Point(221, 587);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(124, 39);
            this.btnEditeaza.TabIndex = 18;
            this.btnEditeaza.Text = "&Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = false;
            this.btnEditeaza.Click += new System.EventHandler(this.BtnSelecteazaEditarea_Click);
            // 
            // btnAdaugaMeniu
            // 
            this.btnAdaugaMeniu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdaugaMeniu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugaMeniu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaMeniu.Location = new System.Drawing.Point(29, 587);
            this.btnAdaugaMeniu.Name = "btnAdaugaMeniu";
            this.btnAdaugaMeniu.Size = new System.Drawing.Size(124, 39);
            this.btnAdaugaMeniu.TabIndex = 17;
            this.btnAdaugaMeniu.Text = "A&dauga";
            this.btnAdaugaMeniu.UseVisualStyleBackColor = false;
            this.btnAdaugaMeniu.Click += new System.EventHandler(this.BtnSelecteazaAdaugarea_Click);
            // 
            // lblCautareMesaj
            // 
            this.lblCautareMesaj.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCautareMesaj.Location = new System.Drawing.Point(152, 490);
            this.lblCautareMesaj.Name = "lblCautareMesaj";
            this.lblCautareMesaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCautareMesaj.Size = new System.Drawing.Size(270, 27);
            this.lblCautareMesaj.TabIndex = 16;
            this.lblCautareMesaj.Text = "GASIT CU SUCCES";
            this.lblCautareMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCautareMesaj.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.numericUpDownCautarePret);
            this.panel4.Controls.Add(this.lblCautarePret);
            this.panel4.Location = new System.Drawing.Point(45, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 72);
            this.panel4.TabIndex = 12;
            // 
            // numericUpDownCautarePret
            // 
            this.numericUpDownCautarePret.DecimalPlaces = 2;
            this.numericUpDownCautarePret.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownCautarePret.Location = new System.Drawing.Point(154, 29);
            this.numericUpDownCautarePret.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCautarePret.Name = "numericUpDownCautarePret";
            this.numericUpDownCautarePret.Size = new System.Drawing.Size(281, 20);
            this.numericUpDownCautarePret.TabIndex = 14;
            this.numericUpDownCautarePret.ThousandsSeparator = true;
            // 
            // lblCautarePret
            // 
            this.lblCautarePret.AutoSize = true;
            this.lblCautarePret.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCautarePret.Location = new System.Drawing.Point(23, 22);
            this.lblCautarePret.Name = "lblCautarePret";
            this.lblCautarePret.Size = new System.Drawing.Size(59, 27);
            this.lblCautarePret.TabIndex = 15;
            this.lblCautarePret.Text = "Pret:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblCautareTip);
            this.panel2.Location = new System.Drawing.Point(45, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 188);
            this.panel2.TabIndex = 12;
            // 
            // lblCautareTip
            // 
            this.lblCautareTip.AutoEllipsis = true;
            this.lblCautareTip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCautareTip.Location = new System.Drawing.Point(11, 25);
            this.lblCautareTip.Name = "lblCautareTip";
            this.lblCautareTip.Size = new System.Drawing.Size(139, 101);
            this.lblCautareTip.TabIndex = 12;
            this.lblCautareTip.Text = "Tip medicament:";
            // 
            // pnlCautareNume
            // 
            this.pnlCautareNume.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlCautareNume.Controls.Add(this.txtCautareNume);
            this.pnlCautareNume.Controls.Add(this.lblCautareNume);
            this.pnlCautareNume.Location = new System.Drawing.Point(45, 90);
            this.pnlCautareNume.Name = "pnlCautareNume";
            this.pnlCautareNume.Size = new System.Drawing.Size(449, 72);
            this.pnlCautareNume.TabIndex = 11;
            // 
            // txtCautareNume
            // 
            this.txtCautareNume.Location = new System.Drawing.Point(144, 27);
            this.txtCautareNume.Name = "txtCautareNume";
            this.txtCautareNume.Size = new System.Drawing.Size(291, 20);
            this.txtCautareNume.TabIndex = 3;
            // 
            // lblCautareNume
            // 
            this.lblCautareNume.AutoSize = true;
            this.lblCautareNume.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCautareNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCautareNume.Location = new System.Drawing.Point(11, 20);
            this.lblCautareNume.Name = "lblCautareNume";
            this.lblCautareNume.Size = new System.Drawing.Size(71, 27);
            this.lblCautareNume.TabIndex = 2;
            this.lblCautareNume.Text = "Nume:";
            // 
            // lblCriteriu
            // 
            this.lblCriteriu.AutoSize = true;
            this.lblCriteriu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCriteriu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCriteriu.Location = new System.Drawing.Point(24, 31);
            this.lblCriteriu.Name = "lblCriteriu";
            this.lblCriteriu.Size = new System.Drawing.Size(199, 27);
            this.lblCriteriu.TabIndex = 10;
            this.lblCriteriu.Text = "Criteriu de cautare:";
            // 
            // cmbFiltru
            // 
            this.cmbFiltru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltru.FormattingEnabled = true;
            this.cmbFiltru.Items.AddRange(new object[] {
            "NUME",
            "TIP",
            "PRET"});
            this.cmbFiltru.Location = new System.Drawing.Point(266, 37);
            this.cmbFiltru.Name = "cmbFiltru";
            this.cmbFiltru.Size = new System.Drawing.Size(228, 21);
            this.cmbFiltru.TabIndex = 9;
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauta.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCauta.Location = new System.Drawing.Point(356, 587);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(124, 39);
            this.btnCauta.TabIndex = 7;
            this.btnCauta.Text = "&Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.BtnCauta_Click);
            // 
            // pnlEditare
            // 
            this.pnlEditare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEditare.Controls.Add(this.btnInapoi);
            this.pnlEditare.Controls.Add(this.lblEditareMesaj);
            this.pnlEditare.Controls.Add(this.panel6);
            this.pnlEditare.Controls.Add(this.lblEditareOptiuni);
            this.pnlEditare.Controls.Add(this.btnSalvare);
            this.pnlEditare.Controls.Add(this.btnSterge);
            this.pnlEditare.Controls.Add(this.lblEditareTip);
            this.pnlEditare.Controls.Add(this.numericUpDownEditarePret);
            this.pnlEditare.Controls.Add(this.lblEditarePret);
            this.pnlEditare.Controls.Add(this.numericUpDownEditareCantitate);
            this.pnlEditare.Controls.Add(this.lblEditareCantitate);
            this.pnlEditare.Controls.Add(this.txtEditareDescriere);
            this.pnlEditare.Controls.Add(this.lblEditareDescriere);
            this.pnlEditare.Controls.Add(this.txtEditareNume);
            this.pnlEditare.Controls.Add(this.lblEditareNume);
            this.pnlEditare.Enabled = false;
            this.pnlEditare.Location = new System.Drawing.Point(12, 12);
            this.pnlEditare.Name = "pnlEditare";
            this.pnlEditare.Size = new System.Drawing.Size(530, 657);
            this.pnlEditare.TabIndex = 18;
            this.pnlEditare.Visible = false;
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInapoi.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(26, 587);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(124, 39);
            this.btnInapoi.TabIndex = 16;
            this.btnInapoi.Text = "I&napoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.BtnInapoi_Click);
            // 
            // lblEditareMesaj
            // 
            this.lblEditareMesaj.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditareMesaj.Location = new System.Drawing.Point(165, 547);
            this.lblEditareMesaj.Name = "lblEditareMesaj";
            this.lblEditareMesaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEditareMesaj.Size = new System.Drawing.Size(270, 27);
            this.lblEditareMesaj.TabIndex = 15;
            this.lblEditareMesaj.Text = "ADAUGAT CU SUCCES";
            this.lblEditareMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditareMesaj.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.ckbEditareExpirare);
            this.panel6.Controls.Add(this.ckbEditarePrescriptie);
            this.panel6.Location = new System.Drawing.Point(154, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 85);
            this.panel6.TabIndex = 6;
            // 
            // ckbEditareExpirare
            // 
            this.ckbEditareExpirare.AutoSize = true;
            this.ckbEditareExpirare.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbEditareExpirare.Location = new System.Drawing.Point(45, 45);
            this.ckbEditareExpirare.Name = "ckbEditareExpirare";
            this.ckbEditareExpirare.Size = new System.Drawing.Size(175, 25);
            this.ckbEditareExpirare.TabIndex = 1;
            this.ckbEditareExpirare.Text = "Cu data de expirare";
            this.ckbEditareExpirare.UseVisualStyleBackColor = true;
            this.ckbEditareExpirare.CheckedChanged += new System.EventHandler(this.CkbOptiuni_CheckedChanged);
            // 
            // ckbEditarePrescriptie
            // 
            this.ckbEditarePrescriptie.AutoSize = true;
            this.ckbEditarePrescriptie.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbEditarePrescriptie.Location = new System.Drawing.Point(45, 14);
            this.ckbEditarePrescriptie.Name = "ckbEditarePrescriptie";
            this.ckbEditarePrescriptie.Size = new System.Drawing.Size(197, 25);
            this.ckbEditarePrescriptie.TabIndex = 0;
            this.ckbEditarePrescriptie.Text = "Cu prescriptie medicala";
            this.ckbEditarePrescriptie.UseVisualStyleBackColor = true;
            this.ckbEditarePrescriptie.CheckedChanged += new System.EventHandler(this.CkbOptiuni_CheckedChanged);
            // 
            // lblEditareOptiuni
            // 
            this.lblEditareOptiuni.AutoSize = true;
            this.lblEditareOptiuni.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditareOptiuni.Location = new System.Drawing.Point(23, 448);
            this.lblEditareOptiuni.Name = "lblEditareOptiuni";
            this.lblEditareOptiuni.Size = new System.Drawing.Size(84, 27);
            this.lblEditareOptiuni.TabIndex = 14;
            this.lblEditareOptiuni.Text = "Optiuni:";
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvare.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvare.Location = new System.Drawing.Point(211, 587);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(124, 39);
            this.btnSalvare.TabIndex = 8;
            this.btnSalvare.Text = "Sal&veaza";
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.BtnSalveaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSterge.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSterge.Location = new System.Drawing.Point(357, 587);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(124, 39);
            this.btnSterge.TabIndex = 7;
            this.btnSterge.Text = "&Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.BtnSterge_Click);
            // 
            // lblEditareTip
            // 
            this.lblEditareTip.AutoEllipsis = true;
            this.lblEditareTip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditareTip.Location = new System.Drawing.Point(21, 75);
            this.lblEditareTip.Name = "lblEditareTip";
            this.lblEditareTip.Size = new System.Drawing.Size(129, 54);
            this.lblEditareTip.TabIndex = 10;
            this.lblEditareTip.Text = "Tip medicament:";
            // 
            // numericUpDownEditarePret
            // 
            this.numericUpDownEditarePret.DecimalPlaces = 2;
            this.numericUpDownEditarePret.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownEditarePret.Location = new System.Drawing.Point(154, 396);
            this.numericUpDownEditarePret.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEditarePret.Name = "numericUpDownEditarePret";
            this.numericUpDownEditarePret.Size = new System.Drawing.Size(290, 20);
            this.numericUpDownEditarePret.TabIndex = 5;
            this.numericUpDownEditarePret.ThousandsSeparator = true;
            // 
            // lblEditarePret
            // 
            this.lblEditarePret.AutoSize = true;
            this.lblEditarePret.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditarePret.Location = new System.Drawing.Point(23, 389);
            this.lblEditarePret.Name = "lblEditarePret";
            this.lblEditarePret.Size = new System.Drawing.Size(59, 27);
            this.lblEditarePret.TabIndex = 13;
            this.lblEditarePret.Text = "Pret:";
            // 
            // numericUpDownEditareCantitate
            // 
            this.numericUpDownEditareCantitate.Location = new System.Drawing.Point(154, 346);
            this.numericUpDownEditareCantitate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEditareCantitate.Name = "numericUpDownEditareCantitate";
            this.numericUpDownEditareCantitate.Size = new System.Drawing.Size(290, 20);
            this.numericUpDownEditareCantitate.TabIndex = 4;
            this.numericUpDownEditareCantitate.ThousandsSeparator = true;
            // 
            // lblEditareCantitate
            // 
            this.lblEditareCantitate.AutoSize = true;
            this.lblEditareCantitate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditareCantitate.Location = new System.Drawing.Point(21, 339);
            this.lblEditareCantitate.Name = "lblEditareCantitate";
            this.lblEditareCantitate.Size = new System.Drawing.Size(107, 27);
            this.lblEditareCantitate.TabIndex = 12;
            this.lblEditareCantitate.Text = "Cantitate:";
            // 
            // txtEditareDescriere
            // 
            this.txtEditareDescriere.Location = new System.Drawing.Point(154, 248);
            this.txtEditareDescriere.Multiline = true;
            this.txtEditareDescriere.Name = "txtEditareDescriere";
            this.txtEditareDescriere.Size = new System.Drawing.Size(291, 77);
            this.txtEditareDescriere.TabIndex = 3;
            // 
            // lblEditareDescriere
            // 
            this.lblEditareDescriere.AutoSize = true;
            this.lblEditareDescriere.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditareDescriere.Location = new System.Drawing.Point(21, 241);
            this.lblEditareDescriere.Name = "lblEditareDescriere";
            this.lblEditareDescriere.Size = new System.Drawing.Size(109, 27);
            this.lblEditareDescriere.TabIndex = 11;
            this.lblEditareDescriere.Text = "Descriere:";
            // 
            // txtEditareNume
            // 
            this.txtEditareNume.Location = new System.Drawing.Point(154, 38);
            this.txtEditareNume.Name = "txtEditareNume";
            this.txtEditareNume.Size = new System.Drawing.Size(291, 20);
            this.txtEditareNume.TabIndex = 1;
            // 
            // lblEditareNume
            // 
            this.lblEditareNume.AutoSize = true;
            this.lblEditareNume.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditareNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEditareNume.Location = new System.Drawing.Point(21, 31);
            this.lblEditareNume.Name = "lblEditareNume";
            this.lblEditareNume.Size = new System.Drawing.Size(71, 27);
            this.lblEditareNume.TabIndex = 0;
            this.lblEditareNume.Text = "Nume:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlAdauga);
            this.Controls.Add(this.pnlCautare);
            this.Controls.Add(this.pnlEditare);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret)).EndInit();
            this.rdbContainer.ResumeLayout(false);
            this.rdbContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAdauga.ResumeLayout(false);
            this.pnlAdauga.PerformLayout();
            this.pnlCautare.ResumeLayout(false);
            this.pnlCautare.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCautarePret)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlCautareNume.ResumeLayout(false);
            this.pnlCautareNume.PerformLayout();
            this.pnlEditare.ResumeLayout(false);
            this.pnlEditare.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditarePret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditareCantitate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.NumericUpDown numericUpDownCantitate;
        private System.Windows.Forms.NumericUpDown numericUpDownPret;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Panel rdbContainer;
        private System.Windows.Forms.RadioButton rdbComprimate;
        private System.Windows.Forms.RadioButton rdbBandaje;
        private System.Windows.Forms.RadioButton rdbPulbere;
        private System.Windows.Forms.RadioButton rdbPicaturi;
        private System.Windows.Forms.RadioButton rdbSupozitoare;
        private System.Windows.Forms.RadioButton rdbCapsule;
        private System.Windows.Forms.RadioButton rdbSirop;
        private System.Windows.Forms.RadioButton rdbCrema;
        private System.Windows.Forms.RadioButton rdbFiole;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Label lblOptiuni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbExpirare;
        private System.Windows.Forms.CheckBox ckbPrescriptie;
        private System.Windows.Forms.Panel pnlAdauga;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Panel pnlCautare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblCriteriu;
        private System.Windows.Forms.ComboBox cmbFiltru;
        private System.Windows.Forms.Panel pnlCautareNume;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownCautarePret;
        private System.Windows.Forms.Label lblCautarePret;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCautareTip;
        private System.Windows.Forms.TextBox txtCautareNume;
        private System.Windows.Forms.Label lblCautareNume;
        private System.Windows.Forms.Label lblCautareMesaj;
        private System.Windows.Forms.Button btnCautaMeniu;
        private System.Windows.Forms.Button btnAdaugaMeniu;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Panel pnlEditare;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblEditareMesaj;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox ckbEditareExpirare;
        private System.Windows.Forms.CheckBox ckbEditarePrescriptie;
        private System.Windows.Forms.Label lblEditareOptiuni;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblEditareTip;
        private System.Windows.Forms.NumericUpDown numericUpDownEditarePret;
        private System.Windows.Forms.Label lblEditarePret;
        private System.Windows.Forms.NumericUpDown numericUpDownEditareCantitate;
        private System.Windows.Forms.Label lblEditareCantitate;
        private System.Windows.Forms.TextBox txtEditareDescriere;
        private System.Windows.Forms.Label lblEditareDescriere;
        private System.Windows.Forms.TextBox txtEditareNume;
        private System.Windows.Forms.Label lblEditareNume;
    }
}

