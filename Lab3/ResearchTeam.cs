using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class ResearchTeam : Team, INameAndCopy, IComparer
    {
        private string Theme;
        /*private ArrayList Publications = new ArrayList();
        private ArrayList TeamMembers= new ArrayList();*/

		List<Person> TeamMembers = new List<Person> (); 
		List<Paper> Publications = new List<Paper> (); 
		private TimeFrame Duration;


		public ResearchTeam(string Name, string Theme, List<Paper> Publications, int RegisterCode, TimeFrame ResearchDuration)
        {
            this.Name = Name;
            this.Theme = Theme;
            this.Publications = Publications;
            this.RegisterCode = RegisterCode;
            Duration = ResearchDuration;
        }

        public ResearchTeam()
        {
            Name = "Ima";
            Theme = "shakaly";
            RegisterCode = 58001;
            Duration = TimeFrame.Long;
        }

        public string ResearchTheme { get { return Theme; } set { Theme = value; } }
        public List<ResearchTeam> ResearchPublications { get { return Publications; } set { Publications = value; } }
        public int ResearchRegisterCode { get { return RegisterCode; } set { RegisterCode = value; } }
        public TimeFrame ResearchDuration { get { return Duration; } set { Duration = value; } }
		public List<ResearchTeam> ResearchTeamMembers { get { return TeamMembers; } set { TeamMembers = value; } }

        public bool this[TimeFrame time]
        {
            get { return time == Duration ? true : false; }
        }

        public void AddPapers ( params Paper[] papers)
        {
            foreach (Paper paper in papers)
                Publications.Add(paper);
        }

        public void AddMembers(params Person[] members)
        {
            foreach (Person person in members)
                TeamMembers.Add(person);
        }

        public override object DeepCopy()
        {
            ResearchTeam temp = new ResearchTeam();

            temp.Name = Name;
            temp.RegNumber = RegNumber;
            temp.ResearchTheme = ResearchTheme;
            temp.ResearchDuration = ResearchDuration;

            ArrayList members = new ArrayList();
            foreach (Person p in ResearchTeamMembers)
                members.Add(p.DeepCopy());
            temp.ResearchTeamMembers = members;

            ArrayList puplications = new ArrayList();
            foreach (Paper paper in ResearchPublications)
                puplications.Add(paper.DeepCopy());
            temp.ResearchPublications = puplications;

            return temp;
        }

        public string ArrayListToString(ArrayList al)
        {
            string temp = "";
            foreach (var element in al)
                temp +=  element.ToString();
            return temp;
        }

        public override string ToString()//о
        {
            return string.Format(" Research group: {0};\n Theme of reserch: {1};\n Group`s Register code: {2};\n Research duration: {3};\n Research publications: {4}; \n\r\r\r Team members: {5}",
                Name, ResearchTheme, ResearchRegisterCode, ResearchDuration, ArrayListToString(ResearchPublications), ArrayListToString(TeamMembers));
        }

        public virtual string ToShortString()
        {
            return string.Format(" Research group {0};\n Theme of reserch {1};\n Group`s Register code {2};\n Research duration {3}",
                Name, ResearchTheme, ResearchRegisterCode, ResearchDuration);
        }

        public override int GetHashCode()
        {
            return Theme.Length * RegisterCode * 1488;
        }


        public IEnumerable GetPapers(int LastNYears)
        {
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - LastNYears; i--)
			{
                foreach (Paper item in Publications)
	            {
                    if (item.DateOfPublication.Year == i)
                        yield return item;
	            }
			}
        }

		public int Compare(ResearchTeam x, ResearchTeam y)
		{
			if (x.Theme < y.Theme)
					return 1;
			if (x.Theme > y.Theme)
					return -1;
				else return 0;
		}

    }
}
