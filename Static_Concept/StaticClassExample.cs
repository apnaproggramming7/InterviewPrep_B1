
namespace Static_Concept
{
    public static class StaticClassExample
    {
    }


    public class NormalClass
    {
        public static int Static_Number;

        public static int Instance_Number;

        public NormalClass()
        {
            Static_Number++;
            Instance_Number++;
        }
    }
}
