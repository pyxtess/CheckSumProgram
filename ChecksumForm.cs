using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecksumProgram
{

    public partial class ChecksumForm : Form
    {
        public string selectedPath = null;

        public bool folderCheck = false;

        public bool cancelProcess = false;
        public enum Algorithm { SHA1, MD5};

        public Algorithm selectedAlgorithm;

        public ChecksumForm()
        {
            InitializeComponent();
            fileListBox.Enabled = false;
            extensionListBox.Enabled = false;
            calculateButton.Enabled = false;
            //------------------------------------
            selectedAlgorithm = Algorithm.SHA1;
            PbFinish();
            progressLabel.Text = "Ready to Calculate (SHA1)";
            algo1MenuItem.Checked = true;
            algo2MenuItem.Checked = false;

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
            {
                ResetAll();
                fileListBox.Enabled = false;
                extensionListBox.Enabled = false;

                folderCheck = false;
                selectedPath = ofd.FileName;
                this.Text = "Selected Path: " + selectedPath + " - FroggyCat's Checksum Calculator";
            }

            fileCountLabel.Text = "File Count: N/A";
            extensionLabel.Text = "Extensions: N/A";
            calculateButton.Enabled = true;
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                fileListBox.Enabled = true;
                extensionListBox.Enabled = true;
                ResetAll();

                folderCheck = true;
                selectedPath = fbd.SelectedPath;
                this.Text = "Selected Path: " + selectedPath + " - FroggyCat's Checksum Calculator";
                InitListBoxes();

            }
            extensionLabel.Text = "Extensions:";
            fileListBox.Enabled = true;
            extensionListBox.Enabled = true;
            calculateButton.Enabled = true;
        }

        public void InitListBoxes()
        {
            string[] allfiles = Directory.GetFiles(selectedPath, "*.*", SearchOption.AllDirectories);
            List<string> filetypeList = new List<string>();
            foreach (string filepath in allfiles)
            {
                string extenstion = Path.GetExtension(filepath);

                if (!filetypeList.Contains(extenstion))
                    filetypeList.Add(extenstion);
            }

            extensionListBox.Items.Add(".*");
            extensionListBox.SelectedIndex = 0;

            foreach (string e in filetypeList)
                extensionListBox.Items.Add(e);

            filetypeList.Clear();
        }
                    

        private static string CalculateChecksumFromFilePathSHA1(string filepath)
        {
            using var sha1 = SHA1.Create();
            using var stream = File.OpenRead(filepath);
            var hash = sha1.ComputeHash(stream);
            var checksum = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            return checksum;
        }

        private static string CalculateChecksumFromFilePathMD5(string filepath)
        {
            using var sha1 = MD5.Create();
            using var stream = File.OpenRead(filepath);
            var hash = sha1.ComputeHash(stream);
            var checksum = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            return checksum;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (folderCheck && extensionListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an extension first!");
                return;
            }

            if (selectedPath == null)
            {
                MessageBox.Show("Please select a file or folder first!");
                return;
            }


            calculateButton.Visible = false;
            //cancelButton.Visible = true;

            fileListBox.Enabled = false;
            extensionListBox.Enabled = false;
            calculateButton.Enabled = false;
            newMenuItem.Enabled = false;
            openFileMenuItem.Enabled = false;
            openFolderMenu.Enabled = false;
            exportMenuItem.Enabled = false;


            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "txt files (*.txt)|*.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    switch (selectedAlgorithm)
                    {
                        case Algorithm.SHA1:
                            //For a Specific File
                            if (!folderCheck)
                            {
                                InitProgressBar(3);

                                progressLabel.Text = "Setting Up New File End Path...";
                                if (File.Exists(save.FileName))
                                    File.Delete(save.FileName);
                                PbTaskComplete();

                                using StreamWriter sw = File.AppendText(save.FileName);
                                progressLabel.Text = "Calculating Checksum (SHA1)";
                                sw.WriteLine(CalculateChecksumFromFilePathSHA1(selectedPath));
                                PbTaskComplete();

                                progressLabel.Text = "Finalizing...";
                                Process.Start("explorer.exe", save.FileName);
                                PbTaskComplete();

                                progressLabel.Text = "Done";
                            }
                            //For Multiple Files (Folders + Subfolders)
                            else
                            {
                                string[] allfiles = Directory.GetFiles(selectedPath, "*" + extensionListBox.SelectedItem, SearchOption.AllDirectories);

                                InitProgressBar(allfiles.Length + 2);

                                progressLabel.Text = "Setting Up New File End Path...";
                                if (File.Exists(save.FileName))
                                    File.Delete(save.FileName);

                                PbTaskComplete();
                                int i = 1;
                                using StreamWriter sw = File.AppendText(save.FileName);
                                foreach (string file in allfiles)
                                {
                                    progressLabel.Text = "Calculating Checksum (SHA1) from file " + i + " of " + allfiles.Length;
                                    sw.WriteLine(CalculateChecksumFromFilePathSHA1(file));
                                    PbTaskComplete();
                                    ++i;
                                }

                                progressLabel.Text = "Finalizing...";
                                Process.Start("explorer.exe", save.FileName);
                                PbTaskComplete();

                                progressLabel.Text = "Done";
                            }
                            break;

                        case Algorithm.MD5:
                            //For a Specific File
                            if (!folderCheck)
                            {
                                InitProgressBar(3);

                                progressLabel.Text = "Setting Up New File End Path...";
                                if (File.Exists(save.FileName))
                                    File.Delete(save.FileName);
                                PbTaskComplete();

                                using StreamWriter sw = File.AppendText(save.FileName);
                                progressLabel.Text = "Calculating Checksum (SHA1)";
                                sw.WriteLine(CalculateChecksumFromFilePathMD5(selectedPath));
                                PbTaskComplete();

                                progressLabel.Text = "Finalizing...";
                                Process.Start("explorer.exe", save.FileName);
                                PbTaskComplete();

                                progressLabel.Text = "Done";
                            }
                            //For Multiple Files (Folders + Subfolders)
                            else
                            {
                                string[] allfiles = Directory.GetFiles(selectedPath, "*" + extensionListBox.SelectedItem, SearchOption.AllDirectories);

                                InitProgressBar(allfiles.Length + 2);

                                progressLabel.Text = "Setting Up New File End Path...";
                                if (File.Exists(save.FileName))
                                    File.Delete(save.FileName);

                                PbTaskComplete();
                                int i = 1;
                                using StreamWriter sw = File.AppendText(save.FileName);
                                foreach (string file in allfiles)
                                {
                                    progressLabel.Text = "Calculating Checksum (SHA1) from file " + i + " of " + allfiles.Length;
                                    sw.WriteLine(CalculateChecksumFromFilePathMD5(file));
                                    PbTaskComplete();
                                    ++i;
                                }

                                progressLabel.Text = "Finalizing...";
                                Process.Start("explorer.exe", save.FileName);
                                PbTaskComplete();

                                progressLabel.Text = "Done";
                            }
                            break;

                        default:
                            MessageBox.Show("Option not Implemented");
                            break;
                    }
                }
            }
            calculateButton.Visible = true;
            cancelButton.Visible = false;

            fileListBox.Enabled = true;
            extensionListBox.Enabled = true;
            calculateButton.Enabled = true;
            newMenuItem.Enabled = true;
            openFileMenuItem.Enabled = true;
            openFolderMenu.Enabled = true;
            exportMenuItem.Enabled = true;
        }

        private void InitProgressBar(int totalTasks)
        {
            progressBar.Value = 0;
            progressBar.Maximum = totalTasks;
        }

        private void PbTaskComplete()
        {
            progressBar.Value++;
        }

        private void PbFinish()
        {
            progressBar.Value = 0;
            progressLabel.Text = selectedAlgorithm switch
            {
                Algorithm.SHA1 => "Ready to Calculate (SHA1)",
                Algorithm.MD5 => "Ready to Calculate (MD5)",
                _ => "Ready to Calculate",
            };
        }


        public void ResetAll()
        {
            selectedPath = null;
            this.Text = "Selected Path: [TBD] - FroggyCat's Checksum Calculator";

            selectedAlgorithm = Algorithm.SHA1;
            PbFinish();
            progressLabel.Text = "Ready to Calculate (SHA1)";
            algo1MenuItem.Checked = true;
            algo2MenuItem.Checked = false;

            PbFinish();

            fileListBox.Items.Clear();
            extensionListBox.Items.Clear();
            fileCountLabel.Text = "File Count ([TBD]):";
            extensionLabel.Text = "Extensions:";

            fileListBox.Enabled = false;
            extensionListBox.Enabled = false;
            calculateButton.Enabled = false;
        }

        private void ExtensionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PbFinish();
            string[] selectedFileType = Directory.GetFiles(selectedPath, "*"+ extensionListBox.SelectedItem, SearchOption.AllDirectories);
            fileCountLabel.Text = "File Count (*" + extensionListBox.SelectedItem + "): " + selectedFileType.Length;
            fileListBox.Items.Clear();
            foreach (string f in selectedFileType)
                fileListBox.Items.Add(Path.GetFileName(f));
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //
            return;
        }

        private void Algo1MenuItem_Click(object sender, EventArgs e)
        {
            selectedAlgorithm = Algorithm.SHA1;
            PbFinish();
            progressLabel.Text = "Ready to Calculate (SHA1)";
            algo1MenuItem.Checked = true;
            algo2MenuItem.Checked = false;
        }

        private void Algo2MenuItem_Click(object sender, EventArgs e)
        {
            selectedAlgorithm = Algorithm.MD5;
            PbFinish();
            progressLabel.Text = "Ready to Calculate (MD5)";
            algo1MenuItem.Checked = false;
            algo2MenuItem.Checked = true;
        }

        private void AboutStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aForm = new AboutForm();
            aForm.Show();
        }
    }
}
