namespace project_euler.Test
{
	public class FiboEvenSumTest
	{
		public record FiboEvenSumResultTestCase(
			uint InputNumber,
			uint Result);

		private static readonly List<FiboEvenSumResultTestCase> testCases =
			[
			new (8, 10),
			new (10, 10),
			new (34, 44),
			new (60, 44),
			new (1000, 798),
			new (100000, 60696),
			new (4000000, 4613732),
			];

		[TestCaseSource(nameof(testCases))]
		public void FiboEvenSumResultTest(FiboEvenSumResultTestCase testCase)
		{
			Assert.That(Functions.FiboEvenSum(testCase.InputNumber), Is.EqualTo(testCase.Result));
		}

		[TestCaseSource(nameof(testCases))]
		public void FiboEvenSumResultIsEvenNumberTest(FiboEvenSumResultTestCase testCase)
		{
			Assert.That(Functions.FiboEvenSum(testCase.InputNumber) % 2, Is.EqualTo(0));
		}
	}
}
