using Singleton;

Console.WriteLine("Singleton");
ConfigurationService configurationService = new();
var azureConnectionString = configurationService.GetValue("Storage:Azure");

Console.WriteLine();