## Screenshot1 
# lines of code
 // Get the guest information
 # Creating Variable & store from txtbox
            string guestName = txtGuestname.Text;
            int age, nights, guests;

#  validate user input          

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
## Screenshot2
 # // Get the selected room

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

# Screenshot3

# -- displaying label 
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