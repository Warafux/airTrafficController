namespace AirTrafficController.forms
{
    partial class editAirplaneForm
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
            this.textBox_airplaneModel = new System.Windows.Forms.TextBox();
            this.textBox_airplaneVendor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addAirplane = new System.Windows.Forms.Button();
            this.textBox_airplaneId = new System.Windows.Forms.TextBox();
            this.numericUpDown_airplaneCapacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_airplaneCoordinateX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_airplaneCoordinateY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_airplaneAcceleration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_airplaneSpeed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_airplaneAltitude = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_availableAirplanes = new System.Windows.Forms.ComboBox();
            this.button_randomNumbers = new System.Windows.Forms.Button();
            this.radioButton_airplaneDirectionLeft = new System.Windows.Forms.RadioButton();
            this.radioButton_airplaneDirectionUp = new System.Windows.Forms.RadioButton();
            this.radioButton_airplaneDirectionRight = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton_airplaneDirectionDown = new System.Windows.Forms.RadioButton();
            this.radioButton_airplaneDirectionRandom = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown_airplaneMaxSpeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneAcceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneMaxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_airplaneModel
            // 
            this.textBox_airplaneModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_airplaneModel.Location = new System.Drawing.Point(18, 165);
            this.textBox_airplaneModel.Name = "textBox_airplaneModel";
            this.textBox_airplaneModel.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneModel.TabIndex = 4;
            this.textBox_airplaneModel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_airplaneVendor
            // 
            this.textBox_airplaneVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_airplaneVendor.Location = new System.Drawing.Point(18, 208);
            this.textBox_airplaneVendor.Name = "textBox_airplaneVendor";
            this.textBox_airplaneVendor.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneVendor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacity";
            // 
            // button_addAirplane
            // 
            this.button_addAirplane.Location = new System.Drawing.Point(12, 518);
            this.button_addAirplane.Name = "button_addAirplane";
            this.button_addAirplane.Size = new System.Drawing.Size(260, 47);
            this.button_addAirplane.TabIndex = 17;
            this.button_addAirplane.Text = "Save airplane";
            this.button_addAirplane.UseVisualStyleBackColor = true;
            this.button_addAirplane.Click += new System.EventHandler(this.button_saveAirplane_Click);
            // 
            // textBox_airplaneId
            // 
            this.textBox_airplaneId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_airplaneId.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_airplaneId.Location = new System.Drawing.Point(18, 123);
            this.textBox_airplaneId.Name = "textBox_airplaneId";
            this.textBox_airplaneId.ReadOnly = true;
            this.textBox_airplaneId.Size = new System.Drawing.Size(141, 20);
            this.textBox_airplaneId.TabIndex = 2;
            // 
            // numericUpDown_airplaneCapacity
            // 
            this.numericUpDown_airplaneCapacity.Location = new System.Drawing.Point(18, 248);
            this.numericUpDown_airplaneCapacity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_airplaneCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_airplaneCapacity.Name = "numericUpDown_airplaneCapacity";
            this.numericUpDown_airplaneCapacity.Size = new System.Drawing.Size(232, 20);
            this.numericUpDown_airplaneCapacity.TabIndex = 6;
            this.numericUpDown_airplaneCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneCoordinateX
            // 
            this.numericUpDown_airplaneCoordinateX.Location = new System.Drawing.Point(18, 290);
            this.numericUpDown_airplaneCoordinateX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_airplaneCoordinateX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_airplaneCoordinateX.Name = "numericUpDown_airplaneCoordinateX";
            this.numericUpDown_airplaneCoordinateX.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_airplaneCoordinateX.TabIndex = 7;
            this.numericUpDown_airplaneCoordinateX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneCoordinateY
            // 
            this.numericUpDown_airplaneCoordinateY.Location = new System.Drawing.Point(148, 290);
            this.numericUpDown_airplaneCoordinateY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_airplaneCoordinateY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_airplaneCoordinateY.Name = "numericUpDown_airplaneCoordinateY";
            this.numericUpDown_airplaneCoordinateY.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_airplaneCoordinateY.TabIndex = 8;
            this.numericUpDown_airplaneCoordinateY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 47);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edit airplane";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Y";
            // 
            // numericUpDown_airplaneAcceleration
            // 
            this.numericUpDown_airplaneAcceleration.Location = new System.Drawing.Point(148, 378);
            this.numericUpDown_airplaneAcceleration.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_airplaneAcceleration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_airplaneAcceleration.Name = "numericUpDown_airplaneAcceleration";
            this.numericUpDown_airplaneAcceleration.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_airplaneAcceleration.TabIndex = 10;
            this.numericUpDown_airplaneAcceleration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneSpeed
            // 
            this.numericUpDown_airplaneSpeed.Location = new System.Drawing.Point(18, 339);
            this.numericUpDown_airplaneSpeed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_airplaneSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_airplaneSpeed.Name = "numericUpDown_airplaneSpeed";
            this.numericUpDown_airplaneSpeed.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_airplaneSpeed.TabIndex = 9;
            this.numericUpDown_airplaneSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Acceleration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Speed";
            // 
            // numericUpDown_airplaneAltitude
            // 
            this.numericUpDown_airplaneAltitude.Location = new System.Drawing.Point(18, 378);
            this.numericUpDown_airplaneAltitude.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_airplaneAltitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_airplaneAltitude.Name = "numericUpDown_airplaneAltitude";
            this.numericUpDown_airplaneAltitude.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_airplaneAltitude.TabIndex = 11;
            this.numericUpDown_airplaneAltitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(19, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Altitude";
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
            this.comboBox_availableAirplanes.Location = new System.Drawing.Point(18, 72);
            this.comboBox_availableAirplanes.Name = "comboBox_availableAirplanes";
            this.comboBox_availableAirplanes.Size = new System.Drawing.Size(232, 21);
            this.comboBox_availableAirplanes.TabIndex = 1;
            this.comboBox_availableAirplanes.SelectedValueChanged += new System.EventHandler(this.comboBox_airplanePresets_SelectedValueChanged);
            // 
            // button_randomNumbers
            // 
            this.button_randomNumbers.Location = new System.Drawing.Point(18, 404);
            this.button_randomNumbers.Name = "button_randomNumbers";
            this.button_randomNumbers.Size = new System.Drawing.Size(111, 20);
            this.button_randomNumbers.TabIndex = 12;
            this.button_randomNumbers.Text = "Random";
            this.button_randomNumbers.UseVisualStyleBackColor = true;
            this.button_randomNumbers.Click += new System.EventHandler(this.button_randomNumbers_Click);
            // 
            // radioButton_airplaneDirectionLeft
            // 
            this.radioButton_airplaneDirectionLeft.AutoSize = true;
            this.radioButton_airplaneDirectionLeft.Location = new System.Drawing.Point(22, 456);
            this.radioButton_airplaneDirectionLeft.Name = "radioButton_airplaneDirectionLeft";
            this.radioButton_airplaneDirectionLeft.Size = new System.Drawing.Size(43, 17);
            this.radioButton_airplaneDirectionLeft.TabIndex = 13;
            this.radioButton_airplaneDirectionLeft.Text = "Left";
            this.radioButton_airplaneDirectionLeft.UseVisualStyleBackColor = true;
            // 
            // radioButton_airplaneDirectionUp
            // 
            this.radioButton_airplaneDirectionUp.AutoSize = true;
            this.radioButton_airplaneDirectionUp.Location = new System.Drawing.Point(80, 456);
            this.radioButton_airplaneDirectionUp.Name = "radioButton_airplaneDirectionUp";
            this.radioButton_airplaneDirectionUp.Size = new System.Drawing.Size(39, 17);
            this.radioButton_airplaneDirectionUp.TabIndex = 14;
            this.radioButton_airplaneDirectionUp.Text = "Up";
            this.radioButton_airplaneDirectionUp.UseVisualStyleBackColor = true;
            // 
            // radioButton_airplaneDirectionRight
            // 
            this.radioButton_airplaneDirectionRight.AutoSize = true;
            this.radioButton_airplaneDirectionRight.Location = new System.Drawing.Point(131, 456);
            this.radioButton_airplaneDirectionRight.Name = "radioButton_airplaneDirectionRight";
            this.radioButton_airplaneDirectionRight.Size = new System.Drawing.Size(50, 17);
            this.radioButton_airplaneDirectionRight.TabIndex = 15;
            this.radioButton_airplaneDirectionRight.Text = "Right";
            this.radioButton_airplaneDirectionRight.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(19, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Direction";
            // 
            // radioButton_airplaneDirectionDown
            // 
            this.radioButton_airplaneDirectionDown.AutoSize = true;
            this.radioButton_airplaneDirectionDown.Location = new System.Drawing.Point(197, 456);
            this.radioButton_airplaneDirectionDown.Name = "radioButton_airplaneDirectionDown";
            this.radioButton_airplaneDirectionDown.Size = new System.Drawing.Size(53, 17);
            this.radioButton_airplaneDirectionDown.TabIndex = 16;
            this.radioButton_airplaneDirectionDown.Text = "Down";
            this.radioButton_airplaneDirectionDown.UseVisualStyleBackColor = true;
            // 
            // radioButton_airplaneDirectionRandom
            // 
            this.radioButton_airplaneDirectionRandom.AutoSize = true;
            this.radioButton_airplaneDirectionRandom.Checked = true;
            this.radioButton_airplaneDirectionRandom.Location = new System.Drawing.Point(22, 479);
            this.radioButton_airplaneDirectionRandom.Name = "radioButton_airplaneDirectionRandom";
            this.radioButton_airplaneDirectionRandom.Size = new System.Drawing.Size(110, 17);
            this.radioButton_airplaneDirectionRandom.TabIndex = 31;
            this.radioButton_airplaneDirectionRandom.TabStop = true;
            this.radioButton_airplaneDirectionRandom.Text = "Random Direction";
            this.radioButton_airplaneDirectionRandom.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Max Speed";
            // 
            // numericUpDown_airplaneMaxSpeed
            // 
            this.numericUpDown_airplaneMaxSpeed.Location = new System.Drawing.Point(148, 339);
            this.numericUpDown_airplaneMaxSpeed.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_airplaneMaxSpeed.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_airplaneMaxSpeed.Name = "numericUpDown_airplaneMaxSpeed";
            this.numericUpDown_airplaneMaxSpeed.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_airplaneMaxSpeed.TabIndex = 32;
            this.numericUpDown_airplaneMaxSpeed.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // editAirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 577);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown_airplaneMaxSpeed);
            this.Controls.Add(this.radioButton_airplaneDirectionRandom);
            this.Controls.Add(this.radioButton_airplaneDirectionDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radioButton_airplaneDirectionRight);
            this.Controls.Add(this.radioButton_airplaneDirectionUp);
            this.Controls.Add(this.radioButton_airplaneDirectionLeft);
            this.Controls.Add(this.button_randomNumbers);
            this.Controls.Add(this.comboBox_availableAirplanes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown_airplaneAltitude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown_airplaneAcceleration);
            this.Controls.Add(this.numericUpDown_airplaneSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_airplaneCoordinateY);
            this.Controls.Add(this.numericUpDown_airplaneCoordinateX);
            this.Controls.Add(this.numericUpDown_airplaneCapacity);
            this.Controls.Add(this.textBox_airplaneId);
            this.Controls.Add(this.button_addAirplane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_airplaneVendor);
            this.Controls.Add(this.textBox_airplaneModel);
            this.Name = "editAirplaneForm";
            this.ShowIcon = false;
            this.Text = "EDIT AIRPLANE";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneAcceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneMaxSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_airplaneModel;
        private System.Windows.Forms.TextBox textBox_airplaneVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_addAirplane;
        private System.Windows.Forms.TextBox textBox_airplaneId;
        private System.Windows.Forms.NumericUpDown numericUpDown_airplaneCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDown_airplaneCoordinateX;
        private System.Windows.Forms.NumericUpDown numericUpDown_airplaneCoordinateY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_airplaneAcceleration;
        private System.Windows.Forms.NumericUpDown numericUpDown_airplaneSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_airplaneAltitude;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_availableAirplanes;
        private System.Windows.Forms.Button button_randomNumbers;
        private System.Windows.Forms.RadioButton radioButton_airplaneDirectionLeft;
        private System.Windows.Forms.RadioButton radioButton_airplaneDirectionUp;
        private System.Windows.Forms.RadioButton radioButton_airplaneDirectionRight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton_airplaneDirectionDown;
        private System.Windows.Forms.RadioButton radioButton_airplaneDirectionRandom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown_airplaneMaxSpeed;
    }
}