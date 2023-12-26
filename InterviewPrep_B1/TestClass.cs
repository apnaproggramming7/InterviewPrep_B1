namespace InterviewPrep_B1
{
    // TestClass is class name
    public class TestClass : ConstructExample
    {
        // Data members
        public int a = 10;
        public string name, address;
        public int MyProperty { get; set; }

        //Methods
        public void GetDetails()
        {
            Console.WriteLine("Test Message From GetDetails Method");
        }

        public void GetData()
        {
            Console.WriteLine("Test Message from GetData Method");
        }

        //constructor
        public TestClass()
        {
            name = "Naushad";
            Console.WriteLine(name);
            Console.WriteLine("Constructor is called");
        }


    }
}

/*
What is constructor?

-> Special type of method
-> constructor with same name whatever the class name
-> To initialized the value
-> When we will create object of that class constructor will be called
-> We dont have any return type
-> If we are not creating any default constructor by default interanlly default constructor will be created


What are the type of constructor?
-> There 5 type of constructor

-> We have some type of constructor (default, paramterized, static)
   only 3 is coming in my mind right now.

What is diff b/w Default constructor & Params constructor?

What is static constructor?

What is diff b/w Default constructor & static constructor?

What is private constructor?

What is base constructor?

Can we overload the constructor?




 What is class? 

-> User Define Data Type
-> we can create class with uppercase and lower
-> It is collection of members
        - function member/ methods
        - data members
            - field (int a,b;)
        - Properties
        - Constructor



-> We can create class using class keyword

-> It should not be the predefine datatype or class (when you are going to create)


2. What is default access of a class?
-> internal

3. Default scope of members in a class?
-> Private

What are the other way restrict a class to be inheritaed
        // Sealed




Object
=======
1. What is object in C#?

-> Object is instance of class
-> If we want to access memebers (data members/methods etc.) of a class, 
we can create object of that class(except, protected private)

2. How to create object of a class?
ClassName objName= new ClassName();

or

ClassName objName;
objName = new ClassName();

 */