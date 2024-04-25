using System.Globalization;

namespace ReSharp.Extensions
{
    /// <summary>
    /// Provides utility functions for value type of <see cref="float" />.
    /// </summary>
    public static class SingleUtility
    {
        /// <summary>
        /// Converts the string representation of a number to its single-precision floating-point number equivalent with number style <see cref="NumberStyles.Any"/>
        /// and format provider <see cref="CultureInfo.InvariantCulture"/>. A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string representing a number to convert.</param>
        /// <param name="result">When this method returns, contains single-precision floating-point number equivalent to the numeric value or symbol contained in <c>s</c>,
        /// if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <c>s</c> parameter is <c>null</c> or <see cref="string.Empty"/>
        /// or is not a number in a valid format. It also fails on .NET Framework and .NET Core 2.2 and earlier versions if s represents a number less than <see cref="float.MinValue"/>
        /// or greater than <see cref="float.MaxValue"/>. This parameter is passed uninitialized; any value originally supplied in result will be overwritten.</param>
        /// <returns><c>true</c> if <c>s</c> was converted successfully; otherwise, <c>false</c>.</returns>
        public static bool GenericTryParse(string s, out float result) => float.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
    }
}