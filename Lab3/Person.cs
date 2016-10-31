using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
        private string name;
        private string sName;
        private DateTime birth;

        public Person()
        {
            DateTime _dt = new DateTime(1999,01,01);
            name = "Dasha";
            sName = "Kovtun";
            birth = _dt;
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
            return "\nName: " + this.name + ".\n Surname: " + this.sName + ".\n Date of Birth: " + this.birth;
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

        public virtual object DeepCopy()
        {
            Person temp = new Person();

            temp.Name = Name;
            temp.SurName = SurName;
            temp.YearOfBirth = YearOfBirth;

            return temp;
        }

        public override int GetHashCode()
        {
            return (birth.Month * birth.Day + birth.Year) + 1024 * 1488 + 228 * (name.Length * sName.Length);
        }

    }
}
