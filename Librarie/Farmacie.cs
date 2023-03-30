using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
    public class Medicament
    {

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int DESCRIERE = 2;
        private const int CANTITATE = 3;
        private const int PRET = 4;

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Cantitate { get; set; }
        public decimal Pret { get; set; }

        public Medicament()
        {
            Id = Cantitate = 0;
            Nume = Descriere = string.Empty;
            Pret = 0.0M;
        }
        public Medicament(int id, string nume, string descriere, int cantitate, decimal pret)
        {
            Id = id;
            Nume = nume;
            Descriere = descriere;
            Cantitate = cantitate;
            Pret = pret;
        }
        public Medicament(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            Id = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Descriere = dateFisier[DESCRIERE];
            Cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
            Pret = Convert.ToDecimal(dateFisier[PRET]);
        }
        public string ConversieLaSir_PentruFisier()
        {
            string sNote = string.Empty;

            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_PRINCIPAL_FISIER,//0
                Id.ToString(),//1
                (Nume ?? " NECUNOSCUT "),//2
                (Descriere ?? " NECUNOSCUT "),//3
                Cantitate.ToString(),//4
                Pret.ToString());//5

            return obiectMedicamentPentruFisier;
        }
        public override string ToString()
        {
            return $"Id: {Id}," +
                $" Nume: {(Nume ?? "NECUNOSCUT")}," +
                $" Descriere: {(Descriere ?? "NECUNOSCUT")}," +
                $" Cantitate: {Cantitate}," +
                $" Pret: {Pret}";
        }
    }
    public class Farmacie
    {
        /*
         * Aceasta clasa va fi clasa principală a aplicației;
         * Clasa conține metodele pentru adăugarea, editarea, ștergerea și afișarea medicamentelor;
         * De asemenea, conține și o listă de medicamente pe care le va gestiona;
         */
        private List<Medicament> ListaMedicamente;
        public Farmacie()
        {
            ListaMedicamente = new List<Medicament>();
        }

        public void AdaugareMedicament(Medicament medicament)
        {
            ListaMedicamente.Add(medicament);
        }
        public void AdaugareMedicamente(List<Medicament> medicamente)
        {
            ListaMedicamente.Clear();
            foreach (Medicament med in medicamente)
            {
                ListaMedicamente.Add(med);
            }
        }
        public void EditareMedicament(int id, Medicament medicament)
        {
            Medicament medicamentDeEditat = ListaMedicamente.FirstOrDefault(med => med.Id == id);
            if (medicamentDeEditat != null)
            {
                medicamentDeEditat.Nume = medicament.Nume;
                medicamentDeEditat.Descriere = medicament.Descriere;
                medicamentDeEditat.Cantitate = medicament.Cantitate;
                medicamentDeEditat.Pret = medicament.Pret;
            }
        }

        public void StergereMedicament(int id)
        {
            Medicament medicamentDeSters = ListaMedicamente.FirstOrDefault(med => med.Id == id);
            if (medicamentDeSters != null)
            {
                ListaMedicamente.Remove(medicamentDeSters);
            }
        }
        public void AfisareListaMedicamente()
        {
            foreach (Medicament medicament in ListaMedicamente)
            {
                Console.WriteLine(medicament.ToString());
            }
        }
        public List<Medicament> CautareMedicamentDupaNume(string nume)
        {
            return ListaMedicamente.Where(med => med.Nume.ToUpper().Contains(nume.ToUpper())).ToList();
        }
        public List<Medicament> CautareMedicamentDupaPret(decimal pret)
        {
            return ListaMedicamente.Where(med => med.Pret == pret).ToList();
        }
        public Medicament CautareMedicamentDupaID(int id)
        {
            foreach(Medicament med in ListaMedicamente)
            {
                if (med.Id == id)
                    return med;
            }
            return null;
        }
        public override string ToString()
        {
            string strMedicamente = string.Empty;
            foreach (Medicament medicament in ListaMedicamente)
            {
                strMedicamente += medicament.ToString();
                strMedicamente += "\n";
            }
            return strMedicamente;
        }
    }
}
