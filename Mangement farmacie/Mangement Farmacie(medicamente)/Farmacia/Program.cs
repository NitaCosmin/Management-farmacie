using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Medicamente_;
using NivelStocareDate;
using System.IO;

namespace piu
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie= Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //string locatieFisierSolutie = @"D:\An 2 sem 2\PIU\Proiect\Date Farmacie.txt";
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareMedicamente_FisierText adminMedicamente = new AdministrareMedicamente_FisierText(caleCompletaFisier);
            Medicamente MedicamentNou = new Medicamente();
            int nrMed = 0;
            adminMedicamente.GetMed(out nrMed);
            string optiune;
            do
            {
                
                Console.WriteLine("A . Citire medicament de la tastatura ");
                Console.WriteLine("B . Salvare date medicament introdus  ");
                Console.WriteLine("C . Afisare lista medicamente din fisier");
                Console.WriteLine("D . Editare/stergere medicament din lista ");
                Console.WriteLine("E . Cauta medicament in lista ");
                Console.WriteLine("F . Exit");
                Console.WriteLine("Introduceti o optiune :");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        MedicamentNou = CitireTastatura();
                        break;
                    case "B":
                        int idMed = nrMed + 1;
                        MedicamentNou.IdMed = idMed;
                        //adaugare student in fisier
                        adminMedicamente.AddMed(MedicamentNou);

                        break;
                    case "C":
                        Medicamente[] medicamente = adminMedicamente.GetMed(out nrMed);
                       Afisaremedicamente(medicamente, nrMed);


                        break;
                    case "D":
                       Medicamente[] medicament = adminMedicamente.GetMed(out nrMed);
                        editare_medicament(medicament,nrMed);
                        
                        break;
                    case "E":
                        Medicamente[] medicamentul = adminMedicamente.GetMed(out nrMed);
                        cauta_medicament(medicamentul,nrMed);
                        break;
                    case "F":
                        return;
                    default:
                        Console.WriteLine("Optiune invalida !!");
                        break;

                }

            } while (optiune.ToUpper() != "F");
            Console.ReadKey();
        }
        public static void AfisareMedicament(Medicamente medicament)
        {
            string infoMed = string.Format("Medicamentul cu id-ul #{0} are numele {1}  si costa  {2} lei",
                    medicament.IdMed,
                    medicament.Nume ?? " NECUNOSCUT ",
                    string.Join(",", medicament.Pret));

            Console.WriteLine(infoMed);
        }

        public static void Afisaremedicamente(Medicamente[] medicamente, int nrMed)
        {
            Console.WriteLine("Avem urmatoarea lista de medicamente:");
            for (int contor = 0; contor < nrMed; contor++)
            {
                AfisareMedicament(medicamente[contor]);
            }
        }

        public static Medicamente CitireTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti pretul");
            int pret = Convert.ToInt32(Console.ReadLine());

            Medicamente medicament= new Medicamente(0, nume, pret);

            

            return medicament;
        }
        public static void editare_medicament(Medicamente[] medicamente,int nrMed)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];

            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareMedicamente_FisierText adminMedicamente = new AdministrareMedicamente_FisierText(caleCompletaFisier);
            Medicamente[] medicamentul = adminMedicamente.GetMed(out nrMed);
            Console.WriteLine("Introduceti numele medicamentului pe care doriti sa il editati :");
                string nume1=Console.ReadLine();
            for(int i=0;i<nrMed;i++)
            { 
                if(medicamente[i].Nume==nume1)
                { 
                    
                    


                    Console.WriteLine("Medicamentul a fost gasit!!");
                    Console.WriteLine("Editati datele despre medicament !");
                    Console.WriteLine("Nume :");
                    
                    string nume2 = Console.ReadLine();
                  
                    Console.WriteLine("Pret :");
                    int pret1 = Convert.ToInt32(Console.ReadLine());

                    string str = File.ReadAllText(caleCompletaFisier);
                    str = str.Replace(medicamente[i].Nume, nume2);
                    
                    
                    File.WriteAllText(caleCompletaFisier,  str);
                   


                }
                 
        
            }
        }
            public static void cauta_medicament(Medicamente[] medicamente,int nrMed)
            {
                Console.WriteLine("Introduceti numele medicamentului pe care doriti sa il cautati :");
                string nume1=Console.ReadLine();
                for(int i=0;i<nrMed;i++)
                if(medicamente[i].Nume==nume1)
                { 
                    Console.WriteLine("Medicamentul a fost gasit!!");
                    
                }
            }
        
        
    }
}

