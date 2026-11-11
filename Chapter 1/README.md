# Chapter 1 - Introduction to Visual

# Topics

## 1.1 Objects
## 1.2 The Program Development Process
## 1.8 Getting Started with Visual Studio
## 2.1 Getting Started with Forms and Controls
## 2.2 Creating the G U I for Your First Visual C# Application
## 2.3 Introduction to C# code
## 2.4 Writing Code for the Hello World Application
## 2.5 Label Controls
## 2.6 Making Sense of IntelliSense
## 2.7 PictureBox Controls
## 2.8 Comments, Blank Lines, and Indentation
## 2.9 Writing the Code to Close an Application’s Form
## 2.10 Dealing with Syntax Errors


# 1.1 Objects

An object is a program component that contains data and performs
operations, Programs use objects to perform specific tasks.

Most programming languages use object-oriented programming in
which a program component is called an “object”

Program objects have properties (or fields) and methods

Properties – data stored in an object

Methods – the operations an object can perform

Controls

Objects that are visible in a program G U I are known as
controls

Commonly used controls are Labels, Buttons, and
TextBoxes

They enhance the functionality of your programs

There are invisible objects in a G U I such as Timers, and
OpenFileDialog

A class is code that describes a particular type of object

# 1.2 Getting Started with Visual Studio (1 of 5)

Visual Studio is a professional integrated development
environment (I D E)

The Visual Studio Environment includes:

Designer Window

Solution Explorer Window

Properties Window

# 1.4 Getting Started with Visual Studio (5 of 5)

Auto Hide allows a window to display only as a tab of the
edges
Menu Bar and Standard Toolbar

Menu bar provides menus such as File, Edit, View,
Project, etc.

Standard toolbar contains buttons that execute frequently
used commands

The Toolbox (1 of 2)

Toolbox is a window for selecting controls to use in an application

Typically appears on the left side of Visual Studio environment

Often is in Auto Hide mode

## The Properties Window

The appearance and other characteristics of a G U I object are
determined by the object's properties

Properties are settings that control how the object looks and
behaves

The Properties window lists all properties

When selecting an object, its properties are displayed in
Properties windows

Each property has 2 columns:

Left: property’s name

Right: property’s value

## Rules for Naming Controls

Controls’ are identified by their names in code

Control names are also known as identifiers.

The naming rules are:

The first character must be a letter (lower or uppercase, does
not matter) or an underscore (_)

All other characters can be alphanumerical characters or
underscores

The name cannot contain spaces

Examples of valid names are:

# 2.2 Creating the G U I for Your First Visual
c sharp Application

In section 2.2 you will start creating an app that has a
Form and a Button control

When the app is finished, it will display the message
"Hello World" when the Button control is clicked

In this section you will create the G U I

In section 2.3 you will learn the details of coding an app

In section 2.4 you will write the code that displays “Hello
World” when the user clicks the button

# 2.3 Introduction to c sharp Code

code is primarily organized in three ways: namespaces, classes, and
methods

Namespace: a container that holds classes

Class: a container that holds methods

Method: a group of one or more programming statements that
perform some operations

A file that contains program code is called a source code file

## Adding Your Code

G U I applications are event-driven which means they respond to events that
occur while the application is running

This means the program waits for the user to do something (like
clicking a button, typing, or moving the mouse) and then responds.

An event is a user’s action such as mouse clicking, key pressing, Moving

In the Designer, double clicking a control such as Button will link the control
to a default Event Handler

An event handler is a method that executes when a specific event takes
place

A code segment similar to the following will be created automatically:

# 2.5 Label Controls

A Label control displays text on a form and can be used to
display unchanging text or program output

Commonly used properties are:

Text: gets(read) or sets(write/change) the text associated
with Label control

Name: gets or sets the name of Label control

Font: allows you to set the font, font style, and font size

BorderStyle: allows you to display a border around the
control’s text

AutoSize: controls the way they can be resized

TextAlign: set the text alignments

# 2.6 Making Sense of IntelliSense

IntelliSense provides automatic code completion as you write
programming statements

IntelliSense is a smart code completion feature. As you type in
your code, it automatically suggests possible keywords, variables,
methods, classes, or properties that you might want to use.

It provides an array of options that make language references easily
accessible

With it, you can find the information you need, and insert language
elements directly into your code

# 2.7 PictureBox Controls

A PictureBox control displays a graphic image on a form

Commonly used properties are:

Image: specifies the image that it will display

SizeMode: specifies how the control’s image is to be
displayed

Visible: determines whether the control is visible on
the form at run time

Creating Clickable Images

You can double click the PictureBox control in the Designer to
create a Click event handler and then add your codes to it. For
example,

And

Sequential Execution of Statements

Programmers need to carefully arrange the sequence of statements in order
to generate the correct results

In the following example, the statements in the method execute in the order
that they appear:

private void showBackButton_Click(object sender, EventArgs e)

{

cardBackPictureBox.Visible = true;

cardFacePictureBox.Visible = false;

}

Incorrect arrangement of sequence can cause logic errors

private void showBackButton_Click(object sender, EventArgs e)

{

cardBackPictureBox.Visible = False;

cardFacePictureBox.Visible = false;

}

This makes sense because when you click the button, you want to flip the
card: back is visible, face is hidden.

What happens here? First line hides the face second line also hides the back.
Result: Both pictures are hidden.

# 2.8 Comments, Blank Links, and
Indentation

Comments are brief notes that are placed in a program’s
source code to explain how parts of the program work

A line comment appears on one line in a program

// Make image of the card back visible.

cardBackPictureBox.Visible = true;

A block comment can occupy multiple consecutive lines
in a program

/*

Line one

Line two

*/

## Using Blank Lines and Indentation (1 of 2)

Programmers frequently use blank lines and indentation in their codes to make the
code more human-readable

Compare the following two identical codes:

namespace Wage_Calculator

{

public partial class Form1 : Form

{

public Form1()

{

lnitializeComponent();

}

private void exitButton_Click(object sender, EventArgs e)

{

// Close the form.

this.Close();

}

}

}

Using Blank Lines and Indentation (2 of 2)

namespace Wage_ Calculator

{

public partial class Form1 : Form

{

public Form1()

{

lnitializeComponent();

}

private void exitButton_ Click(object sender,
EventArgs e)

{

// Close the form.

this. Close();

}

}

}

# 2.9 Writing the Code to Close an
Application’s Form

To close an application’s form in code, use the following
statement:

A commonly used practice is to create an Exit button and
manually add the code to it:

this.Close();

Application.Exit;

# 2.10 Dealing with Syntax Errors

The Visual Studio code editor examines each statement as
you type it and reports any syntax errors that are found

If a syntax error is found, it is underlined with a jagged line

If a syntax error exists and you attempt to compile and
execute, you will see the following window