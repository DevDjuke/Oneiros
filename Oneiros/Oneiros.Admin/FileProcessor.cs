using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Admin
{
    public static class FileProcessor
    {
        public static string GetFileName(string filePath) { return Path.GetFileNameWithoutExtension(filePath); }
        public static string GetOutputFileName(string filePath, string classSuffix, string classPrefix) { return classPrefix + GetFileName(filePath) + classSuffix + ".cs"; }
        public static string GetOuputFilePath(string filePath, string outputFolderPath, string classSuffix, string classPrefix) { return Path.Combine(outputFolderPath, GetOutputFileName(filePath, classSuffix, classPrefix)); }

        public static List<string> ProcessFolder(string inputFolderPath, string outputFolderPath, string classSuffix, string classPreffix)
        {
            List<string> files = ProcessFolder(inputFolderPath);
            for (var i = files.Count - 1; i >= 0; i--)
            {
                if (!ProcessClassFile(files[i], outputFolderPath, classSuffix, classPreffix))
                {
                    files.RemoveAt(i);
                }
            }

            Console.WriteLine($"Found {files.Count()} files to process");
            return files;
        }

        public static List<string> ProcessFolder(string inputFolderPath)
        {
            List<string> files = new List<string>();

            files.AddRange(ProcessDirectory(inputFolderPath));

            return files;
        }

        private static List<string> ProcessDirectory(string directoryPath)
        {
            List<string> files = Directory.GetFiles(directoryPath, "*.cs").ToList();

            string[] subdirectories = Directory.GetDirectories(directoryPath);

            foreach (string subdirectory in subdirectories)
            {
                files.AddRange(ProcessDirectory(subdirectory));
            }

            return files;
        }

        private static bool ProcessClassFile(string filePath, string outputFolderPath, string classSuffix, string classPrefix)
        {
            Console.WriteLine($"Processing class file: {filePath}");

            string fileName = GetFileName(filePath);
            string outputFilePath = GetOuputFilePath(filePath, outputFolderPath, classSuffix, classPrefix);

            if (File.Exists(outputFilePath))
            {
                Console.WriteLine($"Found {outputFilePath} for class file: {fileName}");
                return false;
            }
            else
            {
                Console.WriteLine($"{outputFilePath} not found for class file: {fileName}");
                return true;
            }
        }
    }
}
