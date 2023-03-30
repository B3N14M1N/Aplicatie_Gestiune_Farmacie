using System.Collections.Generic;
using System.IO;
using Librarie;
namespace NivelStocareData
{
    public class AdministrareFarmacie_FisierText
    {
        private const int NR_MAX_MEDICAMENTE = 100;
        private string numeFisier;
        public AdministrareFarmacie_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            /* se incearca deschiderea fisierului in modul OpenOrCreate
            astfel incat sa fie creat daca nu exista */
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public List<Medicament> GetMedicamente(out int NrMedicamente)
        {
            NrMedicamente = 0;
            List<Medicament> list = new List<Medicament>();
            /* se va apela implicit streamReader.Close()
            la iesirea din blocul instructiunii ”using” */
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                /* citeste cate o linie si creaza un obiect de tip Medicament
                pe baza datelor din linia citita si verifica lungimea maxima */
                while ((linieFisier = streamReader.ReadLine()) != null && list.Count < NR_MAX_MEDICAMENTE)
                {
                    list.Add(new Medicament(linieFisier));
                }
            }
            NrMedicamente = list.Count;
            return list;
        }
        public void AddMedicament(Medicament medicament)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(medicament.ConversieLaSir_PentruFisier());
            }
        }
    }
}

