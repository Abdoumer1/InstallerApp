using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InstallerApp
{
    public partial class finish6 : Form
    {
        public finish6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Activated += finish6_Activated;
        }
        private void finish6_Activated(object sender, EventArgs e)
        {
            Updatelist();
        }
        public void Updatelist()
        {
            Folders.Items.Clear();
            Files.Items.Clear();
            foreach (string file in Class.informations.selectedFilePaths)
            {
                Files.Items.Add(System.IO.Path.GetFileName(file));
            }
            foreach (string folder in Class.informations.selectedFolderPaths)
            {
                Folders.Items.Add(System.IO.Path.GetDirectoryName(folder));
            }
            Path.Text = Class.informations.direct;
        }
        public void s()
        {
            MessageBox.Show("operation seccussfly");
        }
        private void Back_Click(object sender, EventArgs e)
        {
            association5 parent = new association5();
            parent.ShowDialog();
            this.Hide();
        }
        private void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = System.IO.Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = System.IO.Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, temppath);
            }
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            if (Class.informations.selectedFilePaths.Count > 0 || Class.informations.selectedFolderPaths.Count > 0)
            {

                if (Class.informations.filemain == null)
                {
                    if (Class.informations.folder != null)
                    {
                        string targetDirectory = System.IO.Path.Combine(Class.informations.direct, Class.informations.folder);
                        if (!Directory.Exists(targetDirectory))
                        {
                            Directory.CreateDirectory(targetDirectory);
                        }
                        else
                        {
                            Directory.Delete(targetDirectory);
                            Directory.CreateDirectory(targetDirectory);
                        }
                        foreach (string filePath in Class.informations.selectedFilePaths)
                        {
                            string fileName = System.IO.Path.GetFileName(filePath);
                            string targetFilePath = System.IO.Path.Combine(targetDirectory, fileName);
                            File.Copy(filePath, targetFilePath, true);
                        }

                        foreach (string folderPath in Class.informations.selectedFolderPaths)
                        {
                            string folderName = new DirectoryInfo(folderPath).Name;
                            string targetFolderPath = System.IO.Path.Combine(targetDirectory, folderName);
                            DirectoryCopy(folderPath, targetFolderPath);
                        }
                        s();
                    }
                    else
                    {
                        string targetDirectory = System.IO.Path.Combine(Class.informations.direct);
                        foreach (string filePath in Class.informations.selectedFilePaths)
                        {
                            string fileName = System.IO.Path.GetFileName(filePath);
                            string targetFilePath = System.IO.Path.Combine(targetDirectory, fileName);
                            File.Copy(filePath, targetFilePath, true);
                        }

                        foreach (string folderPath in Class.informations.selectedFolderPaths)
                        {
                            string folderName = new DirectoryInfo(folderPath).Name;
                            string targetFolderPath = System.IO.Path.Combine(targetDirectory, folderName);
                            DirectoryCopy(folderPath, targetFolderPath);
                        }
                        s();
                    }
                }
                else
                {
                    if (Class.informations.folder != null)
                    {
                        string targetDirectory = System.IO.Path.Combine(Class.informations.direct, Class.informations.folder);
                        if (!Directory.Exists(targetDirectory))
                        {
                            Directory.CreateDirectory(targetDirectory);
                        }
                        else
                        {
                            Directory.Delete(targetDirectory);
                            Directory.CreateDirectory(targetDirectory);
                        }
                        string SecondDirectory = System.IO.Path.Combine(targetDirectory, "package");
                        Directory.CreateDirectory(SecondDirectory);
                        foreach (string filePath in Class.informations.selectedFilePaths)
                        {
                            string fileName = System.IO.Path.GetFileName(filePath);
                            string targetFilePath = System.IO.Path.Combine(SecondDirectory, fileName);
                            File.Copy(filePath, targetFilePath, true);
                        }

                        foreach (string folderPath in Class.informations.selectedFolderPaths)
                        {
                            string folderName = new DirectoryInfo(folderPath).Name;
                            string targetFolderPath = System.IO.Path.Combine(SecondDirectory, folderName);
                            DirectoryCopy(folderPath, targetFolderPath);
                        }
                        string name = System.IO.Path.GetFileName(Class.informations.filemain);
                        string target = System.IO.Path.Combine(targetDirectory, name);
                        File.Copy(Class.informations.filemain, target);
                        s();
                    }
                    else
                    {
                        string targetDirectory = System.IO.Path.Combine(Class.informations.direct);
                        string SecondDirectory = System.IO.Path.Combine(targetDirectory, "package");
                        Directory.CreateDirectory(SecondDirectory);
                        foreach (string filePath in Class.informations.selectedFilePaths)
                        {
                            string fileName = System.IO.Path.GetFileName(filePath);
                            string targetFilePath = System.IO.Path.Combine(SecondDirectory, fileName);
                            File.Copy(filePath, targetFilePath, true);
                        }

                        foreach (string folderPath in Class.informations.selectedFolderPaths)
                        {
                            string folderName = new DirectoryInfo(folderPath).Name;
                            string targetFolderPath = System.IO.Path.Combine(SecondDirectory, folderName);
                            DirectoryCopy(folderPath, targetFolderPath);
                        }
                        string name = System.IO.Path.GetFileName(Class.informations.filemain);
                        string target = System.IO.Path.Combine(targetDirectory, name);
                        File.Copy(Class.informations.filemain, target);
                        s();
                    }
                }
            }
            else
            {
                MessageBox.Show("there's no files or folders to copy them, please go back and select your paths");
            }
        }
        public void Cancel_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            start parent = new start();
            parent.ShowDialog();
            this.Hide();
        }
    }
}
