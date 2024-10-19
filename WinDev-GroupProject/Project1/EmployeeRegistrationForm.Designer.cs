namespace Project1
{
    partial class EmployeeRegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblDoj = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSinNum = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSinNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblSalaryPerHr = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBankDetails = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBankDetails = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnEmpRmv = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpClear = new System.Windows.Forms.Button();
            this.datePickerDoj = new System.Windows.Forms.DateTimePicker();
            this.datePickerDob = new System.Windows.Forms.DateTimePicker();
            this.numSalaryPerHr = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSalaryPerHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(33, 89);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(109, 20);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // lblDoj
            // 
            this.lblDoj.AutoSize = true;
            this.lblDoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoj.Location = new System.Drawing.Point(33, 147);
            this.lblDoj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoj.Name = "lblDoj";
            this.lblDoj.Size = new System.Drawing.Size(127, 20);
            this.lblDoj.TabIndex = 1;
            this.lblDoj.Text = "Date of Joining:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(33, 202);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // lblSinNum
            // 
            this.lblSinNum.AutoSize = true;
            this.lblSinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinNum.Location = new System.Drawing.Point(33, 257);
            this.lblSinNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinNum.Name = "lblSinNum";
            this.lblSinNum.Size = new System.Drawing.Size(50, 20);
            this.lblSinNum.TabIndex = 3;
            this.lblSinNum.Text = "SIN#:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(33, 316);
            this.lblDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(110, 20);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Date of Birth:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(33, 366);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(181, 87);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Size = new System.Drawing.Size(241, 26);
            this.txtEmpId.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtEmpId, "Please Enter 6-10 Alphanumeric characters for Employee ID");
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(181, 200);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 26);
            this.txtPhone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtPhone, "Please enter valid 10 digit phone number");
            // 
            // txtSinNum
            // 
            this.txtSinNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinNum.Location = new System.Drawing.Point(181, 255);
            this.txtSinNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtSinNum.Name = "txtSinNum";
            this.txtSinNum.Size = new System.Drawing.Size(241, 26);
            this.txtSinNum.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtSinNum, "Enter valid 9 digit SIN number");
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(148, 364);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 130);
            this.txtAddress.TabIndex = 9;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(448, 95);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(136, 20);
            this.lblEmployeeName.TabIndex = 10;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // lblSalaryPerHr
            // 
            this.lblSalaryPerHr.AutoSize = true;
            this.lblSalaryPerHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPerHr.Location = new System.Drawing.Point(448, 154);
            this.lblSalaryPerHr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalaryPerHr.Name = "lblSalaryPerHr";
            this.lblSalaryPerHr.Size = new System.Drawing.Size(132, 20);
            this.lblSalaryPerHr.TabIndex = 11;
            this.lblSalaryPerHr.Text = "Salary per Hour:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(448, 222);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblBankDetails
            // 
            this.lblBankDetails.AutoSize = true;
            this.lblBankDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankDetails.Location = new System.Drawing.Point(448, 290);
            this.lblBankDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankDetails.Name = "lblBankDetails";
            this.lblBankDetails.Size = new System.Drawing.Size(110, 20);
            this.lblBankDetails.TabIndex = 13;
            this.lblBankDetails.Text = "Bank Details:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(613, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 26);
            this.txtName.TabIndex = 14;
            // 
            // txtBankDetails
            // 
            this.txtBankDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankDetails.Location = new System.Drawing.Point(578, 288);
            this.txtBankDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankDetails.Multiline = true;
            this.txtBankDetails.Name = "txtBankDetails";
            this.txtBankDetails.Size = new System.Drawing.Size(273, 86);
            this.txtBankDetails.TabIndex = 17;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(590, 397);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddEmp.Size = new System.Drawing.Size(100, 40);
            this.btnAddEmp.TabIndex = 18;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // btnEmpRmv
            // 
            this.btnEmpRmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpRmv.Location = new System.Drawing.Point(724, 397);
            this.btnEmpRmv.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpRmv.Name = "btnEmpRmv";
            this.btnEmpRmv.Size = new System.Drawing.Size(100, 40);
            this.btnEmpRmv.TabIndex = 19;
            this.btnEmpRmv.Text = "Remove";
            this.btnEmpRmv.UseVisualStyleBackColor = true;
            this.btnEmpRmv.Click += new System.EventHandler(this.BtnEmpRmv_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpUpdate.Location = new System.Drawing.Point(590, 454);
            this.btnEmpUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnEmpUpdate.TabIndex = 20;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = true;
            this.btnEmpUpdate.Click += new System.EventHandler(this.BtnEmpUpdate_Click);
            // 
            // btnEmpClear
            // 
            this.btnEmpClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpClear.Location = new System.Drawing.Point(724, 454);
            this.btnEmpClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpClear.Name = "btnEmpClear";
            this.btnEmpClear.Size = new System.Drawing.Size(100, 40);
            this.btnEmpClear.TabIndex = 21;
            this.btnEmpClear.Text = "Clear";
            this.btnEmpClear.UseVisualStyleBackColor = true;
            this.btnEmpClear.Click += new System.EventHandler(this.BtnEmpClear_Click);
            // 
            // datePickerDoj
            // 
            this.datePickerDoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerDoj.Location = new System.Drawing.Point(181, 142);
            this.datePickerDoj.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerDoj.Name = "datePickerDoj";
            this.datePickerDoj.Size = new System.Drawing.Size(241, 26);
            this.datePickerDoj.TabIndex = 22;
            // 
            // datePickerDob
            // 
            this.datePickerDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerDob.Location = new System.Drawing.Point(181, 311);
            this.datePickerDob.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerDob.Name = "datePickerDob";
            this.datePickerDob.Size = new System.Drawing.Size(241, 26);
            this.datePickerDob.TabIndex = 23;
            // 
            // numSalaryPerHr
            // 
            this.numSalaryPerHr.DecimalPlaces = 2;
            this.numSalaryPerHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSalaryPerHr.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSalaryPerHr.Location = new System.Drawing.Point(613, 152);
            this.numSalaryPerHr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSalaryPerHr.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSalaryPerHr.Name = "numSalaryPerHr";
            this.numSalaryPerHr.Size = new System.Drawing.Size(136, 26);
            this.numSalaryPerHr.TabIndex = 24;
            this.numSalaryPerHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSalaryPerHr.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(578, 220);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // EmployeeRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 554);
            this.Controls.Add(this.numSalaryPerHr);
            this.Controls.Add(this.datePickerDob);
            this.Controls.Add(this.datePickerDoj);
            this.Controls.Add(this.btnEmpClear);
            this.Controls.Add(this.btnEmpUpdate);
            this.Controls.Add(this.btnEmpRmv);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtBankDetails);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBankDetails);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSalaryPerHr);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSinNum);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblSinNum);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDoj);
            this.Controls.Add(this.lblEmployeeId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSalaryPerHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblDoj;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSinNum;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSinNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblSalaryPerHr;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBankDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBankDetails;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnEmpRmv;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpClear;
        private System.Windows.Forms.DateTimePicker datePickerDoj;
        private System.Windows.Forms.DateTimePicker datePickerDob;
        private System.Windows.Forms.NumericUpDown numSalaryPerHr;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}