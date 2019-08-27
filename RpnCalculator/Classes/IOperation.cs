using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator.Classes
{
    public interface IOperation
    {
        void Perform(Stack<decimal> myStack);
    }
}