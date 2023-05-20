namespace InterfataUtilizator_WindowsForms
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
            this.rdbPastile = new System.Windows.Forms.RadioButton();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret)).BeginInit();
            this.rdbContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNume.Location = new System.Drawing.Point(54, 49);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(71, 27);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(187, 56);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(291, 20);
            this.txtNume.TabIndex = 1;
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(187, 204);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(291, 77);
            this.txtDescriere.TabIndex = 3;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescriere.Location = new System.Drawing.Point(54, 197);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(109, 27);
            this.lblDescriere.TabIndex = 2;
            this.lblDescriere.Text = "Descriere:";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCantitate.Location = new System.Drawing.Point(54, 295);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(107, 27);
            this.lblCantitate.TabIndex = 4;
            this.lblCantitate.Text = "Cantitate:";
            // 
            // numericUpDownCantitate
            // 
            this.numericUpDownCantitate.Location = new System.Drawing.Point(187, 302);
            this.numericUpDownCantitate.Name = "numericUpDownCantitate";
            this.numericUpDownCantitate.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownCantitate.TabIndex = 5;
            // 
            // numericUpDownPret
            // 
            this.numericUpDownPret.DecimalPlaces = 2;
            this.numericUpDownPret.Location = new System.Drawing.Point(189, 352);
            this.numericUpDownPret.Name = "numericUpDownPret";
            this.numericUpDownPret.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownPret.TabIndex = 7;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPret.Location = new System.Drawing.Point(56, 345);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(59, 27);
            this.lblPret.TabIndex = 6;
            this.lblPret.Text = "Pret:";
            // 
            // lblTip
            // 
            this.lblTip.AutoEllipsis = true;
            this.lblTip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.Location = new System.Drawing.Point(54, 93);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(139, 54);
            this.lblTip.TabIndex = 8;
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
            this.rdbContainer.Controls.Add(this.rdbPastile);
            this.rdbContainer.Location = new System.Drawing.Point(187, 93);
            this.rdbContainer.Name = "rdbContainer";
            this.rdbContainer.Size = new System.Drawing.Size(290, 89);
            this.rdbContainer.TabIndex = 9;
            // 
            // rdbBandaje
            // 
            this.rdbBandaje.AutoSize = true;
            this.rdbBandaje.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbBandaje.Location = new System.Drawing.Point(77, 34);
            this.rdbBandaje.Name = "rdbBandaje";
            this.rdbBandaje.Size = new System.Drawing.Size(66, 20);
            this.rdbBandaje.TabIndex = 8;
            this.rdbBandaje.TabStop = true;
            this.rdbBandaje.Text = "Bandaje";
            this.rdbBandaje.UseVisualStyleBackColor = true;
            // 
            // rdbPulbere
            // 
            this.rdbPulbere.AutoSize = true;
            this.rdbPulbere.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbPulbere.Location = new System.Drawing.Point(207, 34);
            this.rdbPulbere.Name = "rdbPulbere";
            this.rdbPulbere.Size = new System.Drawing.Size(64, 20);
            this.rdbPulbere.TabIndex = 7;
            this.rdbPulbere.TabStop = true;
            this.rdbPulbere.Text = "Pulbere";
            this.rdbPulbere.UseVisualStyleBackColor = true;
            // 
            // rdbPicaturi
            // 
            this.rdbPicaturi.AutoSize = true;
            this.rdbPicaturi.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbPicaturi.Location = new System.Drawing.Point(142, 34);
            this.rdbPicaturi.Name = "rdbPicaturi";
            this.rdbPicaturi.Size = new System.Drawing.Size(65, 20);
            this.rdbPicaturi.TabIndex = 6;
            this.rdbPicaturi.TabStop = true;
            this.rdbPicaturi.Text = "Picaturi";
            this.rdbPicaturi.UseVisualStyleBackColor = true;
            // 
            // rdbSupozitoare
            // 
            this.rdbSupozitoare.AutoSize = true;
            this.rdbSupozitoare.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbSupozitoare.Location = new System.Drawing.Point(12, 60);
            this.rdbSupozitoare.Name = "rdbSupozitoare";
            this.rdbSupozitoare.Size = new System.Drawing.Size(88, 20);
            this.rdbSupozitoare.TabIndex = 5;
            this.rdbSupozitoare.TabStop = true;
            this.rdbSupozitoare.Text = "Supozitoare";
            this.rdbSupozitoare.UseVisualStyleBackColor = true;
            // 
            // rdbCapsule
            // 
            this.rdbCapsule.AutoSize = true;
            this.rdbCapsule.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbCapsule.Location = new System.Drawing.Point(12, 34);
            this.rdbCapsule.Name = "rdbCapsule";
            this.rdbCapsule.Size = new System.Drawing.Size(64, 20);
            this.rdbCapsule.TabIndex = 4;
            this.rdbCapsule.TabStop = true;
            this.rdbCapsule.Text = "Capsule";
            this.rdbCapsule.UseVisualStyleBackColor = true;
            // 
            // rdbSirop
            // 
            this.rdbSirop.AutoSize = true;
            this.rdbSirop.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbSirop.Location = new System.Drawing.Point(207, 8);
            this.rdbSirop.Name = "rdbSirop";
            this.rdbSirop.Size = new System.Drawing.Size(53, 20);
            this.rdbSirop.TabIndex = 3;
            this.rdbSirop.TabStop = true;
            this.rdbSirop.Text = "Sirop";
            this.rdbSirop.UseVisualStyleBackColor = true;
            // 
            // rdbCrema
            // 
            this.rdbCrema.AutoSize = true;
            this.rdbCrema.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbCrema.Location = new System.Drawing.Point(142, 8);
            this.rdbCrema.Name = "rdbCrema";
            this.rdbCrema.Size = new System.Drawing.Size(58, 20);
            this.rdbCrema.TabIndex = 2;
            this.rdbCrema.TabStop = true;
            this.rdbCrema.Text = "Crema";
            this.rdbCrema.UseVisualStyleBackColor = true;
            // 
            // rdbFiole
            // 
            this.rdbFiole.AutoSize = true;
            this.rdbFiole.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbFiole.Location = new System.Drawing.Point(77, 8);
            this.rdbFiole.Name = "rdbFiole";
            this.rdbFiole.Size = new System.Drawing.Size(50, 20);
            this.rdbFiole.TabIndex = 1;
            this.rdbFiole.TabStop = true;
            this.rdbFiole.Text = "Fiole";
            this.rdbFiole.UseVisualStyleBackColor = true;
            // 
            // rdbPastile
            // 
            this.rdbPastile.AutoSize = true;
            this.rdbPastile.Checked = true;
            this.rdbPastile.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbPastile.Location = new System.Drawing.Point(12, 8);
            this.rdbPastile.Name = "rdbPastile";
            this.rdbPastile.Size = new System.Drawing.Size(59, 20);
            this.rdbPastile.TabIndex = 0;
            this.rdbPastile.TabStop = true;
            this.rdbPastile.Text = "Pastile";
            this.rdbPastile.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdauga.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga.Location = new System.Drawing.Point(199, 446);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 39);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAfiseaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAfiseaza.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAfiseaza.Location = new System.Drawing.Point(334, 446);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(124, 39);
            this.btnAfiseaza.TabIndex = 11;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = false;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 711);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.rdbContainer);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.numericUpDownPret);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.numericUpDownCantitate);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.BtnAscunde_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret)).EndInit();
            this.rdbContainer.ResumeLayout(false);
            this.rdbContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RadioButton rdbPastile;
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
    }
}

