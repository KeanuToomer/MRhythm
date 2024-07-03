namespace MRhythm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.triggerIntervalInput = new System.Windows.Forms.TextBox();
            this.triggerIntervalLabel = new System.Windows.Forms.Label();
            this.triggerClock = new System.Windows.Forms.Timer(this.components);
            this.triggerTotalInput = new System.Windows.Forms.TextBox();
            this.triggerDurationTime = new System.Windows.Forms.TextBox();
            this.triggerTotalLabel = new System.Windows.Forms.Label();
            this.triggerDurationLabel = new System.Windows.Forms.Label();
            this.triggerControl = new System.Windows.Forms.Button();
            this.durationLock = new System.Windows.Forms.RadioButton();
            this.triggerTotalLock = new System.Windows.Forms.RadioButton();
            this.targetApplicationInput = new System.Windows.Forms.ComboBox();
            this.applicationScanner = new System.Windows.Forms.Timer(this.components);
            this.setDefault = new System.Windows.Forms.Label();
            this.triggerIntervalUnitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // triggerIntervalInput
            // 
            this.triggerIntervalInput.Location = new System.Drawing.Point(30, 32);
            this.triggerIntervalInput.Name = "triggerIntervalInput";
            this.triggerIntervalInput.Size = new System.Drawing.Size(125, 27);
            this.triggerIntervalInput.TabIndex = 0;
            this.triggerIntervalInput.TextChanged += new System.EventHandler(this.TriggerIntervalInput_TextChanged);
            // 
            // triggerIntervalLabel
            // 
            this.triggerIntervalLabel.AutoSize = true;
            this.triggerIntervalLabel.Location = new System.Drawing.Point(30, 9);
            this.triggerIntervalLabel.Name = "triggerIntervalLabel";
            this.triggerIntervalLabel.Size = new System.Drawing.Size(109, 20);
            this.triggerIntervalLabel.TabIndex = 1;
            this.triggerIntervalLabel.Text = "Trigger interval";
            // 
            // triggerClock
            // 
            this.triggerClock.Tick += new System.EventHandler(this.TriggerClock_Tick);
            // 
            // triggerTotalInput
            // 
            this.triggerTotalInput.Location = new System.Drawing.Point(30, 87);
            this.triggerTotalInput.Name = "triggerTotalInput";
            this.triggerTotalInput.Size = new System.Drawing.Size(125, 27);
            this.triggerTotalInput.TabIndex = 2;
            this.triggerTotalInput.TextChanged += new System.EventHandler(this.TriggerTotalInput_TextChanged);
            // 
            // triggerDurationTime
            // 
            this.triggerDurationTime.Location = new System.Drawing.Point(30, 140);
            this.triggerDurationTime.Name = "triggerDurationTime";
            this.triggerDurationTime.Size = new System.Drawing.Size(125, 27);
            this.triggerDurationTime.TabIndex = 3;
            this.triggerDurationTime.TextChanged += new System.EventHandler(this.TriggerDurationTime_TextChanged);
            // 
            // triggerTotalLabel
            // 
            this.triggerTotalLabel.AutoSize = true;
            this.triggerTotalLabel.Location = new System.Drawing.Point(30, 61);
            this.triggerTotalLabel.Name = "triggerTotalLabel";
            this.triggerTotalLabel.Size = new System.Drawing.Size(136, 20);
            this.triggerTotalLabel.TabIndex = 4;
            this.triggerTotalLabel.Text = "Number of triggers";
            // 
            // triggerDurationLabel
            // 
            this.triggerDurationLabel.AutoSize = true;
            this.triggerDurationLabel.Location = new System.Drawing.Point(30, 117);
            this.triggerDurationLabel.Name = "triggerDurationLabel";
            this.triggerDurationLabel.Size = new System.Drawing.Size(116, 20);
            this.triggerDurationLabel.TabIndex = 5;
            this.triggerDurationLabel.Text = "Trigger duration";
            // 
            // triggerControl
            // 
            this.triggerControl.Location = new System.Drawing.Point(30, 217);
            this.triggerControl.Name = "triggerControl";
            this.triggerControl.Size = new System.Drawing.Size(125, 29);
            this.triggerControl.TabIndex = 6;
            this.triggerControl.Text = "Start";
            this.triggerControl.UseVisualStyleBackColor = true;
            this.triggerControl.Click += new System.EventHandler(this.TriggerControl_Click);
            // 
            // durationLock
            // 
            this.durationLock.AutoSize = true;
            this.durationLock.Location = new System.Drawing.Point(161, 145);
            this.durationLock.Name = "durationLock";
            this.durationLock.Size = new System.Drawing.Size(17, 16);
            this.durationLock.TabIndex = 7;
            this.durationLock.TabStop = true;
            this.durationLock.UseVisualStyleBackColor = true;
            // 
            // triggerTotalLock
            // 
            this.triggerTotalLock.AutoSize = true;
            this.triggerTotalLock.Location = new System.Drawing.Point(161, 90);
            this.triggerTotalLock.Name = "triggerTotalLock";
            this.triggerTotalLock.Size = new System.Drawing.Size(17, 16);
            this.triggerTotalLock.TabIndex = 8;
            this.triggerTotalLock.TabStop = true;
            this.triggerTotalLock.UseVisualStyleBackColor = true;
            // 
            // targetApplicationInput
            // 
            this.targetApplicationInput.FormattingEnabled = true;
            this.targetApplicationInput.Location = new System.Drawing.Point(30, 183);
            this.targetApplicationInput.Name = "targetApplicationInput";
            this.targetApplicationInput.Size = new System.Drawing.Size(151, 28);
            this.targetApplicationInput.TabIndex = 9;
            // 
            // applicationScanner
            // 
            this.applicationScanner.Tick += new System.EventHandler(this.ApplicationScanner_Tick);
            // 
            // setDefault
            // 
            this.setDefault.AutoSize = true;
            this.setDefault.Location = new System.Drawing.Point(188, 9);
            this.setDefault.Name = "setDefault";
            this.setDefault.Size = new System.Drawing.Size(64, 20);
            this.setDefault.TabIndex = 10;
            this.setDefault.Text = "Defaults";
            this.setDefault.Click += new System.EventHandler(this.SetDefault_Click);
            // 
            // triggerIntervalUnitLabel
            // 
            this.triggerIntervalUnitLabel.AutoSize = true;
            this.triggerIntervalUnitLabel.Location = new System.Drawing.Point(153, 41);
            this.triggerIntervalUnitLabel.Name = "triggerIntervalUnitLabel";
            this.triggerIntervalUnitLabel.Size = new System.Drawing.Size(28, 20);
            this.triggerIntervalUnitLabel.TabIndex = 11;
            this.triggerIntervalUnitLabel.Text = "ms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.triggerIntervalUnitLabel);
            this.Controls.Add(this.setDefault);
            this.Controls.Add(this.targetApplicationInput);
            this.Controls.Add(this.triggerTotalLock);
            this.Controls.Add(this.durationLock);
            this.Controls.Add(this.triggerControl);
            this.Controls.Add(this.triggerDurationLabel);
            this.Controls.Add(this.triggerTotalLabel);
            this.Controls.Add(this.triggerDurationTime);
            this.Controls.Add(this.triggerTotalInput);
            this.Controls.Add(this.triggerIntervalLabel);
            this.Controls.Add(this.triggerIntervalInput);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MRhythm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox triggerIntervalInput;
        private System.Windows.Forms.Label triggerIntervalLabel;
        private System.Windows.Forms.Timer triggerClock;
        private System.Windows.Forms.TextBox triggerTotalInput;
        private System.Windows.Forms.TextBox triggerDurationTime;
        private System.Windows.Forms.Label triggerTotalLabel;
        private System.Windows.Forms.Label triggerDurationLabel;
        private System.Windows.Forms.Button triggerControl;
        private System.Windows.Forms.RadioButton durationLock;
        private System.Windows.Forms.RadioButton triggerTotalLock;
        private System.Windows.Forms.ComboBox targetApplicationInput;
        private System.Windows.Forms.Timer applicationScanner;
        private System.Windows.Forms.Label setDefault;
        private System.Windows.Forms.Label triggerIntervalUnitLabel;
    }
}