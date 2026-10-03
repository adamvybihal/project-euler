namespace project_euler
{
	public static class Functions
	{
		///////// Problem 1 //////////

		/// <summary>
		/// Calculates the sum of all natural numbers less than the specified number that are multiples of 3 or 5.
		/// </summary>
		/// <param name="number">Exclusive upper bound; natural numbers less than number are considered.</param>
		/// <returns>The sum of all multiples of 3 or 5 that are less than number.</returns>
		public static uint MultiplesOf3And5(uint number)
		{
			if (number == 0) return 0;

			return MultiplesOfXAndY(number, 3, 5);
		}

		/// <summary>
		/// Count integers strictly less than limit that are multiples of x or y using inclusion–exclusion.
		/// </summary>
		/// <remarks>The method decrements limit before computation; calling with limit == 0 wraps to uint.MaxValue.
		/// Uses x * y for the intersection rather than the least common multiple, so results may be incorrect when x and y
		/// are not coprime. Multiplication of x and y can overflow; inputs are not validated.</remarks>
		/// <param name="limit">Upper exclusive bound; only values strictly less than limit are considered.</param>
		/// <param name="x">First divisor used to count multiples.</param>
		/// <param name="y">Second divisor used to count multiples.</param>
		/// <returns>The number of integers less than limit that are divisible by x or y.</returns>
		public static uint MultiplesOfXAndY(uint limit, uint x, uint y)
		{
			limit--;

			return MultiplesOfX(limit, x) + 
				MultiplesOfX(limit, y) -
				MultiplesOfX(limit, x * y);
		}

		private static uint MultiplesOfX(uint limit, uint divisor)
		{
			uint count = limit / divisor;
			return divisor * count * (count + 1) / 2;
		}


		///////// Problem 2 //////////
		
	}
}
