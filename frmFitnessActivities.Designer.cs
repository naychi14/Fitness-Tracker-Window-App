namespace NCFitnesss
{
    partial class frmFitnessActivities
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.rdoSwimming = new System.Windows.Forms.RadioButton();
            this.rdoWalking = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.cboMetric3 = new System.Windows.Forms.ComboBox();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.lblTodayCalorie = new System.Windows.Forms.Label();
            this.lblTotalCalorie = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblGoal = new System.Windows.Forms.Label();
            this.rdoCycling = new System.Windows.Forms.RadioButton();
            this.rdoHiking = new System.Windows.Forms.RadioButton();
            this.rdoRunning = new System.Windows.Forms.RadioButton();
            this.rdoSkipping = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUserId.Location = new System.Drawing.Point(91, 51);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(92, 21);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Welcome, ";
            // 
            // rdoSwimming
            // 
            this.rdoSwimming.AutoSize = true;
            this.rdoSwimming.Location = new System.Drawing.Point(187, 113);
            this.rdoSwimming.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoSwimming.Name = "rdoSwimming";
            this.rdoSwimming.Size = new System.Drawing.Size(116, 25);
            this.rdoSwimming.TabIndex = 1;
            this.rdoSwimming.TabStop = true;
            this.rdoSwimming.Text = "Swimming";
            this.rdoSwimming.UseVisualStyleBackColor = true;
            this.rdoSwimming.CheckedChanged += new System.EventHandler(this.rdoSwimming_CheckedChanged);
            // 
            // rdoWalking
            // 
            this.rdoWalking.AutoSize = true;
            this.rdoWalking.Location = new System.Drawing.Point(44, 113);
            this.rdoWalking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoWalking.Name = "rdoWalking";
            this.rdoWalking.Size = new System.Drawing.Size(98, 25);
            this.rdoWalking.TabIndex = 0;
            this.rdoWalking.TabStop = true;
            this.rdoWalking.Text = "Walking";
            this.rdoWalking.UseVisualStyleBackColor = true;
            this.rdoWalking.CheckedChanged += new System.EventHandler(this.rdoWalking_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMetric3);
            this.groupBox2.Controls.Add(this.txtMetric2);
            this.groupBox2.Controls.Add(this.cboMetric3);
            this.groupBox2.Controls.Add(this.lblMetric2);
            this.groupBox2.Controls.Add(this.lblMetric1);
            this.groupBox2.Controls.Add(this.txtMetric1);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(506, 236);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Metric values";
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric3.Location = new System.Drawing.Point(12, 190);
            this.lblMetric3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(42, 20);
            this.lblMetric3.TabIndex = 5;
            this.lblMetric3.Text = "MET";
            // 
            // txtMetric2
            // 
            this.txtMetric2.Location = new System.Drawing.Point(171, 119);
            this.txtMetric2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(195, 31);
            this.txtMetric2.TabIndex = 4;
            this.txtMetric2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetric2_KeyPress);
            // 
            // cboMetric3
            // 
            this.cboMetric3.FormattingEnabled = true;
            this.cboMetric3.Location = new System.Drawing.Point(171, 186);
            this.cboMetric3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMetric3.Name = "cboMetric3";
            this.cboMetric3.Size = new System.Drawing.Size(195, 29);
            this.cboMetric3.TabIndex = 3;
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric2.Location = new System.Drawing.Point(12, 119);
            this.lblMetric2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(115, 20);
            this.lblMetric2.TabIndex = 2;
            this.lblMetric2.Text = "Time (minute)";
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric1.Location = new System.Drawing.Point(11, 49);
            this.lblMetric1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(97, 20);
            this.lblMetric1.TabIndex = 1;
            this.lblMetric1.Text = "Weight (kg)";
            // 
            // txtMetric1
            // 
            this.txtMetric1.Location = new System.Drawing.Point(171, 49);
            this.txtMetric1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(195, 31);
            this.txtMetric1.TabIndex = 0;
            this.txtMetric1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetric1_KeyPress);
            // 
            // lblTodayCalorie
            // 
            this.lblTodayCalorie.AutoSize = true;
            this.lblTodayCalorie.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayCalorie.Location = new System.Drawing.Point(587, 228);
            this.lblTodayCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayCalorie.Name = "lblTodayCalorie";
            this.lblTodayCalorie.Size = new System.Drawing.Size(254, 21);
            this.lblTodayCalorie.TabIndex = 3;
            this.lblTodayCalorie.Text = "Current Activity Calorie Burnt =";
            // 
            // lblTotalCalorie
            // 
            this.lblTotalCalorie.AutoSize = true;
            this.lblTotalCalorie.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalorie.Location = new System.Drawing.Point(587, 276);
            this.lblTotalCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCalorie.Name = "lblTotalCalorie";
            this.lblTotalCalorie.Size = new System.Drawing.Size(180, 21);
            this.lblTotalCalorie.TabIndex = 4;
            this.lblTotalCalorie.Text = "Total Calories Burnt =";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(587, 323);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 21);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.MistyRose;
            this.btnCalculate.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(34, 446);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 60);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(691, 55);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(131, 21);
            this.lblGoal.TabIndex = 7;
            this.lblGoal.Text = "Goal Calorie =";
            // 
            // rdoCycling
            // 
            this.rdoCycling.AutoSize = true;
            this.rdoCycling.Location = new System.Drawing.Point(357, 113);
            this.rdoCycling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoCycling.Name = "rdoCycling";
            this.rdoCycling.Size = new System.Drawing.Size(94, 25);
            this.rdoCycling.TabIndex = 8;
            this.rdoCycling.TabStop = true;
            this.rdoCycling.Text = "Cycling ";
            this.rdoCycling.UseVisualStyleBackColor = true;
            this.rdoCycling.CheckedChanged += new System.EventHandler(this.rdoCycling_CheckedChanged);
            // 
            // rdoHiking
            // 
            this.rdoHiking.AutoSize = true;
            this.rdoHiking.Location = new System.Drawing.Point(515, 113);
            this.rdoHiking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoHiking.Name = "rdoHiking";
            this.rdoHiking.Size = new System.Drawing.Size(86, 25);
            this.rdoHiking.TabIndex = 9;
            this.rdoHiking.TabStop = true;
            this.rdoHiking.Text = "Hiking";
            this.rdoHiking.UseVisualStyleBackColor = true;
            this.rdoHiking.CheckedChanged += new System.EventHandler(this.rdoHiking_CheckedChanged);
            // 
            // rdoRunning
            // 
            this.rdoRunning.AutoSize = true;
            this.rdoRunning.Location = new System.Drawing.Point(656, 113);
            this.rdoRunning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoRunning.Name = "rdoRunning";
            this.rdoRunning.Size = new System.Drawing.Size(102, 25);
            this.rdoRunning.TabIndex = 10;
            this.rdoRunning.TabStop = true;
            this.rdoRunning.Text = "Running";
            this.rdoRunning.UseVisualStyleBackColor = true;
            this.rdoRunning.CheckedChanged += new System.EventHandler(this.rdoRunning_CheckedChanged);
            // 
            // rdoSkipping
            // 
            this.rdoSkipping.AutoSize = true;
            this.rdoSkipping.Location = new System.Drawing.Point(814, 113);
            this.rdoSkipping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoSkipping.Name = "rdoSkipping";
            this.rdoSkipping.Size = new System.Drawing.Size(101, 25);
            this.rdoSkipping.TabIndex = 11;
            this.rdoSkipping.TabStop = true;
            this.rdoSkipping.Text = "Skipping";
            this.rdoSkipping.UseVisualStyleBackColor = true;
            this.rdoSkipping.CheckedChanged += new System.EventHandler(this.rdoSkipping_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(914, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 69);
            this.label1.TabIndex = 12;
            this.label1.Text = "🏃";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "⭐✨";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "🌟";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MistyRose;
            this.progressBar1.ForeColor = System.Drawing.Color.Gold;
            this.progressBar1.Location = new System.Drawing.Point(591, 383);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // lblProgressStatus
            // 
            this.lblProgressStatus.AutoSize = true;
            this.lblProgressStatus.Location = new System.Drawing.Point(680, 431);
            this.lblProgressStatus.Name = "lblProgressStatus";
            this.lblProgressStatus.Size = new System.Drawing.Size(0, 21);
            this.lblProgressStatus.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(652, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "📌";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NCFitness.Properties.Resources.NCFitnees_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(935, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.MistyRose;
            this.btnHistory.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(670, 466);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(144, 50);
            this.btnHistory.TabIndex = 20;
            this.btnHistory.Text = "View History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // frmFitnessActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1021, 566);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProgressStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoSkipping);
            this.Controls.Add(this.rdoRunning);
            this.Controls.Add(this.rdoHiking);
            this.Controls.Add(this.rdoCycling);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdoSwimming);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rdoWalking);
            this.Controls.Add(this.lblTotalCalorie);
            this.Controls.Add(this.lblTodayCalorie);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblUserId);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmFitnessActivities";
            this.Text = "Fitness Activities";
            this.Load += new System.EventHandler(this.frmFitnessActivities_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.RadioButton rdoSwimming;
        private System.Windows.Forms.RadioButton rdoWalking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.ComboBox cboMetric3;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.Label lblTodayCalorie;
        private System.Windows.Forms.Label lblTotalCalorie;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.RadioButton rdoCycling;
        private System.Windows.Forms.RadioButton rdoHiking;
        private System.Windows.Forms.RadioButton rdoRunning;
        private System.Windows.Forms.RadioButton rdoSkipping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHistory;
    }
}