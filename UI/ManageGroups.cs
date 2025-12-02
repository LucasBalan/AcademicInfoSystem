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
using System.Runtime.InteropServices;

namespace AcademicInfoSystem.UI
{
    public partial class ManageGroups : Form
    {
        private GroupService groupService;
        private readonly IGroupRepository groupRepository;

        public ManageGroups()
        {
            InitializeComponent();

            var groupRepository = new SQLiteGroupRepository();
            groupService = new GroupService(groupRepository);

            RefreshGroups();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageGroups_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        public void RefreshGroups()
        {
            var groups = groupService.GetAll();
            dataGridView1.DataSource = groups;
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
            int totalStudents = (int)addTotalStudents.Value;

            var newGroup = new Group(0, totalStudents);
            

            groupService.Add(newGroup);
            panel1.Visible = false;
            MessageBox.Show("Group added succesfuly!");
            RefreshGroups();

        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }
            var row = dataGridView1.SelectedRows[0];
            var deleterow = (long)row.Cells["GroupID"].Value;

            var result = MessageBox.Show(
       "Are you sure you want to delete this grade?",
       "Confirm Delete",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   );
            if (result == DialogResult.Yes)
            {

                groupService.Delete(deleterow);
                RefreshGroups();
            }
            else
            { return; }
        }
    }
}
