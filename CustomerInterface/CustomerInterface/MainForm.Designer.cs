﻿namespace CustomerInterface
{
    partial class KioskWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KioskWindow));
            this.KioskTabs = new System.Windows.Forms.TabControl();
            this.MenuTab = new System.Windows.Forms.TabPage();
            this.menuListView = new System.Windows.Forms.ListView();
            this.LoyaltyTab = new System.Windows.Forms.TabPage();
            this.btnDeleteLoyaltyAccount = new System.Windows.Forms.Button();
            this.rewardCountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pastOrdersLabel = new System.Windows.Forms.Label();
            this.FavOrdersView = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.favItemsListView = new System.Windows.Forms.ListView();
            this.favoriteItemsLabel = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.AccNumberTagLabel = new System.Windows.Forms.Label();
            this.LanguageTab = new System.Windows.Forms.TabPage();
            this.selectLangText = new System.Windows.Forms.Label();
            this.spBtn = new System.Windows.Forms.Button();
            this.geBtn = new System.Windows.Forms.Button();
            this.frBtn = new System.Windows.Forms.Button();
            this.enBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.OrderView = new System.Windows.Forms.ListView();
            this.ItemHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.kidsnum_store = new System.Windows.Forms.Label();
            this.KioskTabs.SuspendLayout();
            this.MenuTab.SuspendLayout();
            this.LoyaltyTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LanguageTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // KioskTabs
            // 
            this.KioskTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KioskTabs.Controls.Add(this.MenuTab);
            this.KioskTabs.Controls.Add(this.LoyaltyTab);
            this.KioskTabs.Controls.Add(this.LanguageTab);
            this.KioskTabs.Font = new System.Drawing.Font("Tahoma", 10F);
            this.KioskTabs.ItemSize = new System.Drawing.Size(42, 20);
            this.KioskTabs.Location = new System.Drawing.Point(13, 12);
            this.KioskTabs.Multiline = true;
            this.KioskTabs.Name = "KioskTabs";
            this.KioskTabs.SelectedIndex = 0;
            this.KioskTabs.Size = new System.Drawing.Size(1237, 792);
            this.KioskTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.KioskTabs.TabIndex = 0;
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.menuListView);
            this.MenuTab.Location = new System.Drawing.Point(4, 24);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.MenuTab.Size = new System.Drawing.Size(1229, 764);
            this.MenuTab.TabIndex = 0;
            this.MenuTab.Text = "Menu";
            this.MenuTab.UseVisualStyleBackColor = true;
            // 
            // menuListView
            // 
            this.menuListView.Location = new System.Drawing.Point(6, 17);
            this.menuListView.Name = "menuListView";
            this.menuListView.Size = new System.Drawing.Size(659, 491);
            this.menuListView.TabIndex = 0;
            this.menuListView.UseCompatibleStateImageBehavior = false;
            this.menuListView.View = System.Windows.Forms.View.SmallIcon;
            this.menuListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LoyaltyTab
            // 
            this.LoyaltyTab.Controls.Add(this.btnDeleteLoyaltyAccount);
            this.LoyaltyTab.Controls.Add(this.rewardCountLabel);
            this.LoyaltyTab.Controls.Add(this.panel1);
            this.LoyaltyTab.Controls.Add(this.panel2);
            this.LoyaltyTab.Controls.Add(this.emailTextBox);
            this.LoyaltyTab.Controls.Add(this.nameLabel);
            this.LoyaltyTab.Controls.Add(this.nameTextBox);
            this.LoyaltyTab.Controls.Add(this.rewardsLabel);
            this.LoyaltyTab.Controls.Add(this.emailLabel);
            this.LoyaltyTab.Controls.Add(this.accountNumberLabel);
            this.LoyaltyTab.Controls.Add(this.AccNumberTagLabel);
            this.LoyaltyTab.Location = new System.Drawing.Point(4, 24);
            this.LoyaltyTab.Name = "LoyaltyTab";
            this.LoyaltyTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.LoyaltyTab.Size = new System.Drawing.Size(778, 519);
            this.LoyaltyTab.TabIndex = 2;
            this.LoyaltyTab.Text = "Loyalty Account";
            this.LoyaltyTab.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLoyaltyAccount
            // 
            this.btnDeleteLoyaltyAccount.Location = new System.Drawing.Point(584, 47);
            this.btnDeleteLoyaltyAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteLoyaltyAccount.Name = "btnDeleteLoyaltyAccount";
            this.btnDeleteLoyaltyAccount.Size = new System.Drawing.Size(140, 53);
            this.btnDeleteLoyaltyAccount.TabIndex = 9;
            this.btnDeleteLoyaltyAccount.Text = "Delete Loyalty Account";
            this.btnDeleteLoyaltyAccount.UseVisualStyleBackColor = true;
            this.btnDeleteLoyaltyAccount.Click += new System.EventHandler(this.btnDeleteLoyaltyAccount_Click);
            // 
            // rewardCountLabel
            // 
            this.rewardCountLabel.AutoSize = true;
            this.rewardCountLabel.Location = new System.Drawing.Point(21, 138);
            this.rewardCountLabel.Name = "rewardCountLabel";
            this.rewardCountLabel.Size = new System.Drawing.Size(25, 17);
            this.rewardCountLabel.TabIndex = 8;
            this.rewardCountLabel.Text = "No";
            this.rewardCountLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.pastOrdersLabel);
            this.panel1.Controls.Add(this.FavOrdersView);
            this.panel1.Location = new System.Drawing.Point(6, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 171);
            this.panel1.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(743, 3);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 171);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // pastOrdersLabel
            // 
            this.pastOrdersLabel.AutoSize = true;
            this.pastOrdersLabel.Location = new System.Drawing.Point(3, 11);
            this.pastOrdersLabel.Name = "pastOrdersLabel";
            this.pastOrdersLabel.Size = new System.Drawing.Size(102, 17);
            this.pastOrdersLabel.TabIndex = 9;
            this.pastOrdersLabel.Text = "Favorite Orders";
            this.pastOrdersLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // FavOrdersView
            // 
            this.FavOrdersView.Location = new System.Drawing.Point(0, 39);
            this.FavOrdersView.Name = "FavOrdersView";
            this.FavOrdersView.Size = new System.Drawing.Size(743, 129);
            this.FavOrdersView.TabIndex = 8;
            this.FavOrdersView.UseCompatibleStateImageBehavior = false;
            this.FavOrdersView.SelectedIndexChanged += new System.EventHandler(this.HistoryView_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.favItemsListView);
            this.panel2.Controls.Add(this.favoriteItemsLabel);
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Location = new System.Drawing.Point(6, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 154);
            this.panel2.TabIndex = 2;
            // 
            // favItemsListView
            // 
            this.favItemsListView.Location = new System.Drawing.Point(3, 34);
            this.favItemsListView.Name = "favItemsListView";
            this.favItemsListView.Size = new System.Drawing.Size(740, 117);
            this.favItemsListView.TabIndex = 12;
            this.favItemsListView.UseCompatibleStateImageBehavior = false;
            this.favItemsListView.SelectedIndexChanged += new System.EventHandler(this.favItemsListView_SelectedIndexChanged);
            // 
            // favoriteItemsLabel
            // 
            this.favoriteItemsLabel.AutoSize = true;
            this.favoriteItemsLabel.Location = new System.Drawing.Point(4, 6);
            this.favoriteItemsLabel.Name = "favoriteItemsLabel";
            this.favoriteItemsLabel.Size = new System.Drawing.Size(95, 17);
            this.favoriteItemsLabel.TabIndex = 1;
            this.favoriteItemsLabel.Text = "Favorite Items";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(746, 3);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(115, 85);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(414, 24);
            this.emailTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 17);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(414, 24);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rewardsLabel
            // 
            this.rewardsLabel.AutoSize = true;
            this.rewardsLabel.Location = new System.Drawing.Point(53, 138);
            this.rewardsLabel.Name = "rewardsLabel";
            this.rewardsLabel.Size = new System.Drawing.Size(187, 17);
            this.rewardsLabel.TabIndex = 3;
            this.rewardsLabel.Text = "more orders to free sandwich";
            this.rewardsLabel.Visible = false;
            this.rewardsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 88);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(184, 11);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountNumberLabel.Size = new System.Drawing.Size(0, 17);
            this.accountNumberLabel.TabIndex = 1;
            // 
            // AccNumberTagLabel
            // 
            this.AccNumberTagLabel.AutoSize = true;
            this.AccNumberTagLabel.Location = new System.Drawing.Point(10, 11);
            this.AccNumberTagLabel.Name = "AccNumberTagLabel";
            this.AccNumberTagLabel.Size = new System.Drawing.Size(117, 17);
            this.AccNumberTagLabel.TabIndex = 0;
            this.AccNumberTagLabel.Text = "Account Number:";
            this.AccNumberTagLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LanguageTab
            // 
            this.LanguageTab.Controls.Add(this.selectLangText);
            this.LanguageTab.Controls.Add(this.spBtn);
            this.LanguageTab.Controls.Add(this.geBtn);
            this.LanguageTab.Controls.Add(this.frBtn);
            this.LanguageTab.Controls.Add(this.enBtn);
            this.LanguageTab.Location = new System.Drawing.Point(4, 24);
            this.LanguageTab.Name = "LanguageTab";
            this.LanguageTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.LanguageTab.Size = new System.Drawing.Size(778, 519);
            this.LanguageTab.TabIndex = 3;
            this.LanguageTab.Text = "Language";
            this.LanguageTab.UseVisualStyleBackColor = true;
            this.LanguageTab.Click += new System.EventHandler(this.LanguageTab_Click);
            // 
            // selectLangText
            // 
            this.selectLangText.AutoSize = true;
            this.selectLangText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLangText.Location = new System.Drawing.Point(15, 16);
            this.selectLangText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectLangText.Name = "selectLangText";
            this.selectLangText.Size = new System.Drawing.Size(174, 26);
            this.selectLangText.TabIndex = 24;
            this.selectLangText.Text = "Select language:";
            // 
            // spBtn
            // 
            this.spBtn.Image = ((System.Drawing.Image)(resources.GetObject("spBtn.Image")));
            this.spBtn.Location = new System.Drawing.Point(176, 44);
            this.spBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spBtn.Name = "spBtn";
            this.spBtn.Size = new System.Drawing.Size(48, 27);
            this.spBtn.TabIndex = 23;
            this.spBtn.UseVisualStyleBackColor = true;
            this.spBtn.Click += new System.EventHandler(this.spBtn_Click);
            // 
            // geBtn
            // 
            this.geBtn.Image = ((System.Drawing.Image)(resources.GetObject("geBtn.Image")));
            this.geBtn.Location = new System.Drawing.Point(124, 44);
            this.geBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geBtn.Name = "geBtn";
            this.geBtn.Size = new System.Drawing.Size(48, 27);
            this.geBtn.TabIndex = 22;
            this.geBtn.UseVisualStyleBackColor = true;
            this.geBtn.Click += new System.EventHandler(this.geBtn_Click);
            // 
            // frBtn
            // 
            this.frBtn.Image = ((System.Drawing.Image)(resources.GetObject("frBtn.Image")));
            this.frBtn.Location = new System.Drawing.Point(72, 44);
            this.frBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frBtn.Name = "frBtn";
            this.frBtn.Size = new System.Drawing.Size(48, 27);
            this.frBtn.TabIndex = 21;
            this.frBtn.UseVisualStyleBackColor = true;
            this.frBtn.Click += new System.EventHandler(this.frBtn_Click);
            // 
            // enBtn
            // 
            this.enBtn.Image = ((System.Drawing.Image)(resources.GetObject("enBtn.Image")));
            this.enBtn.Location = new System.Drawing.Point(20, 44);
            this.enBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enBtn.Name = "enBtn";
            this.enBtn.Size = new System.Drawing.Size(48, 27);
            this.enBtn.TabIndex = 20;
            this.enBtn.UseVisualStyleBackColor = true;
            this.enBtn.Click += new System.EventHandler(this.enBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Finish Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.RemoveButton);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.OrderView);
            this.panel3.Controls.Add(this.splitter4);
            this.panel3.Location = new System.Drawing.Point(805, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 493);
            this.panel3.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 454);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 36);
            this.button8.TabIndex = 12;
            this.button8.Text = "Save Order to Favorites";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 399);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "Fave!";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(171, 399);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(89, 35);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(70, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 35);
            this.button6.TabIndex = 9;
            this.button6.Text = "Customize";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // OrderView
            // 
            this.OrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemHeader,
            this.ChangesHeader});
            this.OrderView.Location = new System.Drawing.Point(4, 0);
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(256, 393);
            this.OrderView.TabIndex = 8;
            this.OrderView.UseCompatibleStateImageBehavior = false;
            this.OrderView.View = System.Windows.Forms.View.Details;
            // 
            // ItemHeader
            // 
            this.ItemHeader.Text = "Item";
            this.ItemHeader.Width = 113;
            // 
            // ChangesHeader
            // 
            this.ChangesHeader.Text = "Components";
            this.ChangesHeader.Width = 139;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(0, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 493);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kidsnum_store);
            this.panel4.Controls.Add(this.WelcomeLabel);
            this.panel4.Location = new System.Drawing.Point(808, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 68);
            this.panel4.TabIndex = 8;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(4, 4);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(55, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome!";
            this.WelcomeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // kidsnum_store
            // 
            this.kidsnum_store.AutoSize = true;
            this.kidsnum_store.Location = new System.Drawing.Point(7, 21);
            this.kidsnum_store.Name = "kidsnum_store";
            this.kidsnum_store.Size = new System.Drawing.Size(0, 13);
            this.kidsnum_store.TabIndex = 1;
            // 
            // KioskWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 630);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.KioskTabs);
            this.Name = "KioskWindow";
            this.Text = "Customer Kiosk";
            this.Activated += new System.EventHandler(this.KioskWindow_Activated);
            this.Load += new System.EventHandler(this.KioskWindow_Load);
            this.KioskTabs.ResumeLayout(false);
            this.MenuTab.ResumeLayout(false);
            this.LoyaltyTab.ResumeLayout(false);
            this.LoyaltyTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LanguageTab.ResumeLayout(false);
            this.LanguageTab.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage MenuTab;
        private System.Windows.Forms.ListView menuListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage LoyaltyTab;
        private System.Windows.Forms.Label AccNumberTagLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label rewardsLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pastOrdersLabel;
        private System.Windows.Forms.ListView FavOrdersView;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label favoriteItemsLabel;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ListView favItemsListView;
        private System.Windows.Forms.TabPage LanguageTab;
        public System.Windows.Forms.TabControl KioskTabs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ListView OrderView;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label selectLangText;
        private System.Windows.Forms.Button spBtn;
        private System.Windows.Forms.Button geBtn;
        private System.Windows.Forms.Button frBtn;
        private System.Windows.Forms.Button enBtn;
        private System.Windows.Forms.ColumnHeader ItemHeader;
        private System.Windows.Forms.ColumnHeader ChangesHeader;
        private System.Windows.Forms.Label rewardCountLabel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDeleteLoyaltyAccount;
        private System.Windows.Forms.Label kidsnum_store;
    }
}

