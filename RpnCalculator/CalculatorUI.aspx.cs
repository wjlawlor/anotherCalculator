using RpnCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RpnCalculator
{
    public partial class CalculatorUI : System.Web.UI.Page
    {
        private const string CalcViewStateKey = "CalcState";
        public Calculator Calculator
        {
            get
            {
                object viewStateNumber = ViewState[CalcViewStateKey];
                if (viewStateNumber != null)
                {
                    return (Calculator)viewStateNumber;
                }
                else
                {
                    // Start null as default.
                    return null;
                }
            }
            set
            {
                ViewState[CalcViewStateKey] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calculator = new Calculator();
                //StackViewer.DataSource = Calculator.DisplayStrings();
                //StackViewer.DataBind();
            }
        }
        protected override void OnPreRenderComplete(EventArgs e)
        {
            StackViewer.DataSource = Calculator.DisplayStrings();
            StackViewer.DataBind();

            base.OnPreRenderComplete(e);
        }

        protected void HandleEntry(object sender, EventArgs e)
        {
            decimal value;
            if(decimal.TryParse(NumberInput.Text, out value) == true)
            {
                Calculator.Push(value);
            }

        }
        protected void HandleAdd(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Add);
        }
        protected void HandleSub(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Subtract);
        }
        protected void HandleMult(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Multiply);
        }
        protected void HandleDiv(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Divide);
        }
        protected void HandleNeg(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Negate);
        }
        protected void HandleDrop(object sender, EventArgs e)
        {
            Calculator.Pop();
        }
    }
}
