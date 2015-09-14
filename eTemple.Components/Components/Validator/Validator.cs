using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Diagnostics;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using eTemple.Components.Design;
using eTemple.Components.Properties;

namespace eTemple.Components
{
    #region Extend Property
    /// <summary>
    /// This component validate controls text in represention.
    /// </summary>
    [ProvideProperty("Type", typeof(Control))]
    [ProvideProperty("DataType", typeof(Control))]
    [ProvideProperty("RequiredMessage", typeof(Control))]
    [ProvideProperty("RegularExpression", typeof(Control))]
    [ProvideProperty("RegularExpressionOptions", typeof(Control))]
    [ProvideProperty("RegularExpressionMessage", typeof(Control))]
    [ProvideProperty("ComparedControl", typeof(Control))]
    [ProvideProperty("CompareOperator", typeof(Control))]
    [ProvideProperty("CompareMessage", typeof(Control))]
    [ProvideProperty("RangeOfLowerBound", typeof(Control))]
    [ProvideProperty("RangeOfUpperBound", typeof(Control))]
    [ProvideProperty("RangeMessage", typeof(Control))]
    [ProvideProperty("CustomMessage", typeof(Control))]
    [ToolboxBitmap(typeof(Validator), "Validator.Toolbox.ico")]
    [ToolboxItemFilter("System.Windows.Forms")]
    [Designer(typeof(Validator.ValidatorDesigner), typeof(IDesigner))]
    public partial class Validator : Component, IExtenderProvider
    {
        #region Type
        [DefaultValue(eTemple.Components.ValidationType.None)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_TYPE")]
        [Localizable(true)]
        public ValidationType GetType(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.Type;
            }
            else
            {
                return ValidationType.None;
            }
        }
        public void SetType(Control control, ValidationType type)
        {
            if (this.infos.ContainsKey(control))
            {
                // Especially, in design mode and type is none, ask whether remove validation information.
                if ((DesignMode)
                 && (type == ValidationType.None))
                {
                    // Set right to left message box options.
                    MessageBoxOptions options = (MessageBoxOptions)0;
                    if (this.RightToLeft)
                    {
                        options = MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign;
                    }

                    if (MessageBox.Show(
                            Resources.VALIDATOR_REMOVEWARNING,
                            Resources.VALIDATOR_NAME,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1,
                            options) == DialogResult.Yes)
                    {
                        this.RemoveValidationInfo(control);
                    }
                }
                else
                {
                    this.infos[control].Type = type;
                }
            }
            else
            {
                this.AddValidationInfo(control);
                ValidationInfo info = this.infos[control];
                info.Type = type;
            }
        }

        [DefaultValue(ValidationDataType.String)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_DATATYPE")]
        [Localizable(true)]
        public ValidationDataType GetDataType(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.DataType;
            }
            else
            {
                return ValidationDataType.String;
            }
        }
        public void SetDataType(Control control, ValidationDataType dataType)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.DataType = dataType;
        }
        #endregion Type

        #region Required
        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_REQUIREDMESSAGE")]
        [Localizable(true)]
        public string GetRequiredMessage(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.RequiredMessage;
            }
            else
            {
                return null;
            }
        }
        public void SetRequiredMessage(Control control, string message)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.RequiredMessage = message;
        }
        #endregion Required

        #region Regular Expression
        [DefaultValue((string)null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_REGULAREXPRESSION")]
        [Localizable(true)]
        public string GetRegularExpression(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.RegularExpression;
            }
            else
            {
                return null;
            }
        }
        public void SetRegularExpression(Control control, string regularExpression)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.RegularExpression = regularExpression;
        }

        [DefaultValue(RegexOptions.None)]
        [Editor(typeof(eTemple.Components.Design.FlagsEditor), typeof(UITypeEditor))]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_REGULAREXPRESSIONOPTIONS")]
        [Localizable(true)]
        public RegexOptions GetRegularExpressionOptions(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.RegularExpressOptions;
            }
            else
            {
                return RegexOptions.None;
            }
        }
        public void SetRegularExpressionOptions(Control control, RegexOptions options)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.RegularExpressOptions = options;
        }


        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_REGULAREXPRESSIONMESSAGE")]
        [Localizable(true)]
        public string GetRegularExpressionMessage(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.RegularExpressionMessage;
            }
            else
            {
                return null;
            }
        }
        public void SetRegularExpressionMessage(Control control, string message)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.RegularExpressionMessage = message;
        }
        #endregion Regular expression

        #region Compare
        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_COMPARECONTROL")]
        [Localizable(true)]
        public Control GetComparedControl(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.ComparedControl;
            }
            else
            {
                return null;
            }
        }
        public void SetComparedControl(Control control, Control comparedControl)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.ComparedControl = comparedControl;
        }

        [DefaultValue(ValidationCompareOperator.DataTypeCheck)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_COMPAREOPERATOR")]
        [Localizable(true)]
        public ValidationCompareOperator GetCompareOperator(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.CompareOperator;
            }
            else
            {
                return ValidationCompareOperator.DataTypeCheck;
            }
        }
        public void SetCompareOperator(Control control, ValidationCompareOperator compareOperator)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.CompareOperator = compareOperator;
        }

        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_COMPAREMESSAGE")]
        [Localizable(true)]
        public string GetCompareMessage(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.CompareMessage;
            }
            else
            {
                return null;
            }
        }
        public void SetCompareMessage(Control control, string message)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.CompareMessage = message;
        }
        #endregion Compare

        #region Range
        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_RANGEOFLOWERBOUND")]
        [Localizable(true)]
        public string GetRangeOfLowerBound(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.RangeOfLowerBound;
            }
            else
            {
                return null;
            }
        }
        public void SetRangeOfLowerBound(Control control, string value)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.RangeOfLowerBound = value;
        }

        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_RANGEOFUPPERBOUND")]
        [Localizable(true)]
        public string GetRangeOfUpperBound(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.RangeOfUpperBound;
            }
            else
            {
                return null;
            }
        }
        public void SetRangeOfUpperBound(Control control, string value)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.RangeOfUpperBound = value;
        }

        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_RANGEMESSAGE")]
        [Localizable(true)]
        public string GetRangeMessage(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.RangeMessage;
            }
            else
            {
                return null;
            }
        }
        public void SetRangeMessage(Control control, string message)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.RangeMessage = message;
        }
        #endregion Range

        #region Custom
        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_VALIDATION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_VALIDATION_CUSTOMMESSAGE")]
        [Localizable(true)]
        public string GetCustomMessage(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                ValidationInfo info = this.infos[control];
                return info.CustomMessage;
            }
            else
            {
                return null;
            }
        }
        public void SetCustomMessage(Control control, string message)
        {
            if (!this.infos.ContainsKey(control))
            {
                this.AddValidationInfo(control);
            }

            ValidationInfo info = this.infos[control];
            info.CustomMessage = message;
        }
        #endregion Custom
    }
    #endregion Extend Property

    #region Interface method
    partial class Validator
    {
        public bool CanExtend(object extendee)
        {
            // Only accept textboxbase driver class(TextBox and RichTextBox) and ComboBox
            if (extendee is TextBoxBase || extendee is ComboBox)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    #endregion Interface method

    #region Field & Property
    partial class Validator
    {
        /// <summary>
        /// Custom validation, it will raise when set "Custom" flag of validation type.
        /// Set "Valid" to true in ValidationEventArgs if pass custom test, or else, false.
        /// </summary>
        [PropertyCategory("VALIDATOR_CATEGORY_ACTION")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_EVENT_CUSTOMVALIDATION")]
        public event EventHandler<ValidationEventArgs> CustomValidation;

        private Dictionary<Control, ValidationInfo> infos;
        private ErrorProvider errorProvider;

        private Form form;
        [DefaultValue(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_BEHAVIOR")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_BEHAVIOR_FORM")]
        [Localizable(true)]
        public Form Form
        {
            get
            {
                return this.form;
            }
            set
            {
                if (this.form != value)
                {
                    // Unregister previous form and register current form. 
                    if (this.form != null)
                    {
                        this.form.FormClosing -= new FormClosingEventHandler(validationForm_FormClosing);
                    }

                    this.form = value;

                    if (this.form != null)
                    {
                        this.form.FormClosing += new FormClosingEventHandler(validationForm_FormClosing);
                    }
                }
            }
        }

        private ValidationMode mode = ValidationMode.FocusChange | ValidationMode.Submit;
        /// <summary>
        /// Gets or sets validation mode for specified form.
        /// </summary>
        [DefaultValue(ValidationMode.FocusChange | ValidationMode.Submit)]
        [PropertyCategory("VALIDATOR_CATEGORY_BEHAVIOR")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_BEHAVIOR_MODE")]
        [Localizable(true)]
        public ValidationMode Mode
        {
            get
            {
                return this.mode;
            }
            set
            {
                this.mode = value;
            }
        }

        /// <summary>
        /// Gets or sets the Icon that is displayed next to a control 
        /// when an error description string has been set for the control.
        /// </summary>
        [ValidatorDefaultIconAttribute(null)]
        [PropertyCategory("VALIDATOR_CATEGORY_ERRORPROVIDER")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_ERRORPROVIDER_ICON")]
        [Localizable(true)]
        public Icon Icon
        {
            get
            {
                return errorProvider.Icon;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                errorProvider.Icon = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the component is 
        /// used in a locale that supports right-to-left fonts.
        /// </summary>
        [DefaultValue(false)]
        [PropertyCategory("VALIDATOR_CATEGORY_ERRORPROVIDER")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_ERRORPROVIDER_RIGHTTOLEFT")]
        [Localizable(true)]
        public bool RightToLeft
        {
            get
            {
                return errorProvider.RightToLeft;
            }
            set
            {
                errorProvider.RightToLeft = value;
            }
        }

        /// <summary>
        /// Gets or sets the rate at which the error icon flashes.
        /// </summary>
        [DefaultValue(250)]
        [PropertyCategory("VALIDATOR_CATEGORY_ERRORPROVIDER")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_ERRORPROVIDER_BLINKRATE")]
        [Localizable(true)]
        public int BlinkRate
        {
            get
            {
                return errorProvider.BlinkRate;
            }
            set
            {
                errorProvider.BlinkRate = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating when the error icon flashes.
        /// </summary>
        [DefaultValue(ErrorBlinkStyle.BlinkIfDifferentError)]
        [PropertyCategory("VALIDATOR_CATEGORY_ERRORPROVIDER")]
        [PropertyDescription("VALIDATOR_DESCRIPTION_ERRORPROVIDER_BLINKSTYLE")]
        [Localizable(true)]
        public ErrorBlinkStyle BlinkStyle
        {
            get
            {
                return errorProvider.BlinkStyle;
            }
            set
            {
                errorProvider.BlinkStyle = value;
            }
        }
    }
    #endregion Feild & Property

    #region Constructor & Destructor
    partial class Validator
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Validator()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="container">Container for current components</param>
        public Validator(IContainer container)
            : this()
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            container.Add(this);
        }

        private void Initialize()
        {
            this.infos = new Dictionary<Control, ValidationInfo>();
            this.errorProvider = new ErrorProvider(this.components);
        }
    }
    #endregion Constructor & Destructor

    #region Event
    partial class Validator
    {
        private void validationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.mode & ValidationMode.Submit) != ValidationMode.Submit)
            {
                return;
            }

            DialogResult dr = this.form.DialogResult;
            // Hook form closing event when verify input. Usually, we use "Yes" or "OK" button
            // to confirm user input.
            if ((dr == DialogResult.Yes)
             || (dr == DialogResult.OK))
            {
                if ((e.CloseReason == CloseReason.None)
                 && (!this.Validate()))
                {
                    e.Cancel = true;
                }
            }
        }

        private void control_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            ValidationInfo info = this.infos[control];

            info.Validate();

            // Decide whether can lost foucs.
            if (((this.mode & ValidationMode.FocusChange) != ValidationMode.FocusChange)
             && (info.HasError))
            {
                e.Cancel = true;
            }
        }


        private void info_CustomValidation(object sender, ValidationEventArgs e)
        {
            if (this.CustomValidation != null)
            {
                this.CustomValidation(this, e);
            }
        }
    }
    #endregion Event

    #region Method
    /// <summary>
    /// Method
    /// </summary>
    partial class Validator
    {
        /// <summary>
        /// Add a new validation info.
        /// </summary>
        /// <param name="control">Control for added.</param>
        public void AddValidationInfo(Control control)
        {
            if (!this.infos.ContainsKey(control))
            {
                control.Validating += new CancelEventHandler(control_Validating);
                // Register validation info CustomValidation event.
                ValidationInfo info = new ValidationInfo(control, this.errorProvider);
                info.CustomValidation += new EventHandler<ValidationEventArgs>(info_CustomValidation);
                this.infos.Add(control, info);
            }
        }

        /// <summary>
        /// Remove specified control validation info.
        /// </summary>
        /// <param name="control"></param>
        public void RemoveValidationInfo(Control control)
        {
            if (this.infos.ContainsKey(control))
            {
                this.infos.Remove(control);
                control.Validating -= new CancelEventHandler(control_Validating);
            }
        }

        /// <summary>
        /// Clear all validation info.
        /// </summary>
        public void ClearValidationInfos()
        {
            // Set right to left message box options.
            MessageBoxOptions options = (MessageBoxOptions)0;
            if (this.RightToLeft)
            {
                options = MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign;
            }

            if (MessageBox.Show(
                Resources.VALIDATOR_CLEARWARNING,
                Resources.VALIDATOR_NAME,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                options) == DialogResult.Yes)
            {
                Control[] controls = new Control[this.infos.Keys.Count];
                int i = 0;
                // Do not directly remove validation infomation in the loop.
                // because, when remove a item, it should be change index.
                foreach (Control control in this.infos.Keys)
                {
                    controls[i++] = control;
                }

                foreach (Control control in controls)
                {
                    this.RemoveValidationInfo(control);
                }
            }
        }

        /// <summary>
        /// Validate all controls.
        /// </summary>
        /// <returns>If all control validated successful return true, or else false.</returns>
        public bool Validate()
        {
            if ((this.mode & ValidationMode.FocusChange) == ValidationMode.FocusChange)
            {
                // Focus change mode.
                bool fail = false;
                foreach (Control control in this.infos.Keys)
                {
                    ValidationInfo info = this.infos[control];
                    info.Validate();
                    if (!fail)
                    {
                        fail = info.HasError;
                    }
                }

                return !fail;
            }
            else
            {
                // Not allow focus change.
                foreach (Control control in this.infos.Keys)
                {
                    ValidationInfo info = this.infos[control];
                    info.Validate();
                    if (info.HasError)
                    {
                        control.Focus();
                        return false;
                    }
                }

                return true;
            }
        }
    }
    #endregion Method

    #region Add on
    partial class Validator
    {
        /// <summary>
        /// No exposed.
        /// </summary>
        private sealed class ValidatorDefaultIconAttribute : DefaultValueAttribute
        {
            public ValidatorDefaultIconAttribute(object icon)
                : base(icon)
            {

            }

            public override object Value
            {
                get
                {
                    ErrorProvider errorProvider = new ErrorProvider();
                    Icon icon = errorProvider.Icon;
                    errorProvider.Dispose();
                    return icon;
                }
            }
        }

        private class ValidatorDesigner : ComponentDesigner
        {
            private class ValidatorActionList : DesignerActionList
            {
                private Validator validator;
                private DesignerActionItemCollection items;

                public ValidatorActionList(IComponent component)
                    : base(component)
                {
                    this.validator = component as Validator;
                }

                // notice: it has been called in GetSortedActionItem with literal.
                [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                private void ClearValidationInfos()
                {
                    validator.ClearValidationInfos();
                }

                public override DesignerActionItemCollection GetSortedActionItems()
                {
                    if (this.items == null)
                    {
                        items = new DesignerActionItemCollection();
                        DesignerActionHeaderItem TasksHead = new DesignerActionHeaderItem(Resources.VALIDATOR_ACTIONLIST_TASKS);
                        items.Add(new DesignerActionMethodItem(this, "ClearValidationInfos", Resources.VALIDATOR_ACTIONLIST_TASKS_CLEARVALIDATIONINFOS, TasksHead.Category, true));
                    }

                    return this.items;
                }
            }

            private DesignerActionListCollection actionLists;
            public override DesignerActionListCollection ActionLists
            {
                get
                {
                    if (this.actionLists == null)
                    {
                        this.actionLists = new DesignerActionListCollection();
                        this.actionLists.Add(new ValidatorActionList(this.Component));
                    }

                    return this.actionLists;
                }
            }

            private void ClearValidationInfo()
            {
                ((Validator)this.Component).ClearValidationInfos();
            }

            public override void InitializeNewComponent(System.Collections.IDictionary defaultValues)
            {
                // Set container form as validator's form.
                ((Validator)this.Component).Form = (Form)this.ParentComponent;

                base.InitializeNewComponent(defaultValues);
            }

        }
    }
    #endregion Add on
}
