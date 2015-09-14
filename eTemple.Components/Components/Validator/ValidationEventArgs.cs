﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace eTemple.Components
{
    /// <summary>
    /// Provider data for custom validation - CustomValidation event.
    /// </summary>
    public sealed class ValidationEventArgs:EventArgs
    {
        private Control control;
        /// <summary>
        /// Gets control which when raise CustomValidation event.
        /// </summary>
        public Control Control
        {
            get
            {
                return this.control;
            }
        }

        /// <summary>
        /// Gets or Sets a value indicating whether control text pass custom code test.
        /// </summary>
        private bool valid = true;
        public bool Valid
        {
            get
            {
                return this.valid;
            }
            set
            {
                this.valid = value;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="control">Validated control instance.</param>
        public ValidationEventArgs(Control control)
        {
            this.control = control;
        }
    }
}
