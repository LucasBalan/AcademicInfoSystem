namespace AcademicInfoSystem.UI
{
    partial class ManageGrades
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.buttonEditGrade = new System.Windows.Forms.Button();
            this.buttonDeleteGrade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addGradeButton = new System.Windows.Forms.NumericUpDown();
            this.addDateButton = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectStudentBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGradeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(126, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, -1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(461, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "MANAGE GRADES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(2, 113);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSubjects.TabIndex = 6;
            this.comboBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubjects_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Subject:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 344);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(225, 157);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(82, 38);
            this.buttonAddGrade.TabIndex = 9;
            this.buttonAddGrade.Text = "Add Grade";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // buttonEditGrade
            // 
            this.buttonEditGrade.Location = new System.Drawing.Point(225, 211);
            this.buttonEditGrade.Name = "buttonEditGrade";
            this.buttonEditGrade.Size = new System.Drawing.Size(82, 38);
            this.buttonEditGrade.TabIndex = 10;
            this.buttonEditGrade.Text = "Edit Grade";
            this.buttonEditGrade.UseVisualStyleBackColor = true;
            this.buttonEditGrade.Click += new System.EventHandler(this.buttonEditGrade_Click);
            // 
            // buttonDeleteGrade
            // 
            this.buttonDeleteGrade.Location = new System.Drawing.Point(225, 261);
            this.buttonDeleteGrade.Name = "buttonDeleteGrade";
            this.buttonDeleteGrade.Size = new System.Drawing.Size(82, 39);
            this.buttonDeleteGrade.TabIndex = 11;
            this.buttonDeleteGrade.Text = "Delete Grade";
            this.buttonDeleteGrade.UseVisualStyleBackColor = true;
            this.buttonDeleteGrade.Click += new System.EventHandler(this.buttonDeleteGrade_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Exit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.selectStudentBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addGradeButton);
            this.panel1.Controls.Add(this.addDateButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 221);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grade Value";
            // 
            // addGradeButton
            // 
            this.addGradeButton.DecimalPlaces = 1;
            this.addGradeButton.Location = new System.Drawing.Point(38, 44);
            this.addGradeButton.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.addGradeButton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(131, 20);
            this.addGradeButton.TabIndex = 11;
            this.addGradeButton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addGradeButton.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // addDateButton
            // 
            this.addDateButton.Location = new System.Drawing.Point(10, 139);
            this.addDateButton.Name = "addDateButton";
            this.addDateButton.Size = new System.Drawing.Size(184, 20);
            this.addDateButton.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Olive;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(104, 190);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 28);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "ADD/EDIT GRADE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcademicInfoSystem.Properties.Resources.pngtree_teacher_vector_illustration_with_black_and_white_design_teacher_icon_png_image_1996068__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 115);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // selectStudentBox
            // 
            this.selectStudentBox.FormattingEnabled = true;
            this.selectStudentBox.Location = new System.Drawing.Point(10, 88);
            this.selectStudentBox.Name = "selectStudentBox";
            this.selectStudentBox.Size = new System.Drawing.Size(184, 21);
            this.selectStudentBox.TabIndex = 16;
            this.selectStudentBox.SelectedIndexChanged += new System.EventHandler(this.selectStudentBox_SelectedIndexChanged);
            // 
            // ManageGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDeleteGrade);
            this.Controls.Add(this.buttonEditGrade);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageGrades";
            this.Text = "ManageGradescs";
            this.Load += new System.EventHandler(this.ManageGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGradeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddGrade;
        private System.Windows.Forms.Button buttonEditGrade;
        private System.Windows.Forms.Button buttonDeleteGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown addGradeButton;
        private System.Windows.Forms.DateTimePicker addDateButton;
        private System.Windows.Forms.ComboBox selectStudentBox;
    }
}