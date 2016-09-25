using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Team : INameAndCopy
    {
        protected string name;
        protected int regNumber;

        public Team(string _name, int _regNumber)
        {
            name = _name;
            regNumber = _regNumber;
        }

        public Team()
        {
            name = "NoName";
            regNumber = 8800555;
        }

        public string Name { get; set; }
        

        public int RegNumber
        {
            get { return regNumber; }
            set
            {
                try
                {
                    if (value <= 0) throw new ArgumentOutOfRangeException("Номер не подходит!");
                    regNumber = value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw;
                }
            }
        }

        public virtual object DeepCopy()
        {
            Team temp = new Team();

            temp.name = name;
            temp.regNumber = regNumber;

            return temp;
        }

        public override bool Equals(object obj)
        {
            Team team = (Team)obj;
            return name.Equals(team.name)
                && regNumber.Equals(team.regNumber)
                ? true : false;
        }


        public static bool operator ==(Team p1, Team p2)
        {
            return p1.Equals(p2) ? true : false;
        }


        public static bool operator !=(Team p1, Team p2)
        {
            return p1.Equals(p2) ? false : true;
        }

        public override string ToString()
        {
            return "Name: " + name + ". Regisration number: " + regNumber;
        }
    }
}
