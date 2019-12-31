using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Int030();
            Console.ReadLine();
        }
        //345%10=5
        //345/10=34
        //34%10=4

        //123
        //231

        static void Int030()
        {
            Console.Write("Year=");
            int year = Convert.ToInt32(Console.ReadLine());

            int century = (year - 1) / 100 + 1;
            Console.WriteLine("Century=" + century);

        }


        static void Int029()
        {
            Console.Write("A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C=");
            int C = Convert.ToInt32(Console.ReadLine());

            int NA = A / C;
            int NB = B / C;

            int N = NA * NB;

            int sk = A * B;
            int sp = C * C;
            int sn = sk - sp * N;

            Console.WriteLine("N="+N);
            Console.WriteLine("sn="+sn);
        }

        static void Int024()
        {
            Console.Write("K=");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("S=");
            int s = Convert.ToInt32(Console.ReadLine());
            int dt = (k+s-1) % 7;
            Console.WriteLine("dt=" + dt);
        }


        static void Int023A()
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int hours = n / 3600;
            int rest = n % 3600;
            int minutes = rest / 60;
            int seconds = rest % 60;


            Console.WriteLine("hours=" + hours);
            Console.WriteLine("minutes=" + minutes);
            Console.WriteLine("seconds=" + seconds);
        }

        static void Int023()
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = n % 3600 /60;

            Console.WriteLine("s=" + s);
        }

        static void Int022()
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = n % 3600;

            Console.WriteLine("s=" + s);
        }

        static void Int021()
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = n % 60;

            Console.WriteLine("s=" + s);
        }

        static void Int020()
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int h = n / 3600;

            Console.WriteLine("h=" + h);
        }


        static void Int019()
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n / 60;

            Console.WriteLine("m="+m);
        }

        static void Int018()
        {
            Console.Write(" n(>999) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d3 = n / 1000 % 10;

            Console.WriteLine($"d3={d3}");
        }

        static void Int017()
        {
            Console.Write(" n(>999) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d2 = n / 100 % 10;

            Console.WriteLine($"d2={d2}");
        }


        static void Int016()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d0 = n / 1 % 10;
            int d1 = n / 10 % 10;
            int d2 = n / 100 % 10;

            int x = d2 * 100 + d0 * 10 + d1 * 1;

            Console.WriteLine($"x={x}");

        }


        static void Int015()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d0 = n / 1 % 10;
            int d1 = n / 10 % 10;
            int d2 = n / 100 % 10;

            int x =  d1 * 100 + d2 * 10 + d0 * 1;

            Console.WriteLine($"x={x}");

        }

        static void Int014()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d0 = n / 1 % 10;
            int d1 = n / 10 % 10;
            int d2 = n / 100 % 10;

            int x = d0 * 100 + d2 * 10 + d1 * 1;

            Console.WriteLine($"x={x}");

        }
        static void Int013()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d0 = n / 1 % 10;
            int d1 = n / 10 % 10;
            int d2 = n / 100 % 10;

            int x = d1 * 100 + d0 * 10 + d2 * 1;

            Console.WriteLine($"x={x}");

        }
        static void Int012()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d0 = n / 1 % 10;
            int d1 = n / 10 % 10;
            int d2 = n / 100 % 10;

            int x = d0 * 100 + d1 * 10 + d2 * 1;

            Console.WriteLine($"x={x}");
           
        }


        static void Int011()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d0 = n / 1 % 10;
            int d1 = n / 10 % 10;
            int d2 = n / 100 % 10;

            int sum = d0 + d1 + d2;
            int product = d0 * d1 * d2;

            Console.WriteLine($"sum={sum}");
            Console.WriteLine($"product={product}");
        }


        static void Int010()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d0 = n  % 10;
            int d1 = n / 10 % 10;

            Console.WriteLine($"d0={d0}");
            Console.WriteLine($"d1={d1}");
        }

        static void Int09()
        {
            Console.Write(" n(3 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d2 = n / 100;

            Console.WriteLine($"d2={d2}");
        }

        static void Int08()
        {
            Console.Write(" n(2 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d1 = n / 10;
            int d0 = n % 10;

            int x = d0 * 10 + d1;

            Console.WriteLine($"x={x}");
        }


        static void Int07()
        {
            Console.Write(" n(2 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d1 = n / 10;
            int d0 = n % 10;
            int sum = d0 + d1;
            int product = d0 * d1;

            Console.WriteLine($"sum={sum}");
            Console.WriteLine($"product={product}");
        }


        static void int21()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int seconds = n % 60;
            Console.WriteLine("seconds =" + seconds);
        }
        static void int20()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int hours = n / 60/60;
            Console.WriteLine("hours =" + hours);
        }
        static void int19()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int minutes = n / 60;
            Console.WriteLine("minutes=" + minutes);
        }


        static void int19_23()
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int h = n / 3600;
            int rest = n % 3600;
            int m = rest / 60;
            int s = rest % 60;

            Console.WriteLine(" h = " + h);
            Console.WriteLine(" m = " + m);
            Console.WriteLine(" s = " + s);
        }


        static void Int06()
        {
            Console.Write(" n(2 digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d1 = n / 10;
            int d0 = n % 10;

            Console.WriteLine($"d1={d1}");
            Console.WriteLine($"d0={d0}");
        }

            //349941
            static void Int06test()
        {
            Console.Write(" n(five digits) = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int d0 = n / 1 % 10;
            int d1 = n / 10 % 10;
            int d2 = n / 100 % 10;
            int d3 = n / 1000 % 10;
            int d4 = n / 10000 % 10;

            Console.WriteLine(" d0 = " + d0);
            Console.WriteLine(" d1 = " + d1);
            Console.WriteLine(" d2 = " + d2);
            Console.WriteLine(" d3 = " + d3);
            Console.WriteLine(" d4 = " + d4);

            int k = d0 * 10000 + d1 * 1000 + d2 * 100 + d3 * 10 + d4 * 1;
            Console.WriteLine(" k = " + d0 + d1 + d2 + d3 + d4);

            k = k + 1; //k++; k+=1;
            Console.WriteLine(" k = " + k);

            Console.WriteLine("result = " + (1 / 3) );
            Console.WriteLine("result = " + ( d2 / d3) );
        }

        static void Int04_5()
        {
            Console.Write(" A = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            int n = a / b;
            int rest = a % b;

            Console.WriteLine(" n = " + n);
            Console.WriteLine(" rest = " + rest);
        }

        static void Int01()
        {
            Console.Write(" L = ");
            int l = Convert.ToInt32(Console.ReadLine());

            int m = l / 100;
            int rest = l % 100;

            Console.WriteLine(" m = " + m);
            Console.WriteLine(" rest = " + rest);
        }
    }
}
