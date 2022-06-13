namespace SchoolComputingProjectS3
{
    partial class BatchFileEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessButton = new System.Windows.Forms.Button();
            this.ShouldDeleteFiles = new System.Windows.Forms.CheckBox();
            this.SelectFiles = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ClearFiles = new System.Windows.Forms.Button();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.FileListCount = new System.Windows.Forms.Label();
            this.CheckboxesLabel = new System.Windows.Forms.Label();
            this.ShouldMoveFiles = new System.Windows.Forms.CheckBox();
            this.TextAdd = new System.Windows.Forms.Label();
            this.ElapsedTimeText = new System.Windows.Forms.Label();
            this.ShouldEditFile = new System.Windows.Forms.CheckBox();
            this.TextAddBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(458, 480);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(216, 90);
            this.ProcessButton.TabIndex = 2;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ShouldDeleteFiles
            // 
            this.ShouldDeleteFiles.AutoSize = true;
            this.ShouldDeleteFiles.Location = new System.Drawing.Point(19, 495);
            this.ShouldDeleteFiles.Name = "ShouldDeleteFiles";
            this.ShouldDeleteFiles.Size = new System.Drawing.Size(81, 17);
            this.ShouldDeleteFiles.TabIndex = 6;
            this.ShouldDeleteFiles.Text = "Delete Files";
            this.ShouldDeleteFiles.UseVisualStyleBackColor = true;
            // 
            // SelectFiles
            // 
            this.SelectFiles.Location = new System.Drawing.Point(13, 227);
            this.SelectFiles.Name = "SelectFiles";
            this.SelectFiles.Size = new System.Drawing.Size(328, 35);
            this.SelectFiles.TabIndex = 8;
            this.SelectFiles.Text = "Select Files...";
            this.SelectFiles.UseVisualStyleBackColor = true;
            this.SelectFiles.Click += new System.EventHandler(this.SelectFiles_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.Multiselect = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(672, 212);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ClearFiles
            // 
            this.ClearFiles.Location = new System.Drawing.Point(347, 227);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(328, 35);
            this.ClearFiles.TabIndex = 10;
            this.ClearFiles.Text = "Clear Files...";
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.ClearFiles_Click);
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(13, 268);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(661, 35);
            this.SelectFolder.TabIndex = 11;
            this.SelectFolder.Text = "Select Directory";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // FileListCount
            // 
            this.FileListCount.AutoSize = true;
            this.FileListCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileListCount.ForeColor = System.Drawing.Color.Lime;
            this.FileListCount.Location = new System.Drawing.Point(58, 321);
            this.FileListCount.Name = "FileListCount";
            this.FileListCount.Size = new System.Drawing.Size(216, 39);
            this.FileListCount.TabIndex = 12;
            this.FileListCount.Text = "Added Files: ";
            this.FileListCount.Click += new System.EventHandler(this.FileListCount_Click);
            // 
            // CheckboxesLabel
            // 
            this.CheckboxesLabel.AutoSize = true;
            this.CheckboxesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxesLabel.Location = new System.Drawing.Point(14, 445);
            this.CheckboxesLabel.Name = "CheckboxesLabel";
            this.CheckboxesLabel.Size = new System.Drawing.Size(133, 25);
            this.CheckboxesLabel.TabIndex = 13;
            this.CheckboxesLabel.Text = "Checkboxes: ";
            // 
            // ShouldMoveFiles
            // 
            this.ShouldMoveFiles.AutoSize = true;
            this.ShouldMoveFiles.Location = new System.Drawing.Point(19, 528);
            this.ShouldMoveFiles.Name = "ShouldMoveFiles";
            this.ShouldMoveFiles.Size = new System.Drawing.Size(77, 17);
            this.ShouldMoveFiles.TabIndex = 14;
            this.ShouldMoveFiles.Text = "Move Files";
            this.ShouldMoveFiles.UseVisualStyleBackColor = true;
            // 
            // TextAdd
            // 
            this.TextAdd.AutoSize = true;
            this.TextAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAdd.Location = new System.Drawing.Point(181, 445);
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.Size = new System.Drawing.Size(170, 25);
            this.TextAdd.TabIndex = 15;
            this.TextAdd.Text = "Batch Text Adder:";
            // 
            // ElapsedTimeText
            // 
            this.ElapsedTimeText.AutoSize = true;
            this.ElapsedTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElapsedTimeText.ForeColor = System.Drawing.Color.Blue;
            this.ElapsedTimeText.Location = new System.Drawing.Point(379, 321);
            this.ElapsedTimeText.Name = "ElapsedTimeText";
            this.ElapsedTimeText.Size = new System.Drawing.Size(244, 39);
            this.ElapsedTimeText.TabIndex = 17;
            this.ElapsedTimeText.Text = "Elapsed Time: ";
            // 
            // ShouldEditFile
            // 
            this.ShouldEditFile.AutoSize = true;
            this.ShouldEditFile.Location = new System.Drawing.Point(19, 563);
            this.ShouldEditFile.Name = "ShouldEditFile";
            this.ShouldEditFile.Size = new System.Drawing.Size(82, 17);
            this.ShouldEditFile.TabIndex = 18;
            this.ShouldEditFile.Text = "Write In File";
            this.ShouldEditFile.UseVisualStyleBackColor = true;
            // 
            // TextAddBox
            // 
            this.TextAddBox.Location = new System.Drawing.Point(107, 480);
            this.TextAddBox.Name = "TextAddBox";
            this.TextAddBox.Size = new System.Drawing.Size(323, 111);
            this.TextAddBox.TabIndex = 19;
            this.TextAddBox.Text = "Enter text that you want added to file here.";
            // 
            // BatchFileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 627);
            this.Controls.Add(this.TextAddBox);
            this.Controls.Add(this.ShouldEditFile);
            this.Controls.Add(this.ElapsedTimeText);
            this.Controls.Add(this.TextAdd);
            this.Controls.Add(this.ShouldMoveFiles);
            this.Controls.Add(this.CheckboxesLabel);
            this.Controls.Add(this.FileListCount);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.ClearFiles);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectFiles);
            this.Controls.Add(this.ShouldDeleteFiles);
            this.Controls.Add(this.ProcessButton);
            this.Name = "BatchFileEditor";
            this.Text = "BatchFileEditor";
            this.Load += new System.EventHandler(this.BatchFileEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.CheckBox ShouldDeleteFiles;
        private System.Windows.Forms.Button SelectFiles;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ClearFiles;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Label FileListCount;
        private System.Windows.Forms.Label CheckboxesLabel;
        private System.Windows.Forms.CheckBox ShouldMoveFiles;
        private System.Windows.Forms.Label TextAdd;
        private System.Windows.Forms.Label ElapsedTimeText;
        private System.Windows.Forms.CheckBox ShouldEditFile;
        private System.Windows.Forms.RichTextBox TextAddBox;
    }
}

