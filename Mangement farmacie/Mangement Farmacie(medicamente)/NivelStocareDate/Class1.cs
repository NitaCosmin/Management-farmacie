using _Medicamente_;
using System;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareMedicamente_FisierText
    {
        private const int ID_PRIMUL_MEDICAMENT = 1;
        private const int INCREMENT = 1;

        private const int NR_MAX_MEDICAMENTE = 50;
        private string numeFisier;

        public AdministrareMedicamente_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddMed(Medicamente medicament)
        {
            medicament.IdMed = GetId();

            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica 
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(medicament.ConversieLaSir_PentruFisier());
            }
        }

        public Medicamente[] GetMed(out int nrMed)
        {
            Medicamente[] medicamente = new Medicamente[NR_MAX_MEDICAMENTE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrMed = 0;

                // citeste cate o linie si creaza un obiect de tip Medicament
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    medicamente[nrMed++] = new Medicamente(linieFisier);
                }
            }

            Array.Resize(ref medicamente, nrMed);

            return medicamente;
        }

        private int GetId()
        {
            int IdMed = ID_PRIMUL_MEDICAMENT;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Medicament pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Medicamente medicament = new Medicamente(linieFisier);
                    IdMed = medicament.IdMed + INCREMENT;
                }
            }

            return IdMed;
        }
    }
}