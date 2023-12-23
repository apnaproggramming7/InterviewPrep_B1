namespace InterviewPrep_B1
{
    // TestClass is class name
    public class TestClass
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
                
        }
    }
}

/*
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




Object
=======
1. What is object in C#?

-> Object is instance of class
-> If we want to access memebers (data members/methods etc.) of a class, 
we can create object of that class 

2. How to create object of a class?
ClassName objName= new ClassName();

or

ClassName objName;
objName = new ClassName();

 */