namespace project_euler.Test
{
	public class Tests
	{
		public record MultiplesOf3And5TestCase(
			uint InputNumber,
			uint Result);

		private static readonly List<MultiplesOf3And5TestCase> testCases =
			[
			new (0, 0),
			new (49, 543),
			new (1000, 233168),
			new (8456, 16687353),
			new (19564, 89301183),
			];

		[TestCaseSource(nameof(testCases))]
		public void MultiplesOf3And5Test(MultiplesOf3And5TestCase testCase)
		{
			Assert.That(Functions.MultiplesOf3And5(testCase.InputNumber), Is.EqualTo(testCase.Result));
		}
	}
}
