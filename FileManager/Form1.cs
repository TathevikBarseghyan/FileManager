namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = string.Empty;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                txtFilePath.Text = Path.GetFullPath(openFileDialog1.FileName);
                FileAttributes fileAttributes = File.GetAttributes(filePath);
                systemCheck.Checked = (fileAttributes & FileAttributes.System) != 0;
                systemCheck.Checked = (fileAttributes & FileAttributes.Hidden) != 0;
                systemCheck.Checked = (fileAttributes & FileAttributes.ReadOnly) != 0;
                systemCheck.Checked = (fileAttributes & FileAttributes.Archive) != 0;

                label2.Text = $"Created at: {File.GetCreationTime(filePath)}";
                label3.Text = $"Modified at: {File.GetLastWriteTime(filePath)}";
                label4.Text = $"Accessed at: {File.GetLastAccessTime(filePath)}";

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                FileAttributes attributes = File.GetAttributes(filePath);
                attributes = systemCheck.Checked
                    ? attributes | FileAttributes.System
                    : attributes & ~FileAttributes.System;
                attributes = hiddenCheck.Checked
                    ? attributes | FileAttributes.Hidden
                    : attributes & ~FileAttributes.Hidden;
                attributes = readOnlyCheck.Checked
                    ? attributes | FileAttributes.ReadOnly
                    : attributes & ~FileAttributes.ReadOnly;
                attributes = archiveCheck.Checked
                    ? attributes | FileAttributes.Archive
                    : attributes & ~FileAttributes.Archive;
                attributes = compressedCheck.Checked
                    ? attributes | FileAttributes.Compressed
                    : attributes & ~FileAttributes.Compressed;
                attributes = encryptedCheck.Checked
                    ? attributes | FileAttributes.Encrypted
                    : attributes & ~FileAttributes.Encrypted;

                File.SetAttributes(filePath, attributes);
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtdestinationPath.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy(txtFilePath.Text, txtdestinationPath.Text + "\\" + Path.GetFileName(openFileDialog1.FileName));
            MessageBox.Show("File copied successfully");
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(openFileDialog1.FileName);
            //var aaa = fileName.IndexOf(".");
            string fileType = fileName.Substring(fileName.IndexOf("."), fileName.Length - fileName.IndexOf("."));

            string oldName = txtFilePath.Text;
            string getPath = oldName.Substring(0, oldName.LastIndexOf('\\'));
            string newName = txtRename.Text;

            File.Move(oldName, getPath + "\\" + newName + fileType);

            txtFilePath.Text = "";
            txtRename.Text = "";
            MessageBox.Show("File renamed successfully");
        }
    }
}