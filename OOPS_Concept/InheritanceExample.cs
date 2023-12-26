namespace OOPS_Concept
{
    public class Parent
    {
        public void Bike()
        {
            Console.WriteLine("Parent having: Royal Enfield - Bike");
        }

        public void Car()
        {
            Console.WriteLine("Parent having: BMW - Car");
        }

        public void Land()
        {
            Console.WriteLine("Parent having: Land in Near To IT Park");
        }
    }

    public class Child : Parent
    {
        public void Laptop()
        {
            Console.WriteLine("Child having: HP - Laptop");
        }
    }
}