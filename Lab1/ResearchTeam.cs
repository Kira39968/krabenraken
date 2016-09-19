using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ResearchTeam
    {
        private string researchTheme;
        private string researchTeam;
        private int researchRegisterCode;
        private TimeFrame researchDuration;
        private Paper[] researchPublications;

        public ResearchTeam(string ResearchTheme, string ResearchTeam, int ResearchRegisterCode, TimeFrame ResearchDuration)
        {
            this.researchTheme = ResearchTheme;
            this.researchTeam = ResearchTeam;
            this.researchRegisterCode = ResearchRegisterCode;
            this.researchDuration = ResearchDuration;
        }

        public ResearchTeam()
        {
            this.researchTheme = "new Theme";
            this.researchTeam = "new Team";
            this.researchRegisterCode = 0000000;
            this.researchDuration = TimeFrame.Long;
        }

        public string ResearchTheme { get { return this.researchTheme; } set { this.researchTheme = value; } }
        public string _ResearchTeam { get { return this.researchTeam; } set { this.researchTeam = value; } }
        public int ResearchRegisterCode { get { return this.researchRegisterCode; } set { this.researchRegisterCode = value; } }
        public TimeFrame ResearchDuration { get { return this.researchDuration; } set { this.researchDuration = value; } }
        public Paper[] ResearchPublications { get { return this.researchPublications; } set { this.researchPublications = value; } }

        public bool this[TimeFrame time]
        {
            get { return time == this.researchDuration ? true : false; }
        }

        public void AddPapers ( params Paper[] papers)
        {
            Paper[] temp = new Paper[this.ResearchPublications.Length + papers.Length];
            temp = this.ResearchPublications.Concat(papers).ToArray();
            this.ResearchPublications = temp;
        }

        public override string ToString()
        {
            return String.Format(" Research group {0};\n Theme of reserch {1};\n Group`s Register code {2};\n Research duration {3};\n Research publications {4}",
                _ResearchTeam, ResearchTheme, ResearchRegisterCode, ResearchDuration, ResearchPublications.ToList());
        }

        public virtual string ToShortString()
        {
            return String.Format(" Research group {0};\n Theme of reserch {1};\n Group`s Register code {2};\n Research duration {3}",
                _ResearchTeam, ResearchTheme, ResearchRegisterCode, ResearchDuration);
        }
    }
}
