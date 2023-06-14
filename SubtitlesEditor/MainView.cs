using SubtitlesEditor.Properties;
using System.Text.RegularExpressions;

namespace SubtitlesEditor
{
    public partial class MainView : Form
    {


        public MainView()
        {
            InitializeComponent();
        }

        private void btnAddPathToFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()) if (ofd.ShowDialog() == DialogResult.OK) tbPathToFile.Text = ofd.FileName;
            Settings.Default.inputFilePath = tbPathToFile.Text;
            Settings.Default.outputFilePath = "C:\\Users\\macie\\Downloads\\napisy do filmuOutput.srt";
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            ShiftAndCutSubtitles(Settings.Default.inputFilePath, Settings.Default.outputFilePath, TimeSpan.FromSeconds(5.88));
        }

        private void ShiftAndCutSubtitles(string inputFilePath, string outputFilePath, TimeSpan timeShift)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            string outputContent = string.Empty;
            int subtitleIndex = 1;

            for (int i = 0; i < lines.Length; i += 4)
            {
                string subtitleIndexLine = subtitleIndex.ToString();
                string timeLine = lines[i + 1];
                string textLine = lines[i + 2];

                // Pobranie czasu rozpoczêcia i zakoñczenia napisów
                Match startTimeMatch = Regex.Match(timeLine, @"(\d{2}:\d{2}:\d{2},\d{3})");
                Match endTimeMatch = Regex.Match(timeLine, @"(\d{2}:\d{2}:\d{2},\d{3}) --> (\d{2}:\d{2}:\d{2},\d{3})");

                if (startTimeMatch.Success && endTimeMatch.Success)
                {
                    // Przesuniêcie czasu
                    TimeSpan startTime = TimeSpan.Parse(startTimeMatch.Groups[1].Value);
                    TimeSpan endTime = TimeSpan.Parse(endTimeMatch.Groups[2].Value);

                    startTime = startTime.Add(timeShift);
                    endTime = endTime.Add(timeShift);

                    // Sprawdzenie czy napisy maj¹ równ¹ sekundê rozpoczêcia po przesuniêciu
                    if (startTime.Seconds == 0)
                    {
                        // Dodanie napisów do nowego pliku
                        outputContent += $"{subtitleIndexLine}\n{FormatTime(startTime, endTime)}\n{textLine}\n\n";
                        subtitleIndex++;
                    }
                }
            }

            File.WriteAllText(outputFilePath, outputContent);
        }

        static string FormatTime(TimeSpan startTime, TimeSpan endTime)
        {
            return $"{startTime:hh\\:mm\\:ss\\,fff} --> {endTime:hh\\:mm\\:ss\\,fff}";
        }
    }
}