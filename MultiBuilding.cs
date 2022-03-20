using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    sealed class MultiBuilding: Bulding
    {
        int floor { get; set; }
        public MultiBuilding(string adres, double length, double widt, double height, int floor)
            :base(adres, length, widt, height)
        {
            
            this.floor = floor; 
        }
        public string Print()
        {
            string result = base.Print();
            result += $"{System.Environment.NewLine}Количество этажей - {floor}";
            return result;
        }
    }
}
