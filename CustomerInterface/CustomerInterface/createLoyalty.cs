﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CustomerInterface
{
    public partial class createLoyalty : Form
    {
        private CultureInfo ci;
        private string name;
        private string email;
        private NSADatabase db;

        public createLoyalty(CultureInfo language)
        {
            InitializeComponent();
            ci = language;
        }

        private void createLoyaltyBut_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name))
            {
                errorLabel.Text = "Enter your name!";
            }

            else if (String.IsNullOrEmpty(email))
            {
                errorLabel.Text = "Enter your email!";
            }

            else
            {
                try
                {
                    // connect to DB if it is not connected
                    if (!db.Connected())
                    {
                        db.OpenConnection();
                    }

                    // Get the loyalty account data from the database
                    //db.ManagerSaveLoyaltyAccount(name, email);

                    KioskWindow form = new KioskWindow(ci);
                    form.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Loyalty Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            email = emailTextBox.Text;
        }
    }
}
