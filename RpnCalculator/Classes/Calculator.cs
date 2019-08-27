using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator.Classes
{
    [Serializable]
    public class Calculator
    {
        private Stack<decimal> myStack = new Stack<decimal>();

        public void Push(decimal data)
        {
            myStack.Push(data);
        }

        public void Pop()
        {
            myStack.Pop();
        }

        public string[] DisplayStrings()
        {
            string[] array = new string[4];
            int i = 0;
            foreach (var v in myStack)
            {
                array[i] = v.ToString();
                i++;
                if (i == 4)
                {
                    break;
                }
            }
            return array;
        }

        public void PerformOperation(OperationType type)
        {
            IOperation operation = null;
            if(type == OperationType.Add)
            {
                operation = new AddOperation();
            }
            else if (type == OperationType.Subtract)
            {
                operation = new SubtractOperation();
            }
            else if (type == OperationType.Multiply)
            {
                operation = new MultiplyOperation();
            }
            else if (type == OperationType.Divide)
            {
                operation = new DivideOperation();
            }
            else if (type == OperationType.Negate)
            {
                operation = new NegateOperation();
            }
            if (operation != null)
            {
                operation.Perform(myStack);
            }
        }
    }
}
