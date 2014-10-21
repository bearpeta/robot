namespace Hslu.Csa.Team6.TestDrive
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
            this.commonRunParameters1 = new Hslu.Csa.Team6.RobotView.CommonRunParameters();
            this.driveView1 = new Hslu.Csa.Team6.RobotView.DriveView();
            this.runLineView1 = new Hslu.Csa.Team6.RobotView.RunLineView();
            this.SuspendLayout();
            // 
            // commonRunParameters1
            // 
            this.commonRunParameters1.Acceleration = 0.3F;
            this.commonRunParameters1.Location = new System.Drawing.Point(12, 321);
            this.commonRunParameters1.Name = "commonRunParameters1";
            this.commonRunParameters1.Size = new System.Drawing.Size(350, 85);
            this.commonRunParameters1.Speed = 0.5F;
            this.commonRunParameters1.TabIndex = 1;
            this.commonRunParameters1.AccelerationChanged += new System.EventHandler(this.commonRunParameters1_AccelerationChanged);
            this.commonRunParameters1.SpeedChanged += new System.EventHandler(this.commonRunParameters1_SpeedChanged);
            // 
            // driveView1
            // 
            this.driveView1.Drive = null;
            this.driveView1.Location = new System.Drawing.Point(12, 3);
            this.driveView1.Name = "driveView1";
            this.driveView1.Size = new System.Drawing.Size(290, 300);
            this.driveView1.TabIndex = 0;
            // 
            // runLineView1
            // 
            this.runLineView1.Acceleration = 0F;
            this.runLineView1.Drive = null;
            this.runLineView1.Location = new System.Drawing.Point(355, 23);
            this.runLineView1.Name = "runLineView1";
            this.runLineView1.Size = new System.Drawing.Size(389, 84);
            this.runLineView1.Speed = 0F;
            this.runLineView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(829, 448);
            this.Controls.Add(this.runLineView1);
            this.Controls.Add(this.commonRunParameters1);
            this.Controls.Add(this.driveView1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Hslu.Csa.Team6.RobotView.DriveView driveView1;
        private Hslu.Csa.Team6.RobotView.CommonRunParameters commonRunParameters1;
        private Hslu.Csa.Team6.RobotView.RunLineView runLineView1;
    }
}

