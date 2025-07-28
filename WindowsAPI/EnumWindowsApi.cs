using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Bluarch.Win32.WindowHandle.WindowApi
{
    /// <summary>
    /// Provides access to Win32 API for enumerating top-level windows.
    /// </summary>
    /// <remarks>
    /// Part of the Bluarch project – developed by Kristian Holm Buch, Bluagentis.
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
    public static class EnumWindowsApi
    {
        /// <summary>
        /// Delegate for the callback function used by <see cref="EnumWindows"/>.
        /// </summary>
        /// <param name="hWnd">Handle to a top-level window.</param>
        /// <param name="lParam">Application-defined value passed to EnumWindows.</param>
        /// <returns>True to continue enumeration, false to stop.</returns>
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        /// <summary>
        /// Enumerates all top-level windows on the screen by passing handles to a callback function.
        /// </summary>
        /// <param name="lpEnumFunc">A callback function.</param>
        /// <param name="lParam">Application-defined value to be passed to the callback function.</param>
        /// <returns>True if successful, otherwise false.</returns>
        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// Retrieves a list of all visible top-level window handles.
        /// </summary>
        /// <returns>List of <see cref="IntPtr"/> handles to visible windows.</returns>
        public static List<IntPtr> GetAllVisibleWindows()
        {
            var result = new List<IntPtr>();

            EnumWindows((hWnd, _) =>
            {
                if (WindowQuery.IsWindowVisible(hWnd))
                {
                    result.Add(hWnd);
                }
                return true; // continue enumeration
            }, IntPtr.Zero);

            return result;
        }
    }
}
