// See https://aka.ms/new-console-template for more information
using Oneiros.Admin;

string domainPath = "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.Domain\\Model\\";

ClassProcessor processor = new ClassProcessor();
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\Controllers\\", "Controller", "API_CONTROLLER", "");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\Repositories\\Interfaces\\", "Repository", "REPOSITORY_INTERFACE", "I");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\Repositories\\", "Repository", "REPOSITORY", "");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\Infrastructure\\Services\\", "Service", "SERVICE", "");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\Infrastructure\\Services\\Base\\", "Service", "SERVICE_INTERFACE", "I");

await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Commands\\Create\\", "Command", "CREATE_COMMAND", "Create");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Commands\\Delete\\", "Command", "DELETE_COMMAND", "Delete");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Commands\\Update\\", "Command", "UPDATE_COMMAND", "Update");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Commands\\Create\\", "CommandHandler", "CREATE_COMMAND_HANDLER", "Create");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Commands\\Delete\\", "CommandHandler", "DELETE_COMMAND_HANDLER", "Delete");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Commands\\Update\\", "CommandHandler", "UPDATE_COMMAND_HANDLER", "Update");

await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Queries\\GetAll\\", "sQuery", "GETALL_QUERY", "GetAll");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Queries\\GetById\\", "byIdsQuery", "GETBYID_QUERY", "Get");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Queries\\GetAll\\", "sQueryHandler", "GETALL_QUERY_HANDLER", "GetAll");
await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\App\\Queries\\GetById\\", "byIdsQueryHandler", "GETBYID_QUERY_HANDLER", "Get");

await processor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.Data\\DTO\\", "DTO", "DTO", "");

ClassAppendor appendor = new ClassAppendor();
await appendor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\Infrastructure\\Extensions\\", "Service");
await appendor.ProcessClasses(domainPath, "C:\\Users\\joryj\\Repos\\concept\\Oneiros\\Oneiros\\Oneiros.API\\Infrastructure\\Extensions\\", "Repository");
