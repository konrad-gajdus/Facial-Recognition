namespace FacialRecognition
{
    partial class Web_Cam
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
            this.webCam = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comCamera = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkbxFaceDetction = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fpsBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.fpsCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsBar)).BeginInit();
            this.SuspendLayout();
            // 
            // webCam
            // 
            this.webCam.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.webCam.Location = new System.Drawing.Point(39, 51);
            this.webCam.Name = "webCam";
            this.webCam.Size = new System.Drawing.Size(640, 480);
            this.webCam.TabIndex = 0;
            this.webCam.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(39, 551);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera: ";
            // 
            // comCamera
            // 
            this.comCamera.FormattingEnabled = true;
            this.comCamera.Location = new System.Drawing.Point(91, 19);
            this.comCamera.Name = "comCamera";
            this.comCamera.Size = new System.Drawing.Size(377, 21);
            this.comCamera.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(120, 551);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkbxFaceDetction
            // 
            this.chkbxFaceDetction.AutoSize = true;
            this.chkbxFaceDetction.Location = new System.Drawing.Point(258, 557);
            this.chkbxFaceDetction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkbxFaceDetction.Name = "chkbxFaceDetction";
            this.chkbxFaceDetction.Size = new System.Drawing.Size(99, 17);
            this.chkbxFaceDetction.TabIndex = 5;
            this.chkbxFaceDetction.Text = "Face Detection";
            this.chkbxFaceDetction.UseVisualStyleBackColor = true;
            this.chkbxFaceDetction.CheckedChanged += new System.EventHandler(this.chkbxFaceDetction_CheckedChanged);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(695, 51);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(161, 481);
            this.txtLog.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FPS:";
            // 
            // fpsBar
            // 
            this.fpsBar.Location = new System.Drawing.Point(555, 551);
            this.fpsBar.Maximum = 60;
            this.fpsBar.Minimum = 30;
            this.fpsBar.Name = "fpsBar";
            this.fpsBar.Size = new System.Drawing.Size(202, 45);
            this.fpsBar.TabIndex = 8;
            this.fpsBar.Value = 30;
            this.fpsBar.Scroll += new System.EventHandler(this.fpsBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "FPS:";
            // 
            // fpsCounter
            // 
            this.fpsCounter.AutoSize = true;
            this.fpsCounter.Location = new System.Drawing.Point(91, 65);
            this.fpsCounter.Name = "fpsCounter";
            this.fpsCounter.Size = new System.Drawing.Size(0, 13);
            this.fpsCounter.TabIndex = 10;
            // 
            // Web_Cam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 633);
            this.Controls.Add(this.fpsCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fpsBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.chkbxFaceDetction);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.comCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.webCam);
            this.Name = "Web_Cam";
            this.Text = "Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Web_Cam_FormClosing);
            this.Load += new System.EventHandler(this.webCamLoad);
            ((System.ComponentModel.ISupportInitialize)(this.webCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox webCam;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comCamera;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkbxFaceDetction;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar fpsBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fpsCounter;
    }
}

