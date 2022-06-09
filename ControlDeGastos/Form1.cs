using ControlDeGastos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeGastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GetConcepts();
        }

        private void btnOpenConcept_Click(object sender, EventArgs e)
        {
            var oForm = new ConceptForm();
            oForm.Show();
        }

        private void btnOpenCategory_Click(object sender, EventArgs e)
        {
            var oForm = new CategoryForm();
            oForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cbConcept_Click(object sender, EventArgs e)
        {
            GetConcepts();
        }

        void GetConcepts()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            var conceptList = new List<Concept>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }

            cbConcept.DataSource = conceptList.Where(x => x.IsEnabled).ToList();
            cbConcept.DisplayMember = "Name";
            cbConcept.ValueMember = "Id";
        }
    }
}
