namespace Project1
{
    partial class PayrollPrerequisite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridEmployeeList = new System.Windows.Forms.DataGridView();
            this.clmEmpIdPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpNamePP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePayDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmpSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatePayroll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmployeeList
            // 
            this.gridEmployeeList.AllowUserToAddRows = false;
            this.gridEmployeeList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEmpIdPP,
            this.clmEmpNamePP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEmployeeList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmployeeList.Location = new System.Drawing.Point(12, 62);
            this.gridEmployeeList.MultiSelect = false;
            this.gridEmployeeList.Name = "gridEmployeeList";
            this.gridEmployeeList.ReadOnly = true;
            this.gridEmployeeList.RowHeadersWidth = 51;
            this.gridEmployeeList.RowTemplate.Height = 24;
            this.gridEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployeeList.ShowEditingIcon = false;
            this.gridEmployeeList.ShowRowErrors = false;
            this.gridEmployeeList.Size = new System.Drawing.Size(527, 376);
            this.gridEmployeeList.TabIndex = 0;
            // 
            // clmEmpIdPP
            // 
            this.clmEmpIdPP.HeaderText = "Emp ID";
            this.clmEmpIdPP.MinimumWidth = 6;
            this.clmEmpIdPP.Name = "clmEmpIdPP";
            this.clmEmpIdPP.ReadOnly = true;
            this.clmEmpIdPP.Width = 150;
            // 
            // clmEmpNamePP
            // 
            this.clmEmpNamePP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEmpNamePP.HeaderText = "Employee Name";
            this.clmEmpNamePP.MinimumWidth = 6;
            this.clmEmpNamePP.Name = "clmEmpNamePP";
            this.clmEmpNamePP.ReadOnly = true;
            // 
            // datePayDate
            // 
            this.datePayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePayDate.Location = new System.Drawing.Point(579, 141);
            this.datePayDate.Name = "datePayDate";
            this.datePayDate.Size = new System.Drawing.Size(200, 27);
            this.datePayDate.TabIndex = 1;
            // 
            // lblEmpSelect
            // 
            this.lblEmpSelect.AutoSize = true;
            this.lblEmpSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSelect.Location = new System.Drawing.Point(12, 26);
            this.lblEmpSelect.Name = "lblEmpSelect";
            this.lblEmpSelect.Size = new System.Drawing.Size(290, 20);
            this.lblEmpSelect.TabIndex = 2;
            this.lblEmpSelect.Text = "Select the employee to create payroll:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the payroll date:";
            // 
            // btnCreatePayroll
            // 
            this.btnCreatePayroll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreatePayroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreatePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreatePayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreatePayroll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreatePayroll.Location = new System.Drawing.Point(601, 340);
            this.btnCreatePayroll.Name = "btnCreatePayroll";
            this.btnCreatePayroll.Size = new System.Drawing.Size(150, 35);
            this.btnCreatePayroll.TabIndex = 5;
            this.btnCreatePayroll.Text = "Create &Payroll";
            this.btnCreatePayroll.UseVisualStyleBackColor = false;
            this.btnCreatePayroll.Click += new System.EventHandler(this.BtnCreatePayroll_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(601, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // PayrollPrerequisite
            // 
            this.AcceptButton = this.btnCreatePayroll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreatePayroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpSelect);
            this.Controls.Add(this.datePayDate);
            this.Controls.Add(this.gridEmployeeList);
            this.Name = "PayrollPrerequisite";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PayrollPrerequisite";
            this.Load += new System.EventHandler(this.PayrollPrerequisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployeeList;
        private System.Windows.Forms.DateTimePicker datePayDate;
        private System.Windows.Forms.Label lblEmpSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpIdPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpNamePP;
        private System.Windows.Forms.Button btnCreatePayroll;
        private System.Windows.Forms.Button btnClose;
    }
}