using System;

namespace Net.Petricevic.Learnings.CSharp.MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCrud db = new MongoCrud("AddressBook");

            //var person = new PersonModel
            //{
            //    FirstName = "John", 
            //    LastName = "Doe",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "Schumacher Str. 11",
            //        City = "Linz",
            //        State = "Austria",
            //        ZipCode = "4020"
            //    }
            //};

            //db.InsertRecord("Users", person);

            var records = db.LoadRecords<NameModel>("Users");

            foreach (var person in records)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }

            //var records = db.LoadRecords<PersonModel>("Users");

            //foreach (var person in records)
            //{
            //    Console.WriteLine($"{person.Id}: {person.FirstName} {person.LastName}");

            //    if (person.PrimaryAddress != null)
            //        Console.WriteLine("City: " + person.PrimaryAddress.City);
            //}

            //var personFromId = db.LoadRecordById<PersonModel>("Users", new Guid("6975604f-02e0-41cc-b4f3-625f7abeb320"));

            //personFromId.DateOfBirth = new DateTime(1982,10,31,0,0,0,DateTimeKind.Utc);
            //db.UpsertRecord("Users", personFromId.Id, personFromId);

            //db.DeleteRecord<PersonModel>("Users", personFromId.Id);


        }
    }
}
