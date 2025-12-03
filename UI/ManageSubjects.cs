using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicInfoSystem.Data.Repositories;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;
using AcademicInfoSystem.Services;

namespace AcademicInfoSystem.UI
{
    public partial class ManageSubjects : Form
    {
        private readonly ISubjectRepository _ISubjectRepository;
        private SubjectService subjectService;
        

        public ManageSubjects()
        {
            InitializeComponent();


            var subjectRepo = new SQLiteSubjectRepository();
            subjectService = new SubjectService(subjectRepo);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 

            var subjects = subjectService.GetAll();
            dataGridView1.DataSource = subjects;
        }

        private void RefreshSubjects()
        {

            var subjects = subjectService.GetAll();
            dataGridView1.DataSource = subjects;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefreshSubjects();

        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

           

            


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string subjectName = addNameBox.Text;
            string subjectLanguage = addLanguageBox.Text;
            string subjectClassType = addClassBox.Text;


            if(string.IsNullOrWhiteSpace(subjectName) || string.IsNullOrWhiteSpace(subjectLanguage) || string.IsNullOrWhiteSpace(subjectClassType))
            {
                MessageBox.Show(
                    "All fields must be selected!",
                    "field selection error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    
                    );
            }
            else
            {
                var newSubject = new Subject(
                      0,
                      subjectName,
                      subjectLanguage,
                      subjectClassType
                    );
                subjectService.Add(newSubject);
                RefreshSubjects();
            }
                
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var deleteRow = dataGridView1.SelectedRows[0];
            long deleteSubjectId = (long)deleteRow.Cells["SubjectID"].Value;

            var result = MessageBox.Show(
        "Are you sure you want to delete this grade?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
         );

            if (result == DialogResult.Yes)
            {
                subjectService.Delete( deleteSubjectId );
                MessageBox.Show("Subject deleted succesfuly!");
                RefreshSubjects();        
            }
            else
            { return; }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
