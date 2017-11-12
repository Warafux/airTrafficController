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
            this.button_testMultipleCollisionRandom = new System.Windows.Forms.Button();
            this.button_testCollisionGround = new System.Windows.Forms.Button();
            this.button_testNoCollisionAirplaneAltitude = new System.Windows.Forms.Button();
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
            // button_testMultipleCollisionRandom
            // 
            this.button_testMultipleCollisionRandom.Location = new System.Drawing.Point(12, 201);
            this.button_testMultipleCollisionRandom.Name = "button_testMultipleCollisionRandom";
            this.button_testMultipleCollisionRandom.Size = new System.Drawing.Size(260, 57);
            this.button_testMultipleCollisionRandom.TabIndex = 3;
            this.button_testMultipleCollisionRandom.Text = "TEST MULTIPLE COLLISION RANDOM SPEED/ACCELERATION";
            this.button_testMultipleCollisionRandom.UseVisualStyleBackColor = true;
            this.button_testMultipleCollisionRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_testCollisionGround
            // 
            this.button_testCollisionGround.Location = new System.Drawing.Point(12, 264);
            this.button_testCollisionGround.Name = "button_testCollisionGround";
            this.button_testCollisionGround.Size = new System.Drawing.Size(260, 57);
            this.button_testCollisionGround.TabIndex = 4;
            this.button_testCollisionGround.Text = "TEST COLLISION WITH GROUND";
            this.button_testCollisionGround.UseVisualStyleBackColor = true;
            this.button_testCollisionGround.Click += new System.EventHandler(this.button_testCollisionGround_Click);
            // 
            // button_testNoCollisionAirplaneAltitude
            // 
            this.button_testNoCollisionAirplaneAltitude.Location = new System.Drawing.Point(12, 327);
            this.button_testNoCollisionAirplaneAltitude.Name = "button_testNoCollisionAirplaneAltitude";
            this.button_testNoCollisionAirplaneAltitude.Size = new System.Drawing.Size(260, 57);
            this.button_testNoCollisionAirplaneAltitude.TabIndex = 5;
            this.button_testNoCollisionAirplaneAltitude.Text = "TEST NO COLLISION WITH AIRPLANES (ALTITUDE)";
            this.button_testNoCollisionAirplaneAltitude.UseVisualStyleBackColor = true;
            this.button_testNoCollisionAirplaneAltitude.Click += new System.EventHandler(this.button_testNoCollisionAirplaneAltitude_Click);
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 526);
            this.Controls.Add(this.button_testNoCollisionAirplaneAltitude);
            this.Controls.Add(this.button_testCollisionGround);
            this.Controls.Add(this.button_testMultipleCollisionRandom);
            this.Controls.Add(this.button_testMultipleCollision);
            this.Controls.Add(this.button_testCollision);
            this.Controls.Add(this.button_addRandomAirplane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "testForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tests";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.testForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_addRandomAirplane;
        private System.Windows.Forms.Button button_testCollision;
        private System.Windows.Forms.Button button_testMultipleCollision;
        private System.Windows.Forms.Button button_testMultipleCollisionRandom;
        private System.Windows.Forms.Button button_testCollisionGround;
        private System.Windows.Forms.Button button_testNoCollisionAirplaneAltitude;
    }
}