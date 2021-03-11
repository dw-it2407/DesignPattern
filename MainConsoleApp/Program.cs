using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //EagerSingleton eager = EagerSingleton.GetInstance();
            //EagerSingleton eagerSingleton = EagerSingleton.GetInstance();
            //if (eager.Equals(eagerSingleton))
            //{
            //    Console.WriteLine("eqals");
            //}
            //else
            //{
            //    Console.WriteLine("not equals");
            //}

           
            Console.ReadKey();
        }
    }

    public class CalculateSalary
    {

    }

    class Employees
    {

        private bool bonus = false;
        private double salary = 0.0;
    }

    public class LazySingleton
    {
        private static LazySingleton instance = null;
        private LazySingleton() { }

        public static LazySingleton GetInstance()
        {
            if (instance == null)
                instance = new LazySingleton();

            return instance;
        }

    }

    public class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();
        private EagerSingleton()
        {
            Console.WriteLine("Created eager singleton");
        }

        public static EagerSingleton GetInstance()
        {
            return instance;
        }

    }


   
}