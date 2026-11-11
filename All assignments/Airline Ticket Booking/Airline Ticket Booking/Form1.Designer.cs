namespace Airline_Ticket_Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(957, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airlines Ticket Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(571, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(385, 460);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Airlines Booking Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Travel class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Additional options";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTravelInsurance.Location = new System.Drawing.Point(77, 434);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(351, 29);
            this.chkTravelInsurance.TabIndex = 13;
            this.chkTravelInsurance.Text = "Add travel insurance ($25 per ticket)";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFirstClass.Location = new System.Drawing.Point(76, 339);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(124, 29);
            this.rdoFirstClass.TabIndex = 14;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "First class";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalClass.Location = new System.Drawing.Point(216, 339);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(149, 29);
            this.rdoNormalClass.TabIndex = 15;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusinessClass.Location = new System.Drawing.Point(378, 339);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(167, 29);
            this.rdoBusinessClass.TabIndex = 16;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(77, 505);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 42);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(257, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 42);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(454, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 42);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaggageWeight.Location = new System.Drawing.Point(256, 175);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(242, 30);
            this.txtBaggageWeight.TabIndex = 9;
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(256, 135);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(242, 30);
            this.txtTicket.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(256, 96);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(242, 30);
            this.txtAge.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baggage weight(kg): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of ticket: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passenger age: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passenger name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personal Information";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(256, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 30);
            this.txtName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtTicket);
            this.groupBox1.Controls.Add(this.txtBaggageWeight);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 234);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdoBusinessClass);
            this.Controls.Add(this.rdoNormalClass);
            this.Controls.Add(this.rdoFirstClass);
            this.Controls.Add(this.chkTravelInsurance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

