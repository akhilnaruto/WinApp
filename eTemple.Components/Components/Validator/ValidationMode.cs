using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Text;

namespace eTemple.Components
{
    /// <summary>
    /// ValidationMode, can use FocusChange and Submit combination.
    /// </summary>
    [Flags]
    [Editor(typeof(eTemple.Components.Design.FlagsEditor), typeof(UITypeEditor))]
    public enum ValidationMode
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0x0000,
        /// <summary>
        /// Allow focus change to next control
        /// </summary>
        FocusChange = 0x0001,
        /// <summary>
        /// Validate controls when user click "OK" or "Yes" button.
        /// </summary>
        Submit = 0x0002,
    }
}
