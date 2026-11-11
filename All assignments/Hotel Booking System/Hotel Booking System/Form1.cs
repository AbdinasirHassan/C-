using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       



private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the guest information
            string guestName = txtGuestname.Text;
            int age, nights, guests;

           

            // Check the age
            if (!int.TryParse(txtGuestage.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            // Check the number of nights
            if (!int.TryParse(txtnumberofnight.Text, out nights))
            {
                MessageBox.Show("Please enter valid nights.");
                return;
            }

            // Check the number of guests
            if (!int.TryParse(txtnumberofguests.Text, out guests))
            {
                MessageBox.Show("Please enter valid number of guests.");
                return;
            }

            // Validate the information
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                return;
            }

            // Get the selected room
            string roomType = "";
            double roomRate = 0;

            if (rdoStandard.Checked)
            {
                roomType = "Standard";
                roomRate = 50;
            }
            else if (rdoNormal.Checked)
            {
                roomType = "Normal";
                roomRate = 80;
            }
            else if (rdoHight.Checked)
            {
                roomType = "Hight";
                roomRate = 130;
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            // Check room capacity
            if (roomType == "Standard" && guests > 2)
            {
                MessageBox.Show("Standard room allows 2 guests.");
                return;
            }

            if (roomType == "Normal" && guests > 4)
            {
                MessageBox.Show("Normal room allows 4 guests.");
                return;
            }

            if (roomType == "Hight" && guests > 6)
            {
                MessageBox.Show("Hight room allows 6 guests.");
                return;
            }

            // Calculate the room cost
            double basicCost = roomRate * nights;
            double discountRate = 0;

            // Give a discount for longer stays
            if (nights >= 5 && nights <= 9)
            {
                discountRate = 0.05;
            }
            else if (nights >= 10)
            {
                discountRate = 0.12;
            }

            double nightDiscount = basicCost * discountRate;
            double total = basicCost - nightDiscount;

            // Add breakfast cost if selected
            double breakfastCost = 0;

            if (chkBreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            total = total + breakfastCost;

            // Add service charge for more than 4 guests
            double serviceCharge = 0;

            if (guests > 4)
            {
                serviceCharge = total * 0.05;
            }

            total = total + serviceCharge;

            // Give an extra discount to senior guests
            double seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = total * 0.05;
            }

            total = total - seniorDiscount;

            // Show the booking details
            lblResult.Text =
                "BOOKING APPROVED\n\n" +
                "Guest Name: " + guestName + "\n" +
                "Guest Age: " + age + "\n" +
                "Room Type: " + roomType + "\n" +
                "Room Rate: $" + roomRate.ToString("F2") + "\n" +
                "Number of Nights: " + nights + "\n" +
                "Number of Guests: " + guests + "\n" +
                "Basic Cost: $" + basicCost.ToString("F2") + "\n" +
                "Night Discount: -$" + nightDiscount.ToString("F2") + "\n" +
                "Breakfast: $" + breakfastCost.ToString("F2") + "\n" +
                "Service Charge: $" + serviceCharge.ToString("F2") + "\n" +
                "Senior Discount: -$" + seniorDiscount.ToString("F2") + "\n" +
                "--------------------------\n" +
                "FINAL TOTAL: $" + total.ToString("F2");
        }


        private void btnclear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtGuestage.Text = "";
            txtGuestname.Text = "";
            txtnumberofguests.Text = "";
            txtnumberofnight.Text = "";
            rdoHight.Checked = false;
            rdoNormal.Checked = false;
            rdoStandard.Checked = false;
            chkBreakfast.Checked = false;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

