using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            case4();
            Console.ReadLine();
        }

        static bool isLeapYear(int Year)
        {
            int days = 365;
            if (Year % 4 == 0)
            {
                days = 366;
                if (Year %100==0 && Year % 400 != 0)
                {
                    days = 365;
                }
            }
            return days == 366;
        }

        static int GetMonthDays(int month, int year)
        {
            if (month == 1) return 31;
            if (month == 2) return isLeapYear(year) ? 29 : 28;
            if (month == 3) return 31;
            if (month == 4) return 30;
            if (month == 5) return 31;
            if (month == 6) return 30;
            if (month == 7) return 31;
            if (month == 8) return 31;
            if (month == 9) return 30;
            if (month == 10) return 31;
            if (month == 11) return 30;
            if (month == 12) return 31;
            return 0;
        }

        static void case4()
        {
            Console.Write("Number of the month (1-12): ");
            int numberOfTheMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());

            int numberOfDays = GetMonthDays(numberOfTheMonth, Year);
            Console.WriteLine(numberOfDays);
        }

        static void case3()
        {
            Console.Write("Number of the month (1-12): ");
            int numberOfTheMonth = Convert.ToInt32(Console.ReadLine());

            string answer = "";
            if (numberOfTheMonth == 1 || numberOfTheMonth==2 || numberOfTheMonth==12)
            {
                answer = "Winter";
            }
            else if (numberOfTheMonth == 3 || numberOfTheMonth==4 || numberOfTheMonth==5)
            {
                answer = "Spring";
            }
            else if (numberOfTheMonth == 5 || numberOfTheMonth==7 || numberOfTheMonth==8)
            {
                answer = "Summer";
            }
            else if (numberOfTheMonth == 9 || numberOfTheMonth== 10|| numberOfTheMonth==11)
            {
                answer = "Fall";
            }
            else
            {
                answer = "Wrong choice";
            }
            Console.WriteLine(answer);
        }

        static void case1A()
        {
            Console.Write("Number of the day of the week(1-7): ");
            int numberOfTheDayWeek = Convert.ToInt32(Console.ReadLine());

            string answer = "";
            if (numberOfTheDayWeek == 1)
            {
                answer = "Monday";
            }
            else if (numberOfTheDayWeek == 2)
            {
                answer = "Tuesday";
            }
            else if (numberOfTheDayWeek ==3)
            {
                answer = "Wednesday";
            }
            else if (numberOfTheDayWeek == 4)
            {
                answer = "Thursday";
            }
            else if (numberOfTheDayWeek == 5)
            {
                answer = "Friday";
            }
            else if (numberOfTheDayWeek == 6)
            {
                answer = "Saturday";
            }
            else if (numberOfTheDayWeek == 7)
            {
                answer = "Sunday";
            }
            else
            {
                answer = " Wrong choice";
            }
            Console.WriteLine(answer);
        }

        static void case1()
        {
            Console.Write("Number of the day of the week(1-7): ");
            int numberOfTheDayWeek = Convert.ToInt32(Console.ReadLine());

            string answer = "";
            switch (numberOfTheDayWeek)
            {
                case 1:
                    answer = "Monday";
                    break;
                case 2:
                    answer = "Tuesday";
                    break;
                case 3:
                    answer = "Wednesday";
                    break;
                case 4:
                    answer = " Thursday";
                    break;
                case 5:
                    answer = "Friday";
                    break;
                case 6:
                    answer = "Satruday";
                    break;
                case 7:
                    answer = "Sunday";
                    break;
                default:
                    answer = " Wrong day chosen";
                    break;
            }
            Console.WriteLine(answer);
        }

    }
}
