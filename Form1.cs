using System.ComponentModel;
using System.IO;

namespace CopyDirTaskOs
{

    public partial class Form1 : Form
    {

        public static BackgroundWorker Worker = new();


        public void extention(string Text)
        {
            typeList.Items.Clear();
            /*string type = "";*/
            foreach (string CurrentFile in Directory.GetFiles(Text, "*.*", SearchOption.AllDirectories))
            {
                string type = CurrentFile.Substring(CurrentFile.LastIndexOf('.') + 1);

                if (!typeList.Items.Contains(type))
                {
                    typeList.Items.Add(type);
                }
            }

        }

        public void DeepCopy(DirectoryInfo directory, string destinationPath)
        {
            string type = "*.*";
            /*comboBox1.Invoke((MethodInvoker)(() => comboBox1.SelectedText));*/

            int pre = Directory.EnumerateFileSystemEntries(destinationPath, type, SearchOption.AllDirectories).Count();

            foreach (string dir in Directory.GetDirectories(directory.FullName, $"*", SearchOption.AllDirectories))
            {
                string dirToCreate = dir.Replace(directory.FullName, destinationPath);
                Directory.CreateDirectory(dirToCreate);
                Worker.ReportProgress((Directory.EnumerateFileSystemEntries(destinationPath, type, SearchOption.AllDirectories).Count() - pre) * 100 /
                                     (Directory.EnumerateFileSystemEntries(directory.FullName, type, SearchOption.AllDirectories).Count()));

            }

            foreach (string CurrentFile in Directory.GetFiles(directory.FullName, type, SearchOption.AllDirectories))
            {

                File.Copy(CurrentFile, CurrentFile.Replace(directory.FullName, destinationPath), true);

                Worker.ReportProgress((Directory.EnumerateFileSystemEntries(destinationPath, type, SearchOption.AllDirectories).Count() - pre) * 100 /
                                     Directory.EnumerateFileSystemEntries(directory.FullName, type, SearchOption.AllDirectories).Count());

            }
            MessageBox.Show("copied");
            Worker.ReportProgress(0);

        }

        public Form1()
        {
            InitializeComponent();
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            Worker.DoWork += Worker_DoWork;
            Worker.ProgressChanged += Worker_ProgressChanged;

        }

        private void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            Copybar.Value = e.ProgressPercentage;
            progressNum.Text = Copybar.Value.ToString() + '%';
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            var sourceDir = new DirectoryInfo(sourcePathtxt.Text);

            DeepCopy(sourceDir, destinationPathtxt.Text);
        }

        private void sourceDirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sfd = new();


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sourcePathtxt.Text = sfd.SelectedPath;
                extention(sourcePathtxt.Text);
            }
        }

        private void destinationPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sfd = new();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                destinationPathtxt.Text = sfd.SelectedPath;
            }

        }

        private void Copybtn_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}