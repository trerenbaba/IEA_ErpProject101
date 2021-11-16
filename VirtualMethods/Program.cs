using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            sql.Add();
            sql.Delete();

            MySql mySql = new MySql();
            mySql.Add();
            mySql.Delete();


            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
    }
    class Sql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
           // base.Add();
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by MySql Code");

           // base.Delete();
        }
    }
}
