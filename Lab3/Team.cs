using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Team : INameAndCopy, IComparable
    {
        protected string name;
        protected int RegisterCode;

        public Team(string _name, int _regNumber)
        {
            name = _name;
            RegisterCode = _regNumber;
        }

        public Team()
        {
            name = "NoName";
            RegisterCode = 8800555;
        }

        public string Name { get; set; }


        public int RegNumber
        {
            get { return RegisterCode; }
            set
            {
                 if (value <= 0)
                    throw new ArgumentOutOfRangeException("Номер не подходит!");
                else
                    RegisterCode = value;

            }
        }

        public virtual object DeepCopy()
        {
            Team temp = new Team();

            temp.name = name;
            temp.RegisterCode = RegisterCode;

            return temp;
        }

        public override bool Equals(object obj)
        {
            Team team = (Team)obj;
            return name.Equals(team.name)&& RegisterCode.Equals(team.RegisterCode)
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
            return "Name: " + name + ". Regisration number: " + RegisterCode;
        }

        public override int GetHashCode()
        {
            return name.Length * 1488 + RegisterCode;
        }

		public int CompareTo(object obj) 
		{
			Team otherTeam = obj as Team;
			return this.RegNumber.CompareTo(otherTeam.RegNumber);
		}
    }
}
