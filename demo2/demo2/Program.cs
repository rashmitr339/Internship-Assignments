//Assessment1 no of words in a string

using System;

namespace demo2
{
    internal class Program1
    {
        static void Main(string[] args)
        {

            String input = Console.ReadLine();

            int Count = CountWords(input);

            Console.WriteLine("Number of words in the input string are: " + Count); //print
            Console.ReadLine();
        }


        static int CountWords(String input)
        {
            //            // Split the input string into words based on spaces, tabs, carriage returns, and new line feeds
            string[] words = input.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); //option passed 
                                                                                                                       // split string into substring
                                                                                                                       //handle empty entries remove the empty entries fron the resulting array
                                                                                                                       //            // Return the number of words
            return words.Length;
        }
    }
}

//Assessment3 Average of 3 numbers

//using System;

//namespace Assessment2
//{
//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the first num");
//            int firstnum = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the second num");
//            int secondnum = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the third num");
//            int thirdnum = int.Parse(Console.ReadLine());

//            int sum = firstnum + secondnum + thirdnum;
//            int average = sum / 3;
//            Console.Write(average);

//            Console.ReadKey();

//        }
//    }
//}

//Assessment3 Simple Interest

//using System;

//namespace Assessment3
//{
//    class Program3
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the Principal amount");
//            double principleamt = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the time/period in years");
//            double time = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the rate");
//            double rate = double.Parse(Console.ReadLine());

//            double simpleinterest = (principleamt * time * rate) / 100;
//            Console.Write(simpleinterest);

//            Console.ReadKey();

//        }

//    }
//}


//Assessment4 largest of 3 numbers

//using System;

//namespace Assessment4
//{
//    class Program4
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the Firstnum");
//            double Firstnum = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the secondnum");
//            double Secondnum = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the thirdnum");
//            double Thirdnum = double.Parse(Console.ReadLine());

//            if (Firstnum > Secondnum && Firstnum > Thirdnum)
//            {
//                Console.WriteLine("the Largest number is" + Firstnum);
//            }
//            else if (Secondnum > Thirdnum)
//            {
//                Console.WriteLine("the Largest number is" + Secondnum);
//            }
//            else
//            {
//                Console.WriteLine(Thirdnum);
//            }
//            Console.ReadKey();
//        }

//    }
//}

//Assessment5 remove dublicate value

//using System;
//using System.Linq;

//namespace Assessment5
//{
//    class Program5
//    {
//        static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 2, 3, 4, 4, 5 };
//            int[] uniqueArray = array.Distinct().ToArray();
//            Console.WriteLine("Unique values:");
//            foreach (var item in uniqueArray)
//            {
//                Console.WriteLine(item);
//            }
//            Console.ReadKey();
//        }

//    }
//}


//Assessment6 time zone date

//using System;


//namespace Assessment6
//{
//    class Program6
//    {
//        static void Main(string[] args)
//        {

//            TimeZoneInfo localZone = TimeZoneInfo.Local;  //is a .NET class that represents information about a time zone
//            Console.WriteLine("Local Time Zone:" + localZone);
//            Console.ReadKey();

//        }
//    }
//}




