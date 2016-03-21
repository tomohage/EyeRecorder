namespace EyeRecorder
{
    partial class TriggerForm
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
            this.triggerLabel = new System.Windows.Forms.Label();
            this.triggerSwitchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // triggerLabel
            // 
            this.triggerLabel.AutoSize = true;
            this.triggerLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.triggerLabel.Location = new System.Drawing.Point(22, 20);
            this.triggerLabel.Name = "triggerLabel";
            this.triggerLabel.Size = new System.Drawing.Size(155, 33);
            this.triggerLabel.TabIndex = 2;
            this.triggerLabel.Text = "Trigger off";
            // 
            // triggerSwitchButton
            // 
            this.triggerSwitchButton.Location = new System.Drawing.Point(50, 71);
            this.triggerSwitchButton.Name = "triggerSwitchButton";
            this.triggerSwitchButton.Size = new System.Drawing.Size(98, 47);
            this.triggerSwitchButton.TabIndex = 3;
            this.triggerSwitchButton.Text = "切り替え";
            this.triggerSwitchButton.UseVisualStyleBackColor = true;
            this.triggerSwitchButton.Click += new System.EventHandler(this.triggerSwitchButton_Click);
            // 
            // TriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 140);
            this.Controls.Add(this.triggerSwitchButton);
            this.Controls.Add(this.triggerLabel);
            this.Name = "TriggerForm";
            this.Text = "TriggerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label triggerLabel;
        private System.Windows.Forms.Button triggerSwitchButton;
    }
}