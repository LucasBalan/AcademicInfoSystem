using AcademicInfoSystem.Domain;
using AcademicInfoSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AcademicInfoSystem.Services;
using AcademicInfoSystem.Data.Repositories;

namespace AcademicInfoSystem
{
    public partial class LoginForm : Form
    {

        private LoginService loginService;
        public LoginForm()
        {
            InitializeComponent();
            var repo = new SQLiteUserRepository();
            loginService = new LoginService(repo);
         
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            username_text.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = loginService.Login(username_text.Text, password_text.Text );
            if(user==null)
            {
                MessageBox.Show("Username and password are incorrect, try again!");
                username_text.Clear();
                password_text.Clear();

            }
            else
            {
                switch(user.Role)
                {
                    case "Admin":
                        new AdminForm(user).Show();
                        break;
                    case "Student":
                        new StudentForm(user).Show(); break;
                    case "Teacher":
                        new TeacherForm(user).Show(); break;    

                }
                  
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
