using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler hiçbir zaman new keywordü ile kullanılamazlar.
            //IPerson iper = new IPerson();
            //Ancak IPerson interface inden türettiğimiz sınıflar new lenebilir.
            

            InterfaceBegin();

            ICustomerDal[] cd = new ICustomerDal[2]
            {
                new UseOracle(),
                new UseSqlDal()
            };
            foreach (var customerDal in cd)
            {
                customerDal.Add();
            }

            //CustomerManager cm = new CustomerManager();
            //cm.Add(new UseOracle());
            //cm.Add(new UseSqlDal());

            Console.ReadLine();
        }

        private static void InterfaceBegin()
        {
            IPerson person = new Customer();
            IPerson person1 = new Student();

            Customer customer = new Customer
            {
                id = 1,
                Name = "Onur",
                LastName = "Agici",
                Adress = "Esengles"
            };
            Student student = new Student
            {
                id = 2,
                Name = "Selin",
                LastName = "Agici",
                StudentNo = "445"
            };

            PersonManager pm = new PersonManager();
            pm.Add(customer);
        }
    }

    interface IPerson //Soyut nesne
    {
        //Temel (Base) nesne oluşturup diğer nesneleri ondan implemente etmekdir.
        //Soyut nesneler tek başlarına anlam ifade etmezler ve somut nesnelere ihtiyaç duyarlar.
        int id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson //Somut nesne
    {
        public int id { get;set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student:IPerson
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentNo { get; set; }
    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name);
        }
    }
}
