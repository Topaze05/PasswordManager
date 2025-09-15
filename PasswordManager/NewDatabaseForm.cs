namespace PasswordManager
{
    public partial class NewDatabaseForm : Form
    {
        public NewDatabaseForm()
        {
            InitializeComponent();
        }

        // Permet de voir ou de cacher le mot de passe maître
        private void TogglePasswordChar(object sender, EventArgs e)
        {
            tbxMasterPassword.UseSystemPasswordChar = !tbxMasterPassword.UseSystemPasswordChar;
            tbxRepeatMasterPassword.UseSystemPasswordChar = !tbxRepeatMasterPassword.UseSystemPasswordChar;
        }

        // La clef pour chiffrer les données est le Hash du mot de passe maître
        private void Accept(object sender, EventArgs e)
        {
            if (tbxMasterPassword.Text.Equals(tbxRepeatMasterPassword.Text))
            {
                ((MainForm)Owner).Database.Hash = Security.GetHash(tbxMasterPassword.Text);
            }
            else
            {
                MessageBox.Show("Vos mot de passe ne correspondent pas !", "MyPasswordManager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }
    }
}
