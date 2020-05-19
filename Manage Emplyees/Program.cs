using Finances.Employees;
using System;


namespace Finances
{
    namespace Employees
    {

        class Program
        {
            static void Main(string[] args)
            {
                Person Person1 = new Person();
                Empolyee Person = new Empolyee();

                Person1.SetPerson("Pablo", "Wozniak", 22);
                Person1.GetPerson();

                Person.SetEmployee("cook", 4);
                Console.WriteLine(Person.GetEmplyee());

            }
        }
    }
}
