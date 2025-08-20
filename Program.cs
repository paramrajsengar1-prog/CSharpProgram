
//Experiment 1
//A software company is developing a user profile management system. Design a class UserProfile with private fields like username, password, and email.
//Provide public methods to set and get the values securely.
//Add validation in setters (e.g., email must contain @, password must be at least 6 characters).
//Test your class with at least two objects.
//using System;

//class UserProfile
//{
//    // Private fields
//    private string username;
//    private string password;
//    private string email;

//    // Constructor
//    public UserProfile(string username, string password, string email)
//    {
//        SetUsername(username);
//        SetPassword(password);
//        SetEmail(email);
//    }

//    // Getter for username
//    public string GetUsername()
//    {
//        return username;
//    }

//    // Setter for username
//    public void SetUsername(string username)
//    {
//        if (!string.IsNullOrWhiteSpace(username))
//        {
//            this.username = username;
//        }
//        else
//        {
//            Console.WriteLine("Invalid username. It cannot be empty.");
//        }
//    }

//    // Getter for password (masked for security)
//    public string GetPassword()
//    {
//        return ""; // Masked output
//    }

//    // Setter for password
//    public void SetPassword(string password)
//    {
//        if (!string.IsNullOrEmpty(password) && password.Length >= 6)
//        {
//            this.password = password;
//        }
//        else
//        {
//            Console.WriteLine("Invalid password. Must be at least 6 characters.");
//        }
//    }

//    // Getter for email
//    public string GetEmail()
//    {
//        return email;
//    }

//    // Setter for email
//    public void SetEmail(string email)
//    {
//        if (!string.IsNullOrEmpty(email) && email.Contains("@"))
//        {
//            this.email = email;
//        }
//        else
//        {
//            Console.WriteLine("Invalid email. Must contain '@'.");
//        }
//    }

//    // Display profile info
//    public void DisplayProfile()
//    {
//        Console.WriteLine("Username: " + username);
//        Console.WriteLine("Email: " + email);
//        Console.WriteLine("Password: " + GetPassword());
//        Console.WriteLine("----------------------");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // First valid user
//        UserProfile user1 = new UserProfile("Sandeep", "secure123", "sandeep@example.com");
//        user1.DisplayProfile();

//        // Second user with some invalid inputs
//        UserProfile user2 = new UserProfile("Ravi", "123", "raviexample.com");
//        user2.DisplayProfile();

//        // Fix invalid details
//        user2.SetPassword("strongPass");
//        user2.SetEmail("ravi@example.com");
//        user2.DisplayProfile();

//        Console.ReadLine();
//    }
//}



//Experiment 2
//You are creating an app for a transport company that deals with different types of vehicles.
//Create a base class Vehicle with properties like Make, Model, and Year.
//Create derived classes Truck and Bus, each having a method DisplayDetails().


//using System;
//class Vehicle
//{
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }

//    public Vehicle(string make, string model, int year)
//    {
//        Make = make;
//        Model = model;
//        Year = year;
//    }
//}

//class Truck : Vehicle
//{
//    public double LoadCapacity { get; set; } // in tons

//    public Truck(string make, string model, int year, double loadCapacity)
//        : base(make, model, year)
//    {
//        LoadCapacity = loadCapacity;
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Truck Details:");
//        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Load Capacity: {LoadCapacity} tons");
//        Console.WriteLine("----------------------------------");
//    }
//}

//class Bus : Vehicle
//{
//    public int SeatingCapacity { get; set; }

//    public Bus(string make, string model, int year, int seatingCapacity)
//        : base(make, model, year)
//    {
//        SeatingCapacity = seatingCapacity;
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Bus Details:");
//        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Seating Capacity: {SeatingCapacity} seats");
//        Console.WriteLine("----------------------------------");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//        Truck truck1 = new Truck("Volvo", "FH16", 2022, 25);
//        truck1.DisplayDetails();


//        Bus bus1 = new Bus("Mercedes", "Tourismo", 2023, 50);
//        bus1.DisplayDetails();

//        Console.ReadLine();
//    }
//}

//Experiment 3
//Build a calculator class that can perform basic operations using method overloading.
//Implement multiple Add() methods that take different numbers and types of parameters (int, float, double).
//Write a program to test all the variations of the Add() method.

//using System;

//class Calculator
//{
//    // Add method for two integers
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    // Add method for three integers
//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    // Add method for two floats
//    public float Add(float a, float b)
//    {
//        return a + b;
//    }

//    // Add method for two doubles
//    public double Add(double a, double b)
//    {
//        return a + b;
//    }

//    // Add method for int and double
//    public double Add(int a, double b)
//    {
//        return a + b;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calc = new Calculator();

//        Console.WriteLine("Addition of 2 integers: " + calc.Add(10, 20));
//        Console.WriteLine("Addition of 3 integers: " + calc.Add(5, 15, 25));
//        Console.WriteLine("Addition of 2 floats: " + calc.Add(1.5f, 2.5f));
//        Console.WriteLine("Addition of 2 doubles: " + calc.Add(10.55, 20.45));
//        Console.WriteLine("Addition of int and double: " + calc.Add(5, 12.75));
//    }
//}



//Experiment 4
//Create an abstract class Employee with abstract method CalculateSalary().
//Derive classes FullTimeEmployee and PartTimeEmployee and implement the salary calculation.
//Instantiate objects and calculate salary for both types.


//using System;

//// Abstract Class
//abstract class Employee
//{
//    public string Name { get; set; }
//    public int EmployeeID { get; set; }

//    // Abstract Method
//    public abstract double CalculateSalary();
//}

//// Full-time Employee Class
//class FullTimeEmployee : Employee
//{
//    public double MonthlySalary { get; set; }

//    public override double CalculateSalary()
//    {
//        return MonthlySalary;
//    }
//}

//// Part-time Employee Class
//class PartTimeEmployee : Employee
//{
//    public double HourlyRate { get; set; }
//    public int HoursWorked { get; set; }

//    public override double CalculateSalary()
//    {
//        return HourlyRate * HoursWorked;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Full-time Employee
//        FullTimeEmployee fullTime = new FullTimeEmployee()
//        {
//            Name = "Sandeep",
//            EmployeeID = 101,
//            MonthlySalary = 50000
//        };

//        // Part-time Employee
//        PartTimeEmployee partTime = new PartTimeEmployee()
//        {
//            Name = "Ayush",
//            EmployeeID = 102,
//            HourlyRate = 500,
//            HoursWorked = 40
//        };

//        Console.WriteLine("Full-Time Employee Salary:");
//        Console.WriteLine($"Name: {fullTime.Name}, ID: {fullTime.EmployeeID}, Salary: {fullTime.CalculateSalary()}");

//        Console.WriteLine("\nPart-Time Employee Salary:");
//        Console.WriteLine($"Name: {partTime.Name}, ID: {partTime.EmployeeID}, Salary: {partTime.CalculateSalary()}");
//    }
//}




//Experiment 5
//You are building a student record system.
//Create a class Student with overloaded constructors:
//oDefault constructor
//oConstructor with name and roll number
//oConstructor with name, roll number, and marks
//Display all student data using a method.


//using System;

//class Student
//{
//    public string Name { get; set; }
//    public int RollNumber { get; set; }
//    public double Marks { get; set; }

//    // Default Constructor
//    public Student()
//    {
//        Name = "Not Assigned";
//        RollNumber = 0;
//        Marks = 0.0;
//    }

//    // Constructor with name and roll number
//    public Student(string name, int rollNumber)
//    {
//        Name = name;
//        RollNumber = rollNumber;
//        Marks = 0.0;
//    }

//    // Constructor with name, roll number, and marks
//    public Student(string name, int rollNumber, double marks)
//    {
//        Name = name;
//        RollNumber = rollNumber;
//        Marks = marks;
//    }

//    // Method to display student data
//    public void DisplayData()
//    {
//        Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Marks: {Marks}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Using Default Constructor
//        Student s1 = new Student();

//        // Using Constructor with Name and Roll Number
//        Student s2 = new Student("Sandeep", 101);

//        // Using Constructor with Name, Roll Number, and Marks
//        Student s3 = new Student("Ayush", 102, 88.5);

//        Console.WriteLine("Student Records:");
//        s1.DisplayData();
//        s2.DisplayData();
//        s3.DisplayData();
//    }
//}


//Experiment 6
//Develop a class Product for an inventory system.
//Include auto - implemented properties: ProductID, ProductName, Price, and Quantity.
//Use property validation logic(e.g., Price cannot be negative).
//Write a method to print product details and test it with valid and invalid inputs.


//using System;

//class Product
//{
//    // Auto-implemented properties with validation in setters
//    private double price;
//    private int quantity;

//    public int ProductID { get; set; }
//    public string ProductName { get; set; }

//    public double Price
//    {
//        get { return price; }
//        set
//        {
//            if (value < 0)
//                Console.WriteLine("❌ Price cannot be negative. Setting to 0.");
//            price = value < 0 ? 0 : value;
//        }
//    }

//    public int Quantity
//    {
//        get { return quantity; }
//        set
//        {
//            if (value < 0)
//                Console.WriteLine("❌ Quantity cannot be negative. Setting to 0.");
//            quantity = value < 0 ? 0 : value;
//        }
//    }

//    // Method to print product details
//    public void PrintDetails()
//    {
//        Console.WriteLine($"ProductID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Product p1 = new Product()
//        {
//            ProductID = 101,
//            ProductName = "Laptop",
//            Price = 55000,
//            Quantity = 10
//        };

//        Product p2 = new Product()
//        {
//            ProductID = 102,
//            ProductName = "Smartphone",
//            Price = -15000, // Invalid
//            Quantity = -5   // Invalid
//        };

//        Console.WriteLine("Product Records:");
//        p1.PrintDetails();
//        p2.PrintDetails();
//    }
//}


//Experiment 7
//Design a basic Library Management System using OOP concepts.
//Classes: Book, Member, Library
//Implement:
//oBook lending feature
//oMember registration
//oTrack available books
//Use concepts like inheritance, encapsulation, and method overriding wherever suitable.


using System;
using System.Collections.Generic;

// Base class: Book
class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public bool IsAvailable { get; set; } = true;

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"BookID: {BookID}, Title: {Title}, Available: {IsAvailable}");
    }
}

// Derived class: ReferenceBook (Example of inheritance & method overriding)
class ReferenceBook : Book
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"[Reference] BookID: {BookID}, Title: {Title}, Available: {IsAvailable}");
    }
}

// Member class
class Member
{
    public int MemberID { get; set; }
    public string Name { get; set; }
}

// Library class
class Library
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();

    public void RegisterMember(Member member)
    {
        members.Add(member);
        Console.WriteLine($"✅ Member Registered: {member.Name} (ID: {member.MemberID})");
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"📚 Book Added: {book.Title}");
    }

    public void LendBook(int bookID, int memberID)
    {
        Book book = books.Find(b => b.BookID == bookID);
        Member member = members.Find(m => m.MemberID == memberID);

        if (book == null)
        {
            Console.WriteLine("❌ Book not found!");
            return;
        }
        if (member == null)
        {
            Console.WriteLine("❌ Member not found!");
            return;
        }
        if (!book.IsAvailable)
        {
            Console.WriteLine($"❌ Book '{book.Title}' is already lent out.");
            return;
        }

        book.IsAvailable = false;
        Console.WriteLine($"✅ Book '{book.Title}' lent to {member.Name}");
    }

    public void DisplayAvailableBooks()
    {
        Console.WriteLine("\n📖 Available Books:");
        foreach (var book in books)
        {
            if (book.IsAvailable)
                book.DisplayInfo();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Register Members
        library.RegisterMember(new Member { MemberID = 1, Name = "Sandeep" });
        library.RegisterMember(new Member { MemberID = 2, Name = "Ayush" });

        // Add Books
        library.AddBook(new Book { BookID = 101, Title = "C# Basics" });
        library.AddBook(new ReferenceBook { BookID = 102, Title = "Encyclopedia" });

        // Display Available Books
        library.DisplayAvailableBooks();

        // Lend Books
        library.LendBook(101, 1);
        library.LendBook(101, 2); // Trying to lend an already lent book

        // Display Available Books After Lending
        library.DisplayAvailableBooks();
    }
}