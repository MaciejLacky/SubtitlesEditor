using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SubtitlesEditor.Services
{
    public class Subtitles
    {
        public string ShiftAndCutSubtitles(string[] lines, TimeSpan timeShift)
        {
            string outputContent = string.Empty;
            int subtitleIndex = 1;          
            try
            {
                for (int i = 0; i < lines.Length; i += 4)
                {
                    string subtitleIndexLine = subtitleIndex.ToString();
                    string timeLine = lines[i + 1];
                    string textLine = lines[i + 2];

                    // Pobranie czasu rozpoczęcia i zakończenia napisów
                    Match startTimeMatch = Regex.Match(timeLine, @"(\d{2}:\d{2}:\d{2},\d{3})");
                    Match endTimeMatch = Regex.Match(timeLine, @"(\d{2}:\d{2}:\d{2},\d{3}) --> (\d{2}:\d{2}:\d{2},\d{3})");

                    if (startTimeMatch.Success && endTimeMatch.Success)
                    {
                        // Przesunięcie czasu
                        TimeSpan startTime = TimeSpan.Parse(startTimeMatch.Groups[1].Value);
                        TimeSpan endTime = TimeSpan.Parse(endTimeMatch.Groups[2].Value);

                        startTime = startTime.Add(timeShift);
                        endTime = endTime.Add(timeShift);

                        // Sprawdzenie czy napisy mają równą sekundę rozpoczęcia po przesunięciu
                        if (startTime.Seconds == 0)
                        {
                            // Dodanie napisów do nowego pliku
                            outputContent += $"{subtitleIndexLine}\n{FormatTime(startTime, endTime)}\n{textLine}\n\n";
                            subtitleIndex++;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd przekształcenia danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            return outputContent;
        }

        static string FormatTime(TimeSpan startTime, TimeSpan endTime)
        {
            return $"{startTime:hh\\:mm\\:ss\\,fff} --> {endTime:hh\\:mm\\:ss\\,fff}";
        }
    }
}
