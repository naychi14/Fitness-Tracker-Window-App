using NCFitness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCFitnesss
{
    public partial class frmUserLogin : Form
    {
        private int _userId;
        private string _userName;
        private int _loginAttempts = 0;
        private const int MAX_LOGIN_ATTEMPTS = 3;


        public frmUserLogin()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set initial state of buttons
            btnUpdate.Enabled = false;
            btnFitness.Enabled = false;
            btnHistory.Enabled = false;

            // Set password character
            txtPassword.PasswordChar = '*';

            // Set focus to username field
            txtUserName.Focus();
        }


        private void btnLogin_Click(object sender, EventArgs e)

        {
            try
            {
                // Check if maximum login attempts exceeded
                if (_loginAttempts >= MAX_LOGIN_ATTEMPTS)
                {
                    MessageBox.Show(
                        "Maximum login attempts exceeded. The application will now close for security reasons.",
                        "Security Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }


                // Validate input fields
                if (!ValidateInput())
                {
                    return;
                }

                UserClass user = new UserClass();
                user.Uname = txtUserName.Text.Trim();
                user.Upassword = txtPassword.Text;

                _userId = user.Login();

                if (_userId > 0)
                {
                    _userName = txtUserName.Text.Trim();


                    // Login successful
                    MessageBox.Show(
                        "Login successful! Welcome to NC Fitness.",
                        "Login Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Enable functionality
                    btnUpdate.Enabled = true;
                    btnFitness.Enabled = true;
                    btnHistory.Enabled = true;

                    _loginAttempts = 0; // Reset attempt counter on successful login

                    // Disable login button to prevent multiple login attempts
                    btnLogin.Enabled = false;
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                }
                else
                {
                    // Login failed
                    _loginAttempts++;
                    int remainingAttempts = MAX_LOGIN_ATTEMPTS - _loginAttempts;

                    string message = "Invalid username or password.";
                    if (remainingAttempts > 0)
                    {
                        message += $"\nRemaining attempts: {remainingAttempts}";
                    }
                    else
                    {
                        message += "\nNo more attempts remaining. Application will close.";
                    }

                    MessageBox.Show(
                        message,
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    // Clear password field and focus on it for retry
                    txtPassword.Clear();
                    txtPassword.Focus();

                    // Exit if no more attempts
                    if (_loginAttempts >= MAX_LOGIN_ATTEMPTS)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred during login: {ex.Message}",
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Validate username - check for empty 
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                ShowValidationError("Please enter your username.", txtUserName);
                return false;
            }

            // Validate password - check for empty 
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowValidationError("Please enter your password.", txtPassword);
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(
                message,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            control.Focus();
            if (control is TextBox textBox)
            {
                textBox.SelectAll();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userId <= 0)
                {
                    MessageBox.Show(
                        "Please login first before updating user information.",
                        "Authentication Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                frmUpdateUser updateForm = new frmUpdateUser(_userId, _userName);
                updateForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error opening update form: {ex.Message}",
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFitness_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userId <= 0)
                {
                    MessageBox.Show(
                        "Please login first to access fitness activities.",
                        "Authentication Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                frmFitnessActivities fitnessForm = new frmFitnessActivities(_userId, _userName);
                fitnessForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error opening fitness activities: {ex.Message}",
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory frmFitness = new frmHistory(this._userId);
            frmFitness.ShowDialog();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit the application?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error closing application: {ex.Message}",
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close(); // Force close even if there's an error
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow enter key to trigger login
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow enter key to trigger login
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterUser reg = new frmRegisterUser();
            reg.ShowDialog();
        }


    }
}
