using DevPoint.OnedriveForceSync.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevPoint.OnedriveForceSync
{
    public partial class SetupFoldersForm : Form
    {
        public SetupFoldersForm()
        {
            InitializeComponent();
            //Load Paths from Settigns
            txtFolders.Text = Properties.Settings.Default["OnedrivePaths"]?.ToString();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            var result = folderPicker.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderPicker.SelectedPath))
            {
                txtFolders.Text += $"{folderPicker.SelectedPath}\n";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePathToSettings();
            PromptForShortcut();
            this.Close();
        }

        private void SavePathToSettings()
        {
            Properties.Settings.Default["OnedrivePaths"] = txtFolders.Text;
            Properties.Settings.Default.Save();
        }

        private void PromptForShortcut()
        {
            var confirmResult = MessageBox.Show("Create sync icon on desktop?",
                                     "Desktop Icon",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //Save Shortcut to Desktop
                ShortcutUtil.CreateShortcut();
                MessageBox.Show("Shortcut saved to desktop - it is recommended you pin it to the taskbar");
            }
        }
    }
}