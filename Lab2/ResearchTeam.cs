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
        private string researchTheme;
        private ArrayList researchPublications = new ArrayList();
        private ArrayList researchTeamMembers= new ArrayList();
        private int researchRegisterCode;
        private TimeFrame researchDuration;
        

        public ResearchTeam(string ResearchTheme, ArrayList ResearchPublications, int ResearchRegisterCode, TimeFrame ResearchDuration)
        {
            researchTheme = ResearchTheme;
            researchPublications = ResearchPublications;
            researchRegisterCode = ResearchRegisterCode;
            researchDuration = ResearchDuration;
        }

        public ResearchTeam()
        {
            researchTheme = "new Theme";
            researchRegisterCode = 0000000;
            researchDuration = TimeFrame.Long;
        }

        public string ResearchTheme { get { return researchTheme; } set { researchTheme = value; } }
        public ArrayList ResearchPublications { get { return researchPublications; } set { researchPublications = value; } }
        public int ResearchRegisterCode { get { return researchRegisterCode; } set { researchRegisterCode = value; } }
        public TimeFrame ResearchDuration { get { return researchDuration; } set { researchDuration = value; } }
        public ArrayList ResearchTeamMembers { get { return researchTeamMembers; } set { researchTeamMembers = value; } }

        public bool this[TimeFrame time]
        {
            get { return time == researchDuration ? true : false; }
        }

        public void AddPapers ( params Paper[] papers)
        {
            foreach (Paper paper in papers)
                researchPublications.Add(paper);
        }

        public void AddMembers(params Person[] members)
        {
            foreach (Person person in members)
                researchTeamMembers.Add(person);
        }

        public override string ToString()
        {
            return string.Format(" Research group {0};\n Theme of reserch {1};\n Group`s Register code {2};\n Research duration {3};\n Research publications {4}",
                researchTeamMembers, ResearchTheme, ResearchRegisterCode, ResearchDuration, ResearchPublications);
        }

        public virtual string ToShortString()
        {
            return string.Format(" Research group {0};\n Theme of reserch {1};\n Group`s Register code {2};\n Research duration {3}",
                researchTeamMembers, ResearchTheme, ResearchRegisterCode, ResearchDuration);
        }

        public override int GetHashCode()
        {
            return researchTheme.Length * researchRegisterCode * 1488;
        }


        public IEnumerator<int> GetPapers(int LastNYears)
        { 
            int count = 0;
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - LastNYears; i--)
			{
                foreach (Paper item in researchPublications)
	            {
	            	 if(item.DateOfPublication.Year==i)
                         count++;
	            }
			}
            yield return count;
        }


    }
}
