using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parking
{
    public partial class Form1 : Form
    {
        private int total = 10;
        private int available = 10;
        private int currentUser;
        List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
            totalBox.Text = Convert.ToString(total);
            availableBox.Text = Convert.ToString(available);
        }

        private void entry_button_Click(object sender, EventArgs e)
        {
            int requested_number;
            if (currentUser > 0) requested_number = currentUser;
            else requested_number = new Random().Next(100, 1000);

            if (numbers.Contains(requested_number))
            {
                statusText.Text = $"Car {requested_number} has already entered the garage!";
                return;
            }

            if (available == 0)
            {
                statusText.Text = "There are no empty slots!";
                return;
            }

            statusText.Text = "";
            numbers.Add(requested_number);
            available -= 1;
            availableBox.Text = Convert.ToString(available);
            detailsBox.Items.Add(requested_number + "  —  " + DateTime.Now.ToString());

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            int requested_number;
            if (currentUser > 0) requested_number = currentUser;
            else requested_number = new Random().Next(100, 1000);


            if (available < total && !numbers.Contains(requested_number))
            {
                statusText.Text = $"Car {requested_number} does not exist in the garage!";
                return;
            };


            for (int i = detailsBox.Items.Count - 1; i >= 0; i--)
            {
                if (detailsBox.Items[i].ToString().StartsWith(Convert.ToString(requested_number)))
                {
                    statusText.Text = "";
                    detailsBox.Items.RemoveAt(i);
                    available += 1;
                    availableBox.Text = Convert.ToString(available);
                    numbers.Remove(requested_number);
                }
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userInput.Text.Trim() == "" || !userInput.Text.Trim().All(char.IsDigit))
            {
                statusText.Text = "Invalid Credentials! (only numbers)";
                return;
            };


            switch (loginButton.Text)
            {
                case "Log in":
                    currentUser = Convert.ToInt32(userInput.Text);
                    statusText.Text = $"Logged in as {currentUser}!";
                    userInput.Text = Convert.ToString(currentUser);
                    userInput.ReadOnly = true;
                    loginButton.Text = "Log out";
                    break;

                case "Log out":
                    currentUser = -1;
                    statusText.Text = "Logged out!";
                    userInput.Text = "";
                    userInput.ReadOnly = false;
                    loginButton.Text = "Log in";
                    break;

                default:
                    statusText.Text = "Somethin went wrong";
                    break;
            }
        }

        private void availableBox_TextChanged(object sender, EventArgs e)
        {
            if (total == available) exit_button.Enabled = false;
            else exit_button.Enabled = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void detailsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
