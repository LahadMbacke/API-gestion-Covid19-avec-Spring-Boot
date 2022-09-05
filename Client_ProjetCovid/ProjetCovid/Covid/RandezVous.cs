using Newtonsoft.Json;
using ProjetCovid.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCovid.Covid
{
    public partial class RandezVous : Form
    {
        string nomStructure;
        int id_structure;
        int _session_idPatient;
        public RandezVous(int session_idPatient)
        {

            InitializeComponent();
            _session_idPatient = session_idPatient;
            //Pour auto remplir le combox avec les structures
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("api/covid19/structures").Result;
            //on recupere la list des structures
            List<Structure> structures = response.Content.ReadAsAsync<List<Structure>>().Result;
            //on cree une list qui va contenir le nom des strucures
            List<string> items = new List<string>();
            for(int i = 0; i < structures.Count; i++)
            {
                //on rempli la list avec les noms des structures 
               items.Add(structures[i].nom);            
            }
            //on rempli le combox avec les noms des structures se trouvant dans la liste items
            Combox_structure_Nom.DataSource = items;
        }

        private void button_ValiderRv_Click(object sender, EventArgs e)
        {
            nomStructure = Combox_structure_Nom.Text;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("api/covid19/structure/" + nomStructure).Result;
            List<Structure> structure = response.Content.ReadAsAsync<List<Structure>>().Result;
            // MessageBox.Show(structure[0].nom);
            id_structure = structure[0].id;
            try
            {
                RV rv = new RV();
                rv.dateRV = Convert.ToDateTime(DateRv.Text);
                rv.typeRV = TypeRV.Text;
                rv.code_patient = _session_idPatient;
                rv.code_structure = id_structure;
                Enregistre_Rv(rv).Wait();
            }
            catch (Exception ex)
            {

            }
        }
        static async Task Enregistre_Rv(RV rv)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringContent = new StringContent(JsonConvert.SerializeObject(rv), Encoding.UTF8, "application/json");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            var response = await client.PostAsync("api/covid19/addRv", stringContent).ConfigureAwait(false);
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            MessageBox.Show("RendezVous enregistre");
        }

        private void Combox_structure_Nom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void seeRv()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("covid19/rv/patient/" + _session_idPatient).Result;
            List<RV> rvs = response.Content.ReadAsAsync<List<RV>>().Result;
            //MessageBox.Show(rvs[0].code_patient);
        }
    }
}
