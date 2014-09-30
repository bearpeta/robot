namespace Hslu.Csa.Team6.RobotView
{
    partial class SwitchView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchView));
            this.pictureBoxSwitch = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pictureBoxSwitch
            // 
            this.pictureBoxSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSwitch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSwitch.Image")));
            this.pictureBoxSwitch.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSwitch.Name = "pictureBoxSwitch";
            this.pictureBoxSwitch.Size = new System.Drawing.Size(20, 40);
            // 
            // SwitchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pictureBoxSwitch);
            this.Name = "SwitchView";
            this.Size = new System.Drawing.Size(20, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSwitch;
    }
}
