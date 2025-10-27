using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace ThreadingApplication
{
    public partial class frmTrackThread : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        public frmTrackThread()
        {
            InitializeComponent();
            statustxt.Text = "ALL SET AND READY TO GO!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllocConsole();
            statustxt.Text = "---THREAD STARTING---";
            Console.WriteLine("---THREAD STARTS---");
            Thread threadA = new Thread(ThreadClass.Thread1) { Name = "Thread A", Priority = ThreadPriority.Highest };
            Thread threadB = new Thread(ThreadClass.Thread1) { Name = "Thread B", Priority = ThreadPriority.Normal };
            Thread threadC = new Thread(ThreadClass.Thread2) { Name = "Thread C", Priority = ThreadPriority.AboveNormal };
            Thread threadD = new Thread(ThreadClass.Thread2) { Name = "Thread D", Priority = ThreadPriority.BelowNormal };
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            Console.WriteLine("---THREAD ENDED---");
            statustxt.Text = "---THREAD ENDING...---";
        }

        private void frmTrackThread_Load(object sender, EventArgs e)
        {
            /*AllocConsole();
            statustxt.Text = "---THREAD STARTING---";
            Thread starter = new Thread(StartAndJoinThreads);
            starter.IsBackground = true;
            starter.Start();*/
        }
        private void StartAndJoinThreads()
        {
            Console.WriteLine("---THREAD STARTS---");
            Thread threadA = new Thread(ThreadClass.Thread1) { Name = "Thread A", Priority = ThreadPriority.Highest };
            Thread threadB = new Thread(ThreadClass.Thread1) { Name = "Thread B", Priority = ThreadPriority.Normal };
            Thread threadC = new Thread(ThreadClass.Thread2) { Name = "Thread C", Priority = ThreadPriority.AboveNormal };
            Thread threadD = new Thread(ThreadClass.Thread2) { Name = "Thread D", Priority = ThreadPriority.BelowNormal };
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            Console.WriteLine("---THREAD ENDED---");
            this.Invoke((MethodInvoker)delegate
            {
                statustxt.Text = "---THREAD ENDING...---";
            });
        }
    }
}
