using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class MainForm : Form
    {
        private Account account;

        public MainForm()
        {
            InitializeComponent();
            groupBox4.Enabled = false;
            account = null;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            decimal initialBalance;
            if (nameTextBox.Text.Length != 0
                && Decimal.TryParse(initialBalanceTextBox.Text, out initialBalance))
            {
                account = new Account(nameTextBox.Text, initialBalance);
                groupBox4.Enabled = true;
                ShowAccountInfo();
            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }

        private void ShowAccountInfo()
        {
            nameInfoTextBox.Text = account.Name;
            maxDepthInfoTextBox.Text = account.MaxDebt.ToString();
            balanceInfoTextBox.Text = account.Balance.ToString();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (Decimal.TryParse(depositAmountTextBox.Text, out amount))
            {
                try
                {
                    account.Deposit(amount);
                    ShowAccountInfo();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Amount must be greater than 0");
                }
                catch(OverflowException)
                {
                    MessageBox.Show(string.Format("Amount can't be higher then {0}", decimal.MaxValue));
                }

            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (Decimal.TryParse(withdrawAmountTextBox.Text, out amount))
            {
                try
                {
                    account.Withdraw(amount);
                    ShowAccountInfo();
                }catch(NotEnoughCreditException exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }
    }
}
