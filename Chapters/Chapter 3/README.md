# Chapter 3 - Making Decisions

# Topics

## 4.1 Decision Structures and the if Statement
## 4.2 The if-else Statement
## 4.3 Nested Decision Structures
## 4.4 Logical Operators
## 4.5 bool Variables and Flags
## 4.6 Comparing Strings
## 4.7 Preventing Data Conversion Exceptions with the TryParse Method
## 4.8 Input Validation
## 4.9 Radio Buttons and Check Boxes
## 4.10 The switch Statement
## 4.11 Introduction to List Boxes


# 4.1 Decision Structures and the if Statement

A **control structure** is a logical design that controls the order in which statements execute.

* **Sequence structure**: A set of statements that execute in the order that they appear.
* **Decision structure**: Executes statements only under certain circumstances (also known as a selection structure).

## A Simple Decision Structure

A single-alternative decision structure provides only one alternative path of execution.

In C#, you can use the `if` statement to write such structures:

```csharp
if (expression)
{
    statement;
    statement;
    // etc.
}
```

The `expression` is a Boolean expression that can be evaluated as either `true` or `false`.

## Relational Operators

A relational operator determines whether a specific relationship exists between two values.

| Operator | Meaning | Expression | Meaning |
| :--- | :--- | :--- | :--- |
| `>` | Greater than | `x > y` | Is x greater than y? |
| `<` | Less than | `x < y` | Is x less than y? |
| `>=` | Greater than or equal to | `x >= y` | Is x greater than or equal to y? |
| `<=` | Less than or equal to | `x <= y` | Is x less than or equal to y? |
| `==` | Equal to | `x == y` | Is x equal to y? |
| `!=` | Not equal to | `x != y` | Is x not equal to y? |

### An if Statement with a Boolean Expression Example:

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```


# 4.2 The if-else Statement

An `if-else` statement will execute one block of statements if its Boolean expression is `true`, or another block if its Boolean expression is `false`.

It has two parts: an `if` clause and an `else` clause.

Generic format:

```csharp
if (expression)
{
    statements;
}
else
{
    statements;
}
```

Example:

```csharp
double Temp = 90;
if (Temp > 40)
{
    MessageBox.Show("hot");
}
else
{
    MessageBox.Show("cold");
}
```


# 4.3 Nested Decision Structures

You can create **nested decision structures** to test more than one condition. Nested means "one inside another".

Generic format:

```csharp
if (expression)
{
    if (expression)
    {
        statements;
    }
    else
    {
        statements;
    }
}
else
{
    statements;
}
```

Example (Loan Qualification):

```csharp
double salary = 45000;
double yearsOnJob = 2;

if (salary >= 40000)
{
    if (yearsOnJob >= 2)
    {
        decisionLabel.Text = "You qualify for the loan.";
    }
    else
    {
        decisionLabel.Text = "Minimum years at current job not met.";
    }
}
else
{
    decisionLabel.Text = "Minimum salary requirement not met.";
}
```

## The if-else-if Statement

You can also create a decision structure that evaluates multiple conditions using the `if-else-if` statement.

Generic format:

```csharp
if (expression)
{
    statements;
}
else if (expression)
{
    statements;
}
else
{
    statements;
}
```

Example (Grade Scale):

```csharp
int score = int.Parse(testScoreTextBox.Text);
string grade;

if (score >= 90)
{
    grade = "A";
}
else if (score >= 80)
{
    grade = "B";
}
else if (score >= 70)
{
    grade = "C";
}
else if (score >= 60)
{
    grade = "D";
}
else
{
    grade = "F";
}
```


# 4.4 Logical Operators

Logical operators allow you to connect multiple Boolean expressions to create a compound expression or reverse the truth of an expression.

| Operator | Meaning | Description |
| :--- | :--- | :--- |
| `&&` | AND | Both subexpressions must be true for the compound expression to be true |
| `\|\|` | OR | One or both subexpressions must be true for the compound expression to be true |
| `!` | NOT | Negates (reverses) the Boolean value to its opposite |

### Truth Table Examples:

* `true && false` $\rightarrow$ `false`
* `true || false` $\rightarrow$ `true`
* `!true` $\rightarrow$ `false`

### Sample Usage:

```csharp
// AND Operator
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// OR Operator
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// NOT Operator
if (!(temperature > 100))
{
    MessageBox.Show("The temperature is below the maximum.");
}
```


# 4.5 bool Variables and Flags

You can store `true` or `false` in `bool` variables, which are commonly used as **flags**.

A flag is a variable that signals when some condition exists in the program:
* `false` – indicates the condition does not exist.
* `true` – indicates the condition exists.

Example:

```csharp
double points = double.Parse(txtPoints.Text);
bool isGrandMaster;

if (points > 5000)
{
    isGrandMaster = true;
}
else
{
    isGrandMaster = false;
}

lblResult.Text = isGrandMaster.ToString();
```


# 4.6 Comparing Strings

You can compare strings using relational operators or methods:

1. **Using `==` or `!=` operators:**
```csharp
if (name1 == name2) { }
if (name1 != "bob") { }
```

2. **Using `String.Compare` method:**
```csharp
if (String.Compare(name1, name2) == 0) { }
```

3. **Using `CompareTo` method:**
```csharp
if (name1.CompareTo(name2) == 0) { }
```


# 4.7 Preventing Data Conversion Exceptions with the TryParse Method

Exceptions caused by invalid user input should be prevented when possible using `TryParse` methods (`int.TryParse`, `double.TryParse`, `decimal.TryParse`).

Generic Syntax:

```csharp
dataType.TryParse(string input, out targetVariable)
```

The `out` keyword is required; it specifies that the `targetVariable` receives the parsed result.

Example:

```csharp
int hours;
if (int.TryParse(textBox1.Text, out hours))
{
    // TryParse succeeded — input is a valid number!
}
```


# 4.8 Input Validation

Input validation is the process of inspecting data entered into a program to ensure it is valid before being used.

While `TryParse` verifies data type conversion, logic checks ensure range and integrity.

Examples:

```csharp
// Payroll hours validation
if (hours > 0 && hours <= 168) { }

// Test score validation
if (testScore >= 0 && testScore <= 100) { }
```


# 4.9 Radio Buttons and Check Boxes

* **Radio Buttons**: Allow users to select one choice from several possible choices (mutually exclusive selection).
* **Check Boxes**: Allow users to select multiple options simultaneously.

## Common Properties:
* `Text`: Displays text next to the control.
* `Checked`: A Boolean property (`true`/`false`) determining whether the control is selected.

In code:

```csharp
if (choiceRadioButton.Checked)
{
    // Selected
}

if (option1CheckBox.Checked)
{
    // Selected
}
```

## The CheckedChanged Event

Whenever a radio button or check box's `Checked` property changes, a `CheckedChanged` event is raised.

```csharp
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
    // Event code here
}
```


# 4.10 The switch Statement

The `switch` statement is a multiple-alternative decision structure that lets the value of a variable or expression determine execution path. It serves as an alternative to an `if-else-if` chain.

Generic Format:

```csharp
switch (testExpression)
{
    case value_1:
        statement;
        break;
    case value_2:
        statement;
        break;
    default:
        statement;
        break;
}
```

* `testExpression`: Expression giving an `int`, `string`, or `bool` value.
* `break`: Required to exit the switch structure.
* `default`: Optional section executed when no match is found.


# 4.11 Introduction to List Boxes

A `ListBox` control displays a list of items and allows the user to select an item.

## Commonly Used Properties:
* `Text`: Text of the currently selected item.
* `Items`: Collection containing the items in the ListBox.
* `Items.Count`: Total number of items in the ListBox.
* `SelectedItem`: Currently selected item object.
* `SelectedIndex`: Zero-based index of the currently selected item (returns `-1` if no item is selected).

### Adding Items:
```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
```

### Checking Selection & Accessing Items:
```csharp
if (fruitListBox.SelectedIndex != -1)
{
    string selectedFruit = fruitListBox.SelectedItem.ToString();
}
```

### Text vs SelectedItem:

| Feature | Text | SelectedItem |
| :--- | :--- | :--- |
| **Type** | `string` | `object` |
| **Use Case** | Quick access to text | Access full underlying object |
| **Flexibility** | Less flexible | More flexible |

### Removing Items:
```csharp
// Remove by value
daysListBox.Items.Remove("Tuesday");

// Remove by index
if (listBox1.SelectedIndex != -1)
{
    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
}

// Clear all items
daysListBox.Items.Clear();
```