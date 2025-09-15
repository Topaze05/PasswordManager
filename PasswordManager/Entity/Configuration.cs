namespace PasswordManager.Entity
{
    public class Configuration
    {
        private string lastUsedFile;
        public string LastUsedFile
        {
            get { return lastUsedFile; }
            set { lastUsedFile = value; }
        }
    }
}
