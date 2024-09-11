using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BackGroundWorkerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSyncronius_Click(object sender, EventArgs e)
        {
            int max = 500;
            progressBar1.Value = 0;
            listBox1.Items.Clear();

            int result = 0;
            for (int i = 0; i < max; i++)
            {
                if (i % 42 == 0)
                {
                    listBox1.Items.Add(i);
                   result++;
                }

                System.Threading.Thread.Sleep(1);
                progressBar1.Value = Convert.ToInt32(((double)i / max) * 100);
            }

            MessageBox.Show($"Numbers between 0 and 10000 divisible by 7: {result}");
        }

        private void btnAsyncrounius_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            listBox1.Items.Clear();

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync(500);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show($"Numbers between 0 and 10000 divisible by 7:{e.Result}");
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           progressBar1.Value = e.ProgressPercentage;
            if(e.UserState != null)
            {
                listBox1.Items.Add(e.UserState);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int max = (int)e.Argument;
            int result = 0;
            for (int i = 0; i < max; i++)
            {
                int progressPercentage = Convert.ToInt32(((double)i / max) * 100);
                if (i % 42 == 0)
                {
                    result++;
                    (sender as BackgroundWorker).ReportProgress(progressPercentage, i);
                }
                else
                    (sender as BackgroundWorker).ReportProgress(progressPercentage);
                System.Threading.Thread.Sleep(1);

            }
            e.Result = result;

        }
    }
}
