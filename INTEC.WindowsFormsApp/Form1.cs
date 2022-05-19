using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<Patient> Patients = new List<Patient>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtpDOB.Value = DateTime.Now.AddYears(-18);
            txtAge.Text = "18";

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnUploadPicture.Enabled = true;
            gbPanel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            var patient = new Patient { 
                Id = Guid.NewGuid(),
                FirstName = txtFirstName.Text,
                LastName1 = txtLastName1.Text,
                LastName2 = txtLastName2.Text,
                DocumentType = cbDocumentType.Text,
                DocumentNumber = txtDocumentNumber.Text,
                Sexo = rbMale.Checked ? "M" : "F",
                DOB = dtpDOB.Value,
                Country = cbCountry.Text,
                PlaceBirth = txtPlaceBirth.Text,
                Weight = int.Parse(txtWeight.Text),
                Height = Convert.ToDouble(txtHeight.Text),
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Mobile = txtMobile.Text,
                HasInsurance = chkHasInsurance.Checked,
                Picture = txtPicture.Text,
                CreatedDate = DateTime.Now
            };

            if (chkHasInsurance.Checked)
            {
                patient.InsuranceCompany = cbInsuranceCompany.Text;
                patient.InsuranceNumber = txtInsuranceNumber.Text;
            }

            Patients.Add(patient);

            MessageBox.Show("Paciente Agregado");

            EmptyControls();

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnUploadPicture.Enabled = false;
            gbPanel.Enabled = false;

            GetPatients();
        }

        private void GetPatients()
        {
            dgvPatients.DataSource = null;
            dgvPatients.DataSource = Patients;
        }

        private void EmptyControls()
        {
            //txtFirstName.Text = string.Empty;
            //txtLastName1.Text = string.Empty;

            txtPicture.Text = string.Empty;
            pcPicture.Image = null;

            foreach (Control c in gbPanel.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmptyControls();
        }

        private void chkHasInsurance_CheckedChanged(object sender, EventArgs e)
        {
            cbInsuranceCompany.Enabled = chkHasInsurance.Checked;
            txtInsuranceNumber.Enabled = chkHasInsurance.Checked;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Now.Year - dtpDOB.Value.Year).ToString();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcPicture.Image = new Bitmap(openFileDialog.FileName);

                txtPicture.Text = openFileDialog.FileName;
            }
        }
    }

    public class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Sexo { get; set; }
        public DateTime DOB { get; set; }
        //public int Age {  get { return DOB.Year - DateTime.Now.Year; }}
        public string Country { get; set; }
        public string PlaceBirth { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool HasInsurance { get; set; }
        public string InsuranceCompany { get; set; }
        public string InsuranceNumber { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
