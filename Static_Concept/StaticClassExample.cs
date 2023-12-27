
using System;

namespace Static_Concept
{
    public static class StaticClassExample
    {
        #region We cannot create instance/non static fields or properties

        // int number = 10;
        // public int Id { get; set; }

        #endregion

        #region We cannot create Instance/non static Methods

        //public void GetData()
        //{
        //    Console.WriteLine("Data");
        //}

        #endregion

        #region We cannot create non-static constructor

        //public StaticClassExample()
        //{

        //}

        #endregion


        // Only we can create static members, constructor, properties etc.

        public static string Name { get; set; }

        public static int number;

        public static void GetData()
        {
            Console.WriteLine("Message from GetData Static Method");
        }

        // Static Constructor will call first- When we will be going to call static method
        static StaticClassExample()
        {
            Console.WriteLine("Project Stating Time:" + DateTime.Now);
        }
    }


    public class NormalClass
    {
        // Non-static/Instance field
        int num_instance = 10;
        public void GetNonStaticValue()
        {
            num_instance = num_instance + 10; //20
            Console.WriteLine("Instance variable value: " + num_instance);
        }

        // static field
        static int num_static = 10;
        public void GetStaticValue()
        {
            num_static = num_static + 10; //20
            Console.WriteLine("Static variable value: " + num_static);
        }
    }


    public class ClassWithStaticAndNonStaticField
    {
        int num = 10;
        static int num2 = 10;
        public ClassWithStaticAndNonStaticField()
        {
            Console.WriteLine("=========================Static/Non-Static Fields=====================");

            num++;
            num2++;
            Console.WriteLine("\n Non-static num: " + num);
            Console.WriteLine("\n Static num2: " + num2);

            Console.WriteLine("=========================END Static/Non-Static Fields=====================");
        }
    }
}
