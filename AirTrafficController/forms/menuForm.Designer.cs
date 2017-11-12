namespace AirTrafficController.forms
{
    partial class menuForm
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
            this.button_newAirplane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_tests = new System.Windows.Forms.Button();
            this.button_switchGameRunning = new System.Windows.Forms.Button();
            this.button_editAirplanes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_runningStatus = new System.Windows.Forms.Label();
            this.button_airplaneController = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_newAirplane
            // 
            this.button_newAirplane.Location = new System.Drawing.Point(12, 84);
            this.button_newAirplane.Name = "button_newAirplane";
            this.button_newAirplane.Size = new System.Drawing.Size(277, 50);
            this.button_newAirplane.TabIndex = 0;
            this.button_newAirplane.Text = "Add a new airplane";
            this.button_newAirplane.UseVisualStyleBackColor = true;
            this.button_newAirplane.Click += new System.EventHandler(this.button_newAirplane_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "AirTrafficController Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_tests
            // 
            this.button_tests.Location = new System.Drawing.Point(12, 140);
            this.button_tests.Name = "button_tests";
            this.button_tests.Size = new System.Drawing.Size(277, 50);
            this.button_tests.TabIndex = 2;
            this.button_tests.Text = "TESTS";
            this.button_tests.UseVisualStyleBackColor = true;
            this.button_tests.Click += new System.EventHandler(this.button_tests_Click);
            // 
            // button_switchGameRunning
            // 
            this.button_switchGameRunning.Location = new System.Drawing.Point(570, 84);
            this.button_switchGameRunning.Name = "button_switchGameRunning";
            this.button_switchGameRunning.Size = new System.Drawing.Size(124, 50);
            this.button_switchGameRunning.TabIndex = 3;
            this.button_switchGameRunning.Text = "Turn On/Off airplanes update";
            this.button_switchGameRunning.UseVisualStyleBackColor = true;
            this.button_switchGameRunning.Click += new System.EventHandler(this.button_switchGameRunning_Click);
            // 
            // button_editAirplanes
            // 
            this.button_editAirplanes.Location = new System.Drawing.Point(295, 84);
            this.button_editAirplanes.Name = "button_editAirplanes";
            this.button_editAirplanes.Size = new System.Drawing.Size(269, 50);
            this.button_editAirplanes.TabIndex = 4;
            this.button_editAirplanes.Text = "Edit airplanes";
            this.button_editAirplanes.UseVisualStyleBackColor = true;
            this.button_editAirplanes.Click += new System.EventHandler(this.button_editAirplanes_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Simulation status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_runningStatus
            // 
            this.label_runningStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_runningStatus.Location = new System.Drawing.Point(573, 152);
            this.label_runningStatus.Name = "label_runningStatus";
            this.label_runningStatus.Size = new System.Drawing.Size(121, 43);
            this.label_runningStatus.TabIndex = 6;
            this.label_runningStatus.Text = "?";
            this.label_runningStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_airplaneController
            // 
            this.button_airplaneController.Location = new System.Drawing.Point(295, 140);
            this.button_airplaneController.Name = "button_airplaneController";
            this.button_airplaneController.Size = new System.Drawing.Size(269, 50);
            this.button_airplaneController.TabIndex = 7;
            this.button_airplaneController.Text = "Airplane Controller";
            this.button_airplaneController.UseVisualStyleBackColor = true;
            this.button_airplaneController.Click += new System.EventHandler(this.button_airplaneController_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Made by Warafu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuForm
            // 
            this.ClientSize = new System.Drawing.Size(706, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_airplaneController);
            this.Controls.Add(this.label_runningStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_editAirplanes);
            this.Controls.Add(this.button_switchGameRunning);
            this.Controls.Add(this.button_tests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_newAirplane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuForm_FormClosed);
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_newAirplane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_tests;
        private System.Windows.Forms.Button button_switchGameRunning;
        private System.Windows.Forms.Button button_editAirplanes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_runningStatus;
        private System.Windows.Forms.Button button_airplaneController;
        private System.Windows.Forms.Label label3;
    }
}