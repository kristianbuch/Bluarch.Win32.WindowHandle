using System.Runtime.InteropServices;

namespace Bluarch.Win32.WindowHandle.WindowApi
{
    /// <summary>
    /// Represents the coordinates of the upper-left and lower-right corners of a rectangle.
    /// Used by many native Win32 API functions, including window and screen region calculations.
    /// </summary>
    /// <remarks>
    /// Struct layout must match Win32 RECT definition.
    /// </remarks>
    /// <author>Kristian Holm Buch</author>
    /// <company>Bluagentis</company>
    /// <version>1.0.1</version>
    /// <date>2025-07-28</date>
    /// <location>Copenhagen, Denmark</location>
    /// <software>.NET 8.0, Visual Studio / VSCode</software>
    /// <copyright>
    /// © 2025 - Kristian Holm Buch, Bluagentis. All Rights Reserved.
    /// </copyright>
    /// <license>
    /// CC BY-NC-ND 4.0 (https://creativecommons.org/licenses/by-nc-nd/4.0/)
    /// </license>
    /// <email>kristian@bluagentis.com</email>
    /// <github>https://github.com/kristianbuch</github>
    /// <linkedin>https://linkedin.com/in/kristianbuch</linkedin>
    /// <usage>
    /// This library is provided "as is" without warranty of any kind. Use at your own risk.
    /// </usage>
    /// <exceptions>
    /// Tjellesen Max Jenne A/S (TMJ) has exclusive rights to use this library in their internal systems.
    /// Commercial use is prohibited without prior written consent from the author.
    /// </exceptions>

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        /// <summary>Specifies the x-coordinate of the upper-left corner.</summary>
        public int Left;

        /// <summary>Specifies the y-coordinate of the upper-left corner.</summary>
        public int Top;

        /// <summary>Specifies the x-coordinate of the lower-right corner.</summary>
        public int Right;

        /// <summary>Specifies the y-coordinate of the lower-right corner.</summary>
        public int Bottom;

        /// <summary>
        /// Gets the width of the rectangle (Right - Left).
        /// </summary>
        public int Width => Right - Left;

        /// <summary>
        /// Gets the height of the rectangle (Bottom - Top).
        /// </summary>
        public int Height => Bottom - Top;

        /// <summary>
        /// Returns a readable string representation of the rectangle.
        /// </summary>
        public override string ToString() =>
            $"X={Left}, Y={Top}, Width={Width}, Height={Height}";

        /// <summary>
        /// Initializes a new instance of the <see cref="RECT"/> struct.
        /// </summary>
        /// <param name="left">Left coordinate.</param>
        /// <param name="top">Top coordinate.</param>
        /// <param name="right">Right coordinate.</param>
        /// <param name="bottom">Bottom coordinate.</param>
        public RECT(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }
    }
}
