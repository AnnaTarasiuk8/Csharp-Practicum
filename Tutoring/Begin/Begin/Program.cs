using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            begin40();
            Console.ReadKey();
        }

        static void begin40()
        {
            Console.Write("A1=");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("B1=");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("C1=");
            double c1 = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("A2=");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("B2=");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("C2=");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double d = a1 * b2 - a2*b1;
            double x = (c1 * b2 - c2 * b1) / d;

            double y = (a1 * c1 - a2 * c1) / d;
            

            Console.WriteLine("d=" + d);
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
        }


        static void begin39()
        {
            Console.Write("A=");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B=");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("C=");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("d="+d);
            Console.WriteLine("x1="+x1);
            Console.WriteLine("x2="+x2);
        }


        static void begin38()
        {
            Console.Write("A=");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B=");
            double b = Convert.ToDouble(Console.ReadLine());
            
            double x = -b / a;

            Console.WriteLine("x="+x);
        }

        static void begin37()
        {
            Console.Write("V1=");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("V2=");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("S0=");
            double S0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("T=");
            double t = Convert.ToDouble(Console.ReadLine());


            double s1 = v1 * t;
            double s2 = v2 * t;
            double distance = Math.Abs(S0 - s1 - s2);
            

            Console.WriteLine("s1=" + s1);
            Console.WriteLine("s2=" + s2);
            Console.WriteLine("distance=" + distance);

        }



        static void begin36()
        {
            Console.Write("V1=");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("V2=");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("S0=");
            double S0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("T=");
            double t = Convert.ToDouble(Console.ReadLine());


            double s1 = v1 * t;
            double s2 = v2 * t;
            double distance = S0 + s1 + s2;


            Console.WriteLine("s1=" + s1);
            Console.WriteLine("s2=" + s2);
            Console.WriteLine("distance=" + distance);

        }


            static void begin35()
        {
            Console.Write("V=");
            double v = Convert.ToDouble(Console.ReadLine());

            Console.Write("T1=");
            double t1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("U=");
            double u = Convert.ToDouble(Console.ReadLine());

            Console.Write("T2=");
            double t2 = Convert.ToDouble(Console.ReadLine());

            double sLake = v * t1;
            double sRiver = (v-u) * t2;

            double totalWay = sLake + sRiver;

            Console.WriteLine("Total Way=" + totalWay);

        }


        static void begin34()
        {
            Console.Write("Candies Cost($)=");
            double candiesCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Candies Weight(kg)=");
            double candiesWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iriski Cost($)=");
            double iriskiCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iriski Weight(kg)=");
            double iriskiWeight = Convert.ToDouble(Console.ReadLine());

            double priceCandies = candiesCost/candiesWeight;
            double priceIriski= iriskiCost/iriskiWeight;
            double ratio = priceCandies/ priceIriski;

            Console.WriteLine("priceCandies=" + priceCandies);
            Console.WriteLine("priceIriski=" + priceIriski);
            Console.WriteLine("ratio=" + ratio);

        }


            static void begin33()
        {
            Console.Write("Candies(lb)=");
            double candiesLb = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cost($)=");
            double cost = Convert.ToDouble(Console.ReadLine());

            double price = cost/candiesLb;

            Console.WriteLine("Price=" + price);

            Console.Write("Additional candies(lb)=");
            double aditionalCandiesLb = Convert.ToDouble(Console.ReadLine());

            double costAdditional = price * aditionalCandiesLb;

            Console.WriteLine( "CostAdditional="+costAdditional);
        }


            static void begin32()
        {
            Console.Write("Celsius=");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double farenhait = celsius * 9 / 5 + 32;

            Console.WriteLine("farenhait=" + farenhait);

        }


        static void begin31()
        {
            Console.Write("Farenhait=");
            double farenhait = Convert.ToDouble(Console.ReadLine());

            double celsius = (farenhait - 32) * 5 / 9;
            Console.WriteLine("celsius=" + celsius);
        }

        static void begin30()
        {
            Console.Write("Radians=");
            double radians = Convert.ToDouble(Console.ReadLine());
            double degrees =  radians * 180 / Math.PI;

            Console.WriteLine("degrees=" + degrees);
        }




        static void begin29()
        {
            Console.Write("degrees=");
            double degrees = Convert.ToDouble(Console.ReadLine());
            double radians = degrees * Math.PI / 180;

            Console.WriteLine("radians=" + radians);
        }

        static void begin28()
        {
            Console.Write("a:");
            double a = Convert.ToDouble(Console.ReadLine());

            double b = a * a;// квадрат
            double c = b * a;// куб
            double d = b * c;//5та степінь -квадрат на куб
            double e = d * c;// 15та степінь -5та на квадрат
            double f = b * d;// 10та степінь - квадрат на 5ту




            Console.WriteLine("A2=" + b);
            Console.WriteLine("A3=" + c);
            Console.WriteLine("A5=" + d);
            Console.WriteLine("A15=" + e);
            Console.WriteLine("A10=" + f);


        }

        static void begin27()
        {
            Console.Write("a:");
            double a = Convert.ToDouble(Console.ReadLine());

            double temp = a * a;
            temp = temp * temp;
            temp = temp * temp;

            Console.WriteLine("Result=" + temp);
        }


        static void begin26()
        {
            Console.Write("x:");
            double x = Convert.ToDouble(Console.ReadLine());

            double y;
            y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;

            Console.WriteLine("y="+ y);
        }

        static void begin25()
        {
            Console.Write("x:");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = 3 * (Math.Pow(x, 6)) - 6 * (Math.Pow(x, 2)) - 7;

            Console.WriteLine("y=" + y);

        }
        static void begin24()
        {
            Console.Write("a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double temp = c;
            c = a;
            b = c;
            a = b;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
        }

            static void begin23()
        {
            Console.Write("a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double temp = b;
            b = a;
            a = c;
            c = temp;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);

        }
        static void begin22()
        {
            Console.Write("a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b:");
            double b = Convert.ToDouble(Console.ReadLine());

            double temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }

        static void begin21()
        {
            Console.Write("Enter point1 x:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point1 y:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point2 x:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point2 y:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point3 x:");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point3 y:");
            double y3 = Convert.ToDouble(Console.ReadLine());


            double a= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b= Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c= Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
            Console.WriteLine("s=" + s);

        }
        static void begin20()
        {
            Console.Write("Enter point1 x:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point1 y:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point2 x:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point2 y:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2-y1,2));

            Console.WriteLine("Distance=" + distance);

        }
        static void begin19()
        {
            Console.Write("Enter point x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Abs(y1 - y2);
            double b = Math.Abs(x1 - x2);
            double Perimeter = 2 * (a + b);
            double area = a * b;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("Perimeter=" + Perimeter);
            Console.WriteLine("Area=" + area);

        }
        static void begin18()
        {
            Console.Write("Enter point A:");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point B:");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point C:");
            double C = Convert.ToDouble(Console.ReadLine());

            double AC = Math.Abs(A * C);
            double BC = Math.Abs(B * C);
            double Product = AC * BC;

            Console.WriteLine("AC=" + AC);
            Console.WriteLine("BC=" + BC);
            Console.WriteLine("Product=" + Product);


        }
        static void begin17()
        {
            Console.Write("Enter point A:");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point B:");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter point C:");
            double C = Convert.ToDouble(Console.ReadLine());

            double AC = Math.Abs(A - C);
            double BC = Math.Abs(B - C);
            double Sum = AC + BC;

            Console.WriteLine("AC=" + AC);
            Console.WriteLine("BC=" + BC);
            Console.WriteLine("Sum=" + Sum);
        }
        private static double Distance(double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow(x2 - x1, 2);
            var temp2 = Math.Pow(y2 - y1, 2);
            var result = Math.Sqrt(temp1 + temp2);

            return result;
        }

        static void begin16()
        {
            Console.Write("x1=");
            double x1;
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2=");
            double x2;
            x2 = Convert.ToDouble(Console.ReadLine());

            double Diferance = Math.Abs(x2 - x1);

            Console.WriteLine("diferance=" + Diferance);

            // no idea how to fix thsi problem
        }



        static void begin15()
        {
            Console.Write(" Assign a number to S=");
            double S;
            S = Convert.ToDouble(Console.ReadLine());

            double Radius = Math.Sqrt(S / Math.PI);
            double D = Radius * 2;
            double L = 2 * Math.PI * Radius;

            Console.WriteLine("D=" + D);
            Console.WriteLine("L=" + L);

        }

        static void begin14()
        {
            Console.Write("L=");
            double L;
            L = Convert.ToDouble(Console.ReadLine());

            double r = L / (Math.PI * 2);
            double s = Math.PI * r * r;

            Console.WriteLine("r=" + r);
            Console.WriteLine("s=" + s);
        }


        static void begin13()
        {
            Console.WriteLine("r1>r2");
            Console.Write("r1=");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r2=");
            double r2 = Convert.ToDouble(Console.ReadLine());

            Double S1 = Math.PI * (r1 * r1);
            Double S2 = Math.PI * (r2 * r2);
            Double S3 = S1 - S2;

            Console.WriteLine("S1=" + S1);
            Console.WriteLine("S2=" + S2);
            Console.WriteLine("S3=" + S3);
        }

        static void begin12()
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            double p = a + b + c;


            Console.WriteLine("c=" + c);
            Console.WriteLine("p=" + p);
        }


        static void begin11()
        {
            int a, b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            double a2 = Math.Abs(a);
            double b2 = Math.Abs(b);

            double sum = a2 + b2;
            double diferance = a2 - b2;
            double product = a2 * b2;
            double part = a2 / b2;

            Console.WriteLine($"Sum={sum}, Diferance={diferance}");
            Console.WriteLine("Product=" + product);
            Console.WriteLine("Part={0}", part);
        }

        static void begin10()
        {
            double a, b;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());

            Console.Write("b(Not 0)=");
            b = double.Parse(Console.ReadLine());

            double a2 = a * a;
            double b2 = b * b;

            double sum = a2 + b2;
            double diferance = a2 - b2;
            double product = a2 * b2;
            double part = a2 / b2;


            Console.WriteLine($"Sum={sum}, Diferance={diferance}");
            Console.WriteLine("Product=" + product);
            Console.WriteLine("Part={0}", part);

        }


        static void begin9()
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            double geo = Math.Sqrt(a * b);

            Console.WriteLine("geo=" + geo);
        }
        static void begin8()
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            double average = (a + b) / 2;

            Console.WriteLine("average=" + average);
        }

        static void begin7()
        {
            Console.Write("r=");
            double r = Convert.ToDouble(Console.ReadLine());

            double l = 2 * Math.PI * r;
            double s = Math.PI * r * r;

            Console.WriteLine("l=" + l);
            Console.WriteLine("s=" + s);
        }


        static void begin6()
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double V = a * b * c;
            double s = 2 * (a * b + b * c + a * c);

            Console.WriteLine("v=" + V);
            Console.WriteLine("s=" + s);
            Console.WriteLine("s=");
            Console.WriteLine(s);
        }


        static void begin5()
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            double V = Math.Pow(a, 3);
            // Як підносити число до степеня?

            double s = 6 * a * a;
            Console.WriteLine("v=" + V);
            Console.WriteLine("s=" + s);
        }

        static void begin2()
        {
            double a, b;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            double p = 2 * (a + b);
            double s = a * b;

            Console.WriteLine("Perimetr=" + p);
            Console.WriteLine("Area=" + s);
            Console.WriteLine("Area={0}", s);
            Console.WriteLine($"Area={s}");
        }

        static void begin1()
        {
            double side;
            Console.Write("side = ");
            side = Convert.ToDouble(Console.ReadLine());

            double p = 4 * side;

            Console.WriteLine("Perimetr=" + p);
        }


        static void begin4()
        {
            double PI = 3.1415926, D;

            Console.Write("D = ");
            D = Convert.ToDouble(Console.ReadLine());
            double L = PI * D;

            Console.WriteLine("Length=" + L);
        }


    }
}
