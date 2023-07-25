using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
			//
		
			//
			System.Windows.Forms.TabPage ClientsTabPage;
			System.Windows.Forms.Panel ClientsPanel;
			System.Windows.Forms.Label ThumbnailsListLabel;
			
            //

            //
            General = new GeneralTab(this);
			Thumbnail = new ThumbnailTab(this);
			Zoom = new ZoomTab(this);
            LocalWatcher = new LocalWatcherTab(this);
            Overlay = new OverlayTab(this);
			About = new AboutTab(this);

            this.ThumbnailsList = new System.Windows.Forms.CheckedListBox();
			this.DocumentationLink = new System.Windows.Forms.LinkLabel();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			RestoreWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			TitleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			SeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
			ContentTabControl = new System.Windows.Forms.TabControl();
			ClientsTabPage = new System.Windows.Forms.TabPage();
			ClientsPanel = new System.Windows.Forms.Panel();
			ThumbnailsListLabel = new System.Windows.Forms.Label();

            foreach (PageAndPanel Page in Pages)
            {
                Page.Suspend();
            }

            ContentTabControl.SuspendLayout();
			ClientsTabPage.SuspendLayout();
			ClientsPanel.SuspendLayout();
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
			ContentTabControl.Controls.Add(Zoom.Page);
			ContentTabControl.Controls.Add(LocalWatcher.Page);
			ContentTabControl.Controls.Add(Overlay.Page);
			ContentTabControl.Controls.Add(ClientsTabPage);
			ContentTabControl.Controls.Add(About.Page);
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

			// DocumentationLink
			// 
			this.DocumentationLink.Location = new System.Drawing.Point(0, 266);
			this.DocumentationLink.Margin = new System.Windows.Forms.Padding(45, 5, 4, 5);
			this.DocumentationLink.Name = "DocumentationLink";
			this.DocumentationLink.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
			this.DocumentationLink.Size = new System.Drawing.Size(393, 51);
			this.DocumentationLink.TabIndex = 2;
			this.DocumentationLink.TabStop = true;
			this.DocumentationLink.Text = "to be set from presenter to be set from presenter to be set from prresenter to " +
    "be set from presenter";
			this.DocumentationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DocumentationLinkClicked_Handler);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.ContextMenuStrip = this.TrayMenu;
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(About.resources.GetObject("NotifyIcon.Icon")));
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
			this.Icon = ((System.Drawing.Icon)(About.resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "EVE-O Preview";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing_Handler);
			this.Load += new System.EventHandler(this.MainFormResize_Handler);
			this.Resize += new System.EventHandler(this.MainFormResize_Handler);

            foreach (PageAndPanel Page in Pages)
			{
				Page.ResumeLayout();
			}

            ContentTabControl.ResumeLayout(false);
			ClientsTabPage.ResumeLayout(false);
			ClientsPanel.ResumeLayout(false);
			ClientsPanel.PerformLayout();
			this.TrayMenu.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private NotifyIcon NotifyIcon;
		private ContextMenuStrip TrayMenu;
		private CheckedListBox ThumbnailsList;
		private LinkLabel DocumentationLink;
		//
	}
}