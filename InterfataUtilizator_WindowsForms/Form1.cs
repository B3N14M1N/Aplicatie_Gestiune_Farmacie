using Librarie;
using Librarie.Enumerari;
using NivelStocareData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareFarmacie_FisierText adminMedicamente;

        private Label lblHeaderNume;
        private Label lblHeaderTip;
        private Label lblHeaderDescriere;
        private Label lblHeaderCantitate;
        private Label lblHeaderPret;

        private Label[] lblsNume;
        private Label[] lblsTip;
        private Label[] lblsDescriere;
        private Label[] lblsCantitate;
        private Label[] lblsPret;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 50;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;

        public Form1()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMedicamente = new AdministrareFarmacie_FisierText(caleCompletaFisier);

            InitializeComponent();

            //setare proprietati
            this.Size = new Size(600, 750);
            this.StartPosition = FormStartPosition.Manual;
            Size size = Screen.FromControl(this).WorkingArea.Size - this.Size;
            this.Location = new Point(size.Width/2,size.Height/2);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Text = "Informatii Medicamente";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void AfiseazaMedicamente()
        {
            //adaugare control de tip Label pentru 'Nume';
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderNume);

            //adaugare control de tip Label pentru 'Tip';
            lblHeaderTip = new Label();
            lblHeaderTip.Width = LATIME_CONTROL;
            lblHeaderTip.Text = "Tip";
            lblHeaderTip.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderTip.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderTip);

            //adaugare control de tip Label pentru 'Descriere';
            lblHeaderDescriere = new Label();
            lblHeaderDescriere.Width = LATIME_CONTROL;
            lblHeaderDescriere.Text = "Descriere";
            lblHeaderDescriere.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderDescriere.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderDescriere);

            //adaugare control de tip Label pentru 'Cantitate';
            lblHeaderCantitate = new Label();
            lblHeaderCantitate.Width = LATIME_CONTROL;
            lblHeaderCantitate.Text = "Cantitate";
            lblHeaderCantitate.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderCantitate.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderCantitate);

            //adaugare control de tip Label pentru 'Pret';
            lblHeaderPret = new Label();
            lblHeaderPret.Width = LATIME_CONTROL;
            lblHeaderPret.Text = "Pret";
            lblHeaderPret.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblHeaderPret.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderPret);

            int nrMedicamente = 0;
            ArrayList medicamente = new ArrayList(adminMedicamente.GetMedicamente(out nrMedicamente));

            lblsNume = new Label[nrMedicamente];
            lblsTip = new Label[nrMedicamente];
            lblsDescriere = new Label[nrMedicamente];
            lblsCantitate = new Label[nrMedicamente];
            lblsPret = new Label[nrMedicamente];

            int i = 0;
            foreach (Medicament medicament in medicamente)
            {
                //adaugare control de tip Label pentru numele medicamentelor;
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = medicament.Nume;
                lblsNume[i].MaximumSize = new Size(100, 0);
                lblsNume[i].AutoSize= true;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                //adaugare control de tip Label pentru tipul medicamentelor
                lblsTip[i] = new Label();
                lblsTip[i].Width = LATIME_CONTROL;
                lblsTip[i].Text = medicament.Tip.ToString();
                lblsTip[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsTip[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTip[i]);

                //adaugare control de tip Label pentru descrierea medicamentelor
                lblsDescriere[i] = new Label();
                lblsDescriere[i].Width = LATIME_CONTROL;
                lblsDescriere[i].Text = medicament.Descriere;
                lblsDescriere[i].MaximumSize = new Size(100, 0);
                lblsDescriere[i].AutoSize = true;
                lblsDescriere[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsDescriere[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDescriere[i]);

                //adaugare control de tip Label pentru cantitatea medicamentelor
                lblsCantitate[i] = new Label();
                lblsCantitate[i].Width = LATIME_CONTROL;
                lblsCantitate[i].Text = medicament.Cantitate.ToString();
                lblsCantitate[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsCantitate[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCantitate[i]);

                //adaugare control de tip Label pentru pretul medicamentelor
                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = medicament.Pret.ToString();
                lblsPret[i].Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
                lblsPret[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPret[i]);
                i++;
            }
        }
        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaMedicamente();
            this.Width = OFFSET_X * 2;
        }
        private void BtnAscunde_Click(object sender, EventArgs e)
        {
            this.Width = OFFSET_X;
        }
        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if(!ValidareControale())
            {
                return;
            }
            Medicament m = new Medicament(adminMedicamente.GetLastID() + 1, txtNume.Text, GetTipMedicamentSelectat(),txtDescriere.Text,Convert.ToInt32(numericUpDownCantitate.Value), numericUpDownPret.Value);

            adminMedicamente.AddMedicament(m);

            //resetarea controalelor pentru a introduce datele unui student nou
            ResetareControale();
        }
        private bool ValidareControale()
        {
            if(txtNume.Text.Trim().Length < 1) {
                lblNume.ForeColor = Color.Red;
                return false;
            }
            else
            {
                lblNume.ForeColor = Color.Black;
            }
            if (txtDescriere.Text.Trim().Length < 1)
            {
                lblDescriere.ForeColor = Color.Red;
                return false;
            }
            else
            {
                lblDescriere.ForeColor = Color.Black;
            }
            if(numericUpDownCantitate.Value<=0)
            {
                lblCantitate.ForeColor = Color.Red;
                return false;
            }
            else
            {
                lblCantitate.ForeColor= Color.Black;
            }
            if(numericUpDownPret.Value<=0)
            {
                lblPret.ForeColor = Color.Red;
                return false;
            }
            else
            {
                lblPret.ForeColor= Color.Black;
            }
            return true;
        }
        private void ResetareControale()
        {
            txtDescriere.Text = string.Empty;
            txtNume.Text = string.Empty;
            rdbBandaje.Checked = false;
            rdbCapsule.Checked = false;
            rdbCrema.Checked = false;
            rdbFiole.Checked = false;
            rdbPicaturi.Checked = false;
            rdbPulbere.Checked = false;
            rdbSirop.Checked = false;
            rdbSupozitoare.Checked = false;
            rdbPastile.Checked = true;
            numericUpDownCantitate.Value = 0;
            numericUpDownPret.Value = 0;

        }
        private TipMedicament GetTipMedicamentSelectat()
        {
            if (rdbPastile.Checked)
                return TipMedicament.Pastile;
            if (rdbFiole.Checked)
                return TipMedicament.Fiole;
            if (rdbCrema.Checked)
                return TipMedicament.Crema;
            if (rdbSirop.Checked)
                return TipMedicament.Sirop;
            if (rdbCapsule.Checked)
                return TipMedicament.Capsule;
            if (rdbSupozitoare.Checked)
                return TipMedicament.Supozitoare;
            if (rdbPicaturi.Checked)
                return TipMedicament.Picaturi;
            if (rdbPulbere.Checked)
                return TipMedicament.Pulbere;
            if (rdbBandaje.Checked)
                return TipMedicament.Bandaje;

            return TipMedicament.Pastile;
        }

    }
}
