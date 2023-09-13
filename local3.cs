using System;
using System.Windows.Forms;

namespace InstallerApp
{
    public partial class local3 : Form
    {
        public local3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            direct.Text = Class.informations.direct;
            FolderName.Text = Class.informations.folder;
        }
        private void back_Click(object sender, EventArgs e)
        {
            information2 parent = new information2();
            parent.ShowDialog();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (!folder.Checked)
            {
                if (FolderName.Text.Length <= 1)
                {
                    MessageBox.Show("You must chose a name for your folder or uncheeck the options");
                }
                else
                {
                    Class.informations.folder = FolderName.Text;
                    data4 form = new data4();
                    form.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                Class.informations.folder = null;
                data4 form = new data4();
                form.ShowDialog();
                this.Hide();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void folder_CheckedChanged(object sender, EventArgs e)
        {
            if (folder.Checked)
            {
                FolderName.Enabled = false;
            }
            else
            {
                FolderName.Enabled = true;
            }
        }

        private void destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (destination.Text == "Other Direct")
            {
                
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        direct.Text = folderBrowserDialog.SelectedPath;
                        Class.informations.direct = folderBrowserDialog.SelectedPath;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid directory for installation.", "Directory Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
                direct.Text = Class.informations.direct;
            }
            
            direct.Text = Class.informations.direct;
        }
        private void name_Leave(object sender, EventArgs e)
        {
            if (FolderName.Text == "")
            {
                FolderName.Text = "My program";
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (FolderName.Text == "My program")
            {
                FolderName.Text = "";
            }

        }
    }
}
