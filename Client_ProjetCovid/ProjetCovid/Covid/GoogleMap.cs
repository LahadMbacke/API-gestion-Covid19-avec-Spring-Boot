using GMap.NET;
using GMap.NET.MapProviders;
using ProjetCovid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCovid.Covid
{
    public partial class GoogleMap : Form
    {
        public string hopi;
        public double lati;
        public double longi;
        public GoogleMap()
        {
            InitializeComponent();
            dataGridView_listStructure.Visible = true;
            map.Visible = false;
            //Pour auto remplir le combox avec les structures
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("api/covid19/structures").Result;
            //on recupere la list des structures
            List<Structure> structures = response.Content.ReadAsAsync<List<Structure>>().Result;
            //on cree une list qui va contenir le nom des strucures
            List<string> items = new List<string>();
            for (int i = 0; i < structures.Count; i++)
            {
                //on rempli la list avec les noms des structures 
                items.Add(structures[i].nom);
            }
            //on rempli le combox avec les noms des structures se trouvant dans la liste items
            comboBox_structure.DataSource = items;
        }



        private void button_Rechercher_Click_1(object sender, EventArgs e)
        {
            hopi = comboBox_structure.Text;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("api/covid19/structure/" + hopi).Result;
            var structure = response.Content.ReadAsAsync<IEnumerable<Structure>>().Result;
            dataGridView_listStructure.DataSource = structure;
        }

        private void Voir_GooglMap_dataGrid(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_listStructure.Visible = false;
            map.Visible = true;

            lati = Convert.ToDouble(dataGridView_listStructure.CurrentRow.Cells[8].Value.ToString());
            longi = Convert.ToDouble(dataGridView_listStructure.CurrentRow.Cells[9].Value.ToString());

            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(lati, longi);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 16;
        }
    }
}
