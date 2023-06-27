namespace pattern_maker
{
    partial class FormProjectSetup
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
            this.newProjectInfo = new System.Windows.Forms.GroupBox();
            this.radioCentimeters = new System.Windows.Forms.RadioButton();
            this.radioInches = new System.Windows.Forms.RadioButton();
            this.labelGaugeIn = new System.Windows.Forms.Label();
            this.numericGaugeMeasurementH = new System.Windows.Forms.NumericUpDown();
            this.labelGaugeMeasurementX = new System.Windows.Forms.Label();
            this.numericGaugeMeasurementW = new System.Windows.Forms.NumericUpDown();
            this.labelStitches = new System.Windows.Forms.Label();
            this.numericGaugeStitchesH = new System.Windows.Forms.NumericUpDown();
            this.labelGaugeStitchesX = new System.Windows.Forms.Label();
            this.labelGauge = new System.Windows.Forms.Label();
            this.numericGaugeStitchesW = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelYarn = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.textProjectName = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.newProjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeMeasurementH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeMeasurementW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeStitchesH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeStitchesW)).BeginInit();
            this.SuspendLayout();
            // 
            // newProjectInfo
            // 
            this.newProjectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProjectInfo.AutoSize = true;
            this.newProjectInfo.Controls.Add(this.buttonCreate);
            this.newProjectInfo.Controls.Add(this.radioCentimeters);
            this.newProjectInfo.Controls.Add(this.radioInches);
            this.newProjectInfo.Controls.Add(this.labelGaugeIn);
            this.newProjectInfo.Controls.Add(this.numericGaugeMeasurementH);
            this.newProjectInfo.Controls.Add(this.labelGaugeMeasurementX);
            this.newProjectInfo.Controls.Add(this.numericGaugeMeasurementW);
            this.newProjectInfo.Controls.Add(this.labelStitches);
            this.newProjectInfo.Controls.Add(this.numericGaugeStitchesH);
            this.newProjectInfo.Controls.Add(this.labelGaugeStitchesX);
            this.newProjectInfo.Controls.Add(this.labelGauge);
            this.newProjectInfo.Controls.Add(this.numericGaugeStitchesW);
            this.newProjectInfo.Controls.Add(this.textBox1);
            this.newProjectInfo.Controls.Add(this.labelYarn);
            this.newProjectInfo.Controls.Add(this.labelProjectName);
            this.newProjectInfo.Controls.Add(this.textProjectName);
            this.newProjectInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProjectInfo.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProjectInfo.ForeColor = System.Drawing.Color.Gray;
            this.newProjectInfo.Location = new System.Drawing.Point(30, 30);
            this.newProjectInfo.Name = "newProjectInfo";
            this.newProjectInfo.Size = new System.Drawing.Size(793, 293);
            this.newProjectInfo.TabIndex = 0;
            this.newProjectInfo.TabStop = false;
            this.newProjectInfo.Text = "New Project";
            this.newProjectInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioCentimeters
            // 
            this.radioCentimeters.AutoSize = true;
            this.radioCentimeters.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioCentimeters.Location = new System.Drawing.Point(636, 136);
            this.radioCentimeters.Margin = new System.Windows.Forms.Padding(5);
            this.radioCentimeters.Name = "radioCentimeters";
            this.radioCentimeters.Size = new System.Drawing.Size(130, 27);
            this.radioCentimeters.TabIndex = 14;
            this.radioCentimeters.Text = "Centimeters";
            this.radioCentimeters.UseVisualStyleBackColor = true;
            // 
            // radioInches
            // 
            this.radioInches.AutoSize = true;
            this.radioInches.Checked = true;
            this.radioInches.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioInches.Location = new System.Drawing.Point(541, 133);
            this.radioInches.Margin = new System.Windows.Forms.Padding(5);
            this.radioInches.Name = "radioInches";
            this.radioInches.Size = new System.Drawing.Size(85, 27);
            this.radioInches.TabIndex = 13;
            this.radioInches.TabStop = true;
            this.radioInches.Text = "Inches";
            this.radioInches.UseVisualStyleBackColor = true;
            // 
            // labelGaugeIn
            // 
            this.labelGaugeIn.AutoSize = true;
            this.labelGaugeIn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelGaugeIn.Location = new System.Drawing.Point(372, 108);
            this.labelGaugeIn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelGaugeIn.Name = "labelGaugeIn";
            this.labelGaugeIn.Size = new System.Drawing.Size(27, 23);
            this.labelGaugeIn.TabIndex = 12;
            this.labelGaugeIn.Text = "In";
            // 
            // numericGaugeMeasurementH
            // 
            this.numericGaugeMeasurementH.AllowDrop = true;
            this.numericGaugeMeasurementH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericGaugeMeasurementH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numericGaugeMeasurementH.Location = new System.Drawing.Point(476, 136);
            this.numericGaugeMeasurementH.Margin = new System.Windows.Forms.Padding(10);
            this.numericGaugeMeasurementH.Name = "numericGaugeMeasurementH";
            this.numericGaugeMeasurementH.Size = new System.Drawing.Size(50, 27);
            this.numericGaugeMeasurementH.TabIndex = 11;
            this.numericGaugeMeasurementH.ValueChanged += new System.EventHandler(this.numericGaugeMeasurementH_ValueChanged);
            // 
            // labelGaugeMeasurementX
            // 
            this.labelGaugeMeasurementX.AutoSize = true;
            this.labelGaugeMeasurementX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelGaugeMeasurementX.Location = new System.Drawing.Point(437, 135);
            this.labelGaugeMeasurementX.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.labelGaugeMeasurementX.Name = "labelGaugeMeasurementX";
            this.labelGaugeMeasurementX.Size = new System.Drawing.Size(19, 23);
            this.labelGaugeMeasurementX.TabIndex = 10;
            this.labelGaugeMeasurementX.Text = "x";
            // 
            // numericGaugeMeasurementW
            // 
            this.numericGaugeMeasurementW.AllowDrop = true;
            this.numericGaugeMeasurementW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericGaugeMeasurementW.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numericGaugeMeasurementW.Location = new System.Drawing.Point(372, 136);
            this.numericGaugeMeasurementW.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.numericGaugeMeasurementW.Name = "numericGaugeMeasurementW";
            this.numericGaugeMeasurementW.Size = new System.Drawing.Size(50, 27);
            this.numericGaugeMeasurementW.TabIndex = 9;
            // 
            // labelStitches
            // 
            this.labelStitches.AutoSize = true;
            this.labelStitches.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelStitches.Location = new System.Drawing.Point(541, 76);
            this.labelStitches.Margin = new System.Windows.Forms.Padding(5);
            this.labelStitches.Name = "labelStitches";
            this.labelStitches.Size = new System.Drawing.Size(72, 23);
            this.labelStitches.TabIndex = 8;
            this.labelStitches.Text = "Stitches";
            this.labelStitches.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericGaugeStitchesH
            // 
            this.numericGaugeStitchesH.AllowDrop = true;
            this.numericGaugeStitchesH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericGaugeStitchesH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numericGaugeStitchesH.Location = new System.Drawing.Point(476, 76);
            this.numericGaugeStitchesH.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.numericGaugeStitchesH.Name = "numericGaugeStitchesH";
            this.numericGaugeStitchesH.Size = new System.Drawing.Size(50, 27);
            this.numericGaugeStitchesH.TabIndex = 7;
            this.numericGaugeStitchesH.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelGaugeStitchesX
            // 
            this.labelGaugeStitchesX.AutoSize = true;
            this.labelGaugeStitchesX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelGaugeStitchesX.Location = new System.Drawing.Point(437, 75);
            this.labelGaugeStitchesX.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.labelGaugeStitchesX.Name = "labelGaugeStitchesX";
            this.labelGaugeStitchesX.Size = new System.Drawing.Size(19, 23);
            this.labelGaugeStitchesX.TabIndex = 6;
            this.labelGaugeStitchesX.Text = "x";
            this.labelGaugeStitchesX.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelGauge
            // 
            this.labelGauge.AutoSize = true;
            this.labelGauge.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelGauge.Location = new System.Drawing.Point(372, 43);
            this.labelGauge.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.labelGauge.Name = "labelGauge";
            this.labelGauge.Size = new System.Drawing.Size(63, 23);
            this.labelGauge.TabIndex = 5;
            this.labelGauge.Text = "Gauge";
            // 
            // numericGaugeStitchesW
            // 
            this.numericGaugeStitchesW.AllowDrop = true;
            this.numericGaugeStitchesW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericGaugeStitchesW.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numericGaugeStitchesW.Location = new System.Drawing.Point(372, 76);
            this.numericGaugeStitchesW.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.numericGaugeStitchesW.Name = "numericGaugeStitchesW";
            this.numericGaugeStitchesW.Size = new System.Drawing.Size(50, 27);
            this.numericGaugeStitchesW.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(13, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 24);
            this.textBox1.TabIndex = 3;
            // 
            // labelYarn
            // 
            this.labelYarn.AutoSize = true;
            this.labelYarn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelYarn.Location = new System.Drawing.Point(13, 108);
            this.labelYarn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.labelYarn.Name = "labelYarn";
            this.labelYarn.Size = new System.Drawing.Size(48, 23);
            this.labelYarn.TabIndex = 2;
            this.labelYarn.Text = "Yarn";
            this.labelYarn.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelProjectName.Location = new System.Drawing.Point(13, 43);
            this.labelProjectName.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(118, 23);
            this.labelProjectName.TabIndex = 1;
            this.labelProjectName.Text = "Project Name";
            // 
            // textProjectName
            // 
            this.textProjectName.BackColor = System.Drawing.Color.White;
            this.textProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProjectName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textProjectName.Location = new System.Drawing.Point(13, 76);
            this.textProjectName.Margin = new System.Windows.Forms.Padding(10);
            this.textProjectName.Name = "textProjectName";
            this.textProjectName.Size = new System.Drawing.Size(280, 24);
            this.textProjectName.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCreate.Location = new System.Drawing.Point(611, 221);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(155, 42);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // FormProjectSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(862, 335);
            this.Controls.Add(this.newProjectInfo);
            this.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProjectSetup";
            this.Text = "Project Setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newProjectInfo.ResumeLayout(false);
            this.newProjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeMeasurementH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeMeasurementW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeStitchesH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaugeStitchesW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox newProjectInfo;
        private System.Windows.Forms.Label labelYarn;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.TextBox textProjectName;
        private System.Windows.Forms.Label labelGaugeStitchesX;
        private System.Windows.Forms.Label labelGauge;
        private System.Windows.Forms.NumericUpDown numericGaugeStitchesW;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericGaugeStitchesH;
        private System.Windows.Forms.Label labelStitches;
        private System.Windows.Forms.NumericUpDown numericGaugeMeasurementH;
        private System.Windows.Forms.Label labelGaugeMeasurementX;
        private System.Windows.Forms.NumericUpDown numericGaugeMeasurementW;
        private System.Windows.Forms.Label labelGaugeIn;
        private System.Windows.Forms.RadioButton radioInches;
        private System.Windows.Forms.RadioButton radioCentimeters;
        private System.Windows.Forms.Button buttonCreate;
    }
}

