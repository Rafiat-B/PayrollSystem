using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project1
{
    public partial class LoginRegistrationForm : Form
    {
        public static readonly UsersDB usersDB = new UsersDB();
        public LoginRegistrationForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            //setting min DOB to prevent employees under the age of 18
            dateDob.MaxDate = today.AddYears(-18);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Name validation using regex
            bool validData = true;
            Regex nameRegex = new Regex(@"^[\w ]*$");
            if (!nameRegex.IsMatch(txtName.Text) || String.IsNullOrEmpty(txtName.Text))
            {
                errProvider.SetError(txtName, "Name must contain only Letters or numbers");
                validData = false;
            }
            else
            {
                //clear name error
                errProvider.SetError(txtName, String.Empty);
            }
            // User Id validation
            Regex userIdRegex = new Regex(@"^n_[\d]{6,7}$");
            if (!userIdRegex.IsMatch(txtUserId.Text) || String.IsNullOrEmpty(txtUserId.Text))
            {
                errProvider.SetError(txtUserId, "UserId must contain only Letters or numbers");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtUserId, String.Empty);
            }
            // Password validation
            Regex passwordValidation = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$");
            if (!passwordValidation.IsMatch(txtPassword.Text))
            {
                errProvider.SetError(txtPassword, "Password must contain 1 Capital letter, 1 small letter, 1 number, 1 special character and between 6 to 15 character long");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtPassword, String.Empty);
            }
            // Repassword is same as password check 
            if (!txtPassword.Text.Equals(txtRePassword.Text))
            {
                errProvider.SetError(txtRePassword, "Re-entered Password does not match");
                validData = false;
            }
            // phone validation 
            Regex phoneRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (!phoneRegex.IsMatch(txtPhone.Text) || String.IsNullOrEmpty(txtPhone.Text))
            {
                errProvider.SetError(txtPhone, "Please enter a valid phone number");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtPhone, String.Empty);
            }
            //email validation
            if (!IsValidEmail(txtEmail.Text))
            {
                errProvider.SetError(txtEmail, "Please enter a valid email");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtEmail, String.Empty);
            }
            if (!validData)
            {
                return;
            }
            //Add user to the userDB
            long empId = long.Parse(txtEmpId.Text);
            if(usersDB.AddUser(new User(txtUserId.Text, empId, txtName.Text, txtPassword.Text, txtEmail.Text, txtPhone.Text, dateDob.Value, txtAddress.Text, false)))
            {
                DialogResult d = MessageBox.Show($"User Account {txtUserId.Text} created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                //Error message for user creation
                MessageBox.Show("Unable to create User Account, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        bool IsValidEmail(string email)
        {
            //Email validatin using system net mail
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void TxtRePassword_TextChanged(object sender, EventArgs e)
        {
            // Validation of repassword on text changed 
            if (!txtPassword.Text.Equals(txtRePassword.Text))
            {
                errProvider.SetError(txtRePassword, "Re-entered Password does not match");
                return;
            }
            else
            {
                errProvider.SetError(txtRePassword, String.Empty);
                return;
            }
        }

        private void TxtEmpId_Leave(object sender, EventArgs e)
        {
            //Validation on leaving emp id to check if employee exists on employee id
            if (long.TryParse(txtEmpId.Text, out long Empid) && Empid >= Employee.EMPMINID && Empid <= Employee.EMPMAXID)
            {
                if(!EmployeeDB.ContainsEmployee(Empid))
                {
                    errProvider.SetError(txtEmpId, "EmpId does not exist");
                    return;
                }
                else
                {
                    errProvider.SetError(txtEmpId, String.Empty);
                }
                if (!usersDB.UserAccExistsForEmp(Empid))
                {
                    txtUserId.Text = "n_" + Empid.ToString();
                    errProvider.SetError(txtEmpId, String.Empty);
                    return;
                }
                else
                {
                    MessageBox.Show("User Account already exists for this Employee ID, Please contact support to get your User Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            errProvider.SetError(txtEmpId, "EmpId must contains only numbers");
            return;
        }
    }
}
