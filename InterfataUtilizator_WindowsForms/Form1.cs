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
        private Label lblHeaderOptiuni;

        private Label[] lblsNume;
        private Label[] lblsTip;
        private Label[] lblsDescriere;
        private Label[] lblsCantitate;
        private Label[] lblsPret;
        private Label[] lblsOptiuni;

        private Panel pnlMedicamente;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 50;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 740;

        ArrayList optiuniSelectate = new ArrayList();
        public Form1()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMedicamente = new AdministrareFarmacie_FisierText(caleCompletaFisier);

            InitializeComponent();

            //setare proprietati
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.Manual;
            Size size = Screen.FromControl(this).WorkingArea.Size - this.Size;
            this.Location = new Point(size.Width/2,size.Height/2);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Text = "Informatii Medicamente";
            pnlMedicamente = new Panel();
            pnlMedicamente.Size = new Size(6 * DIMENSIUNE_PAS_X + 10, 700);
            pnlMedicamente.Location=new Point(OFFSET_X, DIMENSIUNE_PAS_Y);
            pnlMedicamente.BackColor = Color.WhiteSmoke;
            pnlMedicamente.Visible= false;
            pnlMedicamente.AutoScroll = true;
            this.Controls.Add(pnlMedicamente);

            //adaugare control de tip Label pentru 'Nume';
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "NUME";
            lblHeaderNume.Left = OFFSET_X;
            lblHeaderNume.ForeColor = Color.Black;
            lblHeaderNume.Visible = false;
            lblHeaderNume.TextAlign= ContentAlignment.MiddleCenter;
            this.Controls.Add(lblHeaderNume);

            //adaugare control de tip Label pentru 'Tip';
            lblHeaderTip = new Label();
            lblHeaderTip.Width = LATIME_CONTROL;
            lblHeaderTip.Text = "TIP";
            lblHeaderTip.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderTip.ForeColor = Color.Black;
            lblHeaderTip.Visible = false;
            lblHeaderTip.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblHeaderTip);

            //adaugare control de tip Label pentru 'Descriere';
            lblHeaderDescriere = new Label();
            lblHeaderDescriere.Width = LATIME_CONTROL;
            lblHeaderDescriere.Text = "DESCRIERE";
            lblHeaderDescriere.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderDescriere.ForeColor = Color.Black;
            lblHeaderDescriere.Visible = false;
            lblHeaderDescriere.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblHeaderDescriere);

            //adaugare control de tip Label pentru 'Cantitate';
            lblHeaderCantitate = new Label();
            lblHeaderCantitate.Width = LATIME_CONTROL;
            lblHeaderCantitate.Text = "CANTITATE";
            lblHeaderCantitate.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderCantitate.ForeColor = Color.Black;
            lblHeaderCantitate.Visible = false;
            lblHeaderCantitate.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblHeaderCantitate);

            //adaugare control de tip Label pentru 'Pret';
            lblHeaderPret = new Label();
            lblHeaderPret.Width = LATIME_CONTROL;
            lblHeaderPret.Text = "PRET";
            lblHeaderPret.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblHeaderPret.ForeColor = Color.Black;
            lblHeaderPret.Visible = false;
            lblHeaderPret.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblHeaderPret);

            //adaugare control de tip Label pentru 'Optiuni';
            lblHeaderOptiuni = new Label();
            lblHeaderOptiuni.Width = LATIME_CONTROL;
            lblHeaderOptiuni.Text = "OPTIUNI";
            lblHeaderOptiuni.Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
            lblHeaderOptiuni.ForeColor = Color.Black;
            lblHeaderOptiuni.TextAlign = ContentAlignment.MiddleCenter;
            lblHeaderOptiuni.Visible = false;
            this.Controls.Add(lblHeaderOptiuni);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void AfiseazaMedicamente( ArrayList medicamente )
        {
            int nrMedicamente = medicamente.Count;

            lblsNume = new Label[nrMedicamente];
            lblsTip = new Label[nrMedicamente];
            lblsDescriere = new Label[nrMedicamente];
            lblsCantitate = new Label[nrMedicamente];
            lblsPret = new Label[nrMedicamente];
            lblsOptiuni = new Label[nrMedicamente];

            int i = 0;
            foreach (Medicament medicament in medicamente)
            {
                //adaugare control de tip Label pentru numele medicamentelor;
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = medicament.Nume;
                lblsNume[i].MaximumSize = new Size(100, 0);
                lblsNume[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsNume[i].AutoSize= true;
                lblsNume[i].Left = 0;
                lblsNume[i].Top = i * DIMENSIUNE_PAS_Y;
                pnlMedicamente.Controls.Add(lblsNume[i]);

                //adaugare control de tip Label pentru tipul medicamentelor
                lblsTip[i] = new Label();
                lblsTip[i].Width = LATIME_CONTROL;
                lblsTip[i].Text = medicament.Tip.ToString();
                lblsTip[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsTip[i].Left = DIMENSIUNE_PAS_X;
                lblsTip[i].Top = i * DIMENSIUNE_PAS_Y;
                pnlMedicamente.Controls.Add(lblsTip[i]);

                //adaugare control de tip Label pentru descrierea medicamentelor
                lblsDescriere[i] = new Label();
                lblsDescriere[i].Width = LATIME_CONTROL;
                lblsDescriere[i].Text = medicament.Descriere;
                lblsDescriere[i].MaximumSize = new Size(100, 0);
                lblsDescriere[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsDescriere[i].AutoSize = true;
                lblsDescriere[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsDescriere[i].Top = i * DIMENSIUNE_PAS_Y;
                pnlMedicamente.Controls.Add(lblsDescriere[i]);

                //adaugare control de tip Label pentru cantitatea medicamentelor
                lblsCantitate[i] = new Label();
                lblsCantitate[i].Width = LATIME_CONTROL;
                lblsCantitate[i].Text = medicament.Cantitate.ToString();
                lblsCantitate[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsCantitate[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsCantitate[i].Top = i * DIMENSIUNE_PAS_Y;
                pnlMedicamente.Controls.Add(lblsCantitate[i]);

                //adaugare control de tip Label pentru pretul medicamentelor
                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = medicament.Pret.ToString();
                lblsPret[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsPret[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsPret[i].Top = i * DIMENSIUNE_PAS_Y;
                pnlMedicamente.Controls.Add(lblsPret[i]);

                //adaugare control de tip Label pentru optiunile medicamentelor
                lblsOptiuni[i] = new Label();
                lblsOptiuni[i].Width = LATIME_CONTROL;
                lblsOptiuni[i].Text = medicament.OptiuniToStringText();
                lblsOptiuni[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsOptiuni[i].AutoSize = true;
                lblsOptiuni[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsOptiuni[i].Top = i * DIMENSIUNE_PAS_Y;
                pnlMedicamente.Controls.Add(lblsOptiuni[i]);

                i++;
            }
        }
        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            lblHeaderNume.Visible = true;
            lblHeaderOptiuni.Visible = true;
            lblHeaderCantitate.Visible = true;
            lblHeaderDescriere.Visible = true;
            lblHeaderPret.Visible = true;
            lblHeaderTip.Visible = true;
            pnlMedicamente.Controls.Clear();
            AfiseazaMedicamente(new ArrayList(adminMedicamente.GetMedicamente(out int nrMedicamente)));
            pnlMedicamente.Visible = true;
        }
        private void BtnAscunde_Click(object sender, EventArgs e)
        {
            lblHeaderNume.Visible = false;
            lblHeaderOptiuni.Visible = false;
            lblHeaderCantitate.Visible = false;
            lblHeaderDescriere.Visible = false;
            lblHeaderPret.Visible = false;
            lblHeaderTip.Visible = false;
            pnlMedicamente.Visible = false;
        }
        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if(!ValidareControaleAdaugare())
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "DATE INVALIDE!";
                lblMesaj.ForeColor = Color.Red;
                return;
            }
            OptiuniMedicamente[] optiuniMedicamente = new OptiuniMedicamente[optiuniSelectate.Count];
            int i = 0;
            foreach(int opt in optiuniSelectate)
            {
                optiuniMedicamente[i++] = (OptiuniMedicamente)opt;
            }
            Medicament m = new Medicament(adminMedicamente.GetLastID() + 1, txtNume.Text, GetTipMedicamentSelectat(),txtDescriere.Text,Convert.ToInt32(numericUpDownCantitate.Value), numericUpDownPret.Value, optiuniMedicamente);

            adminMedicamente.AddMedicament(m);

            //resetarea controalelor pentru a introduce datele unui student nou
            ResetareControaleAdaugare();
            lblMesaj.Visible = true;
            lblMesaj.Text = "ADAUGAT CU SUCCES!";
            lblMesaj.ForeColor= Color.Black;
        }
        private void pnlAdauga_Click(object sender, EventArgs e)
        {
            lblMesaj.Visible= false;
        }
        private void pnlCauta_Click(object sender, EventArgs e)
        {
            lblCautareMesaj.Visible = false;
        }
        private bool ValidareControaleAdaugare()
        {
            if(txtNume.Text.Trim().Length < 1) {
                lblNume.ForeColor = Color.Red;
                return false;
            }
            else
                lblNume.ForeColor = Color.Black;
            if (txtDescriere.Text.Trim().Length < 1) {
                lblDescriere.ForeColor = Color.Red;
                return false;
            }
            else
                lblDescriere.ForeColor = Color.Black;
            if (numericUpDownCantitate.Value <= 0) {
                lblCantitate.ForeColor = Color.Red;
                return false;
            }
            else
                lblCantitate.ForeColor= Color.Black;
            if (numericUpDownPret.Value <= 0) {
                lblPret.ForeColor = Color.Red;
                return false;
            }
            else
                lblPret.ForeColor= Color.Black;
            return true;
        }
        private void ResetareControaleAdaugare()
        {
            ckbExpirare.Checked = false;
            ckbPrescriptie.Checked = false;
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
            rdbComprimate.Checked = true;
            numericUpDownCantitate.Value = 0;
            numericUpDownPret.Value = 0;

        }
        private void ResetareControaleCautare()
        {
            txtCautareNume.Text = string.Empty;

            rdbCautareBandaje.Checked = false;
            rdbCautareCapsule.Checked = false;
            rdbCautareCrema.Checked = false;
            rdbCautareFiole.Checked = false;
            rdbCautarePicaturi.Checked = false;
            rdbCautarePulbere.Checked = false;
            rdbCautareSirop.Checked = false;
            rdbCautareSupozitoare.Checked = false;
            rdbCautareComprimate.Checked = true;

            numericUpDownCautarePret.Value = 0;

        }
        private TipMedicament GetTipMedicamentSelectat()
        {
            if (rdbComprimate.Checked)
                return TipMedicament.Comprimate;
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

            return TipMedicament.Comprimate;
        }
        private void CkbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            OptiuniMedicamente optiuneSelectata = checkBoxControl.Text.ToUpper().Contains("EXPIRARE") ? OptiuniMedicamente.CuDataExpirare : OptiuniMedicamente.CuPrescriptie;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(optiuneSelectata);
            else
                optiuniSelectate.Remove(optiuneSelectata);
        }
        private void BtnSelecteazaCautarea_Click(object sender, EventArgs e)
        {
            ResetareControaleAdaugare();
            cmbFiltru.SelectedIndex = 0;
            lblMesaj.Visible = false;
            pnlAdauga.Visible = false;
            pnlAdauga.Enabled = false;
            pnlCautare.Visible = true;
            pnlCautare.Enabled = true;
        }
        private void BtnSelecteazaAdaugarea_Click(object sender, EventArgs e)
        {
            ResetareControaleCautare();
            lblCautareMesaj.Visible = false;
            pnlCautare.Visible = false;
            pnlCautare.Enabled = false;
            pnlAdauga.Visible = true;
            pnlAdauga.Enabled=true;
        }
        private TipMedicament GetTipMedicamentCautat()
        {
            if (rdbCautareComprimate.Checked)
                return TipMedicament.Comprimate;
            if (rdbCautareFiole.Checked)
                return TipMedicament.Fiole;
            if (rdbCautareCrema.Checked)
                return TipMedicament.Crema;
            if (rdbCautareSirop.Checked)
                return TipMedicament.Sirop;
            if (rdbCautareCapsule.Checked)
                return TipMedicament.Capsule;
            if (rdbCautareSupozitoare.Checked)
                return TipMedicament.Supozitoare;
            if (rdbCautarePicaturi.Checked)
                return TipMedicament.Picaturi;
            if (rdbCautarePulbere.Checked)
                return TipMedicament.Pulbere;
            if (rdbCautareBandaje.Checked)
                return TipMedicament.Bandaje;

            return TipMedicament.Comprimate;
        }
        private void BtnCauta_Click(object sender, EventArgs e)
        {
            if (!ValidareControaleCautare())
            {
                lblCautareMesaj.Visible = true;
                lblCautareMesaj.Text = "DATE INVALIDE!";
                lblCautareMesaj.ForeColor = Color.Red;
                return;
            }
            Farmacie farmacie= new Farmacie();
            farmacie.AdaugareMedicamente(adminMedicamente.GetMedicamente(out int nrMedicamente));
            if (cmbFiltru.SelectedIndex == 0)//NUME
            {
                lblHeaderNume.Visible = true;
                lblHeaderOptiuni.Visible = true;
                lblHeaderCantitate.Visible = true;
                lblHeaderDescriere.Visible = true;
                lblHeaderPret.Visible = true;
                lblHeaderTip.Visible = true;
                pnlMedicamente.Controls.Clear();
                AfiseazaMedicamente(new ArrayList(farmacie.CautareMedicamentDupaNume(txtCautareNume.Text)));
                pnlMedicamente.Visible = true;
            }
            else
            if (cmbFiltru.SelectedIndex == 1)//TIP
            {
                lblHeaderNume.Visible = true;
                lblHeaderOptiuni.Visible = true;
                lblHeaderCantitate.Visible = true;
                lblHeaderDescriere.Visible = true;
                lblHeaderPret.Visible = true;
                lblHeaderTip.Visible = true;
                pnlMedicamente.Controls.Clear();
                AfiseazaMedicamente(new ArrayList(farmacie.CautareMedicamentDupaTip(GetTipMedicamentCautat())));
                pnlMedicamente.Visible = true;
            }
            else
            if (cmbFiltru.SelectedIndex == 2)//PRET
            {
                lblHeaderNume.Visible = true;
                lblHeaderOptiuni.Visible = true;
                lblHeaderCantitate.Visible = true;
                lblHeaderDescriere.Visible = true;
                lblHeaderPret.Visible = true;
                lblHeaderTip.Visible = true;
                pnlMedicamente.Controls.Clear();
                AfiseazaMedicamente(new ArrayList(farmacie.CautareMedicamentDupaPret(numericUpDownCautarePret.Value)));
                pnlMedicamente.Visible = true;
            }

            //resetarea controalelor pentru a introduce datele unui student nou
            ResetareControaleCautare();
        }
        private bool ValidareControaleCautare()
        {
            if (cmbFiltru.SelectedIndex == 0 && txtCautareNume.Text.Trim().Length < 1)
            {
                lblCautareNume.ForeColor = Color.Red;
                return false;
            }
            else
                lblCautareNume.ForeColor = Color.Black;
            if (cmbFiltru.SelectedIndex == 2 && numericUpDownCautarePret.Value <= 0)
            {
                lblCautarePret.ForeColor = Color.Red;
                return false;
            }
            else
                lblCautarePret.ForeColor = Color.Black;
            return true;
        }
    }
}
