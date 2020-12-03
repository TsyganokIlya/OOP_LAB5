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
using System.Diagnostics;
using LAB5.Exceptions;

namespace LAB5
{
    public class Program
    {
        public static Random rand;
        public abstract class Furniture
        {
            enum furn
            {
                str,
                str1,
                str2
            }
            public struct furnn
            {
                public string strr;
                public int a;
                public float f;
                public double d;
            }
            public string Name { get; set; }
            public float Weight { get; set; }
            public float Width { get; set; }
            public float Height { get; set; }
            public float Length { get; set; }
            public int Price { get; set; }
            public Furniture(string name, float weight, float width, float height, float lenght, int price)
            {
                Name = name;
                Weight = weight;
                Width = width;
                Height = height;
                Length = lenght;
                Price = price;
            }
            public virtual void Print()
            {
                Console.WriteLine($"|Мебель\t|Вес\t|Ширина\t|Высота\t|Длина\t|Стоимость");
                Console.WriteLine($"|      \t|   \t|      \t|      \t|     \t|");
            }
            public virtual void sold()
            {
                $"{GetType().Name} not sold!!!".ToLog();
            }
            public virtual void sell()
            {
                Console.WriteLine($"{Name} Sales!!!");
            }
        }
        public class Sofa : Furniture
        {
            public Sofa(string name, float weight, float width, float height, float lenght, int price) : base(name, weight, width, height, lenght, price)
            {
               
            }
            public override string ToString()
            {
                string str;
                str = "Мебель: " + Name + "Вес\n:" + Weight + "\nШирина: " + Width + "\nВысота" + Height + "\nСтоимость" + Price + "\n";
                return str;
            }
        }
        public class Bed : Furniture
        {
            public Bed(string name, float weight, float width, float height, float lenght, int price) : base(name, weight, width, height, lenght, price)
            {

            }
        }
        public class Chair : Furniture
        {
            public Chair(string name, float weight, float width, float height, float lenght, int price) : base(name, weight, width, height, lenght, price)
            {

            }
        }
        public class Table : Furniture
        {
            public Table(string name, float weight, float width, float height, float lenght, int price) : base(name, weight, width, height, lenght, price)
            {

            }
        }
        public partial class Cupboard : Furniture
        {
            public Cupboard(string name, float weight, float width, float height, float lenght, int price) : base(name, weight, width, height, lenght, price)
            {
                
            }
            public void cup()
            {
                
            }
        }
        public interface Sell
        {
            string Name { get;  }
            void sell();
            void sold();
        }
        public class Printer
        {
            public void IAmPrinting(Furniture obj)
            {
                if (obj is Sofa) $"Получаем объект[Printer]".ToLog();
                else if (obj is Chair) $"Получаем объект[Printer]".ToLog();
                else if (obj is Table) $"Получаем объект[Printer]".ToLog();
                else if (obj is Bed) $"Получаем объект[Printer]".ToLog();
                else obj.sell();
            }
        }

        static void Main(string[] args)
        {
            rand = new Random(DateTime.Now.Millisecond);
            Furniture[] furnitures = new Furniture[4];
            Sofa sofa = new Sofa("Sofa", 200, 1.1f, 0.5f, 2.3f, 500);
            Bed bed = new Bed("Bed", 100, 0.8f, 0.5f, 2.1f, 600);
            Chair chair = new Chair("Chair", 30, 0.7f, 1.2f, 0.7f, 456);
            Table table = new Table("Table", 40, 0.9f, 1.1f, 1.6f, 400);
            sofa.Print();
            Console.WriteLine($"|{sofa.Name}\t|{sofa.Weight}\t|{sofa.Width}\t|{sofa.Height}\t|{sofa.Length}\t|{sofa.Price}");
            Console.WriteLine($"|{bed.Name}\t|{bed.Weight}\t|{bed.Width}\t|{bed.Height}\t|{bed.Length}\t|{bed.Price}");
            Console.WriteLine($"|{chair.Name}\t|{chair.Weight}\t|{chair.Width}\t|{chair.Height}\t|{chair.Length}\t|{chair.Price}");
            Console.WriteLine($"|{table.Name}\t|{table.Weight}\t|{table.Width}\t|{table.Height}\t|{table.Length}\t|{table.Price}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\nИнтерфейс:");
            sofa.sell();
            bed.sell();
            chair.sell();
            table.sell();
            Console.WriteLine($"\nИнтерфейс + Абстрактный класс:");
            sofa.sold();
            Console.WriteLine($"\n");

            Sofa sofa1 = sofa as Sofa;

            Console.WriteLine($"\n\nЛабораторная работа №6\n\n");
            try
            {
                int Type = 2;
                int y;
                y = Type / 0;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            try
            {
                object n = "Hello";
                int s = (int)n;
            }
            catch(NotType ex)
            {
                ex.ToString().ToLog();
            }
            try
            {
                string str = "Hello";
                str = str.Insert(1, "World");
                throw new OutOfMemoryException();
            }
            catch(OutOfMemoryException str)
            {
                Console.WriteLine($"Возникло исключение OutOfMemoryException");
            }
            try
            {
                string n = null;
            }
            catch(NotCreate n)
            {
                n.ToString().ToLog();
            }
            finally
            {
                Console.WriteLine($"Вроде словил...");
            }
            Debug.Assert(sofa != null, "Got a null");

        }

    }
    public static class ExtensionMethods
    {
        public static void ToLog(this string source)
        {
            source = $"{source}";
            int buffTop = Console.CursorTop;
            Console.Write(source);
        }
    }
}


