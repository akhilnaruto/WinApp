using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using eTemple.Components.Properties;

namespace eTemple.Components.Design
{
    #region FlagEditor
    public sealed partial class FlagsEditor : UITypeEditor
    {
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        public FlagsEditor()
        {
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            // Validate parameter(s).
            if (provider == null)
            {
                return value;
            }
            if (value == null)
            {
                return value;
            }

            // Validate value is a enum type with Flags attribute.
            if (!value.GetType().IsEnum)
            {
                return value;
            }
            object[] attributes = value.GetType().GetCustomAttributes(typeof(FlagsAttribute), false);
            if ((attributes == null)
               || (attributes.Length == 0))
            {
                return value;
            }

            // Show panel.
            IWindowsFormsEditorService service = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (service != null)
            {
                FlagsEditorControl control = new FlagsEditorControl(value);
                service.DropDownControl(control);

                // Create new enum value.
                Type type = value.GetType();
                object newValue = Activator.CreateInstance(type);
                FieldInfo field = type.GetFields(BindingFlags.Public | BindingFlags.Instance)[0];
                field.SetValue(newValue, control.EditValue);

                control.Dispose();
                return newValue;
            }
            else
            {
                return value;
            }
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;

        }
    }
    #endregion FlagEditor

    #region FlagEditorPanel
    partial class FlagsEditor
    {
        private sealed class FlagsEditorControl : UserControl
        {
            private object editValue;
            public object EditValue
            {
                get
                {
                    return this.editValue;
                }
            }

            public FlagsEditorControl(object editValue)
            {
                this.editValue = editValue;

                CustomComponent();
                Initialize();
            }

            private void CustomComponent()
            {
                this.btnNone = new CheckBox();
                this.clbElements = new CheckedListBox();

                //
                // btnNone
                //
                this.btnNone.Text = Resources.NONE;
                this.btnNone.Appearance = Appearance.Button;
                this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.btnNone.Dock = DockStyle.Top;
                this.btnNone.Click += new EventHandler(btnNone_Click);
                //
                // clbElements
                //
                this.clbElements.Dock = DockStyle.Fill;
                this.clbElements.CheckOnClick = true;
                this.clbElements.IntegralHeight = false;
                this.clbElements.ItemCheck += new ItemCheckEventHandler(clbElements_ItemCheck);
                //
                // FlagsEditorControl
                //
                this.Controls.Add(this.clbElements);
                this.Controls.Add(this.btnNone);
            }

            private void Initialize()
            {
                Type type = this.editValue.GetType();
                // Gets all enumeration members.
                FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public);
                foreach (FieldInfo field in fields)
                {
                    // Add all enumeration members except none.
                    int value = (int)field.GetValue(this.editValue);
                    if (value != 0)
                    {
                        if ((value & (int)this.editValue) == value)
                        {
                            // add current enumeration member and check it if value set bit of it.
                            this.clbElements.Items.Add(field.Name, true);
                        }
                        else
                        {
                            // add current enumeration member.
                            this.clbElements.Items.Add(field.Name, false);
                        }
                    }
                }
            }

            private void btnNone_Click(object sender, EventArgs e)
            {
                this.btnNone.Enabled = false;
                // UnSelected all items.
                this.clbElements.BeginUpdate();
                for (int i = 0; i < this.clbElements.Items.Count; i++)
                {
                    this.clbElements.SetItemChecked(i, false);
                }
                this.clbElements.EndUpdate();
                // Set enum value to 0, means "None".
                Type type = this.editValue.GetType();
                FieldInfo field = type.GetFields()[0];
                field.SetValue(this.editValue, 0);
            }

            private void clbElements_ItemCheck(object sender, ItemCheckEventArgs e)
            {
                string name = this.clbElements.Items[e.Index] as string;
                // Get item value.
                Type type = this.editValue.GetType();
                int itemValue = (int)type.GetField(name).GetValue(this.editValue);

                // Set new value.
                if (e.NewValue == CheckState.Checked)
                {
                    // Add item value.
                    int value = (int)this.editValue | itemValue;
                    // Before item selected, the value is non 0, hence, after set a value, it will
                    // equal to item value, in other words, the original value is 0. 
                    if (value == itemValue)
                    {
                        this.btnNone.Enabled = true;
                        this.btnNone.Checked = false;
                    }

                    // A enum Public and Instance field indicates its int value.                
                    FieldInfo field = type.GetFields(BindingFlags.Public | BindingFlags.Instance)[0];
                    field.SetValue(this.editValue, value);
                }
                else
                {
                    // Sub item value
                    int value = (int)this.editValue & (~itemValue);
                    // Unselected items.
                    if (value == 0)
                    {
                        this.btnNone.Enabled = false;
                        this.btnNone.Checked = true;
                    }

                    // A enum Public and Instance field indicates its int value.                
                    FieldInfo field = type.GetFields(BindingFlags.Public | BindingFlags.Instance)[0];
                    field.SetValue(this.editValue, value);
                }
            }

            CheckBox btnNone;
            CheckedListBox clbElements;
        }
    }
    #endregion FlagEditorPanel
}
