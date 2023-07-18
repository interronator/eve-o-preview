using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EveOPreview.View
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void SetPanelSettings(ref System.Windows.Forms.Panel PanelToSet, Control[] ConntrolsToAdd
			, string Name, System.Drawing.Size SizeToUse )
		{
            PanelToSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			PanelToSet.Controls.AddRange(ConntrolsToAdd);
            PanelToSet.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelToSet.Location = new System.Drawing.Point(4, 5);
            PanelToSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelToSet.Name = Name;
			PanelToSet.Size = SizeToUse;
            PanelToSet.TabIndex = 18;
        }

		private void CreateGeneralTabAndPanel()
		{

		}
        #region Windows Form Designer generated code

        /// <summary>s
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripMenuItem RestoreWindowMenuItem;
			System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
			System.Windows.Forms.ToolStripMenuItem TitleMenuItem;
			System.Windows.Forms.ToolStripSeparator SeparatorMenuItem;
			System.Windows.Forms.TabControl ContentTabControl;
            System.Windows.Forms.TabPage LocalWatcherPage;
            System.Windows.Forms.Panel LocalWatcherPanel;
			//
		
			//
			System.Windows.Forms.Panel ZoomSettingsPanel;
			System.Windows.Forms.Label ZoomFactorLabel;
			System.Windows.Forms.Label ZoomAnchorLabel;
			System.Windows.Forms.TabPage OverlayTabPage;
			System.Windows.Forms.Panel OverlaySettingsPanel;
			System.Windows.Forms.TabPage ClientsTabPage;
			System.Windows.Forms.Panel ClientsPanel;
			System.Windows.Forms.Label ThumbnailsListLabel;
			System.Windows.Forms.TabPage AboutTabPage;
			System.Windows.Forms.Panel AboutPanel;
			System.Windows.Forms.Label DocumentationLinkLabel;
			System.Windows.Forms.Label DescriptionLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.Label NameLabel;
            //

            //
            General = new GeneralTab(this);
			Thumbnail = new ThumbnailTab(this);

			this.ZoomTabPage = new System.Windows.Forms.TabPage();
			this.ZoomAnchorPanel = new System.Windows.Forms.Panel();
			this.ZoomAanchorNWRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorNRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorNERadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorWRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorSERadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorCRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorSRadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorERadioButton = new System.Windows.Forms.RadioButton();
			this.ZoomAanchorSWRadioButton = new System.Windows.Forms.RadioButton();
			this.EnableThumbnailZoomCheckBox = new System.Windows.Forms.CheckBox();
			this.ThumbnailZoomFactorNumericEdit = new System.Windows.Forms.NumericUpDown();
			this.HighlightColorLabel = new System.Windows.Forms.Label();
			this.ActiveClientHighlightColorButton = new System.Windows.Forms.Panel();
			this.EnableActiveClientHighlightCheckBox = new System.Windows.Forms.CheckBox();
			this.ShowThumbnailOverlaysCheckBox = new System.Windows.Forms.CheckBox();
			this.ShowThumbnailFramesCheckBox = new System.Windows.Forms.CheckBox();
			this.ThumbnailsList = new System.Windows.Forms.CheckedListBox();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.DocumentationLink = new System.Windows.Forms.LinkLabel();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			RestoreWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			TitleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			SeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
			ContentTabControl = new System.Windows.Forms.TabControl();
			LocalWatcherPage = new System.Windows.Forms.TabPage();
			LocalWatcherPanel = new System.Windows.Forms.Panel();
			ZoomSettingsPanel = new System.Windows.Forms.Panel();
			ZoomFactorLabel = new System.Windows.Forms.Label();
			ZoomAnchorLabel = new System.Windows.Forms.Label();
			OverlayTabPage = new System.Windows.Forms.TabPage();
			OverlaySettingsPanel = new System.Windows.Forms.Panel();
			ClientsTabPage = new System.Windows.Forms.TabPage();
			ClientsPanel = new System.Windows.Forms.Panel();
			ThumbnailsListLabel = new System.Windows.Forms.Label();
			AboutTabPage = new System.Windows.Forms.TabPage();
			AboutPanel = new System.Windows.Forms.Panel();
			DocumentationLinkLabel = new System.Windows.Forms.Label();
			DescriptionLabel = new System.Windows.Forms.Label();
			NameLabel = new System.Windows.Forms.Label();
			ContentTabControl.SuspendLayout();
			LocalWatcherPage.SuspendLayout();
			LocalWatcherPanel.SuspendLayout();
			this.ZoomTabPage.SuspendLayout();
			ZoomSettingsPanel.SuspendLayout();
			this.ZoomAnchorPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailZoomFactorNumericEdit)).BeginInit();
			OverlayTabPage.SuspendLayout();
			OverlaySettingsPanel.SuspendLayout();
			ClientsTabPage.SuspendLayout();
			ClientsPanel.SuspendLayout();
			AboutTabPage.SuspendLayout();
			AboutPanel.SuspendLayout();
			this.TrayMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// RestoreWindowMenuItem
			// 
			RestoreWindowMenuItem.Name = "RestoreWindowMenuItem";
			RestoreWindowMenuItem.Size = new System.Drawing.Size(199, 30);
			RestoreWindowMenuItem.Text = "Restore";
			RestoreWindowMenuItem.Click += new System.EventHandler(this.RestoreMainForm_Handler);
			// 
			// ExitMenuItem
			// 
			ExitMenuItem.Name = "ExitMenuItem";
			ExitMenuItem.Size = new System.Drawing.Size(199, 30);
			ExitMenuItem.Text = "Exit";
			ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick_Handler);
			// 
			// TitleMenuItem
			// 
			TitleMenuItem.Enabled = false;
			TitleMenuItem.Name = "TitleMenuItem";
			TitleMenuItem.Size = new System.Drawing.Size(199, 30);
			TitleMenuItem.Text = "EVE-O Preview";
			// 
			// SeparatorMenuItem
			// 
			SeparatorMenuItem.Name = "SeparatorMenuItem";
			SeparatorMenuItem.Size = new System.Drawing.Size(196, 6);
			// 
			// ContentTabControl
			// 
			ContentTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
			ContentTabControl.Controls.Add(General.Page);
			ContentTabControl.Controls.Add(Thumbnail.Page);
			ContentTabControl.Controls.Add(this.ZoomTabPage);
			ContentTabControl.Controls.Add(LocalWatcherPage);
			ContentTabControl.Controls.Add(OverlayTabPage);
			ContentTabControl.Controls.Add(ClientsTabPage);
			ContentTabControl.Controls.Add(AboutTabPage);
			ContentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			ContentTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			ContentTabControl.ItemSize = new System.Drawing.Size(35, 120);
			ContentTabControl.Location = new System.Drawing.Point(0, 0);
			ContentTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			ContentTabControl.Multiline = true;
			ContentTabControl.Name = "ContentTabControl";
			ContentTabControl.SelectedIndex = 0;
			ContentTabControl.Size = new System.Drawing.Size(585, 335);
			ContentTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			ContentTabControl.TabIndex = 6;
			ContentTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ContentTabControl_DrawItem);

            // 
            // MinimizeInactiveClientsCheckBox
            // 
            General.MinimizeInactiveClientsCheckBox.AutoSize = true;

			// 
			// ZoomTabPage
			// 
			this.ZoomTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.ZoomTabPage.Controls.Add(ZoomSettingsPanel);
			this.ZoomTabPage.Location = new System.Drawing.Point(124, 4);
			this.ZoomTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomTabPage.Name = "ZoomTabPage";
			this.ZoomTabPage.Size = new System.Drawing.Size(457, 327);
			this.ZoomTabPage.TabIndex = 2;
			this.ZoomTabPage.Text = "Zoom";
            // 
            // ZoomSettingsPanel
            // 
            SetPanelSettings(ref ZoomSettingsPanel,
             new Control[] {
                ZoomFactorLabel,
                ZoomAnchorPanel,
                ZoomAnchorLabel,
                EnableThumbnailZoomCheckBox,
                ThumbnailZoomFactorNumericEdit},
             "ZoomSettingsPanel",
              new System.Drawing.Size(457, 337));
			// 
			// ZoomFactorLabel
			// 
			ZoomFactorLabel.AutoSize = true;
			ZoomFactorLabel.Location = new System.Drawing.Point(12, 51);
			ZoomFactorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			ZoomFactorLabel.Name = "ZoomFactorLabel";
			ZoomFactorLabel.Size = new System.Drawing.Size(100, 20);
			ZoomFactorLabel.TabIndex = 39;
			ZoomFactorLabel.Text = "Zoom Factor";
            // 
            // ZoomAnchorPanel
            // 
            SetPanelSettings(ref ZoomAnchorPanel,
             new Control[] {
                ZoomAanchorNWRadioButton,
                ZoomAanchorNRadioButton,
                ZoomAanchorNERadioButton,
                ZoomAanchorWRadioButton,
                ZoomAanchorSERadioButton,
                ZoomAanchorCRadioButton,
                ZoomAanchorSRadioButton,
                ZoomAanchorERadioButton,
                ZoomAanchorSWRadioButton},
             "ZoomAnchorPanel",
              new System.Drawing.Size(114, 111));
			// 
			// ZoomAanchorNWRadioButton
			// 
			this.ZoomAanchorNWRadioButton.AutoSize = true;
			this.ZoomAanchorNWRadioButton.Location = new System.Drawing.Point(4, 5);
			this.ZoomAanchorNWRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorNWRadioButton.Name = "ZoomAanchorNWRadioButton";
			this.ZoomAanchorNWRadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorNWRadioButton.TabIndex = 0;
			this.ZoomAanchorNWRadioButton.TabStop = true;
			this.ZoomAanchorNWRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorNWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorNRadioButton
			// 
			this.ZoomAanchorNRadioButton.AutoSize = true;
			this.ZoomAanchorNRadioButton.Location = new System.Drawing.Point(46, 5);
			this.ZoomAanchorNRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorNRadioButton.Name = "ZoomAanchorNRadioButton";
			this.ZoomAanchorNRadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorNRadioButton.TabIndex = 1;
			this.ZoomAanchorNRadioButton.TabStop = true;
			this.ZoomAanchorNRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorNRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorNERadioButton
			// 
			this.ZoomAanchorNERadioButton.AutoSize = true;
			this.ZoomAanchorNERadioButton.Location = new System.Drawing.Point(88, 5);
			this.ZoomAanchorNERadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorNERadioButton.Name = "ZoomAanchorNERadioButton";
			this.ZoomAanchorNERadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorNERadioButton.TabIndex = 2;
			this.ZoomAanchorNERadioButton.TabStop = true;
			this.ZoomAanchorNERadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorNERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorWRadioButton
			// 
			this.ZoomAanchorWRadioButton.AutoSize = true;
			this.ZoomAanchorWRadioButton.Location = new System.Drawing.Point(4, 45);
			this.ZoomAanchorWRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorWRadioButton.Name = "ZoomAanchorWRadioButton";
			this.ZoomAanchorWRadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorWRadioButton.TabIndex = 3;
			this.ZoomAanchorWRadioButton.TabStop = true;
			this.ZoomAanchorWRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorSERadioButton
			// 
			this.ZoomAanchorSERadioButton.AutoSize = true;
			this.ZoomAanchorSERadioButton.Location = new System.Drawing.Point(88, 85);
			this.ZoomAanchorSERadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorSERadioButton.Name = "ZoomAanchorSERadioButton";
			this.ZoomAanchorSERadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorSERadioButton.TabIndex = 8;
			this.ZoomAanchorSERadioButton.TabStop = true;
			this.ZoomAanchorSERadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorSERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorCRadioButton
			// 
			this.ZoomAanchorCRadioButton.AutoSize = true;
			this.ZoomAanchorCRadioButton.Location = new System.Drawing.Point(46, 45);
			this.ZoomAanchorCRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorCRadioButton.Name = "ZoomAanchorCRadioButton";
			this.ZoomAanchorCRadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorCRadioButton.TabIndex = 4;
			this.ZoomAanchorCRadioButton.TabStop = true;
			this.ZoomAanchorCRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorCRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorSRadioButton
			// 
			this.ZoomAanchorSRadioButton.AutoSize = true;
			this.ZoomAanchorSRadioButton.Location = new System.Drawing.Point(46, 85);
			this.ZoomAanchorSRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorSRadioButton.Name = "ZoomAanchorSRadioButton";
			this.ZoomAanchorSRadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorSRadioButton.TabIndex = 7;
			this.ZoomAanchorSRadioButton.TabStop = true;
			this.ZoomAanchorSRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorSRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorERadioButton
			// 
			this.ZoomAanchorERadioButton.AutoSize = true;
			this.ZoomAanchorERadioButton.Location = new System.Drawing.Point(88, 45);
			this.ZoomAanchorERadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorERadioButton.Name = "ZoomAanchorERadioButton";
			this.ZoomAanchorERadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorERadioButton.TabIndex = 5;
			this.ZoomAanchorERadioButton.TabStop = true;
			this.ZoomAanchorERadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAanchorSWRadioButton
			// 
			this.ZoomAanchorSWRadioButton.AutoSize = true;
			this.ZoomAanchorSWRadioButton.Location = new System.Drawing.Point(4, 85);
			this.ZoomAanchorSWRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ZoomAanchorSWRadioButton.Name = "ZoomAanchorSWRadioButton";
			this.ZoomAanchorSWRadioButton.Size = new System.Drawing.Size(21, 20);
			this.ZoomAanchorSWRadioButton.TabIndex = 6;
			this.ZoomAanchorSWRadioButton.TabStop = true;
			this.ZoomAanchorSWRadioButton.UseVisualStyleBackColor = true;
			this.ZoomAanchorSWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ZoomAnchorLabel
			// 
			ZoomAnchorLabel.AutoSize = true;
			ZoomAnchorLabel.Location = new System.Drawing.Point(12, 88);
			ZoomAnchorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			ZoomAnchorLabel.Name = "ZoomAnchorLabel";
			ZoomAnchorLabel.Size = new System.Drawing.Size(60, 20);
			ZoomAnchorLabel.TabIndex = 40;
			ZoomAnchorLabel.Text = "Anchor";
			// 
			// EnableThumbnailZoomCheckBox
			// 
			this.EnableThumbnailZoomCheckBox.AutoSize = true;
			this.EnableThumbnailZoomCheckBox.Checked = true;
			this.EnableThumbnailZoomCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.EnableThumbnailZoomCheckBox.Location = new System.Drawing.Point(12, 11);
			this.EnableThumbnailZoomCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EnableThumbnailZoomCheckBox.Name = "EnableThumbnailZoomCheckBox";
			this.EnableThumbnailZoomCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.EnableThumbnailZoomCheckBox.Size = new System.Drawing.Size(141, 24);
			this.EnableThumbnailZoomCheckBox.TabIndex = 36;
			this.EnableThumbnailZoomCheckBox.Text = "Zoom on hover";
			this.EnableThumbnailZoomCheckBox.UseVisualStyleBackColor = true;
			this.EnableThumbnailZoomCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ThumbnailZoomFactorNumericEdit
			// 
			this.ThumbnailZoomFactorNumericEdit.BackColor = System.Drawing.SystemColors.Window;
			this.ThumbnailZoomFactorNumericEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ThumbnailZoomFactorNumericEdit.Location = new System.Drawing.Point(122, 48);
			this.ThumbnailZoomFactorNumericEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ThumbnailZoomFactorNumericEdit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.ThumbnailZoomFactorNumericEdit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.ThumbnailZoomFactorNumericEdit.Name = "ThumbnailZoomFactorNumericEdit";
			this.ThumbnailZoomFactorNumericEdit.Size = new System.Drawing.Size(57, 26);
			this.ThumbnailZoomFactorNumericEdit.TabIndex = 37;
			this.ThumbnailZoomFactorNumericEdit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.ThumbnailZoomFactorNumericEdit.ValueChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// OverlayTabPage
			// 
			OverlayTabPage.BackColor = System.Drawing.SystemColors.Control;
			OverlayTabPage.Controls.Add(OverlaySettingsPanel);
			OverlayTabPage.Location = new System.Drawing.Point(124, 4);
			OverlayTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			OverlayTabPage.Name = "OverlayTabPage";
			OverlayTabPage.Size = new System.Drawing.Size(457, 327);
			OverlayTabPage.TabIndex = 3;
			OverlayTabPage.Text = "Overlay";
			// 
			// OverlaySettingsPanel
			// 
			 SetPanelSettings(ref OverlaySettingsPanel,
             new Control[] {
                HighlightColorLabel,
                ActiveClientHighlightColorButton,
                EnableActiveClientHighlightCheckBox,
                ShowThumbnailOverlaysCheckBox,
                ShowThumbnailFramesCheckBox},
             "OverlaySettingsPanel",
              new System.Drawing.Size(457, 327));
			// 
			// HighlightColorLabel
			// 
			this.HighlightColorLabel.AutoSize = true;
			this.HighlightColorLabel.Location = new System.Drawing.Point(8, 120);
			this.HighlightColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HighlightColorLabel.Name = "HighlightColorLabel";
			this.HighlightColorLabel.Size = new System.Drawing.Size(46, 20);
			this.HighlightColorLabel.TabIndex = 29;
			this.HighlightColorLabel.Text = "Color";
			// 
			// ActiveClientHighlightColorButton
			// 
			this.ActiveClientHighlightColorButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ActiveClientHighlightColorButton.Location = new System.Drawing.Point(63, 118);
			this.ActiveClientHighlightColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ActiveClientHighlightColorButton.Name = "ActiveClientHighlightColorButton";
			this.ActiveClientHighlightColorButton.Size = new System.Drawing.Size(138, 25);
			this.ActiveClientHighlightColorButton.TabIndex = 28;
			this.ActiveClientHighlightColorButton.Click += new System.EventHandler(this.ActiveClientHighlightColorButton_Click);
			// 
			// EnableActiveClientHighlightCheckBox
			// 
			this.EnableActiveClientHighlightCheckBox.AutoSize = true;
			this.EnableActiveClientHighlightCheckBox.Checked = true;
			this.EnableActiveClientHighlightCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.EnableActiveClientHighlightCheckBox.Location = new System.Drawing.Point(12, 85);
			this.EnableActiveClientHighlightCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EnableActiveClientHighlightCheckBox.Name = "EnableActiveClientHighlightCheckBox";
			this.EnableActiveClientHighlightCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.EnableActiveClientHighlightCheckBox.Size = new System.Drawing.Size(183, 24);
			this.EnableActiveClientHighlightCheckBox.TabIndex = 27;
			this.EnableActiveClientHighlightCheckBox.Text = "Highlight active client";
			this.EnableActiveClientHighlightCheckBox.UseVisualStyleBackColor = true;
			this.EnableActiveClientHighlightCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ShowThumbnailOverlaysCheckBox
			// 
			this.ShowThumbnailOverlaysCheckBox.AutoSize = true;
			this.ShowThumbnailOverlaysCheckBox.Checked = true;
			this.ShowThumbnailOverlaysCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowThumbnailOverlaysCheckBox.Location = new System.Drawing.Point(12, 11);
			this.ShowThumbnailOverlaysCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ShowThumbnailOverlaysCheckBox.Name = "ShowThumbnailOverlaysCheckBox";
			this.ShowThumbnailOverlaysCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowThumbnailOverlaysCheckBox.Size = new System.Drawing.Size(128, 24);
			this.ShowThumbnailOverlaysCheckBox.TabIndex = 25;
			this.ShowThumbnailOverlaysCheckBox.Text = "Show overlay";
			this.ShowThumbnailOverlaysCheckBox.UseVisualStyleBackColor = true;
			this.ShowThumbnailOverlaysCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ShowThumbnailFramesCheckBox
			// 
			this.ShowThumbnailFramesCheckBox.AutoSize = true;
			this.ShowThumbnailFramesCheckBox.Checked = true;
			this.ShowThumbnailFramesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowThumbnailFramesCheckBox.Location = new System.Drawing.Point(12, 48);
			this.ShowThumbnailFramesCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ShowThumbnailFramesCheckBox.Name = "ShowThumbnailFramesCheckBox";
			this.ShowThumbnailFramesCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowThumbnailFramesCheckBox.Size = new System.Drawing.Size(128, 24);
			this.ShowThumbnailFramesCheckBox.TabIndex = 26;
			this.ShowThumbnailFramesCheckBox.Text = "Show frames";
			this.ShowThumbnailFramesCheckBox.UseVisualStyleBackColor = true;
			this.ShowThumbnailFramesCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
			// 
			// ClientsTabPage
			// 
			ClientsTabPage.BackColor = System.Drawing.SystemColors.Control;
			ClientsTabPage.Controls.Add(ClientsPanel);
			ClientsTabPage.Location = new System.Drawing.Point(124, 4);
			ClientsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			ClientsTabPage.Name = "ClientsTabPage";
			ClientsTabPage.Size = new System.Drawing.Size(457, 327);
			ClientsTabPage.TabIndex = 4;
			ClientsTabPage.Text = "Active Clients";
			// 
			// ClientsPanel
			// 
			ClientsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			ClientsPanel.Controls.Add(this.ThumbnailsList);
			ClientsPanel.Controls.Add(ThumbnailsListLabel);
			ClientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			ClientsPanel.Location = new System.Drawing.Point(0, 0);
			ClientsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			ClientsPanel.Name = "ClientsPanel";
			ClientsPanel.Size = new System.Drawing.Size(457, 327);
			ClientsPanel.TabIndex = 32;
			// 
			// ThumbnailsList
			// 
			this.ThumbnailsList.BackColor = System.Drawing.SystemColors.Window;
			this.ThumbnailsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ThumbnailsList.CheckOnClick = true;
			this.ThumbnailsList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ThumbnailsList.FormattingEnabled = true;
			this.ThumbnailsList.IntegralHeight = false;
			this.ThumbnailsList.Location = new System.Drawing.Point(0, 49);
			this.ThumbnailsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ThumbnailsList.Name = "ThumbnailsList";
			this.ThumbnailsList.Size = new System.Drawing.Size(455, 276);
			this.ThumbnailsList.TabIndex = 34;
			this.ThumbnailsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ThumbnailsList_ItemCheck_Handler);
			// 
			// ThumbnailsListLabel
			// 
			ThumbnailsListLabel.AutoSize = true;
			ThumbnailsListLabel.Location = new System.Drawing.Point(12, 14);
			ThumbnailsListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			ThumbnailsListLabel.Name = "ThumbnailsListLabel";
			ThumbnailsListLabel.Size = new System.Drawing.Size(238, 20);
			ThumbnailsListLabel.TabIndex = 33;
			ThumbnailsListLabel.Text = "Thumbnails (check to force hide)";
			// 
			// AboutTabPage
			// 
			AboutTabPage.BackColor = System.Drawing.SystemColors.Control;
			AboutTabPage.Controls.Add(AboutPanel);
			AboutTabPage.Location = new System.Drawing.Point(124, 4);
			AboutTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			AboutTabPage.Name = "AboutTabPage";
			AboutTabPage.Size = new System.Drawing.Size(457, 327);
			AboutTabPage.TabIndex = 5;
			AboutTabPage.Text = "About";
			// 
			// AboutPanel
			// 
			AboutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			AboutPanel.Controls.Add(DocumentationLinkLabel);
			AboutPanel.Controls.Add(DescriptionLabel);
			AboutPanel.Controls.Add(this.VersionLabel);
			AboutPanel.Controls.Add(NameLabel);
			AboutPanel.Controls.Add(this.DocumentationLink);
			AboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			AboutPanel.Location = new System.Drawing.Point(0, 0);
			AboutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			AboutPanel.Name = "AboutPanel";
			AboutPanel.Size = new System.Drawing.Size(457, 327);
			AboutPanel.TabIndex = 2;
			// 
			// DocumentationLinkLabel
			// 
			DocumentationLinkLabel.AutoSize = true;
			DocumentationLinkLabel.Location = new System.Drawing.Point(0, 242);
			DocumentationLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			DocumentationLinkLabel.Name = "DocumentationLinkLabel";
			DocumentationLinkLabel.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
			DocumentationLinkLabel.Size = new System.Drawing.Size(336, 30);
			DocumentationLinkLabel.TabIndex = 6;
			DocumentationLinkLabel.Text = "For more information visit the forum thread:";
			// 
			// DescriptionLabel
			// 
			DescriptionLabel.Location = new System.Drawing.Point(0, 63);
			DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			DescriptionLabel.Name = "DescriptionLabel";
			DescriptionLabel.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
			DescriptionLabel.Size = new System.Drawing.Size(392, 178);
			DescriptionLabel.TabIndex = 5;
			DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
			// 
			// VersionLabel
			// 
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VersionLabel.Location = new System.Drawing.Point(200, 14);
			this.VersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(69, 29);
			this.VersionLabel.TabIndex = 4;
			this.VersionLabel.Text = "1.0.0";
			// 
			// NameLabel
			// 
			NameLabel.AutoSize = true;
			NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			NameLabel.Location = new System.Drawing.Point(6, 14);
			NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new System.Drawing.Size(193, 29);
			NameLabel.TabIndex = 3;
			NameLabel.Text = "EVE-O Preview";
			// 
			// DocumentationLink
			// 
			this.DocumentationLink.Location = new System.Drawing.Point(0, 266);
			this.DocumentationLink.Margin = new System.Windows.Forms.Padding(45, 5, 4, 5);
			this.DocumentationLink.Name = "DocumentationLink";
			this.DocumentationLink.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
			this.DocumentationLink.Size = new System.Drawing.Size(393, 51);
			this.DocumentationLink.TabIndex = 2;
			this.DocumentationLink.TabStop = true;
			this.DocumentationLink.Text = "to be set from prresenter to be set from prresenter to be set from prresenter to " +
    "be set from prresenter";
			this.DocumentationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DocumentationLinkClicked_Handler);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.ContextMenuStrip = this.TrayMenu;
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "EVE-O Preview";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RestoreMainForm_Handler);
			// 
			// TrayMenu
			// 
			this.TrayMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            TitleMenuItem,
            RestoreWindowMenuItem,
            SeparatorMenuItem,
            ExitMenuItem});
			this.TrayMenu.Name = "contextMenuStrip1";
			this.TrayMenu.Size = new System.Drawing.Size(200, 100);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(585, 400);
			this.Controls.Add(ContentTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "EVE-O Preview";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing_Handler);
			this.Load += new System.EventHandler(this.MainFormResize_Handler);
			this.Resize += new System.EventHandler(this.MainFormResize_Handler);
			ContentTabControl.ResumeLayout(false);
			
			this.ZoomTabPage.ResumeLayout(false);
			ZoomSettingsPanel.ResumeLayout(false);
			ZoomSettingsPanel.PerformLayout();
			this.ZoomAnchorPanel.ResumeLayout(false);
			this.ZoomAnchorPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailZoomFactorNumericEdit)).EndInit();
			OverlayTabPage.ResumeLayout(false);
			OverlaySettingsPanel.ResumeLayout(false);
			OverlaySettingsPanel.PerformLayout();
			ClientsTabPage.ResumeLayout(false);
			ClientsPanel.ResumeLayout(false);
			ClientsPanel.PerformLayout();
			AboutTabPage.ResumeLayout(false);
			AboutPanel.ResumeLayout(false);
			AboutPanel.PerformLayout();
			this.TrayMenu.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        /*
        this.MinimizeInactiveClientsCheckBox = new System.Windows.Forms.CheckBox();
        this.EnableClientLayoutTrackingCheckBox = new System.Windows.Forms.CheckBox();
        this.HideActiveClientThumbnailCheckBox = new System.Windows.Forms.CheckBox();
        this.ShowThumbnailsAlwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
        this.HideThumbnailsOnLostFocusCheckBox = new System.Windows.Forms.CheckBox();
        this.EnablePerClientThumbnailsLayoutsCheckBox = new System.Windows.Forms.CheckBox();
        this.SetLocalThumbnailWindowPosition = new System.Windows.Forms.CheckBox();
        this.MinimizeToTrayCheckBox = new System.Windows.Forms.CheckBox();
        */
        private NotifyIcon NotifyIcon;
		private ContextMenuStrip TrayMenu;
		private TabPage ZoomTabPage;

		private Panel ZoomAnchorPanel;
		private RadioButton ZoomAanchorNWRadioButton;
		private RadioButton ZoomAanchorNRadioButton;
		private RadioButton ZoomAanchorNERadioButton;
		private RadioButton ZoomAanchorWRadioButton;
		private RadioButton ZoomAanchorSERadioButton;
		private RadioButton ZoomAanchorCRadioButton;
		private RadioButton ZoomAanchorSRadioButton;
		private RadioButton ZoomAanchorERadioButton;
		private RadioButton ZoomAanchorSWRadioButton;
		private CheckBox EnableThumbnailZoomCheckBox;
		private NumericUpDown ThumbnailZoomFactorNumericEdit;
		private Label HighlightColorLabel;
		private Panel ActiveClientHighlightColorButton;
		private CheckBox EnableActiveClientHighlightCheckBox;
		private CheckBox ShowThumbnailOverlaysCheckBox;
		private CheckBox ShowThumbnailFramesCheckBox;
		private CheckedListBox ThumbnailsList;
		private LinkLabel DocumentationLink;
		private Label VersionLabel;
		//
	}
}