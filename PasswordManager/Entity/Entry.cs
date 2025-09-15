using System.ComponentModel;

namespace PasswordManager.Entity
{
    public class Entry : ICloneable
    {
        private string uuid;
        [Browsable(false)]
        public string UUID
        {
            get { return uuid; }
            set { uuid = value; }
        }

        private string title;
        [DisplayName("Titre")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string username;
        [DisplayName("Nom d'utilisateur")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        [DisplayName("Mot de passe")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string link;
        [DisplayName("Adresse (URL)")]
        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        private DateTime createdAt;
        [DisplayName("Date de création")]
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
