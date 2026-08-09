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
    public partial class frmUpdateUser : Form
    {
        int uid;
        string userName;
        public frmUpdateUser(int uid, string uname)
        {
            InitializeComponent();
            this.uid = uid;
            this.userName = uname;
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            lblUserID.Text = "Welcome back, " + userName + "! You can change info here.";
            // Set initial password character
            txtPassword.PasswordChar = '*';
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtGoalCalorie.Text))
            {
                MessageBox.Show("Please enter all required data", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // Goal calorie validation
            double goalCal;
            try
            {
                goalCal = double.Parse(txtGoalCalorie.Text);

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

            // If all validations pass, proceed with update
            UserClass user = new UserClass();
            bool status = user.UpdateUser(uid, txtPassword.Text, goalCal);
            if (status)
            {
                MessageBox.Show("User information updated successfully!",
                    "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.",
                    "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtPassword.Text = "";
            txtGoalCalorie.Text = "";
            chkPassword.Checked = false;
            txtPassword.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //  real-time validation feedback 
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswordInRealTime();
        }

        private void txtGoalCalorie_TextChanged(object sender, EventArgs e)
        {
            ValidateGoalCalorieInRealTime();
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
                    txtGoalCalorie.ForeColor = Color.Orange;   // Invalid range
                }
            }
            else
            {
                txtGoalCalorie.ForeColor = Color.Red;          // Invalid format
            }
        }

        
    }
}
