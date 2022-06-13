using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SchoolComputingProjectS3
{
    public partial class BatchFileEditor : Form
    {
        public BatchFileEditor()
        {
            InitializeComponent();
        }

        private void BatchFileEditor_Load(object sender, EventArgs e)
        {
            
        }

        private string ConvertMillisecondsToSeconds(double milliseconds)
        {
            if (TimeSpan.FromMilliseconds(milliseconds).TotalSeconds > 60)
            {
                return TimeSpan.FromMilliseconds(milliseconds).TotalMinutes.ToString("0.00") + "m";
            }
            return TimeSpan.FromMilliseconds(milliseconds).TotalSeconds.ToString("0.00") + "s";
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            int filecount = listBox1.Items.Count;
            var TimeTrack = Stopwatch.StartNew();
            var elapsedTime = TimeTrack.ElapsedMilliseconds;

            if (filecount > 0)
            {
                if (ShouldDeleteFiles.Checked) // For deleting all files.
                {
                    foreach (string file in listBox1.Items)
                    {
                        File.Delete(file);
                        ElapsedTimeText.Text = "Elapsed Time: " + ConvertMillisecondsToSeconds(elapsedTime).ToString();
                    }
                }

                if (ShouldMoveFiles.Checked) // Move files to a directory.
                {
                    FolderBrowserDialog MoveFileDirectory = new FolderBrowserDialog();
                    MoveFileDirectory.Description = "Select a new directory to move files to.";


                    if (MoveFileDirectory.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in listBox1.Items)
                        {
                            if (File.Exists(file))
                            {
                                File.Move(file, MoveFileDirectory.SelectedPath + Path.DirectorySeparatorChar + Path.GetFileName(file));
                                ElapsedTimeText.Text = "Elapsed Time: " + ConvertMillisecondsToSeconds(elapsedTime).ToString();
                            }
                        }
                    }
                }

                if (ShouldEditFile.Checked) // Batch Text Adder.
                {
                    foreach (string file in listBox1.Items)
                    {
                        File.WriteAllText(file, TextAddBox.Text);
                        ElapsedTimeText.Text = "Elapsed Time: " + ConvertMillisecondsToSeconds(elapsedTime).ToString();
                    }
                }

                MessageBox.Show("Process Done!");
                return;
            }
            {
                MessageBox.Show("You haven't added any files!");
                return;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FileDirectory = new FolderBrowserDialog();
            FileDirectory.Description = "Select files that you want to edit."; 

            if(FileDirectory.ShowDialog() == DialogResult.OK)
            {
                foreach (string dirfiles in Directory.GetFiles(FileDirectory.SelectedPath, "*.txt", SearchOption.AllDirectories))
                {
                    if (!listBox1.Items.Contains(dirfiles))
                    {
                        listBox1.Items.Add(dirfiles);
                    }
                    else
                    {

                        listBox1.Items.Add(dirfiles);
                    }
                }
                FileListCount.Text = "Added Files: " + listBox1.Items.Count;
            }
        }

        private void SelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Text Files|*.txt;";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OpenFileDialog.FileNames)
                {
                    if (!listBox1.Items.Contains(file))
                    {
                        listBox1.Items.Add(file);
                    }
                }
                FileListCount.Text = "Added Files: " + listBox1.Items.Count;
            }
        }

        private void ClearFiles_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; --i)
            {
                listBox1.Items.RemoveAt(i);
            }
            FileListCount.Text = "Added Files: " + listBox1.Items.Count;
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FileListCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
