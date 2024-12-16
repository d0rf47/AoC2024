using System.Linq;

namespace Falconi.AoC.Day1
{
	public class SolutionPart2
	{
		public Solution solution { get; set; }

		public SolutionPart2()
		{
			solution = new();
		}

		public int GenerateSimilarity()
		{
			int returnVal = 0;
			foreach (var i in solution.Left)
			{
				int occurance = solution.Right.Where(r => r == i).Count();
				returnVal += (i * occurance);
			}

			return returnVal;
		}
	}
}