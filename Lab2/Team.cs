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
                try
                {
                    if (value <= 0) throw new ArgumentOutOfRangeException("Номер не подходит!");
                    RegisterCode = value;
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
            temp.RegisterCode = RegisterCode;

            return temp;
        }

        public override bool Equals(object obj)
        {
            Team team = (Team)obj;
            return name.Equals(team.name)
                && RegisterCode.Equals(team.RegisterCode)
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
    }
}
