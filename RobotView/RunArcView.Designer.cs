namespace Hslu.Csa.Team6.RobotView
{
    partial class RunArcView
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(337, 80);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 20);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "RunArc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "+/-";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.Text = "Angle (+/- degrees)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Radius (+mm)";
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(223, 6);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(60, 20);
            this.radioButtonLeft.TabIndex = 12;
            this.radioButtonLeft.Text = "Left";
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.Location = new System.Drawing.Point(309, 6);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(64, 20);
            this.radioButtonRight.TabIndex = 13;
            this.radioButtonRight.TabStop = false;
            this.radioButtonRight.Text = "Right";
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRadius.Location = new System.Drawing.Point(223, 44);
            this.numericUpDownRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(100, 24);
            this.numericUpDownRadius.TabIndex = 14;
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAngle.Location = new System.Drawing.Point(223, 75);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(100, 24);
            this.numericUpDownAngle.TabIndex = 15;
            // 
            // RunArcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.numericUpDownRadius);
            this.Controls.Add(this.radioButtonRight);
            this.Controls.Add(this.radioButtonLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "RunArcView";
            this.Size = new System.Drawing.Size(433, 118);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
    }
}
