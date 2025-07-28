using System;
using System.Runtime.InteropServices;

namespace Bluarch.Win32.WindowHandle.WindowApi
{
    /// <summary>
    /// Provides native Win32 API methods for manipulating window position, z-order, and visibility.
    /// </summary>
    /// <remarks>
    /// This class is part of the Bluarch.Win32.WindowHandle project by Kristian Holm Buch, Bluagentis.
    /// It includes operations such as moving, positioning, and bringing windows to the foreground.
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
    public static class WindowOperations
    {
        /// <summary>
        /// Moves and resizes the specified window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="X">New left position.</param>
        /// <param name="Y">New top position.</param>
        /// <param name="Width">New width of the window.</param>
        /// <param name="Height">New height of the window.</param>
        /// <param name="Repaint">True to repaint the window after moving.</param>
        /// <returns>True if successful, otherwise false.</returns>
        [DllImport("user32.dll")]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int Width, int Height, bool Repaint);

        /// <summary>
        /// Changes the position and size of the specified window. Can also change the window’s Z-order.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="hWndInsertAfter">Handle to the window to precede in Z order, or a special value (e.g., HWND_TOPMOST).</param>
        /// <param name="X">New X position.</param>
        /// <param name="Y">New Y position.</param>
        /// <param name="cx">New width.</param>
        /// <param name="cy">New height.</param>
        /// <param name="uFlags">Flags that define which parameters to use (e.g., SWP_NOSIZE).</param>
        /// <returns>True if successful, otherwise false.</returns>
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        /// <summary>
        /// Brings the specified window to the foreground and activates it.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>True if successful, otherwise false.</returns>
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Brings the specified window to the top of the Z-order.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>True if successful, otherwise false.</returns>
        [DllImport("user32.dll")]
        public static extern bool BringWindowToTop(IntPtr hWnd);
    }
}
