using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

public class Program
{
    public static void Main()
    {
        string num_of_strings, actual_string;
        int intNumStrings;

        Console.WriteLine("How many strings do you have?");

        num_of_strings = Console.ReadLine();
        intNumStrings = Convert.ToInt32(num_of_strings);

        for (int i = 1; i <= intNumStrings; i++)
        {
            Console.Write("Enter a string: ");
            actual_string = Console.ReadLine();
            Console.WriteLine(actual_string.ToLower());
            Console.ReadLine();
           
        }
    }
}
