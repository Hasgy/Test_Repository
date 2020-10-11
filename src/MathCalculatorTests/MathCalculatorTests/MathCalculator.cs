using System;

namespace MathCalculatorTests 
{
    public class MathCalculator
    {
        public int Sum(int a, int b){
            return a+b;
        }

        public int Sum(string a, string b){
            return int.Parse(a+b);
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Sum(string a, string b)
        {   
            return Convert.ToInt32(a) + Convert.ToInt32(b); 
        }

        public string UnitStrings(string a, string b){
            return a + b;
        }
    }
}