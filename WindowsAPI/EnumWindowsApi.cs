/// <summary>
/// Bluarch.Win32.WindowHandle - Native Win32 API Wrapper for advanced window management.
/// </summary>
/// <remarks>
/// This class library is developed as part of the Bluarch project by Kristian Holm Buch, Bluagentis.
/// It provides direct access to Win32 API functions for querying, manipulating, and controlling window behavior in Windows environments.
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
/// This library is provided "as is" without warranty of any kind. Use at your own risk.
/// </usage>
/// <exceptions>
/// Tjellesen Max Jenne A/S (TMJ) has exclusive rights to use this library in their internal systems.
/// Commercial use is prohibited without prior written consent from the author.
/// </exceptions>

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Bluarch.Win32.WindowHandle.WindowApi
{
    public static class EnumWindowsApi
    {
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        public static List<IntPtr> GetAllVisibleWindows()
        {
            var result = new List<IntPtr>();
            EnumWindows((hWnd, lParam) =>
            {
                if (WindowQuery.IsWindowVisible(hWnd))
                    result.Add(hWnd);
                return true;
            }, IntPtr.Zero);
            return result;
        }
    }
}
