using Oneiros.Admin.ClassTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Admin
{
    public static class ClassCreator
    {
        public async static Task CreateClassIfNotExists(string filePath, string filename, string template)
        {

            if (!File.Exists(filePath))
            {
                string classTemplate = GetClassTemplate(filename, template);
                await File.WriteAllTextAsync(filePath, classTemplate);
            }
        }

        private static string GetClassTemplate(string filename, string template)
        {
            switch (template)
            {
                case "API_CONTROLLER":
                    return APIControllerTemplate.Template(filename);
                case "REPOSITORY":
                    return RepositoryTemplate.Template(filename);
                case "REPOSITORY_INTERFACE":
                    return RepositoryTemplate.ITemplate(filename);
                case "SERVICE":
                    return ServiceTemplate.Template(filename);
                case "SERVICE_INTERFACE":
                    return ServiceTemplate.ITemplate(filename);
                case "CREATE_COMMAND":
                    return CommandTemplate.CreateTemplate(filename);
                case "DELETE_COMMAND":
                    return CommandTemplate.DeleteTemplate(filename);
                case "UPDATE_COMMAND":
                    return CommandTemplate.UpdateTemplate(filename);
                case "CREATE_COMMAND_HANDLER":
                    return CommandTemplate.CreateHandlerTemplate(filename);
                case "DELETE_COMMAND_HANDLER":
                    return CommandTemplate.DeleteHandlerTemplate(filename);
                case "UPDATE_COMMAND_HANDLER":
                    return CommandTemplate.UpdateHandlerTemplate(filename);
                case "GETALL_QUERY":
                    return QueryTemplate.GetAllTemplate(filename);
                case "GETALL_QUERY_HANDLER":
                    return QueryTemplate.GetAllHandlerTemplate(filename);
                case "GETBYID_QUERY":
                    return QueryTemplate.GetIdTemplate(filename);
                case "GETBYID_QUERY_HANDLER":
                    return QueryTemplate.GetIdHandlerTemplate(filename);
                case "DTO":
                    return DTOTemplate.Teplate(filename);
                default:return "";
            }
        }
    }
}
