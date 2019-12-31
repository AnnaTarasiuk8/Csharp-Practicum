using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExersises
{
    class Program
    {
        static void Main(string[] args)
        {
            if30A();
            Console.ReadLine();
        }

        static void if30A()
        {
            Console.Write(" x = ");
            int x = Convert.ToInt32(Console.ReadLine());

            string answer = "One";
            if (10 <= x && x < 100)
            {
                answer = "Two";
            }
            if (100 <= x && x < 1000)
            {
                answer = "Three";
            }
            answer += "-digit ";

            if (x % 2 == 0)
            {
                answer += "even ";
            }
            else
            {
                answer += "odd";
            }

            answer += "number.";
            Console.WriteLine(answer);
        }


        static void if30()
        {
            Console.Write(" x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 || x <= 999)
            {
                if (x % 2 == 0) 
                {
                    if (x < 100)
                    {
                        Console.WriteLine("two digit even number");
                    }
                    else
                        Console.WriteLine("Its a three digit even number");
                }
                else
                {
                    if (x < 100)
                    {
                        Console.WriteLine("two digit even number");
                    }
                    else
                        Console.WriteLine("Its a three digit even number");
                }
            }

            else 
                Console.WriteLine("Number is not between 1 and 999");

            
        }



        static void if29()
        {
            Console.Write(" x = ");
            int x = Convert.ToInt32(Console.ReadLine());

            string description = "zero ";
            if (x > 0)
            {
                description = "positive ";
            }
            if (x < 0)
            {
                description = "negative ";
            }

            if (x % 2 == 0)
            {
                description += "even ";
            }
            else
            {
                description += "odd ";
            }

            description += "number.";

            Console.WriteLine(description);
        }

        static void if28()
        {
            Console.Write(" year = ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (isLeapYear(year))
            {
                Console.WriteLine("Year is Leap");
            }
            else
            {
                Console.WriteLine("year is not leap");
            }
        }

        static bool isLeapYear ( int year)
        {
            int days = 365;
            if (year % 4 == 0)
            {
                days = 366;
                if ( year %100==0 && year % 400 != 0)
                {
                    days = 365;
                }
            }
            return days == 366;
        }

        static void if27()
        {
            Console.Write(" x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double F = 0;

            if (x >= 0)
            {
                int y = (int)x;
                if (y%2==0){
                    F = 1;
                }
                if (y % 2 != 0)
                {
                    F = -1;
                }
            }
            
            Console.WriteLine("F = " + F);

        }
        static void if26()
        {
            Console.Write(" x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double F = 0;

            if (x <= 0 )
            {
                F = -x;
            }
            else if ( x>=2)
            {
                F = 4;
            }
            else
            {
                F = x * x;
            }
            Console.WriteLine("F = " + F);

        }

        static void if25()
        {
            Console.Write(" x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double F = 0;

            if (x < -2 || x>2)
            {
                F = 2*x;
            }
            else 
            {
                F = -3 * x;
            }
            Console.WriteLine("F = " + F);

        }

        static void if24()
        {
            Console.Write(" x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double F = 0;
            if (x > 0)
            {
                F = 2 * Math.Sin(x);
            }
            if (x <= 0)
            {
                F = 6 - x;
            }
            Console.WriteLine("F = " + F);

        }
        static void if22()
        {
            Console.Write(" x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write(" y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            int quarter = 0;
             
            if ( x>0 && y > 0)
            {
                quarter = 1;
            }

            if (x < 0 && y > 0)
            {
                quarter = 2;
            }

            if ( x<0 && y < 0)
            {
                quarter = 3;
            }
            if (x > 0 && y < 0)
            {
                quarter = 4;

            }

            Console.WriteLine("quarter = " + quarter);
        }

        static void if21()
        {
            Console.Write(" x = ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            if (x == 0 && y == 0)
            {
                result = 0;
            }

            if (x==0 && y != 0)
            {
                result = 2;
            }
              
            if (x!=0 && y == 0)
            {
                result = 1;

            }
            if (x!=0 && y != 0)
            {
                result = 3;
            }

            Console.WriteLine("result = " + result );
         }


        static void if20()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());

            double AB = Math.Abs(A - B);
            double AC = Math.Abs(A - C);

           if (AB < AC)
            {
                Console.WriteLine( " B is closer to A than C");
            }
           else
            {
                Console.WriteLine(" C is closer to A than B");
            }
            
        }

        static void if19()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());
            
            Console.Write(" D = ");
            int D = Convert.ToInt32(Console.ReadLine());

            int unique = A;
            if (A == B&& A==D)
            {
                unique = C;
            }
            if (A == C && A==B)
            {
                unique = D;
            }

            if ( A== C && A == D)
            {
                unique = B;
            }
            Console.WriteLine("unique = " + unique);

        }
        static void if18()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            
            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());

            int unique = A;
            if ( A==B)
            {
                unique = C;
            }
            if (A== C)
            {
                unique = B;
            }

            Console.WriteLine("unique = " + unique);
            
        }

        static void if17()
        {
            Console.Write(" A = ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write(" B = ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write(" C = ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A < B && B < C || A>B && B>C)
            {
                A = A + A;
                B = B + B;
                C = C + C;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;

            }
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
        }

        static void if16()
        {
            Console.Write(" A = ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write(" B = ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write(" C = ");
            double C = Convert.ToDouble(Console.ReadLine());

            if ( A<B && B < C)
            {
                A = A + A;
                B = B + B;
                C = C + C;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;

            }
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
        }
        static void if13()
        {
            Console.Write(" A = ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write(" B = ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write(" C = ");
            double C = Convert.ToDouble(Console.ReadLine());

            double between = A;
            if  (A<B && B<C || A>B && B > C)
            {
                between = B;
            }
            if ( A<C && C<B || A>C && C > B)
            {
                between = C;
            }

            Console.WriteLine("between = " + between);
        }


        static void if13A()
        {
            Console.Write(" A = ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write(" B = ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write(" C = ");
            double C = Convert.ToDouble(Console.ReadLine());

            double min = A;

            if (B < min)
            {
                min = B;
            }

            if (C < min)
            {
                min = C;
            }

            double max = A;

            if (B > max)
            {
                max = B;
            }

            if (C > max)
            {
                max = C;
            }

            double between = A + B + C - min - max;

            Console.WriteLine("max = " + max);
            Console.WriteLine("between = " + between);
            Console.WriteLine("min = " + min);
        }

        static void if12()
        {
            Console.Write(" A = ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write(" B = ");
            double B = Convert.ToDouble(Console.ReadLine());
            
            Console.Write(" C = ");
            double C = Convert.ToDouble(Console.ReadLine());

            double min = A;

            if (B < min)
            {
                min = B;
            }

            if (C < min)
            {
                min = C;
            }

            Console.WriteLine("min = " + min);
        }

        static void if11()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                A = 0;
                B = 0;
            }
            else
            {
                int max = A;
                if (B > A)
                {
                    max = B;
                }
                A = max;
                B = max;

            }

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

        }

        static void if10()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                A = 0;
                B = 0;
            }
            else 
            {
               int  sum = A + B;
                A = sum;
                B = sum;

            }

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

        }


        static void if9()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                int t = A;
                A = B;
                B = t;

            }

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

        }


        static void if8()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            int min = A;
            if (B < A)
            {
                min = B;
            }

            int max = A;
            if (B > A)
            {
                max = B;
            }

            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);

        }

        static void if7()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            int min = A;
            if (B < A)
            {
                min = B;
            }

            Console.WriteLine("min = " + min);

        }

        static void if6()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            int max = A;
            if (B>A)
            {
                max = B;
            }

            Console.WriteLine("max = " + max);

        }

        static void if5()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            if (A > 0)
            {
                counter = counter + 1;
            }

            if (B > 0)
            {
                counter = counter + 1;
            }

            if (C > 0)
            {
                counter = counter + 1;
            }

            int counter1 = 0;

            if (A < 0)
            {
                counter1 = counter1 + 1;
            }

            if (B < 0)
            {
                counter1 = counter1 + 1;

            }

            if (C < 0)
            {
                counter1 = counter1 + 1;

            }

            Console.WriteLine("counter = " + counter);
            Console.WriteLine("counter1 = " + counter1);
            
        }


        static void if4()
        {
            Console.Write(" A = ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write(" C = ");
            int C = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            if (A > 0)
            {
                counter = counter + 1;
            }  
            
            if (B > 0)
            {
                counter = counter + 1;
            }  
            
            if (C > 0)
            {
                counter = counter + 1;
            }
            
            

            Console.WriteLine("counter = " + counter);
        }

        static void if3()
        {
            Console.Write(" Plug in your number: ");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A > 0)
            {
                A = A + 1;
            }
            else if (A < 0)
            {
                A = A - 2;
            }
            else
            {
                A = 10;
            }

            Console.WriteLine("A = " + A);
        }


        static void if2()
        {
            Console.Write(" Plug in your number: ");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A > 0)
            {
                A = A + 1;
            }
            else
            {
                A = A - 2;
            }

            Console.WriteLine("A = " + A);
        }

        static void if1()
        {
            Console.Write(" Plug in your number: ");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A > 0)
            {
                A = A + 1;
            }

            Console.WriteLine("A = " + A);
        }

    }


}
