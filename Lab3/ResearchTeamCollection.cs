using System;
using System.Collections.Generic;

namespace Lab3
{
	public class ResearchTeamCollection
	{
		private List<ResearchTeam> Teams = new List<ResearchTeam>();

		public ResearchTeamCollection ()
		{
		}

		public void AddDefaults()
		{
			Teams.Add(new ResearchTeam("1 Team", "1 Theme", new List<Paper>(), 322221, TimeFrame.TwoYears));
			Teams.Add(new ResearchTeam("2 Team", "2 Theme", new List<Paper>(), 412342, TimeFrame.Long));
			Teams.Add(new ResearchTeam("3 Team", "3 Theme", new List<Paper>(), 322321, TimeFrame.Year));
			Teams.Add(new ResearchTeam("4 Team", "4 Theme", new List<Paper>(), 123421, TimeFrame.Long));
			Teams.Add(new ResearchTeam("5 Team", "5 Theme", new List<Paper>(), 323221, TimeFrame.TwoYears));
			Teams.Add(new ResearchTeam("6 Team", "6 Theme", new List<Paper>(), 432331, TimeFrame.Long));
			Teams.Add(new ResearchTeam("7 Team", "7 Theme", new List<Paper>(), 924931, TimeFrame.Year));
			Teams.Add(new ResearchTeam("8 Team", "8 Theme", new List<Paper>(), 324391, TimeFrame.Year));
			Teams.Add(new ResearchTeam("9 Team", "9 Theme", new List<Paper>(), 302111, TimeFrame.TwoYears));
		}

		public void AddResearchTeams ( params  ResearchTeam [] Teams) 
		{
			
		}
	}
}

