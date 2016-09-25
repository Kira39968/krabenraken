using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        private string name;
        private string sName;
        private DateTime birth;

        public Person()
        {
            DateTime _dt = new DateTime(0000,01,01);
            this.name = "unnamed";
            this.sName = "unnamed";
            this.birth = _dt;
        }

        public Person(string name, string sName, DateTime birth)
        {
            this.name = name;
            this.sName = sName;
            this.birth = birth;
        }

        public string Name
        { 
            get { return this.name; }
            set { this.name = value; }
        }

        public string SurName
        {
            get { return this.sName; }
            set { this.sName = value; }
        }

        public DateTime DateOfBirth 
        {
            get { return this.birth; }
            set { this.birth = value; }
        }

        public int YearOfBirth
        {
            get { return birth.Year; }
            set { birth.AddYears(value - birth.Year); }
        }

        public override string ToString()
        {
            return "Name: " + this.name + ". Surname: " + this.sName + ". Date of Birth: " + this.birth;
        }

        public virtual string ToShortString()
        {
            return "Name: " + this.name + ". Surname: " + this.sName;
        }

        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            return name.Equals(person.name) 
                && sName.Equals(person.sName) 
                && birth.Equals(person.birth) 
                ? true : false;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2) ? true : false;
        }
        
        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Equals(p2) ? false : true;
        }

        public override int GetHashCode()
        {
            Random r = new Random();
            return (birth.Month * birth.Day + birth.Year) + 1024 * 1488 + 228 * (name.Length * sName.Length * r.Next(10,20));
        }

    }
}
