using System;

namespace MyConsole
{
    /// <summary>Class for a person</summary>
    class Person
    {        
        public int BirthYear { get; set; }
        public string Name { get; set; }

        /// <summary>Used when you want to print the object data</summary>
        public override string ToString()
        {
            return "Year: " + BirthYear + ", Name: " + Name;
        }

        /// <summary>Used for comparing</summary>
        public override bool Equals(object anObject)
        {
            if (anObject == null) {
                return false;
            }

            Person onePerson = anObject as Person;

            if (onePerson == null) {
                return false;
            }

            return Equals(onePerson);
        }

        /// <summary>Required to get Equals to work. Returns the ID for the object</summary>
        public override int GetHashCode()
        {
            return BirthYear;
        }

        /// <summary>Used by Equals when it calls itself with a onePerson object</summary>
        public bool Equals(Person onePerson)
        {
            if (onePerson == null) {
                return false;
            }

            return (this.BirthYear.Equals(onePerson.BirthYear));
        }
    }
}
