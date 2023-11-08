namespace MetronomeTimer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblStart = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.trackBPM = new System.Windows.Forms.TrackBar();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.BPMnumUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblBPM = new System.Windows.Forms.Label();
            this.BPMlblMax = new System.Windows.Forms.Label();
            this.TimerNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimerStartCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PomoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPMnumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(75, 116);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(56, 16);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Let\'s Go";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(272, 23);
            this.textTitle.Name = "textTitle";
            this.textTitle.ReadOnly = true;
            this.textTitle.Size = new System.Drawing.Size(274, 38);
            this.textTitle.TabIndex = 3;
            this.textTitle.Text = "Pomodoro Metronome";
            this.textTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(629, 117);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(65, 16);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time Left:";
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBPM
            // 
            this.trackBPM.Location = new System.Drawing.Point(102, 188);
            this.trackBPM.Maximum = 200;
            this.trackBPM.Minimum = 50;
            this.trackBPM.Name = "trackBPM";
            this.trackBPM.Size = new System.Drawing.Size(573, 61);
            this.trackBPM.TabIndex = 8;
            this.trackBPM.Value = 50;
            this.trackBPM.Scroll += new System.EventHandler(this.trackBPM_Scroll);
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(78, 85);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(44, 26);
            this.checkBoxStart.TabIndex = 11;
            this.checkBoxStart.Text = "Start";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // BPMnumUpDown
            // 
            this.BPMnumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BPMnumUpDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BPMnumUpDown.Location = new System.Drawing.Point(374, 93);
            this.BPMnumUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BPMnumUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BPMnumUpDown.Name = "BPMnumUpDown";
            this.BPMnumUpDown.Size = new System.Drawing.Size(145, 69);
            this.BPMnumUpDown.TabIndex = 15;
            this.BPMnumUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BPMnumUpDown.ValueChanged += new System.EventHandler(this.BPMnumUpDown_ValueChanged);
            // 
            // lblBPM
            // 
            this.lblBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblBPM.Location = new System.Drawing.Point(198, 97);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBPM.Size = new System.Drawing.Size(170, 65);
            this.lblBPM.TabIndex = 16;
            this.lblBPM.Text = "BPM:";
            this.lblBPM.Click += new System.EventHandler(this.BPMlabel_Click);
            // 
            // BPMlblMax
            // 
            this.BPMlblMax.AutoSize = true;
            this.BPMlblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BPMlblMax.Location = new System.Drawing.Point(681, 177);
            this.BPMlblMax.Name = "BPMlblMax";
            this.BPMlblMax.Size = new System.Drawing.Size(81, 42);
            this.BPMlblMax.TabIndex = 17;
            this.BPMlblMax.Text = "200";
            // 
            // TimerNumUpDown
            // 
            this.TimerNumUpDown.Location = new System.Drawing.Point(700, 117);
            this.TimerNumUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.TimerNumUpDown.Name = "TimerNumUpDown";
            this.TimerNumUpDown.Size = new System.Drawing.Size(48, 22);
            this.TimerNumUpDown.TabIndex = 19;
            this.TimerNumUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimerNumUpDown.ValueChanged += new System.EventHandler(this.TimerNumUpDown_ValueChanged);
            // 
            // TimerStartCheck
            // 
            this.TimerStartCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.TimerStartCheck.AutoSize = true;
            this.TimerStartCheck.BackColor = System.Drawing.SystemColors.Control;
            this.TimerStartCheck.Location = new System.Drawing.Point(646, 85);
            this.TimerStartCheck.Name = "TimerStartCheck";
            this.TimerStartCheck.Size = new System.Drawing.Size(82, 26);
            this.TimerStartCheck.TabIndex = 20;
            this.TimerStartCheck.Text = "Start Timer";
            this.TimerStartCheck.UseVisualStyleBackColor = false;
            this.TimerStartCheck.CheckedChanged += new System.EventHandler(this.TimerStartCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(47, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "50";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // PomoTimer
            // 
            this.PomoTimer.Tick += new System.EventHandler(this.PomoTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerStartCheck);
            this.Controls.Add(this.TimerNumUpDown);
            this.Controls.Add(this.BPMlblMax);
            this.Controls.Add(this.lblBPM);
            this.Controls.Add(this.BPMnumUpDown);
            this.Controls.Add(this.checkBoxStart);
            this.Controls.Add(this.trackBPM);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.lblStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPMnumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TrackBar trackBPM;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.NumericUpDown BPMnumUpDown;
        private System.Windows.Forms.Label BPMlblMax;
        private System.Windows.Forms.NumericUpDown TimerNumUpDown;
        private System.Windows.Forms.CheckBox TimerStartCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer PomoTimer;
    }
}

