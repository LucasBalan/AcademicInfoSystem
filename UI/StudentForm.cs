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
    public partial class StudentForm : Form
    {
        private User loggedUser;
        public StudentForm(User user)
        {
            InitializeComponent();
            loggedUser = user;
            label2.Text = $"Welcome, {loggedUser.FirstName} {loggedUser.LastName} ({loggedUser.Role} - ID: {loggedUser.UserId})";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ViewGrades(loggedUser);
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
