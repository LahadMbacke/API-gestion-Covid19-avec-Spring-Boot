using ProjetCovid.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace ProjetCovid
{
    public partial class FormCovid : Form
    {
        string hopi;
        string _role;
        public FormCovid(string role)
        {
           
            InitializeComponent();
            _role = role;
            if(_role =="admin")
            {
                button_new.Visible = true;
            }
            else
            {
                button_new.Visible = false;
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("api/covid19/structures").Result;
            List<Structure> hopital = response.Content.ReadAsAsync<List<Structure>>().Result;
            dataGridView1.DataSource = hopital;

            //On cache le datagrid qui affiche la recherche
            dataGridView_ReacherchStructure.Visible = false;
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            FormStructure form = new FormStructure();
            form.ShowDialog();
        }


        //Bouton de recherche d'une Structure
        private void Recherche_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView_ReacherchStructure.Visible = true;

            //la variable hopi contient le contenu de la recherche
            hopi = textBox1_Recherche.Text;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("api/covid19/structure/" + hopi).Result;
            var hopital = response.Content.ReadAsAsync<IEnumerable<Structure>>().Result;
            dataGridView_ReacherchStructure.DataSource = hopital;

        }

        private void textBox1_Recherche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
