using PasswordManager.Entity;
using System.Text.Json;

namespace PasswordManager
{
    public partial class OpenDatabaseForm : Form
    {
        private string dbFile;

        public OpenDatabaseForm(string dbFile)
        {
            InitializeComponent();
            this.dbFile = dbFile;
            Text += $" - {Path.GetFileName(dbFile)}";
        }

        private void TogglePasswordChar(object sender, EventArgs e)
        {
            tbxMasterPassword.UseSystemPasswordChar = !tbxMasterPassword.UseSystemPasswordChar;
        }

        private void Accept(object sender, EventArgs e)
        {
            var hash = Security.GetHash(tbxMasterPassword.Text);
            var file = Security.DecryptFile(hash, dbFile);

            if (!string.IsNullOrWhiteSpace(file))
            {
                var json = File.ReadAllText(file);

                File.Delete(file);

                ((MainForm)Owner).Database = JsonSerializer.Deserialize<Database>(json);
                ((MainForm)Owner).Database.Hash = hash;
            }

            else
            {
                MessageBox.Show("Le mot de passe maitre est invalide !", "MyPasswordManager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxMasterPassword.Clear();

                DialogResult = DialogResult.None;
            }

        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            tbxMasterPassword.Select();
        }
    }
}
