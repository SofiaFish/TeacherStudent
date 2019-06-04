namespace WindowsFormsApplication7
{
    partial class Mark
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
            this.lName = new System.Windows.Forms.Label();
            this.lbMark = new System.Windows.Forms.ListBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.bAddMark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lTeacher = new System.Windows.Forms.Label();
            this.lStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(12, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(61, 16);
            this.lName.TabIndex = 0;
            this.lName.Text = "Препод:";
            this.lName.Click += new System.EventHandler(this.lName_Click);
            // 
            // lbMark
            // 
            this.lbMark.FormattingEnabled = true;
            this.lbMark.Location = new System.Drawing.Point(16, 80);
            this.lbMark.Name = "lbMark";
            this.lbMark.Size = new System.Drawing.Size(150, 95);
            this.lbMark.TabIndex = 1;
            this.lbMark.SelectedIndexChanged += new System.EventHandler(this.lbMark_SelectedIndexChanged);
            // 
            // tbAdd
            // 
            this.tbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdd.Location = new System.Drawing.Point(16, 188);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(64, 22);
            this.tbAdd.TabIndex = 2;
            this.tbAdd.TextChanged += new System.EventHandler(this.tbAdd_TextChanged);
            this.tbAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdd_KeyPress);
            // 
            // bAddMark
            // 
            this.bAddMark.Location = new System.Drawing.Point(91, 188);
            this.bAddMark.Name = "bAddMark";
            this.bAddMark.Size = new System.Drawing.Size(75, 23);
            this.bAddMark.TabIndex = 3;
            this.bAddMark.Text = "add";
            this.bAddMark.UseVisualStyleBackColor = true;
            this.bAddMark.Click += new System.EventHandler(this.bAdd1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Студент:";
            // 
            // lTeacher
            // 
            this.lTeacher.AutoSize = true;
            this.lTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTeacher.Location = new System.Drawing.Point(100, 9);
            this.lTeacher.Name = "lTeacher";
            this.lTeacher.Size = new System.Drawing.Size(11, 16);
            this.lTeacher.TabIndex = 5;
            this.lTeacher.Text = ".";
            this.lTeacher.Click += new System.EventHandler(this.lTeacher_Click);
            // 
            // lStudent
            // 
            this.lStudent.AutoSize = true;
            this.lStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStudent.Location = new System.Drawing.Point(100, 40);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(11, 16);
            this.lStudent.TabIndex = 6;
            this.lStudent.Text = ".";
            // 
            // Mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 222);
            this.Controls.Add(this.lStudent);
            this.Controls.Add(this.lTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddMark);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.lbMark);
            this.Controls.Add(this.lName);
            this.Name = "Mark";
            this.Text = "Mark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ListBox lbMark;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button bAddMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTeacher;
        private System.Windows.Forms.Label lStudent;
    }
}