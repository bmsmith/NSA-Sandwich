﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Globalization;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace CustomerInterface
{
    public partial class KioskWindow : Form
    {
        //CultureInfo stores the lanuage
        //(default is US if language not chosen in splash screen)
        private CultureInfo ci;
        private Assembly a; //loads assembly for CustomerInterface
        private ResourceManager rm; //manages the resources and gets the text localization for users language

        //db will connect to the databse
        private NSADatabase db;
        private NSAMenuCategory[] menu; //contains menu
        private NSAOrder currentOrder; //current order
        private NSAComponent[] componentsList;
        private CustomizeForm customizeItemForm; //used when user tries to customize an order
        private NSALoyaltyAccount account; //stores loyalty account info
                                           //acc #, name, email, rewards

        //constructor called when logging in as guest
        public KioskWindow(CultureInfo language)
        {
            ci = language; //set the language
            a = Assembly.Load("CustomerInterface"); //load the assembly and resourcemanager
            rm = new ResourceManager("CustomerInterface.Lang.lang", a);

            InitializeComponent();
            db = new NSADatabase();
            db.OpenConnection();
            componentsList = db.getComponents();
            menu = db.getMenu();

            updateMenu();
            currentOrder = new NSAOrder();
            setLang(ci);
        }

        //constructor called when logging in with a loyalty account
        public KioskWindow(CultureInfo language, List<string>[] accountNumber)
        {
            ci = language; //set the language
            a = Assembly.Load("CustomerInterface"); //load the assembly and resourcemanager
            rm = new ResourceManager("CustomerInterface.Lang.lang", a);

            
            account = new NSALoyaltyAccount(accountNumber[0][0], accountNumber[1][0], accountNumber[2][0], accountNumber[3][0]);
            InitializeComponent();

            db = new NSADatabase();
            db.OpenConnection();
            componentsList = db.getComponents();
            menu = db.getMenu();

            setAccountTab();
            updateMenu();
            currentOrder = new NSAOrder();
            setLang(ci);
        }

        private void setAccountTab()
        {
            nameTextBox.Text = account.getName();
            emailTextBox.Text = account.getEmail();
            accountNumberLabel.Text = account.getAccountNumber();
            rewardsLabel.Text = account.getOrdersNeeded() + " more orders to free sandwich";
        }

        private void updateMenu()
        {
            DataParser dataParser = new DataParser(ci); //parses Categories, Menu Items, and Components and displays them in the users language
            foreach (NSAMenuCategory category in menu)
            {
                ListViewGroup LVG = new ListViewGroup(dataParser.parseCategory(category.Name));
                foreach (NSAMenuItem item in category.Items)
                {
                    if (item.CategoryID != category.Id)
                    {
                        continue;
                    }
                    ListViewItem newitem = new ListViewItem(dataParser.parseItem(item.Name), item.Image, LVG);
                    newitem.Tag = item;
                    menuListView.Items.Add(newitem);
                }
                menuListView.Groups.Add(LVG);
            }

            ListViewGroup RandomGroup = new ListViewGroup(dataParser.parseCategory("Random"));
            ListViewItem randomItemLVI = new ListViewItem("Random Sandwich!", RandomGroup);
            NSARandomItem randomItem = new NSARandomItem();
            randomItem.CategoryID = 1;
            randomItem.Price = 9.99;
            randomItem.MenuType = "Random!";
            randomItem.Name = "Random";
            randomItemLVI.Tag = randomItem;
            menuListView.Items.Add(randomItemLVI);
            menuListView.Groups.Add(RandomGroup);

            rm.GetString("accountNumber", ci);
            rm.GetString("accountNumber", ci);
        }

        //clears the menu (mostly used to set items to a users language)
        private void clearMenu()
        {
            menuListView.Items.Clear();
        }

        private void addItemToOrder(NSAMenuItem item) {
            
            item.GenerateItem(componentsList);
            
            //item.getComponents(db, componentsList);
            currentOrder.AddItem(new NSAMenuItem(item));
            
            UpdateOrderView();
            

        }

        private void UpdateOrderView() {
            try
            {
                DataParser cp = new DataParser(ci);
                OrderView.Items.Clear();
                Decimal totalPrice = 0;
                for (int i = 0; i < currentOrder.Items.Count; i++)
                {

                    ListViewItem lvi = new ListViewItem(cp.parseItem(currentOrder.Items.ElementAt(i).Name));
                    totalPrice += (Decimal)currentOrder.Items.ElementAt(i).Price;
                    lvi.Tag = i; // Set to the index of the order item
                    OrderView.Items.Add(lvi);
                    if (currentOrder.Items.ElementAt(i).Components.Count > 0)
                    {
                        
                        foreach (NSAComponent c in currentOrder.Items.ElementAt(i).Components)
                        {
                            
                            ListViewItem changeItem = new ListViewItem(""); // Set to blank so we can see the change
                            changeItem.SubItems.Add(cp.parseItem(c.ToString()));
                            changeItem.Tag = i;
                            OrderView.Items.Add(changeItem);
                        }


                    }

                }

                OrderView.Items.Add(new ListViewItem("Total: " + totalPrice));
            }
            catch (System.NullReferenceException e) {
                Console.WriteLine(e.StackTrace);
            }
        }
        private void removeItemFromOrder(NSAMenuItem item)
        { 
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem t in menuListView.SelectedItems)
            {
                ((NSAMenuItem)t.Tag).getComponents(db, componentsList);
                addItemToOrder((NSAMenuItem)t.Tag);
                UpdateOrderView();
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LanguageTab_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (OrderView.SelectedItems.Count > 0)
            {
                customizeItemForm = new CustomizeForm();
                customizeItemForm.setLang(ci);
                customizeItemForm.CustomizeComponents = componentsList;
                customizeItemForm.CustomizeItem = (NSAMenuItem)currentOrder.Items[(int)OrderView.SelectedItems[0].Tag];
                customizeItemForm.OriginalIndex = OrderView.SelectedIndices[0];
                customizeItemForm.populateComponents();
                customizeItemForm.Show();
            }
        }

        //sets language of the interface to users chosen language
        public void setLang(CultureInfo ci)
        {
            selectLangText.Text = rm.GetString("selectLangText", ci); //language tab localization

            button1.Text = rm.GetString("finishOrderBut", ci); //order interface localization
            WelcomeLabel.Text = rm.GetString("welcome", ci);
            button6.Text = rm.GetString("customizeBut", ci);
            RemoveButton.Text = rm.GetString("removeBut", ci);
            OrderView.Columns[0].Text = rm.GetString("itemCat", ci);
            OrderView.Columns[1].Text = rm.GetString("changesCat", ci);

            KioskTabs.TabPages[0].Text = rm.GetString("menuTab", ci); //tab name localization
            KioskTabs.TabPages[1].Text = rm.GetString("loyaltyTab", ci);
            KioskTabs.TabPages[2].Text = rm.GetString("languageTab", ci);

            AccNumberTagLabel.Text = rm.GetString("accountNumber", ci); //account tab localization
            nameLabel.Text = rm.GetString("name", ci);
            emailLabel.Text = rm.GetString("email", ci);
            pastOrdersLabel.Text = rm.GetString("pastOrders", ci);
            favoriteItemsLabel.Text = rm.GetString("favoriteItems", ci);

            UpdateOrderView(); //also updates the current orders language
            clearMenu();
            updateMenu();   //menu is also supported
        }

        //changes the language to english
        private void enBtn_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("en-US");
            setLang(ci);
        }

        //changes the language to french
        private void frBtn_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("fr-FR");
            setLang(ci);
        }

        //changes the language to german
        private void geBtn_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("de-DE");
            setLang(ci);
        }

        //changes the language to spanish
        private void spBtn_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("es-ES");
            setLang(ci);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(("INSERT INTO orders (storeid, loyaltyid, status, timeplaced, total, tax, refunded) VALUES (" + db.StoreNumber1 + ", " + account.getAccountNumber() + ", 0, " + DateTime.Now + ", " + currentOrder.Total.ToString() + ", " + currentOrder.Tax.ToString() + ", " + (Convert.ToInt32(account.getRewardCount()) == 0) + ");"), db.Connection1);
            cmd.ExecuteReader();
            currentOrder.Id = cmd.LastInsertedId;
            
            foreach (NSAMenuItem item in currentOrder.Items) { 
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in OrderView.SelectedItems) {
                currentOrder.Items.RemoveAt((int)item.Tag);
            }
            UpdateOrderView();
        }

        private void KioskWindow_Activated(object sender, EventArgs e)
        {
            
            if (customizeItemForm != null)
            {
                
                NSAChanges changes = customizeItemForm.Changes;

                
                customizeItemForm.Close();
                
                currentOrder.Items.RemoveAt(changes.OriginalItem);
                
                addItemToOrder(changes.FinishedItem);

                
                
                UpdateOrderView();
                
            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

    }
}
