//using System;

//public class assessment1
//{
//    public void Text()
//    {
//        Console.WriteLine("Good Morning");
//    }
//}
//public class Program1
//{

//    public static void Main(string[] args)
//    {
//        assessment1 a1 = new assessment1();
//        a1.Text();
//    }


//}

//using System;
//using System.IO;

//public class Program2
//{
//    static void Main(string[] args)
//    {
//string path = @"C:\Directory";
//Directory.CreateDirectory(path);

//if (Directory.Exists(path))
//{
//    Console.WriteLine("Directory created sucessfully");
//}
//else
//{
//    Console.WriteLine("Directory not created");
//}

//string filepath = @"C:\Directory\myfile1.txt";
//File.Create(filepath);

//if(File.Exists(filepath))
//{
//    Console.WriteLine("Created");
//}
//else
//{
//    Console.WriteLine("Not Created");
//}

//string[] Lines = new string[]
//{
//    "Hello World, How are you..",
//    "How you all doing..",
//    "Have a Great Day!"
//};

//File.WriteAllLines(filepath, Lines);

//foreach (string line in Lines)
//{
//    Console.WriteLine(line);
//}

//    string[] s = File.ReadAllLines(filepath);
//    foreach (var text in s)
//    {
//        Console.WriteLine(text);
//    }

//string filepath = @"C:\Directory\myfile1.txt";
//File.Copy(@"C:\Directory\myfile1.txt", @"C:\Directory2\myfile2.txt");

//string path = @"C:\Directory";
//string[] Files = Directory.GetFiles(path);
//foreach (string File in Files)
//{
//    Console.WriteLine(File);

//}

//string filepath = @"C:\Directory\myfile1.txt";
//FileInfo f1= new FileInfo(filepath);
//Console.WriteLine(f1.FullName);
//Console.WriteLine(f1.Name);
//Console.WriteLine(f1.Length.ToString());
//Console.WriteLine(f1.Extension);
//Console.WriteLine(f1.DirectoryName);

//string path = @"C:\Directory\myfile2.txt";
//File.Create(path);

//if(File.Exists(path) )
//{
//    Console.WriteLine("created");
//}
//else
//{
//    Console.WriteLine("not created");
//}

//string path = @"C:\Directory\myfile2.txt";
//Console.WriteLine("Enter the text");
//string text = Console.ReadLine();
//File.AppendAllText(path, text + "\n");
//File.WriteAllText(path, text);




//Console.ReadKey();



//}

//}
//---------------------------------------------------------------------------------------------


//2 - Exception handling

//using System;
////using System.Data;

//class Program1
//{
//    public static void Main(string[] args)

//    {
//        try                                         //test the block of code
//        {
//            Console.WriteLine("Enter the Temperature:");
//            int temp = int.Parse(Console.ReadLine());
//            if (temp == 0)
//            {
//                throw new Exception("Temperature Cannot be Zero");
//            }
//            Console.WriteLine("The temperature entered is" + " " + temp);
//            Console.ReadKey();

//        }
//        catch (Exception ex) //class
//        {
//            //string msg = "Temperature Cannot be Zero";
//            Console.WriteLine("Error:" + ex);
//            //string msg = "Temperature Cannot be Zero";
//            //Console.WriteLine(msg);
//            Console.ReadKey();
//        }
//    }

//}

// 5 - create a file

//using System;
////using System.IO; // name space input output

//public class Program2
//{
//    public static void Main(string[] args)
//    {
//string filepath = @"C:\Directory5";
//Directory.CreateDirectory(filepath);

//if (Directory.Exists(filepath))
//{
//    Console.WriteLine("New Directory Created");
//}
//else
//{
//    Console.WriteLine("Directory not Created");
//}

//        string filepath = @"C:\Directory5\Programfile.txt";
//        File.Create(filepath);

//        if (File.Exists(filepath))
//        {
//            Console.WriteLine("New File Created");
//        }

//        else
//        {
//            Console.WriteLine("File not Created");
//        }
//        Console.ReadKey();
//    }
//}

// 3 - open, write, read a file

using System;
using System.IO;

public class Program3
{
    public static void Main(string[] args)
    {
        string filepath = @"C:\Directory5\Programfile.txt";

        string[] Lines = new string[]
        {
"Hello Word, Good Morning",
"How you all doing",
"Have a Great Day......!!!!!"
        };

        File.WriteAllLines(filepath, Lines);

        foreach (var line in Lines)
        {
            Console.WriteLine(line);
        }



        foreach (string line in File.ReadAllLines(filepath))
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("Enter a Text");
        string text = Console.ReadLine();
        File.AppendAllText(filepath, text + "\n");

        Console.ReadKey();

    }
}

//4 - Generic list

//using System;

//public class Program4
//{
//    public static void Main(string[] args)
//    {
//        List<string> list = new List<string>(); //using engeric where we'll be specify the data type
//        list.Add("Rashmi");
//        list.Add("Hema");
//        list.Add("Pruthvi");
//        list.Add("Harshitha");


//        Console.WriteLine("--------------Using For Loop:-----------------");
//        for (int i = 0; i < list.Count; i++)
//        {
//            Console.WriteLine(list[i]);
//        }

//        Console.WriteLine("---------------Using Foreach Loop:---------------");
//        foreach (var l in list)
//        {
//            Console.WriteLine(l);
//        }

//        Console.WriteLine("----------------Using Index:-----------------------");
//        Console.WriteLine(list[0]);
//        Console.WriteLine(list[1]);
//        Console.WriteLine(list[2]);
//        Console.WriteLine(list[3]);
//        Console.ReadKey();


//    }

//}

//1 - to display a employee data Indexer

//using System;

//class Employee
//{
//    private string[] details = new string[6]; //array of string of size 6

//    public string this[int index] // keyword used whenever we're defining the indexer
//    {
//        get
//        {
//            return details[index];  //When an instance of the Employee class is indexed using [] notation, this getter retrieves the value at the specified index from the details array.
//        }
//        set
//        {
//            details[index] = value; //When a value is assigned to an indexed instance of the Employee class, this setter assigns the value to the specified index in the details array.
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee emp = new Employee();
//        // Taking input from the user
//        Console.WriteLine("Enter employee details:");
//        Console.Write("Employee ID: ");
//        emp[0] = Console.ReadLine();   //assigning the index to the instace of class using indexer

//        Console.Write("Name: ");
//        emp[1] = Console.ReadLine();

//        Console.Write("Job: ");
//        emp[2] = Console.ReadLine();

//        Console.Write("Salary: ");
//        emp[3] = Console.ReadLine();

//        Console.Write("Location: ");
//        emp[4] = Console.ReadLine();

//        Console.Write("Gender: ");
//        emp[5] = Console.ReadLine();

//        // Displaying initial values
//        Console.WriteLine($"EID={emp[0]},Name={emp[1]},Job={emp[2]},Salary={emp[3]},Location={emp[4]},Gender={emp[5]}");

//        // Modifying the values
//        Console.WriteLine("Enter modified employee details:");
//        Console.Write("Name: ");
//        emp[1] = Console.ReadLine();

//        Console.Write("Salary: ");
//        emp[3] = Console.ReadLine();

//        Console.Write("Location: ");
//        emp[4] = Console.ReadLine();

//        // Displaying modified values
//        Console.WriteLine("*After Modification");
//        Console.WriteLine($"EID={emp[0]},Name={emp[1]},Job={emp[2]},Salary={emp[3]},Location={emp[4]},Gender={emp[5]}");
//        Console.ReadLine();
//    }
//}

// 6 copy a file

//using System;
////using System.IO;

//public class Program6
//{

//    public static void Main(string[] args)
//    {
//        //string path = @"C:\Directory5\Programfile.txt"; //source
//        //File.Copy(path, @"C:\Directory2\CopieddProgramfile.txt"); //current file path & destination

//        string path = @"C:\Directory2\CopieddProgramfile.txt";
//        Console.WriteLine(File.ReadAllText(path));
//        Console.ReadKey();

//    }

//}

// 7 - sorting of array in aces order

//using System;

//public class Program7

//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the size of the arrays:");
//        int size = int.Parse(Console.ReadLine());

//        int[] array1 = new int[size];
//        int[] array2 = new int[size];

//        Console.WriteLine("Enter the elements of the first array (sorted in ascending order):");
//        for (int i = 0; i < size; i++)
//        {
//            array1[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Enter the elements of the second array (sorted in ascending order):");
//        for (int i = 0; i < size; i++)
//        {
//            array2[i] = int.Parse(Console.ReadLine());
//        }

//        int[] mergedArray = MergeArrays(array1, array2); // calling a method

//        Console.WriteLine("Merged Array:");
//        foreach (int num in mergedArray)
//        {
//            Console.Write(num + " ");
//        }
//        Console.ReadKey();
//    }

//    static int[] MergeArrays(int[] arr1, int[] arr2)  // defining a method
//    {
//        int[] mergedArray = new int[arr1.Length + arr2.Length];
//        int i = 0, j = 0, k = 0; //1

//        while (i < arr1.Length && j < arr2.Length) //2,7 3,8
//        {
//            if (arr1[i] < arr2[j]) //2 7
//            {
//                mergedArray[k++] = arr1[i++]; // 1 = 5, 
//            }
//            else
//            {
//                mergedArray[k++] = arr2[j++];
//            }
//        }

//        while (i < arr1.Length)
//        {
//            mergedArray[k++] = arr1[i++];
//        }

//        while (j < arr2.Length)
//        {
//            mergedArray[k++] = arr2[j++];
//        }

//        return mergedArray;


//    }

//}

//7 - sorting of array in aces order

//using System;


//class Program
//{
//    static void Main(string[] args)
//    {
//        //int[] array1 = { 1, 8, 3 };
//        //int[] array2 = { 4, 5, 6 };
//        Console.WriteLine("Enter the size of the arrays:");
//        int size = int.Parse(Console.ReadLine());

//        int[] array1 = new int[size];
//        int[] array2 = new int[size];

//        Console.WriteLine("Enter the elements of the first array (sorted in ascending order):");
//        for (int i = 0; i < size; i++)
//        {
//            array1[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Enter the elements of the second array (sorted in ascending order):");
//        for (int i = 0; i < size; i++)
//        {
//            array2[i] = int.Parse(Console.ReadLine());
//        }

//        int[] mergedArray = array1.Concat(array2).ToArray();
//        Array.Sort(mergedArray);

//        Console.WriteLine("Merged Array:");
//        foreach (var num in mergedArray)
//        {
//            Console.Write(num + " ");

//        }
//        Console.ReadKey();
//    }
//}

// 8 - to count the frequncy of an array elements

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Define an example array
//        int[] array = { 1, 2, 3, 4, 1, 2, 3, 4, 5, 2, 3, 1 };

//        // Call the CountFrequency method to count the frequency of each element
//        CountFrequency(array);

//        // Wait for the user to press a key before closing the console window
//        Console.ReadKey();
//    }

//    // Method to count the frequency of each element in the array and print it
//    static void CountFrequency(int[] array)
//    {
//        // Create a dictionary to store element-frequency pairs
//        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

//        // Iterate through each element in the array
//        foreach (int num in array)
//        {
//            // Check if the element already exists in the dictionary
//            if (frequencyMap.ContainsKey(num))
//            {
//                // If it exists, increment its frequency by 1
//                frequencyMap[num]++;  //later 1 = 3 or 4
//            }
//            else
//            {
//                // If it doesn't exist, add it to the dictionary with a frequency of 1
//                frequencyMap[num] = 1;  //initially 1 = 1
//            }
//        }

//        // Print the frequency of each element
//        Console.WriteLine("Element\tFrequency");
//        foreach (var pair in frequencyMap)   // which takes both key and value
//        {
//            Console.WriteLine(pair.Key + "\t" + pair.Value);
//        }
//    }
//}

// 9 - To seperate even and odd numbers into seperate array

//using System;

//class Program9
//{
//    static void Main(string[] args)
//    {
//        // Example array containing integers
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        // Separate odd and even integers into separate arrays
//        int[] evenNumbers = new int[numbers.Length];
//        int[] oddNumbers = new int[numbers.Length];
//        int evenIndex = 0, oddIndex = 0;

//        foreach (int num in numbers)
//        {
//            if (num % 2 == 0)
//            {
//                evenNumbers[evenIndex++] = num; //the number will get added to even array based on index
//            }                                   // first go to 0 place and increment automatically other number get addedd to1, 2  so on
//            else
//            {
//                oddNumbers[oddIndex++] = num;
//            }
//        }

//        // Trim the arrays to remove extra zeros
//        Array.Resize(ref evenNumbers, evenIndex); // takes a parameter array and new index of array
//        Array.Resize(ref oddNumbers, oddIndex);

//        // Print the even numbers
//        Console.WriteLine("Even Numbers:");
//        foreach (int evenNum in evenNumbers)
//        {
//            Console.Write(evenNum + " ");

//        }

//        // Print the odd numbers
//        Console.WriteLine("\nOdd Numbers:");
//        foreach (int oddNum in oddNumbers)
//        {
//            Console.Write(oddNum + " ");

//        }
//        Console.ReadKey();
//    }
//}

// 10 - line lies x axix or y axis

//using System;

//class Program10
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the X coordinate:");
//        int x = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the Y coordinate:");
//        int y = int.Parse(Console.ReadLine());

//        string quadrant = DetermineQuadrant(x, y);

//        Console.WriteLine($"The point ({x}, {y}) lies in {quadrant} quadrant.");
//        Console.ReadKey();
//    }

//    static string DetermineQuadrant(int x, int y)
//    {
//        if (x > 0 && y > 0)
//        {
//            return "the first";
//        }
//        else if (x < 0 && y > 0)
//        {
//            return "the second";
//        }
//        else if (x < 0 && y < 0)
//        {
//            return "the third";
//        }
//        else if (x > 0 && y < 0)
//        {
//            return "the fourth";
//        }
//        else if (x == 0 && y == 0)
//        {
//            return "the origin";
//        }
//        else if (x == 0)
//        {
//            return "the Y-axis";
//        }
//        else // y == 0
//        {
//            return "the X-axis";
//        }

//    }


//}

// 11 - Electricity bill

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Input customer details
//        Console.WriteLine("Enter customer name:");
//        string name = Console.ReadLine();

//        Console.WriteLine("Enter customer ID:");
//        string id = Console.ReadLine();

//        Console.WriteLine("Enter the due Amount:");
//        int dueAmount = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter units consumed:");
//        int unitsConsumed = int.Parse(Console.ReadLine());

//        // Calculate electricity bill
//        double billAmount = CalculateBill(unitsConsumed);

//        // Display bill details
//        Console.WriteLine("\nElectricity Bill");
//        Console.WriteLine("Customer Name: " + name);
//        Console.WriteLine("Customer ID: " + id);
//        Console.WriteLine("Units Consumed: " + unitsConsumed);
//        Console.WriteLine("Total Amount Due: Rs. " + (billAmount + dueAmount));
//        Console.ReadKey();
//    }

//    static double CalculateBill(int unitsConsumed)
//    {
//        const double UnitRate = 6.50; // Rate per unit in rupees

//        double totalAmount = unitsConsumed * UnitRate;

//        return totalAmount;
//    }
//}

//using System;

//class ElectricityBillCalculator
//{
//    static void Main(string[] args)
//    {
//        // Prompt user to enter customer details
//        Console.WriteLine("Enter customer name: ");
//        string name = Console.ReadLine();

//        Console.WriteLine("Enter customer ID: ");
//        string id = Console.ReadLine();

//        Console.WriteLine("Enter units consumed: ");
//        int unitsConsumed = int.Parse(Console.ReadLine());

//        // Calculate total bill amount
//        double totalAmount = CalculateBill(unitsConsumed); // billamount will be assigned

//        // Display customer details and bill amount
//        Console.WriteLine("\nCustomer Details:");
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("ID: " + id);
//        Console.WriteLine("Units Consumed: " + unitsConsumed);
//        Console.WriteLine("Total Amount Due: $" + totalAmount);
//        Console.ReadKey();
//    }

//    // Function to calculate bill amount based on units consumed
//    static double CalculateBill(int unitsConsumed)
//    {
//        double billAmount = 0;

//        if (unitsConsumed <= 100)
//        {
//            billAmount = unitsConsumed * 0.50;
//        }
//        else if (unitsConsumed > 100 && unitsConsumed <= 300)
//        {
//            billAmount = 100 * 0.50 + (unitsConsumed - 100) * 0.75;
//        }
//        else if (unitsConsumed > 300 && unitsConsumed <= 500)
//        {
//            billAmount = 100 * 0.50 + 200 * 0.75 + (unitsConsumed - 300) * 1.20;
//        }
//        else
//        {
//            billAmount = 100 * 0.50 + 200 * 0.75 + 200 * 1.20 + (unitsConsumed - 500) * 1.50;
//        }

//        return billAmount;
//    }
//}

// 12 - remove special characters from given text

//using System;
//using System.Text.RegularExpressions;

//class SpecialCharacterRemover
//{
//    static void Main(string[] args)
//    {
//        // Input text containing special characters
//        Console.WriteLine("Enter text with special characters:");
//        string inputText = Console.ReadLine();

//        // Remove special characters
//        string updatedText = RemoveSpecialCharacters(inputText); //assigns updatedText

//        // Display the updated text
//        Console.WriteLine("\nText with special characters removed:");
//        Console.WriteLine(updatedText);
//        Console.ReadKey();
//    }

//    static string RemoveSpecialCharacters(string input)
//    {
//        // Regular expression pattern to match special characters
//        string pattern = @"[^a-zA-Z0-9\s_-]"; //^ not matching this pattern will be replaced with ""

//        // Remove special characters using regex
//        string updatedText = Regex.Replace(input, pattern, "");
//        //method takes the string input, string pattern, stringreplacement
//        return updatedText;
//    }
//}
