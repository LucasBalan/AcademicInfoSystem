namespace AcademicInfoSystem.UI
{
    partial class ManageStudents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCurrentYear = new System.Windows.Forms.NumericUpDown();
            this.addIsActive = new System.Windows.Forms.ComboBox();
            this.addDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.addLastName = new System.Windows.Forms.TextBox();
            this.addFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addGroupId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCurrentYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 60);
            this.label1.TabIndex = 15;
            this.label1.Text = "MANAGE STUDENTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Exit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.addGroupId);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addCurrentYear);
            this.panel1.Controls.Add(this.addIsActive);
            this.panel1.Controls.Add(this.addDateOfBirth);
            this.panel1.Controls.Add(this.addLastName);
            this.panel1.Controls.Add(this.addFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 313);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Olive;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(127, 282);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 28);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Current Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "IsActive?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "GroupID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // addCurrentYear
            // 
            this.addCurrentYear.Location = new System.Drawing.Point(27, 251);
            this.addCurrentYear.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.addCurrentYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addCurrentYear.Name = "addCurrentYear";
            this.addCurrentYear.Size = new System.Drawing.Size(165, 20);
            this.addCurrentYear.TabIndex = 5;
            this.addCurrentYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addIsActive
            // 
            this.addIsActive.FormattingEnabled = true;
            this.addIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.addIsActive.Location = new System.Drawing.Point(27, 211);
            this.addIsActive.Name = "addIsActive";
            this.addIsActive.Size = new System.Drawing.Size(165, 21);
            this.addIsActive.TabIndex = 4;
            // 
            // addDateOfBirth
            // 
            this.addDateOfBirth.Location = new System.Drawing.Point(10, 133);
            this.addDateOfBirth.Name = "addDateOfBirth";
            this.addDateOfBirth.Size = new System.Drawing.Size(207, 20);
            this.addDateOfBirth.TabIndex = 3;
            // 
            // addLastName
            // 
            this.addLastName.Location = new System.Drawing.Point(27, 94);
            this.addLastName.Name = "addLastName";
            this.addLastName.Size = new System.Drawing.Size(165, 20);
            this.addLastName.TabIndex = 2;
            // 
            // addFirstName
            // 
            this.addFirstName.Location = new System.Drawing.Point(27, 55);
            this.addFirstName.Name = "addFirstName";
            this.addFirstName.Size = new System.Drawing.Size(165, 20);
            this.addFirstName.TabIndex = 1;
            this.addFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADD STUDENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 375);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(792, 21);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(85, 32);
            this.addStudentButton.TabIndex = 19;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(883, 21);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(85, 32);
            this.deleteStudentButton.TabIndex = 20;
            this.deleteStudentButton.Text = "Delete";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcademicInfoSystem.Properties.Resources.Administrator_PNG_File__1_;
            this.pictureBox1.Location = new System.Drawing.Point(65, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 134);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // addGroupId
            // 
            this.addGroupId.FormattingEnabled = true;
            this.addGroupId.Location = new System.Drawing.Point(27, 172);
            this.addGroupId.Name = "addGroupId";
            this.addGroupId.Size = new System.Drawing.Size(165, 21);
            this.addGroupId.TabIndex = 15;
            this.addGroupId.SelectedIndexChanged += new System.EventHandler(this.addGroupId_SelectedIndexChanged);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ManageStudents";
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCurrentYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addLastName;
        private System.Windows.Forms.TextBox addFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addCurrentYear;
        private System.Windows.Forms.ComboBox addIsActive;
        private System.Windows.Forms.DateTimePicker addDateOfBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox addGroupId;
    }
}