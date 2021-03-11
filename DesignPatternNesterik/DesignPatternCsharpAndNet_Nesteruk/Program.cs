using Ocp;
using Srp;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharpAndNet_Nesteruk
{

    class Program
    {
        static void Main(string[] args)
        {
            //Example SRP
            //var j = new Journal();
            //j.AddEntry("Today");
            //j.AddEntry("I ate a bug");
            //Console.WriteLine(j);           
            //Persistence persistence = new Persistence();
            //persistence.SaveToFile(j, @"C:\temp\Journal.txt");            

            //Example Ocp
            var apple = new Product("Apple", Color.Red, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Medium);
            var house = new Product("House", Color.Blue, Size.Huge);

            Product[] products = { apple, tree, house };
            ProductFilter.FilterBySize(products, Size.Huge);
            
            Console.ReadKey();           
        }
    }
}
