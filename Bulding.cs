using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    
    class Bulding
    {
        string adres { get; set; }
        double length { get; set; }
        double width { get; set; }
        double height { get; set; }

        public Bulding(string adres, double length, double widt, double height)
        {
            this.adres = adres;
            this.length = length;   
            this.width = widt;  
            this.height = height;   
        }

        public string Print()
        {
            return $"Адрес здания:{adres} {System.Environment.NewLine}Длина здания - {length} м{System.Environment.NewLine}Ширина здания -  {width} м{System.Environment.NewLine}Высота здания -  {height} м";
        }
    }
}
