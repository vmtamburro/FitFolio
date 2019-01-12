using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace FitFolio.Assets.Helper
{
   public class InfixToPostfix
    {
        public bool check_error = false;//check the first charachter is positive or negative

        public string StardardizeDouble(double num)
        {
            int a = (int)num;
            if (a == num)
                return a.ToString();
            else
                return num.ToString();
        }

        public bool IsCharPi(char c)
        {
            if (c == 'n')// Alt+227
                return true;
            else
                return false;
        }

        public bool IsNumPi(double num)
        {
            if (num == Math.PI)
                return true;
            else
                return false;
        }

        public bool IsNum(char c)
        {
            if (Char.IsDigit(c) || IsCharPi(c))
                return true;
            else
                return false;
        }

        public string NumToString(double num)
        {
            if (IsNumPi(num))
                return "n";
            else
               return StardardizeDouble(num);
        }

        public double StringToNum(string s)
        {
            if (IsCharPi(s[0]))
                return Math.PI;
            else
                return double.Parse(s);
        }

        public bool IsOperator(char c)
        {
            // @ = square root
            //
            char[] operatorList = { '+', '-', '*', '/', '^','~', '-', 's', 'c', 't', '@', '!', '%', '(', ')' };
            Array.Sort(operatorList);
            if(Array.BinarySearch(operatorList, c)>-1)
                return true;
            else
                return false;
        }

        public int Priority(char c)
        {
            switch(c)
            {
                case '+': case '-':
                    return 1;
                case '*': case '/':
                    return 2;
                case '~':
                    return 3;
                case '@': case '^':
                    return 4;
                case 's': case 'c': case 't':
                    return 5;
                default:
                    return 0;
            }
        }

        public bool IsOneMath(char c)
        {
            char[] operatorList = { 's', 'c', 't', '@', '('};
            Array.Sort(operatorList);
            if (Array.BinarySearch(operatorList, c) > -1)
                return true;
            else
                return false;
        }

        public string Stardardize(String s)
        {
            String sl = String.Empty;
            s = s.Trim();
            s = s.Replace("\\s+", " ");
            int open = 0, close = 0;
            for (int i = 0; i <s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                    open++;
                if (c == ')')
                    close++;        
            }

            for (int i = 0; i < (open-close); i++)//Auto Append )
            {
                if (i > 0 && IsOneMath(s[i]) && (s[i-1]== ')' || IsNum(s[i-1])))
                    sl += "+";
                if ((i == 0 || (i > 0 && !IsNum(s[i - 1]))) && s[i] == '-' && IsNum(s[i + 1]))
                    sl += '~'; //check negative
                else if (i > 0 && (IsNum(s[i - 1])) || s[i - 1] == ')' && IsCharPi(s[i]))
                    sl = sl + "*" + s[i];// change : &n,...)n to 6*n,...)*n
                else
                    sl += s[i];
            }
            return sl;

        }

        public string[] ProcessString(string sMath)
        {
            string sl = String.Empty;
            string[] elementMath = null;
            sMath = Stardardize(sMath);
            InfixToPostfix ITP = new InfixToPostfix();
            for (int i = 0; i < sMath.Length; i++)
            {
                char c = sMath[i];
                if (i < sMath.Length - 1 && IsCharPi(c) && !IsOperator(sMath[i + 1]))
                {
                    check_error = true;
                    return null;
                }
                else
                {
                    if (!IsOperator(c))
                        sl += c;
                    else
                        sl = sl + " " + c + " ";
                }
            }

                sl = sl.Trim();
                sl = sl.Replace("\\s+", " ");
                elementMath = sl.Split(' ');
                return elementMath;
            }

        public string [] PostFix(string[] elementMath)
        {
            string sl = String.Empty;
            string[] E;
            Stack<string> S = new Stack<string>();
            for (int i = 0; i < elementMath.Length; i++)
            {
                char c = elementMath[i][0];
                if (!IsOperator(c))
                    sl = sl + elementMath[i] + " ";
                else
                {
                    if (c == '(')
                        S.Push(elementMath[i]);
                    else
                    {
                        if(c== ')')
                        {
                            char cl;
                            do
                            {
                                cl = S.Peek()[0];
                                if (cl != '(')
                                    sl = sl + S.Peek() + " ";
                                S.Pop();
                            } while (cl != '(');
                        }
                        else
                        {
                            while (S.Count == 0 && Priority(S.Peek()[0])>= Priority(c))
                                sl = sl + S.Pop() + " ";
                            S.Push(elementMath[i]);

                        }
                    }
                }

            }
            while (S.Count != 0)
                sl = sl + S.Pop() + " ";
            E = sl.Split(' ');
            E = E.Take(E.Length - 1).ToArray();//Remove last index
            return E;
        }

        public string ValueMath(string[] elementMath)
        {
            Stack<double> S = new Stack<double>();
            double num = 0.0;
            for(int i = 0; i < elementMath.Length; i++)
            {
                char c = elementMath[i][0];
                if (IsCharPi(c))
                    S.Push(Math.PI);
                else
                {
                    if (!IsOperator(c))
                        S.Push(double.Parse(elementMath[i]));
                    else
                    {
                        double num1 = S.Pop();
                        switch (c)
                        {
                            case '~':
                                num = -num1;
                                break;
                            case 's':
                                num = Math.Sin(num1);
                                break;
                            case 'c':
                                num = Math.Cos(num1);
                                break;
                            case 't':
                                num = Math.Tan(num1);
                                break;
                            case '%':
                                num = num1 / 100;
                                break;
                            case '@':
                                {
                                    if (num1 >= 0)
                                        num = Math.Sqrt(num1);
                                    else
                                        check_error = true;
                                }
                                break;
                            case '!':
                                {
                                    if (num1 >= 0 && (int)num1 == num1)
                                    {
                                        num = 1;
                                        for (int j = 1; j <= (int)num1; j++)
                                            num *= j;
                                    }
                                    else
                                        check_error = true;
                                }
                                break;
                            default:
                                break;

                        }
                        if (S.Count != 0)
                        {
                            double num2 = S.Peek();
                            switch (c)
                            {
                                case '+':
                                    num = num2 + num1;
                                    S.Pop();
                                    break;
                                case '-':
                                    num = num2 - num1;
                                    S.Pop();
                                    break;
                                case '*':
                                    num = num2 * num1;
                                    S.Pop();
                                    break;
                                case '/':
                                    {
                                        if (num1 != 0)
                                            num = num2 / num1;
                                        else
                                            check_error = true;
                                        S.Pop();
                                    }
                                    break;
                                case '^':
                                    num = Math.Pow(num1, num1);
                                    S.Pop();
                                    break;
                            }
                        }
                        S.Push(num);
                    }   
                    
                }
            }
            return NumToString(S.Pop());
        }

   }
}

