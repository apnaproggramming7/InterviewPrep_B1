
namespace OOPS_Concept.Interface
{
    interface ILaptop
    {
        void GetCovers();
    }

    interface IMobile
    {
        void GetCovers();
    }

    interface ITablet
    {
        void GetCovers();
    }

    public class LaptopMobleTab : ILaptop, ITablet, IMobile
    {
        void ILaptop.GetCovers()
        {
            Console.WriteLine("Laptop Covers");
        }

        void ITablet.GetCovers()
        {
            Console.WriteLine("Tablet Covers");
        }

        void IMobile.GetCovers()
        {
            Console.WriteLine("Mobile Covers");
        }
    }


}
