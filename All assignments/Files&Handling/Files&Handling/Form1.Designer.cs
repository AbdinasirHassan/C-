namespace SelfTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReadfile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Location = new System.Drawing.Point(177, 102);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(143, 60);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create File";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReadfile
            // 
            this.btnReadfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReadfile.Location = new System.Drawing.Point(177, 182);
            this.btnReadfile.Name = "btnReadfile";
            this.btnReadfile.Size = new System.Drawing.Size(143, 60);
            this.btnReadfile.TabIndex = 1;
            this.btnReadfile.Text = "Read file";
            this.btnReadfile.UseVisualStyleBackColor = false;
            this.btnReadfile.Click += new System.EventHandler(this.btnReadfile_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(177, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 60);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close file";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(599, 51);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(320, 444);
            this.listBox.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(177, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 60);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete data";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 574);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReadfile);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReadfile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnDelete;
    }
}

