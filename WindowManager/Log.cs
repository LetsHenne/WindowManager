using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowManager
{
    public partial class Log : Form
    {
        private MainWindow mainWindow;
        public Log(List<string> log, MainWindow window)
        {
            this.InitializeComponent();
            this.mainWindow = window;
            foreach(string txt in log)
            {
                this.boxLog.Text += txt + "\r\n";
            }            
        }
        public void Refresh(List<string> newLog)
        {
            this.boxLog.Text = string.Empty;
            foreach (string txt in newLog)
            {
                this.boxLog.Text += txt + "\r\n";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh(this.mainWindow.RequestLog());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.mainWindow.ClearLog();
            this.Refresh(this.mainWindow.RequestLog());
        }
    }
}
