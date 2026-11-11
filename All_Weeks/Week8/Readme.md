# Software Sales Assignment System (C# Windows Forms)

A desktop application built using C# and Windows Forms designed to handle software package sales calculations, customer age verification restrictions, input parsing, and tiered discount structures.

## 🚀 Features (Astaamaha Barnaamijka)
- **Age Restriction Validation:** Ensures the buyer is at least 25 years old (`age >= 25`); otherwise, the transaction is rejected with an alert message.
- **Robust Input Verification:** Uses `double.TryParse` and `int.TryParse` to safely parse numbers and prevent application crashes from invalid inputs or negative numbers.
- **Tiered Volume Discounts:** Automatically calculates discount rates based on the number of packages purchased:
  - **11 – 19 packages:** 20% discount
  - **20 – 48 packages:** 30% discount
  - **50 – 98 packages:** 40% discount
  - **100+ packages:** 50% discount
- **Financial Calculation & Summary:** Computes the subtotal, discount amount, and final total after discount, displaying a clear breakdown on a results label (`lbldisplay`).

## 🛠️ Code Structure & Logic (Qaab-dhismeedka Koodka)
The application core resides inside the Windows Forms `Form1` class:
1. **`btnCalculate_Click`**: Parses package quantities, prices, and customer age, enforces the minimum age rule (25+), checks volume tiers, calculates subtotals and discounts, and renders the sales receipt.
2. **`btnClear_Click`**: Clears all input textboxes (`txtNumberofPackage`, `txtPricePerPackage`, `txtAge`) and resets the display label.
3. **`btnExit_Click`**: Closes the application smoothly using `Application.Exit()`.

## 💻 Requirements (Shuruudaha Shaqaynta)
- **Language:** C# (.NET Framework / .NET Core with Windows Forms support)
- **IDE:** Visual Studio

## 📥 How to Run (Sida loo shaqaysiiyo)
1. Open the project inside **Visual Studio**.
2. Ensure your form contains text boxes (`txtNumberofPackage`, `txtPricePerPackage`, `txtAge`), buttons (`btnCalculate`, `btnClear`, `btnExit`), and a display label (`lbldisplay`).
3. Build and run the project (`F5`).