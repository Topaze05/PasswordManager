using PasswordManager.Entity;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace PasswordManager.Helper
{
    public static class ConfigurationHelper
    {
        private static readonly string configDirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyPasswordManager");

        private static readonly string configFileName = "MyPassword.config.json";

        private static readonly string configFilePath = Path.Combine(configDirPath, configFileName);

        /// <summary>
        /// Fonction qui enregistre sous forme de fichier json les données de configuration
        /// </summary>
        /// <param name="configuration"> La class qui contient les données de configuration </param>
        public static void SaveConfiguration(Configuration configuration)
        {
            var json = JsonSerializer.Serialize(configuration, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(configDirPath))
            {
                Directory.CreateDirectory(configDirPath);
            }

            File.WriteAllText(configFilePath, json);
        }


        public static Configuration LoadConfiguration()
        {
            Configuration configuration = new();

            if (!Directory.Exists(configDirPath))
            {
                Directory.CreateDirectory(configDirPath);
                SaveConfiguration(configuration);

                return configuration;
            }

            var json = File.ReadAllText(configFilePath);

            return JsonSerializer.Deserialize<Configuration>(json);
        }
    }
}
