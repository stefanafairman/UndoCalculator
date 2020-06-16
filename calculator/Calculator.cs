using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public class Calculator
    {
        Stack<Memento> careTaker = new Stack<Memento>();

        private double firstNumber;
        private double secondNumber;
        private char operation;
        private double runningTotal = 0;
        private double result;

        public double FirstNumber
        {
            get
            {
                return firstNumber;
            }

            set
            {
                firstNumber = value;
            }
        }
        public double SecondNumber
        {
            get
            {
                return secondNumber;
            }

            set
            {
               secondNumber = value;
            }
        }
        public char Operation
        {
            get
            {
                return operation;
            }

            set
            {
                operation = value;
            }
        }
        public double RunningTotal
        {
            get
            {
                return runningTotal;
            }
            
        }
        public double Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public double Operations()
        {

            if (Operation == '+')
            {
               Result = FirstNumber + SecondNumber;
            }

            if (Operation == '-')
            {
                Result = FirstNumber - SecondNumber;
            }

            if (Operation == '*')
            {
                Result = FirstNumber * SecondNumber;
            }

            if (Operation == '/')
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Cannot divide by 0!");
                }

                Result = FirstNumber / SecondNumber;
            }
            
            careTaker.Push(new Memento(RunningTotal, FirstNumber, SecondNumber, Operation));
            runningTotal += Result;
            return Result;

        }

        public double undoOperation()
        {

            if (Operation == '+')
            {
                Result = FirstNumber + SecondNumber;
            }

            if (Operation == '-')
            {
                Result = FirstNumber - SecondNumber;
            }

            if (Operation == '*')
            {
                Result = FirstNumber * SecondNumber;
            }

            if (Operation == '/')
            {
                Result = FirstNumber / SecondNumber;
            }

            runningTotal += Result;
            
            return Result;

        }

        public void clear()
        {
            runningTotal = 0;
            firstNumber = 0;
            secondNumber = 0;
            careTaker.Clear();
        }

        public void undo()
        {

            if (careTaker.Count > 0)
            {
                careTaker.Pop();
                
                if (careTaker.Count > 0)
                {
                    Memento m = careTaker.Peek();
                    runningTotal = m.RunningTotal;
                    firstNumber = m.FirstNumber;
                    secondNumber = m.SecondNumber;
                    Operation = m.Operation;
                    undoOperation();
                }
                else
                {
                    firstNumber = 0;
                    secondNumber = 0;
                    runningTotal = 0;
                    Operation = '+';
                    undoOperation();
                }

            }

            else
            {
                string text = "UNDO IS NOT AVAILABLE!";
                MessageBox.Show(text);
            }

        }

    }
}
