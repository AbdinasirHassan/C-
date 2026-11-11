####  Screen shot1 
# Declaring variable 
            //creating variables
            double  Total,totalafterdiscount ,discountrate, discountAmount, numberofpackage, priceperpackage;
            int age = 0;
            discountrate = 0;
# validate user input
            //Check the number of packages
            if (!double.TryParse(txtNumberofPackage.Text, out numberofpackage))
            {
                MessageBox.Show("Envalid  Package");
                return;
            }
            //Check the Price of Per package
            if (!double.TryParse(txtPricePerPackage.Text, out priceperpackage))
            {
                MessageBox.Show("Envalid  pricePackage");
                return;
            }
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Envalid  age");
                return;
            }
            if (age < 25)
            {
                MessageBox.Show("You cannot buy. the age most be 25 or above");
                return;
            }
 ##### Screenshot 2
 # checks
 # validate
            //Validate the information
            if (numberofpackage < 0 || priceperpackage < 0)
            {
                MessageBox.Show("Envalid  input, please enter correct one!");
                return;
            }
            //Checks discount rate
            if (numberofpackage > 10 && numberofpackage < 20)
            {
                discountrate = 20;
                
            }
            else if (numberofpackage > 20 && numberofpackage < 49)
            {
                discountrate = 30;
            }
            else if (numberofpackage > 50 && numberofpackage < 99)
            {
                discountrate = 40;
            }
            else if (numberofpackage > 100 )
            {
                discountrate = 50;
            }
            //Calculate the amount
            totalafterdiscount = 0;
            Total = numberofpackage * priceperpackage;
#### Screenshot3 
 # Calculate discount amount
 # total 
 # display           
            discountAmount = Total - totalafterdiscount;

            totalafterdiscount = Total - discountAmount;

            discountAmount = Total * discountrate / 100;
            totalafterdiscount = Total - discountAmount;

            //display
            lbldisplay.Text = (
                "Sofrware Result\n\n" +
                "Number of Package: " + numberofpackage + "\n" +
                "Price perpackage: $" + priceperpackage + "\n" +
                "Subtotal(before Discount): " + Total + "\n" +
                "Discount rate: " + discountrate +"%"+ "\n" +
                "Discount Amount: $" + discountAmount + "\n" +
                "Total Amount(after discount): $" + totalafterdiscount + "\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberofPackage.Text = string.Empty;
            txtPricePerPackage.Text = string.Empty;
            lbldisplay.Text = "";
            txtAge.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
