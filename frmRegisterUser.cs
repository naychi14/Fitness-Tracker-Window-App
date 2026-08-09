using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NCFitnesss
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserClass user=new UserClass();

            // Input Validation

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtGoalCalorie.Text))
            {
                MessageBox.Show("Please enter all required data", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Username validation: only letters and numbers
            Regex usernameRegex = new Regex("^[a-zA-Z0-9]+$");
            if (!usernameRegex.IsMatch(txtUserName.Text))
            {
                MessageBox.Show("Username can only contain letters (A-Z, a-z) and numbers (0-9).",
                    "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Password validation: exactly 12 characters with at least one uppercase and one lowercase
            if (txtPassword.Text.Length != 12)
            {
                MessageBox.Show("Password must be exactly 12 characters long.",
                    "Invalid Password Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Regex hasUpperCase = new Regex("[A-Z]");
            Regex hasLowerCase = new Regex("[a-z]");

            if (!hasUpperCase.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password must contain at least ONE (1) uppercase letter.",
                    "Password Requirement Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!hasLowerCase.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password must contain at least ONE (1) lowercase letter.",
                    "Password Requirement Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            user.Uname = txtUserName.Text.Trim();
            user.Upassword = txtPassword.Text;


            // Goal calorie validation
            try
            {
                double goalCal = double.Parse(txtGoalCalorie.Text);

                // Check if positive number
                if (goalCal <= 0)
                {
                    MessageBox.Show("Goal calorie must be a positive number.",
                        "Invalid Goal Calorie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Boundary check - must be between 300 and 10000 calories
                if (goalCal < 300 || goalCal > 10000)
                {
                    MessageBox.Show("Goal calorie must be between 300 and 10000 calories for safety.",
                        "Invalid Calorie Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                user.GoalCal = goalCal;
            }
            catch (FormatException)
            {
                MessageBox.Show("Goal calorie must be a valid numeric value.",
                    "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing goal calorie: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check for existing user
            if (user.CheckExisitingUser(user.Uname) != 0)
            {
                MessageBox.Show("Username already exists. Please choose a different username.",
                    "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt registration
            int uid = user.Registration();
            if (uid != 0)
            {
                MessageBox.Show($"Registration successful! Your user ID is: {uid}",
                    "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form after successful registration
                ClearForm();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.",
                    "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtGoalCalorie.Text = "";
            chkPassword.Checked = false;
            txtUserName.Focus();
        }


        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPassword.Checked)
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
            this.Close();
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            // Set initial password character
            txtPassword.PasswordChar = '*';
        }



        // Real-time validation feedback

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            ValidateUsernameInRealTime();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswordInRealTime();
        }

        private void txtGoalCalorie_TextChanged(object sender, EventArgs e)
        {
            ValidateGoalCalorieInRealTime();
        }


        private void ValidateUsernameInRealTime()
        {
            Regex usernameRegex = new Regex("^[a-zA-Z0-9]*$");
            if (!usernameRegex.IsMatch(txtUserName.Text))
            {
                // Change text color 
                txtUserName.ForeColor = Color.Red;
            }
            else
            {
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void ValidatePasswordInRealTime()
        {
            if (txtPassword.Text.Length > 0)
            {
                Regex hasUpperCase = new Regex("[A-Z]");
                Regex hasLowerCase = new Regex("[a-z]");

                bool hasUpper = hasUpperCase.IsMatch(txtPassword.Text);
                bool hasLower = hasLowerCase.IsMatch(txtPassword.Text);
                bool correctLength = txtPassword.Text.Length == 12;

                // Visual feedback
                if (correctLength && hasUpper && hasLower)
                {
                    txtPassword.ForeColor = Color.Green;
                }
                else
                {
                    txtPassword.ForeColor = Color.DarkGoldenrod;
                }
            }
            else
            {
                txtPassword.ForeColor = Color.Black;
            }
        }


        private void ValidateGoalCalorieInRealTime()
        {
            if (double.TryParse(txtGoalCalorie.Text, out double goalCal))
            {
                if (goalCal >= 300 && goalCal <= 10000)
                {
                    txtGoalCalorie.ForeColor = Color.Green;    // Good range
                }
                else
                {
                    txtGoalCalorie.ForeColor = Color.Orange;      // Invalid range
                }
            }
            else
            {
                txtGoalCalorie.ForeColor = Color.Red;        // invalid format
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserLogin login = new frmUserLogin();
            login.ShowDialog();
        }
    }
}
