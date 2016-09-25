using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ResearchTeam : Team, INameAndCopy
    {
        private string Theme;
        private ArrayList Publications = new ArrayList();
        private ArrayList TeamMembers= new ArrayList();
        
        private TimeFrame researchDuration;
        

        public ResearchTeam(string Name, string Theme, ArrayList Publications, int RegisterCode, TimeFrame ResearchDuration)
        {
            this.Name = Name;
            this.Theme = Theme;
            this.Publications = Publications;
            this.RegisterCode = RegisterCode;
            researchDuration = ResearchDuration;
        }

        public ResearchTeam()
        {
            Theme = "new Theme";
            RegisterCode = 0000000;
            researchDuration = TimeFrame.Long;
        }

        public string ResearchTheme { get { return Theme; } set { Theme = value; } }
        public ArrayList ResearchPublications { get { return Publications; } set { Publications = value; } }
        public int ResearchRegisterCode { get { return RegisterCode; } set { RegisterCode = value; } }
        public TimeFrame ResearchDuration { get { return researchDuration; } set { researchDuration = value; } }
        public ArrayList ResearchTeamMembers { get { return TeamMembers; } set { TeamMembers = value; } }

        public bool this[TimeFrame time]
        {
            get { return time == researchDuration ? true : false; }
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

            temp.Name = name;
            temp.RegNumber = RegisterCode;
            temp.ResearchTheme = Theme;
            temp.ResearchDuration = researchDuration;

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

        public override string ToString()
        {
            return string.Format(" Research group {0};\n Theme of reserch {1};\n Group`s Register code {2};\n Research duration {3};\n Research publications {4}; \n Team members {5}",
                Name, ResearchTheme, ResearchRegisterCode, ResearchDuration, ResearchPublications, TeamMembers);
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


        public IEnumerator<int> GetPapers(int LastNYears)
        { 
            int count = 0;
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - LastNYears; i--)
			{
                foreach (Paper item in Publications)
	            {
	            	 if(item.DateOfPublication.Year==i)
                         count++;
	            }
			}
            yield return count;
        }


    }
}
