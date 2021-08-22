/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

namespace Opc.Ua.Sample.Controls
{
    partial class ClientForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLoadMI = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PerformanceTestMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Task_TestMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscoveyrMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscoverServersMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscoveryServersOnNetworkMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Discovery_RegisterMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ServerUrlLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.ServerStatusLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.SessionsPanel = new System.Windows.Forms.SplitContainer();
            this.EndpointSelectorCTRL = new Opc.Ua.Client.Controls.EndpointSelectorCtrl();
            this.clientHeaderBranding1 = new Opc.Ua.Client.Controls.HeaderBranding();
            this.SessionsCTRL = new Opc.Ua.Sample.Controls.SessionTreeCtrl();
            this.NotificationsCTRL = new Opc.Ua.Sample.Controls.NotificationMessageListCtrl();
            this.BrowseCTRL = new Opc.Ua.Sample.Controls.BrowseTreeCtrl();
            this.MainMenu.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionsPanel)).BeginInit();
            this.SessionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMI,
            this.TaskMI,
            this.DiscoveyrMI,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(584, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.Visible = false;
            // 
            // FileMI
            // 
            this.FileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileLoadMI,
            this.FileSaveMI,
            this.FileSaveAsMI,
            this.toolStripMenuItem1,
            this.FileExit});
            this.FileMI.Name = "FileMI";
            this.FileMI.Size = new System.Drawing.Size(37, 20);
            this.FileMI.Text = "File";
            // 
            // FileLoadMI
            // 
            this.FileLoadMI.Name = "FileLoadMI";
            this.FileLoadMI.Size = new System.Drawing.Size(123, 22);
            this.FileLoadMI.Text = "Load...";
            // 
            // FileSaveMI
            // 
            this.FileSaveMI.Name = "FileSaveMI";
            this.FileSaveMI.Size = new System.Drawing.Size(123, 22);
            this.FileSaveMI.Text = "Save";
            // 
            // FileSaveAsMI
            // 
            this.FileSaveAsMI.Name = "FileSaveAsMI";
            this.FileSaveAsMI.Size = new System.Drawing.Size(123, 22);
            this.FileSaveAsMI.Text = "Save As...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(123, 22);
            this.FileExit.Text = "Exit";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // TaskMI
            // 
            this.TaskMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWindowMI,
            this.PerformanceTestMI,
            this.toolStripSeparator1,
            this.Task_TestMI});
            this.TaskMI.Name = "TaskMI";
            this.TaskMI.Size = new System.Drawing.Size(41, 20);
            this.TaskMI.Text = "Task";
            // 
            // NewWindowMI
            // 
            this.NewWindowMI.Name = "NewWindowMI";
            this.NewWindowMI.Size = new System.Drawing.Size(154, 22);
            this.NewWindowMI.Text = "New Window...";
            this.NewWindowMI.Click += new System.EventHandler(this.NewWindowMI_Click);
            // 
            // PerformanceTestMI
            // 
            this.PerformanceTestMI.Name = "PerformanceTestMI";
            this.PerformanceTestMI.Size = new System.Drawing.Size(154, 22);
            this.PerformanceTestMI.Text = "Stack Test...";
            this.PerformanceTestMI.Click += new System.EventHandler(this.PerformanceTestMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // Task_TestMI
            // 
            this.Task_TestMI.Name = "Task_TestMI";
            this.Task_TestMI.Size = new System.Drawing.Size(154, 22);
            this.Task_TestMI.Text = "Test 1";
            this.Task_TestMI.Click += new System.EventHandler(this.Task_TestMI_Click);
            // 
            // DiscoveyrMI
            // 
            this.DiscoveyrMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiscoverServersMI,
            this.DiscoveryServersOnNetworkMI,
            this.Discovery_RegisterMI});
            this.DiscoveyrMI.Name = "DiscoveyrMI";
            this.DiscoveyrMI.Size = new System.Drawing.Size(70, 20);
            this.DiscoveyrMI.Text = "Discovery";
            // 
            // DiscoverServersMI
            // 
            this.DiscoverServersMI.Name = "DiscoverServersMI";
            this.DiscoverServersMI.Size = new System.Drawing.Size(185, 22);
            this.DiscoverServersMI.Text = "Servers...";
            this.DiscoverServersMI.Click += new System.EventHandler(this.DiscoverServersMI_Click);
            // 
            // DiscoveryServersOnNetworkMI
            // 
            this.DiscoveryServersOnNetworkMI.Name = "DiscoveryServersOnNetworkMI";
            this.DiscoveryServersOnNetworkMI.Size = new System.Drawing.Size(185, 22);
            this.DiscoveryServersOnNetworkMI.Text = "Servers on Network...";
            this.DiscoveryServersOnNetworkMI.Click += new System.EventHandler(this.DiscoveryServersOnNetworkMI_Click);
            // 
            // Discovery_RegisterMI
            // 
            this.Discovery_RegisterMI.Name = "Discovery_RegisterMI";
            this.Discovery_RegisterMI.Size = new System.Drawing.Size(185, 22);
            this.Discovery_RegisterMI.Text = "Register Now";
            this.Discovery_RegisterMI.Click += new System.EventHandler(this.Discovery_RegisterMI_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerUrlLB,
            this.ServerStatusLB});
            this.StatusStrip.Location = new System.Drawing.Point(0, 539);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(584, 22);
            this.StatusStrip.TabIndex = 6;
            this.StatusStrip.Text = "statusStrip1";
            this.StatusStrip.Visible = false;
            // 
            // ServerUrlLB
            // 
            this.ServerUrlLB.Name = "ServerUrlLB";
            this.ServerUrlLB.Size = new System.Drawing.Size(79, 17);
            this.ServerUrlLB.Text = "Disconnected";
            // 
            // ServerStatusLB
            // 
            this.ServerStatusLB.Name = "ServerStatusLB";
            this.ServerStatusLB.Size = new System.Drawing.Size(49, 17);
            this.ServerStatusLB.Text = "00:00:00";
            // 
            // SessionsPanel
            // 
            this.SessionsPanel.Location = new System.Drawing.Point(0, 0);
            this.SessionsPanel.Name = "SessionsPanel";
            this.SessionsPanel.Size = new System.Drawing.Size(150, 100);
            this.SessionsPanel.TabIndex = 0;
            // 
            // EndpointSelectorCTRL
            // 
            this.EndpointSelectorCTRL.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.EndpointSelectorCTRL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(81)))));
            this.EndpointSelectorCTRL.Location = new System.Drawing.Point(65, 189);
            this.EndpointSelectorCTRL.Name = "EndpointSelectorCTRL";
            this.EndpointSelectorCTRL.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.EndpointSelectorCTRL.SelectedEndpoint = null;
            this.EndpointSelectorCTRL.Size = new System.Drawing.Size(454, 122);
            this.EndpointSelectorCTRL.TabIndex = 2;
            this.EndpointSelectorCTRL.ConnectEndpoint += new Opc.Ua.Client.Controls.ConnectEndpointEventHandler(this.EndpointSelectorCTRL_ConnectEndpoint);
            this.EndpointSelectorCTRL.EndpointsChanged += new System.EventHandler(this.EndpointSelectorCTRL_OnChange);
            // 
            // clientHeaderBranding1
            // 
            this.clientHeaderBranding1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientHeaderBranding1.BackColor = System.Drawing.Color.White;
            this.clientHeaderBranding1.Location = new System.Drawing.Point(445, 34);
            this.clientHeaderBranding1.MaximumSize = new System.Drawing.Size(0, 100);
            this.clientHeaderBranding1.MinimumSize = new System.Drawing.Size(500, 90);
            this.clientHeaderBranding1.Name = "clientHeaderBranding1";
            this.clientHeaderBranding1.Padding = new System.Windows.Forms.Padding(3);
            this.clientHeaderBranding1.Size = new System.Drawing.Size(500, 90);
            this.clientHeaderBranding1.TabIndex = 9;
            this.clientHeaderBranding1.Visible = false;
            // 
            // SessionsCTRL
            // 
            this.SessionsCTRL.AddressSpaceCtrl = null;
            this.SessionsCTRL.Configuration = null;
            this.SessionsCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessionsCTRL.EnableDragging = false;
            this.SessionsCTRL.Location = new System.Drawing.Point(0, 0);
            this.SessionsCTRL.MessageContext = null;
            this.SessionsCTRL.Name = "SessionsCTRL";
            this.SessionsCTRL.NotificationMessagesCtrl = this.NotificationsCTRL;
            this.SessionsCTRL.PreferredLocales = null;
            this.SessionsCTRL.ServerStatusCtrl = null;
            this.SessionsCTRL.Size = new System.Drawing.Size(65, 237);
            this.SessionsCTRL.TabIndex = 0;
            this.SessionsCTRL.Visible = false;
            // 
            // NotificationsCTRL
            // 
            this.NotificationsCTRL.EnableDragging = true;
            this.NotificationsCTRL.Instructions = "Create a subscription to see notifications";
            this.NotificationsCTRL.Location = new System.Drawing.Point(91, 96);
            this.NotificationsCTRL.MaxMessageCount = 10;
            this.NotificationsCTRL.Name = "NotificationsCTRL";
            this.NotificationsCTRL.Size = new System.Drawing.Size(299, 50);
            this.NotificationsCTRL.TabIndex = 0;
            this.NotificationsCTRL.Visible = false;
            // 
            // BrowseCTRL
            // 
            this.BrowseCTRL.AttributesCtrl = null;
            this.BrowseCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseCTRL.EnableDragging = true;
            this.BrowseCTRL.Location = new System.Drawing.Point(0, 0);
            this.BrowseCTRL.Name = "BrowseCTRL";
            this.BrowseCTRL.SessionTreeCtrl = null;
            this.BrowseCTRL.Size = new System.Drawing.Size(484, 237);
            this.BrowseCTRL.TabIndex = 0;
            this.BrowseCTRL.Visible = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.EndpointSelectorCTRL);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.clientHeaderBranding1);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UA Sample Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionsPanel)).EndInit();
            this.SessionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem TaskMI;
        private Opc.Ua.Client.Controls.EndpointSelectorCtrl EndpointSelectorCTRL;
        private System.Windows.Forms.SplitContainer SessionsPanel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ServerUrlLB;
        private System.Windows.Forms.SplitContainer MainPN;
        private Opc.Ua.Sample.Controls.NotificationMessageListCtrl NotificationsCTRL;
        private System.Windows.Forms.ToolStripMenuItem PerformanceTestMI;
        private System.Windows.Forms.ToolStripMenuItem FileMI;
        private System.Windows.Forms.ToolStripMenuItem FileLoadMI;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAsMI;
        private System.Windows.Forms.ToolStripStatusLabel ServerStatusLB;
        private System.Windows.Forms.ToolStripMenuItem DiscoveyrMI;
        private System.Windows.Forms.ToolStripMenuItem DiscoverServersMI;
        private System.Windows.Forms.ToolStripMenuItem NewWindowMI;
        protected SessionTreeCtrl SessionsCTRL;
        private System.Windows.Forms.ToolStripMenuItem Discovery_RegisterMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Task_TestMI;
        private Opc.Ua.Client.Controls.HeaderBranding clientHeaderBranding1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiscoveryServersOnNetworkMI;
        protected BrowseTreeCtrl BrowseCTRL;
    }
}
