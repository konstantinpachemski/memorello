using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28ProektnaFormsMemorello.Login
{
    public partial class CreateLoginForm : Form
    {
        public User user;
        public CreateLoginForm()
        {
            InitializeComponent();
        }
        
        private void UsernameBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = usernameValidate(usernameBox.Text.Trim());
        }
        bool usernameValidate(string username)
        {
            if (username.Length == 0)
            {
                errorProvider1.SetError(usernameBox, "You must enter username.");
                return true;
            }
            else if (username.Length > 1 && username.Length <= 3)
            {
                errorProvider1.SetError(usernameBox, "Username must be greater then 3 characters.");
                return true;
            }
            else
            {
                errorProvider1.SetError(usernameBox, null);
                return false;
            }
        }

        private void PasswordBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = passwordValidate(passwordBox.Text.Trim());
        }
        bool passwordValidate(string password)
        {
            if (password.Length == 0)
            {
                errorProvider1.SetError(passwordBox, "You must enter password.");
                return true;
            }
            else if (password.Length >= 1 && password.Length <= 6)
            {
                errorProvider1.SetError(passwordBox, "Password must be greater then 6 characters.");
                return true;
            }
            else
            {
                errorProvider1.SetError(passwordBox, null);
                return false;
            }
        }

        private void ConfirmPasswordBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = cPasswordValidate(confirmPasswordBox.Text.Trim());
        }
        bool cPasswordValidate(string cpassword)
        {
            if (cpassword.Length == 0)
            {
                errorProvider1.SetError(confirmPasswordBox, "You must enter password.");
                return true;
            }
            else if (cpassword.Length >= 1 && cpassword.Length <= 6)
            {
                errorProvider1.SetError(confirmPasswordBox, "Password must be greater then 6 characters.");
                return true;
            }
            else if (passwordBox.Text.Trim() != confirmPasswordBox.Text.Trim())
            {
                errorProvider1.SetError(confirmPasswordBox, "Passwords don't match");
                return true;
            }
            else
            {
                errorProvider1.SetError(confirmPasswordBox, null);
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if ((!usernameValidate(usernameBox.Text.Trim())) && (!passwordValidate(passwordBox.Text.Trim())) && (!cPasswordValidate(confirmPasswordBox.Text.Trim())))
            {
                user = new User(usernameBox.Text.Trim(), passwordBox.Text.Trim());
                DialogResult = DialogResult.OK;
            }
        }

        private void CreateLoginForm_Load(object sender, EventArgs e)
        {
        }
       
        }
    }