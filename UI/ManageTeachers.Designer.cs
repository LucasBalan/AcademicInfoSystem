namespace AcademicInfoSystem.UI
{
    partial class ManageTeachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addDepartment = new System.Windows.Forms.ComboBox();
            this.addAcademicTitle = new System.Windows.Forms.ComboBox();
            this.addHireDate = new System.Windows.Forms.DateTimePicker();
            this.addDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.addLastName = new System.Windows.Forms.TextBox();
            this.addFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.deleteTeacherButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "MANAGE TEACHER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Exit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 376);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addDepartment);
            this.panel1.Controls.Add(this.addAcademicTitle);
            this.panel1.Controls.Add(this.addHireDate);
            this.panel1.Controls.Add(this.addDateOfBirth);
            this.panel1.Controls.Add(this.addLastName);
            this.panel1.Controls.Add(this.addFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 310);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Olive;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(111, 279);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 28);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Hire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Academic Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // addDepartment
            // 
            this.addDepartment.AutoCompleteCustomSource.AddRange(new string[] {
            "Computer Science",
            "Information Systems",
            "Software Engineering",
            "Electrical Engineering",
            "Electronics Engineering",
            "Mechanical Engineering",
            "Industrial Engineering",
            "Robotics",
            "Telecommunications Engineering",
            "Computer Engineering",
            "Automotive Engineering",
            "Aerospace Engineering",
            "Materials Engineering",
            "Chemical Engineering",
            "Environmental Engineering",
            "Biomedical Engineering"});
            this.addDepartment.FormattingEnabled = true;
            this.addDepartment.Items.AddRange(new object[] {
            "Computer Science",
            "Information Systems",
            "Software Engineering",
            "Electrical Engineering",
            "Electronics Engineering",
            "Mechanical Engineering",
            "Industrial Engineering",
            "Robotics",
            "Telecommunications Engineering",
            "Computer Engineering",
            "Automotive Engineering",
            "Aerospace Engineering",
            "Materials Engineering",
            "Chemical Engineering",
            "Environmental Engineering",
            "Biomedical Engineering"});
            this.addDepartment.Location = new System.Drawing.Point(18, 170);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(175, 21);
            this.addDepartment.TabIndex = 6;
            // 
            // addAcademicTitle
            // 
            this.addAcademicTitle.AutoCompleteCustomSource.AddRange(new string[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Senior Lecturer",
            "Teaching Assistant",
            "Instructor",
            "Researcher",
            "Senior Researcher",
            "Doctor (PhD)",
            "Master (MSc)"});
            this.addAcademicTitle.FormattingEnabled = true;
            this.addAcademicTitle.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Senior Lecturer",
            "Teaching Assistant",
            "Instructor",
            "Researcher",
            "Senior Researcher",
            "Doctor (PhD)",
            "Master (MSc)"});
            this.addAcademicTitle.Location = new System.Drawing.Point(20, 210);
            this.addAcademicTitle.Name = "addAcademicTitle";
            this.addAcademicTitle.Size = new System.Drawing.Size(173, 21);
            this.addAcademicTitle.TabIndex = 5;
            // 
            // addHireDate
            // 
            this.addHireDate.Location = new System.Drawing.Point(5, 250);
            this.addHireDate.Name = "addHireDate";
            this.addHireDate.Size = new System.Drawing.Size(200, 20);
            this.addHireDate.TabIndex = 4;
            // 
            // addDateOfBirth
            // 
            this.addDateOfBirth.Location = new System.Drawing.Point(5, 131);
            this.addDateOfBirth.Name = "addDateOfBirth";
            this.addDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.addDateOfBirth.TabIndex = 3;
            // 
            // addLastName
            // 
            this.addLastName.Location = new System.Drawing.Point(20, 92);
            this.addLastName.Name = "addLastName";
            this.addLastName.Size = new System.Drawing.Size(173, 20);
            this.addLastName.TabIndex = 2;
            // 
            // addFirstName
            // 
            this.addFirstName.Location = new System.Drawing.Point(20, 53);
            this.addFirstName.Name = "addFirstName";
            this.addFirstName.Size = new System.Drawing.Size(173, 20);
            this.addFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADD TEACHER";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(806, 26);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(90, 28);
            this.addTeacherButton.TabIndex = 20;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // deleteTeacherButton
            // 
            this.deleteTeacherButton.Location = new System.Drawing.Point(920, 26);
            this.deleteTeacherButton.Name = "deleteTeacherButton";
            this.deleteTeacherButton.Size = new System.Drawing.Size(89, 28);
            this.deleteTeacherButton.TabIndex = 21;
            this.deleteTeacherButton.Text = "Delete";
            this.deleteTeacherButton.UseVisualStyleBackColor = true;
            this.deleteTeacherButton.Click += new System.EventHandler(this.deleteTeacherButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcademicInfoSystem.Properties.Resources.Administrator_PNG_File__1_;
            this.pictureBox1.Location = new System.Drawing.Point(49, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 124);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ManageTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteTeacherButton);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ManageTeachers";
            this.Text = "ManageTeachers";
            this.Load += new System.EventHandler(this.ManageTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button deleteTeacherButton;
        private System.Windows.Forms.DateTimePicker addHireDate;
        private System.Windows.Forms.DateTimePicker addDateOfBirth;
        private System.Windows.Forms.TextBox addLastName;
        private System.Windows.Forms.TextBox addFirstName;
        private System.Windows.Forms.ComboBox addDepartment;
        private System.Windows.Forms.ComboBox addAcademicTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
    }
}