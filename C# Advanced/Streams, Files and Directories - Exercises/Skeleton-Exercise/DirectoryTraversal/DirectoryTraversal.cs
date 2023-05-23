namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> fileExtensions = new SortedDictionary<string, List<FileInfo>>();
            string[] filesInDir = Directory.GetFiles(inputFolderPath);

            foreach (var file in filesInDir)
            {
                FileInfo fileInfo = new (file);

                if (!fileExtensions.ContainsKey(fileInfo.Extension))
                {
                    fileExtensions.Add(fileInfo.Extension, new List<FileInfo>());
                }

                fileExtensions[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var file in fileExtensions.OrderByDescending(ef => ef.Value.Count()))
            {
                sb.Append(file.ToString());

                foreach (var subFile in file.Value.OrderBy(sf => sf.Length))
                {
                    sb.AppendLine($"-- {subFile.Name} - {(double)subFile.Length / 1024:f3}kb");
                }
            }

            return sb.ToString();
         }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + reportFileName;
            File.WriteAllText(filePath, textContent);
        }
    }
}
