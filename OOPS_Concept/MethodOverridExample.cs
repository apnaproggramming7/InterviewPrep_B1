namespace OOPS_Concept
{
    public class MethodOverridExample
    {
        public virtual void GetDetails()
        {
            Console.WriteLine("Details");
        }

        public void GetDetails(int a)
        {
            Console.WriteLine("Details");
        }
    }

    public class GetData : MethodOverridExample
    {
        public override void GetDetails()
        {
            Console.WriteLine("jhjkhjkhkjh");
        }

        //public new void GetDetails()
        //{
        //    Console.WriteLine("jhjkhjkhkjh");
        //}
    }
}

/*
 Overriding
==========
- Method with same parameter type(same signature),
but it should not be int the same class, 
it will be available in different class - called method overriding

-  Inheritance is must()
-  Why overriding : We will have multiple method and that method will be 
used at multiple place-> If we dont want to touch existing functionalities
then we over that method whereever we want to use

- override & vertual
- To override any method we have use vertual keyword with existing and
whenever we are going to override we use override keyword with that method

 
 
What is difference between overloading & oveeriding in C#?

What is difference between override and new?

 */