using _Medicamente_;
using NivelStocareDate;
using System;
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

namespace Interfata.Forms
{
    public partial class FormStoc_farmacie : Form
    {

        AdministrareMedicamente_FisierText administrare;


        private Form activeForm;
        private Label lblNume;
        private Label lblPret;


        private Label[] lblsNume;
        private Label[] lblsPret;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 180;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 498;


        public FormStoc_farmacie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormStoc_farmacie_Load(object sender, EventArgs e)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName; 
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            administrare = new AdministrareMedicamente_FisierText(caleCompletaFisier);

            AfiseazaMed();
        }
        private void AfiseazaMed()
        {




            Medicamente[] medicamente = administrare.GetMed(out int nrMed);




            int i = 0;
            foreach (Medicamente medicamet in medicamente)
            {
                
                dataGridView1.Rows.Add(medicamet.IdMed, medicamet.Nume, medicamet.Pret+ " Lei");
                i++;

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
