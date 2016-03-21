using System.Windows.Forms;


namespace EyeRecorder
{
    class FileDialog
    {
        public static string FilePathDialog()
        {
            string path = Application.StartupPath;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "recording_data.csv";
            sfd.InitialDirectory = path;
            sfd.Filter =
                "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.Title = "保存先のファイルを選択してください";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;

            sfd.ShowDialog();

            return sfd.FileName;
        }
    }
}
