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
    public partial class AssignStudents : Form
    {
        private StudentService studentService;
        private GroupService groupService;

        private readonly IStudentRepository studentRepository;
        private readonly IGroupRepository groupRepository;  

        public AssignStudents()
        {
            InitializeComponent();

            studentRepository = new SQLiteStudentRepository();
            studentService = new StudentService(studentRepository);

            groupRepository = new SQLiteGroupRepository();
            groupService = new GroupService(groupRepository);   

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadStudents()
        {
            selectStudentBox.DataSource = studentService.GetAll();
            selectStudentBox.DisplayMember = "FullName";
            selectStudentBox.ValueMember = "UserID";
        }

        private void LoadGroups()
        {
            selectGroupBox.DataSource = groupService.GetAll();
            selectGroupBox.DisplayMember = "GroupID";
            selectGroupBox.ValueMember = "GroupID";
        }
        

        private void selectStudentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadGroups();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure?",
                "Assign student to group",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
                
                );

            if (result == DialogResult.Yes)
            {
                long updateStudentId = (long)selectStudentBox.SelectedValue;
                long updateGroupId = (long)selectGroupBox.SelectedValue;

                studentService.Update(updateStudentId, updateGroupId);
                MessageBox.Show("Student was assigned succesfuly!");

            }
            else { return;  }
        }
    }
}
