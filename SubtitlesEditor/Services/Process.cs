using SubtitlesEditor.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesEditor.Services
{
    public class Process
    {
        private Files _files;
        private bool _success;
        private Subtitles _subtitles;

        public Process()
        {
            _files = new Files();
            _subtitles = new Subtitles();
        }

        public void Start()
        {           
            string[] lines = _files.Read(Settings.Default.inputFilePath);
            if(lines.Count() == 0) return;
            
            string outputContent = _subtitles.ShiftAndCutSubtitles(lines, TimeSpan.FromSeconds(Settings.Default.timeShift));
            if(string.IsNullOrEmpty(outputContent)) return;
            
            _success = _files.Save(Settings.Default.outputFilePath+ "\\"+ Settings.Default.outputFileName, outputContent);
            if (_success) MessageBox.Show($"Utworzono plik w {Settings.Default.outputFilePath}", "Zakończono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Błąd zapisania danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }  
    }
}
