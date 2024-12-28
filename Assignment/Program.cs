
using System;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this Enum.

            //Console.WriteLine("Week days is ");

            //for (int i = 1; i <= 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}

            #endregion

            #region Q2 - Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays thecorresponding month range for that season. Note range for seasons(spring march to may, summer june to august, autumn Septemberto November, winter December to February)

            Season season;

            bool isParsed;
            do
            {

                Console.Write("Enter Season : ");

                isParsed = Enum.TryParse(Console.ReadLine(), out season);


            } while (!isParsed);

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring is from March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer is from June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn is from Septemper to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter is from December to February");
                    break;
                default:
                    Console.WriteLine("ERROR 404");
                    break;
            }

            #endregion

        }
    }
}
