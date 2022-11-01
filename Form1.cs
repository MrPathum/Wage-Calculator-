using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02WageCalculator
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal hours, rate, earning;
            hours = decimal.Parse(inputTextbox01.Text);
            rate = decimal.Parse(inputTextBox02.Text);
            earning = hours * rate;
            resultTextBox.Text = earning.ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextbox01.Clear();
            inputTextBox02.Clear();
            resultTextBox.Clear();
            inputTextbox01.Focus();
        }
    }
}
