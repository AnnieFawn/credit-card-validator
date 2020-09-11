using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    /*
    * INFO 1112 - SUMMER 2016
    * ASSIGNMENT 3
    *
    * Student Name : Anna Phan
    * Student Number : 100303872
    */
    public partial class Form1 : Form
    {        /* Return true if the card number is valid */
        static bool IsValid(long number)
        {

            /* Your code goes here */

            // if the number is divisible by 10  shows the card is valid if not invalid
            if (number % 10 == 0)
            {
                MessageBox.Show("This card is valid");
                return true;

            }

            else
            {
                MessageBox.Show("This is invalid");
                return false;
            }

            }
        /* * Get the result from Step 2 */
        static long SumOfDoubleEvenPlace(long number)
        {
            /* Your code goes here */
            long result = 0;
            number = number / 10;
            while (number != 0)
            {
                //reads the second digit from right to left
                result += GetDigit((number % 10) * 2); 
                number = number / 100;
            }
            return result;
        }
        /* * Return this number if it is a single digit ,
        * otherwise , return the sum of the two digits */
        static long GetDigit(long number)
        {
            /* Your code goes here */

            return number % 10 + (number / 10);

        }
        /* * Return sum of odd place digits in number */
        static long SumOfOddPlace(long number)
        {
            /* Your code goes here */
            long result = 0;
            while (number != 0)
            {
                //reads the second digit from right to left
                result += GetDigit(number % 10);
                number = number / 100;
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool start = true; 

           //Checks if the card type is correct
            string CardString = txtbCardNumber.Text;
            //if visa is checked and the first charater of the string is 4
            if ((RBVisa.Checked) && (CardString[0] != '4'))
            {
                MessageBox.Show("This is an incorrect card type!");
                start = false;
            }
            //if Master card is checked and the first charater of the string is 5
            else if ((RBMasterCard.Checked) && (CardString[0] != '5'))
            {
                MessageBox.Show("This is an incorrect card type!");
                start = false;
            }
            //if Amex is checked and the first charater of the string is 37
            else if ((RBAmex.Checked) && ((CardString[0] != '3') || (CardString[1] != '7')))
            {
                MessageBox.Show("This is an incorrect card type!");
                start = false;
            }
            //if Discovery is checked and the first charater of the string is 6
            else if ((RBDiscovery.Checked) && (CardString[0] != '6'))
            {
                MessageBox.Show("This is an incorrect card type!");
                start = false;
            }

            if (start == true)
            {
                long CardNumber = long.Parse(txtbCardNumber.Text);

                long TotalSum =
                SumOfDoubleEvenPlace(CardNumber) +
                SumOfOddPlace(CardNumber);

                IsValid(TotalSum);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void CBYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
