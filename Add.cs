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
    public partial class Add : Form
    {
      public List<Teachers> tmp { get; set; }
        public Students AddS { set; get; }
        public Add()
        {
            InitializeComponent();
        }

        public void set(List<Teachers> s)
        {
            tmp = s;
            cbTeacher.DataSource = null;
            cbTeacher.DataSource = tmp;

        }
        public void setst(Students ss)
        {
            tbName.Text = ss.Name;
            tbLName.Text = ss.LName;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bOk_Click(object sender, EventArgs e)
        {
            AddS = new Students(tbLName.Text, tbName.Text, mcBirthday.SelectionStart);
            tbName.Clear();
            tbLName.Clear();
            Close();
        }

        private void bCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
