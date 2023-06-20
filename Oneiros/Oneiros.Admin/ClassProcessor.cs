using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Admin
{
    public class ClassProcessor
    {
        public async Task ProcessClasses(string inputFolderPath, string outputFolderPath, string classSuffix, string template, string classPrefix)
        {
            List<string> classesToProcess = FileProcessor.ProcessFolder(inputFolderPath, outputFolderPath, classSuffix, classPrefix);

            foreach(string className in classesToProcess) 
            {
                string outputFileName = FileProcessor.GetOutputFileName(className, classSuffix, classPrefix);
                string outputFilePath = FileProcessor.GetOuputFilePath(className, outputFolderPath, classSuffix, classPrefix);

                Console.WriteLine("Creating File...");
                await ClassCreator.CreateClassIfNotExists(outputFilePath, Path.GetFileNameWithoutExtension(className), template);
                Console.WriteLine($"{outputFileName} created.");
            }
        }
    }
}
