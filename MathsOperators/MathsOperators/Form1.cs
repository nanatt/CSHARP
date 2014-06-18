using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                int leftHandSide = int.Parse(lhsOperand.Text);
                int rightHandSide = int.Parse(rhsOperand.Text);
                int answer = doCalculation(leftHandSide, rightHandSide);
                result.Text = answer.ToString();
            }
            catch (FormatException fEx)
            {
                result.Text = fEx.Message;
            }
            catch (OverflowException oEx)
            {
                result.Text = oEx.Message;
            }
            catch (InvalidOperationException ioEx)
            {
                result.Text = ioEx.Message;
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
            }            
        }

        private int doCalculation(int leftHandSide, int rightHandSide)
        {
            int result = 0;

            if(addition.Checked)
                result = addValues(leftHandSide, rightHandSide);
            else if(subtraction.Checked)
                result = subtractValues(leftHandSide, rightHandSide);
            else if(multiplication.Checked)
                result = multiplyValues(leftHandSide, rightHandSide);
            else if(division.Checked)
                result = divideValues(leftHandSide, rightHandSide);
            else if(remainder.Checked)
                result = remainderValues(leftHandSide, rightHandSide);
            else
                throw new InvalidOperationException("no operator selected");

            return result;
        }
        private int addValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " + " + rightHandSide.ToString();
            return leftHandSide + rightHandSide;
        }
        private int subtractValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " - " + rightHandSide.ToString();
            return leftHandSide - rightHandSide;
        }
        private int multiplyValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " * " + rightHandSide.ToString();
            return leftHandSide * rightHandSide;
        }
        private int divideValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " / " + rightHandSide.ToString();
            return leftHandSide / rightHandSide;
        }
        private int remainderValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " % " + rightHandSide.ToString();
            return leftHandSide % rightHandSide;
        }
    }
}