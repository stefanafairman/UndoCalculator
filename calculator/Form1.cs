using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class frmCalculator : Form
    {
        double variable;
        bool periodPressed;
        long powersOfTen;
        bool checkIfNegative = false;
        bool noNumPressed;

        Calculator c;

        public frmCalculator()
        {
            variable = 0;
            periodPressed = false;
            powersOfTen = 10;
            InitializeComponent();
            c = new Calculator();
            noNumPressed = true;
            checkIfNegative = false;
            txtRunningTotal.Text = 0.ToString();
            txtDisplay.Text = 0.ToString();
        }
        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void frmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    cmd0.PerformClick();
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    cmd1.PerformClick();
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    cmd2.PerformClick();
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    cmd3.PerformClick();
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    cmd4.PerformClick();
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    cmd5.PerformClick();
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    cmd6.PerformClick();
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    cmd7.PerformClick();
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    cmd8.PerformClick();
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    cmd9.PerformClick();
                    break;
                case Keys.Add:
                    cmdAdd.PerformClick();
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    cmdSubtract.PerformClick();
                    break;
                case Keys.Divide:
                    cmdDivision.PerformClick();
                    break;
                case Keys.Multiply:
                    cmdMultiply.PerformClick();
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    cmdPeriod.PerformClick();
                    break;
                case Keys.Oemplus:
                    cmdEquals.PerformClick();
                    break;
            }
            
        }
        private void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void cmdPeriod_Click(object sender, EventArgs e)
        {
            periodPressed = true;
        }

        
        private void handleNumbers(char input)
        {
            noNumPressed = false;
            if (periodPressed)
            {
                double digit = ((double)input) / powersOfTen;
                variable += digit;
                powersOfTen *= 10;
            }
            else
            {
                variable *= 10;
                variable += input;
            }

            if (checkIfNegative)
            {
                txtDisplay.Text = (variable*(-1)).ToString();

            }
            else
            {
                txtDisplay.Text = variable.ToString();

            }
            
        }
        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            handleNumbers((char)1);
        }
        private void cmd2_Click(object sender, EventArgs e)
        {
            handleNumbers((char)2);
        }
        private void cmd3_Click(object sender, EventArgs e)
        {
            handleNumbers((char)3);
        }
        private void cmd4_Click(object sender, EventArgs e)
        {
            handleNumbers((char)4);
        }
        private void cmd5_Click(object sender, EventArgs e)
        {
            handleNumbers((char)5);
        }
        private void cmd6_Click(object sender, EventArgs e)
        {
            handleNumbers((char)6);
        }
        private void cmd7_Click(object sender, EventArgs e)
        {
            handleNumbers((char)7);
        }
        private void cmd8_Click(object sender, EventArgs e)
        {
            handleNumbers((char)8);
        }
        private void cmd9_Click(object sender, EventArgs e)
        {
            handleNumbers((char)9);
        }
        private void cmd0_Click(object sender, EventArgs e)
        {
            handleNumbers((char)0);
        }
        private void resetMethod()
        {
            variable = 0;
            periodPressed = false;
            powersOfTen = 10;
            noNumPressed = true;
            checkIfNegative = false;
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (checkIfNegative)
            {
                c.FirstNumber = variable * (-1);

            }
            else
            {
                c.FirstNumber = variable;

            }
            c.Operation = '+';
            resetMethod();
            

        }

        private void cmdSubtract_Click(object sender, EventArgs e)
        {
            if (noNumPressed)
            {
                checkIfNegative = true;
                
            }
            else
            {
                if (checkIfNegative)
                {
                    c.FirstNumber = variable * (-1);
                    c.Operation = '-';
                    resetMethod();
                }
                else
                {
                    c.FirstNumber = variable;
                    c.Operation = '-';
                    resetMethod();
                }
                
            }



        }
        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            if (checkIfNegative)
            {
                c.FirstNumber = variable * (-1);

            }
            else
            {
                c.FirstNumber = variable;

            }

            c.Operation = '*';
            resetMethod();
            


        }
        private void cmdDivision_Click(object sender, EventArgs e)
        {
            if (checkIfNegative)
            {
                c.FirstNumber = variable * (-1);

            }
            else
            {
                c.FirstNumber = variable;

            }
            c.Operation = '/';
            resetMethod();

        }
        private void cmdEquals_Click(object sender, EventArgs e)
        {
            if (checkIfNegative)
            {
                c.SecondNumber = variable * (-1);
            }
            else
            {
                c.SecondNumber = variable;
            }

            variable = c.Operations();
            txtRunningTotal.Text = c.RunningTotal.ToString();
            txtDisplay.Text = variable.ToString();
            resetMethod();
            c.FirstNumber = 0;
            c.SecondNumber = 0;
        }
        private void clearMethod()
        {
            txtDisplay.Clear();
            txtRunningTotal.Clear();
            c.FirstNumber = 0;
            c.SecondNumber = 0;
            
            variable = 0;
            periodPressed = false;
            powersOfTen = 10;
            txtRunningTotal.Text = 0.ToString();
            txtDisplay.Text = 0.ToString();
        }
        private void cmdClear_Click(object sender, EventArgs e)
        {
            clearMethod();
            c.clear();
        }

        private void txtRunningTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdUndo_Click(object sender, EventArgs e)
        {
            c.undo();
            txtRunningTotal.Text = c.RunningTotal.ToString();
            txtDisplay.Text = c.Result.ToString();

        }
    }
}
