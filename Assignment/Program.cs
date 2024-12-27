
using System.ComponentModel;
using Common;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this Enum.

            Console.WriteLine("Week days is ");

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine((WeekDays)i);
            }

            #endregion

        }
    }
}
