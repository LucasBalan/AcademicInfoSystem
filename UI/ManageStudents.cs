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
using AcademicInfoSystem.Domain;

namespace AcademicInfoSystem.UI
{
    public partial class ManageStudents : Form
    {
        private StudentService studentService;
        private readonly IStudentRepository studentRepository;
        private UserService userService;
        private readonly IUserRepository userRepository;

        private readonly IGroupRepository groupRepository;
        private GroupService groupService;
        public ManageStudents()
        {
            InitializeComponent();
            studentRepository = new SQLiteStudentRepository();
            studentService = new StudentService(studentRepository);

            userRepository = new SQLiteUserRepository();
            userService = new UserService(userRepository);

            groupRepository = new SQLiteGroupRepository();
            groupService = new GroupService(groupRepository);
            panel1.Visible = false;
            RefreshStudents();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            var groups = groupService.GetAll();
            addGroupId.DataSource = groups;
            addGroupId.DisplayMember = "GroupID";
            addGroupId.ValueMember = "GroupID";

        }
        private void RefreshStudents()
        {
            var students = studentService.GetAll();
            dataGridView1.DataSource = students ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        { 
            panel1.Visible =true;
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var deleteRow = dataGridView1.SelectedRows[0];
            long deleteUserId = (long)deleteRow.Cells["UserID"].Value;

            var result = MessageBox.Show(
        "Are you sure you want to delete this student?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
         );

            if (result == DialogResult.Yes)
            {
                userService.Delete(deleteUserId);
                studentService.Delete(deleteUserId);
                MessageBox.Show("Subject deleted succesfuly!");
                RefreshStudents();
                panel1.Visible = false;
            }
            else
            { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            string username = addFirstName.Text;
            string password = addLastName.Text;
            string firstName = addFirstName.Text.Trim();
            string lastName = addLastName.Text.Trim();
            DateTime dateOfBirth = (DateTime)addDateOfBirth.Value;
            string role = "Student";

            long groupId = (long)addGroupId.SelectedValue;
        
            bool isActive;

            if (addIsActive.Text == "Yes") isActive = true;
            else isActive = false;

            int currentYear = (int)addCurrentYear.Value;

            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(addIsActive.Text) || addGroupId.SelectedValue == null )
            {
                MessageBox.Show(
                    "All fields must be selected!",
                    "Fields not selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            else if (userService.GetByCredentials(username, password) != null)
            {
                MessageBox.Show(
                    "User already exists!",
                    "User not available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                var newUser = new User(
                   0,
                   username,
                   password,
                   firstName,
                   lastName,
                   role,
                   dateOfBirth
                   );
                long userId = userService.Add(newUser);
                var newStudent = new Student(
                    userId,
                    username,
                    password,
                    firstName,
                    lastName,
                    role,
                    dateOfBirth,
                    groupId,
                    isActive,
                    currentYear
                    );

                studentService.Add(newStudent);
                MessageBox.Show("New student added succesfuly!");
                RefreshStudents();
                panel1.Visible = false;
            }
               

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addGroupId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addGroupId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
