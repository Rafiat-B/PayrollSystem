using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class LoginForm : Form
    {
        public static readonly UsersDB usersDB = new UsersDB();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // show registration form
            Form registerForm = new LoginRegistrationForm();
            registerForm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // exit forms and confirmation of exit
            DialogResult d = MessageBox.Show("Do you want to exit?", "Exit Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // show home page based on if the user is admin user or not
            User currentUser = usersDB.GetUser(txtBxUserId.Text);
            if (currentUser != null && currentUser.Password.Equals(txtBoxPassword.Text))
            {
                ClearFields();
                //Admin home form
                if (currentUser.IsAdmin)
                {
                    AdminHomeForm adminHomeForm = new AdminHomeForm();
                    this.Hide();
                    DialogResult d = adminHomeForm.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        this.Show();
                        return;
                    }
                    this.Close();
                    return;
                }
                else
                {
                    //Employee home form
                    EmployeeForm employeeForm = new EmployeeForm(currentUser.EmpId);
                    this.Hide();
                    DialogResult d = employeeForm.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        this.Show();
                        return;
                    }
                    this.Close();
                    return;
                }
            }
            // login error message
            MessageBox.Show("Invalid username or password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearFields();

        }

        private void ClearFields()
        {
            txtBxUserId.Text = string.Empty;
            txtBoxPassword.Text = string.Empty;
        }
    }
}
