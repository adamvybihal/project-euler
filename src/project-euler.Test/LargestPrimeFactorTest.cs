namespace project_euler.Test
{
	public class LargestPrimeFactorTest
	{
		public record LargestPrimeFactorTestCase(
			long InputNumber,
			long Result);

		private static readonly List<LargestPrimeFactorTestCase> testCases =
			[
			new (2, 2),
			new (3, 3),
			new (5, 5),
			new (7, 7),
			new (8, 2),
			new (13195, 29),
			new (600851475143, 6857)
			];

		[TestCaseSource(nameof(testCases))]
		public void LargestPrimeFactorResultTest(LargestPrimeFactorTestCase testCase)
		{
			Assert.That(Functions.LargestPrimeFactor(testCase.InputNumber), Is.EqualTo(testCase.Result));
		}
	}
}