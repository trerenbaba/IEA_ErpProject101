﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solid prensiplerinden 4.sü olan Interface Segragation prensibini kullandık.

            //Single Responsibility:Sınıflarımızın iyi tanımlanmış tek bir sorumluluğu olmalıdır.
            //Open/Closed :Sınıfların değişikliğe kapalı ancak yeni davranışların eklenmesine açık olmalı.
            //Liskov Substitution : Kodumuzuda herhangi bir değişiklik yapmaya gerek kalmadan türetilmiş sınıfların (sub class) türedikleri ata sınıfın (base class) yerine kullanabilmeliyiz.
            //Interface Segragation : Genel kullanım amaçlı tek bir kontrat yerine daha özelleşmiş birden çok kontrat oluşturmayı tercih etmeliyiz.
            //Dependency Inversion : Katmanlı mimarilerde üst seviye modüller alt seviyedeki modüllere doğrudan bağımlı olmamalıdır.
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Warker : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }

}
