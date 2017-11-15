namespace AirTrafficController.forms
{
    partial class statsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_deadPeopleCounter = new System.Windows.Forms.Label();
            this.listBox_deadPeopleLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dead people";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "Statistics";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dead people log";
            // 
            // label_deadPeopleCounter
            // 
            this.label_deadPeopleCounter.AutoSize = true;
            this.label_deadPeopleCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deadPeopleCounter.Location = new System.Drawing.Point(155, 66);
            this.label_deadPeopleCounter.Name = "label_deadPeopleCounter";
            this.label_deadPeopleCounter.Size = new System.Drawing.Size(0, 39);
            this.label_deadPeopleCounter.TabIndex = 16;
            // 
            // listBox_deadPeopleLog
            // 
            this.listBox_deadPeopleLog.FormattingEnabled = true;
            this.listBox_deadPeopleLog.HorizontalScrollbar = true;
            this.listBox_deadPeopleLog.Location = new System.Drawing.Point(18, 136);
            this.listBox_deadPeopleLog.Name = "listBox_deadPeopleLog";
            this.listBox_deadPeopleLog.Size = new System.Drawing.Size(590, 121);
            this.listBox_deadPeopleLog.TabIndex = 17;
            // 
            // statsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 275);
            this.Controls.Add(this.listBox_deadPeopleLog);
            this.Controls.Add(this.label_deadPeopleCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "statsForm";
            this.ShowIcon = false;
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_deadPeopleCounter;
        private System.Windows.Forms.ListBox listBox_deadPeopleLog;
    }
}