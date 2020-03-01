using System;
using Net.Petricevic.Learnings.CSharp.Factory.Person;

namespace Net.Petricevic.Learnings.CSharp.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PersonFactory();
            IPerson person = factory.CreatePerson(PersonType.Rural);

            Console.WriteLine(person.GetName());
        }
    }
}
