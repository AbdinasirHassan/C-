# Chapter 4 - Loops, Files, and Random Numbers

# Topics

## 5.1 The while Loop
## 5.2 The ++ and -- Operators
## 5.3 The for Loop
## 5.4 The do-while Loop
## 5.5 Using Files for Data Storage
## 5.6 The OpenFileDialog and SaveFileDialog Controls
## 5.7 Random Numbers
## 5.8 The Load Event


# 5.1 The while Loop

The `while` loop causes a statement or set of statements to repeat as long as a Boolean expression is true.

The simple logic is: While a Boolean expression is true, do some task.

A `while` loop has two parts:
* A Boolean expression that is tested for a `true` or `false` value
* A statement or set of statements that is repeated as long as the Boolean expression is true

## Structure of a while Loop

The general format of a `while` loop is:

```csharp
while (BooleanExpression)
{
    statements;
}
```

* The first line is called the **while clause**.
* Statements inside the curly braces are the **body of the loop**.
* When a `while` loop executes, the Boolean expression is tested. If true, the statements are executed.
* Each time the loop executes its statement or statements, we say the loop is **iterating**, or performing an **iteration**.
* **Counter variables**: Variables used to track how many times a loop runs.

## The while Loop is a Pretest Loop

A `while` loop is a **pretest loop**, which means it tests its condition before performing an iteration.

This usually means steps must be taken prior to the loop to ensure it executes at least once.

Example:
```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}
```
In order for the loop to iterate at least once, `count` must be initialized to a value that is less than 5. This loop will iterate 5 times.

If a `while` loop's condition is false to start with, the loop will not iterate at all.

## Infinite Loops

An **infinite loop** is a loop that will repeat until the program is interrupted.

A typical scenario is when the programmer forgets to write code that makes the test condition false.

Example of an infinite loop:
```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    // count is never updated!
}
```


# 5.2 The ++ and -- Operators

To **increment** a variable means to increase its value, and to **decrement** a variable means to decrease its value.

C# provides the `++` and `--` operators to increment and decrement variables.

Adding 1 to a variable can be written as:
```csharp
count++;    // or count += 1; or count = count + 1;
```

Subtracting 1 from a variable can be written as:
```csharp
count--;    // or count -= 1; or count = count - 1;
```

## Postfix Mode versus Prefix Mode

* **Postfix mode** (`count++`): Place the operators after their operands. Use the old value first, then change it.
* **Prefix mode** (`++count`): Place the operators before their operands. Change the value first, then use it.

Example of Postfix vs Prefix:
```csharp
int count = 5;
int x = 0;

x = count++; // Postfix: x gets 5, count becomes 6

int count2 = 5;
int x2 = 0;

x2 = ++count2; // Prefix: count2 becomes 6, x2 gets 6
```


# 5.3 The for Loop

The `for` loop is specially designed for situations requiring a counter variable to control the number of times that a loop iterates.

You must specify three actions:
1. **Initialization**: A one-time expression that defines the initial value of the counter.
2. **Test**: A Boolean expression to be tested. If true, the loop iterates.
3. **Update**: Increases or decreases the value of the counter.

The general format is:
```csharp
for (InitializationExpression; TestExpression; UpdateExpression)
{
    statements;
}
```

The `for` loop is also a **pretest loop**.

Sample Code:
```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

## Other Forms of Update Expression

In the update expression, the counter variable does not always have to increment by 1.

```csharp
// Increment by 10
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

// Counting backward
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```


# 5.4 The do-while Loop

The `do-while` loop is a **posttest loop**, which means it performs an iteration before testing its Boolean expression.

One or more statements are executed before the Boolean expression is tested. It is guaranteed to run at least once.

Generic Format:
```csharp
do
{
    statements;
} while (BooleanExpression);
```

Sample Code:
```csharp
int number = 1;
do
{
    MessageBox.Show(number.ToString());
} while (number < 0);
// This will display the message box once, even though 1 < 0 is false.
```


# 5.5 Using Files for Data Storage

When a program needs to save data for later use, it writes the data to a file.

There are always three steps:
1. **Open the file**: Create a connection between the file and the program.
2. **Process the file**: Either write to or read from the file.
3. **Close the file**: Disconnect the file and the program.

Types of files:
* **Text file**: Contains data encoded as text using schemes such as Unicode.
* **Binary file**: Contains data that has not been converted to text.

## File Accessing with .NET Classes

.NET provides two main classes for working with text files:
* `StreamWriter`: For writing data to a text file.
* `StreamReader`: For reading data from a text file.

## Writing Data to a File

```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.Close();
```

* `WriteLine`: Writes an item of data followed by a newline character.
* `Write`: Writes an item without adding a newline character.

### CreateText vs AppendText
* `File.CreateText`: Creates a new text file. If the file already exists, its contents are erased.
* `File.AppendText`: Appends data to an existing file without erasing its current contents.

```csharp
StreamWriter outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.Close();
```

### Specifying File Path Location
Use `@` prefix before the string to specify full paths:
```csharp
StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");
```

## Reading Data from a File

Use `File.OpenText` method to open a file for reading:

```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");

string content = inputFile.ReadToEnd(); // Reads all contents
// OR
string line = inputFile.ReadLine(); // Reads one line

inputFile.Close();
```

### Reading a File with a Loop
Use `EndOfStream` property to detect the end of the file:

```csharp
StreamReader reader = File.OpenText("students.txt");
while (reader.EndOfStream == false)
{
    string line = reader.ReadLine();
    listBox1.Items.Add(line);
}
reader.Close();
```


# 5.6 The OpenFileDialog and SaveFileDialog Controls

The `OpenFileDialog` and `SaveFileDialog` controls allow your application to display standard Windows dialog boxes for opening and saving files.

They are **invisible controls** (placed in the component tray at the bottom of the Designer).

## Displaying File Dialogs in Code

```csharp
DialogResult result = openFileDialog.ShowDialog();

if (result == DialogResult.OK)
{
    // User clicked Open
    StreamReader reader = File.OpenText(openFileDialog.FileName);
    // process file...
    reader.Close();
}
else if (result == DialogResult.Cancel)
{
    // User clicked Cancel
    MessageBox.Show("Operation cancelled");
}
```

## SaveFileDialog Example:

```csharp
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamWriter writer = File.CreateText(saveFileDialog.FileName);
    writer.WriteLine("Hello World");
    writer.Close();
}
```


# 5.7 Random Numbers

.NET provides the `Random` class to generate random numbers.

Creating a `Random` object and generating numbers:
```csharp
Random rand = new Random();

int number1 = rand.Next();         // Random integer
double number2 = rand.NextDouble(); // Random float from 0.0 to 1.0
```

## Specifying a Range with Random.Next

To specify an upper limit (0 to max - 1):
```csharp
// Generates a random number from 0 to 99
int number = rand.Next(100);
```


# 5.8 The Load Event

When running an application, the application's form is loaded into memory and an event known as `Load` takes place.

Double-click the Form in the Designer to create the event handler:

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
```
Any code inside the `Load` event handler executes automatically when the form is launched.