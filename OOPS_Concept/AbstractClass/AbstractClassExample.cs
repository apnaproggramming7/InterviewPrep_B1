
namespace OOPS_Concept.AbstractClass
{
    public abstract class AbstractClassExample
    {
        int a = 10;

        //Abstract method
        // We will not have body definition
        public abstract void GetArea();// method declaration

        // Cone -> Area , Triange -> Area

        // Non abstract method (Normal method)
        // We will have body definition

        public void TestMethod()
        {

        }
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }


        //public abstract void GetArea();

    }

    public class ClassName : AbstractClassExample
    {

        // Implementing abstract method
        public override void GetArea()
        {
            //code
            //throw new NotImplementedException();
        }
    }


    public abstract class AreaClass
    {
        public abstract void GetArea();
    }

    public class ConeClass : AreaClass
    {
        public override void GetArea()
        {
            Console.WriteLine("Cone Area");
        }
    }

    public class TriangleClass : AreaClass
    {
        public override void GetArea()
        {
            Console.WriteLine("Triangle Area");
        }
    }

    //public class Class1
    //{
    //    public Class1()
    //    {
    //        Console.WriteLine("Base constructor");
    //    }
    //}
    //public class Class2 : Class1
    //{
    //    public Class2()
    //    {
    //        Console.WriteLine("Derived constructor");
    //    }
    //}
    //public class MainClass
    //{
    //    public static void Main()
    //    {
    //        Class2 obj1 = new Class2();
    //    }
    //}

}

/*
 
  What is mean by abstraction?

- To hiding the details ( We will be hinding the details from one class/file to another class/file)
- Abstract class same as class
- We can create abstract method and non abstract method too.
- W cannot create instance of abstract class

- We can apply abstraction based on 2 concepts
    - using Abstract class
    - using Interface
 */
