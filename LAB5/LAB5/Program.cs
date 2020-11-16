using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class Program
    {
        public abstract class Furniture
        {
            public string Name { get; set; }
            public float Weight { get; set; }
            public float Width { get; set; }
            public float Height { get; set; }
            public float Length { get; set; }
            public Furniture(string name, float weight, float width, float height, float lenght)
            {
                Name = name;
                Weight = weight;
                Width = width;
                Height = height;
                Length = lenght;
            }
            public virtual void Print()
            {
                Console.WriteLine($"|Мебель\t|Вес\t|Ширина\t|Высота\t|Длина");
                Console.WriteLine($"|      \t|   \t|      \t|      \t|     ");
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
            public Sofa(string name, float weight, float width, float height, float lenght) : base(name, weight, width, height, lenght)
            {
               
            }
            public override string ToString()
            {
                string str;
                str = "Мебель: " + Name + "Вес\n:" + Weight + "\nШирина: " + Width + "\nВысота" + Height + "\n";
                return str;
            }
        }
        public class Bed : Furniture
        {
            public Bed(string name, float weight, float width, float height, float lenght) : base(name, weight, width, height, lenght)
            {

            }
        }
        public class Chair : Furniture
        {
            public Chair(string name, float weight, float width, float height, float lenght) : base(name, weight, width, height, lenght)
            {

            }
        }
        public class Table : Furniture
        {
            public Table(string name, float weight, float width, float height, float lenght) : base(name, weight, width, height, lenght)
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
                if (obj is Sofa) $"Getting object as [Printer]".ToLog();
                else if (obj is Chair) $"Getting object as [Printer]".ToLog();
                else if (obj is Table) $"Getting object as [Printer]".ToLog();
                else if (obj is Bed) $"Getting object as [Printer]".ToLog();
                else obj.sell();
            }
        }
        static void Main(string[] args)
        {
            Furniture[] furnitures = new Furniture[4];
            Sofa sofa = new Sofa("Sofa", 200, 1.1f, 0.5f, 2.3f);
            Bed bed = new Bed("Bed", 100, 0.8f, 0.5f, 2.1f);
            Chair chair = new Chair("Chair", 30, 0.7f, 1.2f, 0.7f);
            Table table = new Table("Table", 40, 0.9f, 1.1f, 1.6f);
            sofa.Print();
            Console.WriteLine($"|{sofa.Name}\t|{sofa.Weight}\t|{sofa.Width}\t|{sofa.Height}\t|{sofa.Length}");
            Console.WriteLine($"|{bed.Name}\t|{bed.Weight}\t|{bed.Width}\t|{bed.Height}\t|{bed.Length}");
            Console.WriteLine($"|{chair.Name}\t|{chair.Weight}\t|{chair.Width}\t|{chair.Height}\t|{chair.Length}");
            Console.WriteLine($"|{table.Name}\t|{table.Weight}\t|{table.Width}\t|{table.Height}\t|{table.Length}");
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


