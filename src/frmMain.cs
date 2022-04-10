using UTDRMusicRandomizer;

namespace UTDR_Music_Randomizer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void EnableOrDisableControls(bool enable)
        {
            txtBrowsePath.Enabled = enable;
            btnBrowse.Enabled = enable;
            btnRandomize.Enabled = enable;
            btnRestoreFromBackup.Enabled = enable;

            foreach (CheckBox c in grpOptions.Controls) c.Enabled = enable;
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtBrowsePath.Text))
            {
                MessageBox.Show("Directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!UTDRRandomizer.IsValidPath(txtBrowsePath.Text))
            {
                MessageBox.Show("Please select a valid install path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnableOrDisableControls(false);
                bool makeBackup = false;
                if (UTDRRandomizer.BackupFolderExists(txtBrowsePath.Text))
                {
                    var answer = MessageBox.Show("Backup folder already exists. Overwrite it? (If you have randomized previously, this will backup the randomized files!)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        makeBackup = true;
                    }
                }
                else
                {
                    makeBackup = true;
                }

                var options = new RandoOptions(
                    cbOptSpeedrunLegal.Checked,
                    cbOptCyberBattle.Checked,
                    cbOptMultiPart.Checked,
                    cbOptCredits.Checked,
                    cbOptAmbience.Checked,
                    cbOptSFX.Checked
                );

                var result = UTDRRandomizer.Randomize(txtBrowsePath.Text, options, makeBackup);
                MessageBox.Show(result.Message, (result.Success ? "Info" : "Error"), MessageBoxButtons.OK, (result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error));

                EnableOrDisableControls(true);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var search = new FolderBrowserDialog();
            search.Description = "Select folder";

            if (search.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(search.SelectedPath))
                {
                    if (UTDRRandomizer.IsValidPath(search.SelectedPath))
                    {
                        txtBrowsePath.Text = search.SelectedPath;
                        btnRandomize.Enabled = true;
                        btnRestoreFromBackup.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid install path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestoreFromBackup_Click(object sender, EventArgs e)
        {
            if (!UTDRRandomizer.IsValidPath(txtBrowsePath.Text))
            {
                MessageBox.Show("Please select a valid install path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!UTDRRandomizer.BackupFolderExists(txtBrowsePath.Text))
            {
                MessageBox.Show("Directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnableOrDisableControls(false);
                bool restored = UTDRRandomizer.RestoreFromBackup(txtBrowsePath.Text);
                if (restored)
                {
                    MessageBox.Show("Restored from backup!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //something went wrong while restoring the backup
                {
                    MessageBox.Show("A fatal error occurred, and data could not be recovered. Please reinstall the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                EnableOrDisableControls(true);
            }
        }
    }
}