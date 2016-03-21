using System;
using System.Windows.Forms;
using System.Diagnostics;
using TobiiEyexArrangeTool;


namespace EyeRecorder
{
    public partial class SettingForm : Form
    {
        private bool isRecording = false;
        private Stopwatch stopwatch = null;
        private TobiiEyexArrangeController controller = null;
        private FileIO fileIo = null;
        private TriggerForm triggerForm = null;

        public SettingForm()
        {
            isRecording = false;
            controller = new TobiiEyexArrangeController();
            triggerForm = new TriggerForm();
            triggerForm.Show();
            InitializeComponent();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            string outputFilePath = FileDialog.FilePathDialog();
            saveFilePathLabel.Text = outputFilePath;
            if (this.saveFilePathLabel.Text != "")
            {
                this.recordButton.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                isRecording = false;
                recordButton.Text = "● REC";
                cancelButton.Enabled = true;
                stopwatch.Stop();
                stopwatch.Reset();

                controller.DisposeTobiiEyex();

                fileIo.Close();

                positionUpdateTimer.Enabled = false;
                positionUpdateTimer.Stop();
            }
            else
            {
                isRecording = true;
                recordButton.Text = "■ Stop";
                cancelButton.Enabled = false;
                stopwatch = new Stopwatch();
                stopwatch.Start();

                controller.StartTobiiEyex();

                fileIo = new FileIO(saveFilePathLabel.Text, controller.monitorWidth, controller.monitorHeight);

                positionUpdateTimer.Enabled = true;
                positionUpdateTimer.Start();
            }
        }

        private void positionUpdateTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = stopwatch.Elapsed.ToString();
            if (triggerForm.triggerFlag)
            {
                fileIo.InputEyePositionData(stopwatch.ElapsedMilliseconds.ToString(), controller.x, controller.y, true);
            }
            else
            {
                fileIo.InputEyePositionData(stopwatch.ElapsedMilliseconds.ToString(), controller.x, controller.y, false);
            }
            
        }
    }
}
