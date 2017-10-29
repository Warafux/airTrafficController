namespace AirTrafficController.forms
{
    partial class testForm
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
            this.button_addRandomAirplane = new System.Windows.Forms.Button();
            this.button_testCollision = new System.Windows.Forms.Button();
            this.button_testMultipleCollision = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addRandomAirplane
            // 
            this.button_addRandomAirplane.Location = new System.Drawing.Point(12, 12);
            this.button_addRandomAirplane.Name = "button_addRandomAirplane";
            this.button_addRandomAirplane.Size = new System.Drawing.Size(260, 57);
            this.button_addRandomAirplane.TabIndex = 0;
            this.button_addRandomAirplane.Text = "Add random airplane";
            this.button_addRandomAirplane.UseVisualStyleBackColor = true;
            this.button_addRandomAirplane.Click += new System.EventHandler(this.button_addRandomAirplane_Click);
            // 
            // button_testCollision
            // 
            this.button_testCollision.Location = new System.Drawing.Point(12, 75);
            this.button_testCollision.Name = "button_testCollision";
            this.button_testCollision.Size = new System.Drawing.Size(260, 57);
            this.button_testCollision.TabIndex = 1;
            this.button_testCollision.Text = "TEST COLLISION";
            this.button_testCollision.UseVisualStyleBackColor = true;
            this.button_testCollision.Click += new System.EventHandler(this.button_testCollision_Click);
            // 
            // button_testMultipleCollision
            // 
            this.button_testMultipleCollision.Location = new System.Drawing.Point(12, 138);
            this.button_testMultipleCollision.Name = "button_testMultipleCollision";
            this.button_testMultipleCollision.Size = new System.Drawing.Size(260, 57);
            this.button_testMultipleCollision.TabIndex = 2;
            this.button_testMultipleCollision.Text = "TEST MULTIPLE COLLISION SAME SPEED/ACCELERATION";
            this.button_testMultipleCollision.UseVisualStyleBackColor = true;
            this.button_testMultipleCollision.Click += new System.EventHandler(this.button_testMultipleCollision_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "TEST MULTIPLE COLLISION RANDOM SPEED/ACCELERATION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_testMultipleCollision);
            this.Controls.Add(this.button_testCollision);
            this.Controls.Add(this.button_addRandomAirplane);
            this.Name = "testForm";
            this.Text = "testForm";
            this.Load += new System.EventHandler(this.testForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_addRandomAirplane;
        private System.Windows.Forms.Button button_testCollision;
        private System.Windows.Forms.Button button_testMultipleCollision;
        private System.Windows.Forms.Button button1;
    }
}