using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EveOPreview.View
{
    public class PageAndPanel
    {
        public PageAndPanel(MainForm InParentForm)
        {
            ParentForm = InParentForm;

            Panel.SuspendLayout();
            Page.SuspendLayout();

            SetPage();
            SetPanel();

            Page.ResumeLayout(false);
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
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

        protected void SetCheckBox(CheckBox InCheckBox, string Name, string Text, Point InLocation, Padding InPadding, Size InSize, int TabIndex, EventHandler Handler)
        {
            InCheckBox.UseVisualStyleBackColor = true;
            InCheckBox .CheckedChanged += new System.EventHandler(Handler);

            SetGeneralControlMembers(InCheckBox, Name, Text, InLocation, InPadding, InSize, TabIndex);
        }

        protected void SetRadioButton(RadioButton InRadioButton, string Name, string Text, Point InLocation, Padding InPadding, Size InSize, int TabIndex, EventHandler Handler)
        {
            InRadioButton.TabStop = true;
            InRadioButton.UseVisualStyleBackColor = true;
            InRadioButton.CheckedChanged += new EventHandler(Handler);

            SetGeneralControlMembers(InRadioButton, Name, Text, InLocation, InPadding, InSize, TabIndex);
        }

        protected void SetNumeric(NumericUpDown InNumeric, string InName, decimal InValue, Point InLocation, Size InSize, int InTabIndex)
        {
            InNumeric.BackColor = SystemColors.Window;
            InNumeric.BorderStyle = BorderStyle.FixedSingle;
            InNumeric.CausesValidation = false;
            InNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            InNumeric.Location = InLocation;
            InNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            InNumeric.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            InNumeric.Name = InName;
            InNumeric.Size = InSize;
            InNumeric.TabIndex = InTabIndex;
            InNumeric.Value = InValue;
            InNumeric.ValueChanged += new System.EventHandler(ParentForm.ThumbnailSizeChanged_Handler);

            Panel.Controls.Add(InNumeric);
        }

        protected void SetGeneralControlMembers(Control InControl, string Name, string Text, Point InLocation, Padding InMargin, Size InSize, int TabIndex)
        {
            InControl.Name = Name;
            InControl.Text = Text;
            InControl.AutoSize = true;
            InControl.Margin = InMargin;
            InControl.Location = InLocation;
            InControl.Size = InSize;
            InControl.TabIndex = TabIndex;

            Panel.Controls.Add(InControl);
        }

        public TabPage Page = new TabPage();
        public Panel Panel = new Panel();
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

    public class ThumbnailTab : PageAndPanel
    {
        public ThumbnailTab(MainForm InParentForm) : base(InParentForm)
        {
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsWidthNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsHeightNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailOpacityTrackBar)).BeginInit();

            Padding LabelPadding = new Padding(4, 0, 4, 0);

            SetGeneralControlMembers(HeightLabel, "HeightLabel", "Thumbnail Height", new Point(12, 88), LabelPadding, new Size(133, 20), 24);
            SetGeneralControlMembers(WidthLabel, "WidthLabel", "Thumbnail Width", new Point(12, 51), LabelPadding, new Size(127, 20), 23);
            SetGeneralControlMembers(OpacityLabel, "OpacityLabel", "Opacity", new Point(12, 14), LabelPadding, new Size(62, 20), 19);
            
            decimal WidthDecimal = new decimal(new int[] {
            100,
            0,
            0,
            0});
            SetNumeric(ThumbnailsWidthNumericEdit, "ThumbnailsWidthNumericEdit", WidthDecimal, new Point(158, 48), new Size(72, 26), 21);

            decimal HeightDecimal = new decimal(new int[] {
            70,
            0,
            0,
            0});
            SetNumeric(ThumbnailsHeightNumericEdit, "ThumbnailsHeightNumericEdit", HeightDecimal, new Point(158, 85), new Size(72, 26), 22);

            SetTrackBar();

            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsWidthNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsHeightNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailOpacityTrackBar)).EndInit();
        }
        protected override void SetPage()
        {
            SetPageSettings("ThumbnailTabPage", "Thumbnail", new Point(124, 4), new Size(457, 327), 1);

            base.SetPage();
        }

        protected override void SetPanel()
        {
            SetPanelSettings("ThumbnailSettingsPanel", new Point(4, 5), new Size(449, 317), 19);

            base.SetPanel();
        }

        // Only 1 track bar, so not making helper function cause too many parameters
        private void SetTrackBar()
        {
            ThumbnailOpacityTrackBar.AutoSize = false;
            ThumbnailOpacityTrackBar.LargeChange = 10;
            ThumbnailOpacityTrackBar.Location = new Point(92, 9);
            ThumbnailOpacityTrackBar.Margin = new Padding(4, 5, 4, 5);
            ThumbnailOpacityTrackBar.Maximum = 100;
            ThumbnailOpacityTrackBar.Minimum = 20;
            ThumbnailOpacityTrackBar.Name = "ThumbnailOpacityTrackBar";
            ThumbnailOpacityTrackBar.Size = new Size(286, 34);
            ThumbnailOpacityTrackBar.TabIndex = 20;
            ThumbnailOpacityTrackBar.TickFrequency = 10;
            ThumbnailOpacityTrackBar.Value = 20;
            ThumbnailOpacityTrackBar.ValueChanged += new EventHandler(ParentForm.OptionChanged_Handler);

            Panel.Controls.Add(ThumbnailOpacityTrackBar);
        }

        public Label HeightLabel = new Label();
        public Label WidthLabel = new Label();
        public Label OpacityLabel = new Label();

        public NumericUpDown ThumbnailsWidthNumericEdit = new NumericUpDown();
        public NumericUpDown ThumbnailsHeightNumericEdit = new NumericUpDown();
        public TrackBar ThumbnailOpacityTrackBar = new TrackBar();
    }
}
