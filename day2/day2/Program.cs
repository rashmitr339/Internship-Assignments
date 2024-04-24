// See https://aka.ms/new-console-template for more information

// Assessment3 to display the info of teacher and student using inheritance

//using Microsoft.VisualBasic;
//using System;

//public class Info
//{
//    public string name;
//    public int age;
//    public string address;

//    public void TInformation()
//    {
//        Console.WriteLine("Teacher Info:" + " " + name + " " + age + " " + address);
//    }

//    public void SInformation()
//    {
//        Console.WriteLine("Student Info:" + " " + name + " " + age + " " + address);
//    }

//}

//public class Teacher : Info
//{

//}

//public class Student : Info
//{

//}

//public class Program
//{
//    public static void Main()
//    {
//        Teacher teacher = new Teacher();
//        teacher.name = Console.ReadLine();
//        teacher.age = int.Parse(Console.ReadLine());
//        teacher.address = Console.ReadLine();
//        teacher.TInformation();


//        Student student = new Student();
//        student.name = Console.ReadLine();
//        student.age = int.Parse(Console.ReadLine());
//        student.address = Console.ReadLine();
//        student.SInformation();
//    }

//}


// Payment system using polimorphism //method overriding

//using System;

//public class Payment
//{
//    public virtual void Paymentmode()
//    {
//        Console.WriteLine("Payment mode");
//    }
//}

//public class DigitalWallet : Payment
//{
//    public override void Paymentmode()
//    {
//        Console.WriteLine("- Digital Payment -");
//    }
//}
//public class BankTransfer : Payment
//{
//    public override void Paymentmode()
//    {
//        Console.WriteLine("- Bank Transfer -");
//    }
//}
//public class CreditCards : Payment
//{
//    public override void Paymentmode()
//    {
//        Console.WriteLine("- Credit Cards -");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        DigitalWallet d = new DigitalWallet();
//        d.Paymentmode();

//        BankTransfer b = new BankTransfer();
//        b.Paymentmode();

//        CreditCards c = new CreditCards();
//        c.Paymentmode();
//    }
//}


//  employee details using encapsulation

using System;

public class Employee
{
    private string name;
    private string designation;
    private int salary;
    private string gender;

    public void setName(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return this.name;
    }
    public void setDesignation(string designation)
    {
        this.designation = designation;
    }
    public string getDesignation()
    {
        return this.designation;
    }
    public void setSalary(int salary)
    {
        this.salary = salary;
    }
    public int getSalary()
    {
        return this.salary;
    }
    public void setGender(string gender)
    {
        this.gender = gender;
    }
    public string getGender()
    {
        return this.gender;
    }
}

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee();
        Console.WriteLine("Employee Detail:");
        employee.setName("Rashmi");
        Console.WriteLine(employee.getName());
        employee.setDesignation("Software Developer Intern");
        Console.WriteLine(employee.getDesignation());
        employee.setSalary(30000);
        Console.WriteLine(employee.getSalary());
        employee.setGender("Female");
        Console.WriteLine(employee.getGender());
    }
}

// To find the area of circle, triangle, square

//abstract class shape    //incomplete method which has no implementation public
//{
//    public abstract void Area();  // no need to give method body/implementation, virtual void {}
//}
//class Circle : shape
//{
//    public double radius;
//    public Circle(double r)
//    {
//        this.radius = r;
//    }
//    public override void Area()       // runtime polimorphism binding of method declaration and method implementation during runtime
//    {
//        Console.WriteLine("Area of Circle is " + 3.14 * radius * radius);  //taking method from parentclass and 
//    }                                                                      //and changing the implementation
//}
//class Triangle : shape
//{
//    public double length;
//    public double breadth;
//    public Triangle(double l, double b)
//    {
//        this.length = l;
//        this.breadth = b;
//    }
//    public override void Area()
//    {
//        Console.WriteLine("Area of Triangle is " + 0.5 * length * breadth);
//    }
//}
//class Square : shape
//{
//    public double length;
//    public Square(double l)
//    {
//        this.length = l;
//    }
//    public override void Area()
//    {
//        Console.WriteLine("Area of Triangle is " + length * length);
//    }
//}
//class Driver
//{
//    static void Main(string[] args)
//    {
//        Circle c = new Circle(5);
//        c.Area();
//        Triangle t = new Triangle(5, 10);
//        t.Area();
//        Square s = new Square(3.5);
//        s.Area();

//    }
//}