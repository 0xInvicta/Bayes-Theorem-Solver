using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bayes__Theorem_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            displayResults.Clear();
            try
            {
                float PA = float.Parse(PABox.Text);
                float PBA = float.Parse(PBABox.Text);
                float PB = float.Parse(PBBox.Text);
            }
            catch (FormatException ex)
            {
                //throw;
                MessageBox.Show("Please Enter a valid number !","ERROR");
            }

            float numPA = float.Parse(PABox.Text);
            float numPBA = float.Parse(PBABox.Text);
            float numPB = float.Parse(PBBox.Text);
            if (numPA > 100 || numPBA > 100 || numPB > 100)
            {
                displayResults.Text += "% cannot be greater then 100%";
            }
            else
            {
                float probability = (numPA * numPBA) / numPB;

                displayResults.Text += probability.ToString();
            }
            
        }
    }
}
