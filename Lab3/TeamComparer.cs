using System;
using System.Collections.Generic;
namespace Lab3
{
	internal class TeamComparer: IComparer<ResearchTeam>
	{
		public int Compare(ResearchTeam x, ResearchTeam y)
		{
			if (x.ResearchPublications.Count< y.ResearchPublications.Count)
				return 1;
			if (x.ResearchPublications.Count > y.ResearchPublications.Count)
				return -1;
			else return 0;
		}
	}
}

