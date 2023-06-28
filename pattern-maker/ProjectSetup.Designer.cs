namespace pattern_maker
{
    partial class NewProject
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
            this.grpNewProjectInfo = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.radCentimeters = new System.Windows.Forms.RadioButton();
            this.radInches = new System.Windows.Forms.RadioButton();
            this.lbGaugeIn = new System.Windows.Forms.Label();
            this.numGaugeMeasurementH = new System.Windows.Forms.NumericUpDown();
            this.lblGaugeMeasurementX = new System.Windows.Forms.Label();
            this.numGaugeMeasurementW = new System.Windows.Forms.NumericUpDown();
            this.lblStitches = new System.Windows.Forms.Label();
            this.numGaugeStitchesH = new System.Windows.Forms.NumericUpDown();
            this.lblGaugeStitchesX = new System.Windows.Forms.Label();
            this.lblGauge = new System.Windows.Forms.Label();
            this.numGaugeStitchesW = new System.Windows.Forms.NumericUpDown();
            this.txtYarn = new System.Windows.Forms.TextBox();
            this.lblYarn = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.saveFileDialogNewProject = new System.Windows.Forms.SaveFileDialog();
            this.grpNewProjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeMeasurementH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeMeasurementW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeStitchesH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeStitchesW)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewProjectInfo
            // 
            this.grpNewProjectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNewProjectInfo.Controls.Add(this.btnCreate);
            this.grpNewProjectInfo.Controls.Add(this.radCentimeters);
            this.grpNewProjectInfo.Controls.Add(this.radInches);
            this.grpNewProjectInfo.Controls.Add(this.lbGaugeIn);
            this.grpNewProjectInfo.Controls.Add(this.numGaugeMeasurementH);
            this.grpNewProjectInfo.Controls.Add(this.lblGaugeMeasurementX);
            this.grpNewProjectInfo.Controls.Add(this.numGaugeMeasurementW);
            this.grpNewProjectInfo.Controls.Add(this.lblStitches);
            this.grpNewProjectInfo.Controls.Add(this.numGaugeStitchesH);
            this.grpNewProjectInfo.Controls.Add(this.lblGaugeStitchesX);
            this.grpNewProjectInfo.Controls.Add(this.lblGauge);
            this.grpNewProjectInfo.Controls.Add(this.numGaugeStitchesW);
            this.grpNewProjectInfo.Controls.Add(this.txtYarn);
            this.grpNewProjectInfo.Controls.Add(this.lblYarn);
            this.grpNewProjectInfo.Controls.Add(this.lblProjectName);
            this.grpNewProjectInfo.Controls.Add(this.txtProjectName);
            this.grpNewProjectInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpNewProjectInfo.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewProjectInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(67)))));
            this.grpNewProjectInfo.Location = new System.Drawing.Point(30, 30);
            this.grpNewProjectInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.grpNewProjectInfo.MaximumSize = new System.Drawing.Size(790, 300);
            this.grpNewProjectInfo.MinimumSize = new System.Drawing.Size(790, 300);
            this.grpNewProjectInfo.Name = "grpNewProjectInfo";
            this.grpNewProjectInfo.Size = new System.Drawing.Size(790, 300);
            this.grpNewProjectInfo.TabIndex = 0;
            this.grpNewProjectInfo.TabStop = false;
            this.grpNewProjectInfo.Text = "New Project";
            // 
            // btnCreate
            // 
            this.btnCreate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCreate.Location = new System.Drawing.Point(611, 221);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 65);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // radCentimeters
            // 
            this.radCentimeters.AutoSize = true;
            this.radCentimeters.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radCentimeters.Location = new System.Drawing.Point(636, 136);
            this.radCentimeters.Margin = new System.Windows.Forms.Padding(5);
            this.radCentimeters.Name = "radCentimeters";
            this.radCentimeters.Size = new System.Drawing.Size(145, 34);
            this.radCentimeters.TabIndex = 14;
            this.radCentimeters.Text = "Centimeters";
            this.radCentimeters.UseVisualStyleBackColor = true;
            // 
            // radInches
            // 
            this.radInches.AutoSize = true;
            this.radInches.Checked = true;
            this.radInches.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radInches.Location = new System.Drawing.Point(541, 133);
            this.radInches.Margin = new System.Windows.Forms.Padding(5);
            this.radInches.Name = "radInches";
            this.radInches.Size = new System.Drawing.Size(92, 34);
            this.radInches.TabIndex = 13;
            this.radInches.TabStop = true;
            this.radInches.Text = "Inches";
            this.radInches.UseVisualStyleBackColor = true;
            // 
            // lbGaugeIn
            // 
            this.lbGaugeIn.AutoSize = true;
            this.lbGaugeIn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbGaugeIn.Location = new System.Drawing.Point(372, 108);
            this.lbGaugeIn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbGaugeIn.Name = "lbGaugeIn";
            this.lbGaugeIn.Size = new System.Drawing.Size(30, 30);
            this.lbGaugeIn.TabIndex = 12;
            this.lbGaugeIn.Text = "In";
            // 
            // numGaugeMeasurementH
            // 
            this.numGaugeMeasurementH.AllowDrop = true;
            this.numGaugeMeasurementH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numGaugeMeasurementH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numGaugeMeasurementH.Location = new System.Drawing.Point(476, 136);
            this.numGaugeMeasurementH.Margin = new System.Windows.Forms.Padding(10);
            this.numGaugeMeasurementH.Name = "numGaugeMeasurementH";
            this.numGaugeMeasurementH.Size = new System.Drawing.Size(50, 28);
            this.numGaugeMeasurementH.TabIndex = 11;
            // 
            // lblGaugeMeasurementX
            // 
            this.lblGaugeMeasurementX.AutoSize = true;
            this.lblGaugeMeasurementX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblGaugeMeasurementX.Location = new System.Drawing.Point(437, 135);
            this.lblGaugeMeasurementX.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblGaugeMeasurementX.Name = "lblGaugeMeasurementX";
            this.lblGaugeMeasurementX.Size = new System.Drawing.Size(23, 30);
            this.lblGaugeMeasurementX.TabIndex = 10;
            this.lblGaugeMeasurementX.Text = "x";
            // 
            // numGaugeMeasurementW
            // 
            this.numGaugeMeasurementW.AllowDrop = true;
            this.numGaugeMeasurementW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numGaugeMeasurementW.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numGaugeMeasurementW.Location = new System.Drawing.Point(372, 136);
            this.numGaugeMeasurementW.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.numGaugeMeasurementW.Name = "numGaugeMeasurementW";
            this.numGaugeMeasurementW.Size = new System.Drawing.Size(50, 28);
            this.numGaugeMeasurementW.TabIndex = 9;
            // 
            // lblStitches
            // 
            this.lblStitches.AutoSize = true;
            this.lblStitches.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblStitches.Location = new System.Drawing.Point(541, 76);
            this.lblStitches.Margin = new System.Windows.Forms.Padding(5);
            this.lblStitches.Name = "lblStitches";
            this.lblStitches.Size = new System.Drawing.Size(83, 30);
            this.lblStitches.TabIndex = 8;
            this.lblStitches.Text = "Stitches";
            // 
            // numGaugeStitchesH
            // 
            this.numGaugeStitchesH.AllowDrop = true;
            this.numGaugeStitchesH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numGaugeStitchesH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numGaugeStitchesH.Location = new System.Drawing.Point(476, 76);
            this.numGaugeStitchesH.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.numGaugeStitchesH.Name = "numGaugeStitchesH";
            this.numGaugeStitchesH.Size = new System.Drawing.Size(50, 28);
            this.numGaugeStitchesH.TabIndex = 7;
            // 
            // lblGaugeStitchesX
            // 
            this.lblGaugeStitchesX.AutoSize = true;
            this.lblGaugeStitchesX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblGaugeStitchesX.Location = new System.Drawing.Point(437, 75);
            this.lblGaugeStitchesX.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblGaugeStitchesX.Name = "lblGaugeStitchesX";
            this.lblGaugeStitchesX.Size = new System.Drawing.Size(23, 30);
            this.lblGaugeStitchesX.TabIndex = 6;
            this.lblGaugeStitchesX.Text = "x";
            // 
            // lblGauge
            // 
            this.lblGauge.AutoSize = true;
            this.lblGauge.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblGauge.Location = new System.Drawing.Point(372, 43);
            this.lblGauge.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblGauge.Name = "lblGauge";
            this.lblGauge.Size = new System.Drawing.Size(73, 30);
            this.lblGauge.TabIndex = 5;
            this.lblGauge.Text = "Gauge";
            // 
            // numGaugeStitchesW
            // 
            this.numGaugeStitchesW.AllowDrop = true;
            this.numGaugeStitchesW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numGaugeStitchesW.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numGaugeStitchesW.Location = new System.Drawing.Point(372, 76);
            this.numGaugeStitchesW.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.numGaugeStitchesW.Name = "numGaugeStitchesW";
            this.numGaugeStitchesW.Size = new System.Drawing.Size(50, 28);
            this.numGaugeStitchesW.TabIndex = 4;
            // 
            // txtYarn
            // 
            this.txtYarn.BackColor = System.Drawing.Color.White;
            this.txtYarn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYarn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtYarn.Location = new System.Drawing.Point(13, 139);
            this.txtYarn.Margin = new System.Windows.Forms.Padding(10);
            this.txtYarn.Name = "txtYarn";
            this.txtYarn.Size = new System.Drawing.Size(280, 25);
            this.txtYarn.TabIndex = 3;
            // 
            // lblYarn
            // 
            this.lblYarn.AutoSize = true;
            this.lblYarn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblYarn.Location = new System.Drawing.Point(13, 108);
            this.lblYarn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblYarn.Name = "lblYarn";
            this.lblYarn.Size = new System.Drawing.Size(55, 30);
            this.lblYarn.TabIndex = 2;
            this.lblYarn.Text = "Yarn";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblProjectName.Location = new System.Drawing.Point(13, 43);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(139, 30);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.White;
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtProjectName.Location = new System.Drawing.Point(13, 76);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(10);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(280, 25);
            this.txtProjectName.TabIndex = 0;
            // 
            // saveFileDialogNewProject
            // 
            this.saveFileDialogNewProject.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogNewProject_FileOk);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(862, 363);
            this.Controls.Add(this.grpNewProjectInfo);
            this.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewProject";
            this.Text = "Pattern Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNewProjectInfo.ResumeLayout(false);
            this.grpNewProjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeMeasurementH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeMeasurementW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeStitchesH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaugeStitchesW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewProjectInfo;
        private System.Windows.Forms.Label lblYarn;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblGaugeStitchesX;
        private System.Windows.Forms.Label lblGauge;
        private System.Windows.Forms.NumericUpDown numGaugeStitchesW;
        private System.Windows.Forms.TextBox txtYarn;
        private System.Windows.Forms.NumericUpDown numGaugeStitchesH;
        private System.Windows.Forms.Label lblStitches;
        private System.Windows.Forms.NumericUpDown numGaugeMeasurementH;
        private System.Windows.Forms.Label lblGaugeMeasurementX;
        private System.Windows.Forms.Label lbGaugeIn;
        private System.Windows.Forms.RadioButton radInches;
        private System.Windows.Forms.RadioButton radCentimeters;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.SaveFileDialog saveFileDialogNewProject;
        public System.Windows.Forms.NumericUpDown numGaugeMeasurementW;
    }
}

