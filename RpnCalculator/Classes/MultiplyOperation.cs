using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator.Classes
{
    public class MultiplyOperation : IOperation
    {
        public void Perform(Stack<decimal> myStack)
        {
            if (myStack.Count >= 2)
            {
                decimal operandOne = myStack.Pop();
                decimal operandTwo = myStack.Pop();

                decimal result = operandOne * operandTwo;
                myStack.Push(result);
            }
        }
    }
}