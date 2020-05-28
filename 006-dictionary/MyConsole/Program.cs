using System;
using System.Collections.Generic; // When you want to use Dictionary
using System.Linq; // When you want to use FirstOrDefault

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
        protected static Dictionary<string, Person> CreatePersonList() 
        {
            Dictionary<string, Person> personList = new Dictionary<string, Person>();

            personList.Add("001", new Person() { Id="001", BirthYear=1990, Name="Adam" } );
            personList.Add("002", new Person() { Id="002", BirthYear=1991, Name="Bertil" } );
            personList.Add("003", new Person() { Id="003", BirthYear=1992, Name="Cesar" } );
            personList.Add("004", new Person() { Id="004", BirthYear=1993, Name="David" } );
            personList.Add("005", new Person() { Id="005", BirthYear=1994, Name="Erik" } );
            personList.Add("006", new Person() { Id="006", BirthYear=1995, Name="Filip" } );

            return personList;
        }

        /// <summary>Shows the list in the Console</summary>
        protected static void EchoPersonList(Dictionary<string, Person> personList)
        {


            foreach (KeyValuePair<string, Person> entry in personList)
            {
                // do something with entry.Value or entry.Key
                Echo(entry.Value.ToString());
            }

            Echo("-------------------------------");
        }

        /// <summary>Loops trough the list and change all names</summary>
        protected static Dictionary<string, Person> ChangeItems(Dictionary<string, Person> personList)
        {
            foreach (KeyValuePair<string, Person> entry in personList)
            {
                // do something with entry.Value or entry.Key
                entry.Value.Name = entry.Value.Name + "-a";
            }

            return personList;
        }

        /// <summary>Remove item by index. Remove item by finding the BirthYear</summary>
        protected static Dictionary<string, Person> RemoveItems(Dictionary<string, Person> personList)
        {
            // Remove by list index
            personList.Remove("003"); // Removes Cesar

            // Remove by search - The compare will look at BirthYear only so Erik will be removed.
            // See required functions MyClass -> Person: Equals and GetHashCode.
            var myKey = personList.FirstOrDefault(x => x.Value.BirthYear == 1994).Key;
            personList.Remove(myKey);

            return personList;
        }

        /// <summary>Find an item by part of the name and then we update the name</summary>
        protected static Dictionary<string, Person> FindOneItem(Dictionary<string, Person> personList)
        {
            var myKey = personList.FirstOrDefault(x => x.Value.Name == "Adam-a").Key;

            if (myKey != null) {
                personList[myKey].Name = "New Adam";
            }

            return personList;
        }

        /// <summary>Writes to the console</summary>
        protected static void Echo(string row = "") {
            Console.WriteLine(row);
        }
    }
}
