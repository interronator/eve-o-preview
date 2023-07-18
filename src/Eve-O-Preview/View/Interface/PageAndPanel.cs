using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EveOPreview.View
{
    public class PageAndPanel
    {
        public PageAndPanel(MainForm InParentForm)
        {
            ParentForm = InParentForm;

            SetPage();
            SetPanel();

            Panel.SuspendLayout();
        }

        protected void SetPanelSettings(string InName, Point InLocation, Size InSize, int InTabIndex)
        {
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Dock = DockStyle.Fill;
            Panel.Margin = new Padding(4, 5, 4, 5);
        }

        protected void SetPageSettings(string InName, string InText, Point InLocation, Size InSize, int InTabIndex)
        {
            Page.BackColor = SystemColors.Control;
            Page.Controls.Add(Panel);
            Page.Location = InLocation;
            Page.Margin = new Padding(4, 5, 4, 5);
            Page.Name = InName;
            Page.Padding = new Padding(4, 5, 4, 5);
            Page.Size = InSize;
            Page.TabIndex = InTabIndex;
            Page.Text = InText;
        }

        protected virtual void SetPage() { }
        protected virtual void SetPanel() { }

        public void SetCheckBox(CheckBox InCheckBox, string Name, string Text, Point InLocation, Padding InPadding, Size InSize, int TabIndex, EventHandler Handler)
        {
            SetGeneralControlMembers(InCheckBox, Name, Text, InLocation, InPadding, InSize, TabIndex);

            InCheckBox.UseVisualStyleBackColor = true;
            InCheckBox .CheckedChanged += new System.EventHandler(Handler);
        }

        public void CreateRadioButton(string Name, string Text, Point InLocation, Padding InPadding, Size InSize, int TabIndex, EventHandler Handler)
        {
            RadioButton NewRadioButton = new RadioButton();

            SetGeneralControlMembers(NewRadioButton, Name, Text, InLocation, InPadding, InSize, TabIndex);
           
            NewRadioButton.TabStop = true;
            NewRadioButton.UseVisualStyleBackColor = true;
            NewRadioButton.CheckedChanged += new System.EventHandler(Handler);

        }

        private void SetGeneralControlMembers(Control InControl, string Name, string Text, Point InLocation, Padding InPadding, Size InSize, int TabIndex)
        {
            InControl.Name = Name;
            InControl.Text = Text;
            InControl.AutoSize = true;
            InControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            InControl.Location = InLocation;
            InControl.Size = InSize;
            InControl.TabIndex = TabIndex;

            Controls.Add(InControl);
        }

        public TabPage Page = new TabPage();
        public Panel Panel = new Panel();
        public List<Control> Controls = new List<Control>();
        protected MainForm ParentForm;
    }

    public class GeneralTab : PageAndPanel
    {
        public GeneralTab(MainForm InParentForm) : base(InParentForm)
        {
            SetCheckBox(MinimizeInactiveClientsCheckBox, "MinimizeInactiveClientsCheckBox", "Minimize inactive EVE clients", new Point(12, 122), new Padding(4, 5, 4, 5), new Size(239, 24), 24, ParentForm.OptionChanged_Handler);
            SetCheckBox(EnableClientLayoutTrackingCheckBox, "EnableClientLayoutTrackingCheckBox", "Track client locations", new Point(12, 48), new Padding(4, 5, 4, 5), new Size(182, 24), 19, ParentForm.OptionChanged_Handler);
            SetCheckBox(HideActiveClientThumbnailCheckBox, "HideActiveClientThumbnailCheckBox", "Hide preview of active EVE client", new Point(12, 85), new Padding(4, 5, 4, 5), new Size(266, 24), 20, ParentForm.OptionChanged_Handler);
            SetCheckBox(ShowThumbnailsAlwaysOnTopCheckBox, "ShowThumbnailsAlwaysOnTopCheckBox", "Previews always on top", new Point(12, 159), new Padding(4, 5, 4, 5), new Size(197, 24), 21, ParentForm.OptionChanged_Handler);
            SetCheckBox(HideThumbnailsOnLostFocusCheckBox, "HideThumbnailsOnLostFocusCheckBox", "Hide previews when EVE client is not active", new Point(12, 196), new Padding(4, 5, 4, 5), new Size(340, 24), 22, ParentForm.OptionChanged_Handler);
            SetCheckBox(EnablePerClientThumbnailsLayoutsCheckBox, "EnablePerClientThumbnailsLayoutsCheckBox", "Unique layout for each EVE client", new Point(12, 233), new Padding(4, 5, 4, 5), new Size(272, 24), 23, ParentForm.OptionChanged_Handler);
            SetCheckBox(MinimizeToTrayCheckBox, "MinimizeToTrayCheckBox", "Minimize to System Tray", new Point(12, 11), new Padding(4, 5, 4, 5), new Size(205, 24), 18, ParentForm.OptionChanged_Handler);
        }

        protected override void SetPage()
        {
            SetPageSettings("GeneralTabPage", "General", new Point(124, 4), new Size(457, 327), 0);

            base.SetPage();
        }

        protected override void SetPanel()
        {
            SetPanelSettings("GeneralSettingsPanel", new Point(4, 5), new Size(449, 317), 18);

            base.SetPanel();
        }

        public CheckBox MinimizeInactiveClientsCheckBox = new CheckBox();
        public CheckBox EnableClientLayoutTrackingCheckBox = new CheckBox();
        public CheckBox HideActiveClientThumbnailCheckBox = new CheckBox();
        public CheckBox ShowThumbnailsAlwaysOnTopCheckBox = new CheckBox();
        public CheckBox HideThumbnailsOnLostFocusCheckBox = new CheckBox();
        public CheckBox EnablePerClientThumbnailsLayoutsCheckBox = new CheckBox();
        public CheckBox MinimizeToTrayCheckBox = new CheckBox();
    }
}
