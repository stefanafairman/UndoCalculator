using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Memento
    {
        private double runningTotal;
        private double firstNumber;
        private double secondNumber;
        private char operation;

        public double RunningTotal
        {
            get
            {
                return runningTotal;
            }
            private set 
            {
                if (value >= 0)
                    runningTotal = value;
            }
        }

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

            private set
            {
                operation = value;
            }
        }

        public Memento(double inRunningTotal, double inFirstNumber, double inSecondNumber, char inOperation)
        {

            RunningTotal = inRunningTotal;
            FirstNumber = inFirstNumber;
            SecondNumber = inSecondNumber;
            Operation = inOperation;

        }



    }
}
