namespace AirTrafficController.forms
{
    partial class controllerAirplaneForm
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
            this.textBox_airplaneId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_availableAirplanes = new System.Windows.Forms.ComboBox();
            this.button_airplaneSwitchMotorStatus = new System.Windows.Forms.Button();
            this.button_airplaneSwitchDeployedLandingGear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button_airplaneAscend = new System.Windows.Forms.Button();
            this.button_airplaneDescend = new System.Windows.Forms.Button();
            this.button_airplaneAccelerate = new System.Windows.Forms.Button();
            this.button_airplaneBrake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_airplaneSpeed = new System.Windows.Forms.Label();
            this.label_airplaneAcceleration = new System.Windows.Forms.Label();
            this.label_airplaneAltitude = new System.Windows.Forms.Label();
            this.label_airplaneMotorStatus = new System.Windows.Forms.Label();
            this.label_airplaneLandingGear = new System.Windows.Forms.Label();
            this.label_airplaneAltitudeDanger = new System.Windows.Forms.Label();
            this.label_airplaneCollisionDanger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_airplaneId
            // 
            this.textBox_airplaneId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_airplaneId.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_airplaneId.Location = new System.Drawing.Point(14, 123);
            this.textBox_airplaneId.Name = "textBox_airplaneId";
            this.textBox_airplaneId.ReadOnly = true;
            this.textBox_airplaneId.Size = new System.Drawing.Size(198, 20);
            this.textBox_airplaneId.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Available airplanes";
            // 
            // comboBox_availableAirplanes
            // 
            this.comboBox_availableAirplanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_availableAirplanes.FormattingEnabled = true;
            this.comboBox_availableAirplanes.Location = new System.Drawing.Point(14, 72);
            this.comboBox_availableAirplanes.Name = "comboBox_availableAirplanes";
            this.comboBox_availableAirplanes.Size = new System.Drawing.Size(198, 21);
            this.comboBox_availableAirplanes.TabIndex = 1;
            this.comboBox_availableAirplanes.SelectedValueChanged += new System.EventHandler(this.comboBox_airplanePresets_SelectedValueChanged);
            // 
            // button_airplaneSwitchMotorStatus
            // 
            this.button_airplaneSwitchMotorStatus.Location = new System.Drawing.Point(14, 284);
            this.button_airplaneSwitchMotorStatus.Name = "button_airplaneSwitchMotorStatus";
            this.button_airplaneSwitchMotorStatus.Size = new System.Drawing.Size(198, 55);
            this.button_airplaneSwitchMotorStatus.TabIndex = 34;
            this.button_airplaneSwitchMotorStatus.Text = "Switch motor status ON/OFF";
            this.button_airplaneSwitchMotorStatus.UseVisualStyleBackColor = true;
            this.button_airplaneSwitchMotorStatus.Click += new System.EventHandler(this.button_airplaneSwitchMotorStatus_Click);
            // 
            // button_airplaneSwitchDeployedLandingGear
            // 
            this.button_airplaneSwitchDeployedLandingGear.Location = new System.Drawing.Point(14, 345);
            this.button_airplaneSwitchDeployedLandingGear.Name = "button_airplaneSwitchDeployedLandingGear";
            this.button_airplaneSwitchDeployedLandingGear.Size = new System.Drawing.Size(198, 55);
            this.button_airplaneSwitchDeployedLandingGear.TabIndex = 35;
            this.button_airplaneSwitchDeployedLandingGear.Text = "Switch landing gear status DEPLOYED/NOT DEPLOYED";
            this.button_airplaneSwitchDeployedLandingGear.UseVisualStyleBackColor = true;
            this.button_airplaneSwitchDeployedLandingGear.Click += new System.EventHandler(this.button_airplaneSwitchDeployedLandingGear_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 30);
            this.label15.TabIndex = 38;
            this.label15.Text = "Airplane Controller";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_airplaneAscend
            // 
            this.button_airplaneAscend.Location = new System.Drawing.Point(14, 223);
            this.button_airplaneAscend.Name = "button_airplaneAscend";
            this.button_airplaneAscend.Size = new System.Drawing.Size(96, 55);
            this.button_airplaneAscend.TabIndex = 39;
            this.button_airplaneAscend.Text = "Ascend";
            this.button_airplaneAscend.UseVisualStyleBackColor = true;
            this.button_airplaneAscend.Click += new System.EventHandler(this.button_airplaneAscend_Click);
            // 
            // button_airplaneDescend
            // 
            this.button_airplaneDescend.Location = new System.Drawing.Point(116, 223);
            this.button_airplaneDescend.Name = "button_airplaneDescend";
            this.button_airplaneDescend.Size = new System.Drawing.Size(96, 55);
            this.button_airplaneDescend.TabIndex = 40;
            this.button_airplaneDescend.Text = "Descend";
            this.button_airplaneDescend.UseVisualStyleBackColor = true;
            this.button_airplaneDescend.Click += new System.EventHandler(this.button_airplaneDescend_Click);
            // 
            // button_airplaneAccelerate
            // 
            this.button_airplaneAccelerate.Location = new System.Drawing.Point(14, 162);
            this.button_airplaneAccelerate.Name = "button_airplaneAccelerate";
            this.button_airplaneAccelerate.Size = new System.Drawing.Size(96, 55);
            this.button_airplaneAccelerate.TabIndex = 41;
            this.button_airplaneAccelerate.Text = "Accelerate";
            this.button_airplaneAccelerate.UseVisualStyleBackColor = true;
            this.button_airplaneAccelerate.Click += new System.EventHandler(this.button_airplaneAccelerate_Click);
            // 
            // button_airplaneBrake
            // 
            this.button_airplaneBrake.Location = new System.Drawing.Point(117, 162);
            this.button_airplaneBrake.Name = "button_airplaneBrake";
            this.button_airplaneBrake.Size = new System.Drawing.Size(96, 55);
            this.button_airplaneBrake.TabIndex = 42;
            this.button_airplaneBrake.Text = "Brake";
            this.button_airplaneBrake.UseVisualStyleBackColor = true;
            this.button_airplaneBrake.Click += new System.EventHandler(this.button_airplaneBrake_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "Live airplane variables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Speed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Acceleration:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Altitude:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Motor status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Landing gear";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Collision danger";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Altitude danger";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_airplaneSpeed
            // 
            this.label_airplaneSpeed.AutoSize = true;
            this.label_airplaneSpeed.Location = new System.Drawing.Point(86, 462);
            this.label_airplaneSpeed.Name = "label_airplaneSpeed";
            this.label_airplaneSpeed.Size = new System.Drawing.Size(0, 13);
            this.label_airplaneSpeed.TabIndex = 52;
            // 
            // label_airplaneAcceleration
            // 
            this.label_airplaneAcceleration.AutoSize = true;
            this.label_airplaneAcceleration.Location = new System.Drawing.Point(85, 481);
            this.label_airplaneAcceleration.Name = "label_airplaneAcceleration";
            this.label_airplaneAcceleration.Size = new System.Drawing.Size(0, 13);
            this.label_airplaneAcceleration.TabIndex = 53;
            // 
            // label_airplaneAltitude
            // 
            this.label_airplaneAltitude.AutoSize = true;
            this.label_airplaneAltitude.Location = new System.Drawing.Point(86, 500);
            this.label_airplaneAltitude.Name = "label_airplaneAltitude";
            this.label_airplaneAltitude.Size = new System.Drawing.Size(0, 13);
            this.label_airplaneAltitude.TabIndex = 54;
            // 
            // label_airplaneMotorStatus
            // 
            this.label_airplaneMotorStatus.AutoSize = true;
            this.label_airplaneMotorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_airplaneMotorStatus.Location = new System.Drawing.Point(12, 543);
            this.label_airplaneMotorStatus.Name = "label_airplaneMotorStatus";
            this.label_airplaneMotorStatus.Size = new System.Drawing.Size(0, 33);
            this.label_airplaneMotorStatus.TabIndex = 55;
            // 
            // label_airplaneLandingGear
            // 
            this.label_airplaneLandingGear.AutoSize = true;
            this.label_airplaneLandingGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_airplaneLandingGear.Location = new System.Drawing.Point(140, 543);
            this.label_airplaneLandingGear.Name = "label_airplaneLandingGear";
            this.label_airplaneLandingGear.Size = new System.Drawing.Size(0, 33);
            this.label_airplaneLandingGear.TabIndex = 56;
            // 
            // label_airplaneAltitudeDanger
            // 
            this.label_airplaneAltitudeDanger.AutoSize = true;
            this.label_airplaneAltitudeDanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_airplaneAltitudeDanger.Location = new System.Drawing.Point(140, 614);
            this.label_airplaneAltitudeDanger.Name = "label_airplaneAltitudeDanger";
            this.label_airplaneAltitudeDanger.Size = new System.Drawing.Size(0, 33);
            this.label_airplaneAltitudeDanger.TabIndex = 57;
            // 
            // label_airplaneCollisionDanger
            // 
            this.label_airplaneCollisionDanger.AutoSize = true;
            this.label_airplaneCollisionDanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_airplaneCollisionDanger.Location = new System.Drawing.Point(12, 614);
            this.label_airplaneCollisionDanger.Name = "label_airplaneCollisionDanger";
            this.label_airplaneCollisionDanger.Size = new System.Drawing.Size(0, 33);
            this.label_airplaneCollisionDanger.TabIndex = 58;
            // 
            // controllerAirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 730);
            this.Controls.Add(this.label_airplaneCollisionDanger);
            this.Controls.Add(this.label_airplaneAltitudeDanger);
            this.Controls.Add(this.label_airplaneLandingGear);
            this.Controls.Add(this.label_airplaneMotorStatus);
            this.Controls.Add(this.label_airplaneAltitude);
            this.Controls.Add(this.label_airplaneAcceleration);
            this.Controls.Add(this.label_airplaneSpeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_airplaneBrake);
            this.Controls.Add(this.button_airplaneAccelerate);
            this.Controls.Add(this.button_airplaneDescend);
            this.Controls.Add(this.button_airplaneAscend);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button_airplaneSwitchDeployedLandingGear);
            this.Controls.Add(this.button_airplaneSwitchMotorStatus);
            this.Controls.Add(this.comboBox_availableAirplanes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_airplaneId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "controllerAirplaneForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit Airplane";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.controllerAirplaneForm_FormClosing);
            this.Load += new System.EventHandler(this.controllerAirplaneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_airplaneId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_availableAirplanes;
        private System.Windows.Forms.Button button_airplaneSwitchMotorStatus;
        private System.Windows.Forms.Button button_airplaneSwitchDeployedLandingGear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_airplaneAscend;
        private System.Windows.Forms.Button button_airplaneDescend;
        private System.Windows.Forms.Button button_airplaneAccelerate;
        private System.Windows.Forms.Button button_airplaneBrake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_airplaneSpeed;
        private System.Windows.Forms.Label label_airplaneAcceleration;
        private System.Windows.Forms.Label label_airplaneAltitude;
        private System.Windows.Forms.Label label_airplaneMotorStatus;
        private System.Windows.Forms.Label label_airplaneLandingGear;
        private System.Windows.Forms.Label label_airplaneAltitudeDanger;
        private System.Windows.Forms.Label label_airplaneCollisionDanger;
    }
}