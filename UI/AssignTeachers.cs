using AcademicInfoSystem.Data.Repositories;
using AcademicInfoSystem.Domain.Repositories;
using AcademicInfoSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicInfoSystem.UI
{
    public partial class AssignTeachers : Form
    {
        private TeacherService teacherService;
        private SubjectService subjectService;
        private TeacherSubjectService teacherSubjectService;
        private readonly ITeacherSubjectRepository teacherSubjectRepository;
        private readonly ITeacherRepository teacherRepository;
        private readonly ISubjectRepository subjectRepository;
        public AssignTeachers()
        {
            InitializeComponent();

            teacherRepository = new SQLiteTeacherRepository();
            teacherService = new TeacherService(teacherRepository);

            subjectRepository = new SQLiteSubjectRepository();
            subjectService = new SubjectService(subjectRepository);

            teacherSubjectRepository = new SQLiteTeacherSubjectRepository();
            teacherSubjectService = new TeacherSubjectService(teacherSubjectRepository);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
        }

        private void AssignTeachers_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadSubjects();

        }

        private void LoadTeachers()
        {
            selectTeachersBox.DataSource = teacherRepository.GetAll();
            selectTeachersBox.DisplayMember = "FullName";
            selectTeachersBox.ValueMember = "UserID";
        }

        private void LoadSubjects()
        {
            selectSubjectBox.DataSource = subjectRepository.GetAll();

            selectSubjectBox.DisplayMember = "Name";
            selectSubjectBox.ValueMember = "SubjectID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show(
                "Are you sure?",
                "Assign teacher to subject",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
                );

            if (result == DialogResult.Yes)
            {
                long selectedTeacherId = (long)selectTeachersBox.SelectedValue;
                long selectedSubjectId = (long)selectSubjectBox.SelectedValue;

                teacherSubjectService.Assign(selectedTeacherId, selectedSubjectId);

                MessageBox.Show("Teacher assigned succesfuly!");
                
            }
            else
            { return;  }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectSubjectBox.DataSource = subjectRepository.GetAll();

            selectSubjectBox.DisplayMember = "Name";
            selectSubjectBox.ValueMember = "SubjectID";

        }
    }
}
