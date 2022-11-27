using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Medicamente_
{
    public class Medicamente
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRET = 2;
       

        
        

        //proprietati auto-implemented
        public int IdMed { get; set; } 
        public string Nume { get; set; }
        public int Pret { get; set; }




        //contructor implicit
        public Medicamente()
        {
            Nume = string.Empty;
            Pret = 0;
        }

        //constructor cu parametri
        public Medicamente(int idMed, string nume, int pret)
        {
            this.IdMed = idMed;
            this.Nume = nume;
            this.Pret = pret;
           
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Medicamente(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

           
            IdMed = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Pret = Convert.ToInt32(dateFisier[PRET]);


        }
        //conversie la sir pentru fisierul text
        public string ConversieLaSir_PentruFisier()
        {
            string sir = string.Empty;

            string obiectMedPentruFisier = string.Format("{1}{0}{2}{0}{3}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdMed.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                sir);

            return obiectMedPentruFisier;
        }


    }
}
