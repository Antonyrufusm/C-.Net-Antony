using System; // comment
using ClassLibrary1;

namespace CLR_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassSample classSample = new ClassSample();
            classSample.Calculate();
            Console.WriteLine("Welcome Aspire");
            Console.ReadKey();
        }
    }
}
