using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator.Classes
{
    public class NegateOperation : IOperation
    {
        public void Perform(Stack<decimal> myStack)
        {
            if (myStack.Count >= 1)
            {
                decimal operandOne = myStack.Pop();

                decimal result = operandOne * -1;
                myStack.Push(result);
            }
        }
    }
}