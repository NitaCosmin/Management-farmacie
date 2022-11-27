using NivelStocareDate;
using _Medicamente_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Interfata.Forms
{
    public partial class FormCauta : Form
    {
        AdministrareMedicamente_FisierText administrare;
        public FormCauta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            administrare = new AdministrareMedicamente_FisierText(caleCompletaFisier);
            Medicamente[] medicamente = administrare.GetMed(out int nrMed);
            string nume1 = textBox1.Text;
            
            for (int i = 0; i < nrMed; i++)
                if (String.Equals(medicamente[i].Nume,nume1,StringComparison.CurrentCultureIgnoreCase))
                {
                   
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(medicamente[i].IdMed,medicamente[i].Nume,medicamente[i].Pret);
                    textBox1.Clear();
                    

                }
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.CadetBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Teal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCauta_Load(object sender, EventArgs e)
        {

        }
    }
}
