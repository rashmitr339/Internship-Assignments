//using System;
//using System.Linq;

//public class Student
//{

//    public string name;
//    public int age;
//    public int id;

//    public Student(string name, int age, int id)
//    {
//        this.name = name;
//        this.age = age;
//        this.id = id;
//    }

//}

//public class Class
//{
//    public string classname;
//    public int classid;

//    public Class(string classname, int classid)
//    {
//        this.classname = classname;
//        this.classid = classid;
//    }
//}

//class Program1
//{
//    static void Main(string[] args)
//    {
//        List<Student> list = new List<Student>();
//        list.Add(new Student("Rashmi", 23, 1));
//        list.Add(new Student("Pruthvi", 24, 2));
//        list.Add(new Student("Harshitha", 17, 3));

//        List<Class> list2 = new List<Class>();
//        list2.Add(new Class("PCMB", 1));
//        list2.Add(new Class("PCMC", 2));
//        list2.Add(new Class("PCME", 3));

//        var StudentsOver18 = from student in list where student.age > 18 select student;
//        foreach (var s in StudentsOver18)
//        {
//            Console.WriteLine("Students Over Age 18:");
//            Console.WriteLine(s.name);
//        }
//        var ClassContainingStudentsOver18 = from c in list2 join student in StudentsOver18 on c.classid equals student.id select c;
//        foreach (var i in ClassContainingStudentsOver18)
//        {
//            Console.WriteLine("Class containing Students Over Age 18:");
//            Console.WriteLine(i.classname);
//        }

//    }



//}

//using System;

//public class Employeedetails
//{
//    public string name;
//    public int id;
//    public int salary;

//    public Employeedetails(string name, int id, int salary)
//    {
//        this.name = name;
//        this.id = id;
//        this.salary = salary;
//    }

//}

//class Program2
//{
//    static void Main(string[] args)
//    {
//        List<Employeedetails> list = new List<Employeedetails>();
//        list.Add(new Employeedetails("Jin", 1, 2000));
//        list.Add(new Employeedetails("Suga", 2, 800));
//        list.Add(new Employeedetails("Rm", 3, 4500));
//        list.Add(new Employeedetails("Jhope", 4, 9000));
//        list.Add(new Employeedetails("Jimin", 5, 550));
//        list.Add(new Employeedetails("V", 6, 5000));
//        list.Add(new Employeedetails("Jk", 7, 6500));

//        var EmpSalary = from Emp in list where Emp.salary >= 800 && Emp.salary <= 6000 select Emp;
//        foreach (var emp in EmpSalary) //loops through the data stored in that variable
//        {
//            Console.WriteLine("Employees having salary between 800 and 6000:");
//            Console.WriteLine(emp.name + " " + ":" + " " + emp.salary);
//        }


//    }
//}

//using System;

//class Person
//{
//    public string Name { get; set; }

//}

//class Program3
//{
//    static void Main(string[] args)
//    {

//        Console.WriteLine("Enter the Size of the Users:");
//        int Size = int.Parse(Console.ReadLine());

//        List<Person> list = new List<Person>();
//        for (int i = 0; i < Size; i++)


//        {
//            Console.WriteLine("Enter the users Name:");
//            string name = Console.ReadLine();

//            Person p = new Person { Name = name };
//            list.Add(p);

//        }

//        var SortedNames = from N in list where N.Name.Length < 4 select N; //select new {Name = N.Name}
//        Console.WriteLine("Person names of length<4:");
//        foreach (var nam in SortedNames)
//        {

//            Console.WriteLine(nam.Name);
//        }



//    }
//}

//using System;

//class Program4
//{
//    static void Main(string[] args)
//    {

//        Console.WriteLine("Enter the specific salary: ");
//        int specificSalary = int.Parse(Console.ReadLine());

//        // Create a list to store the numbers
//        List<int> salaries = new List<int>();

//        // Get the numbers from the user
//        Console.WriteLine("Enter the salaries (enter 'stop' to finish): ");
//        string input;

//        while ((input = Console.ReadLine()) != "stop")
//        {
//            salaries.Add(int.Parse(input));
//        }


//        var greaterNumbers = from number in salaries
//                             where number > specificSalary
//                             select number;


//        Console.WriteLine("Numbers greater than " + specificSalary + ":");
//        foreach (var n in greaterNumbers)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}

//using System;
//using System.Numerics;
//using System.Threading.Tasks;

//class Program5
//{
//    static async Task Main(string[] args)  // contains async operation
//    {
//        //Task representing this operation to the variable factorialTask. 
//        //This allows us to await the completion of the task later in the program.
//        // Task.Run is method used to execute the asynchronous operation

//        Console.WriteLine("Calculating factorial of 20 asynchronously...");
//        Task<BigInteger> factorialTask = Task.Run(() => CalculateFactorialAsync(20)); // declaring variable
//        BigInteger factorial = await factorialTask;
//        Console.WriteLine($"Factorial of 20: {factorial}");


//        //This lambda expression is a shorthand way to define an anonymous method.

//        Console.WriteLine("\nCalculating 25th term of Fibonacci sequence asynchronously...");
//        Task<int> fibonacciTask = Task.Run(() => CalculateFibonacciAsync(20));
//        int fibonacciTerm = await fibonacciTask;
//        Console.WriteLine($"20th term of Fibonacci sequence: {fibonacciTerm}");
//    }

//    static async Task<BigInteger> CalculateFactorialAsync(int n) //recursive calls all the methods first

//    {
//        if (n == 0)
//            return BigInteger.One;
//        else
//            return n * await Task.Run(() => CalculateFactorialAsync(n - 1));
//    }

//    static async Task<int> CalculateFibonacciAsync(int n) //addition of previous 2 numbers
//    {
//        if (n <= 1)
//            return n;
//        else
//            return await Task.Run(() => CalculateFibonacciAsync(n - 1)) + await Task.Run(() => CalculateFibonacciAsync(n - 2));
//    }
//}

//class PersonBankAccount
//{
//    private static string bankName;
//    private const int minimumBalance = 1000;
//    private const double intrestRate = 0.07;
//    private const int intrestPeriodicity = 4;

//    private double balance;

//    static PersonBankAccount()
//    {
//        Console.WriteLine("Enter the name of the bank :");
//        bankName = Console.ReadLine();
//    }
//    public static void RenameBankAccount(string newName)// no need to create a instance
//    {
//        bankName = newName;
//        Console.WriteLine($"Bank renamed successfully {bankName}");
//    }
//    public void Withdraw(int amount)
//    {
//        if (balance - amount < minimumBalance)
//        {
//            Console.WriteLine("Insufficient balance. Withdraw failed");
//            return;
//        }
//        balance -= amount;
//        Console.WriteLine($"Withdraw of {amount} successful. Current Balance is :{balance}");
//    }
//    public void Deposit(int amount)
//    {
//        balance += amount;

//        Console.WriteLine($"Deposite of {amount} successful. Current Balance is : {balance + minimumBalance}");
//    }
//    public void AddInterest()
//    {
//        double intrest = balance * intrestRate * (intrestPeriodicity / 12.0);
//        balance += intrest;
//        Console.WriteLine($"Intrest is added : {intrest}. New Balance is :{balance}");
//    }
//    public double GetBalance()
//    {
//        return balance;
//    }

//}
//class MainClass
//{
//    static void Main(string[] args)
//    {
//        PersonBankAccount account = new PersonBankAccount();

//        while (true)
//        {
//            Console.WriteLine("\nChoose an option:");
//            Console.WriteLine("1. Withdraw");
//            Console.WriteLine("2. Deposit");
//            Console.WriteLine("3. Add Interest");
//            Console.WriteLine("4. Check Balance");
//            Console.WriteLine("5. Rename Bank");
//            Console.WriteLine("6. Exit");

//            Console.Write("Enter your choice: ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter withdrawal amount: ");
//                    int withdrawAmount = Convert.ToInt32(Console.ReadLine());
//                    account.Withdraw(withdrawAmount);
//                    break;

//                case "2":
//                    Console.Write("Enter deposit amount: ");
//                    int depositAmount = Convert.ToInt32(Console.ReadLine());
//                    account.Deposit(depositAmount);
//                    break;

//                case "3":
//                    account.AddInterest();
//                    break;

//                case "4":
//                    Console.WriteLine($"Current Balance: {account.GetBalance()}");
//                    break;

//                case "5":
//                    Console.Write("Enter new bank name: ");
//                    string newBankName = Console.ReadLine();
//                    PersonBankAccount.RenameBankAccount(newBankName);
//                    break;

//                case "6":
//                    Console.WriteLine("Exiting program...");
//                    return;

//                default:
//                    Console.WriteLine("Invalid choice. Please try again.");
//                    break;
//            }
//        }
//    }
//}

//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;

//class Product
//{
//    public int ProductId;
//    public string ProductName;
//    public int Price;
//    public int Quantity;

//    public Product(int productId, string productName, int price, int quantity)
//    {
//        ProductId = productId;
//        ProductName = productName;
//        Price = price;
//        Quantity = quantity;

//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create a list of products
//        List<Product> products = new List<Product>();


//        products.Add(new Product(1, "Laptop", 999, 10));
//        products.Add(new Product(2, "SmartPhone", 599, 20));
//        products.Add(new Product(3, "Tablet", 299, 15));
//        products.Add(new Product(4, "HeadPhone", 100, 30));
//        products.Add(new Product(1, "Mouse", 50, 50));


//        // Serialize the list of products to JSON string
//        string jsonString = JsonConvert.SerializeObject(products);

//        // Print the JSON string
//        Console.WriteLine("JSON string:");

//        Console.WriteLine(jsonString);

//        // Deserialize the JSON string back to list of products
//        List<Product> deserializedProducts = JsonConvert.DeserializeObject<List<Product>>(jsonString);

//        // Print the deserialized products
//        Console.WriteLine("\nDeserialized Products:");
//        foreach (var product in deserializedProducts)
//        {
//            Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}, Quantity: {product.Quantity}");
//        }
//    }
//}

