using System;
using System.Collections.Generic;

namespace MyConsole
{
    class Program
    {
        /// <summary>Example that use a list with objects</summary>
        static void Main(string[] args)
        {
            var personList = CreatePersonList();
            EchoPersonList(personList);

            personList = ChangeItems(personList);
            EchoPersonList(personList);

            personList = RemoveItems(personList);
            EchoPersonList(personList);

            personList = FindOneItem(personList);
            EchoPersonList(personList);
        }

        /// <summary>Creates and returns a list with Person objects that has data</summary>
        protected static List<Person> CreatePersonList() 
        {
            List<Person> personList = new List<Person>();

            personList.Add(new Person() { BirthYear=1990, Name="Adam" } );
            personList.Add(new Person() { BirthYear=1991, Name="Bertil" } );
            personList.Add(new Person() { BirthYear=1992, Name="Cesar" } );
            personList.Add(new Person() { BirthYear=1993, Name="David" } );
            personList.Add(new Person() { BirthYear=1994, Name="Erik" } );
            personList.Add(new Person() { BirthYear=1995, Name="Filip" } );

            return personList;
        }

        /// <summary>Shows the list in the Console</summary>
        protected static void EchoPersonList(List<Person> personList)
        {
            foreach (Person myItem in personList) {
                Echo(myItem.ToString());
            }
            Echo("-------------------------------");
        }

        /// <summary>Loops trough the list and change all names</summary>
        protected static List<Person> ChangeItems(List<Person> personList)
        {
            foreach (Person myItem in personList) {
                myItem.Name = myItem.Name + "-a";
            }

            return personList;
        }

        /// <summary>Remove item by index. Remove item by finding the BirthYear</summary>
        protected static List<Person> RemoveItems(List<Person> personList)
        {
            // Remove by list index
            personList.RemoveAt(3); // Item 0,1,2,3 - David will be removed.

            // Remove by search - The compare will look at BirthYear only so Bertil will be removed.
            // See required functions MyClass -> Person: Equals and GetHashCode.
            var findPerson = new Person() { BirthYear=1991, Name="Cesar" };
            personList.Remove(findPerson);

            return personList;
        }

        /// <summary>Find an item by part of the name and then we update the name</summary>
        protected static List<Person> FindOneItem(List<Person> personList)
        {
            var onePerson = personList.Find(x => x.Name.Contains("Cesar"));
            if (onePerson != null) {
                onePerson.Name = "New Cesar";
            }

            return personList;
        }

        /// <summary>Writes to the console</summary>
        protected static void Echo(string row = "") {
            Console.WriteLine(row);
        }

    }
}
