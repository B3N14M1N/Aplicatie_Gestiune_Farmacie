using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarie.Enumerari;
namespace Librarie
{
    public class Medicament
    {

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID = 0;
        private const int NUME = 1;
        private const int TIP = 2;
        private const int DESCRIERE = 3;
        private const int CANTITATE = 4;
        private const int PRET = 5;
        private const int OPTIUNI = 6;

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Cantitate { get; set; }
        public decimal Pret { get; set; }
        public TipMedicament Tip { get; set; }
        public OptiuniMedicamente[] Optiuni { get; set; }

        public Medicament()
        {
            Id = Cantitate = 0;
            Nume = Descriere = string.Empty;
            Pret = 0.0M;
            Optiuni = null;
        }
        public Medicament(int id, string nume, TipMedicament tip, string descriere, int cantitate, decimal pret, OptiuniMedicamente[] optiuni)
        {
            Id = id;
            Nume = nume;
            Tip = tip;
            Descriere = descriere;
            Cantitate = cantitate;
            Pret = pret;
            Optiuni = optiuni;
        }
        public Medicament(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            Id = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Tip = (TipMedicament)Convert.ToInt32(dateFisier[TIP]);
            Descriere = dateFisier[DESCRIERE];
            Cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
            Pret = Convert.ToDecimal(dateFisier[PRET]);
            if (dateFisier[OPTIUNI].Length > 0)
            {
                Optiuni = new OptiuniMedicamente[dateFisier[OPTIUNI].Split(SEPARATOR_SECUNDAR_FISIER).Length];
                int i = 0;
                foreach (string opt in dateFisier[OPTIUNI].Split(SEPARATOR_SECUNDAR_FISIER))
                {

                    if (int.TryParse(opt, out int n))
                    {
                        Optiuni[i] = (OptiuniMedicamente)n;
                        i++;
                    }
                }
            }
            else
                Optiuni = null;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER,//0
                Id.ToString(),//1
                (Nume ?? " NECUNOSCUT "),//2
                (int)Tip,//3
                (Descriere ?? " NECUNOSCUT "),//4
                Cantitate.ToString(),//5
                Pret.ToString(),//6
                OptiuniToString());//7

            return obiectMedicamentPentruFisier;
        }
        public string OptiuniToString()
        {
            string sir = "";
            if(Optiuni!=null)
            foreach(OptiuniMedicamente opt in Optiuni)
            {
                sir += (int)opt;
                sir += " ";
            }
            return sir.Trim();
        }
        public string OptiuniToStringText()
        {
            string sir = "";
            if (Optiuni != null)
                foreach (OptiuniMedicamente opt in Optiuni)
                {
                    sir += opt.ToString();
                    sir += '\n';
                }
            return sir.Trim();
        }
        public override string ToString()
        {
            return $"Id: {Id}," +
                $" Nume: {(Nume ?? "NECUNOSCUT")}," +
                $" Tip: {Tip}," +
                $" Descriere: {(Descriere ?? "NECUNOSCUT")}," +
                $" Cantitate: {Cantitate}," +
                $" Pret: {Pret}" +
                $" Optiuni:{OptiuniToString()}";
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
                medicamentDeEditat = medicament;
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
        public List<Medicament> CautareMedicamentDupaTip(TipMedicament tip)
        {
            return ListaMedicamente.Where(med => med.Tip == tip).ToList();
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
