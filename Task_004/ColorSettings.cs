using Newtonsoft.Json;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;

namespace Task_004
{
    internal class ColorSettings
    {
        public IConfiguration config;
        private string path = 
            @"C:\Users\Admin\Desktop\Pro\Home_005\Task_004\settings.json";

        public ColorSettings()
        {
            config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path, true, true)
                .Build();
        }

        public void Changer(string userColor)
        {
            dynamic? jsonObj = 
                JsonConvert.DeserializeObject(File.ReadAllText(path));

            jsonObj["MyColor"] = userColor;

            string output = 
                JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(path, output);
        }

        public string? UserChoice()
        {
            Console.Write("Type a color of text for your app : ");

            return Console.ReadLine();
        }
    }
}
