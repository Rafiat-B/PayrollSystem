namespace Project1
{
    partial class PayrollCalculator
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
            this.lblProvincialTax = new System.Windows.Forms.Label();
            this.lblFdrlIncomeTx = new System.Windows.Forms.Label();
            this.lblCppEi = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblInsrncDdctn = new System.Windows.Forms.Label();
            this.lblOthrDdctn = new System.Windows.Forms.Label();
            this.lblTotalDdctns = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grpBoxTax = new System.Windows.Forms.GroupBox();
            this.txtTotalTax = new System.Windows.Forms.Label();
            this.txtCppEiPrmum = new System.Windows.Forms.Label();
            this.txtFdrlIncmTax = new System.Windows.Forms.Label();
            this.txtProvincialTax = new System.Windows.Forms.Label();
            this.grpBoxDdctn = new System.Windows.Forms.GroupBox();
            this.txtTotalDdctn = new System.Windows.Forms.Label();
            this.txtRglrDdctn = new System.Windows.Forms.Label();
            this.txtInsrncDdctn = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblOthrDdctns = new System.Windows.Forms.Label();
            this.lblOvertimeRate = new System.Windows.Forms.Label();
            this.lblOvertimehrs = new System.Windows.Forms.Label();
            this.lblHoursWorded = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblTaxesNDdctns = new System.Windows.Forms.Label();
            this.txtHourlyWage = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.Label();
            this.txtTaxNDdctns = new System.Windows.Forms.Label();
            this.grpBasicPayInfo = new System.Windows.Forms.GroupBox();
            this.numOtherDeductions = new System.Windows.Forms.NumericUpDown();
            this.numOvertimeRate = new System.Windows.Forms.NumericUpDown();
            this.numOvertimeHrsWorked = new System.Windows.Forms.NumericUpDown();
            this.numHrsWorked = new System.Windows.Forms.NumericUpDown();
            this.txtEmpId = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.btnUpdatePay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblPayrollStatus = new System.Windows.Forms.Label();
            this.grpBoxStatus = new System.Windows.Forms.GroupBox();
            this.grpBoxTax.SuspendLayout();
            this.grpBoxDdctn.SuspendLayout();
            this.grpBasicPayInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherDeductions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOvertimeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOvertimeHrsWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHrsWorked)).BeginInit();
            this.grpBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProvincialTax
            // 
            this.lblProvincialTax.AutoSize = true;
            this.lblProvincialTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincialTax.Location = new System.Drawing.Point(23, 49);
            this.lblProvincialTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincialTax.Name = "lblProvincialTax";
            this.lblProvincialTax.Size = new System.Drawing.Size(114, 20);
            this.lblProvincialTax.TabIndex = 22;
            this.lblProvincialTax.Text = "Provincial Tax";
            // 
            // lblFdrlIncomeTx
            // 
            this.lblFdrlIncomeTx.AutoSize = true;
            this.lblFdrlIncomeTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFdrlIncomeTx.Location = new System.Drawing.Point(23, 104);
            this.lblFdrlIncomeTx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFdrlIncomeTx.Name = "lblFdrlIncomeTx";
            this.lblFdrlIncomeTx.Size = new System.Drawing.Size(156, 20);
            this.lblFdrlIncomeTx.TabIndex = 23;
            this.lblFdrlIncomeTx.Text = "Federal Income Tax";
            // 
            // lblCppEi
            // 
            this.lblCppEi.AutoSize = true;
            this.lblCppEi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCppEi.Location = new System.Drawing.Point(23, 164);
            this.lblCppEi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCppEi.Name = "lblCppEi";
            this.lblCppEi.Size = new System.Drawing.Size(142, 20);
            this.lblCppEi.TabIndex = 24;
            this.lblCppEi.Text = "CPP/EI premiums";
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalTax.Location = new System.Drawing.Point(23, 216);
            this.lblTotalTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(107, 20);
            this.lblTotalTax.TabIndex = 26;
            this.lblTotalTax.Text = "Total Taxes";
            // 
            // lblInsrncDdctn
            // 
            this.lblInsrncDdctn.AutoSize = true;
            this.lblInsrncDdctn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsrncDdctn.Location = new System.Drawing.Point(24, 40);
            this.lblInsrncDdctn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsrncDdctn.Name = "lblInsrncDdctn";
            this.lblInsrncDdctn.Size = new System.Drawing.Size(163, 20);
            this.lblInsrncDdctn.TabIndex = 28;
            this.lblInsrncDdctn.Text = "Insurance Deduction";
            // 
            // lblOthrDdctn
            // 
            this.lblOthrDdctn.AutoSize = true;
            this.lblOthrDdctn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthrDdctn.Location = new System.Drawing.Point(24, 95);
            this.lblOthrDdctn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOthrDdctn.Name = "lblOthrDdctn";
            this.lblOthrDdctn.Size = new System.Drawing.Size(195, 20);
            this.lblOthrDdctn.TabIndex = 29;
            this.lblOthrDdctn.Text = "Other Regular Deduction";
            // 
            // lblTotalDdctns
            // 
            this.lblTotalDdctns.AutoSize = true;
            this.lblTotalDdctns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDdctns.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalDdctns.Location = new System.Drawing.Point(23, 152);
            this.lblTotalDdctns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDdctns.Name = "lblTotalDdctns";
            this.lblTotalDdctns.Size = new System.Drawing.Size(175, 25);
            this.lblTotalDdctns.TabIndex = 30;
            this.lblTotalDdctns.Text = "Total Deductions";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(50, 48);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(367, 48);
            this.label22.TabIndex = 31;
            this.label22.Text = "Payroll Calculator";
            // 
            // grpBoxTax
            // 
            this.grpBoxTax.Controls.Add(this.txtTotalTax);
            this.grpBoxTax.Controls.Add(this.txtCppEiPrmum);
            this.grpBoxTax.Controls.Add(this.txtFdrlIncmTax);
            this.grpBoxTax.Controls.Add(this.txtProvincialTax);
            this.grpBoxTax.Controls.Add(this.lblTotalTax);
            this.grpBoxTax.Controls.Add(this.lblCppEi);
            this.grpBoxTax.Controls.Add(this.lblFdrlIncomeTx);
            this.grpBoxTax.Controls.Add(this.lblProvincialTax);
            this.grpBoxTax.Location = new System.Drawing.Point(527, 115);
            this.grpBoxTax.Name = "grpBoxTax";
            this.grpBoxTax.Size = new System.Drawing.Size(392, 258);
            this.grpBoxTax.TabIndex = 33;
            this.grpBoxTax.TabStop = false;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.AutoSize = true;
            this.txtTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTotalTax.Location = new System.Drawing.Point(240, 216);
            this.txtTotalTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.Size = new System.Drawing.Size(104, 20);
            this.txtTotalTax.TabIndex = 30;
            this.txtTotalTax.Text = "<total Tax>";
            // 
            // txtCppEiPrmum
            // 
            this.txtCppEiPrmum.AutoSize = true;
            this.txtCppEiPrmum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCppEiPrmum.Location = new System.Drawing.Point(240, 159);
            this.txtCppEiPrmum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCppEiPrmum.Name = "txtCppEiPrmum";
            this.txtCppEiPrmum.Size = new System.Drawing.Size(149, 20);
            this.txtCppEiPrmum.TabIndex = 29;
            this.txtCppEiPrmum.Text = "<Cpp/Ei premium>";
            // 
            // txtFdrlIncmTax
            // 
            this.txtFdrlIncmTax.AutoSize = true;
            this.txtFdrlIncmTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFdrlIncmTax.Location = new System.Drawing.Point(240, 104);
            this.txtFdrlIncmTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFdrlIncmTax.Name = "txtFdrlIncmTax";
            this.txtFdrlIncmTax.Size = new System.Drawing.Size(117, 20);
            this.txtFdrlIncmTax.TabIndex = 28;
            this.txtFdrlIncmTax.Text = "<Federal Tax>";
            // 
            // txtProvincialTax
            // 
            this.txtProvincialTax.AutoSize = true;
            this.txtProvincialTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincialTax.Location = new System.Drawing.Point(240, 49);
            this.txtProvincialTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtProvincialTax.Name = "txtProvincialTax";
            this.txtProvincialTax.Size = new System.Drawing.Size(127, 20);
            this.txtProvincialTax.TabIndex = 27;
            this.txtProvincialTax.Text = "<provincial tax>";
            // 
            // grpBoxDdctn
            // 
            this.grpBoxDdctn.Controls.Add(this.txtTotalDdctn);
            this.grpBoxDdctn.Controls.Add(this.txtRglrDdctn);
            this.grpBoxDdctn.Controls.Add(this.txtInsrncDdctn);
            this.grpBoxDdctn.Controls.Add(this.lblInsrncDdctn);
            this.grpBoxDdctn.Controls.Add(this.lblOthrDdctn);
            this.grpBoxDdctn.Controls.Add(this.lblTotalDdctns);
            this.grpBoxDdctn.Location = new System.Drawing.Point(526, 379);
            this.grpBoxDdctn.Name = "grpBoxDdctn";
            this.grpBoxDdctn.Size = new System.Drawing.Size(392, 199);
            this.grpBoxDdctn.TabIndex = 34;
            this.grpBoxDdctn.TabStop = false;
            // 
            // txtTotalDdctn
            // 
            this.txtTotalDdctn.AutoSize = true;
            this.txtTotalDdctn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDdctn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTotalDdctn.Location = new System.Drawing.Point(230, 151);
            this.txtTotalDdctn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalDdctn.Name = "txtTotalDdctn";
            this.txtTotalDdctn.Size = new System.Drawing.Size(155, 25);
            this.txtTotalDdctn.TabIndex = 33;
            this.txtTotalDdctn.Text = "<ttl deduction>";
            // 
            // txtRglrDdctn
            // 
            this.txtRglrDdctn.AutoSize = true;
            this.txtRglrDdctn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRglrDdctn.Location = new System.Drawing.Point(241, 95);
            this.txtRglrDdctn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRglrDdctn.Name = "txtRglrDdctn";
            this.txtRglrDdctn.Size = new System.Drawing.Size(129, 20);
            this.txtRglrDdctn.TabIndex = 32;
            this.txtRglrDdctn.Text = "<Regural amnt>";
            // 
            // txtInsrncDdctn
            // 
            this.txtInsrncDdctn.AutoSize = true;
            this.txtInsrncDdctn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsrncDdctn.Location = new System.Drawing.Point(241, 40);
            this.txtInsrncDdctn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtInsrncDdctn.Name = "txtInsrncDdctn";
            this.txtInsrncDdctn.Size = new System.Drawing.Size(144, 20);
            this.txtInsrncDdctn.TabIndex = 31;
            this.txtInsrncDdctn.Text = "<insurance amnt>";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(39, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(94, 25);
            this.txtName.TabIndex = 17;
            this.txtName.Text = "<Name>";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNetPay.Location = new System.Drawing.Point(40, 497);
            this.lblNetPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(104, 25);
            this.lblNetPay.TabIndex = 10;
            this.lblNetPay.Text = "NET PAY";
            // 
            // lblOthrDdctns
            // 
            this.lblOthrDdctns.AutoSize = true;
            this.lblOthrDdctns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthrDdctns.Location = new System.Drawing.Point(40, 431);
            this.lblOthrDdctns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOthrDdctns.Name = "lblOthrDdctns";
            this.lblOthrDdctns.Size = new System.Drawing.Size(132, 20);
            this.lblOthrDdctns.TabIndex = 9;
            this.lblOthrDdctns.Text = "Other Deduction";
            // 
            // lblOvertimeRate
            // 
            this.lblOvertimeRate.AutoSize = true;
            this.lblOvertimeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertimeRate.Location = new System.Drawing.Point(40, 266);
            this.lblOvertimeRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOvertimeRate.Name = "lblOvertimeRate";
            this.lblOvertimeRate.Size = new System.Drawing.Size(117, 20);
            this.lblOvertimeRate.TabIndex = 6;
            this.lblOvertimeRate.Text = "Overtime Rate";
            // 
            // lblOvertimehrs
            // 
            this.lblOvertimehrs.AutoSize = true;
            this.lblOvertimehrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertimehrs.Location = new System.Drawing.Point(40, 212);
            this.lblOvertimehrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOvertimehrs.Name = "lblOvertimehrs";
            this.lblOvertimehrs.Size = new System.Drawing.Size(128, 20);
            this.lblOvertimehrs.TabIndex = 5;
            this.lblOvertimehrs.Text = "Overtime Hours";
            // 
            // lblHoursWorded
            // 
            this.lblHoursWorded.AutoSize = true;
            this.lblHoursWorded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorded.Location = new System.Drawing.Point(41, 159);
            this.lblHoursWorded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoursWorded.Name = "lblHoursWorded";
            this.lblHoursWorded.Size = new System.Drawing.Size(180, 20);
            this.lblHoursWorded.TabIndex = 2;
            this.lblHoursWorded.Text = "Regular Hours Worked";
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyWage.Location = new System.Drawing.Point(41, 104);
            this.lblHourlyWage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(106, 20);
            this.lblHourlyWage.TabIndex = 1;
            this.lblHourlyWage.Text = "Hourly Wage";
            // 
            // lblTaxesNDdctns
            // 
            this.lblTaxesNDdctns.AutoSize = true;
            this.lblTaxesNDdctns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxesNDdctns.Location = new System.Drawing.Point(40, 377);
            this.lblTaxesNDdctns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxesNDdctns.Name = "lblTaxesNDdctns";
            this.lblTaxesNDdctns.Size = new System.Drawing.Size(176, 20);
            this.lblTaxesNDdctns.TabIndex = 8;
            this.lblTaxesNDdctns.Text = "Taxes and Deductions";
            // 
            // txtHourlyWage
            // 
            this.txtHourlyWage.AutoSize = true;
            this.txtHourlyWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyWage.Location = new System.Drawing.Point(298, 104);
            this.txtHourlyWage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHourlyWage.Name = "txtHourlyWage";
            this.txtHourlyWage.Size = new System.Drawing.Size(118, 20);
            this.txtHourlyWage.TabIndex = 19;
            this.txtHourlyWage.Text = "<hourly wage>";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.AutoSize = true;
            this.txtGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(297, 323);
            this.txtGrossPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(102, 20);
            this.txtGrossPay.TabIndex = 20;
            this.txtGrossPay.Text = "<gross pay>";
            // 
            // txtTaxNDdctns
            // 
            this.txtTaxNDdctns.AutoSize = true;
            this.txtTaxNDdctns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxNDdctns.Location = new System.Drawing.Point(297, 377);
            this.txtTaxNDdctns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTaxNDdctns.Name = "txtTaxNDdctns";
            this.txtTaxNDdctns.Size = new System.Drawing.Size(152, 20);
            this.txtTaxNDdctns.TabIndex = 21;
            this.txtTaxNDdctns.Text = "<tax + deductions>";
            // 
            // grpBasicPayInfo
            // 
            this.grpBasicPayInfo.Controls.Add(this.numOtherDeductions);
            this.grpBasicPayInfo.Controls.Add(this.numOvertimeRate);
            this.grpBasicPayInfo.Controls.Add(this.numOvertimeHrsWorked);
            this.grpBasicPayInfo.Controls.Add(this.numHrsWorked);
            this.grpBasicPayInfo.Controls.Add(this.txtEmpId);
            this.grpBasicPayInfo.Controls.Add(this.txtNetPay);
            this.grpBasicPayInfo.Controls.Add(this.txtTaxNDdctns);
            this.grpBasicPayInfo.Controls.Add(this.txtGrossPay);
            this.grpBasicPayInfo.Controls.Add(this.txtHourlyWage);
            this.grpBasicPayInfo.Controls.Add(this.lblTaxesNDdctns);
            this.grpBasicPayInfo.Controls.Add(this.lblHourlyWage);
            this.grpBasicPayInfo.Controls.Add(this.lblHoursWorded);
            this.grpBasicPayInfo.Controls.Add(this.lblOvertimehrs);
            this.grpBasicPayInfo.Controls.Add(this.lblOvertimeRate);
            this.grpBasicPayInfo.Controls.Add(this.lblGrossPay);
            this.grpBasicPayInfo.Controls.Add(this.lblOthrDdctns);
            this.grpBasicPayInfo.Controls.Add(this.lblNetPay);
            this.grpBasicPayInfo.Controls.Add(this.txtName);
            this.grpBasicPayInfo.Location = new System.Drawing.Point(37, 115);
            this.grpBasicPayInfo.Name = "grpBasicPayInfo";
            this.grpBasicPayInfo.Size = new System.Drawing.Size(483, 547);
            this.grpBasicPayInfo.TabIndex = 32;
            this.grpBasicPayInfo.TabStop = false;
            // 
            // numOtherDeductions
            // 
            this.numOtherDeductions.DecimalPlaces = 2;
            this.numOtherDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOtherDeductions.Location = new System.Drawing.Point(302, 429);
            this.numOtherDeductions.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numOtherDeductions.Name = "numOtherDeductions";
            this.numOtherDeductions.Size = new System.Drawing.Size(133, 26);
            this.numOtherDeductions.TabIndex = 4;
            // 
            // numOvertimeRate
            // 
            this.numOvertimeRate.DecimalPlaces = 2;
            this.numOvertimeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOvertimeRate.Location = new System.Drawing.Point(301, 264);
            this.numOvertimeRate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numOvertimeRate.Name = "numOvertimeRate";
            this.numOvertimeRate.Size = new System.Drawing.Size(133, 26);
            this.numOvertimeRate.TabIndex = 3;
            // 
            // numOvertimeHrsWorked
            // 
            this.numOvertimeHrsWorked.DecimalPlaces = 1;
            this.numOvertimeHrsWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOvertimeHrsWorked.Location = new System.Drawing.Point(301, 210);
            this.numOvertimeHrsWorked.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numOvertimeHrsWorked.Name = "numOvertimeHrsWorked";
            this.numOvertimeHrsWorked.Size = new System.Drawing.Size(133, 26);
            this.numOvertimeHrsWorked.TabIndex = 2;
            // 
            // numHrsWorked
            // 
            this.numHrsWorked.DecimalPlaces = 1;
            this.numHrsWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHrsWorked.Location = new System.Drawing.Point(302, 157);
            this.numHrsWorked.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numHrsWorked.Name = "numHrsWorked";
            this.numHrsWorked.Size = new System.Drawing.Size(133, 26);
            this.numHrsWorked.TabIndex = 1;
            // 
            // txtEmpId
            // 
            this.txtEmpId.AutoSize = true;
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(39, 18);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(105, 25);
            this.txtEmpId.TabIndex = 23;
            this.txtEmpId.Text = "<Emp Id>";
            // 
            // txtNetPay
            // 
            this.txtNetPay.AutoSize = true;
            this.txtNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNetPay.Location = new System.Drawing.Point(296, 496);
            this.txtNetPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(109, 25);
            this.txtNetPay.TabIndex = 22;
            this.txtNetPay.Text = "<net pay>";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(41, 323);
            this.lblGrossPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(88, 20);
            this.lblGrossPay.TabIndex = 7;
            this.lblGrossPay.Text = "Gross Pay";
            // 
            // btnUpdatePay
            // 
            this.btnUpdatePay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdatePay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdatePay.Location = new System.Drawing.Point(689, 674);
            this.btnUpdatePay.Name = "btnUpdatePay";
            this.btnUpdatePay.Size = new System.Drawing.Size(100, 40);
            this.btnUpdatePay.TabIndex = 6;
            this.btnUpdatePay.Text = "&UPDATE";
            this.btnUpdatePay.UseVisualStyleBackColor = false;
            this.btnUpdatePay.Click += new System.EventHandler(this.BtnUpdatePay_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(811, 674);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalculate.Location = new System.Drawing.Point(526, 674);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 40);
            this.btnCalculate.TabIndex = 35;
            this.btnCalculate.Text = "C&ALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(220, 29);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 28);
            this.cbxStatus.TabIndex = 36;
            // 
            // lblPayrollStatus
            // 
            this.lblPayrollStatus.AutoSize = true;
            this.lblPayrollStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrollStatus.Location = new System.Drawing.Point(28, 32);
            this.lblPayrollStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayrollStatus.Name = "lblPayrollStatus";
            this.lblPayrollStatus.Size = new System.Drawing.Size(113, 20);
            this.lblPayrollStatus.TabIndex = 24;
            this.lblPayrollStatus.Text = "Payroll Status";
            // 
            // grpBoxStatus
            // 
            this.grpBoxStatus.Controls.Add(this.lblPayrollStatus);
            this.grpBoxStatus.Controls.Add(this.cbxStatus);
            this.grpBoxStatus.Location = new System.Drawing.Point(530, 584);
            this.grpBoxStatus.Name = "grpBoxStatus";
            this.grpBoxStatus.Size = new System.Drawing.Size(389, 78);
            this.grpBoxStatus.TabIndex = 31;
            this.grpBoxStatus.TabStop = false;
            // 
            // PayrollCalculator
            // 
            this.AcceptButton = this.btnUpdatePay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(948, 731);
            this.Controls.Add(this.grpBoxStatus);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdatePay);
            this.Controls.Add(this.grpBasicPayInfo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.grpBoxDdctn);
            this.Controls.Add(this.grpBoxTax);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PayrollCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payroll Calculator";
            this.Load += new System.EventHandler(this.PayrollCalculator_Load);
            this.grpBoxTax.ResumeLayout(false);
            this.grpBoxTax.PerformLayout();
            this.grpBoxDdctn.ResumeLayout(false);
            this.grpBoxDdctn.PerformLayout();
            this.grpBasicPayInfo.ResumeLayout(false);
            this.grpBasicPayInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherDeductions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOvertimeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOvertimeHrsWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHrsWorked)).EndInit();
            this.grpBoxStatus.ResumeLayout(false);
            this.grpBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProvincialTax;
        private System.Windows.Forms.Label lblFdrlIncomeTx;
        private System.Windows.Forms.Label lblCppEi;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblInsrncDdctn;
        private System.Windows.Forms.Label lblOthrDdctn;
        private System.Windows.Forms.Label lblTotalDdctns;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grpBoxTax;
        private System.Windows.Forms.GroupBox grpBoxDdctn;
        private System.Windows.Forms.Label txtTotalTax;
        private System.Windows.Forms.Label txtCppEiPrmum;
        private System.Windows.Forms.Label txtFdrlIncmTax;
        private System.Windows.Forms.Label txtProvincialTax;
        private System.Windows.Forms.Label txtTotalDdctn;
        private System.Windows.Forms.Label txtRglrDdctn;
        private System.Windows.Forms.Label txtInsrncDdctn;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblOthrDdctns;
        private System.Windows.Forms.Label lblOvertimeRate;
        private System.Windows.Forms.Label lblOvertimehrs;
        private System.Windows.Forms.Label lblHoursWorded;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.Label lblTaxesNDdctns;
        private System.Windows.Forms.Label txtHourlyWage;
        private System.Windows.Forms.Label txtGrossPay;
        private System.Windows.Forms.Label txtTaxNDdctns;
        private System.Windows.Forms.GroupBox grpBasicPayInfo;
        private System.Windows.Forms.Label txtNetPay;
        private System.Windows.Forms.Label txtEmpId;
        private System.Windows.Forms.NumericUpDown numHrsWorked;
        private System.Windows.Forms.NumericUpDown numOtherDeductions;
        private System.Windows.Forms.NumericUpDown numOvertimeRate;
        private System.Windows.Forms.NumericUpDown numOvertimeHrsWorked;
        private System.Windows.Forms.Button btnUpdatePay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblPayrollStatus;
        private System.Windows.Forms.GroupBox grpBoxStatus;
    }
}