using System;
using System.Runtime.InteropServices;

namespace Bluarch.Win32.WindowHandle.WindowApi
{
    /// <summary>
    /// Provides access to Win32 window state management functions, such as showing, minimizing, restoring, and querying state.
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
    public static class WindowState
    {
        /// <summary>
        /// Sets the specified window's show state. This function posts a message and returns immediately.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nCmdShow">Control flag (see NativeConstants, e.g. SW_SHOW, SW_MINIMIZE).</param>
        /// <returns>True if successful; otherwise, false.</returns>
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// Sets the show state of a window asynchronously.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nCmdShow">Control flag (see NativeConstants).</param>
        /// <returns>True if successful; otherwise, false.</returns>
        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// Minimizes (but does not destroy) the specified window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>True if successful; otherwise, false.</returns>
        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hWnd);

        /// <summary>
        /// Determines whether the specified window is minimized (iconic).
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>True if the window is minimized; otherwise, false.</returns>
        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        /// <summary>
        /// Determines whether the specified window is maximized.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>True if the window is maximized; otherwise, false.</returns>
        [DllImport("user32.dll")]
        public static extern bool IsZoomed(IntPtr hWnd);
    }
}