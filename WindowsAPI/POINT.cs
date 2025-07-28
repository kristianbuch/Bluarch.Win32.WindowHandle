using System;
using System.Runtime.InteropServices;

namespace Bluarch.Win32.WindowHandle.WindowApi
{
    /// <summary>
    /// Win32 POINT structure representing a 2D screen or client coordinate.
    /// </summary>
    /// <remarks>
    /// Used for screen position and client area measurements in native Win32 APIs.
    /// </remarks>
    /// <author>Kristian Holm Buch</author>
    /// <company>Bluagentis</company>
    /// <version>1.0.0</version>
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
    /// This struct is provided "as is" without warranty of any kind. Use at your own risk.
    /// </usage>
    /// <exceptions>
    /// Tjellesen Max Jenne A/S (TMJ) has exclusive rights to use this struct in their internal systems.
    /// Commercial use is prohibited without prior written consent from the author.
    /// </exceptions>
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public override string ToString() => $"X={X}, Y={Y}";
    }
}
