using System;

namespace WindowsFormsApp1
{
    interface ICalculator
    {
        decimal Number1 { get; set; }
        decimal Number2 { get; set; }
        decimal Result {  get; set; }
        decimal GetNumber();
        decimal Add(decimal n1, decimal n2);
        decimal Subtract(decimal n1, decimal n2);
        decimal Multiply(decimal n1, decimal n2);
        decimal Divide(decimal n1, decimal n2);
        void Reset();
        event EventHandler 加;
        event EventHandler 減;
        event EventHandler 乘;
        event EventHandler 除;
        event EventHandler 等於;
        event EventHandler 小數點;
    }
}
