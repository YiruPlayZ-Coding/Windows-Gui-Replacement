using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsDesktop
{
    public partial class WindowsDesktop : Form
    {
        public WindowsDesktop()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Desktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gpeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\gpedit.msc");
        }

        private void regeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\regedit.exe");
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.WorkingDirectory = @"C:\";
            cmd.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            cmd.StartInfo.RedirectStandardInput = false;
            cmd.StartInfo.RedirectStandardOutput = false;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = true;
            cmd.Start();

//            cmd.StandardInput.WriteLine(@"cd c:\");
//            cmd.StandardInput.Flush();
//            cmd.StandardInput.Close();
//            cmd.WaitForExit();
//            MessageBox.Show(cmd.StandardOutput.ReadToEnd());

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\windows\system32\rundll32.exe shell32.dll,#61");
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Program Files (x86)\Notepad++\Notepad++.exe");
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\explorer.exe");
        }
    }
}
