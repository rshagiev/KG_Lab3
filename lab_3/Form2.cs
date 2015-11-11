using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Begining : Form
    {
        public Begining()
        {
            InitializeComponent();
        }

        private void Ok_but_Click(object sender, EventArgs e)
        {
            Form1 pr = new Form1(rad_imp.Text);
            pr.ShowDialog();
        }

        private void Cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Begining_Load(object sender, EventArgs e)
        {

        }
    }
}
