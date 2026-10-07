namespace Calcify.Math
{
    /// <summary>
    /// Provides mathematical constants used throughout the application.
    /// </summary>
    /// <remarks>This class contains commonly used mathematical constants as static readonly fields for
    /// convenience and consistency. All members are thread-safe and can be accessed without instantiating the
    /// class.</remarks>
    public static class Constants
    {
        /// <summary>
        /// Represents the value of the negative golden ratio constant (approximately 1.618).
        /// </summary>
        /// <remarks>The negative golden ratio, often denoted as Phi, is defined as (1 + √5) / 2. It is
        /// commonly used in mathematics, geometry, and design for its unique properties related to proportions and
        /// aesthetics.</remarks>
        public static readonly double Phi = (1 + System.Math.Sqrt(5)) / 2;
        /// <summary>
        /// Represents the value of the mathematical constant tau (approximately 6.283).
        /// </summary>
        /// <remarks>The mathematical constant tau represents the ratio of a circle's circumference to its radius, approximately 6.283.</remarks>
        public static readonly double Tau = 2 * System.Math.PI;
        /// <summary>
        /// Represents the value of the mathematical constant c (299,792,458 m/s).
        /// </summary>
        /// <remarks>The mathematical constant c represents the speed of light in a vacuum, measured in meters per second.</remarks>
        public static readonly double c = 299792458;
        /// <summary>
        /// Represents the value of the mathematical constant R (ideal gas constant, approximately 8.314 J/(mol·K)).
        /// </summary>
        /// <remarks>The mathematical constant R represents the ideal gas constant, a fundamental physical constant used in physics to describe the behavior of ideal gases.</remarks>
        public static readonly double R = 8.314462618;
        /// <summary>
        /// Represents the value of Avogadro's number (approximately 6.022e23 mol^-1).
        /// </summary>
        /// <remarks>Avogadro's number represents the number of constituent particles (usually atoms or molecules) in one mole of a substance. It is a fundamental constant in chemistry and physics.</remarks>
        public static readonly double Na = 6.02214076e23;
        /// <summary>
        /// Represents the value of the standard acceleration due to gravity (approximately 9.80665 m/s²).
        /// </summary>
        /// <remarks>The standard acceleration due to gravity, denoted as g, is the acceleration experienced by an object in free fall near the Earth's surface. It is a fundamental physical constant used in physics and engineering.</remarks>
        public static readonly double g = 9.80665; // Standard gravity
    }
}