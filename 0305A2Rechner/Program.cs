using System;

namespace _0305A2Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string operators = "+-*/xX.";
            int a, b, r, rr = 0;
            char o;

            Console.Write("Bitte geben Sie Zahl a ein     : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie den Operator an: ");
            o = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.Write("Bitte geben Sie Zahl b ein     : ");
            b = int.Parse(Console.ReadLine());

            // Console.WriteLine("{0}indexof({1}) {2} ", operators, o, operators.IndexOf(o));

            if (o == '/' && b == 0)
                Console.WriteLine("Division durch 0 funktioniert weniger gut");
            else if (operators.IndexOf(o) == -1)
                Console.WriteLine("Ungültiger Operator {0}", o);
            else
            {
                switch (o)
                {
                    case '+':
                        r = a + b;
                        break;

                    case '-':
                        r = a - b;
                        break;

                    case '.':
                    case 'X':
                    case 'x':
                    case '*':
                        r = a * b;
                        break;

                    case '/':
                        r = a / b;
                        rr = a % b;
                        break;

                    default:
                        r = 0;
                        break;
                }
                Console.Write("{0} {1} {2} = {3}", a, o, b, r);
                if (rr != 0)
                    Console.WriteLine(" rest {0}", rr);
                Console.WriteLine();
            }
        }
    }
}
