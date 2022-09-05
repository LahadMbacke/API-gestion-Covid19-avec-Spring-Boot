using Newtonsoft.Json;
using ProjetCovid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCovid
{
    public partial class InscriptionPatient : Form
    {
        public InscriptionPatient()
        {
            InitializeComponent();
        }


        private void button_connecter_Click(object sender, EventArgs e)
        {
            LoginPatient ln= new LoginPatient();
            ln.ShowDialog();
            this.Close();
        }

        private void Inscription_Click(object sender, EventArgs e)
        {
            Patient patient = new  Patient();
            try
            {
                patient.nom = textBox_Nom.Text;
                patient.prenom = textBox_Prenom.Text;
                patient.email = textBox_Email.Text;
                patient.adresse = textBox_Adresse.Text;
                patient.password = textBox_Password.Text;
                patient.age = Convert.ToInt32(textBox_Age.Text);

                Enregistre_Patient(patient).Wait();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static async Task Enregistre_Patient(Patient patient)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringContent = new StringContent(JsonConvert.SerializeObject(patient), Encoding.UTF8, "application/json");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            var response = await client.PostAsync("api/covid19/addPatient", stringContent).ConfigureAwait(false);
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
         
        }
    }
}
