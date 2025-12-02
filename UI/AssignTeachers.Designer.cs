namespace AcademicInfoSystem.UI
{
    partial class AssignTeachers
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
            this.label3 = new System.Windows.Forms.Label();
            this.selectTeachersBox = new System.Windows.Forms.ComboBox();
            this.selectSubjectBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Exit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // selectTeachersBox
            // 
            this.selectTeachersBox.FormattingEnabled = true;
            this.selectTeachersBox.Location = new System.Drawing.Point(36, 135);
            this.selectTeachersBox.Name = "selectTeachersBox";
            this.selectTeachersBox.Size = new System.Drawing.Size(288, 21);
            this.selectTeachersBox.TabIndex = 13;
            this.selectTeachersBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selectSubjectBox
            // 
            this.selectSubjectBox.FormattingEnabled = true;
            this.selectSubjectBox.Location = new System.Drawing.Point(36, 242);
            this.selectSubjectBox.Name = "selectSubjectBox";
            this.selectSubjectBox.Size = new System.Drawing.Size(288, 21);
            this.selectSubjectBox.TabIndex = 14;
            this.selectSubjectBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(117, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(121, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choose Subject";
            // 
            // AssignTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectSubjectBox);
            this.Controls.Add(this.selectTeachersBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AssignTeachers";
            this.Text = "AssignTeachers";
            this.Load += new System.EventHandler(this.AssignTeachers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectTeachersBox;
        private System.Windows.Forms.ComboBox selectSubjectBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}