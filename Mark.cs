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
    public partial class Mark : Form
    {
        List<string> marks;
        public Mark()
        {
            InitializeComponent();
            marks = new List<string>();
        }

        private void lbMark_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAdd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lName_Click(object sender, EventArgs e)
        {
             lName.Text = ToString();

        }

        private void bAdd1_Click(object sender, EventArgs e)
        {
           
            lbMark.Items.Add(tbAdd.Text);
            tbAdd.Clear();
            marks.Add(tbAdd.Text);
        }

        private void tbAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 )
                e.Handled = true;

        }

        private void lTeacher_Click(object sender, EventArgs e)
        {
            //lTeacher.Text = 
        }
    }
}
