using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class FileWorker
    {

        private string filename = "Noname.txt";

        public string Filename { get { return filename; } }

        public FileWorker(string filename)
        {
            this.filename = filename;

            string content = "";
            File.WriteAllText(filename, content);
        }

        public void SaveArrayToFile(int[] arr)
        {
            string content = "";

            for (int i = 0; i < arr.Length; i++)
            {
                content += arr[i] + "\n";
            }

            File.WriteAllText(filename, content);
        }

        public void SaveArrayToFile(double[] arr)
        {
            string content = "";

            for (int i = 0; i < arr.Length; i++)
            {
                content += arr[i] + "\n";
            }

            File.WriteAllText(filename, content);
        }

    }
}
