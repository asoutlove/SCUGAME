using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFinal
{
    public partial class FormMain : Form
    {

        game1 frmG1 = new game1();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("01156227 廖振廷, 01156230 歐紀安, 01156282 劉珈妤");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmG1.Show(this);
            this.Hide();
        }
    }
}
