using System;
using System.Collections.Generic;
using System.Configuration;
using Librarie;
using NivelStocareData;

namespace Aplicatie_Gestiune_Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {

            Medicament medicament = new Medicament();
            Farmacie farmacie = new Farmacie();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareFarmacie_FisierText adminMedicamente = new AdministrareFarmacie_FisierText(numeFisier);
            int nrMedicamente = 0;
            // acest apel ajuta la obtinerea numarului de medicamente inca de la inceputul executiei
            // astfel incat o eventuala adaugare sa atribuie un IdMedicament corect noului medicament
            // iar farmacia este incarcata cu medicamentele din fisier
            farmacie.AdaugareMedicamente(adminMedicamente.GetMedicamente(out nrMedicamente));

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii medicament");
                Console.WriteLine("A. Afisarea ultimului medicament introdus");
                Console.WriteLine("F. Afisare medicamente din fisier/farmacie");
                Console.WriteLine("S. Salvare medicament in fisier/farmacie");
                Console.WriteLine("C. Cautare medicament dupa ID"); //0
                Console.WriteLine("K. Cautare medicament dupa nume");//1
                Console.WriteLine("P. Cautare medicament dupa pret");//2
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine().Trim();

                switch (optiune.ToUpper())
                {
                    case "I":
                        medicament = CitireMedicamentTastatura();

                        break;
                    case "A":
                        if (medicament.Nume!=string.Empty)
                            AfisareMedicament(medicament);
                        else
                            Console.WriteLine("Introdu un medicament!");

                        break;
                    case "F":
                        farmacie.AdaugareMedicamente(adminMedicamente.GetMedicamente(out nrMedicamente));
                        farmacie.AfisareListaMedicamente();

                        break;
                    case "S":
                        // Verifica daca nu a fost adaugat deja medicamentul sau daca nu este gol 
                        if (medicament.Nume != string.Empty && farmacie.CautareMedicamentDupaID(medicament.Id)==null)
                        {
                            int idMedicament = nrMedicamente + 1;
                            medicament.Id = idMedicament;

                            //adaugare medicament in fisier
                            adminMedicamente.AddMedicament(medicament);
                            //adaugare medicament in farmacie
                            farmacie.AdaugareMedicament(medicament);
                            nrMedicamente = nrMedicamente + 1;
                        }
                        else
                            Console.WriteLine("Introdu un medicament!");

                        break;
                    case "C": // Cautare dupa ID
                        CautareMedicament(0, farmacie);

                        break;
                    case "K": // Cautare dupa NUME
                        CautareMedicament(1, farmacie);

                        break;
                    case "P": // Cautare dupa PRET
                        CautareMedicament(2, farmacie);

                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
        static Medicament CitireMedicamentTastatura()
        {
            Console.WriteLine("Introdu numele:");
            string Nume = Console.ReadLine().Trim();
            Console.WriteLine("Introdu descrierea:");
            string Descriere = Console.ReadLine().Trim();
            Console.WriteLine("Introdu cantitatea:");
            int Cantitate = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Introdu pretul:");
            decimal Pret = Convert.ToDecimal(Console.ReadLine().Trim());
            return new Medicament(0,Nume,Descriere,Cantitate,Pret);
        }
        static void AfisareMedicament(Medicament medicament)
        {
            Console.WriteLine(medicament.ToString());
        }
        static void CautareMedicament(int caz, Farmacie farmacie)
        {
            switch(caz)
            {
                default:
                    Console.WriteLine("CAZ NECUNOSCUT");
                    break;
                case 0: // Cautare dupa ID
                    Console.WriteLine("Introdu ID-ul:");
                    int id = Convert.ToInt32(Console.ReadLine().Trim());

                    if (farmacie.CautareMedicamentDupaID(id) != null)
                    {
                        Medicament med = farmacie.CautareMedicamentDupaID(id);
                        Console.WriteLine(med.ToString());
                    }
                    else
                        Console.WriteLine($"Medicamentul cu ID-ul {id} nu a fost gasit!");

                    break;
                case 1: // Cautare dupa NUME
                    Console.WriteLine("Introdu numele");
                    string nume=Console.ReadLine().Trim();

                    if (farmacie.CautareMedicamentDupaNume(nume).Count != 0)
                    {
                        foreach (Medicament med in farmacie.CautareMedicamentDupaNume(nume))
                        {
                            Console.WriteLine(med.ToString());
                        }
                    }
                    else
                        Console.WriteLine($"Medicamentul cu numele {nume} nu a fost gasit!");

                    break;
                case 2: // Cautare dupa PRET
                    Console.WriteLine("Introdu ID-ul:");
                    decimal pret = Convert.ToDecimal(Console.ReadLine().Trim());
                    if (farmacie.CautareMedicamentDupaPret(pret).Count != 0)
                    {
                        List<Medicament> list = new List<Medicament>();
                        list = farmacie.CautareMedicamentDupaPret(pret);
                        foreach (Medicament med in list)
                        {
                            Console.WriteLine(med.ToString());
                        }
                    }
                    else
                        Console.WriteLine($"Nu au fost gasite medicamente cu pretul {pret}");

                    break;
            }
        }
    }
}
