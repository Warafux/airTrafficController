namespace AirTrafficController.forms
{
    partial class newAirplaneForm
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
            this.numericUpDown_altitude = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneAcceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altitude)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_airplaneModel
            // 
            this.textBox_airplaneModel.Location = new System.Drawing.Point(18, 143);
            this.textBox_airplaneModel.Name = "textBox_airplaneModel";
            this.textBox_airplaneModel.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneModel.TabIndex = 0;
            this.textBox_airplaneModel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_airplaneVendor
            // 
            this.textBox_airplaneVendor.Location = new System.Drawing.Point(18, 182);
            this.textBox_airplaneVendor.Name = "textBox_airplaneVendor";
            this.textBox_airplaneVendor.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneVendor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacity";
            // 
            // button_addAirplane
            // 
            this.button_addAirplane.Location = new System.Drawing.Point(12, 452);
            this.button_addAirplane.Name = "button_addAirplane";
            this.button_addAirplane.Size = new System.Drawing.Size(260, 113);
            this.button_addAirplane.TabIndex = 6;
            this.button_addAirplane.Text = "Add airplane";
            this.button_addAirplane.UseVisualStyleBackColor = true;
            this.button_addAirplane.Click += new System.EventHandler(this.button_addAirplane_Click);
            // 
            // textBox_airplaneId
            // 
            this.textBox_airplaneId.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_airplaneId.Location = new System.Drawing.Point(18, 104);
            this.textBox_airplaneId.Name = "textBox_airplaneId";
            this.textBox_airplaneId.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneId.TabIndex = 7;
            // 
            // numericUpDown_airplaneCapacity
            // 
            this.numericUpDown_airplaneCapacity.Location = new System.Drawing.Point(18, 221);
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
            this.numericUpDown_airplaneCapacity.TabIndex = 10;
            this.numericUpDown_airplaneCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneCoordinateX
            // 
            this.numericUpDown_airplaneCoordinateX.Location = new System.Drawing.Point(18, 294);
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
            this.numericUpDown_airplaneCoordinateX.TabIndex = 11;
            this.numericUpDown_airplaneCoordinateX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneCoordinateY
            // 
            this.numericUpDown_airplaneCoordinateY.Location = new System.Drawing.Point(148, 294);
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
            this.numericUpDown_airplaneCoordinateY.TabIndex = 12;
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
            this.label4.Text = "New airplane";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Y";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numericUpDown_airplaneAcceleration
            // 
            this.numericUpDown_airplaneAcceleration.Location = new System.Drawing.Point(148, 343);
            this.numericUpDown_airplaneAcceleration.Maximum = new decimal(new int[] {
            1000,
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
            this.numericUpDown_airplaneAcceleration.TabIndex = 18;
            this.numericUpDown_airplaneAcceleration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneSpeed
            // 
            this.numericUpDown_airplaneSpeed.Location = new System.Drawing.Point(18, 343);
            this.numericUpDown_airplaneSpeed.Maximum = new decimal(new int[] {
            1000,
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
            this.numericUpDown_airplaneSpeed.TabIndex = 17;
            this.numericUpDown_airplaneSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Acceleration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Speed";
            // 
            // numericUpDown_altitude
            // 
            this.numericUpDown_altitude.Location = new System.Drawing.Point(18, 382);
            this.numericUpDown_altitude.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_altitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_altitude.Name = "numericUpDown_altitude";
            this.numericUpDown_altitude.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_altitude.TabIndex = 21;
            this.numericUpDown_altitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(19, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Altitude";
            // 
            // newAirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 577);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown_altitude);
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
            this.Name = "newAirplaneForm";
            this.Text = "newAirplaneForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneAcceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altitude)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown_altitude;
        private System.Windows.Forms.Label label10;
    }
}