using AcademicInfoSystem.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicInfoSystem.Data.Repositories;
using AcademicInfoSystem.Domain.Repositories;
using AcademicInfoSystem.Services;

namespace AcademicInfoSystem.UI
{
    public partial class AssignSubjects : Form
    {
        private GroupSubjectService groupSubjectService;
        private readonly IGroupSubjectRepository groupSubjectRepository;
        private SubjectService subjectService;
        private GroupService groupService;
        private readonly ISubjectRepository subjectRepository;
        private readonly IGroupRepository groupRepository;
        public AssignSubjects()
        {
            InitializeComponent();

            groupSubjectRepository = new SQLiteGroupSubjectRepository();
            groupSubjectService = new GroupSubjectService(groupSubjectRepository);

            subjectRepository = new SQLiteSubjectRepository();
            subjectService = new SubjectService(subjectRepository);

            groupRepository = new SQLiteGroupRepository();
            groupService = new GroupService(groupRepository);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSubjects()
        {
            selectSubjectBox.DataSource = subjectService.GetAll();
            selectSubjectBox.DisplayMember = "Name";
            selectSubjectBox.ValueMember = "SubjectID";
        }
        private void LoadGroups()
        {
            selectGroupBox.DataSource = groupService.GetAll();
            selectGroupBox.DisplayMember = "GroupID";
            selectGroupBox.ValueMember = "GroupID";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
               "Are you sure?",
               "Assign subject to group",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Error

               );

            if (result == DialogResult.Yes)
            {
                long subjectId = (long)selectSubjectBox.SelectedValue;
                long groupId = (long)selectGroupBox.SelectedValue;

                groupSubjectService.Assign(subjectId, groupId);
                MessageBox.Show("Subject was assigned succesfuly!");

            }
            else { return; }
        }
        

        private void AssignSubjects_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadGroups();
        }
    }
}
