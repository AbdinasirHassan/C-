
##### Screenshot 1

## creating file
        // 1. Create File
        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                Output_file = new StreamWriter("Students.txt");

                Output_file.WriteLine("Name: Abdinasir");
                Output_file.WriteLine("ID: C1240324");
                Output_file.WriteLine("Fac: Computer Application");

                MessageBox.Show("File created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
##### Screenshot 2 
# reading file 
        // 2. Read File
       
            private void btnReadfile_Click(object sender, EventArgs e)
        {
            // Close the output file if it is still open
            if (Output_file != null)
            {
                Output_file.Close();
                Output_file = null;
            }

            listBox.Items.Clear();

            if (File.Exists("Students.txt"))
            {
                using (StreamReader Input_file = new StreamReader("Students.txt"))
                {
                    string line;

                    while ((line = Input_file.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);
                    }
                }

                MessageBox.Show("File read successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }


        // 3. Close File
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (Output_file != null)
            {
                Output_file.Close();
                Output_file = null;

                MessageBox.Show("File closed successfully!");
            }
            else
            {
                MessageBox.Show("No open file to close!");
            }
        }

#### screenshot3 
## deleting file 
        // 4. Delete File
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Output_file != null)
            {
                Output_file.Close();
                Output_file = null;
            }

            if (File.Exists("Students.txt"))
            {
                File.Delete("Students.txt");

                listBox.Items.Clear();

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
