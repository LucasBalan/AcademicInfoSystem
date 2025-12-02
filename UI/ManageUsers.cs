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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new  ManageStudents();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ManageTeachers();
            form.Show();
        }
    }
}
