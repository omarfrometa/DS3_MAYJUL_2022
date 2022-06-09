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
    public partial class ConceptForm : Form
    {
        public bool Adding { get; set; } = true;
        public ConceptForm()
        {
            InitializeComponent();

            GetRecords();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbPanel.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            //GenerateNewID();
        }

        private void GenerateNewID()
        {
            ClearFields();

            //var Id = 1;

            //txtID.Text = Id.ToString();
        }

        private void ClearFields()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            chkIsEnabled.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            var json = string.Empty;
            var conceptList = new List<Concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";

            if (File.Exists(pathFile))
            { 
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }

            var conceptExist = conceptList.Count(x => x.Name.ToString().ToLower().Trim() == txtName.Text.ToLower().Trim());
            if (conceptExist > 0)
            {
                MessageBox.Show("El cocepto Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            var concept = new Concept();
            if (Adding) //Adding Record
            {
                concept = new Concept
                {
                    Id = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    IsEnabled = chkIsEnabled.Checked,
                    CreatedDate = DateTime.Now
                };
            }
            else //Updating Record
            {
                var Id = int.Parse(txtID.Text);
                concept = conceptList.FirstOrDefault(x => x.Id == Id);
                if (concept != null)
                {
                    conceptList.Remove(concept);

                    concept.Name = txtName.Text;
                    concept.Description = txtDescription.Text;
                    concept.IsEnabled = chkIsEnabled.Checked;
                    concept.ModifiedDate = DateTime.Now;
                }
            }

            conceptList.Add(concept);

            json = JsonConvert.SerializeObject(conceptList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            ClearFields();

            GetRecords();
        }

        private void GetRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            var conceptList = new List<Concept>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }

            txtID.Text = (conceptList.Count + 1).ToString();
            dgvConcepts.DataSource = conceptList;
        }
    }
}
