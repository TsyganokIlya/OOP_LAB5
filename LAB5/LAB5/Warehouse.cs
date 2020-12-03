using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LAB5
{
    public class Warehouse
    {
        public static Random rand;

        static void Main(string[] args)
        {
            int price = 0;
            rand = new Random(DateTime.Now.Millisecond);
            Cupboard[] cupboards = new Cupboard[rand.Next(15) + 5];
            for (int i = 0; i < cupboards.Length; i++)
            {
                cupboards[i] = new Cupboard()
                {
                    Price = rand.Next(100, 2000),
                    Weight = rand.Next(50, 250),

                };
                price += cupboards[i].Price;
            }
            Console.WriteLine($"\nСписок шкафов: ");
            foreach (var cupboard in cupboards)
            {
                Console.WriteLine($"\t{cupboard}");
            }
            Console.WriteLine($"\tОбщая стоимость шкафов: {price}");
            Console.WriteLine("\nВведите производителя шкафов: ");
            string choice1 = Console.ReadLine();
            foreach (var cupboard in cupboards)
            {
                if (cupboard.Manuf == choice1)
                {
                    Console.WriteLine($"\t{cupboard}");
                }
            }
        }
    }
    public partial class Cupboard
    {
        public int price = 0;
        private static string[] _Manufacturer;
        private static string _Manuf;
        private int _Price;
        private float _Weight;
        public static int count;
        public string Manuf
        {
            get
            {
                return _Manuf;
            }
            set
            {
                if (_Manufacturer.Contains(value))
                {
                    _Manuf = value;
                }
            }

        }
        ~Cupboard() => count--;
        static Cupboard()
        {
            _Manufacturer = new string[] { "BelMebel", "RusMebel", "GerMebel" };
        }
        public Cupboard()
        {
            Manuf = _Manufacturer[Warehouse.rand.Next(_Manufacturer.Length)];
        }
        public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }
        public float Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                _Weight = value;
            }
        }
        public override string ToString()
        {
            return $"{_Manuf}\t{_Weight} кг.\t{_Price} руб.";
        }
    }
}