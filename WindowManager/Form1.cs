using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowManager
{
    public partial class MainWindow : Form
    {
        private BackgroundWorker backgroundWorker;
        private bool backgroundWorkerRunningState;
        private string runningStateImgLocationError;
        private string runningStateImgLocationRunning;
        private string runningStateImgLocationPause;
        private int mouseX;
        private int mouseY;
        private bool mouseDown;
        private Button lastButton;
        private List<string> logStrings;
        private List<Rule> rules;
        
        public MainWindow()
        {
            this.InitializeComponent();
            this.LoadSettings();
            this.InitialiseBackGroundWorker();
            this.ExecuteBackgroundWorker();
        }

        private void LoadSettings()
        {
            this.runningStateImgLocationError = "error.png";
            this.runningStateImgLocationRunning = "running.png";
            this.runningStateImgLocationPause = "pause.png";
            this.logStrings = new();
            this.logStrings.Add(DateTime.Now + ": Programm started");
            this.lastButton = this.btnRules;
            this.OpenPage(this.lastButton.Name);

            this.rules = new();            
            Process process = Process.GetProcessById(32452);
            this.rules.Add(new(process, WindowShowStyle.Hide, process, WindowShowStyle.Show, 0));
        }


        #region BackgroundWorker
        private void InitialiseBackGroundWorker()
        {
            this.backgroundWorkerRunningState = true;
            this.backgroundWorker = new();
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }
        private void imgRunningState_Click(object sender, EventArgs e)
        {
            if (!this.backgroundWorker.IsBusy)
            {
                this.backgroundWorkerRunningState = true;
                this.backgroundWorker.RunWorkerAsync();
                this.UpdateLog("Backgroundworker executed");                
                this.imgRunningState.ImageLocation = this.runningStateImgLocationRunning;                
            }
            else if (this.backgroundWorker.IsBusy)
            {
                this.backgroundWorkerRunningState = false;
                this.backgroundWorker.CancelAsync();
                this.UpdateLog("Backgroundworker canceled");                
                this.imgRunningState.ImageLocation = this.runningStateImgLocationPause;
            }
            else
            {
                //Execute Error Information Window
                this.UpdateLog("Unknown error while changing runningstate");
                this.imgRunningState.ImageLocation = this.runningStateImgLocationError;
            }
        }
        private void ExecuteBackgroundWorker()
        {
            this.backgroundWorker.RunWorkerAsync();
            this.imgRunningState.ImageLocation = this.runningStateImgLocationRunning;
        }
        private async void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (this.backgroundWorkerRunningState)
            {
                foreach(Rule rule in this.rules)
                {
                    if (rule.TestIfRuleAplies())
                    {
                        await rule.ExecuteRule();
                    }
                }
                System.Threading.Thread.Sleep(500);
            }
        }
        #endregion

        #region Log
        //adds an information to the log
        private void UpdateLog(string message)
        {
            this.logStrings.Add(DateTime.Now + ": " + message);
            if (this.pnlFormLoader.Controls[0].Name == "Log")
            {
                Log log = (Log)this.pnlFormLoader.Controls[0];
                log.Refresh(this.logStrings);
            }                        
        }

        //returns the log
        public List<string> RequestLog()
        {
            return this.logStrings;
        }

        //clears the log and adds information regarding the deletion
        public void ClearLog()
        {
            this.logStrings = new();
            this.UpdateLog("Log cleared");
        }
        #endregion

        #region PageHandling
        //Event that is fired when a pageload-button is pressed
        private void ChangePanel_Click(object sender, EventArgs e)
        {
            this.lastButton.BackColor = Color.FromArgb(24, 30, 54);
            Button btn = (Button)sender;
            this.pnlNav.Height = btn.Height;
            this.pnlNav.Top = btn.Top;
            this.pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
            this.lastButton = btn;
            this.OpenPage(btn.Name);
        }


        //Opens a page using a button name
        private void OpenPage(string name)
        {
            this.pnlFormLoader.Controls.Clear();
            Form form = GetFormByName(name);
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(form);
            form.Show();
        }


        //Returns a page using a button name
        private Form GetFormByName(string name)
        {
            switch (name)
            {
                case "btnRules":
                    return new Rules();
                case "btnAddRule":
                    return new AddRule();
                case "btnSettings":
                    return new Settings();
                case "btnLog":
                    return new Log(this.logStrings, this);
                default:
                    return new Rules();
            }
        }
        #endregion

        #region WindowControll

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.backgroundWorkerRunningState = false;
            this.backgroundWorker.CancelAsync();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizeToTray_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void notificationIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        
        #region MoveWindow
        private void pnlControllWindow_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }
        private void pnlControllWindow_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }
        private void pnlControllWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new(p.X - this.mouseX, p.Y - this.mouseY);                
            }
        }
        #endregion

        #endregion        
    }
}
