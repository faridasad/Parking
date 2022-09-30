using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        private int total = 10;
        private int available = 10;
        List<int> numbers = new List<int>();


        public Form1()
        {
            InitializeComponent();
            totalBox.Text = Convert.ToString(total);
            availableBox.Text = Convert.ToString(available);
        }


        private void entry_button_Click(object sender, EventArgs e)
        {
            int random = new Random().Next(1, 11);

            if (available == 0)
            {
                statusText.Text = "Heç bir boş slot yoxdur!";
                return;
            }

            if (numbers.Contains(random))
            {
                statusText.Text = $"{random} nömrəli maşın artıq daxil olub!";
                return;
            }

            statusText.Text = "";
            numbers.Add(random);
            available -= 1;
            availableBox.Text = Convert.ToString(available);
            detailsBox.Items.Add(random + "  —  " + DateTime.Now.ToString());

        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            int random = new Random().Next(1, 11);


            if (available < total && !numbers.Contains(random))
            {
                statusText.Text = $"{random} nömrəli maşın mövcud deyil!";
                return;
            };



            for (int i = detailsBox.Items.Count - 1; i >= 0; i--)
            {
                if (detailsBox.Items[i].ToString().StartsWith(Convert.ToString(random)))
                {
                    statusText.Text = "";
                    detailsBox.Items.RemoveAt(i);
                    available += 1;
                    availableBox.Text = Convert.ToString(available);
                    numbers.Remove(random);
                }
            }
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

    }
}
