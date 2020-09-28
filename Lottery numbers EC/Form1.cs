using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_numbers_EC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Create an array to hold the numbers 
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            // Create a Random Object 
            Random rand = new Random(); 

            //Array of random numbers 0-99
            for (int index = 0; index <lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(100);
            }

            // Display the array elements 
            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString(); 
            fifthLabel.Text = lotteryNumbers[4].ToString(); 
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close out the app
            this.Close(); 
        }
    }
}
