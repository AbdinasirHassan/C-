using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the passenger information
            string passengerName = txtName.Text;
            int age, tickets;
            double baggageWeight;

            // Check the passenger name
            if (string.IsNullOrWhiteSpace(passengerName))
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            // Check the age using TryParse[cite: 2]
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            // Check the number of tickets using TryParse[cite: 2]
            if (!int.TryParse(txtTicket.Text, out tickets))
            {
                MessageBox.Show("Please enter valid number of tickets.");
                return;
            }

            // Check the baggage weight using TryParse[cite: 2]
            if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter valid baggage weight.");
                return;
            }

            // Validate the information ranges[cite: 2]
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100 years.");
                return;
            }

            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                return;
            }

            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage weight cannot be negative and cannot exceed 50 kg per passenger.");
                return;
            }

            // Get the selected travel class and price
            string travelClass = "";
            double ticketPrice = 0;

            if (rdoFirstClass.Checked)
            {
                travelClass = "First Class";
                ticketPrice = 250; // Standard First Class base price
            }
            else if (rdoNormalClass.Checked)
            {
                travelClass = "Normal Class";
                ticketPrice = 120; // Standard Normal Class base price
            }
            else if (rdoBusinessClass.Checked)
            {
                travelClass = "Business Class";
                ticketPrice = 180; // Standard Business Class base price
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Use a bool flag to determine whether the booking is approved or rejected[cite: 2]
            bool bookingApproved = true;
            string rejectionReason = "";

            // Rule: Passengers below 12 years cannot book First Class[cite: 2]
            if (age < 12 && travelClass == "First Class")
            {
                bookingApproved = false;
                rejectionReason = "Passengers below 12 years cannot book First Class.";
            }

            // If booking is rejected, display the reason[cite: 2]
            if (!bookingApproved)
            {
                lblResult.Text =
                    "BOOKING REJECTED\n\n" +
                    "Passenger Name: " + passengerName + "\n" +
                    "Reason: " + rejectionReason;
                return;
            }

            // Calculate the basic ticket cost: Basic Ticket Cost = Ticket Price * Number of Tickets[cite: 2]
            double basicTicketCost = ticketPrice * tickets;
            double total = basicTicketCost;
            double ticketDiscount = 0;

            // Ticket Volume Discounts[cite: 2]
            if (tickets >= 3 && tickets <= 4)
            {
                ticketDiscount = basicTicketCost * 0.05; // 5% discount
            }
            else if (tickets == 5)
            {
                ticketDiscount = basicTicketCost * 0.10; // 10% discount
            }

            total = total - ticketDiscount;

            // Age-based Discounts[cite: 2]
            double ageDiscount = 0;
            if (age < 12)
            {
                ageDiscount = total * 0.20; // 20% child discount
            }
            else if (age >= 60)
            {
                ageDiscount = total * 0.10; // 10% senior discount
            }

            total = total - ageDiscount;

            // Add travel insurance cost if selected ($25 per ticket)[cite: 2]
            double insuranceCost = 0;
            if (chkTravelInsurance.Checked)
            {
                insuranceCost = 25 * tickets;
                total = total + insuranceCost;
            }

            // Baggage rules: Up to 20 kg per passenger is free; charges apply for excess weight[cite: 2]
            double extraBaggageCost = 0;
            double freeBaggageLimit = 20 * tickets;
            double totalBaggage = baggageWeight * tickets;
            if (totalBaggage > freeBaggageLimit)
            {
                double excessWeight = totalBaggage - freeBaggageLimit;
                extraBaggageCost = excessWeight * 2.0; // $2 per extra kg
                total = total + extraBaggageCost;
            }

            // Show the booking details
            lblResult.Text =
                "BOOKING APPROVED\n\n" +
                "Passenger Name: " + passengerName + "\n" +
                "Passenger Age: " + age + "\n" +
                "Travel Class: " + travelClass + "\n" +
                "Ticket Price: $" + ticketPrice.ToString("F2") + "\n" +
                "Number of Tickets: " + tickets + "\n" +
                "Baggage Weight: " + baggageWeight + " kg/passenger[cite: 2]\n" +
                "Basic Ticket Cost: $" + basicTicketCost.ToString("F2") + "[cite: 2]\n" +
                "Ticket Discount: -$" + ticketDiscount.ToString("F2") + "\n" +
                "Age Discount: -$" + ageDiscount.ToString("F2") + "\n" +
                "Travel Insurance: $" + insuranceCost.ToString("F2") + "\n" +
                "Extra Baggage Cost: $" + extraBaggageCost.ToString("F2") + "\n" +
                "--------------------------\n" +
                "FINAL TOTAL: $" + total.ToString("F2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtBaggageWeight.Text = "";
            txtTicket.Text = "";
            chkTravelInsurance.Checked = false;
            rdoBusinessClass.Checked = false;
            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
