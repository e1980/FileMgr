using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInput frmInput = new frmInput();
            frmInput.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSerach frmSerach = new frmSerach();
            frmSerach.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
