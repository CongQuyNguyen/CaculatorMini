using System;
using System.Collections.Generic;

namespace CaculatorVersion2
{

    internal class Cal
    {
        public bool IsDigit(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public double Caculate(string infix)
        {
            Stack<double> st = new Stack<double>();
            string[] cal = infix.Split(' ');
            foreach (var token in cal)
            {
                if (IsDigit(token))
                {
                    double number;
                    if (double.TryParse(token, out number))
                    {
                        st.Push(number);
                    }
                    else
                    {
                        Console.WriteLine("Eroll");
                    }

                }
                else
                {
                    double b = st.Pop();
                    double a = st.Pop();

                    if (token == "+")
                    {
                        st.Push(a + b);
                    }
                    else if (token == "-")
                    {
                        st.Push(a - b);
                    }
                    else if (token == "*")
                    {
                        st.Push(a * b);
                    }
                    else if (token == "/")
                    {
                        st.Push(a / b);
                    }
                }
            }
            Console.WriteLine(infix.Length);

            return st.Pop();
        }
    }
}
