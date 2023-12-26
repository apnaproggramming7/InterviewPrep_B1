namespace OOPS_Concept
{
    public class Parent1
    {
        public void TwoWheeler()
        {
            Console.WriteLine("Parent Mobile");
        }
    }

    public class Parent2
    {
        public void TwoWheeler()
        {
            Console.WriteLine("Parent Mobile");
        }
    }

    public class Child1: Parent1//, Parent2 // Interface for multiple inheritance
    {
        public void Mobile()
        {
            Console.WriteLine("Child Mobile");
        }
    }
}
