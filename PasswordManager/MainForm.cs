using PasswordManager.Entity;
using PasswordManager.Helper;
using System.ComponentModel;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        private const int DTG_PASSWORD_COLUMN_INDEX = 2;
        private const int NUMBER_OF_PASSWORD_CHAR = 8;

        public Database Database;

        private Configuration configuration;
        private Entry selectedEntry;

        public MainForm()
        {
            InitializeComponent();

            Database = new Database();
            configuration = new Configuration();

            Load += MainForm_Load;
            Shown += OnFormShown;
            FormClosing += OnFormClosing;
        }

        #region Form Events
        /// <summary>
        /// Affiche la configuration actuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormShown(object sender, EventArgs e)
        {
            if (configuration.LastUsedFile is not null)
            {
                OpenDatabaseForm openDatabaseForm = new(configuration.LastUsedFile);

                // Si le mot de passe est correcte
                if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.DataSource = Database.Entries;
                    Text = $"MyPasswordManager - {Path.GetFileName(configuration.LastUsedFile)}";

                }
            }
        }

        /// <summary>
        /// Charge la dernière configuration utilisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            configuration = ConfigurationHelper.LoadConfiguration();

            // Si la base de donnée n'existe plus
            if (!File.Exists(configuration.LastUsedFile))
            {
                configuration.LastUsedFile = null;
            }
        }

        /// <summary>
        /// Sauvegarde la configuration juste avant que le formulaire soit fermé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationHelper.SaveConfiguration(configuration);

            if (Database != null)
            {
                DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
            }
        }
        #endregion

        #region Entry Methods
        /// <summary>
        /// Fonction qui ajoute une entré de données dans une base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEntry(object sender, EventArgs e)
        {
            EntryForm entryForm = new();

            if (entryForm.ShowDialog(this) == DialogResult.OK)
            {
                Database.Entries.Add(entryForm.Entry);
                DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
            }
        }

        private void DeleteEntry(object sender, EventArgs e)
        {
            SetSelectedEntry();

            var dialogResult = MessageBox.Show($"Etes vous certain de vouloir supprimer définitivement l'entrée sélectionné ?" +
                $" \n\n - {selectedEntry.Title}", "MyPasswordManager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                Database.Entries.Remove(selectedEntry);
            }
        }

        #endregion

        #region Database Methods
        /// <summary>
        /// Création d'une nouvelle base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewDatabase(object sender, EventArgs e)
        {
            // Initialisation des paramêtres pour l'explorateur windows
            SaveFileDialog sfd = new();
            sfd.FileName = "Base de données.mpm";
            sfd.Filter = "Fichier MPM de MyPasswordManager | *.mpm";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                NewDatabaseForm newDatabaseForm = new();

                // Enregistre la nouvelle database
                if (newDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database.Entries = new BindingList<Entry>();
                    DtgEntries.DataSource = Database.Entries;

                    configuration.LastUsedFile = dbFile;

                    DatabaseHelper.SaveDatabase(dbFile, Database);

                    Text = $"MyPasswordManager - {Path.GetFileName(dbFile)}";
                }
            }
        }

        /// <summary>
        /// Fonction qui permet d'ouvrir une base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDatabase(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenDatabaseForm(ofd.FileName);
            }
        }

        /// <summary>
        /// Fonction qui ferme la base de donné sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "MyPasswordManager";
            configuration.LastUsedFile = null;
        }

        /// <summary>
        /// Sauvegarde la base de donné sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveDatabase(object sender, EventArgs e)
        {
            DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
        }

        /// <summary>
        /// Fonction qui ferme la base de donné de sorte à ce qu'il faille de nouveau entrée le mot de passe pour accéder aux données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LockDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "MyPasswordManager";
            OpenDatabaseForm(configuration.LastUsedFile);
        }

        /// <summary>
        /// Fonction qui ouvre le formulaire pour ouvrir une nouvelle base de donnée
        /// </summary>
        /// <param name="dbFile"></param>
        private void OpenDatabaseForm(string dbFile)
        {
            OpenDatabaseForm openDatabaseForm = new(dbFile);

            if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
            {
                DtgEntries.DataSource = Database.Entries;
                Text = $"MyPasswordManager - {Path.GetFileName(dbFile)}";
                configuration.LastUsedFile = dbFile;
            }
        }
        #endregion

        #region Menu Events
        /// <summary>
        /// Fonction qui gère si les menus des fichiers sont accessibles ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuFileOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleFileMenu(isEnabled: true);
            else
                ToggleFileMenu(isEnabled: false);
        }

        /// <summary>
        /// Fonction qui gère si les menus des entrées sont accessibles ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuEntryOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleEntryMenu(isEnabled: true);
            else
                ToggleEntryMenu(isEnabled: false);

        }
        #endregion

        #region Methods
        /// <summary>
        /// Fonction qui change l'accessibilité des menus des fichiers
        /// </summary>
        /// <param name="isEnabled"></param>
        private void ToggleFileMenu(bool isEnabled)
        {
            menuSaveDatabase.Enabled = isEnabled;
            menuLockDatabase.Enabled = isEnabled;
            menuCloseDatabase.Enabled = isEnabled;
        }

        /// <summary>
        /// Fonction qui change l'accessibilité des menus des entrées
        /// </summary>
        /// <param name="isEnabled"></param>
        private void ToggleEntryMenu(bool isEnabled)
        {
            menuAddEntry.Enabled = isEnabled;
            menuCopyPassword.Enabled = isEnabled;
            menuCopyUername.Enabled = isEnabled;
        }

        private void ToggleContextMenuNotify(bool isEnable)
        {
            contextMenuLockDatabase.Enabled = isEnable;
            // contextMenuExit.Enabled=isEnable;
        }
        #endregion

        #region Copy Methods
        private void CopyUsername(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (selectedEntry != null)
            {
                Clipboard.SetText(selectedEntry.Username);
            }
        }

        private void CopyPassword(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (selectedEntry != null)
            {
                Clipboard.SetText(Security.Decrypt(selectedEntry.Password, Database.Hash));
            }

        }

        private void CopyURL(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (selectedEntry != null)
            {
                Clipboard.SetText(selectedEntry.Link);
            }
        }

        #endregion

        /// <summary>
        /// Fonction qui ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Permet de faire apparaitre le mot de passe comme une suite de 8 "*"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtgEntriesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DTG_PASSWORD_COLUMN_INDEX)
            {
                e.Value = new string('*', NUMBER_OF_PASSWORD_CHAR);
            }
        }

        /// <summary>
        /// Fonction qui permet de modifier une entrée déjà existante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEntry(object sender, EventArgs e)
        {
            if (DtgEntries.SelectedRows.Count == 1)
            {
                SetSelectedEntry();
                EntryForm entryForm = new EntryForm(selectedEntry);
                selectedEntry.Password = Security.Decrypt(selectedEntry.Password, Database.Hash);


                if (entryForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.RefreshEdit();
                    selectedEntry.Password = Security.Encrypt(selectedEntry.Password, Database.Hash);
                    DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
                }
            }
        }

        /// <summary>
        /// Récupère l'entrée sélectionné
        /// </summary>
        private void SetSelectedEntry()
        {
            selectedEntry = (Entry)DtgEntries.CurrentRow.DataBoundItem;
        }

        private void contextMenuNotifyOpening(object sender, CancelEventArgs e)
        {
            if (Database.Hash is null)
            {
                ToggleContextMenuNotify(isEnable: false);
            }
            else
            {
                ToggleContextMenuNotify(isEnable: true);
            }
        }

    }
}