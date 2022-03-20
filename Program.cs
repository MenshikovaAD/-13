using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulding bulding = new Bulding("г. Санкт-Петербург, Лахтинский пр., д.2, корп.3", 65, 65, 462);
            Console.WriteLine(bulding.Print());
            MultiBuilding multiBuilding = new MultiBuilding("г. Санкт-Петербург, Лахтинский пр., д.2, корп.3", 65, 65, 462, 87);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
