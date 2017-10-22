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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_airplaneCoordinateY)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_airplaneModel
            // 
            this.textBox_airplaneModel.Location = new System.Drawing.Point(23, 104);
            this.textBox_airplaneModel.Name = "textBox_airplaneModel";
            this.textBox_airplaneModel.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneModel.TabIndex = 0;
            this.textBox_airplaneModel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_airplaneVendor
            // 
            this.textBox_airplaneVendor.Location = new System.Drawing.Point(23, 158);
            this.textBox_airplaneVendor.Name = "textBox_airplaneVendor";
            this.textBox_airplaneVendor.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneVendor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // button_addAirplane
            // 
            this.button_addAirplane.Location = new System.Drawing.Point(12, 398);
            this.button_addAirplane.Name = "button_addAirplane";
            this.button_addAirplane.Size = new System.Drawing.Size(260, 167);
            this.button_addAirplane.TabIndex = 6;
            this.button_addAirplane.Text = "Add airplane";
            this.button_addAirplane.UseVisualStyleBackColor = true;
            this.button_addAirplane.Click += new System.EventHandler(this.button_addAirplane_Click);
            // 
            // textBox_airplaneId
            // 
            this.textBox_airplaneId.Location = new System.Drawing.Point(23, 46);
            this.textBox_airplaneId.Name = "textBox_airplaneId";
            this.textBox_airplaneId.Size = new System.Drawing.Size(232, 20);
            this.textBox_airplaneId.TabIndex = 7;
            // 
            // numericUpDown_airplaneCapacity
            // 
            this.numericUpDown_airplaneCapacity.Location = new System.Drawing.Point(23, 217);
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
            this.numericUpDown_airplaneCapacity.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown_airplaneCapacity.TabIndex = 10;
            this.numericUpDown_airplaneCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneCoordinateX
            // 
            this.numericUpDown_airplaneCoordinateX.Location = new System.Drawing.Point(33, 278);
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
            this.numericUpDown_airplaneCoordinateX.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown_airplaneCoordinateX.TabIndex = 11;
            this.numericUpDown_airplaneCoordinateX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_airplaneCoordinateY
            // 
            this.numericUpDown_airplaneCoordinateY.Location = new System.Drawing.Point(33, 316);
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
            this.numericUpDown_airplaneCoordinateY.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown_airplaneCoordinateY.TabIndex = 12;
            this.numericUpDown_airplaneCoordinateY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newAirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 577);
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
    }
}