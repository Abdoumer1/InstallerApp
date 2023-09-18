using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InstallerApp
{
    public partial class data4 : Form
    {
        public data4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Activated += data4_Activated;
        }
        private void data4_Activated(object sender, EventArgs e)
        {
            Updatelist();
        }
        public void Updatelist()
        {
            files.Items.Clear();
            foreach (string file in Class.informations.selectedFilePaths)
            {
                files.Items.Add(System.IO.Path.GetFileName(file));
            }
            foreach (string folder in Class.informations.selectedFolderPaths)
            {
                files.Items.Add(System.IO.Path.GetDirectoryName(folder));
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            local3 parent = new local3();
            parent.ShowDialog();
            this.Hide();
            int a;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if ((!have.Checked && Class.informations.filemain != null) || (have.Checked))
            {
                association5 form = new association5();
                form.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Main File Empty please Chose it or Check option of you don' need Main File");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void have_CheckedChanged(object sender, EventArgs e)
        {
            if (have.Checked)
            {
                browse.Enabled = false;
            }
            else
            {
                browse.Enabled = true;
            }
        }
        private void selectfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Class.informations.selectedFilePaths.Add(fileDialog.FileName);
                edite.Enabled = true;
                delete.Enabled = true;
                files.Enabled = true;
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(fileDialog.FileName));
                files.Items.Add(System.IO.Path.GetFileName(fileDialog.FileName),imageList1.Images.Count);
                
            }
        }
        private void selectfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                Class.informations.selectedFolderPaths.Add(folderDialog.SelectedPath);
                edite.Enabled = true;
                delete.Enabled = true;
                files.Enabled = true;
                files.Items.Add(System.IO.Path.GetDirectoryName(folderDialog.SelectedPath));
            }
        }

        private void selectmainfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Class.informations.filemain= fileDialog.FileName;
                edite.Enabled = true;
                delete.Enabled = true;
                files.Enabled = true;
                path.Text = fileDialog.FileName;
                files.Items.Add(System.IO.Path.GetFileName(fileDialog.FileName));
            }
        }
        private void edite_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 1)
            {
                files.SelectedItems[0].BeginEdit();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in files.SelectedItems)
            {
                files.Items.Remove(selectedItem);
                string itemName = selectedItem.SubItems[0].Text;
                string itemPath = selectedItem.SubItems[1].Text;

                if (File.Exists(itemPath))
                {
                    File.Delete(itemPath);
                }
                else if (Directory.Exists(itemPath))
                {
                    Directory.Delete(itemPath, true);
                }
            }
        } 
    }
}
