using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new MsSql();
            database.Add();
            database.Deleted();
            Database database2 = new Oracle();
            database2.Add();
            database2.Deleted();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        //Abstract classlar ile hem tamamlanmış hemde tamamlanmamış metodlar tanımlayabiliriz.
        //Abstract classlar birer inheritance dir. Bu yüzden her class için bir kez kullanılır sonrasında interface lerimiz var ise ekleyebiliriz. Abstract classlar new keyworu alamazlar.
        public void Add() //Tamamlanmış metod
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Deleted(); //Tamamlanmamış metod
    }
    class MsSql : Database
    {
        //Abstract dediğimiz şey içi dolu olmayan virtual metoddur.
        public override void Deleted()
        {
            Console.WriteLine("Deleted by MsSql");
        }
    }

    class Oracle : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
