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

namespace UI_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareMedicamente_FisierText administrare;


        private Form activeForm;
        private Label lblNume;
        private Label lblPret;
        

        private Label[] lblsNume;
        private Label[] lblsPret;
    

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
       
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_afisare.Controls.Add(childForm);
            this.panel_afisare.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }
        public Form1()
        {
            

            InitializeComponent();

            
            
           
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Interfata.Forms.FormStoc_farmacie(),sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button_afisare.BackColor = Color.CadetBlue;
        }

        private void panelMeniu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_adauga_MouseHover(object sender, EventArgs e)
        {
            button_adauga.BackColor = Color.CadetBlue;
        }

        private void button_adauga_MouseLeave(object sender, EventArgs e)
        {
            button_adauga.BackColor = Color.Teal;
        }

        private void button_afisare_MouseLeave(object sender, EventArgs e)
        {
            button_afisare.BackColor = Color.Teal;
        }

        private void button_modifica_MouseHover(object sender, EventArgs e)
        {
            button_modifica.BackColor = Color.CadetBlue;
        }

        private void button_modifica_MouseLeave(object sender, EventArgs e)
        {
            button_modifica.BackColor = Color.Teal;
        }

        private void button_cauta_MouseHover(object sender, EventArgs e)
        {
            button_cauta.BackColor = Color.CadetBlue;
        }

        private void button_cauta_MouseLeave(object sender, EventArgs e)
        {
            button_cauta.BackColor = Color.Teal;
        }

        private void panel_logo2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_adauga_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new Interfata.Forms.FormAdauga(), sender);
        }

        private void button_modifica_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new Interfata.Forms.FormModifica(), sender);
        }

        private void button_cauta_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new Interfata.Forms.FormCauta(), sender);
        }

        private void panel_afisare_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
