using PasswordManager.Entity;

namespace PasswordManager
{
    /// <summary>
    /// Formulaire permettant d'ajouter une entrée de données dans une base de donnée
    /// </summary>
    public partial class EntryForm : Form
    {
        public Entry Entry;
        public Entry initEntry;

        public EntryForm(Entry value_entry = null)
        {
            InitializeComponent();

            if (value_entry != null)
            {
                Entry = value_entry;
            }
        }

        /// <summary>
        /// Fonction qui est appelé quand on appuie sur le bouton Ok du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accept(object sender, EventArgs e)
        {
            if (tbxPassword.Text.Equals(tbxConfirm.Text))
            {
                Entry = new()
                {
                    UUID = Guid.NewGuid().ToString().ToUpper(),
                    Title = tbxTitle.Text,
                    Username = tbxUsername.Text,
                    Password = Security.Encrypt(tbxPassword.Text, ((MainForm)Owner).Database.Hash),
                    Link = tbxLink.Text,
                    CreatedAt = DateTime.Now,
                };
            }

            else
            {
                MessageBox.Show("Le mot de passe et sa confirmation ne sont pas identiques.",
                    "La validation a échoué", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Fonction qui cache ou montre les charactères du mot de passe et de la confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TogglePasswordChar(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !tbxPassword.UseSystemPasswordChar;
            tbxConfirm.UseSystemPasswordChar = !tbxConfirm.UseSystemPasswordChar;
        }

        /// <summary>
        /// Sélectionne automatiquement le titre quand le formulaire s'ouvre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoad(object sender, EventArgs e)
        {
            tbxTitle.Select();

            if (Entry != null)
            {
                initEntry = (Entry)Entry.Clone();

                tbxTitle.DataBindings.Add("Text", Entry, "Title");
                tbxUsername.DataBindings.Add("Text", Entry, "Username");
                tbxPassword.DataBindings.Add("Text", Entry, "Password");
                tbxConfirm.Text = tbxPassword.Text;
                tbxLink.DataBindings.Add("Text", Entry, "Link");
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Entry != null && DialogResult == DialogResult.Cancel)
            {
                Entry.Title = initEntry.Title;
                Entry.Username = initEntry.Username;
                Entry.Password = initEntry.Password;
                Entry.Link = initEntry.Link;
            }
        }
    }
}
