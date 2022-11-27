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
    public partial class FormAdauga : Form
    {
        
        public FormAdauga()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.PowderBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.CadetBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];

            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareMedicamente_FisierText adminMedicamente = new AdministrareMedicamente_FisierText(caleCompletaFisier);
            Medicamente MedicamentNou = new Medicamente();
            MedicamentNou.Nume = textBox_nume.Text;
            MedicamentNou.Pret= Convert.ToInt32(textBox_pret.Text);
            int nrMed = 0;
            adminMedicamente.GetMed(out nrMed);
            int idMed = nrMed + 1;
            MedicamentNou.IdMed = idMed;
            //adaugare student in fisier
            adminMedicamente.AddMed(MedicamentNou);
            textBox_nume.Clear();
            textBox_pret.Clear();

        }

        private void FormAdauga_Load(object sender, EventArgs e)
        {

        }

        private void textBox_nume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
