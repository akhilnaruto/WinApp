using System;
using System.Collections.Generic;
using System.Text;

namespace eTemple.Components
{
    /// <summary>
    /// Indicate the data type of control's text.
    /// </summary>
    public enum ValidationDataType
    {
        /// <summary>
        /// string type.
        /// </summary>
        String,
        /// <summary>
        /// int type.
        /// </summary>
        Integer,
        /// <summary>
        /// double type
        /// </summary>
        Double,
        /// <summary>
        /// DateTime type
        /// </summary>
        Date,
        /// <summary>
        /// decimal type.
        /// </summary>
        Currency
    }
}
