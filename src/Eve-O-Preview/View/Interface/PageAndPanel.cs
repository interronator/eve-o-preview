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

            SetPage();
            SetPanel();

            ParentForm.Pages.Add(this);
        }

        protected void SetPanelSettings(string InName, Point InLocation, Size InSize, int InTabIndex, Panel InPanel = null)
        {
            Panel PanelToEdit;

            if (InPanel == null)
            {
                PanelToEdit = Panel;
                PanelToEdit.Dock = DockStyle.Fill;
            }
            else
            {
                PanelToEdit = InPanel;
            }

            PanelToEdit.BorderStyle = BorderStyle.FixedSingle;
            PanelToEdit.Margin = new Padding(4, 5, 4, 5);
            PanelToEdit.Name = InName;
            PanelToEdit.Location = InLocation;
            PanelToEdit.Size = InSize;
            PanelToEdit.TabIndex = InTabIndex;
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

        public virtual void Suspend()
        {
            Page.SuspendLayout();
            Panel.SuspendLayout();
        }

        public virtual void ResumeLayout()
        {
            Page.ResumeLayout(false);
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
        }

        protected virtual void SetPage() { }
        protected virtual void SetPanel() { }

        protected void SetCheckBox(CheckBox InCheckBox, string Name, string Text, Point InLocation, Size InSize, int TabIndex)
        {
            InCheckBox.UseVisualStyleBackColor = true;
            InCheckBox.CheckedChanged += new System.EventHandler(ParentForm.OptionChanged_Handler);

            SetGeneralControlMembers(InCheckBox, Name, Text, InLocation, new Padding(4, 5, 4, 5), InSize, TabIndex);
        }

        protected void SetRadioButton(RadioButton InRadioButton, string Name, Point InLocation, Size InSize, int TabIndex, bool bAutoAdd = true)
        {
            InRadioButton.TabStop = true;
            InRadioButton.UseVisualStyleBackColor = true;
            InRadioButton.CheckedChanged += new EventHandler(ParentForm.OptionChanged_Handler);

            SetGeneralControlMembers(InRadioButton, Name, "", InLocation, new Padding(4, 5, 4, 5), InSize, TabIndex);
        }

        protected void SetNumeric(NumericUpDown InNumeric, string InName, decimal InValue, Point InLocation, Size InSize, int InTabIndex, int Increment = 10)
        {
            InNumeric.BackColor = SystemColors.Window;
            InNumeric.BorderStyle = BorderStyle.FixedSingle;
            InNumeric.CausesValidation = false;
            InNumeric.Increment = new decimal(new int[] {
            Increment,
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

        protected void SetGeneralControlMembers(Control InControl, string Name, string Text, Point InLocation, Padding InMargin, Size InSize, int TabIndex, bool bAutoAdd = true)
        {
            InControl.Name = Name;
            InControl.Text = Text;
            InControl.AutoSize = true;
            InControl.Margin = InMargin;
            InControl.Location = InLocation;
            InControl.Size = InSize;
            InControl.TabIndex = TabIndex;

            if (bAutoAdd)
            {
                Panel.Controls.Add(InControl);
            }
        }

        public TabPage Page = new TabPage();
        public Panel Panel = new Panel();
        protected MainForm ParentForm;
    }

    public class GeneralTab : PageAndPanel
    {
        public GeneralTab(MainForm InParentForm) : base(InParentForm)
        {
            SetCheckBox(MinimizeInactiveClientsCheckBox, "MinimizeInactiveClientsCheckBox", "Minimize inactive EVE clients", new Point(12, 122), new Size(239, 24), 24);
            SetCheckBox(EnableClientLayoutTrackingCheckBox, "EnableClientLayoutTrackingCheckBox", "Track client locations", new Point(12, 48), new Size(182, 24), 19);
            SetCheckBox(HideActiveClientThumbnailCheckBox, "HideActiveClientThumbnailCheckBox", "Hide preview of active EVE client", new Point(12, 85), new Size(266, 24), 20);
            SetCheckBox(ShowThumbnailsAlwaysOnTopCheckBox, "ShowThumbnailsAlwaysOnTopCheckBox", "Previews always on top", new Point(12, 159), new Size(197, 24), 21);
            SetCheckBox(HideThumbnailsOnLostFocusCheckBox, "HideThumbnailsOnLostFocusCheckBox", "Hide previews when EVE client is not active", new Point(12, 196), new Size(340, 24), 22);
            SetCheckBox(EnablePerClientThumbnailsLayoutsCheckBox, "EnablePerClientThumbnailsLayoutsCheckBox", "Unique layout for each EVE client", new Point(12, 233), new Size(272, 24), 23);
            SetCheckBox(MinimizeToTrayCheckBox, "MinimizeToTrayCheckBox", "Minimize to System Tray", new Point(12, 11), new Size(205, 24), 18);
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

    public class ZoomTab : PageAndPanel
    {
        public ZoomTab(MainForm InParentForm) : base(InParentForm)
        {
            Panel.Controls.Add(ZoomAnchorLabel);
            Panel.Controls.Add(ZoomAnchorPanel);

            Size RadioButtonSize = new Size(21, 20);
            SetRadioButton(ZoomAanchorNWRadioButton, "ZoomAanchorNWRadioButton", new Point(4, 5), RadioButtonSize, 0, false);
            SetRadioButton(ZoomAanchorNRadioButton, "ZoomAanchorNRadioButton", new Point(46, 5), RadioButtonSize, 1, false);
            SetRadioButton(ZoomAanchorNERadioButton, "ZoomAanchorNERadioButton", new Point(88, 5), RadioButtonSize, 2, false);
            SetRadioButton(ZoomAanchorWRadioButton, "ZoomAanchorWRadioButton", new Point(4, 45), RadioButtonSize, 3, false);
            SetRadioButton(ZoomAanchorCRadioButton, "ZoomAanchorCRadioButton", new Point(46, 45), RadioButtonSize, 4, false);
            SetRadioButton(ZoomAanchorERadioButton, "ZoomAanchorERadioButton", new Point(88, 45), RadioButtonSize, 5, false);
            SetRadioButton(ZoomAanchorSWRadioButton, "ZoomAanchorSWRadioButton", new Point(4, 85), RadioButtonSize, 6, false);
            SetRadioButton(ZoomAanchorSRadioButton, "ZoomAanchorSRadioButton", new Point(46, 85), RadioButtonSize, 7, false);
            SetRadioButton(ZoomAanchorSERadioButton, "ZoomAanchorSERadioButton", new Point(88, 85), RadioButtonSize, 8, false);

            ZoomAnchorPanel.Controls.AddRange(new Control[] { ZoomAanchorNWRadioButton , ZoomAanchorNRadioButton, ZoomAanchorNERadioButton,
            ZoomAanchorWRadioButton, ZoomAanchorCRadioButton, ZoomAanchorERadioButton, ZoomAanchorSWRadioButton, ZoomAanchorSRadioButton, ZoomAanchorSERadioButton});

            SetGeneralControlMembers(ZoomFactorLabel, "ZoomFactorLabel", "Zoom Factor", new Point(12, 51), new Padding(4, 0, 4, 0), new Size(100, 20), 39);
            SetGeneralControlMembers(ZoomAnchorLabel, "ZoomAnchorLabel", "Anchor", new Point(12, 88), new Padding(4, 0, 4, 0), new Size(60, 20), 40);

            SetZoomNumeric();
            SetCheckBox(EnableThumbnailZoomCheckBox, "EnableThumbnailZoomCheckBox", "Zoom on hover", new Point(12, 11), new Size(141, 24), 36);

        }

        public override void Suspend()
        {
            base.Suspend();

            ZoomAnchorPanel.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailZoomFactorNumericEdit)).BeginInit();
        }

        public override void ResumeLayout()
        {
            base.ResumeLayout();

            ZoomAnchorPanel.ResumeLayout(false);
            ZoomAnchorPanel.PerformLayout();


            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailZoomFactorNumericEdit)).EndInit();
        }

        protected override void SetPage()
        {
            SetPageSettings("ZoomTabPage", "Zoom", new Point(124, 4), new Size(457, 327), 2);

            base.SetPage();
        }

        protected override void SetPanel()
        {
            SetPanelSettings("ZoomSettingsPanel", new Point(0, 0), new Size(457, 327), 36);

            SetPanelSettings("ZoomAnchorPanel", new Point(122, 83), new Size(114, 111), 38, ZoomAnchorPanel);

            base.SetPanel();
        }

        private void SetZoomNumeric()
        {
            decimal ZoomValue = new decimal(new int[] {
            2,
            0,
            0,
            0});

            SetNumeric(ThumbnailZoomFactorNumericEdit, "ThumbnailZoomFactorNumericEdit", ZoomValue, new Point(122, 48), new Size(57, 26), 37, 33);
        }

        // Begin of Zoom Anchor
        public Panel ZoomAnchorPanel = new Panel();
        public Label ZoomAnchorLabel = new Label();

        public RadioButton ZoomAanchorNWRadioButton = new RadioButton();
        public RadioButton ZoomAanchorNRadioButton = new RadioButton();
        public RadioButton ZoomAanchorNERadioButton = new RadioButton();
        public RadioButton ZoomAanchorWRadioButton = new RadioButton();
        public RadioButton ZoomAanchorSERadioButton = new RadioButton();
        public RadioButton ZoomAanchorCRadioButton = new RadioButton();
        public RadioButton ZoomAanchorSRadioButton = new RadioButton();
        public RadioButton ZoomAanchorERadioButton = new RadioButton();
        public RadioButton ZoomAanchorSWRadioButton = new RadioButton();
        // End of Zoom Anchor

        public Label ZoomFactorLabel = new Label();
        public CheckBox EnableThumbnailZoomCheckBox = new CheckBox();
        public NumericUpDown ThumbnailZoomFactorNumericEdit = new NumericUpDown();
    }

    public class LocalWatcherTab : PageAndPanel
    {
        public LocalWatcherTab(MainForm InParent) : base(InParent)
        {

        }

        protected override void SetPage()
        {
            SetPageSettings("LocalWatcherPage", "Local Watch", new Point(124, 4), new Size(457, 327), 3);

            base.SetPage();
        }
    }

    public class OverlayTab : PageAndPanel
    {
        public OverlayTab(MainForm InParent) : base(InParent)
        {
            SetGeneralControlMembers(HighlightColorLabel, "HighlightColorLabel", "Color", new Point(8, 120), new Padding(4, 0, 4, 0), new Size(46, 20), 29);
            SetCheckBox(EnableActiveClientHighlightCheckBox, "EnableActiveClientHighlightCheckBox", "Highlight active client", new Point(12, 85), new Size(183, 24), 27);
            SetCheckBox(ShowThumbnailOverlaysCheckBox, "ShowThumbnailOverlaysCheckBox", "Show overlay", new Point(12, 11), new Size(128, 24), 15);
            SetCheckBox(ShowThumbnailFramesCheckBox, "ShowThumbnailFramesCheckBox", "Show frames", new Point(12, 48), new Size(128, 24), 26);

        }

        protected override void SetPage()
        {
            SetPageSettings("OverlayTabPage", "Overlay", new Point(124, 4), new Size(457, 327), 4);

            base.SetPage();
        }

        protected override void SetPanel()
        {
            SetPanelSettings("OverlaySettingsPanel", new Point(0, 0), new Size(457, 327), 25);
            SetPanelSettings("ActiveClientHighlightColorButton", new Point(63, 118), new Size(138, 25), 28, ActiveClientHighlightColorButton);
            Panel.Controls.Add(ActiveClientHighlightColorButton);
            ShowThumbnailFramesCheckBox.Click += new System.EventHandler(ParentForm.ActiveClientHighlightColorButton_Click);
            base.SetPanel();
        }

        public Label HighlightColorLabel = new Label();
        public Panel ActiveClientHighlightColorButton = new Panel();
        public CheckBox EnableActiveClientHighlightCheckBox = new CheckBox();
        public CheckBox ShowThumbnailOverlaysCheckBox = new CheckBox();
        public CheckBox ShowThumbnailFramesCheckBox = new CheckBox();
    }

    public class AboutTab : PageAndPanel
    {
        public AboutTab(MainForm InParent) : base(InParent)
        {
            SetGeneralControlMembers(DocumentationLinkLabel, "DocumentationLinkLabel", "For more information visit the forum thread:",
                new Point(0, 244), new Padding(4, 0, 4, 0), new Size(336, 30), 6);
            string ResourceString = resources.GetString("DescriptionLabel.Text");
            SetGeneralControlMembers(DescriptionLabel, "DescriptionLabel", ResourceString,
                new Point(0, 63), new Padding(12, 5, 12, 5), new Size(392, 178), 5);
            SetGeneralControlMembers(NameLabel, "NameLabel", "EVE-O Preview", new Point(6, 14), new Padding(4, 0, 4, 0), new Size(193, 29), 3);
            SetGeneralControlMembers(VersionLabel, "VersionLabel", "1.0.0", new Point(200, 14), new Padding(4, 0, 4, 0), new Size(69, 29), 4);
        }

        protected override void SetPage()
        {
            SetPageSettings("AboutTabPage", "About", new Point(124, 4), new Size(457, 327), 6);

            base.SetPage();
        }

        protected override void SetPanel()
        {
            SetPanelSettings("AboutPanel", new Point(0, 0), new Size(457, 327), 2);
            base.SetPanel();
        }

        public Label DocumentationLinkLabel = new Label();
        public Label DescriptionLabel = new Label();
        public Label VersionLabel = new Label();
        public System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        public Label NameLabel = new Label();
    }
}