namespace FileManager
{
    partial class Form1
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
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            btnOpen = new Button();
            groupBox1 = new GroupBox();
            encryptedCheck = new CheckBox();
            compressedCheck = new CheckBox();
            btnUpdate = new Button();
            archiveCheck = new CheckBox();
            readOnlyCheck = new CheckBox();
            hiddenCheck = new CheckBox();
            systemCheck = new CheckBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblMove = new Label();
            txtdestinationPath = new TextBox();
            btnSelectDestination = new Button();
            btnCopy = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtFilePath = new TextBox();
            lblRename = new Label();
            txtRename = new TextBox();
            btnRename = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 16);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "File path:";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(56, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(encryptedCheck);
            groupBox1.Controls.Add(compressedCheck);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(archiveCheck);
            groupBox1.Controls.Add(readOnlyCheck);
            groupBox1.Controls.Add(hiddenCheck);
            groupBox1.Controls.Add(systemCheck);
            groupBox1.Location = new Point(56, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 288);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Attributes";
            // 
            // encryptedCheck
            // 
            encryptedCheck.AutoSize = true;
            encryptedCheck.Location = new Point(21, 176);
            encryptedCheck.Name = "encryptedCheck";
            encryptedCheck.Size = new Size(97, 24);
            encryptedCheck.TabIndex = 6;
            encryptedCheck.Text = "Encrypted";
            encryptedCheck.UseVisualStyleBackColor = true;
            // 
            // compressedCheck
            // 
            compressedCheck.AutoSize = true;
            compressedCheck.Location = new Point(21, 146);
            compressedCheck.Name = "compressedCheck";
            compressedCheck.Size = new Size(117, 24);
            compressedCheck.TabIndex = 5;
            compressedCheck.Text = "Compressed ";
            compressedCheck.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(21, 240);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // archiveCheck
            // 
            archiveCheck.AutoSize = true;
            archiveCheck.Location = new Point(21, 116);
            archiveCheck.Name = "archiveCheck";
            archiveCheck.Size = new Size(80, 24);
            archiveCheck.TabIndex = 3;
            archiveCheck.Text = "Archive";
            archiveCheck.UseVisualStyleBackColor = true;
            // 
            // readOnlyCheck
            // 
            readOnlyCheck.AutoSize = true;
            readOnlyCheck.Location = new Point(21, 86);
            readOnlyCheck.Name = "readOnlyCheck";
            readOnlyCheck.Size = new Size(93, 24);
            readOnlyCheck.TabIndex = 2;
            readOnlyCheck.Text = "Readonly";
            readOnlyCheck.UseVisualStyleBackColor = true;
            // 
            // hiddenCheck
            // 
            hiddenCheck.AutoSize = true;
            hiddenCheck.Location = new Point(21, 56);
            hiddenCheck.Name = "hiddenCheck";
            hiddenCheck.Size = new Size(80, 24);
            hiddenCheck.TabIndex = 1;
            hiddenCheck.Text = "Hidden";
            hiddenCheck.UseVisualStyleBackColor = true;
            // 
            // systemCheck
            // 
            systemCheck.AutoSize = true;
            systemCheck.Location = new Point(21, 26);
            systemCheck.Name = "systemCheck";
            systemCheck.Size = new Size(78, 24);
            systemCheck.TabIndex = 0;
            systemCheck.Text = "System";
            systemCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(214, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 286);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Time Parameters";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 77);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "Modified at:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 120);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Accessed at:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 35);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Created at:";
            // 
            // lblMove
            // 
            lblMove.AutoSize = true;
            lblMove.Location = new Point(56, 361);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(69, 20);
            lblMove.TabIndex = 4;
            lblMove.Text = "Move To:";
            // 
            // txtdestinationPath
            // 
            txtdestinationPath.Location = new Point(156, 359);
            txtdestinationPath.Name = "txtdestinationPath";
            txtdestinationPath.Size = new Size(375, 27);
            txtdestinationPath.TabIndex = 5;
            // 
            // btnSelectDestination
            // 
            btnSelectDestination.Location = new Point(537, 357);
            btnSelectDestination.Name = "btnSelectDestination";
            btnSelectDestination.Size = new Size(94, 29);
            btnSelectDestination.TabIndex = 6;
            btnSelectDestination.Text = "Select";
            btnSelectDestination.UseVisualStyleBackColor = true;
            btnSelectDestination.Click += btnSelectDestination_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(637, 357);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(94, 29);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(231, 12);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(500, 27);
            txtFilePath.TabIndex = 8;
            // 
            // lblRename
            // 
            lblRename.AutoSize = true;
            lblRename.Location = new Point(56, 408);
            lblRename.Name = "lblRename";
            lblRename.Size = new Size(86, 20);
            lblRename.TabIndex = 9;
            lblRename.Text = "Rename To:";
            // 
            // txtRename
            // 
            txtRename.Location = new Point(156, 405);
            txtRename.Name = "txtRename";
            txtRename.Size = new Size(375, 27);
            txtRename.TabIndex = 10;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(537, 403);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(94, 29);
            btnRename.TabIndex = 11;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRename);
            Controls.Add(txtRename);
            Controls.Add(lblRename);
            Controls.Add(txtFilePath);
            Controls.Add(btnCopy);
            Controls.Add(btnSelectDestination);
            Controls.Add(txtdestinationPath);
            Controls.Add(lblMove);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnOpen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button btnOpen;
        private GroupBox groupBox1;
        private CheckBox archiveCheck;
        private CheckBox readOnlyCheck;
        private CheckBox hiddenCheck;
        private CheckBox systemCheck;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblMove;
        private TextBox txtdestinationPath;
        private Button btnSelectDestination;
        private Button btnCopy;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtFilePath;
        private Label lblRename;
        private TextBox txtRename;
        private Button btnRename;
        private CheckBox compressedCheck;
        private CheckBox encryptedCheck;
    }
}