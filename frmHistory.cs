using NCFitnesss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCFitness
{
    public partial class frmHistory : Form
    {
        int userId;
        public frmHistory(int uid)
        {
            InitializeComponent();
            this.userId = uid;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            FitnessClass fc = new FitnessClass();

            double goalCalorie = fc.GetGoalCalorie(this.userId);
            lblGoal.Text = "Goal Calorie = " + fc.GetGoalCalorie(this.userId).ToString();

            double totalCalorie = fc.GetTotalCalorie(this.userId);
            lblTotalCalorie.Text = "Total Calorie = " + totalCalorie.ToString("F2");

            double remain = goalCalorie - totalCalorie;
            if (remain <= 0)
            {
                lblStatus.Text = "Status: " + "Your goal reached! Congratulations!";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Status: " + remain.ToString("F2") + " calories remaining.";
                lblStatus.ForeColor = Color.Orange;
            }

            dataGridView1.DataSource = fc.ShowUserActvities(this.userId);
        }
    }
}
