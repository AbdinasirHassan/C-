# Screenshot1

## line 1 covers
- Creating String variables
- name and dept 
 
## line 2 covers
- Creating Integer variables
-- Semester and StudentId

# Screenshot2
- Storing data to variable i created 
## line1

storing name input form textbox 
to variable name
name = txtname.Text;

## line2

storing department input form textbox 
to variable dept
dept = txtdeptment.Text;

## line3

storing student Id input form textbox 
to variable studentId
studentId = int.parse(txtstudentId.Text;)
int.parse converts string to integer 

## line4

storing semester input form textbox 
to variable semester
semester = int.parse(txtSemester.Text;)
int.parse converts string to integer 

# Screenshot3

displaying information to label 

lbloutput = student name: + 
          name + "ID "+studentId+
         "Department"+ dept + "Semester"+ semester+ 


# Screenshot4
- clearing data from lbloutput information 
lbloutput.Text = "";
            txtStudentId.Text = string.Empty;
            txtSemester.Text = string.Empty;
            txtname.Text = string.Empty;
            txtdepartment.Text = string.Empty;

