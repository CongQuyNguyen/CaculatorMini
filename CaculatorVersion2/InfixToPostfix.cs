using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorVersion2
{
    public class InfixToPostfixPro
    {
        Stack st = new Stack();
        public int Precedence (char x)
        {
            if (x == '(')
            {
                return 0;
            }
            else if (x == '+' || x == '-')
            {
                return 1;
            }
            else if (x == '*' || x == '/')
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public string InfixToPostfix (string infix)
        {
            string postfix = "", number = "";
            char tmp;

            for (int i = 0; i < infix.Length; i++)
            {
                if (char.IsDigit(infix[i]))
                {
                    number += infix[i];
                }
                else
                {
                    if (number.Length > 0)
                    {
                        postfix += number;
                        postfix += " ";
                        number = "";
                    }
                    
                    if (infix[i] == '(')
                    {
                        double num;
                        if (double.TryParse("(", out num))
                        {
                            st.Push(num);
                        }
                        else
                        {
                            Console.WriteLine("Eroll");
                        }
                        // st.Push(Convert.ToDouble('('));
                    }
                    else if (infix[i] == ')')
                    {
                        while ((st.Count > 0) && (Convert.ToChar(st.Peek()) != '(')) 
                        {
                            tmp = Convert.ToChar(st.Pop());
                            postfix += tmp;
                            postfix += " ";
                        }
                    }
                    else
                    {
                        while ((st.Count > 0) && (Precedence(infix[i]) <= Precedence (Convert.ToChar (st.Peek ()))))
                        {
                            tmp = Convert.ToChar(st.Pop());
                            postfix += tmp;
                            postfix += " ";
                        }
                        st.Push(infix[i]);
                    }
                }
            }

            if (number.Length > 0)
            {
                postfix += number;
                postfix += " ";
            }
            
            while (st.Count > 0)
            {
                postfix += Convert.ToChar(st.Pop());
                postfix += " ";
            }

            return postfix;
        }
    }
}
