using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int number = 0;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Enabled = false;
            button.BackColor = Color.Gray;
            lblGenerateInfo.Text = "Number has been generated";
            number = random.Next(100);        
        }

     

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbGuess.Text) == number)
            {
                lblClose.Text = "You won:)";
                lblClose.ForeColor = Color.Green;
                MessageBox.Show("Congratulations!", "You won:)", MessageBoxButtons.OK);
            }
            else if (int.Parse(tbGuess.Text) > number)
            {
                lblClose.Text = "The number is smaller";
                lblClose.ForeColor = Color.YellowGreen;
            }
            else if (int.Parse(tbGuess.Text) < number)
            {
                lblClose.Text = "The number is bigger";
                lblClose.ForeColor = Color.YellowGreen;
            }
        }
    }
}
