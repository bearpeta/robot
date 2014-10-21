namespace Hslu.Csa.Team6.TestMotor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.driveCtrlView1 = new Hslu.Csa.Team6.RobotView.DriveCtrlView();
            this.motorCtrlViewLeft = new Hslu.Csa.Team6.RobotView.MotorCtrlView();
            this.motorCtrlViewRight = new Hslu.Csa.Team6.RobotView.MotorCtrlView();
            this.SuspendLayout();
            // 
            // driveCtrlView1
            // 
            this.driveCtrlView1.DriveCtrl = null;
            this.driveCtrlView1.Location = new System.Drawing.Point(311, 15);
            this.driveCtrlView1.Name = "driveCtrlView1";
            this.driveCtrlView1.Size = new System.Drawing.Size(480, 75);
            this.driveCtrlView1.TabIndex = 0;
            // 
            // motorCtrlViewLeft
            // 
            this.motorCtrlViewLeft.Location = new System.Drawing.Point(45, 93);
            this.motorCtrlViewLeft.MotorCtrl = null;
            this.motorCtrlViewLeft.Name = "motorCtrlViewLeft";
            this.motorCtrlViewLeft.Size = new System.Drawing.Size(480, 330);
            this.motorCtrlViewLeft.TabIndex = 1;
            // 
            // motorCtrlViewRight
            // 
            this.motorCtrlViewRight.Location = new System.Drawing.Point(546, 96);
            this.motorCtrlViewRight.MotorCtrl = null;
            this.motorCtrlViewRight.Name = "motorCtrlViewRight";
            this.motorCtrlViewRight.Size = new System.Drawing.Size(480, 330);
            this.motorCtrlViewRight.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1099, 426);
            this.Controls.Add(this.motorCtrlViewRight);
            this.Controls.Add(this.motorCtrlViewLeft);
            this.Controls.Add(this.driveCtrlView1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Hslu.Csa.Team6.RobotView.DriveCtrlView driveCtrlView1;
        private Hslu.Csa.Team6.RobotView.MotorCtrlView motorCtrlViewLeft;
        private Hslu.Csa.Team6.RobotView.MotorCtrlView motorCtrlViewRight;
    }
}

