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
    public partial class MesRvs : Form
    {
       public int _session_idPatient = 1;
        public MesRvs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("/api/covid19/rv/patient/" + _session_idPatient).Result;
            List<RvJSonModel> rvs = response.Content.ReadAsAsync<List<RvJSonModel>>().Result;
           // MessageBox.Show(rvs);
           dataGridView1.DataSource = rvs;

        }
    }
}
