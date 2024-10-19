namespace Project1
{
    partial class AdminHomeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.payrollsTab = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDeletePayroll = new System.Windows.Forms.Button();
            this.btnCreatePayroll = new System.Windows.Forms.Button();
            this.btnPayrollSearch = new System.Windows.Forms.Button();
            this.txtPayrollSearch = new System.Windows.Forms.TextBox();
            this.btnPayrollDetails = new System.Windows.Forms.Button();
            this.gridPayrollTable = new System.Windows.Forms.DataGridView();
            this.clmPayRollId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatePT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmployeePT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpNamePT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoursPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRatePT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOvertimePT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOvertimeRatePT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPayPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.txtEmployeeSearch = new System.Windows.Forms.TextBox();
            this.gridEmpTable = new System.Windows.Forms.DataGridView();
            this.clmEmpIdET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpNameET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPayRateET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmailET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDojET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOutEmp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.payrollsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayrollTable)).BeginInit();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.payrollsTab);
            this.tabControl1.Controls.Add(this.employeeTab);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 608);
            this.tabControl1.TabIndex = 0;
            // 
            // payrollsTab
            // 
            this.payrollsTab.BackColor = System.Drawing.Color.White;
            this.payrollsTab.Controls.Add(this.btnLogOut);
            this.payrollsTab.Controls.Add(this.btnDeletePayroll);
            this.payrollsTab.Controls.Add(this.btnCreatePayroll);
            this.payrollsTab.Controls.Add(this.btnPayrollSearch);
            this.payrollsTab.Controls.Add(this.txtPayrollSearch);
            this.payrollsTab.Controls.Add(this.btnPayrollDetails);
            this.payrollsTab.Controls.Add(this.gridPayrollTable);
            this.payrollsTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.payrollsTab.Location = new System.Drawing.Point(4, 29);
            this.payrollsTab.Margin = new System.Windows.Forms.Padding(4);
            this.payrollsTab.Name = "payrollsTab";
            this.payrollsTab.Padding = new System.Windows.Forms.Padding(4);
            this.payrollsTab.Size = new System.Drawing.Size(1022, 575);
            this.payrollsTab.TabIndex = 0;
            this.payrollsTab.Text = "Payrolls";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Location = new System.Drawing.Point(7, 531);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(116, 37);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnDeletePayroll
            // 
            this.btnDeletePayroll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletePayroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeletePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePayroll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletePayroll.Location = new System.Drawing.Point(692, 533);
            this.btnDeletePayroll.Name = "btnDeletePayroll";
            this.btnDeletePayroll.Size = new System.Drawing.Size(150, 35);
            this.btnDeletePayroll.TabIndex = 5;
            this.btnDeletePayroll.Text = "Delete Payroll";
            this.btnDeletePayroll.UseVisualStyleBackColor = false;
            this.btnDeletePayroll.Click += new System.EventHandler(this.BtnDeletePayroll_Click);
            // 
            // btnCreatePayroll
            // 
            this.btnCreatePayroll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreatePayroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreatePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreatePayroll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreatePayroll.Location = new System.Drawing.Point(865, 533);
            this.btnCreatePayroll.Name = "btnCreatePayroll";
            this.btnCreatePayroll.Size = new System.Drawing.Size(150, 35);
            this.btnCreatePayroll.TabIndex = 4;
            this.btnCreatePayroll.Text = "Create Payroll";
            this.btnCreatePayroll.UseVisualStyleBackColor = false;
            this.btnCreatePayroll.Click += new System.EventHandler(this.BtnCreatePayroll_Click);
            // 
            // btnPayrollSearch
            // 
            this.btnPayrollSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayrollSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayrollSearch.Location = new System.Drawing.Point(254, 7);
            this.btnPayrollSearch.Name = "btnPayrollSearch";
            this.btnPayrollSearch.Size = new System.Drawing.Size(80, 26);
            this.btnPayrollSearch.TabIndex = 3;
            this.btnPayrollSearch.Text = "Search";
            this.btnPayrollSearch.UseVisualStyleBackColor = false;
            this.btnPayrollSearch.Click += new System.EventHandler(this.BtnPayrollSearch_Click);
            // 
            // txtPayrollSearch
            // 
            this.txtPayrollSearch.Location = new System.Drawing.Point(7, 7);
            this.txtPayrollSearch.Name = "txtPayrollSearch";
            this.txtPayrollSearch.Size = new System.Drawing.Size(241, 26);
            this.txtPayrollSearch.TabIndex = 2;
            // 
            // btnPayrollDetails
            // 
            this.btnPayrollDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayrollDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPayrollDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayrollDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayrollDetails.Location = new System.Drawing.Point(545, 533);
            this.btnPayrollDetails.Name = "btnPayrollDetails";
            this.btnPayrollDetails.Size = new System.Drawing.Size(120, 35);
            this.btnPayrollDetails.TabIndex = 1;
            this.btnPayrollDetails.Text = "Show Details";
            this.btnPayrollDetails.UseVisualStyleBackColor = false;
            this.btnPayrollDetails.Click += new System.EventHandler(this.BtnPayrollDetails_Click);
            // 
            // gridPayrollTable
            // 
            this.gridPayrollTable.AllowUserToAddRows = false;
            this.gridPayrollTable.AllowUserToDeleteRows = false;
            this.gridPayrollTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPayrollTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPayRollId,
            this.clmDatePT,
            this.clmEmployeePT,
            this.clmEmpNamePT,
            this.clmHoursPT,
            this.clmRatePT,
            this.clmOvertimePT,
            this.clmOvertimeRatePT,
            this.clmTotalPayPT,
            this.clmStatusPT});
            this.gridPayrollTable.Location = new System.Drawing.Point(7, 39);
            this.gridPayrollTable.Name = "gridPayrollTable";
            this.gridPayrollTable.ReadOnly = true;
            this.gridPayrollTable.RowHeadersWidth = 51;
            this.gridPayrollTable.RowTemplate.Height = 24;
            this.gridPayrollTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPayrollTable.ShowEditingIcon = false;
            this.gridPayrollTable.Size = new System.Drawing.Size(1008, 488);
            this.gridPayrollTable.TabIndex = 0;
            this.gridPayrollTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPayrollTable_CellDoubleClick);
            // 
            // clmPayRollId
            // 
            this.clmPayRollId.HeaderText = "Pay Roll Id";
            this.clmPayRollId.MinimumWidth = 6;
            this.clmPayRollId.Name = "clmPayRollId";
            this.clmPayRollId.ReadOnly = true;
            this.clmPayRollId.Visible = false;
            this.clmPayRollId.Width = 125;
            // 
            // clmDatePT
            // 
            this.clmDatePT.HeaderText = "Pay Date";
            this.clmDatePT.MinimumWidth = 6;
            this.clmDatePT.Name = "clmDatePT";
            this.clmDatePT.ReadOnly = true;
            this.clmDatePT.Width = 125;
            // 
            // clmEmployeePT
            // 
            this.clmEmployeePT.HeaderText = "Emp ID";
            this.clmEmployeePT.MinimumWidth = 6;
            this.clmEmployeePT.Name = "clmEmployeePT";
            this.clmEmployeePT.ReadOnly = true;
            this.clmEmployeePT.Width = 125;
            // 
            // clmEmpNamePT
            // 
            this.clmEmpNamePT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEmpNamePT.HeaderText = "Emp Name";
            this.clmEmpNamePT.MinimumWidth = 6;
            this.clmEmpNamePT.Name = "clmEmpNamePT";
            this.clmEmpNamePT.ReadOnly = true;
            // 
            // clmHoursPT
            // 
            this.clmHoursPT.HeaderText = "Hours Worked";
            this.clmHoursPT.MinimumWidth = 6;
            this.clmHoursPT.Name = "clmHoursPT";
            this.clmHoursPT.ReadOnly = true;
            this.clmHoursPT.Width = 75;
            // 
            // clmRatePT
            // 
            this.clmRatePT.HeaderText = "Pay Rate";
            this.clmRatePT.MinimumWidth = 6;
            this.clmRatePT.Name = "clmRatePT";
            this.clmRatePT.ReadOnly = true;
            this.clmRatePT.Width = 60;
            // 
            // clmOvertimePT
            // 
            this.clmOvertimePT.HeaderText = "Overtime Hour";
            this.clmOvertimePT.MinimumWidth = 6;
            this.clmOvertimePT.Name = "clmOvertimePT";
            this.clmOvertimePT.ReadOnly = true;
            this.clmOvertimePT.Width = 80;
            // 
            // clmOvertimeRatePT
            // 
            this.clmOvertimeRatePT.HeaderText = "Overtime Rate";
            this.clmOvertimeRatePT.MinimumWidth = 6;
            this.clmOvertimeRatePT.Name = "clmOvertimeRatePT";
            this.clmOvertimeRatePT.ReadOnly = true;
            this.clmOvertimeRatePT.Width = 80;
            // 
            // clmTotalPayPT
            // 
            this.clmTotalPayPT.HeaderText = "Total Pay";
            this.clmTotalPayPT.MinimumWidth = 6;
            this.clmTotalPayPT.Name = "clmTotalPayPT";
            this.clmTotalPayPT.ReadOnly = true;
            this.clmTotalPayPT.Width = 90;
            // 
            // clmStatusPT
            // 
            this.clmStatusPT.HeaderText = "Status";
            this.clmStatusPT.MinimumWidth = 6;
            this.clmStatusPT.Name = "clmStatusPT";
            this.clmStatusPT.ReadOnly = true;
            this.clmStatusPT.Width = 80;
            // 
            // employeeTab
            // 
            this.employeeTab.BackColor = System.Drawing.Color.White;
            this.employeeTab.Controls.Add(this.btnLogOutEmp);
            this.employeeTab.Controls.Add(this.btnAddEmp);
            this.employeeTab.Controls.Add(this.btnUpdateEmp);
            this.employeeTab.Controls.Add(this.btnEmployeeSearch);
            this.employeeTab.Controls.Add(this.txtEmployeeSearch);
            this.employeeTab.Controls.Add(this.gridEmpTable);
            this.employeeTab.Location = new System.Drawing.Point(4, 29);
            this.employeeTab.Margin = new System.Windows.Forms.Padding(4);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(4);
            this.employeeTab.Size = new System.Drawing.Size(1022, 575);
            this.employeeTab.TabIndex = 1;
            this.employeeTab.Text = "Employees";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEmp.Location = new System.Drawing.Point(865, 533);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(150, 35);
            this.btnAddEmp.TabIndex = 7;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateEmp.Location = new System.Drawing.Point(650, 533);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(200, 35);
            this.btnUpdateEmp.TabIndex = 6;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = false;
            this.btnUpdateEmp.Click += new System.EventHandler(this.BtnUpdateEmp_Click);
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmployeeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeSearch.Location = new System.Drawing.Point(254, 7);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(80, 26);
            this.btnEmployeeSearch.TabIndex = 5;
            this.btnEmployeeSearch.Text = "Search";
            this.btnEmployeeSearch.UseVisualStyleBackColor = false;
            this.btnEmployeeSearch.Click += new System.EventHandler(this.BtnEmployeeSearch_Click);
            // 
            // txtEmployeeSearch
            // 
            this.txtEmployeeSearch.Location = new System.Drawing.Point(7, 7);
            this.txtEmployeeSearch.Name = "txtEmployeeSearch";
            this.txtEmployeeSearch.Size = new System.Drawing.Size(241, 26);
            this.txtEmployeeSearch.TabIndex = 4;
            // 
            // gridEmpTable
            // 
            this.gridEmpTable.AllowUserToAddRows = false;
            this.gridEmpTable.AllowUserToDeleteRows = false;
            this.gridEmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEmpIdET,
            this.clmEmpNameET,
            this.clmPayRateET,
            this.clmPhoneET,
            this.clmEmailET,
            this.clmDojET});
            this.gridEmpTable.Location = new System.Drawing.Point(7, 39);
            this.gridEmpTable.Name = "gridEmpTable";
            this.gridEmpTable.ReadOnly = true;
            this.gridEmpTable.RowHeadersWidth = 51;
            this.gridEmpTable.RowTemplate.Height = 24;
            this.gridEmpTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpTable.Size = new System.Drawing.Size(1008, 488);
            this.gridEmpTable.TabIndex = 0;
            this.gridEmpTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmpTable_CellDoubleClick);
            // 
            // clmEmpIdET
            // 
            this.clmEmpIdET.HeaderText = "Emp ID";
            this.clmEmpIdET.MinimumWidth = 6;
            this.clmEmpIdET.Name = "clmEmpIdET";
            this.clmEmpIdET.ReadOnly = true;
            this.clmEmpIdET.Width = 125;
            // 
            // clmEmpNameET
            // 
            this.clmEmpNameET.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEmpNameET.HeaderText = "Emp Name";
            this.clmEmpNameET.MinimumWidth = 6;
            this.clmEmpNameET.Name = "clmEmpNameET";
            this.clmEmpNameET.ReadOnly = true;
            // 
            // clmPayRateET
            // 
            this.clmPayRateET.HeaderText = "Pay Rate";
            this.clmPayRateET.MinimumWidth = 6;
            this.clmPayRateET.Name = "clmPayRateET";
            this.clmPayRateET.ReadOnly = true;
            this.clmPayRateET.Width = 80;
            // 
            // clmPhoneET
            // 
            this.clmPhoneET.HeaderText = "Phone";
            this.clmPhoneET.MinimumWidth = 6;
            this.clmPhoneET.Name = "clmPhoneET";
            this.clmPhoneET.ReadOnly = true;
            this.clmPhoneET.Width = 125;
            // 
            // clmEmailET
            // 
            this.clmEmailET.HeaderText = "Email";
            this.clmEmailET.MinimumWidth = 6;
            this.clmEmailET.Name = "clmEmailET";
            this.clmEmailET.ReadOnly = true;
            this.clmEmailET.Width = 150;
            // 
            // clmDojET
            // 
            this.clmDojET.HeaderText = "Joining Date";
            this.clmDojET.MinimumWidth = 6;
            this.clmDojET.Name = "clmDojET";
            this.clmDojET.ReadOnly = true;
            this.clmDojET.Width = 125;
            // 
            // btnLogOutEmp
            // 
            this.btnLogOutEmp.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogOutEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOutEmp.Location = new System.Drawing.Point(7, 531);
            this.btnLogOutEmp.Name = "btnLogOutEmp";
            this.btnLogOutEmp.Size = new System.Drawing.Size(116, 37);
            this.btnLogOutEmp.TabIndex = 8;
            this.btnLogOutEmp.Text = "Logout";
            this.btnLogOutEmp.UseVisualStyleBackColor = false;
            this.btnLogOutEmp.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1058, 636);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHomeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Home";
            this.tabControl1.ResumeLayout(false);
            this.payrollsTab.ResumeLayout(false);
            this.payrollsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayrollTable)).EndInit();
            this.employeeTab.ResumeLayout(false);
            this.employeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage payrollsTab;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.DataGridView gridEmpTable;
        private System.Windows.Forms.Button btnPayrollDetails;
        private System.Windows.Forms.TextBox txtPayrollSearch;
        private System.Windows.Forms.Button btnPayrollSearch;
        private System.Windows.Forms.Button btnEmployeeSearch;
        private System.Windows.Forms.TextBox txtEmployeeSearch;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPayRollId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatePT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmployeePT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpNamePT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoursPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRatePT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOvertimePT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOvertimeRatePT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPayPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusPT;
        private System.Windows.Forms.DataGridView gridPayrollTable;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnCreatePayroll;
        private System.Windows.Forms.Button btnDeletePayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpIdET;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpNameET;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPayRateET;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneET;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmailET;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDojET;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLogOutEmp;
    }
}