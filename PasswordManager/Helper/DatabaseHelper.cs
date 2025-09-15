using PasswordManager.Entity;
using System.Text.Json;

namespace PasswordManager.Helper
{
    public static class DatabaseHelper
    {
        /// <summary>
        /// Fonction qui enregistre les Databases en les chiffrant
        /// </summary>
        /// <param name="path"> Path de l'endroit où doit être enregistré la database chiffrée </param>
        /// <param name="database"> Database à enregistrer </param>
        public static void SaveDatabase(string path, Database database)
        {
            // Créer un fichier temporaire contenant les données non chiffré
            var fileName = Guid.NewGuid().ToString() + ".tmp";
            var tempFilePath = Path.Combine(Path.GetTempPath(), fileName);

            File.WriteAllText(tempFilePath, JsonSerializer.Serialize(database));

            // Chiffre les données et les enregistre à l'endroit désiré
            Security.EncryptFile(database.Hash, tempFilePath, path);

            // Test du fichier de sécurité custom
            // CustomSecurity.Great();

            File.Delete(tempFilePath);
        }
    }
}
