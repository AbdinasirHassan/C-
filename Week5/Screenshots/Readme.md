# C# File Handling Assignment - Code Breakdown

# Screenshot1

## line 1 covers
- Initializing file creation dialog
- Using `SaveFileDialog` to configure the save path, title, and file extension filter (`.txt`)

## line 2 covers
- Managing user input content
- Checking if the output box is empty and providing default text using `StreamWriter` if necessary

# Screenshot2

- Reading complete file content using `File.ReadAllText()`

## line 1
- Retrieving the selected file path via the `ChooseFile()` helper method
- Checking if a file was selected (`path == null`) before proceeding

## line 2
- Executing the read operation inside a `try` block
- Reading all characters from the specified text file into a single string at once

## line 3
- Displaying the file contents directly inside the application's output text box along with a method header

## line 4
- Implementing exception handling for I/O errors (`IOException` and `UnauthorizedAccessException`) to ensure application stability

# Screenshot3

- Reading files line by line using `StreamReader` and `StringBuilder`

## line 1
- Initializing a high-performance `StringBuilder` to store the formatted reading results

## line 2
- Setting up a `StreamReader` inside a `using` block for safe resource management and memory efficiency

## line 3
- Implementing a `while` loop with `reader.ReadLine()` to read the file sequentially until the end of the stream is reached

## line 4
- Dynamically tracking and appending line numbers (`lineNumber + ": " + line`) to the output for clear structured viewing