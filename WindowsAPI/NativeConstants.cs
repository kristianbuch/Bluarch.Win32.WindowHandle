

using System;

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

    public static class NativeConstants
    {
        #region HWND Constants

        /// <summary>Places the window above all non-topmost windows.</summary>
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        /// <summary>Places the window above all non-topmost windows but below all topmost windows.</summary>
        public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

        #endregion

        #region ShowWindow Commands

        /// <summary>Hides the window and activates another window.</summary>
        public const int SW_HIDE = 0;

        /// <summary>Activates and displays a window. If the window is minimized or maximized, the system restores it.</summary>
        public const int SW_SHOWNORMAL = 1;

        /// <summary>Activates the window and displays it as a minimized window.</summary>
        public const int SW_SHOWMINIMIZED = 2;

        /// <summary>Maximizes the specified window.</summary>
        public const int SW_MAXIMIZE = 3;

        /// <summary>Displays a window in its most recent size and position. This value is similar to SW_SHOWNORMAL, except the window is not activated.</summary>
        public const int SW_SHOWNOACTIVATE = 4;

        /// <summary>Activates the window and displays it in its current size and position.</summary>
        public const int SW_SHOW = 5;

        /// <summary>Minimizes the specified window and activates the next top-level window in the Z order.</summary>
        public const int SW_MINIMIZE = 6;

        /// <summary>Activates and displays the window. If the window is minimized or maximized, the system restores it to its original size and position.</summary>
        public const int SW_RESTORE = 9;

        /// <summary>Sets the show state based on the SW_ value specified in the STARTUPINFO structure passed to the CreateProcess function by the program that started the application.</summary>
        public const int SW_SHOWDEFAULT = 10;

        #endregion

        #region SetWindowPos Flags

        /// <summary>Retains the current size (ignores the cx and cy parameters).</summary>
        public const uint SWP_NOSIZE = 0x0001;

        /// <summary>Retains the current position (ignores X and Y parameters).</summary>
        public const uint SWP_NOMOVE = 0x0002;

        /// <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
        public const uint SWP_NOZORDER = 0x0004;

        /// <summary>Makes the window visible.</summary>
        public const uint SWP_SHOWWINDOW = 0x0040;

        #endregion
    }
}
