﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInterface
{
    public partial class CashCreditSelect : Form
    {
        long orderID;
        Decimal cost;
        NSADatabase db;
        StringBuilder receipt;
        String email;

        public CashCreditSelect(long orderID, Decimal cost, NSADatabase db, StringBuilder receipt, string email)
        {
            InitializeComponent();
            this.orderID = orderID;
            this.cost = cost;
            this.db = db;
            this.receipt = receipt;
            this.email = email;

            receipt.Append("Order #: " + orderID);
            receipt.AppendLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashForm2 cf = new CashForm2(orderID, cost, db, receipt, email);
            cf.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditForm1 cf = new CreditForm1(orderID, cost, db, receipt, email);
            cf.Show();
            Hide();
        }
    }
}
