using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AcademicInfoSystem.Data.Repositories;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;
using AcademicInfoSystem.Services;

namespace AcademicInfoSystem.UI
{
    public partial class ManageGrades : Form
    {
        private User loggedUser;
        private readonly IGradeRepository gradeRepository;
        private readonly ISubjectRepository subjectRepository;
        private GradeService gradeService;
        private SubjectService subjectService;
        private bool isEdit = false;
        private long editingGradeId = 0;

        private readonly IStudentRepository studentRepository;
        private StudentService studentService;

        public ManageGrades(User user)
        {
            InitializeComponent();
            loggedUser = user;

            gradeRepository = new SQLiteGradeRepository();
            gradeService = new GradeService(gradeRepository);


            subjectRepository = new SQLiteSubjectRepository();
            subjectService = new SubjectService(subjectRepository);

            studentRepository = new SQLiteStudentRepository();
            studentService = new StudentService(studentRepository);





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dataGridView1.MultiSelect = false;
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subject = (Subject)comboBoxSubjects.SelectedItem;
            long subjectId = subject.SubjectId;
            var grades = gradeService.GetByTeacherAndSubject(loggedUser.UserId, subjectId);

            dataGridView1.DataSource = grades;
            dataGridView1.Columns["GradeID"].Visible = false;
            dataGridView1.Columns["TeacherID"].Visible = false;
            dataGridView1.Columns["SubjectID"].Visible = false;
            


        }

        private void ManageGrades_Load(object sender, EventArgs e)
        {
           var subjects=  subjectService.GetByTeacherId(loggedUser.UserId);
            comboBoxSubjects.DataSource = subjects;
            comboBoxSubjects.DisplayMember = "Name";
            comboBoxSubjects.ValueMember = "SubjectID";
            panel1.Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var students = studentService.GetAll();
            selectStudentBox.DataSource = students;
            selectStudentBox.DisplayMember = "FullName";
            selectStudentBox.ValueMember = "UserID";

        }

        private void RefreshGrades()
        {
            var subject = (Subject)comboBoxSubjects.SelectedItem;
            long subjectId = subject.SubjectId;
            var grades = gradeService.GetByTeacherAndSubject(loggedUser.UserId, subjectId);

            dataGridView1.DataSource = grades;
            dataGridView1.Columns["GradeID"].Visible = false;
            dataGridView1.Columns["TeacherID"].Visible = false;
            dataGridView1.Columns["SubjectID"].Visible = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            addGradeButton.Value= 1;
            selectStudentBox.SelectedValue = 0;
            addDateButton.Value= DateTime.Now;

            panel1.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var subject = (Subject)comboBoxSubjects.SelectedItem;
            long subjectId = subject.SubjectId;
            long teacherId = loggedUser.UserId;
            
            double gradeValue = (double)addGradeButton.Value;
            DateTime gradeDate = (DateTime)addDateButton.Value;

            if(isEdit==false)
            {
                if(selectStudentBox.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Please select a student",
                        "No student selected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return;
                }
                else
                {
                    long studentId = (long)selectStudentBox.SelectedValue;
                    var newGrade = new Grade(
               0,
               subjectId,
               studentId,
               teacherId,
               gradeValue,
               gradeDate
               );
                    gradeService.AddGrade(newGrade);
                    MessageBox.Show("Grade added succesfuly!");

                }

            }
            else
            {
                long studentId = (long)selectStudentBox.SelectedValue;
                var updateGrade = new Grade(
           editingGradeId,
           subjectId,
           studentId,
           teacherId,
           gradeValue,
           gradeDate
           );
                gradeService.UpdateGrade(updateGrade);
                MessageBox.Show("Grade updated succesfuly!");
                isEdit = false;
                editingGradeId = 0;
            }


            panel1.Visible = false;
            RefreshGrades();


        }

        private void buttonDeleteGrade_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            long gradeId = (long)row.Cells["GradeID"].Value;
            
            var result = MessageBox.Show(
        "Are you sure you want to delete this grade?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    );

            if (result == DialogResult.Yes)
            { gradeService.DeleteGrade(gradeId);
                MessageBox.Show("Grade deleted succesfuly!");
                RefreshGrades();
            }
            else
            { return;  }

        }

        private void buttonEditGrade_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count  == 0 || dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row");
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            editingGradeId = (long)row.Cells["GradeID"].Value;


            long currentStudentId = Convert.ToInt64(row.Cells["StudentID"].Value);
            double currentGradeValue = Convert.ToDouble(row.Cells["GradeValue"].Value);
            DateTime currentDateTime = Convert.ToDateTime(row.Cells["Date"].Value);

            addGradeButton.Value = (decimal)currentGradeValue;
            addDateButton.Value = currentDateTime;
            selectStudentBox.SelectedValue = currentStudentId;

            
            isEdit = true;
            panel1.Visible = true;

        }

        private void addIDButton_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void selectStudentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
