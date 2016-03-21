namespace EyeRecorder
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SettingButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.recordButton = new System.Windows.Forms.Button();
            this.saveFilePathLabel = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.positionUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "保存先ファイルパス（空の場合は保存されない）";
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(332, 46);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(82, 19);
            this.SettingButton.TabIndex = 2;
            this.SettingButton.Text = "設定";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(148, 81);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(151, 19);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "00:00:00.0000000";
            // 
            // recordButton
            // 
            this.recordButton.Enabled = false;
            this.recordButton.ForeColor = System.Drawing.Color.Red;
            this.recordButton.Location = new System.Drawing.Point(104, 106);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(73, 23);
            this.recordButton.TabIndex = 11;
            this.recordButton.Text = "● REC";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // saveFilePathLabel
            // 
            this.saveFilePathLabel.Location = new System.Drawing.Point(14, 46);
            this.saveFilePathLabel.Name = "saveFilePathLabel";
            this.saveFilePathLabel.ReadOnly = true;
            this.saveFilePathLabel.Size = new System.Drawing.Size(298, 19);
            this.saveFilePathLabel.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(273, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // positionUpdateTimer
            // 
            this.positionUpdateTimer.Interval = 50;
            this.positionUpdateTimer.Tick += new System.EventHandler(this.positionUpdateTimer_Tick);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 141);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveFilePathLabel);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.Text = "設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.TextBox saveFilePathLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Timer positionUpdateTimer;
    }
}