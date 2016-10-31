using System;
using System.Collections.Generic;
using System.Collections;

namespace Lab3
{
	internal class ResearchTeamCollection
	{
		private List<ResearchTeam> Teams = new List<ResearchTeam>();

		public List<ResearchTeam> SortedByRegNumber
		{
			get
			{
				List<ResearchTeam> sorting = new List<ResearchTeam>(Teams);
				sorting.Sort();

				return sorting;
			}
		}

		public List<ResearchTeam> SortedByTheme
		{
			get
			{
				List<ResearchTeam> sorting = new List<ResearchTeam>(Teams);
				sorting.Sort(new ResearchTeam());

				return sorting;
			}
		}

		public List<ResearchTeam> SortedByNumber
		{
			get
			{
				List<ResearchTeam> sorting = new List<ResearchTeam>(Teams);
				sorting.Sort(new TeamComparer());

				return sorting;
			}
		}

		public void AddDefaults()
		{
			Teams.Add(new ResearchTeam("6 Team", "6 Tme", new List<Paper>(), 432331, TimeFrame.Long));
			Teams.Add(new ResearchTeam("7 Team", "7 The", new List<Paper>(), 924931, TimeFrame.Year));
			Teams.Add(new ResearchTeam("8 Team", "8 Them", new List<Paper>(), 324391, TimeFrame.Year));
			Teams.Add(new ResearchTeam("9 Team", "9 Theme", new List<Paper>(), 302111, TimeFrame.TwoYears));
			Teams.Add(new ResearchTeam("1 Team", "T", new List<Paper>(), 322221, TimeFrame.TwoYears));
			Teams.Add(new ResearchTeam("2 Team", "T1", new List<Paper>(), 412342, TimeFrame.Long));
			Teams.Add(new ResearchTeam("3 Team", "T1", new List<Paper>(), 322321, TimeFrame.Year));
			Teams.Add(new ResearchTeam("4 Team", "T111", new List<Paper>(), 123421, TimeFrame.Long));
			Teams.Add(new ResearchTeam("5 Team", "T123", new List<Paper>(), 323221, TimeFrame.TwoYears));

		}

		public void AddResearchTeams ( params  ResearchTeam [] teams) 
		{
			foreach (ResearchTeam team in teams)
				Teams.Add(team);
		}

		public override string ToString ()
		{
			string output = "";
			foreach (ResearchTeam team in Teams)
				output += team + "\n\n";
			return output;
		}


	}
}

