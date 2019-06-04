using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Wind : Form
    {
        List<Teachers> teachers = new List<Teachers>();
        public Wind()
        {
            InitializeComponent();

            teachers.Add(new Teachers("Клепач","Владимир","096335684"));
            teachers.Add(new Teachers("Хилько", "Андрей", "0934582395"));
            teachers.Add(new Teachers("Чумак", "Дмитрий", "0994723465"));
            

            teachers[0].student.Add(new Students("София","Рожко",new DateTime(2001,2,22)));
            teachers[0].student[0].Number = "0935803385";
            teachers[0].student.Add(new Students("Толик", "Прищенко", new DateTime(1996, 7, 8)));
            teachers[0].student[1].Number = "0735962345";
            teachers[0].student.Add(new Students("РобертО", "Григорян", new DateTime(2000, 9,3)));
            teachers[0].student[2].Number = "0998729945";

            teachers[1].student.Add(new Students("Владислав","Миненко", new DateTime(2000,6,29)));
            teachers[1].student.Add(new Students("Наталия", "Лоик", new DateTime(1998, 6, 19)));
            teachers[1].student.Add(new Students("Антон", "Пызев", new DateTime(1999, 6, 12)));

            teachers[2].student.Add(new Students("Демидов", "Виктор", new DateTime(1991, 6, 29)));
            teachers[2].student.Add(new Students("Богдан", "Марченко", new DateTime(1999,4, 5)));
            teachers[2].student.Add(new Students("Илья", "Косогов", new DateTime(1979, 8, 11)));

            cbTeacher.DataSource = teachers;

        }

        private void cbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
        private void bAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void bRemove_Click(object sender, EventArgs e)
        {

            
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbStudents_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void bSms_Click(object sender, EventArgs e)
        {
            var wnd = new Sms();
            wnd.ShowDialog();
        }

        private void lbStudents_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeacher.SelectedIndex < -1)
                return;
            lbStudents.DataSource = null;
            lbStudents.DataSource = teachers[cbTeacher.SelectedIndex].student;
        }

        private void bAddTeach_Click(object sender, EventArgs e)
        {
            var wnd2 = new Add2();
            wnd2.ShowDialog();
            //wnd2.set(teachers);
            var data = wnd2.AddT;
            int index = cbTeacher.SelectedIndex;
            teachers.Add(data);
            cbTeacher.DataSource = null;
            cbTeacher.DataSource = teachers;
        }

        private void bRemove_Click_1(object sender, EventArgs e)
        {
            if (lbStudents.SelectedIndex > -1)
            {
                int index = lbStudents.SelectedIndex;

                teachers[cbTeacher.SelectedIndex].student.RemoveAt(lbStudents.SelectedIndex);
                lbStudents.DataSource = null;
                lbStudents.DataSource = teachers[cbTeacher.SelectedIndex].student;
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            var wnd1 = new Add();
            wnd1.set(teachers);
            wnd1.setst(teachers[cbTeacher.SelectedIndex].student[lbStudents.SelectedIndex]);
            wnd1.ShowDialog();

            var data = wnd1.AddS;
            teachers[cbTeacher.SelectedIndex].student[lbStudents.SelectedIndex] = data;
            lbStudents.DataSource = null;
            lbStudents.DataSource = teachers[cbTeacher.SelectedIndex].student;
        }

        private void bAdd_Click_1(object sender, EventArgs e)
        {
            var wnd = new Add();
            wnd.set(teachers);
            wnd.ShowDialog();
            var data = wnd.AddS;
            int index = cbTeacher.SelectedIndex;
            teachers[index].student.Add(data);
            lbStudents.DataSource = null;
            lbStudents.DataSource = teachers[index].student;
        }

        private void lbStudents_DoubleClick_1(object sender, EventArgs e)
        {
            var wnd3 = new Mark();
            wnd3.ShowDialog();
        }
    }
}
