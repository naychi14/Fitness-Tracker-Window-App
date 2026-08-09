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
    public partial class frmFitnessActivities : Form
    {
        int userId;
        int aid; //activity id 
        string userName;
        
        public frmFitnessActivities(int uid, string uname)
        {
            InitializeComponent();
            this.userId = uid;
            this.userName = uname;
        }
        //Welcome user
        private void frmFitnessActivities_Load(object sender, EventArgs e)
        {
            lblUserId.Text = "Welcome, " + userName + "! Please select an activity.";
            
            FitnessClass fc = new FitnessClass();
            lblGoal.Text = "Goal Calorie = " +fc.GetGoalCalorie(this.userId).ToString();
        }
        // Activity metrics 
        private void rdoWalking_CheckedChanged(object sender, EventArgs e)
        {
            aid = 1;
            var choices = new Dictionary<string, string>();
            choices["2.8"] = "Light= 2.8";
            choices["3.5"] = "Moderate = 3.5";
            choices["5.0"] = "Fast=5.0";
            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";
        }

        private void rdoSwimming_CheckedChanged(object sender, EventArgs e)
        {
            aid = 2;
            var choices = new Dictionary<string, string>();
            choices["6.0"] = "Leisurely swimming = 6.0";
            choices["5.8"] = "moderate effort =5.8";
            choices["9.8"] = "freestyle, fast=9.8";
            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";
        }

        private void rdoCycling_CheckedChanged(object sender, EventArgs e)
        {
            aid = 3;
            var choices = new Dictionary<string, string>();
            choices["4.0"] = "Leisure cycling (<16 km/h) = 4.0";
            choices["6.8"] = "Moderate (16–19 km/h) = 6.8";
            choices["8.0"] = "Vigorous (19–22 km/h) = 8.0";
            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";
        }

        private void rdoHiking_CheckedChanged(object sender, EventArgs e)
        {
            aid = 4;
            var choices = new Dictionary<string, string>();
            choices["6.0"] = "Hiking on flat terrain = 6.0";
            choices["7.3"] = "Hiking uphill (light pack) = 7.3";
            choices["9.0"] = "Hiking uphill (heavy pack) = 9.0";
            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";
        }

        private void rdoRunning_CheckedChanged(object sender, EventArgs e)
        {
            aid = 5;
            var choices = new Dictionary<string, string>();
            choices["8.0"] = "Slow Running (8 km/h) = 8.0";
            choices["11.5"] = "Running (10 km/h) = 11.5";
            choices["16.0"] = "Running Fast (16 km/h) = 16.0";
            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";
        }

        private void rdoSkipping_CheckedChanged(object sender, EventArgs e)
        {
            aid = 6;
            var choices = new Dictionary<string, string>();
            choices["8.8"] = "Slow pace = 8.8";
            choices["11.8"] = "Moderate pace = 11.8";
            choices["12.3"] = "Fast pace = 12.3";
            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";
        }

        private bool ValidateInputs()
        {
            // Check if activity is selected
            if (aid == 0)
            {
                MessageBox.Show("Please select an activity first.", "Activity Required",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Validate weight input
            if (string.IsNullOrWhiteSpace(txtMetric1.Text))
            {
                MessageBox.Show("Please enter your weight in kilograms.", "Weight Required",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetric1.Focus();
                return false;
            }

            if (!float.TryParse(txtMetric1.Text, out float weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for weight (kg).", "Invalid Weight",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetric1.Focus();
                txtMetric1.SelectAll();
                return false;
            }

            if (weight < 30 || weight > 300) // Valid range: 30 - 300 kg
            {
                MessageBox.Show("Weight must be between 30 and 300 kg. Please enter a valid weight.", "Invalid Weight",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetric1.Focus();
                txtMetric1.SelectAll();
                return false;
            }


            // Validate time input
            if (string.IsNullOrWhiteSpace(txtMetric2.Text))
            {
                MessageBox.Show("Please enter the exercise duration in minutes.", "Time Required",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetric2.Focus();
                return false;
            }

            if (!float.TryParse(txtMetric2.Text, out float time) || time <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for exercise duration (minutes).", "Invalid Time",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetric2.Focus();
                txtMetric2.SelectAll();
                return false;
            }

            if (time > 720) // 12 hours in minutes
            {
                MessageBox.Show("Exercise duration cannot exceed 720 minutes (12 hours).", "Invalid Time",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetric2.Focus();
                txtMetric2.SelectAll();
                return false;
            }


            // Validate MET selection
            if (cboMetric3.SelectedItem == null)
            {
                MessageBox.Show("Please select an intensity level from the dropdown.", "Intensity Level Required",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMetric3.Focus();
                return false;
            }

            return true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all inputs before proceeding
                if (!ValidateInputs())
                {
                    return; // Exit if validation fails
                }

                // Parse validated inputs
                float weight = float.Parse(txtMetric1.Text);
                float time = float.Parse(txtMetric2.Text);
                float MET = float.Parse(cboMetric3.SelectedValue.ToString());

                // Calculate calorie
                float toDaycalorie = (time / 60) * weight * MET;
                lblTodayCalorie.Text = "Current Activity Calorie Burnt =" + toDaycalorie.ToString("F2");

                FitnessClass fc = new FitnessClass();
                fc.InsertMetric(this.userId, aid, toDaycalorie, DateTime.Now);

                double totalCalorie = fc.GetTotalCalorie(this.userId);
                lblTotalCalorie.Text = "Total Calorie = " + totalCalorie.ToString("F2");

                double goalCalorie = fc.GetGoalCalorie(this.userId);

                double remain = goalCalorie - totalCalorie;
                if (remain <= 0)
                {
                    lblStatus.Text = "Status: " + "Your goal reached! Congratulations!";
                }
                else
                {
                    lblStatus.Text = "Status: " + remain.ToString("F2") + " calories remaining.";
                }

                UpdateCalorieProgress(goalCalorie, totalCalorie);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCalorieProgress(double goalCalories, double totalCalories)
        {
            if (goalCalories <= 0)
            {
                progressBar1.Value = 0;
                return;
            }

            // Calculate progress percentage
            int progress = (int)Math.Round(totalCalories / goalCalories * 100);
            progress = Math.Min(progress, 100); // Cap at 100%

            // Update ProgressBar
            progressBar1.Value = progress;

            // Update status label with color coding
            if (progress >= 100)
            {
                lblProgressStatus.Text = "Goal Achieved! 🎉";
                lblProgressStatus.ForeColor = Color.Green;
            }
            else if (progress >= 75)
            {
                lblProgressStatus.Text = "Almost There! 💪";
                lblProgressStatus.ForeColor = Color.Orange;
            }
            else
            {
                lblProgressStatus.Text = "Keep Going! 🔥";
                lblProgressStatus.ForeColor = Color.Red;
            }
        }



        // Add input validation for text boxes to prevent non-numeric input
        private void txtMetric1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers, decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMetric2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers, decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory frmFitness = new frmHistory(this.userId);
            frmFitness.ShowDialog();
        }
    }
}