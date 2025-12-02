namespace AcademicInfoSystem.UI
{
    partial class ManageGroups
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addTotalStudents = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTotalStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Exit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "MANAGE GROUPS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 366);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(238, 123);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(89, 29);
            this.addGroupButton.TabIndex = 18;
            this.addGroupButton.Text = "Add";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(238, 184);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(89, 29);
            this.deleteGroupButton.TabIndex = 19;
            this.deleteGroupButton.Text = "Delete";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addTotalStudents);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 121);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD GROUP";
            // 
            // addTotalStudents
            // 
            this.addTotalStudents.Location = new System.Drawing.Point(11, 51);
            this.addTotalStudents.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.addTotalStudents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addTotalStudents.Name = "addTotalStudents";
            this.addTotalStudents.Size = new System.Drawing.Size(200, 20);
            this.addTotalStudents.TabIndex = 2;
            this.addTotalStudents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Students (Max 72)";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Olive;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(134, 90);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 28);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcademicInfoSystem.Properties.Resources.Administrator_PNG_File__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 170);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ManageGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteGroupButton);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "ManageGroups";
            this.Text = "ManageGroupscs";
            this.Load += new System.EventHandler(this.ManageGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTotalStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addTotalStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
    }
}