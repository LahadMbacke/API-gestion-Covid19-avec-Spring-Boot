using ProjetCovid.Covid;
using ProjetCovid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCovid
{
    public partial class Principale : Form
    {
        public int session_idPatient;
        public string session_role;
        public Principale(string role,int patientID)
        {
            InitializeComponent();
            session_idPatient = patientID;
            session_role = role;
           // MessageBox.Show(patientID.ToString(), "Welcom");
        }

        public Principale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStructure form = new FormStructure();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginPatient ln = new LoginPatient();
            ln.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ouvre la fenetre ListStructures
            FormCovid hopiatls = new FormCovid(session_role);
            hopiatls.Show();
        }


        //Boutton pour prise de randez vous
        private void button1_Click_2(object sender, EventArgs e)
        {
            RandezVous rv = new RandezVous(session_idPatient);
            rv.Show();
        }

      

        private void button_VoirMapp_Click(object sender, EventArgs e)
        {
            GoogleMap gmap = new GoogleMap();       
            gmap.ShowDialog();
        }
    }
}

