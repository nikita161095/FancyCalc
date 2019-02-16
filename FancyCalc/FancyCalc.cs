using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }

        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            //throw new NotImplementedException();
            if (expression == null)
            {
                throw new ArgumentNullException();
            }
            int pos_sign = expression.IndexOfAny(new char[] { '+', '-', '*', '/' });
            int pos_equal = expression.IndexOf('=');
            double a;
            double b;
            if (pos_equal == -1)
            {
                pos_equal = expression.Length;
            }
            try
            {
                a = double.Parse(expression.Substring(0, pos_sign));
                b = double.Parse(expression.Substring(pos_sign + 1, pos_equal - 1 - pos_sign));
            }
            catch
            {
                throw new ArgumentNullException();
            }
            if (expression.IndexOf('+') != -1)
            {
                return a + b;
            }
            else if (expression.IndexOf('-') != -1)
            {
                return a - b;
            }
            else if (expression.IndexOf('*') != -1)
            {
                return a * b;
            }
            else if (expression.IndexOf('/') != -1)
            {
                if (b == 0)
                {
                    throw new ArgumentException();
                }
                return a / b;
            }
            else
            {
                return 0;
            }
        }
    }
}
