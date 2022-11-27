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
    public partial class FormModifica : Form
    {
        int indexRow;
        AdministrareMedicamente_FisierText administrare;
        public FormModifica()
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
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[1].Value = textbox_nume.Text;
            newDataRow.Cells[2].Value = textBox_pret.Text;
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];

            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareMedicamente_FisierText adminMedicamente = new AdministrareMedicamente_FisierText(caleCompletaFisier);
            Medicamente MedicamentNou = new Medicamente();
            int nrMed = 0;
            adminMedicamente.GetMed(out nrMed);
            Medicamente[] medicamente = adminMedicamente.GetMed(out nrMed);
            string nume1 = textBox_nume_pastrat.Text;
            for (int i = 0; i < nrMed; i++)
            {
                if (medicamente[i].Nume == nume1)
                {




                    

                    string nume2 = textbox_nume.Text;

                    
                    string pret1 = textBox_pret.Text;

                    string str = File.ReadAllText(caleCompletaFisier);
                    str = str.Replace(medicamente[i].Nume, nume2);
                    str = str.Replace(Convert.ToString(medicamente[i].Pret), pret1);
                   

                    File.WriteAllText(caleCompletaFisier, str);



                }


            }

        }
        private void dataGridView1_Load(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void AfiseazaMed()
        {




            Medicamente[] medicamente = administrare.GetMed(out int nrMed);




            int i = 0;
            foreach (Medicamente medicamet in medicamente)
            {

                dataGridView1.Rows.Add(medicamet.IdMed, medicamet.Nume, medicamet.Pret);
                i++;

            }

        }
        

        private void FormModifica_Load(object sender, EventArgs e)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            administrare = new AdministrareMedicamente_FisierText(caleCompletaFisier);

            AfiseazaMed();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textbox_nume.Text = row.Cells[1].Value.ToString();
            textBox_pret.Text = row.Cells[2].Value.ToString();
            textBox_nume_pastrat.Text = row.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            
        }

        private void textBox_nume_pastrat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
