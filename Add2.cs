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
    public partial class Add2 : Form
    {
        public List<Teachers> tmp2 { get; set; }
        public Teachers AddT { set; get; }
        public Add2()
        {
            InitializeComponent();
        }
       
        private void bCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            AddT = new Teachers(tbLName.Text, tbName.Text,tbNumber.Text);
            tbName.Clear();
            tbLName.Clear();
            tbNumber.Clear();
            Close();
        }
    }
}
