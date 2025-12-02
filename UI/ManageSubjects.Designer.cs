namespace AcademicInfoSystem.UI
{
    partial class ManageSubjects
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addClassBox = new System.Windows.Forms.ComboBox();
            this.addLanguageBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE SUBJECTS";
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(193, 94);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(89, 35);
            this.addSubjectButton.TabIndex = 2;
            this.addSubjectButton.Text = "Add";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Location = new System.Drawing.Point(193, 135);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(89, 35);
            this.deleteSubjectButton.TabIndex = 3;
            this.deleteSubjectButton.Text = "Delete";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcademicInfoSystem.Properties.Resources.Administrator_PNG_File__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 170);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addLanguageBox);
            this.panel1.Controls.Add(this.addClassBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addNameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 250);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADD SUBJECT";
            // 
            // addNameBox
            // 
            this.addNameBox.Location = new System.Drawing.Point(32, 64);
            this.addNameBox.Name = "addNameBox";
            this.addNameBox.Size = new System.Drawing.Size(197, 20);
            this.addNameBox.TabIndex = 1;
            this.addNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // addClassBox
            // 
            this.addClassBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Lecture",
            "Lab"});
            this.addClassBox.FormattingEnabled = true;
            this.addClassBox.Items.AddRange(new object[] {
            "Lecture",
            "Lab"});
            this.addClassBox.Location = new System.Drawing.Point(32, 176);
            this.addClassBox.Name = "addClassBox";
            this.addClassBox.Size = new System.Drawing.Size(197, 21);
            this.addClassBox.TabIndex = 5;
            // 
            // addLanguageBox
            // 
            this.addLanguageBox.FormattingEnabled = true;
            this.addLanguageBox.Items.AddRange(new object[] {
            "Lithuanian",
            "English"});
            this.addLanguageBox.Location = new System.Drawing.Point(32, 116);
            this.addLanguageBox.Name = "addLanguageBox";
            this.addLanguageBox.Size = new System.Drawing.Size(197, 21);
            this.addLanguageBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Class Type";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Olive;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(144, 212);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 28);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(747, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteSubjectButton);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageSubjects";
            this.Text = "ManageSubjectsForm";
            this.Load += new System.EventHandler(this.ManageSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Button deleteSubjectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox addClassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addLanguageBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}