
#### Screenshot1
# creating/declaring variable 
        {
            //Creating variables 
            int StudentId, Mark;
            String Depart, StudentName,StudetnType;
            StudentName = txtName.Text;
            Depart = txtDept.Text;
            


# validate
           //Checks user  input 
            if (!int.TryParse(txtId.Text, out StudentId))
            {
                MessageBox.Show("Envalid  Id");
                return;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Envalid Name Please enter your name");
                return;
            }
            if (txtDept.Text == "")
            {
                MessageBox.Show("Envalid Department Please enter your dept");
                return;
            }

            if (!int.TryParse(txtMark.Text, out Mark))
            {
                MessageBox.Show("Envalid  Mark");
                return;
            }
            if ((StudentId < 1))
            {
                MessageBox.Show("ID most be positive integgers & 1 or above");
                return;
            }
            //check marks 0-100

            if (Mark < 0 ||  Mark > 100)
            {
                MessageBox.Show("Envalid Mark. the Marks most be Between 1-100");
                return;
            }
            if (rdoUndergraduate.Checked)
            {
                StudetnType = "UnderGraduate";
            }
            else if (rdoPostgraduate.Checked)
            {
                StudetnType = "Postgraduate";
            }
            else
            {
                MessageBox.Show("Envalid Choose please choose type ");
                return;
            }

#### screenshot2 
# Error handling
            //Error handling try ctach exception
            try
            {
                Output_file = new StreamWriter("Students.txt");

                Output_file.WriteLine("Student Name: " + StudentName);
                Output_file.WriteLine("Student Id: " + StudentId);
                Output_file.WriteLine("Student Dept: " + Depart);
                Output_file.WriteLine("Student Mark: " + Mark);
                Output_file.WriteLine("Student type: "+StudetnType);

               

                // Save file dialog
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "Text Files (*.txt)|*.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(save.FileName, "Saved Data");
                    MessageBox.Show("File created successfully!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //  Read File

        private void btnReadfile_Click(object sender, EventArgs e)
        {
### Screenshot3 
# open file dialog 
           // open file dialog
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Text Files (*.txt)|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(open.FileName);
                Console.WriteLine(content);
            }

            //  try ctach exception
            try
            {
                string content = File.ReadAllText("myfile.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found!");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Close the output file if it is still open
            if (Output_file != null)
            {
                Output_file.Close();
                Output_file = null;
            }

            listBox1.Items.Clear();

            if (File.Exists("Students.txt"))
            {
                using (StreamReader Input_file = new StreamReader("Students.txt"))
                {
                    string line;

                    while (true)
                    {
                        line = Input_file.ReadLine();
                        if(line== null)
                        {
                            break;

                        }
                          
                        listBox1.Items.Add(line);
                    }
                }

                MessageBox.Show("File read successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        //  Clear  File and delete
        private void btnClear_Click(object sender, EventArgs e)
        {

### Screenshot4 
# check files
            //Checks file
            if (Output_file != null)
            {
                Output_file.Close();
                Output_file = null;
            }

            if (File.Exists("Students.txt"))
            {
                File.Delete("Students.txt");

                listBox1.Items.Clear();
                txtDept.Text = "";
                txtId.Text = "";
                txtMark.Text = "";
                txtName.Text = "";


                MessageBox.Show("File deleted successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
