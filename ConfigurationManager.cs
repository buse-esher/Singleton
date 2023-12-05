using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Singleton
{
    public class ConfigurationService
    { 
        public string GetValue(string key)
        {
            ConfigurationManager configurationManager = new();
            string path= Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("Configuration.json");
            return configurationManager.GetSection(key).Value;  
        }
    }
}
