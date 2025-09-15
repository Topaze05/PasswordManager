using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PasswordManager.Entity
{
    public class Database
    {
        private string hash;

        [JsonIgnore]
        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        private BindingList<Entry> entries;
        public BindingList<Entry> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        public Database()
        {
            entries = new BindingList<Entry>();
        }
    }
}
