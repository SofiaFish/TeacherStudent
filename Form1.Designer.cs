namespace WindowsFormsApplication7
{
    partial class Wind
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
            this.bSms = new System.Windows.Forms.Button();
            this.bChange = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddTeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSms
            // 
            this.bSms.Location = new System.Drawing.Point(171, 187);
            this.bSms.Name = "bSms";
            this.bSms.Size = new System.Drawing.Size(75, 23);
            this.bSms.TabIndex = 15;
            this.bSms.Text = "Сообщение";
            this.bSms.UseVisualStyleBackColor = true;
            this.bSms.Click += new System.EventHandler(this.bSms_Click);
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(171, 158);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(75, 23);
            this.bChange.TabIndex = 14;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(171, 129);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 13;
            this.bRemove.Text = "Удалить";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click_1);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(171, 100);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click_1);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(12, 100);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(139, 108);
            this.lbStudents.TabIndex = 11;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged_1);
            this.lbStudents.DoubleClick += new System.EventHandler(this.lbStudents_DoubleClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Студенты";
            // 
            // cbTeacher
            // 
            this.cbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(12, 40);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(139, 24);
            this.cbTeacher.TabIndex = 9;
            this.cbTeacher.SelectedIndexChanged += new System.EventHandler(this.cbTeacher_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Преподаватель";
            // 
            // bAddTeach
            // 
            this.bAddTeach.Location = new System.Drawing.Point(171, 40);
            this.bAddTeach.Name = "bAddTeach";
            this.bAddTeach.Size = new System.Drawing.Size(75, 23);
            this.bAddTeach.TabIndex = 16;
            this.bAddTeach.Text = "Добавить";
            this.bAddTeach.UseVisualStyleBackColor = true;
            this.bAddTeach.Click += new System.EventHandler(this.bAddTeach_Click);
            // 
            // Wind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 230);
            this.Controls.Add(this.bAddTeach);
            this.Controls.Add(this.bSms);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTeacher);
            this.Controls.Add(this.label1);
            this.Name = "Wind";
            this.Text = "Ghtgjl";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSms;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddTeach;
    }
}

