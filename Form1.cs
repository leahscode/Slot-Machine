using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineLS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * global variables
         */
        decimal totalInsert = 0, totalWin = 0;
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            // preload images with an insert of 0
            spin();
        }

        private decimal spin()
        {
            // get three random numbers
            int maxNum = fruitImageList.Images.Count;
            int num1 = rand.Next(maxNum), num2 = rand.Next(maxNum), num3 = rand.Next(maxNum);

            // update the images
            fruitImage1.Image = fruitImageList.Images[num1];
            fruitImage2.Image = fruitImageList.Images[num2];
            fruitImage3.Image = fruitImageList.Images[num3];

            // check if there's a match and assign  to "win"
            decimal win;
            if ((num1 == num2) && (num1 == num3))
            {
                win = 3;
            }
            else if ((num1 == num2) || (num1 == num3) || (num2 == num3))
            {
                win = 2;
            }
            else
            {
                win = 0;
            }
            return win;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            decimal spinResult, insert, win;
            if (decimal.TryParse(insertTextBox.Text, out insert))
            {
                // run a spin, calculate win, update global variables, display results
                spinResult = spin();
                win = spinResult * insert;
                totalInsert += insert;
                totalWin += win;

                string msg = (spinResult == 0) ? "Sorry, you didn't win." : "You won " + spinResult + " time the amount you entered!";
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Invalid input detected. Please try again");
                insertTextBox.Text = "";
                insertTextBox.Focus();
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You entered $" + totalInsert + ".\n"
                + "You won $" + totalWin + ".");
            this.Close();
        }
    }
}
