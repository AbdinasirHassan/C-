# Airline Ticket Booking System (C# Windows Forms)

A desktop application built using C# and Windows Forms to manage airline ticket reservations, validate passenger details, calculate costs, apply volume and age-based discounts, and handle baggage rules.

## 🚀 Features (Astaamaha Barnaamijka)
- **Passenger Validation:** Validates passenger name, age (1–100 years), ticket quantity (1–5), and baggage weight (up to 50 kg).
- **Travel Classes & Pricing:** Supports multiple travel classes with standard base rates:
  - **First Class:** $250 per ticket (Restricted for passengers under 12 years).
  - **Business Class:** $180 per ticket.
  - **Normal Class:** $120 per ticket.
- **Dynamic Discounts & Rules:**
  - **Age Restrictions:** Passengers under 12 years are restricted from booking First Class (Booking is automatically rejected with a specific reason).
  - **Volume Discounts:** 5% discount for 3–4 tickets; 10% discount for 5 tickets.
  - **Age-Based Discounts:** 20% discount for children (under 12); 10% discount for seniors (60+).
- **Add-ons & Baggage:**
  - **Travel Insurance:** Optional $25 per ticket.
  - **Excess Baggage Fees:** Free limit of 20 kg per passenger; $2.0 per extra kg charged for weight exceeding the limit.
- **Receipt Generation:** Displays a complete financial breakdown on a result label (`lblResult`) showing approval/rejection status, discounts, and final totals.

## 🛠️ Code Structure & Logic (Qaab-dhismeedka Koodka)
The core logic resides within the Windows Forms `Form1` class:
1. **`button1_Click`**: Parses user inputs safely using `int.TryParse` and `double.TryParse`, performs range and business rule validations, handles class selections, computes discounts and additional charges, and displays the receipt.
2. **`btnClear_Click`**: Resets all input textboxes, checkboxes, radio buttons, and output labels.
3. **`btnClose_Click`**: Exits the application safely using `Application.Exit()`.

## 💻 Requirements (Shuruudaha Shaqaynta)
- **Language:** C# (.NET Framework / .NET Core with Windows Forms support)
- **IDE:** Visual Studio

## 📥 How to Run (Sida loo shaqaysiiyo)
1. Open the project inside **Visual Studio**.
2. Ensure your UI controls match the expected naming conventions (`txtName`, `txtAge`, `txtTicket`, `txtBaggageWeight`, `rdoFirstClass`, `rdoBusinessClass`, `rdoNormalClass`, `chkTravelInsurance`, `lblResult`, `button1`, `btnClear`, `btnClose`).
3. Build and run the project (`F5`).