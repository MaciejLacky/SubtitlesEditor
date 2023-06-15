using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesEditor.Services
{
    public class Files
    {
        public string[] Read(string inputFilePath)
        {
            try
            {
                string[] files = File.ReadAllLines(inputFilePath);
                return files;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd pobrania danych z pliku.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return new string[0];
        }
        public bool Save (string outputFilePath, string outputContent)
        {
            try
            {               
                File.WriteAllText(outputFilePath, outputContent);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd pobrania danych z pliku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
