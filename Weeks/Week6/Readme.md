# File Handling Assignment (C# Windows Forms)

A desktop application built using C# and Windows Forms to demonstrate various file handling operations, including creating, reading using different methods (`ReadAllText`, `ReadAllLines`, `StreamReader`), and deleting text files.

## 🚀 Features (Astaamaha Barnaamijka)
- **Dynamic Interface Builder (`BuildInterface`):** Programmatically generates buttons, text boxes, and labels with a clean, modern UI styling without relying on the Visual Studio designer file.
- **File Creation (`StreamWriter`):** Allows users to save text input from the output box into a new `.txt` file using `SaveFileDialog`.
- **Multiple Reading Methods:**
  - **ReadAllText:** Reads the entire contents of a file into a single string at once.
  - **ReadAllLines:** Reads file contents into a string array, processing line-by-line with added line numbers.
  - **StreamReader:** Efficiently reads files line by line using a stream loop, ideal for handling larger text files.
- **File Deletion:** Permanently deletes a selected text file after user confirmation (`MessageBox`).
- **Error Handling:** Robust exception handling for `IOException` and `UnauthorizedAccessException` to prevent application crashes during file operations.

## 🛠️ Code Structure & Logic (Qaab-dhismeedka Koodka)
The core logic resides within the Windows Forms `Form1` class:
1. **`BuildInterface()`**: Sets up form properties, title labels, buttons, and the read-only `outputBox`.
2. **`CreateFile_Click`**: Opens a `SaveFileDialog` and writes text to a file using `StreamWriter`.
3. **`ReadAllText_Click`**: Selects a file and reads all text using `File.ReadAllText`.
4. **`ReadAllLines_Click`**: Reads file lines into an array and formats them with line numbers using `StringBuilder`.
5. **`StreamReader_Click`**: Uses `StreamReader` and a `while` loop with `ReadLine()` to process lines sequentially.
6. **`DeleteFile_Click`**: Confirms and deletes a selected file via `File.Delete`.
7. **`ChooseFile()` & `ShowFileError()`**: Helper methods for file dialog selection and centralized error handling.

## 💻 Requirements (Shuruudaha Shaqaynta)
- **Language:** C# (.NET Framework / .NET Core with Windows Forms support)
- **IDE:** Visual Studio

## 📥 How to Run (Sida loo shaqaysiiyo)
1. Open the project inside **Visual Studio**.
2. Build and run the project (`F5`).
3. Use the interface buttons to create, read (using 3 different methods), or delete text files interactively.