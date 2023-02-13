namespace WebApp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.URL = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.header_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dynamic_label = new System.Windows.Forms.Label();
            this.app_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.tooltip_search_button = new System.Windows.Forms.ToolTip(this.components);
            this.EditBookmarkButton = new System.Windows.Forms.Button();
            this.DeleteBookmarkButton = new System.Windows.Forms.Button();
            this.OpenBookmarkInNewTabButton = new System.Windows.Forms.Button();
            this.DeleteHistoryButton = new System.Windows.Forms.Button();
            this.OpenHistoryInNewTabButton = new System.Windows.Forms.Button();
            this.tooltip_bookmark_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_history_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_url = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_home_button = new System.Windows.Forms.ToolTip(this.components);
            this.back_button = new System.Windows.Forms.Button();
            this.forward_button = new System.Windows.Forms.Button();
            this.reload_button = new System.Windows.Forms.Button();
            this.tooltip_close_button = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookmarkList = new System.Windows.Forms.ListBox();
            this.historyList = new System.Windows.Forms.ListBox();
            this.bulkDownload = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBookmarkPanel = new System.Windows.Forms.Panel();
            this.EditHistoryPanel = new System.Windows.Forms.Panel();
            this.tooltip_historyDelete_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_historyOpen_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_editBookmark_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_bookmarkDelete_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_bookmarkOpen_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_back_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_forward_button = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_reload_button = new System.Windows.Forms.ToolTip(this.components);
            this.header_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.EditBookmarkPanel.SuspendLayout();
            this.EditHistoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.BackColor = System.Drawing.Color.White;
            this.URL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.URL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.URL.Location = new System.Drawing.Point(252, 116);
            this.URL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(925, 34);
            this.URL.TabIndex = 1;
            this.tooltip_url.SetToolTip(this.URL, "Search Bar: The URL to be searched is entered here.");
            this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchWithEnterKey);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_button.Image = ((System.Drawing.Image)(resources.GetObject("search_button.Image")));
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_button.Location = new System.Drawing.Point(1198, 114);
            this.search_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(35, 35);
            this.search_button.TabIndex = 3;
            this.search_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_search_button.SetToolTip(this.search_button, "Search Button: This will search for the URL entered in the textbox.");
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.SearchButtonIconClick);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_button.Location = new System.Drawing.Point(198, 114);
            this.home_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(35, 35);
            this.home_button.TabIndex = 4;
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_home_button.SetToolTip(this.home_button, "Home Button: This button will bring back to the home page.");
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.HomeButtonIconClick);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.Gray;
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.Controls.Add(this.dynamic_label);
            this.header_panel.Controls.Add(this.app_label);
            this.header_panel.Controls.Add(this.close_button);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1256, 53);
            this.header_panel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 6;
            // 
            // dynamic_label
            // 
            this.dynamic_label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dynamic_label.ForeColor = System.Drawing.Color.White;
            this.dynamic_label.Location = new System.Drawing.Point(240, 15);
            this.dynamic_label.Name = "dynamic_label";
            this.dynamic_label.Size = new System.Drawing.Size(814, 28);
            this.dynamic_label.TabIndex = 5;
            this.dynamic_label.Text = "WEB";
            this.dynamic_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // app_label
            // 
            this.app_label.AutoSize = true;
            this.app_label.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.app_label.ForeColor = System.Drawing.Color.White;
            this.app_label.Location = new System.Drawing.Point(43, 12);
            this.app_label.Name = "app_label";
            this.app_label.Size = new System.Drawing.Size(201, 31);
            this.app_label.TabIndex = 4;
            this.app_label.Text = "SAL Browser";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(1198, 7);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(46, 40);
            this.close_button.TabIndex = 2;
            this.tooltip_close_button.SetToolTip(this.close_button, "Close Button: This button will close the application.");
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.ApplicationClose);
            // 
            // EditBookmarkButton
            // 
            this.EditBookmarkButton.BackColor = System.Drawing.Color.Transparent;
            this.EditBookmarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBookmarkButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("EditBookmarkButton.Image")));
            this.EditBookmarkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBookmarkButton.Location = new System.Drawing.Point(10, 13);
            this.EditBookmarkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBookmarkButton.Name = "EditBookmarkButton";
            this.EditBookmarkButton.Size = new System.Drawing.Size(35, 35);
            this.EditBookmarkButton.TabIndex = 19;
            this.EditBookmarkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_editBookmark_button.SetToolTip(this.EditBookmarkButton, "Edit Bookmark Button: This will enable to edit the selected URL name and address." +
        "");
            this.EditBookmarkButton.UseVisualStyleBackColor = false;
            this.EditBookmarkButton.Visible = false;
            this.EditBookmarkButton.Click += new System.EventHandler(this.BookmarksEdit);
            // 
            // DeleteBookmarkButton
            // 
            this.DeleteBookmarkButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBookmarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBookmarkButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBookmarkButton.Image")));
            this.DeleteBookmarkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBookmarkButton.Location = new System.Drawing.Point(10, 58);
            this.DeleteBookmarkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBookmarkButton.Name = "DeleteBookmarkButton";
            this.DeleteBookmarkButton.Size = new System.Drawing.Size(35, 35);
            this.DeleteBookmarkButton.TabIndex = 20;
            this.DeleteBookmarkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_bookmarkDelete_button.SetToolTip(this.DeleteBookmarkButton, "Bookmark Delete Button: This will delete the selected bookmark from the list.");
            this.DeleteBookmarkButton.UseVisualStyleBackColor = false;
            this.DeleteBookmarkButton.Visible = false;
            this.DeleteBookmarkButton.Click += new System.EventHandler(this.BookmarksDelete);
            // 
            // OpenBookmarkInNewTabButton
            // 
            this.OpenBookmarkInNewTabButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenBookmarkInNewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBookmarkInNewTabButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenBookmarkInNewTabButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenBookmarkInNewTabButton.Image")));
            this.OpenBookmarkInNewTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenBookmarkInNewTabButton.Location = new System.Drawing.Point(10, 103);
            this.OpenBookmarkInNewTabButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenBookmarkInNewTabButton.Name = "OpenBookmarkInNewTabButton";
            this.OpenBookmarkInNewTabButton.Size = new System.Drawing.Size(35, 35);
            this.OpenBookmarkInNewTabButton.TabIndex = 21;
            this.OpenBookmarkInNewTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_bookmarkOpen_button.SetToolTip(this.OpenBookmarkInNewTabButton, "Bookmark Open Button: This will open the selected bookmark in a new tab.");
            this.OpenBookmarkInNewTabButton.UseVisualStyleBackColor = false;
            this.OpenBookmarkInNewTabButton.Visible = false;
            this.OpenBookmarkInNewTabButton.Click += new System.EventHandler(this.LoadTabWithUserBookmark);
            // 
            // DeleteHistoryButton
            // 
            this.DeleteHistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteHistoryButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteHistoryButton.Image")));
            this.DeleteHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteHistoryButton.Location = new System.Drawing.Point(10, 14);
            this.DeleteHistoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteHistoryButton.Name = "DeleteHistoryButton";
            this.DeleteHistoryButton.Size = new System.Drawing.Size(35, 35);
            this.DeleteHistoryButton.TabIndex = 20;
            this.DeleteHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_historyDelete_button.SetToolTip(this.DeleteHistoryButton, "History Delete Button: This will delete the selected history from the list.");
            this.DeleteHistoryButton.UseVisualStyleBackColor = false;
            this.DeleteHistoryButton.Visible = false;
            this.DeleteHistoryButton.Click += new System.EventHandler(this.HistoryDelete);
            // 
            // OpenHistoryInNewTabButton
            // 
            this.OpenHistoryInNewTabButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenHistoryInNewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenHistoryInNewTabButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenHistoryInNewTabButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenHistoryInNewTabButton.Image")));
            this.OpenHistoryInNewTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenHistoryInNewTabButton.Location = new System.Drawing.Point(10, 59);
            this.OpenHistoryInNewTabButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenHistoryInNewTabButton.Name = "OpenHistoryInNewTabButton";
            this.OpenHistoryInNewTabButton.Size = new System.Drawing.Size(35, 35);
            this.OpenHistoryInNewTabButton.TabIndex = 21;
            this.OpenHistoryInNewTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_historyOpen_button.SetToolTip(this.OpenHistoryInNewTabButton, "Open Selected History Button: This will open the selected URL from the list in ne" +
        "w tab.");
            this.OpenHistoryInNewTabButton.UseVisualStyleBackColor = false;
            this.OpenHistoryInNewTabButton.Visible = false;
            this.OpenHistoryInNewTabButton.Click += new System.EventHandler(this.LoadTabWithUserHistory);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_button.Location = new System.Drawing.Point(48, 114);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(35, 35);
            this.back_button.TabIndex = 10;
            this.back_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_back_button.SetToolTip(this.back_button, "Back Button: This will open the previous tab URL.");
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.BackButtonIconClick);
            // 
            // forward_button
            // 
            this.forward_button.BackColor = System.Drawing.Color.Transparent;
            this.forward_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_button.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forward_button.Image = ((System.Drawing.Image)(resources.GetObject("forward_button.Image")));
            this.forward_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forward_button.Location = new System.Drawing.Point(98, 114);
            this.forward_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(35, 35);
            this.forward_button.TabIndex = 11;
            this.forward_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_forward_button.SetToolTip(this.forward_button, "Forward Button: This will open the URL from which you previously returned.");
            this.forward_button.UseVisualStyleBackColor = false;
            this.forward_button.Click += new System.EventHandler(this.ForwardButtonIconClick);
            // 
            // reload_button
            // 
            this.reload_button.BackColor = System.Drawing.Color.Transparent;
            this.reload_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload_button.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reload_button.Image = ((System.Drawing.Image)(resources.GetObject("reload_button.Image")));
            this.reload_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reload_button.Location = new System.Drawing.Point(148, 114);
            this.reload_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reload_button.Name = "reload_button";
            this.reload_button.Size = new System.Drawing.Size(35, 35);
            this.reload_button.TabIndex = 12;
            this.reload_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip_reload_button.SetToolTip(this.reload_button, "Reload Button: This will reload the current tab.");
            this.reload_button.UseVisualStyleBackColor = false;
            this.reload_button.Click += new System.EventHandler(this.ReloadButtonIconClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(54, 181);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 700);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabController_SelectedIndexChanged);
            // 
            // bookmarkList
            // 
            this.bookmarkList.BackColor = System.Drawing.Color.White;
            this.bookmarkList.FormattingEnabled = true;
            this.bookmarkList.ItemHeight = 25;
            this.bookmarkList.Location = new System.Drawing.Point(795, 527);
            this.bookmarkList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookmarkList.Name = "bookmarkList";
            this.bookmarkList.Size = new System.Drawing.Size(402, 354);
            this.bookmarkList.TabIndex = 16;
            this.bookmarkList.Visible = false;
            this.bookmarkList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookmarksLeftClickMouse);
            // 
            // historyList
            // 
            this.historyList.BackColor = System.Drawing.Color.White;
            this.historyList.FormattingEnabled = true;
            this.historyList.ItemHeight = 25;
            this.historyList.Location = new System.Drawing.Point(795, 181);
            this.historyList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(402, 329);
            this.historyList.TabIndex = 17;
            this.historyList.Visible = false;
            this.historyList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HistoryLeftClickMouse);
            // 
            // bulkDownload
            // 
            this.bulkDownload.FileName = "openFileDialog1";
            this.bulkDownload.Filter = "*.txt|";
            this.bulkDownload.Title = "Select a txt file";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.tabsToolStripMenuItem1,
            this.historyToolStripMenuItem1,
            this.bookmarksToolStripMenuItem2,
            this.favouritesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 53);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editHomePageToolStripMenuItem});
            this.homePageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.homePageToolStripMenuItem.Text = "Home";
            // 
            // editHomePageToolStripMenuItem
            // 
            this.editHomePageToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.editHomePageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editHomePageToolStripMenuItem.Name = "editHomePageToolStripMenuItem";
            this.editHomePageToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.editHomePageToolStripMenuItem.Text = "Edit Home Page";
            this.editHomePageToolStripMenuItem.Click += new System.EventHandler(this.HomePageEditMenuItem);
            // 
            // tabsToolStripMenuItem1
            // 
            this.tabsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeTabToolStripMenuItem});
            this.tabsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tabsToolStripMenuItem1.Name = "tabsToolStripMenuItem1";
            this.tabsToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.tabsToolStripMenuItem1.Text = "Tab";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.newTabToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.NewTabOpen);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.closeTabToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.TerminateCurrentTab);
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryToolStripMenuItem,
            this.closeHistoryToolStripMenuItem,
            this.clearHistoryToolStripMenuItem});
            this.historyToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(102, 24);
            this.historyToolStripMenuItem1.Text = "History";
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.viewHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.viewHistoryToolStripMenuItem.Text = "View History";
            this.viewHistoryToolStripMenuItem.Click += new System.EventHandler(this.ViewHistoryMenuItem);
            // 
            // closeHistoryToolStripMenuItem
            // 
            this.closeHistoryToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.closeHistoryToolStripMenuItem.Enabled = false;
            this.closeHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeHistoryToolStripMenuItem.Name = "closeHistoryToolStripMenuItem";
            this.closeHistoryToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.closeHistoryToolStripMenuItem.Text = "Close History";
            this.closeHistoryToolStripMenuItem.Click += new System.EventHandler(this.CloseHistoryMenuItem);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.clearHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.ClearHistoryMenuItem);
            // 
            // bookmarksToolStripMenuItem2
            // 
            this.bookmarksToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBookmarksToolStripMenuItem,
            this.closeBookmarksToolStripMenuItem,
            this.clearBookmarksToolStripMenuItem});
            this.bookmarksToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.bookmarksToolStripMenuItem2.Name = "bookmarksToolStripMenuItem2";
            this.bookmarksToolStripMenuItem2.Size = new System.Drawing.Size(124, 24);
            this.bookmarksToolStripMenuItem2.Text = "Bookmarks";
            // 
            // viewBookmarksToolStripMenuItem
            // 
            this.viewBookmarksToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.viewBookmarksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewBookmarksToolStripMenuItem.Name = "viewBookmarksToolStripMenuItem";
            this.viewBookmarksToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.viewBookmarksToolStripMenuItem.Text = "View Bookmarks";
            this.viewBookmarksToolStripMenuItem.Click += new System.EventHandler(this.ViewBookmarksMenuItem);
            // 
            // closeBookmarksToolStripMenuItem
            // 
            this.closeBookmarksToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.closeBookmarksToolStripMenuItem.Enabled = false;
            this.closeBookmarksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeBookmarksToolStripMenuItem.Name = "closeBookmarksToolStripMenuItem";
            this.closeBookmarksToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.closeBookmarksToolStripMenuItem.Text = "Close Bookmarks";
            this.closeBookmarksToolStripMenuItem.Click += new System.EventHandler(this.CloseBookmarksMenuItem);
            // 
            // clearBookmarksToolStripMenuItem
            // 
            this.clearBookmarksToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.clearBookmarksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clearBookmarksToolStripMenuItem.Name = "clearBookmarksToolStripMenuItem";
            this.clearBookmarksToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.clearBookmarksToolStripMenuItem.Text = "Clear Bookmarks";
            this.clearBookmarksToolStripMenuItem.Click += new System.EventHandler(this.ClearBookmarksMenuItem);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkPageToolStripMenuItem,
            this.bulkDownloadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.favouritesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.favouritesToolStripMenuItem.Text = "Options";
            // 
            // bookmarkPageToolStripMenuItem
            // 
            this.bookmarkPageToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.bookmarkPageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookmarkPageToolStripMenuItem.Name = "bookmarkPageToolStripMenuItem";
            this.bookmarkPageToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.bookmarkPageToolStripMenuItem.Text = "Bookmark Page";
            this.bookmarkPageToolStripMenuItem.Click += new System.EventHandler(this.BookmarkMenuItem);
            // 
            // bulkDownloadToolStripMenuItem
            // 
            this.bulkDownloadToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.bulkDownloadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bulkDownloadToolStripMenuItem.Name = "bulkDownloadToolStripMenuItem";
            this.bulkDownloadToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.bulkDownloadToolStripMenuItem.Text = "Bulk Download";
            this.bulkDownloadToolStripMenuItem.Click += new System.EventHandler(this.BulkDownloadMenuItem);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.ApplicationClose);
            // 
            // EditBookmarkPanel
            // 
            this.EditBookmarkPanel.BackColor = System.Drawing.Color.Gray;
            this.EditBookmarkPanel.Controls.Add(this.DeleteBookmarkButton);
            this.EditBookmarkPanel.Controls.Add(this.OpenBookmarkInNewTabButton);
            this.EditBookmarkPanel.Controls.Add(this.EditBookmarkButton);
            this.EditBookmarkPanel.Location = new System.Drawing.Point(1201, 637);
            this.EditBookmarkPanel.Name = "EditBookmarkPanel";
            this.EditBookmarkPanel.Size = new System.Drawing.Size(55, 150);
            this.EditBookmarkPanel.TabIndex = 22;
            this.EditBookmarkPanel.Visible = false;
            // 
            // EditHistoryPanel
            // 
            this.EditHistoryPanel.BackColor = System.Drawing.Color.Gray;
            this.EditHistoryPanel.Controls.Add(this.DeleteHistoryButton);
            this.EditHistoryPanel.Controls.Add(this.OpenHistoryInNewTabButton);
            this.EditHistoryPanel.Location = new System.Drawing.Point(1201, 304);
            this.EditHistoryPanel.Name = "EditHistoryPanel";
            this.EditHistoryPanel.Size = new System.Drawing.Size(55, 107);
            this.EditHistoryPanel.TabIndex = 23;
            this.EditHistoryPanel.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1256, 915);
            this.Controls.Add(this.EditHistoryPanel);
            this.Controls.Add(this.EditBookmarkPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.historyList);
            this.Controls.Add(this.bookmarkList);
            this.Controls.Add(this.reload_button);
            this.Controls.Add(this.forward_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.URL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebApp";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.EditBookmarkPanel.ResumeLayout(false);
            this.EditHistoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox URL;
        private Button search_button;
        private Button home_button;
        private Panel header_panel;
        private Button close_button;
        private Label app_label;
        private ToolTip tooltip_search_button;
        private ToolTip tooltip_bookmark_button;
        private ToolTip tooltip_history_button;
        private ToolTip tooltip_url;
        private ToolTip tooltip_home_button;
        private ToolTip tooltip_close_button;
        private TabControl tabControl1;
        private Button back_button;
        private Button forward_button;
        private Button reload_button;
        private ListBox bookmarkList;
        private ListBox historyList;
        private OpenFileDialog bulkDownload;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem favouritesToolStripMenuItem;
        private ToolStripMenuItem bookmarkPageToolStripMenuItem;
        private ToolStripMenuItem bulkDownloadToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label dynamic_label;
        private ToolStripMenuItem tabsToolStripMenuItem1;
        private ToolStripMenuItem newTabToolStripMenuItem;
        private ToolStripMenuItem closeTabToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem1;
        private ToolStripMenuItem viewHistoryToolStripMenuItem;
        private ToolStripMenuItem closeHistoryToolStripMenuItem;
        private ToolStripMenuItem clearHistoryToolStripMenuItem;
        private ToolStripMenuItem bookmarksToolStripMenuItem2;
        private ToolStripMenuItem viewBookmarksToolStripMenuItem;
        private ToolStripMenuItem closeBookmarksToolStripMenuItem;
        private ToolStripMenuItem clearBookmarksToolStripMenuItem;
        private ToolStripMenuItem homePageToolStripMenuItem;
        private ToolStripMenuItem editHomePageToolStripMenuItem;
        private Label label1;
        private Button EditBookmarkButton;
        private Button DeleteBookmarkButton;
        private Button OpenBookmarkInNewTabButton;
        private Panel EditBookmarkPanel;
        private Panel EditHistoryPanel;
        private Button DeleteHistoryButton;
        private Button OpenHistoryInNewTabButton;
        private ToolTip tooltip_historyDelete_button;
        private ToolTip tooltip_editBookmark_button;
        private ToolTip tooltip_bookmarkDelete_button;
        private ToolTip tooltip_bookmarkOpen_button;
        private ToolTip tooltip_historyOpen_button;
        private ToolTip tooltip_back_button;
        private ToolTip tooltip_forward_button;
        private ToolTip tooltip_reload_button;
    }
}