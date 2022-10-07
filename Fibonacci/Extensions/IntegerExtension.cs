namespace Fibonacci.Extensions
{
    public static class IntegerExtension
    {
        /// <summary>
        /// Get a Fibonacci value for a given position
        /// </summary>
        /// <param name="n">The position to calculate</param>
        /// <returns>The Fibonacci value</returns>
        public static int GetFibonacciValue(this int n)
        {
            if (n is 0 or 1)
                return n;

            return GetFibonacciValue(n - 1) + GetFibonacciValue(n - 2);
        }
    }
}
