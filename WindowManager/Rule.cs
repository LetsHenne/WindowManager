using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowManager
{
    public class Rule
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        public Rule(Process ifProcess, WindowShowStyle ifState, Process thenProcess, WindowShowStyle thenState, int delayInTicks)
        {
            this.ID = Guid.NewGuid();
            this.IfProcess = ifProcess;
            this.IfState = ifState;
            this.ThenProcess = thenProcess;
            this.ThenState = thenState;
            this.DelayInTicks = delayInTicks;
        }
        public Guid ID
        {
            get;
            set;
        }
        public Process IfProcess
        {
            private get;
            set;
        }
        public WindowShowStyle IfState
        {
            private get;
            set;
        }
        public Process ThenProcess
        {
            private get;
            set;
        }
        public WindowShowStyle ThenState
        {
            private get;
            set;
        }
        public int DelayInTicks
        {
            get;
            set;
        }
        public bool TestIfRuleAplies()
        {
            this.IfProcess.Refresh();                        
            if (GetProcessPlacement(this.IfProcess) == this.IfState)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Task ExecuteRule()
        {
            return Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(this.DelayInTicks);
                ShowWindowAsync(this.ThenProcess.MainWindowHandle, (int)this.ThenState);
            });
        }
        private WindowShowStyle GetProcessPlacement(Process p)
        {
            if(p.MainWindowHandle == IntPtr.Zero)
            {
                return WindowShowStyle.Hide;
            }
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            GetWindowPlacement(p.MainWindowHandle, ref placement);
            switch (placement.showCmd)
            {
                case 1:
                    return WindowShowStyle.Show;                    
                case 2:
                    return WindowShowStyle.Minimize;                    
                case 3:
                    return WindowShowStyle.Maximize;
                default:
                    return WindowShowStyle.Hide;
            }
        }
    }
}
