using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Bluarch.Win32.WindowHandle.WindowApi
{
    /// <summary>
    /// Bluarch.Win32.WindowHandle - Native Win32 API Wrapper for advanced window management.
    /// </summary>
    /// <remarks>
    /// This class library is developed as part of the Bluarch project by Kristian Holm Buch, Bluagentis.
    /// It provides direct access to Win32 API functions for querying, manipulating, and controlling window behavior in Windows environments.
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
    public static class WindowQuery
    {
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

        /// <summary>
        /// Retrieves the visible window title text.
        /// </summary>
        public static string GetWindowTextSafe(IntPtr hWnd)
        {
            var sb = new StringBuilder(512);
            GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        /// <summary>
        /// Retrieves the class name of the specified window.
        /// </summary>
        public static string GetClassNameSafe(IntPtr hWnd)
        {
            var sb = new StringBuilder(512);
            GetClassName(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        /// <summary>
        /// Retrieves the top-left client area coordinates of the window, excluding window borders and title bar.
        /// </summary>
        /// <param name="hWnd">Handle to the target window.</param>
        /// <returns>POINT struct containing X and Y screen coordinates of the client area's top-left corner.</returns>
        public static POINT GetTopLeftWithoutBorder(IntPtr hWnd)
        {
            POINT topLeft = new POINT();
            if (ClientToScreen(hWnd, ref topLeft))
            {
                return topLeft;
            }
            return new POINT { X = -1, Y = -1 };
        }
    }
}
