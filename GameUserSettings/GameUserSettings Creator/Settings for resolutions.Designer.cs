namespace GameUserSettings_Creator
{
    partial class Settings_for_resolutions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_for_resolutions));
            this.btn_Search = new System.Windows.Forms.Button();
            this.OpenFolderD = new System.Windows.Forms.OpenFileDialog();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lblMonitorName = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.txtResX = new System.Windows.Forms.TextBox();
            this.txtResY = new System.Windows.Forms.TextBox();
            this.lblNewResolution = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(12, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search file";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // OpenFolderD
            // 
            this.OpenFolderD.FileName = "Settings User";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(95, 38);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(16, 13);
            this.lblMonitor.TabIndex = 2;
            this.lblMonitor.Text = "...";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(12, 146);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update my settings";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lblMonitorName
            // 
            this.lblMonitorName.AutoSize = true;
            this.lblMonitorName.Location = new System.Drawing.Point(14, 38);
            this.lblMonitorName.Name = "lblMonitorName";
            this.lblMonitorName.Size = new System.Drawing.Size(76, 13);
            this.lblMonitorName.TabIndex = 4;
            this.lblMonitorName.Text = "Monitor Name:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(117, 51);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(16, 13);
            this.lblRes.TabIndex = 5;
            this.lblRes.Text = "...";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(14, 51);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(97, 13);
            this.lblResolution.TabIndex = 9;
            this.lblResolution.Text = "Current resolutions:";
            // 
            // txtResX
            // 
            this.txtResX.Location = new System.Drawing.Point(12, 94);
            this.txtResX.Name = "txtResX";
            this.txtResX.Size = new System.Drawing.Size(100, 20);
            this.txtResX.TabIndex = 10;
            this.txtResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResX_KeyPress);
            // 
            // txtResY
            // 
            this.txtResY.Location = new System.Drawing.Point(12, 120);
            this.txtResY.Name = "txtResY";
            this.txtResY.Size = new System.Drawing.Size(100, 20);
            this.txtResY.TabIndex = 11;
            this.txtResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResY_KeyPress);
            // 
            // lblNewResolution
            // 
            this.lblNewResolution.AutoSize = true;
            this.lblNewResolution.Location = new System.Drawing.Point(9, 78);
            this.lblNewResolution.Name = "lblNewResolution";
            this.lblNewResolution.Size = new System.Drawing.Size(118, 13);
            this.lblNewResolution.TabIndex = 12;
            this.lblNewResolution.Text = "Change new resolution:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(118, 97);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(118, 123);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 14;
            this.lblY.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 65);
            this.label1.TabIndex = 15;
            this.label1.Text = "The best 4:3 resolutions\r\n\r\n1280x960\r\n1024x768\r\n800x600";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings_for_resolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblNewResolution);
            this.Controls.Add(this.txtResY);
            this.Controls.Add(this.txtResX);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblMonitorName);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.btn_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings_for_resolutions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings for resolutions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.OpenFileDialog OpenFolderD;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lblMonitorName;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.TextBox txtResX;
        private System.Windows.Forms.TextBox txtResY;
        private System.Windows.Forms.Label lblNewResolution;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label1;
    }
}