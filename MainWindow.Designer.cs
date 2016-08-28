namespace IPSW_Restorer
{
    partial class MainWindow
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
            this.stepOneLabel = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.labelStepTwo = new System.Windows.Forms.Label();
            this.basebandOption = new System.Windows.Forms.CheckBox();
            this.tssFromCydia = new System.Windows.Forms.CheckBox();
            this.latestFirmware = new System.Windows.Forms.CheckBox();
            this.fetchTSS = new System.Windows.Forms.CheckBox();
            this.limer4in = new System.Windows.Forms.CheckBox();
            this.fullyRestore = new System.Windows.Forms.CheckBox();
            this.stepThreeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.openIPSW = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // stepOneLabel
            // 
            this.stepOneLabel.AutoSize = true;
            this.stepOneLabel.Location = new System.Drawing.Point(12, 14);
            this.stepOneLabel.Name = "stepOneLabel";
            this.stepOneLabel.Size = new System.Drawing.Size(107, 13);
            this.stepOneLabel.TabIndex = 0;
            this.stepOneLabel.Text = "1. Select the ipsw file";
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(13, 30);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(295, 51);
            this.fileButton.TabIndex = 1;
            this.fileButton.Text = "Open";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // labelStepTwo
            // 
            this.labelStepTwo.AutoSize = true;
            this.labelStepTwo.Location = new System.Drawing.Point(10, 119);
            this.labelStepTwo.Name = "labelStepTwo";
            this.labelStepTwo.Size = new System.Drawing.Size(86, 13);
            this.labelStepTwo.TabIndex = 2;
            this.labelStepTwo.Text = "2. Select options";
            // 
            // basebandOption
            // 
            this.basebandOption.AutoSize = true;
            this.basebandOption.Location = new System.Drawing.Point(16, 135);
            this.basebandOption.Name = "basebandOption";
            this.basebandOption.Size = new System.Drawing.Size(126, 17);
            this.basebandOption.TabIndex = 3;
            this.basebandOption.Text = "No baseband update";
            this.basebandOption.UseVisualStyleBackColor = true;
            // 
            // tssFromCydia
            // 
            this.tssFromCydia.AutoSize = true;
            this.tssFromCydia.Location = new System.Drawing.Point(16, 158);
            this.tssFromCydia.Name = "tssFromCydia";
            this.tssFromCydia.Size = new System.Drawing.Size(163, 17);
            this.tssFromCydia.TabIndex = 4;
            this.tssFromCydia.Text = "TSS from cydia (Old devices)";
            this.tssFromCydia.UseVisualStyleBackColor = true;
            // 
            // latestFirmware
            // 
            this.latestFirmware.AutoSize = true;
            this.latestFirmware.Location = new System.Drawing.Point(16, 87);
            this.latestFirmware.Name = "latestFirmware";
            this.latestFirmware.Size = new System.Drawing.Size(146, 17);
            this.latestFirmware.TabIndex = 5;
            this.latestFirmware.Text = "Download latest iOS ipsw";
            this.latestFirmware.UseVisualStyleBackColor = true;
            // 
            // fetchTSS
            // 
            this.fetchTSS.AutoSize = true;
            this.fetchTSS.Location = new System.Drawing.Point(16, 181);
            this.fetchTSS.Name = "fetchTSS";
            this.fetchTSS.Size = new System.Drawing.Size(77, 17);
            this.fetchTSS.TabIndex = 6;
            this.fetchTSS.Text = "Fetch TSS";
            this.fetchTSS.UseVisualStyleBackColor = true;
            // 
            // limer4in
            // 
            this.limer4in.AutoSize = true;
            this.limer4in.Location = new System.Drawing.Point(16, 204);
            this.limer4in.Name = "limer4in";
            this.limer4in.Size = new System.Drawing.Size(130, 17);
            this.limer4in.TabIndex = 7;
            this.limer4in.Text = "Limer4in (Old devices)";
            this.limer4in.UseVisualStyleBackColor = true;
            // 
            // fullyRestore
            // 
            this.fullyRestore.AutoSize = true;
            this.fullyRestore.Location = new System.Drawing.Point(16, 228);
            this.fullyRestore.Name = "fullyRestore";
            this.fullyRestore.Size = new System.Drawing.Size(97, 17);
            this.fullyRestore.TabIndex = 8;
            this.fullyRestore.Text = "Format iDevice";
            this.fullyRestore.UseVisualStyleBackColor = true;
            // 
            // stepThreeLabel
            // 
            this.stepThreeLabel.AutoSize = true;
            this.stepThreeLabel.Location = new System.Drawing.Point(12, 262);
            this.stepThreeLabel.Name = "stepThreeLabel";
            this.stepThreeLabel.Size = new System.Drawing.Size(87, 13);
            this.stepThreeLabel.TabIndex = 9;
            this.stepThreeLabel.Text = "3. Perform action";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(191, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Download source code";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 366);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stepThreeLabel);
            this.Controls.Add(this.fullyRestore);
            this.Controls.Add(this.limer4in);
            this.Controls.Add(this.fetchTSS);
            this.Controls.Add(this.latestFirmware);
            this.Controls.Add(this.tssFromCydia);
            this.Controls.Add(this.basebandOption);
            this.Controls.Add(this.labelStepTwo);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.stepOneLabel);
            this.Name = "MainWindow";
            this.Text = "idevicerestore gui";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stepOneLabel;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label labelStepTwo;
        private System.Windows.Forms.CheckBox basebandOption;
        private System.Windows.Forms.CheckBox tssFromCydia;
        private System.Windows.Forms.CheckBox latestFirmware;
        private System.Windows.Forms.CheckBox fetchTSS;
        private System.Windows.Forms.CheckBox limer4in;
        private System.Windows.Forms.CheckBox fullyRestore;
        private System.Windows.Forms.Label stepThreeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.OpenFileDialog openIPSW;
    }
}

