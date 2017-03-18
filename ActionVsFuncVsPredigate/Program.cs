using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionVsFuncVsPredigate
{
    class Program
    {
        delegate string delgateType(int number);

        public static string MethodReference(int age)
        {
            Console.WriteLine(String.Format("Delegate Reference Age is : {0}",age.ToString()));
            return age.ToString();
        }

        static Func<int, string> _func;
        static Action<int> _action;
        Predicate<int> _prdeicate;

        

        static void Main(string[] args)
        {
            delgateType delegateReference = MethodReference;
            delegateReference(28);

            _func = MethodReference;
            _action = (x) => { Console.WriteLine(x.ToString()); };



            Random randomizer = new Random();
           List<String> sampleList = Enum.GetNames(typeof(ConsoleColor)).ToList();

           Console.WriteLine(sampleList.Select(x => x.Last()));
           sampleList.ForEach(colors => { Console.WriteLine(colors); });


           Console.ReadKey();
        }
    }
}
