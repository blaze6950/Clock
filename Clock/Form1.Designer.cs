namespace Clock
{
    partial class ClockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            this.panel = new System.Windows.Forms.Panel();
            this.startStopButton = new System.Windows.Forms.Button();
            this.clockStyleGB = new System.Windows.Forms.GroupBox();
            this.classicRB = new System.Windows.Forms.RadioButton();
            this.standartRB = new System.Windows.Forms.RadioButton();
            this.handStyleGB = new System.Windows.Forms.GroupBox();
            this.sharpRB = new System.Windows.Forms.RadioButton();
            this.uniformRB = new System.Windows.Forms.RadioButton();
            this.ticksLabel = new System.Windows.Forms.Label();
            this.ticksCB = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateCB = new System.Windows.Forms.ComboBox();
            this.numbersCB = new System.Windows.Forms.ComboBox();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.innerColorButton = new System.Windows.Forms.Button();
            this.habdColorButton = new System.Windows.Forms.Button();
            this.tickColorButton = new System.Windows.Forms.Button();
            this.outerColorButton = new System.Windows.Forms.Button();
            this.secHandColorButton = new System.Windows.Forms.Button();
            this.textColorButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.captionTB = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.clockStyleGB.SuspendLayout();
            this.handStyleGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(183, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(326, 326);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(13, 13);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(143, 23);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "Start / Stop";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // clockStyleGB
            // 
            this.clockStyleGB.Controls.Add(this.classicRB);
            this.clockStyleGB.Controls.Add(this.standartRB);
            this.clockStyleGB.Location = new System.Drawing.Point(13, 43);
            this.clockStyleGB.Name = "clockStyleGB";
            this.clockStyleGB.Size = new System.Drawing.Size(143, 46);
            this.clockStyleGB.TabIndex = 2;
            this.clockStyleGB.TabStop = false;
            this.clockStyleGB.Text = "Clock Style";
            // 
            // classicRB
            // 
            this.classicRB.AutoSize = true;
            this.classicRB.Location = new System.Drawing.Point(79, 20);
            this.classicRB.Name = "classicRB";
            this.classicRB.Size = new System.Drawing.Size(58, 17);
            this.classicRB.TabIndex = 1;
            this.classicRB.Text = "Classic";
            this.classicRB.UseVisualStyleBackColor = true;
            // 
            // standartRB
            // 
            this.standartRB.AutoSize = true;
            this.standartRB.Checked = true;
            this.standartRB.Location = new System.Drawing.Point(7, 20);
            this.standartRB.Name = "standartRB";
            this.standartRB.Size = new System.Drawing.Size(65, 17);
            this.standartRB.TabIndex = 0;
            this.standartRB.TabStop = true;
            this.standartRB.Text = "Standart";
            this.standartRB.UseVisualStyleBackColor = true;
            this.standartRB.CheckedChanged += new System.EventHandler(this.standartRB_CheckedChanged);
            // 
            // handStyleGB
            // 
            this.handStyleGB.Controls.Add(this.sharpRB);
            this.handStyleGB.Controls.Add(this.uniformRB);
            this.handStyleGB.Location = new System.Drawing.Point(13, 96);
            this.handStyleGB.Name = "handStyleGB";
            this.handStyleGB.Size = new System.Drawing.Size(143, 46);
            this.handStyleGB.TabIndex = 3;
            this.handStyleGB.TabStop = false;
            this.handStyleGB.Text = "Hand Style";
            // 
            // sharpRB
            // 
            this.sharpRB.AutoSize = true;
            this.sharpRB.Location = new System.Drawing.Point(75, 20);
            this.sharpRB.Name = "sharpRB";
            this.sharpRB.Size = new System.Drawing.Size(53, 17);
            this.sharpRB.TabIndex = 1;
            this.sharpRB.Text = "Sharp";
            this.sharpRB.UseVisualStyleBackColor = true;
            // 
            // uniformRB
            // 
            this.uniformRB.AutoSize = true;
            this.uniformRB.Checked = true;
            this.uniformRB.Location = new System.Drawing.Point(7, 20);
            this.uniformRB.Name = "uniformRB";
            this.uniformRB.Size = new System.Drawing.Size(61, 17);
            this.uniformRB.TabIndex = 0;
            this.uniformRB.TabStop = true;
            this.uniformRB.Text = "Uniform";
            this.uniformRB.UseVisualStyleBackColor = true;
            this.uniformRB.CheckedChanged += new System.EventHandler(this.uniformRB_CheckedChanged);
            // 
            // ticksLabel
            // 
            this.ticksLabel.AutoSize = true;
            this.ticksLabel.Location = new System.Drawing.Point(12, 151);
            this.ticksLabel.Name = "ticksLabel";
            this.ticksLabel.Size = new System.Drawing.Size(36, 13);
            this.ticksLabel.TabIndex = 4;
            this.ticksLabel.Text = "Ticks:";
            // 
            // ticksCB
            // 
            this.ticksCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticksCB.FormattingEnabled = true;
            this.ticksCB.Location = new System.Drawing.Point(65, 148);
            this.ticksCB.Name = "ticksCB";
            this.ticksCB.Size = new System.Drawing.Size(91, 21);
            this.ticksCB.TabIndex = 5;
            this.ticksCB.SelectedIndexChanged += new System.EventHandler(this.ticksCB_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 179);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date:";
            // 
            // dateCB
            // 
            this.dateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateCB.FormattingEnabled = true;
            this.dateCB.Location = new System.Drawing.Point(65, 176);
            this.dateCB.Name = "dateCB";
            this.dateCB.Size = new System.Drawing.Size(91, 21);
            this.dateCB.TabIndex = 7;
            this.dateCB.SelectedIndexChanged += new System.EventHandler(this.dateCB_SelectedIndexChanged);
            // 
            // numbersCB
            // 
            this.numbersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numbersCB.FormattingEnabled = true;
            this.numbersCB.Location = new System.Drawing.Point(65, 204);
            this.numbersCB.Name = "numbersCB";
            this.numbersCB.Size = new System.Drawing.Size(91, 21);
            this.numbersCB.TabIndex = 8;
            this.numbersCB.SelectedIndexChanged += new System.EventHandler(this.numbersCB_SelectedIndexChanged);
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Location = new System.Drawing.Point(12, 207);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(52, 13);
            this.numbersLabel.TabIndex = 9;
            this.numbersLabel.Text = "Numbers:";
            // 
            // innerColorButton
            // 
            this.innerColorButton.Location = new System.Drawing.Point(13, 231);
            this.innerColorButton.Name = "innerColorButton";
            this.innerColorButton.Size = new System.Drawing.Size(75, 23);
            this.innerColorButton.TabIndex = 10;
            this.innerColorButton.Text = "InnerColor";
            this.innerColorButton.UseVisualStyleBackColor = true;
            this.innerColorButton.Click += new System.EventHandler(this.innerColorButton_Click);
            // 
            // habdColorButton
            // 
            this.habdColorButton.Location = new System.Drawing.Point(13, 261);
            this.habdColorButton.Name = "habdColorButton";
            this.habdColorButton.Size = new System.Drawing.Size(75, 23);
            this.habdColorButton.TabIndex = 11;
            this.habdColorButton.Text = "HandColor";
            this.habdColorButton.UseVisualStyleBackColor = true;
            this.habdColorButton.Click += new System.EventHandler(this.habdColorButton_Click);
            // 
            // tickColorButton
            // 
            this.tickColorButton.Location = new System.Drawing.Point(13, 291);
            this.tickColorButton.Name = "tickColorButton";
            this.tickColorButton.Size = new System.Drawing.Size(75, 23);
            this.tickColorButton.TabIndex = 12;
            this.tickColorButton.Text = "TickColor";
            this.tickColorButton.UseVisualStyleBackColor = true;
            this.tickColorButton.Click += new System.EventHandler(this.tickColorButton_Click);
            // 
            // outerColorButton
            // 
            this.outerColorButton.Location = new System.Drawing.Point(92, 231);
            this.outerColorButton.Name = "outerColorButton";
            this.outerColorButton.Size = new System.Drawing.Size(75, 23);
            this.outerColorButton.TabIndex = 13;
            this.outerColorButton.Text = "OuterColor";
            this.outerColorButton.UseVisualStyleBackColor = true;
            this.outerColorButton.Click += new System.EventHandler(this.outerColorButton_Click);
            // 
            // secHandColorButton
            // 
            this.secHandColorButton.Location = new System.Drawing.Point(92, 261);
            this.secHandColorButton.Name = "secHandColorButton";
            this.secHandColorButton.Size = new System.Drawing.Size(75, 23);
            this.secHandColorButton.TabIndex = 14;
            this.secHandColorButton.Text = "SecHandCol";
            this.secHandColorButton.UseVisualStyleBackColor = true;
            this.secHandColorButton.Click += new System.EventHandler(this.secHandColorButton_Click);
            // 
            // textColorButton
            // 
            this.textColorButton.Location = new System.Drawing.Point(92, 291);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(75, 23);
            this.textColorButton.TabIndex = 15;
            this.textColorButton.Text = "TextColor";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Caption:";
            // 
            // captionTB
            // 
            this.captionTB.Location = new System.Drawing.Point(67, 318);
            this.captionTB.Name = "captionTB";
            this.captionTB.Size = new System.Drawing.Size(100, 20);
            this.captionTB.TabIndex = 17;
            this.captionTB.TextChanged += new System.EventHandler(this.captionTB_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 350);
            this.Controls.Add(this.captionTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textColorButton);
            this.Controls.Add(this.secHandColorButton);
            this.Controls.Add(this.outerColorButton);
            this.Controls.Add(this.tickColorButton);
            this.Controls.Add(this.habdColorButton);
            this.Controls.Add(this.innerColorButton);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.numbersCB);
            this.Controls.Add(this.dateCB);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.ticksCB);
            this.Controls.Add(this.ticksLabel);
            this.Controls.Add(this.handStyleGB);
            this.Controls.Add(this.clockStyleGB);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClockForm";
            this.Text = "Clock";
            this.clockStyleGB.ResumeLayout(false);
            this.clockStyleGB.PerformLayout();
            this.handStyleGB.ResumeLayout(false);
            this.handStyleGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.GroupBox clockStyleGB;
        private System.Windows.Forms.RadioButton classicRB;
        private System.Windows.Forms.RadioButton standartRB;
        private System.Windows.Forms.GroupBox handStyleGB;
        private System.Windows.Forms.RadioButton sharpRB;
        private System.Windows.Forms.RadioButton uniformRB;
        private System.Windows.Forms.Label ticksLabel;
        private System.Windows.Forms.ComboBox ticksCB;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox dateCB;
        private System.Windows.Forms.ComboBox numbersCB;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Button innerColorButton;
        private System.Windows.Forms.Button habdColorButton;
        private System.Windows.Forms.Button tickColorButton;
        private System.Windows.Forms.Button outerColorButton;
        private System.Windows.Forms.Button secHandColorButton;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox captionTB;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

