# Hotel Booking System (C# Windows Forms)

A desktop application built using C# and Windows Forms to manage hotel room bookings, calculate costs, apply discounts, and handle guest validations.

## 🚀 Features (Astaamaha Barnaamijka)
- **Guest Validation:** Validates guest age, number of nights, and total guests against specific rules.
- **Room Selection:** Supports multiple room types with different rates and capacities:
  - **Standard:** $50/night (Max 2 guests)
  - **Normal:** $80/night (Max 4 guests)
  - **Hight (High-end):** $130/night (Max 6 guests)
- **Dynamic Pricing & Discounts:**
  - **Length of Stay Discount:** 5% discount for 5–9 nights; 12% discount for 10+ nights.
  - **Senior Citizen Discount:** Extra 5% discount for guests aged 60 and above.
  - **Breakfast Option:** Optional breakfast package ($10 per guest per night).
  - **Service Charge:** 5% service charge applied if guests exceed 4.
- **Receipt Generation:** Automatically displays a detailed breakdown of charges and totals on a results label (`lblResult`).

## 🛠️ Code Structure & Logic (Qaab-dhismeedka Koodka)
The application logic is written inside a Windows Forms `Form1` class:
1. **`btnCalculate_Click`**: Handles input parsing (`int.TryParse`), range validation, room pricing, discount calculations, extra charges, and final summary output.
2. **`btnclear_Click`**: Resets all input fields, checkboxes, radio buttons, and the result label.
3. **`btnexit_Click`**: Closes the application gracefully using `Application.Exit()`.

## 💻 Requirements (Shuruudaha Shaqaynta)
- **Language:** C# (.NET Framework / .NET Core with Windows Forms support)
- **IDE:** Visual Studio

## 📥 How to Run (Sida loo shaqaysiiyo)
1. Open the project in **Visual Studio**.
2. Ensure you have controls matching the naming convention (`txtGuestname`, `txtGuestage`, `txtnumberofnight`, `txtnumberofguests`, `rdoStandard`, `rdoNormal`, `rdoHight`, `chkBreakfast`, `lblResult`, `btnCalculate`, `btnclear`, `btnexit`).
3. Build and Run (`F5`) the project.