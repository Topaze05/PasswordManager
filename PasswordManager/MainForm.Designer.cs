namespace PasswordManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLockDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyUername = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgEntries = new System.Windows.Forms.DataGridView();
            this.contextMenuDtg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuModifyEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuLockDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.copierLURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).BeginInit();
            this.contextMenuDtg.SuspendLayout();
            this.contextMenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEntry});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDatabase,
            this.menuOpenDatabase,
            this.menuCloseDatabase,
            this.menuSaveDatabase,
            this.menuLockDatabase,
            this.menuExitApplication});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 20);
            this.menuFile.Text = "Fichier";
            this.menuFile.DropDownOpening += new System.EventHandler(this.MenuFileOpening);
            // 
            // menuNewDatabase
            // 
            this.menuNewDatabase.Name = "menuNewDatabase";
            this.menuNewDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNewDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuNewDatabase.Text = "Nouveau";
            this.menuNewDatabase.Click += new System.EventHandler(this.NewDatabase);
            // 
            // menuOpenDatabase
            // 
            this.menuOpenDatabase.Name = "menuOpenDatabase";
            this.menuOpenDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpenDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuOpenDatabase.Text = "Ouvrir";
            this.menuOpenDatabase.Click += new System.EventHandler(this.OpenDatabase);
            // 
            // menuCloseDatabase
            // 
            this.menuCloseDatabase.Name = "menuCloseDatabase";
            this.menuCloseDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuCloseDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuCloseDatabase.Text = "Fermer";
            this.menuCloseDatabase.Click += new System.EventHandler(this.CloseDatabase);
            // 
            // menuSaveDatabase
            // 
            this.menuSaveDatabase.Name = "menuSaveDatabase";
            this.menuSaveDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSaveDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuSaveDatabase.Text = "Enregistrer";
            this.menuSaveDatabase.Click += new System.EventHandler(this.SaveDatabase);
            // 
            // menuLockDatabase
            // 
            this.menuLockDatabase.Name = "menuLockDatabase";
            this.menuLockDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuLockDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuLockDatabase.Text = "Verrouiller l\'espace de travail";
            this.menuLockDatabase.Click += new System.EventHandler(this.LockDatabase);
            // 
            // menuExitApplication
            // 
            this.menuExitApplication.Name = "menuExitApplication";
            this.menuExitApplication.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuExitApplication.Size = new System.Drawing.Size(263, 22);
            this.menuExitApplication.Text = "Quitter";
            this.menuExitApplication.Click += new System.EventHandler(this.ExitApplication);
            // 
            // menuEntry
            // 
            this.menuEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddEntry,
            this.menuCopyUername,
            this.menuCopyPassword});
            this.menuEntry.Name = "menuEntry";
            this.menuEntry.Size = new System.Drawing.Size(52, 20);
            this.menuEntry.Text = "Entrée";
            this.menuEntry.DropDownOpening += new System.EventHandler(this.MenuEntryOpening);
            // 
            // menuAddEntry
            // 
            this.menuAddEntry.Name = "menuAddEntry";
            this.menuAddEntry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuAddEntry.Size = new System.Drawing.Size(255, 22);
            this.menuAddEntry.Text = "Ajouter une entrée";
            this.menuAddEntry.Click += new System.EventHandler(this.AddEntry);
            // 
            // menuCopyUername
            // 
            this.menuCopyUername.Name = "menuCopyUername";
            this.menuCopyUername.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuCopyUername.Size = new System.Drawing.Size(255, 22);
            this.menuCopyUername.Text = "Copier le nom d\'utilisateur";
            this.menuCopyUername.Click += new System.EventHandler(this.CopyUsername);
            // 
            // menuCopyPassword
            // 
            this.menuCopyPassword.Name = "menuCopyPassword";
            this.menuCopyPassword.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopyPassword.Size = new System.Drawing.Size(255, 22);
            this.menuCopyPassword.Text = "Copier le mot de passe";
            this.menuCopyPassword.Click += new System.EventHandler(this.CopyPassword);
            // 
            // DtgEntries
            // 
            this.DtgEntries.AllowUserToAddRows = false;
            this.DtgEntries.AllowUserToDeleteRows = false;
            this.DtgEntries.AllowUserToResizeRows = false;
            this.DtgEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEntries.BackgroundColor = System.Drawing.Color.White;
            this.DtgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEntries.ContextMenuStrip = this.contextMenuDtg;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgEntries.DefaultCellStyle = dataGridViewCellStyle1;
            this.DtgEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgEntries.Location = new System.Drawing.Point(0, 24);
            this.DtgEntries.Name = "DtgEntries";
            this.DtgEntries.ReadOnly = true;
            this.DtgEntries.RowTemplate.Height = 25;
            this.DtgEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgEntries.ShowCellToolTips = false;
            this.DtgEntries.ShowEditingIcon = false;
            this.DtgEntries.Size = new System.Drawing.Size(784, 537);
            this.DtgEntries.TabIndex = 1;
            this.DtgEntries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgEntriesCellFormatting);
            // 
            // contextMenuDtg
            // 
            this.contextMenuDtg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuCopyUsername,
            this.contextMenuCopyPassword,
            this.copierLURLToolStripMenuItem,
            this.contextMenuAddEntry,
            this.contextMenuModifyEntry,
            this.contextMenuDeleteEntry});
            this.contextMenuDtg.Name = "contextMenuStrip1";
            this.contextMenuDtg.Size = new System.Drawing.Size(215, 136);
            // 
            // contextMenuCopyUsername
            // 
            this.contextMenuCopyUsername.Name = "contextMenuCopyUsername";
            this.contextMenuCopyUsername.Size = new System.Drawing.Size(214, 22);
            this.contextMenuCopyUsername.Text = "Copier le nom d\'utilisateur";
            this.contextMenuCopyUsername.Click += new System.EventHandler(this.CopyUsername);
            // 
            // contextMenuCopyPassword
            // 
            this.contextMenuCopyPassword.Name = "contextMenuCopyPassword";
            this.contextMenuCopyPassword.Size = new System.Drawing.Size(214, 22);
            this.contextMenuCopyPassword.Text = "Copier le mot de passe";
            this.contextMenuCopyPassword.Click += new System.EventHandler(this.CopyPassword);
            // 
            // contextMenuAddEntry
            // 
            this.contextMenuAddEntry.Name = "contextMenuAddEntry";
            this.contextMenuAddEntry.Size = new System.Drawing.Size(214, 22);
            this.contextMenuAddEntry.Text = "Ajouter une entrée";
            this.contextMenuAddEntry.Click += new System.EventHandler(this.AddEntry);
            // 
            // contextMenuModifyEntry
            // 
            this.contextMenuModifyEntry.Name = "contextMenuModifyEntry";
            this.contextMenuModifyEntry.Size = new System.Drawing.Size(214, 22);
            this.contextMenuModifyEntry.Text = "Modifier l\'entrée";
            this.contextMenuModifyEntry.Click += new System.EventHandler(this.EditEntry);
            // 
            // contextMenuDeleteEntry
            // 
            this.contextMenuDeleteEntry.Name = "contextMenuDeleteEntry";
            this.contextMenuDeleteEntry.Size = new System.Drawing.Size(214, 22);
            this.contextMenuDeleteEntry.Text = "Supprimer l\'entrée";
            this.contextMenuDeleteEntry.Click += new System.EventHandler(this.DeleteEntry);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MyPasswordManager";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuLockDatabase,
            this.contextMenuExit});
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(224, 48);
            this.contextMenuNotify.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuNotifyOpening);
            // 
            // contextMenuLockDatabase
            // 
            this.contextMenuLockDatabase.Name = "contextMenuLockDatabase";
            this.contextMenuLockDatabase.Size = new System.Drawing.Size(223, 22);
            this.contextMenuLockDatabase.Text = "Verrouiller l\'espace de travail";
            this.contextMenuLockDatabase.Click += new System.EventHandler(this.LockDatabase);
            // 
            // contextMenuExit
            // 
            this.contextMenuExit.Name = "contextMenuExit";
            this.contextMenuExit.Size = new System.Drawing.Size(223, 22);
            this.contextMenuExit.Text = "Quitter";
            this.contextMenuExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // copierLURLToolStripMenuItem
            // 
            this.copierLURLToolStripMenuItem.Name = "copierLURLToolStripMenuItem";
            this.copierLURLToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.copierLURLToolStripMenuItem.Text = "Copier l\'URL";
            this.copierLURLToolStripMenuItem.Click += new System.EventHandler(this.CopyURL);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DtgEntries);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPasswordManager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).EndInit();
            this.contextMenuDtg.ResumeLayout(false);
            this.contextMenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuNewDatabase;
        private ToolStripMenuItem menuOpenDatabase;
        private ToolStripMenuItem menuCloseDatabase;
        private ToolStripMenuItem menuSaveDatabase;
        private ToolStripMenuItem menuLockDatabase;
        private ToolStripMenuItem menuExitApplication;
        private ToolStripMenuItem menuEntry;
        private ToolStripMenuItem menuAddEntry;
        private ToolStripMenuItem menuCopyUername;
        private DataGridView DtgEntries;
        private ToolStripMenuItem menuCopyPassword;
        private ContextMenuStrip contextMenuDtg;
        private ToolStripMenuItem contextMenuCopyUsername;
        private ToolStripMenuItem contextMenuCopyPassword;
        private ToolStripMenuItem contextMenuAddEntry;
        private ToolStripMenuItem contextMenuModifyEntry;
        private ToolStripMenuItem contextMenuDeleteEntry;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuNotify;
        private ToolStripMenuItem contextMenuLockDatabase;
        private ToolStripMenuItem contextMenuExit;
        private ToolStripMenuItem copierLURLToolStripMenuItem;
    }
}