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
            this.button_airplaneSwitchMotorStatus.Location = new System.Drawing.Point(14, 219);
            this.button_airplaneSwitchMotorStatus.Name = "button_airplaneSwitchMotorStatus";
            this.button_airplaneSwitchMotorStatus.Size = new System.Drawing.Size(198, 55);
            this.button_airplaneSwitchMotorStatus.TabIndex = 34;
            this.button_airplaneSwitchMotorStatus.Text = "Switch motor status ON/OFF";
            this.button_airplaneSwitchMotorStatus.UseVisualStyleBackColor = true;
            this.button_airplaneSwitchMotorStatus.Click += new System.EventHandler(this.button_airplaneSwitchMotorStatus_Click);
            // 
            // button_airplaneSwitchDeployedLandingGear
            // 
            this.button_airplaneSwitchDeployedLandingGear.Location = new System.Drawing.Point(14, 280);
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
            this.button_airplaneAscend.Location = new System.Drawing.Point(14, 158);
            this.button_airplaneAscend.Name = "button_airplaneAscend";
            this.button_airplaneAscend.Size = new System.Drawing.Size(96, 55);
            this.button_airplaneAscend.TabIndex = 39;
            this.button_airplaneAscend.Text = "Ascend";
            this.button_airplaneAscend.UseVisualStyleBackColor = true;
            this.button_airplaneAscend.Click += new System.EventHandler(this.button_airplaneAscend_Click);
            // 
            // button_airplaneDescend
            // 
            this.button_airplaneDescend.Location = new System.Drawing.Point(116, 158);
            this.button_airplaneDescend.Name = "button_airplaneDescend";
            this.button_airplaneDescend.Size = new System.Drawing.Size(96, 55);
            this.button_airplaneDescend.TabIndex = 40;
            this.button_airplaneDescend.Text = "Descend";
            this.button_airplaneDescend.UseVisualStyleBackColor = true;
            this.button_airplaneDescend.Click += new System.EventHandler(this.button_airplaneDescend_Click);
            // 
            // controllerAirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 730);
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
    }
}