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
            try
            {
                int R = Convert.ToInt32(rad_imp.Text);
            
                 if (R < 0)
                {
                   MessageBox.Show("Invalid input. Please use only numbest grater than 0");
                }
                  else
                    {
                         Form1 pr = new Form1(R);
                         pr.ShowDialog();
                     }
             }
            catch (FormatException R)
            {
                MessageBox.Show("Use only natural numbers!!!");
            }
            catch (OverflowException R)
            {
                MessageBox.Show("The number is too big. Try again.");
            }

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

        private void rad_imp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
