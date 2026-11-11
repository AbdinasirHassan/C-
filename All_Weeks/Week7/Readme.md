# AssignmentStudent - Student Record Management System (C# Windows Forms)

A desktop application built using C# and Windows Forms designed to handle student data input validation, save student records into text files using `StreamWriter`, read data using both a manual `OpenFileDialog`/`StreamReader` loop and hardcoded paths, and clean up or delete records dynamically.

## 🚀 Features (Astaamaha Barnaamijka)
- **Comprehensive Input Validation:** 
  - Validates student ID as a positive integer (`>= 1`).
  - Ensures name and department text boxes are not empty.
  - Validates student marks to ensure they fall within the valid range of `1` to `100`.
  - Enforces radio button selection for student types (**UnderGraduate** or **Postgraduate**).
- **File Creation & Dialog Integration (`btnSavefile_Click`):** 
  - Writes student details (`Name`, `ID`, `Department`, `Mark`, `Type`) to `Students.txt` via `StreamWriter`.
  - Includes a `SaveFileDialog` instance for flexible destination exporting.
- **Advanced File Reading (`btnReadfile_Click`):** 
  - Incorporates an `OpenFileDialog` selection block alongside safe error handling (`FileNotFoundException`, `IOException`).
  - Reads `Students.txt` line-by-line using a `while (true)` loop with `StreamReader` and populates a `ListBox` (`listBox1`).
- **File Deletion & Form Reset (`btnClear_Click`):** Closes any open file streams, deletes `Students.txt` from disk, clears the `ListBox`, and resets all input text fields.

## 🛠️ Code Structure & Logic (Qaab-dhismeedka Koodka)
The application core resides inside the Windows Forms `Form1` class:
1. **`btnSavefile_Click`**: Parses numerical inputs (`int.TryParse`), validates business rules (ID positivity, mark thresholds, radio states), writes student records to disk, and handles save dialogs inside a `try-catch` block.
2. **`btnReadfile_Click`**: Opens file browsing dialogs, handles multiple exception blocks, safely closes active streams, and reads files line-by-line into `listBox1`.
3. **`btnClear_Click`**: Deletes the persistent `Students.txt` file, clears UI components, and resets input controls.
4. **`btnExit_Click`**: Gracefully terminates the application using `Application.Exit()`.

## 💻 Requirements (Shuruudaha Shaqaynta)
- **Language:** C# (.NET Framework / .NET Core with Windows Forms support)
- **IDE:** Visual Studio

## 📥 How to Run (Sida loo shaqaysiiyo)
1. Open the project inside **Visual Studio**.
2. Ensure your form contains text boxes (`txtName`, `txtId`, `txtDept`, `txtMark`), radio buttons (`rdoUndergraduate`, `rdoPostgraduate`), a `ListBox` (`listBox1`), and corresponding buttons.
3. Build and run the project (`F5`).