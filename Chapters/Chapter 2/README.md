#  Chapter 2 - Processing Data

# Chapter 2 - Topics 

3.1 Reading Input with TextBox Controls

3.2 A First Look at Variables

3.3 Numeric Data Type and Variables

3.4 Performing Calculations

3.5 Inputting and Outputting Numeric Values

3.6 Formatting Numbers with the ToString Method

3.7 Simple Exception Handling

3.8 Using Named Constants

3.9 Declaring Variables as Fields

3.10 Using the Math Class

3.11 More G U I Details

3.12 Using the Debugger to Locate Logic Errors


# The Text Property

A TextBox control’s Text property stores the user inputs

Text property accepts only string values, e.g.

textBox1.Text = "Hello";

To clear the content of a TextBox control, assign an
empty string("")

textBox1.Text = string.Empty;

textBox1.Clear();

# 3.2 A First Look at Variables

A variable is a storage location in memory

A variable name represents the memory location

In

you must declare a variable in a program before

using it to store data

The syntax to declare variables is:

DataType VariableName;

# Data Types

A

variable must be declared with a proper data type

The data type specifies the type of data a variable can hold

In

many data types are known as primitive data types

they store fundamental types of data (means essential or core

such as strings and integers

“Primitive” means basic / simple / built-in.

In C#, primitive data types are already defined by the
language, not created by you.



# Declaring Local Variables with the var
Keyword

var is a keyword you can use instead of writing the full type of a variable.

The compiler automatically figures out the type from the value you assign
(this is called type inference).

You can use the var keyword to declare and initialize a local variable.
Example:

var interestRate = 12.0;

var stockCode = "D465U";

var accountBalance = 1000.0m;

You must provide an initialization value when declaring a variable with var.

The compiler determines the variable's data type from the initialization value.

The var keyword can be used only to declare local variables (variables
declared inside a method).

Later you will see how var can simplify complex declarations.

# Displaying Numeric Values

The Text property of a control only accepts string literals

To display a number in a TextBox or Label control requires you to convert a
numeric data to string type

In

all variables work with the ToString method to convert the value of

the variables to strings:

You call the ToString method using the following general format:
variableName.ToString()

decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;

MessageBox.Show(myNumber.ToString());

Another option is “implicit string conversion with the + operator”:

int idNumber = 1044;

string output = "Your ID number is " + idNumber;

# 3.8 Using Named Constants

A named constant is a name that represents a value that cannot be
changed during the program’s execution

In a constant can be declared by const keyword:

const double INTEREST_RATE = 0.129;

Writing the name of a constant in uppercase letters is traditional in
many programming languages but is not a requirement.

# 3.9 Declaring Variables as Fields

A field is a variable that is declared at the class level

It is declared inside the class, but not inside of any
method

A field’s scope is the entire class

In the following FieldDemo application, the name
variable is a field that is declared in the Form1 class

The name field is created in memory when the Form1
form is created

# 3.10 Using the Math Class

The .NET Math class provides several methods for performing
complex mathematical calculations

Math.Sqrt(x): returns the square root of x (a double).

Math.Pow(x, y): returns the value of x raised to the power of
y. Both x and y are double.

Math.Max(x, y): Returns the greater of the two values x and y

Math.Min(x, y):Returns the lesser of the two values x and y.

Math.Round(x) :Returns the value of x (a double or a decimal)
rounded to the nearest integer.

There are two predefined constants:

Math.PI: represents the ratio of the circumference of a circle
to its diameter.

Math.E: represents the natural logarithmic base

# 3.11 More G U I Details – Tab Order

When an application is running, one of the form’s controls always
has the focus

Focus means a control receives the user’s keyboard input

When a button has the focus, pressing the Enter key can
execute the button’s Click event handler

The order in which controls receive the focus is called the tab order

When the user presses the tab key to select controls, the
program will follow the tab order

The TabIndex property contains a numeric value indicating the
control’s position in the tab order

The value starts with 0. The index of first control is 0, the nth

control is

#