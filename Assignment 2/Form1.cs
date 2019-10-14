using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double SR1, SR2, SR3;
            // shows when each text box is being used in each set of code// 

            try
            {
                SR1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Invaled Input");
                SR1 = 0.0;
                // if input given is not a number then it will be seen as an error//

            }
            try
            {
                SR2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Invaled Input");
                SR2 = 0.0;
                // if input given is not a number then it will be seen as an error//
            }
            try
            {
                SR3 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Invaled Input");
                SR3 = 0.0;
                // if input given is not a number then it will be seen as an error//
            }
            double resistance = SR1 = SR2;
            label4.Text = "R Total =" + resistance;
            //This is used to calculate the total resistance//
        }
              

        private void Button2_Click(object sender, EventArgs e)
        {
            double PR1, PR2, PR3;
            // shows when each text box is being used in each set of code// 

            try
            {
                PR1 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Invaled Input");
                PR1 = 0.0;
                // if input given is not a number then it will be seen as an error//
                            
            }
            try
            {
                PR2 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Invaled Input");
                PR2 = 0.0;
                // if input given is not a number then it will be seen as an error//

            }
            try
            {
                PR3 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Invaled Input");
                PR3 = 0.0;
                // if input given is not a number then it will be seen as an error//
            }






        }
    }
}
