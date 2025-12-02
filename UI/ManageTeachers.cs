using AcademicInfoSystem.Data.Repositories;
using AcademicInfoSystem.Domain;
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
    public partial class ManageTeachers : Form
    {
        private readonly ITeacherRepository teacherRepository;
        private readonly IUserRepository userRepository;
        private TeacherService teacherService;
        private UserService userService;
        public ManageTeachers()
        {
            InitializeComponent();

            userRepository = new SQLiteUserRepository();
            teacherRepository = new SQLiteTeacherRepository();

            teacherService = new TeacherService(teacherRepository);
            userService = new UserService(userRepository);

            panel1.Visible = false;
            RefreshTeachers();

        }

        public void RefreshTeachers()
        {
            var teachers = teacherRepository.GetAll();
            dataGridView1.DataSource = teachers; 

        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
           
        }

        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var deleteRow = dataGridView1.SelectedRows[0];
            long deleteUserId = (long)deleteRow.Cells["UserID"].Value;

            var result = MessageBox.Show(
        "Are you sure you want to delete this teacher?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
         );

            if (result == DialogResult.Yes)
            {
                userService.Delete(deleteUserId);
                teacherService.Delete(deleteUserId);
                MessageBox.Show("Subject deleted succesfuly!");
                RefreshTeachers();
                panel1.Visible = false;
            }
            else
            { return; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string role = "Teacher";

            string department = addDepartment.Text.Trim();
            string academicTitle = addAcademicTitle.Text.Trim();
            DateTime hireDate = (DateTime)addHireDate.Value;

            
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(department) || string.IsNullOrWhiteSpace(academicTitle))
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
                return;
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
                var newTeacher = new Teacher(
                    userId,
                    username,
                    password,
                    firstName,
                    lastName,
                    role,
                    dateOfBirth,
                    department,
                    academicTitle,
                    hireDate
                    );

                teacherService.Add(newTeacher);
                MessageBox.Show("New teacher added succesfuly!");
                RefreshTeachers();
                panel1.Visible = false;
            }

              
        }
    }
}
