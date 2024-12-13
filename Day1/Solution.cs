namespace Falconi.AoC.Day1
{
	/// <summary>
	/// Problem Solution
	/// </summary>
	public class Solution
	{
		public List<int> Right { get; set; }
		public List<int> Left { get; set; }
		private string FileName { get; set; } = "input.txt";
		public Solution()
		{
			Right = new();
			Left = new();
			LoadData();
		}

		/// <summary>
		/// Handles the initial data load 
		/// and loads data into 2 class properties
		/// </summary>
		public void LoadData()
		{
			foreach (var line in File.ReadLines(FileName))
			{
				var split = line.Split("   ");
				int left = Int32.Parse(split[0]);
				int right = Int32.Parse(split[1]);
				Left.Add(left);
				Right.Add(right);
				Left.Sort();
				Right.Sort();
			}
			for (var i = 0; i < Left.Count; i++)
			{
				Console.WriteLine($"{Left[i]}   {Right[i]}");
			}
		}

		/// <summary>
		/// Generates the final diff value for the 2 lists
		/// </summary>
		/// <returns>An integer which represents the difference between the 2 lists</returns>
		public int GenerateDiff()
		{
			int returnVal = 0;
			for (var i = 0; i < Left.Count; i++)
			{
				int diff = Left[i] - Right[i];
				if (diff < 0)
				{
					diff *= -1;
				}
				returnVal += diff;
			}
			return returnVal;
		}
	}
}