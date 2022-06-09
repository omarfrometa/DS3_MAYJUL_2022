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
    public partial class Form2 : Form
    {
        private List<Student> Students = new List<Student>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            var student = new Student { Name = txtName.Text, CreatedDate = DateTime.Now };
            Students.Add(student);

            dgvRecords.DataSource = null;
            dgvRecords.DataSource = Students;

            txtName.Text = string.Empty;
            MessageBox.Show("Registro Agregado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Student
    { 
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
