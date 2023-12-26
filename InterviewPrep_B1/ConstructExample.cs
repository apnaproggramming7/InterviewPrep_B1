namespace InterviewPrep_B1
{
    public class ConstructExample
    {
        public string name;
        //public ConstructExample()
        //{
        //    Console.WriteLine("Defaut Constructor Called");
        //}

        //// Parameterized Constructor
        //public ConstructExample(int number)
        //{
        //    this.name = name;
        //    Console.WriteLine($"{number} Constructor Called");
        //}

        //public ConstructExample(string address)
        //{
        //    Console.WriteLine("Parameter Constructor Called");
        //}

        //public ConstructExample(ConstructExample copy)
        //{
        //    Console.WriteLine("Copy Constructor Called");
        //    this.name = copy.name;
        //}


        public ConstructExample()
        {
            Console.WriteLine("Defaut Constructor Called");
        }

        // Static word -> We are not going create any object for that
        static ConstructExample()
        {
            Console.WriteLine("Static Constructor Called");
        }

        // Sigleton design pattern
        //private ConstructExample()
        //{
        //    Console.WriteLine("Private Constructor");
        //}


    }
}