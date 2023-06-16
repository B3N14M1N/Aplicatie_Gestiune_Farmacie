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

        private Farmacie farmacie;

        private DataGridView medicamenteGridView;

        private const int DIMENSIUNE_PAS_Y = 50;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 740;

        private Medicament medicamentDeEditat;

        ArrayList optiuniSelectate = new ArrayList();
        public Form1()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMedicamente = new AdministrareFarmacie_FisierText(caleCompletaFisier);
            farmacie = new Farmacie();
            farmacie.AdaugareMedicamente(adminMedicamente.GetMedicamente(out int nrMedicamente));
            InitializeazaMedicamenteGridView();
            InitializeComponent();

            //setare proprietati
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.Manual;
            Size size = Screen.FromControl(this).WorkingArea.Size - this.Size;
            this.Location = new Point(size.Width/2,size.Height/2);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Text = "Informatii Medicamente";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void InitializeazaMedicamenteGridView()
        {
            medicamenteGridView = new DataGridView
            {
                TabIndex = 20,
                Location = new System.Drawing.Point(OFFSET_X - DIMENSIUNE_PAS_X - 65, 10),
                Size = new Size(5 * DIMENSIUNE_PAS_X + 105, 655),
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false
            };
            medicamenteGridView.RowTemplate.Height = DIMENSIUNE_PAS_Y;
            medicamenteGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            medicamenteGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            medicamenteGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medicamenteGridView.SelectionChanged += MedicamenteGridView_SelectionChanged;
            this.Controls.Add(medicamenteGridView);
        }
        private void AfiseazaMedicamente( ArrayList medicamente )
        {
            medicamenteGridView.ReadOnly = false;
            medicamenteGridView.Visible = true;
            medicamenteGridView.DataSource = null;
            medicamenteGridView.DataSource = medicamente;
            foreach (DataGridViewColumn col in medicamenteGridView.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            medicamenteGridView.Columns[0].Width = DIMENSIUNE_PAS_X / 2;
            medicamenteGridView.Columns[1].Width = DIMENSIUNE_PAS_X + DIMENSIUNE_PAS_X/2;
            medicamenteGridView.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            medicamenteGridView.Columns[2].Width = DIMENSIUNE_PAS_X + DIMENSIUNE_PAS_X/2;
            medicamenteGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            medicamenteGridView.Columns[3].Width = DIMENSIUNE_PAS_X / 2;
            medicamenteGridView.Columns[4].Width = DIMENSIUNE_PAS_X / 2;
            medicamenteGridView.Columns[6].Width = DIMENSIUNE_PAS_X;
            medicamenteGridView.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            medicamenteGridView.ClearSelection();
            medicamenteGridView.ReadOnly = true;
        }
        private void BtnSelecteazaCautarea_Click(object sender, EventArgs e)
        {
            rdbContainer.Enabled = true;
            rdbContainer.Visible = true;
            rdbContainer.Parent = null;
            panel2.Controls.Add(rdbContainer);
            rdbContainer.Location = new Point(145,16);
            rdbContainer.TabIndex = 11;
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
            optiuniSelectate.Clear();
            rdbContainer.Enabled = true;
            rdbContainer.Visible = true;
            rdbContainer.Parent = null;
            pnlAdauga.Controls.Add(rdbContainer);
            rdbContainer.Location = new Point(180, 90);
            rdbContainer.TabIndex = 2;
            ResetareControaleCautare();
            lblCautareMesaj.Visible = false;
            pnlCautare.Visible = false;
            pnlCautare.Enabled = false;
            pnlAdauga.Visible = true;
            pnlAdauga.Enabled=true;
        }
        private void BtnSelecteazaEditarea_Click(object sender, EventArgs e)
        {
            optiuniSelectate.Clear();
            rdbContainer.Enabled = true;
            rdbContainer.Visible = true;
            rdbContainer.Parent = null;
            pnlEditare.Controls.Add(rdbContainer);
            rdbContainer.Location = new Point(180, 90);
            rdbContainer.TabIndex = 2;
            btnSalvare.Enabled = true;
            btnSterge.Enabled = true;
            medicamentDeEditat = (Medicament)medicamenteGridView.CurrentRow.DataBoundItem;
            AfiseazaMedicamente(new ArrayList { medicamentDeEditat });
            txtEditareNume.Text = medicamentDeEditat.Nume;
            txtEditareDescriere.Text = medicamentDeEditat.Descriere;
            numericUpDownEditareCantitate.Value = medicamentDeEditat.Cantitate;
            numericUpDownEditarePret.Value = medicamentDeEditat.Pret;
            if (medicamentDeEditat.Optiuni != null && medicamentDeEditat.Optiuni.Length > 0)
            {
                if (medicamentDeEditat.Optiuni.Contains(OptiuniMedicamente.CuPrescriptie))
                {
                    ckbEditarePrescriptie.Checked = true;
                    optiuniSelectate.Add(OptiuniMedicamente.CuPrescriptie);
                }
                if (medicamentDeEditat.Optiuni.Contains(OptiuniMedicamente.CuDataExpirare))
                {
                    ckbEditareExpirare.Checked = true;
                    optiuniSelectate.Add(OptiuniMedicamente.CuDataExpirare);
                }
            }
            else
            {
                ckbEditarePrescriptie.Checked = false;
                ckbEditareExpirare.Checked = false;
            }
            foreach (RadioButton rdb in rdbContainer.Controls)
            {
                rdb.Checked = false;
            }
            if (medicamentDeEditat.Tip == TipMedicament.Capsule)
                rdbCapsule.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Pulbere)
                rdbPulbere.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Sirop)
                rdbSirop.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Supozitoare)
                rdbSupozitoare.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Bandaje)
                rdbBandaje.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Comprimate)
                rdbComprimate.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Fiole)
                rdbFiole.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Crema)
                rdbCrema.Checked = true;
            if (medicamentDeEditat.Tip == TipMedicament.Picaturi)
                rdbPicaturi.Checked = true;
            pnlEditare.Enabled = true;
            pnlEditare.Visible = true;
            pnlCautare.Enabled = false;
            pnlCautare.Visible = false;
        }
        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaMedicamente(new ArrayList(farmacie.Lista()));
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
            farmacie.AdaugareMedicament(m);

            //resetarea controalelor pentru a introduce datele unui medicament nou
            ResetareControaleAdaugare();
            lblMesaj.Visible = true;
            lblMesaj.Text = "ADAUGAT CU SUCCES!";
            lblMesaj.ForeColor= Color.Black;
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
            lblCautareMesaj.Visible = false;
            //Farmacie farmacie= new Farmacie();
            //farmacie.AdaugareMedicamente(adminMedicamente.GetMedicamente(out int nrMedicamente));
            ArrayList medicamente = new ArrayList();
            if (cmbFiltru.SelectedIndex == 0)//NUME
            {
                medicamente = new ArrayList(farmacie.CautareMedicamentDupaNume(txtCautareNume.Text));
            }
            else
            if (cmbFiltru.SelectedIndex == 1)//TIP
            {
                medicamente = new ArrayList(farmacie.CautareMedicamentDupaTip(GetTipMedicamentSelectat()));
            }
            else
            if (cmbFiltru.SelectedIndex == 2)//PRET
            {
                medicamente = new ArrayList(farmacie.CautareMedicamentDupaPret(numericUpDownCautarePret.Value));
            }
            if (medicamente.Count > 0)
            {
                AfiseazaMedicamente(medicamente);
                medicamenteGridView.Visible = true;
            }
            else
            {
                medicamenteGridView.DataSource = null;
                lblCautareMesaj.Visible = true;
                lblCautareMesaj.Text = "NU S-AU GASIT MEDICAMENTE CU CERINTELE DORITE!";
                lblCautareMesaj.ForeColor = Color.Red;
            }
        }
        private void BtnSalveaza_Click(object sender, EventArgs e)
        {
            if (!ValidareControaleEditare())
            {
                lblEditareMesaj.Visible = true;
                lblEditareMesaj.Text = "DATE INVALIDE!";
                lblEditareMesaj.ForeColor = Color.Red;
                return;
            }
            OptiuniMedicamente[] optiuniMedicamente=new OptiuniMedicamente[0];
            if(ckbEditarePrescriptie.Checked || ckbEditareExpirare.Checked)
            {
                if(ckbEditarePrescriptie.Checked== ckbEditareExpirare.Checked)
                {
                    optiuniMedicamente = new OptiuniMedicamente[2];
                    optiuniMedicamente[0] = OptiuniMedicamente.CuPrescriptie;
                    optiuniMedicamente[1] = OptiuniMedicamente.CuDataExpirare;
                }
                else
                {
                    optiuniMedicamente = new OptiuniMedicamente[1];
                    if(ckbEditarePrescriptie.Checked)
                        optiuniMedicamente[0] = OptiuniMedicamente.CuPrescriptie;
                    else
                        optiuniMedicamente[0] = OptiuniMedicamente.CuDataExpirare;
                }
            }
            medicamentDeEditat.Nume = txtEditareNume.Text;
            medicamentDeEditat.Tip = GetTipMedicamentSelectat();
            medicamentDeEditat.Descriere = txtEditareDescriere.Text;
            medicamentDeEditat.Cantitate = Convert.ToInt32(numericUpDownEditareCantitate.Value);
            medicamentDeEditat.Pret = numericUpDownEditarePret.Value;
            medicamentDeEditat.Optiuni = optiuniMedicamente;

            farmacie.EditareMedicament(medicamentDeEditat.Id, medicamentDeEditat);
            adminMedicamente.UpdateMedicamente(farmacie.Lista());

            //resetarea controalelor pentru a introduce datele unui medicament nou
            lblEditareMesaj.Visible = true;
            lblEditareMesaj.ForeColor = Color.Black;
            lblEditareMesaj.Text = "SALVAT CU SUCCES!";
            AfiseazaMedicamente(new ArrayList { medicamentDeEditat });
        }
        private void BtnSterge_Click(object sender, EventArgs e)
        {
            string message = "Doresti sa stergi?";
            string title = "Avertizare";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                farmacie.StergereMedicament(medicamentDeEditat.Id);
                adminMedicamente.UpdateMedicamente(farmacie.Lista());
                lblEditareMesaj.Visible = true;
                lblEditareMesaj.ForeColor = Color.Black;
                lblEditareMesaj.Text = "MEDICAMENTUL A FOST STERS CU SUCCES!";
                medicamenteGridView.DataSource = null;
                btnSalvare.Enabled = false;
                btnSterge.Enabled = false;
            }
        }
        private void BtnInapoi_Click(object sender, EventArgs e)
        {

            ResetareControaleRadioButton();
            rdbContainer.Enabled = true;
            rdbContainer.Visible = true;
            rdbContainer.Parent = null;
            panel2.Controls.Add(rdbContainer);
            rdbContainer.Location = new Point(145, 16);
            rdbContainer.TabIndex = 11;
            medicamenteGridView.DataSource = null;
            pnlCautare.Enabled = true;
            pnlCautare.Visible = true;
            pnlEditare.Enabled = false;
            pnlEditare.Visible = false;
        }
        private void PnlAdauga_Click(object sender, EventArgs e)
        {
            lblMesaj.Visible= false;
        }
        private void PnlCauta_Click(object sender, EventArgs e)
        {
            ResetareControaleCautare();
            lblCautareMesaj.Visible = false;
            AfiseazaMedicamente(new ArrayList(farmacie.Lista()));
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
        private bool ValidareControaleEditare()
        {
            if (txtEditareNume.Text.Trim().Length < 1)
            {
                lblEditareNume.ForeColor = Color.Red;
                return false;
            }
            else
                lblEditareNume.ForeColor = Color.Black;
            if (txtEditareDescriere.Text.Trim().Length < 1)
            {
                lblEditareDescriere.ForeColor = Color.Red;
                return false;
            }
            else
                lblEditareDescriere.ForeColor = Color.Black;
            if (numericUpDownEditareCantitate.Value <= 0)
            {
                lblEditareCantitate.ForeColor = Color.Red;
                return false;
            }
            else
                lblEditareCantitate.ForeColor = Color.Black;
            if (numericUpDownEditarePret.Value <= 0)
            {
                lblEditarePret.ForeColor = Color.Red;
                return false;
            }
            else
                lblEditarePret.ForeColor = Color.Black;
            return true;
        }
        private void ResetareControaleAdaugare()
        {
            lblNume.ForeColor = Color.Black;
            lblDescriere.ForeColor = Color.Black;
            lblCantitate.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            ckbExpirare.Checked = false;
            ckbPrescriptie.Checked = false;
            txtDescriere.Text = string.Empty;
            txtNume.Text = string.Empty;
            ResetareControaleRadioButton();
            numericUpDownCantitate.Value = 0;
            numericUpDownPret.Value = 0;

        }
        private void ResetareControaleCautare()
        {
            lblCautareNume.ForeColor = Color.Black;
            lblCautarePret.ForeColor = Color.Black;
            lblCautareTip.ForeColor = Color.Black;

            txtCautareNume.Text = string.Empty;
            ResetareControaleRadioButton();

            numericUpDownCautarePret.Value = 0;

        }
        private void ResetareControaleRadioButton()
        {
            rdbBandaje.Checked = false;
            rdbCapsule.Checked = false;
            rdbCrema.Checked = false;
            rdbFiole.Checked = false;
            rdbPicaturi.Checked = false;
            rdbPulbere.Checked = false;
            rdbSirop.Checked = false;
            rdbSupozitoare.Checked = false;
            rdbComprimate.Checked = true;
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
            {
                if(!optiuniSelectate.Contains(optiuneSelectata))
                    optiuniSelectate.Add(optiuneSelectata);
            }
            else
                optiuniSelectate.Remove(optiuneSelectata);
        }
        private void MedicamenteGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (medicamenteGridView.SelectedRows.Count > 1)
            {
                for (int i = 1; i < medicamenteGridView.SelectedRows.Count; i++)
                {
                    medicamenteGridView.SelectedRows[i].Selected = false;
                }
            }
            if (medicamenteGridView.SelectedRows.Count == 1)
                btnEditeaza.Enabled = true;
            else
                btnEditeaza.Enabled = false;
        }
    }
}
