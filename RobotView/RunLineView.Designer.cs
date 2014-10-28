namespace Hslu.Csa.Team6.RobotView
{
    partial class RunLineView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "RunLine";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.Text = "Length (+/- mm)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "+/-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownLength.Location = new System.Drawing.Point(202, 38);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(100, 24);
            this.numericUpDownLength.TabIndex = 7;
            this.numericUpDownLength.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLength.ValueChanged += new System.EventHandler(this.numericUpDownLength_ValueChanged);
            // 
            // RunLineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RunLineView";
            this.Size = new System.Drawing.Size(389, 84);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
    }
}
