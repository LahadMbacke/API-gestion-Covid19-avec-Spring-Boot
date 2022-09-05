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
    public partial class LoginPatient : Form
    {
        public static int patientID;
        public static string rolee;
        public LoginPatient()
        {
            InitializeComponent();
        }

        private void button_Sinscrire_Click(object sender, EventArgs e)
        {
            InscriptionPatient ins=new InscriptionPatient();
            ins.ShowDialog();        
        }

        //Button Login  
        private void button_Connecter_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            try
            {
             //On recupere les valeur entrees dans Email et password  
                patient.email = textBox_Email.Text;
                patient.password = textBox_Password.Text;    
                //on appelle la fonction qui appelle l'API'
                Login_Patient(patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion");
            }
        }

        static async Task Login_Patient(Patient patient)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // ici on serialise l'objet Patient pour le convertir sous forme JSON
            var stringContent = new StringContent(JsonConvert.SerializeObject(patient), Encoding.UTF8, "application/json");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            var response = await client.PostAsync("api/covid19/connexion", stringContent).ConfigureAwait(false);
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

            //On recupere l'objet que l'API nous a donnee 
            Patient patientLog = response.Content.ReadAsAsync<Patient>().Result;

            if(patientLog != null)
            {
                //On recupere queleque champ de l'objet
                string email = patientLog.email;
                string password = patientLog.password;
                string role = patientLog.role;
                patientID = patientLog.idpers;
                rolee = patientLog.role;

                    if (email != null && password != null)
                    { 
                         if(role=="admin")
                        {
                         //MessageBox.Show(role.ToString());
                         Principale acc = new Principale(rolee,patientID);
                         acc.ShowDialog();
                        }
                         else
                        {
                        //MessageBox.Show(role.ToString());
                            Principale acc = new Principale(rolee,patientID);
                            acc.ShowDialog();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Echc");
                    }
            }
           else
            {
                MessageBox.Show("Votre email ou password est Incorrect. Veuillez resseyer");
            }
        }
    }
}
