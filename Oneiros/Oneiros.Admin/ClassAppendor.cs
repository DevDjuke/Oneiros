using Oneiros.Admin.ClassTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Admin
{
    public class ClassAppendor
    {
        public async Task ProcessClasses(string inputFolderPath, string outputFolderPath, string template)
        {
            List<string> classesToProcess = ProcessDirectory(inputFolderPath);

            StringBuilder sb = new StringBuilder();

            foreach (string className in classesToProcess)
            {
                sb.AppendLine($"services.AddScoped<I{Path.GetFileNameWithoutExtension(className)}{template}, {Path.GetFileNameWithoutExtension(className)}{template}>();");
            }

            switch(template)
            {
                case "Service":
                    await File.WriteAllTextAsync(Path.Combine(outputFolderPath, "ServiceExtension.cs"), ExtensionTemplate.ServiceTemplate(sb.ToString()));
                    break;
                case "Repository":
                    await File.WriteAllTextAsync(Path.Combine(outputFolderPath, "RepositoryExtension.cs"), ExtensionTemplate.RepositoryTemplate(sb.ToString()));
                    break;
            }
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
    }
}
