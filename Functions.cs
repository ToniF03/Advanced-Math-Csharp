using System;

namespace Calcify.Classes.Math
{
    /// <summary>
    /// Provides mathematical utility methods for calculating factorials and combinations.
    /// </summary>
    /// <remarks>The static methods in the Functions class support common combinatorial calculations, such as
    /// computing the factorial of a non-negative number and determining the number of possible combinations for a given
    /// set size. All methods validate input parameters and throw exceptions for invalid arguments. These methods are
    /// thread-safe as they do not maintain any internal state.</remarks>
    class Functions
    {
        /// <summary>
        /// Returns the factorial value of number greater than zero.
        /// </summary>
        /// <param name="d">A number greater than or equal to 0, but less than or equal to System.Double.MaxValue.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double Factorial(double d)
        {
            if (d < 0)
                throw new ArgumentOutOfRangeException();
            else if (d == 0)
                return 1;
            else
            {
                double result = 0;
                for (double n = d; n > 0; n--)
                {
                    if (result == 0) result = n;
                    else result *= n;
                }
                return result;
            }

        }

        /// <summary>
        /// Calculates the number of combinations that can be made by selecting a subset of size r from a set of size n.
        /// </summary>
        /// <param name="n">The total number of items in the set. Must be greater than or equal to <paramref name="r"/>.</param>
        /// <param name="r">The number of items to select from the set. Must be less than or equal to <paramref name="n"/>.</param>
        /// <returns>The number of possible combinations as a double-precision floating-point value.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="n"/> is less than <paramref name="r"/>.</exception>
        public static double nCr(int n, int r)
        {
            if (n < r)
                throw new ArgumentException();
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        /// <summary>
<<<<<<< Updated upstream
        /// Returns the sign of a double-precision floating-point number.
        /// </summary>
        /// <param name="d">The double-precision floating-point number to evaluate.</param>
        /// <returns>1 if the number is positive, -1 if it is negative, and 0 if it is zero.</returns>
=======
        /// Returns the remainder of dividing <paramref name="a"/> by <paramref name="b"/>.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The remainder produced by the % operator.</returns>
        /// <exception cref="DivideByZeroException">
        /// Thrown when <paramref name="b"/> is zero.
        /// </exception>
        public static double Modulo(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("The divisor cannot be zero.");
            return a % b;
        }

        /// <summary>
        /// Determines whether a value has no fractional part.
        /// </summary>
        /// <param name="d">The value to check.</param>
        /// <returns>
        /// <see langword="true"/> if the remainder after dividing <paramref name="d"/> by 1 is zero;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public static bool isInteger(double d)
        {
            return d % 1 == 0;
        }

        /// <summary>
        /// Raises a value to the power of one third.
        /// </summary>
        /// <param name="d">The value to raise to the power of one third.</param>
        /// <returns>The result of raising <paramref name="d"/> to the power of one third.</returns>
        /// <remarks>
        /// The result follows <see cref="System.Math.Pow(double, double)"/> semantics; a negative
        /// input produces <see cref="double.NaN"/>.
        /// </remarks>
        public static double Cbrt(double d)
        {
            return System.Math.Pow(d, 1.0 / 3.0);
        }

        /// <summary>
        /// Returns the sign of a value.
        /// </summary>
        /// <param name="d">The value to evaluate.</param>
        /// <returns>
        /// 1 if <paramref name="d"/> is positive, -1 if it is negative, or 0 otherwise.
        /// </returns>
>>>>>>> Stashed changes
        public static double sign(double d)
        {
            if (d > 0) return 1;
            else if (d < 0) return -1;
            else return 0;
        }

<<<<<<< Updated upstream


        /// <summary>
        /// Returns the cube root of a double-precision floating-point number.
        /// </summary>
        /// <param name="d">The double-precision floating-point number to evaluate.</param>
        /// <returns>The cube root of the number as a double-precision floating-point value.</returns>
        public static double Cbrt(double d)
        {
            return System.Math.Pow(d, 1.0 / 3.0);
        }

        /// <summary>
        /// Returns the inverse hyperbolic cosine of a double-precision floating-point number.
        /// </summary>
        /// <param name="d">The double-precision floating-point number to evaluate.</param>
        /// <returns>The inverse hyperbolic cosine of the number as a double-precision floating-point value.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double Acosh(double d)
        {
            if (d < 1)
                throw new ArgumentOutOfRangeException();
            return System.Math.Log(d + System.Math.Sqrt(d * d - 1));
        }

        /// <summary>
        /// Returns the inverse hyperbolic sine of a double-precision floating-point number.
        /// </summary>
        /// <param name="d">The double-precision floating-point number to evaluate.</param>
        /// <returns>The inverse hyperbolic sine of the number as a double-precision floating-point value.</returns>
=======
        /// <summary>
        /// Computes the inverse hyperbolic sine of a value.
        /// </summary>
        /// <param name="d">The value to evaluate.</param>
        /// <returns>The inverse hyperbolic sine of <paramref name="d"/>.</returns>
>>>>>>> Stashed changes
        public static double Asinh(double d)
        {
            return System.Math.Log(d + System.Math.Sqrt(d * d + 1));
        }

        /// <summary>
<<<<<<< Updated upstream
        /// Returns the inverse hyperbolic tangent of a double-precision floating-point number.
        /// </summary>
        /// <param name="d">The double-precision floating-point number to evaluate.</param>
        /// <returns>The inverse hyperbolic tangent of the number as a double-precision floating-point value.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double Atanh(double d)
        {
            if (d <= -1 || d >= 1)
                throw new ArgumentOutOfRangeException();
=======
        /// Computes the inverse hyperbolic cosine of a value.
        /// </summary>
        /// <param name="d">A value greater than or equal to 1.</param>
        /// <returns>The inverse hyperbolic cosine of <paramref name="d"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="d"/> is less than 1.
        /// </exception>
        public static double Acosh(double d)
        {
            if (d < 1)
                throw new ArgumentOutOfRangeException("The input value must be greater than or equal to 1.");
            return System.Math.Log(d + System.Math.Sqrt(d * d - 1));
        }

        /// <summary>
        /// Computes the inverse hyperbolic tangent of a value.
        /// </summary>
        /// <param name="d">A value in the open interval (-1, 1).</param>
        /// <returns>The inverse hyperbolic tangent of <paramref name="d"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="d"/> is less than or equal to -1, or greater than or equal to 1.
        /// </exception>
        public static double Atanh(double d)
        {
            if (d <= -1 || d >= 1)
                throw new ArgumentOutOfRangeException("The input value must be in the range (-1, 1).");
>>>>>>> Stashed changes
            return 0.5 * System.Math.Log((1 + d) / (1 - d));
        }

        /// <summary>
<<<<<<< Updated upstream
        /// Returns the modulo of two double-precision floating-point numbers, ensuring a non-negative result.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor. Must not be zero.</param>
        /// <returns>A value greater than or equal to zero and less than the absolute value of <paramref name="b"/>.</returns>
        /// <exception cref="ArgumentException"><paramref name="b"/> is zero.</exception>
        public static double modulo(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("The divisor cannot be zero.", nameof(b));
            double result = (((a % b) + b) % b);
            if (result < 0)
                result += System.Math.Abs(b);
            return result;
        }

        /// <summary>
        /// Determines whether a double-precision floating-point number is an integer (i.e., has no fractional part).
        /// </summary>
        /// <param name="d">The double-precision floating-point number to check.</param>
        /// <returns><c>true</c> if the number is an integer; otherwise, <c>false</c>.</returns>
        public static bool isInteger(double d)
        {
            return d % 1 == 0;
        }

        /// <summary>
        /// Calculates the number of permutations of r items selected from a set of n items.
        /// </summary>
        /// <param name="n">The total number of items.</param>
        /// <param name="r">The number of items to select.</param>
        /// <returns>The number of permutations.</returns>
        /// <exception cref="ArgumentException"></exception>
=======
        /// Calculates the number of ordered selections of <paramref name="r"/> items from
        /// <paramref name="n"/> items, without replacement.
        /// </summary>
        /// <param name="n">The total number of items.</param>
        /// <param name="r">The number of items selected.</param>
        /// <returns>The permutation count, calculated as n! / (n - r)!, as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="n"/> is less than <paramref name="r"/>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if a negative factorial argument is evaluated.
        /// </exception>
>>>>>>> Stashed changes
        public static double Permutation(int n, int r)
        {
            if (n < r)
                throw new ArgumentException("n must be greater than or equal to r.");
            return Factorial(n) / Factorial(n - r);
        }

<<<<<<< Updated upstream
=======
        /// <summary>
        /// Calculates the number of ways to select <paramref name="r"/> items from
        /// <paramref name="n"/> items, without regard to order.
        /// </summary>
        /// <param name="n">The total number of items.</param>
        /// <param name="r">The number of items selected.</param>
        /// <returns>The combination count, calculated as n! / (r! * (n - r)!), as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="n"/> is less than <paramref name="r"/>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if a negative factorial argument is evaluated.
        /// </exception>
>>>>>>> Stashed changes
        public static double Combination(int n, int r)
        {
            if (n < r)
                throw new ArgumentException("n must be greater than or equal to r.");
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

<<<<<<< Updated upstream
        public static double CombinationA(int n, int r)
        {
            if (n < r)
                throw new ArgumentException("n must be greater than or equal to r.");
            return Factorial(r + n - 1) / (Factorial(r) * Factorial(n - 1));
=======
        /// <summary>
        /// Calculates the number of combinations of <paramref name="r"/> selections from
        /// <paramref name="n"/> types when selections may be repeated.
        /// </summary>
        /// <param name="n">The number of available types; must be greater than zero.</param>
        /// <param name="r">The number of selections; must be non-negative.</param>
        /// <returns>The combination count with repetition, calculated as (n + r - 1)! / (r! * (n - 1)!), as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="n"/> or <paramref name="r"/> is negative.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="n"/> is zero, because the calculation evaluates a negative factorial argument.
        /// </exception>
        public static double CombinationA(int n, int r)
        {
            if (n < 0 || r < 0)
                throw new ArgumentException("n and r must be non-negative.");
            return Factorial(n + r - 1) / (Factorial(r) * Factorial(n - 1));
>>>>>>> Stashed changes
        }
    }
}
