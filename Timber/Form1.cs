using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timber
{
    public partial class Timber : Form
    {

        double days; //Public variable declaration

        public Timber()
        {
            InitializeComponent();
            BackColor = Color.Cyan; //Changing background colour
        }

        private double CalcDays(double length, double breadth) //Creating CalcDays() method
        {
            double area = length * breadth;
            days = area / 6;
            lboxResult.Items.Add("It will take " + Math.Round(days, 2) + " days to install this wooden floor"); //Displaying result on listbox
            return (days); //Retrurning number of days
        }

        private void DisplayScale(double days) //Creating DisplayScale() method
        {
            if (days >= 12) //Determining appropriate scale 
            {
                lboxResult.Items.Add("A project that lasts " + Math.Round(days, 2) + " days, is large scale"); //Displaying result on listbox
            }
            else if (days >= 7)
            {
                lboxResult.Items.Add("A project that lasts " + Math.Round(days, 2) + " days, is semi-large scale");
            }
            else if (days >= 1)
            {
                lboxResult.Items.Add("A project that lasts " + Math.Round(days, 2) + " days, is small scale");
            }
            else
            {
                MessageBox.Show("Please enter a valid length and breadth"); //Message if scale is not valid
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double length; //Variable declaration
            double breadth;

            if (double.TryParse(tbLength.Text, out length)) //Ensurning valid user input (decimal value)
            {
                if (double.TryParse(tbBreadth.Text, out breadth)) //Ensurning valid user input (decimal value)
                {
                    lboxResult.Items.Clear(); //Clearing listbox and texboxes and setting focus
                    tbBreadth.Clear();
                    tbLength.Clear();
                    tbBreadth.Focus();
                    double time = CalcDays(length, breadth); //Calling CalcDays() method
                    DisplayScale(days);//Calling DisplayScale() method
                }
                else
                {
                    MessageBox.Show("Please enter a valid breadth"); //Messge if user enters invalid input
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid length");
            }
    }
    }
}
