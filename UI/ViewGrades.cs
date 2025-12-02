using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Data.Repositories;
using System.Drawing.Text;
using AcademicInfoSystem.Services;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.UI
{
    public partial class ViewGrades : Form
    {
        private User loggedUser;
        private GradeService gradeService;
        private readonly IGradeRepository gradeRepository;

        private  SubjectService subjectService;
        private readonly ISubjectRepository subjectRepository;
        
        public ViewGrades(User user)
        {
            InitializeComponent();
            loggedUser = user;

            gradeRepository = new SQLiteGradeRepository();
            gradeService = new GradeService(gradeRepository);
            label2.Text = $"Student: {loggedUser.FirstName} {loggedUser.LastName} (ID: {loggedUser.UserId})";

            subjectRepository = new SQLiteSubjectRepository();
            subjectService = new SubjectService(subjectRepository);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewGrades_Load(object sender, EventArgs e)
        {
            var grades = gradeService.GetByStudentId(loggedUser.UserId);
            if (grades.Count == 0)
            {
                MessageBox.Show("You have no grades!");
                this.Close();
                
                return;
            }
            else
            {
                dataGridView1.DataSource = grades;
                dataGridView1.Columns["TeacherID"].Visible = false;
                dataGridView1.Columns["GradeID"].Visible = false;
                dataGridView1.Columns["StudentID"].Visible = false;

                dataGridView2.DataSource = subjectService.GetAll();
                dataGridView2.Columns["Language"].Visible = false;
                dataGridView2.Columns["ClassNumber"].Visible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
                


            
            





        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
