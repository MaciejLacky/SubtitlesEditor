using SubtitlesEditor.Properties;
using SubtitlesEditor.Services;
using System.Text.RegularExpressions;

namespace SubtitlesEditor
{
    public partial class MainView : Form
    {
        private Process _process;

        public MainView()
        {
            InitializeComponent();
            _process = new Process();           
        }

        private void btnAddPathToFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()) if (ofd.ShowDialog() == DialogResult.OK) tbPathToFile.Text = ofd.FileName;
            Settings.Default.inputFilePath = tbPathToFile.Text;         
        }
        private void btnAddFileToFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog()) if (fbd.ShowDialog() == DialogResult.OK) tbPathToFolder.Text = fbd.SelectedPath;
            Settings.Default.outputFilePath = tbPathToFolder.Text;
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            Settings.Default.outputFileName = tbOutputFileName.Text;
            Settings.Default.timeShift = (long)nudTimeShift.Value;
            _process.Start();
        }
    }
}