
namespace WindowManager
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuerytime = new System.Windows.Forms.Label();
            this.imgRunningState = new System.Windows.Forms.PictureBox();
            this.pnlControllWindow = new System.Windows.Forms.Panel();
            this.btnMinimizeToTray = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRunningState)).BeginInit();
            this.pnlControllWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnAddRule);
            this.panel1.Controls.Add(this.btnRules);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 161);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 42);
            this.pnlNav.TabIndex = 11;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 535);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.ChangePanel_Click);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLog.Location = new System.Drawing.Point(0, 245);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(186, 42);
            this.btnLog.TabIndex = 12;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.ChangePanel_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRule.FlatAppearance.BorderSize = 0;
            this.btnAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRule.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddRule.Location = new System.Drawing.Point(0, 203);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(186, 42);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.ChangePanel_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRules.Location = new System.Drawing.Point(0, 161);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(186, 42);
            this.btnRules.TabIndex = 1;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.ChangePanel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblQuerytime);
            this.panel2.Controls.Add(this.imgRunningState);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 161);
            this.panel2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(50, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 15);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "500";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuerytime
            // 
            this.lblQuerytime.AutoSize = true;
            this.lblQuerytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuerytime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblQuerytime.Location = new System.Drawing.Point(50, 109);
            this.lblQuerytime.Name = "lblQuerytime";
            this.lblQuerytime.Size = new System.Drawing.Size(81, 16);
            this.lblQuerytime.TabIndex = 1;
            this.lblQuerytime.Text = "Query time";
            // 
            // imgRunningState
            // 
            this.imgRunningState.Image = ((System.Drawing.Image)(resources.GetObject("imgRunningState.Image")));
            this.imgRunningState.Location = new System.Drawing.Point(60, 22);
            this.imgRunningState.Name = "imgRunningState";
            this.imgRunningState.Size = new System.Drawing.Size(63, 63);
            this.imgRunningState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRunningState.TabIndex = 0;
            this.imgRunningState.TabStop = false;
            this.imgRunningState.Click += new System.EventHandler(this.imgRunningState_Click);
            // 
            // pnlControllWindow
            // 
            this.pnlControllWindow.Controls.Add(this.btnMinimizeToTray);
            this.pnlControllWindow.Controls.Add(this.btnMinimize);
            this.pnlControllWindow.Controls.Add(this.btnClose);
            this.pnlControllWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControllWindow.Location = new System.Drawing.Point(186, 0);
            this.pnlControllWindow.Name = "pnlControllWindow";
            this.pnlControllWindow.Size = new System.Drawing.Size(765, 36);
            this.pnlControllWindow.TabIndex = 2;
            this.pnlControllWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControllWindow_MouseDown);
            this.pnlControllWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControllWindow_MouseMove);
            this.pnlControllWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlControllWindow_MouseUp);
            // 
            // btnMinimizeToTray
            // 
            this.btnMinimizeToTray.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeToTray.FlatAppearance.BorderSize = 0;
            this.btnMinimizeToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeToTray.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizeToTray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMinimizeToTray.Location = new System.Drawing.Point(570, 0);
            this.btnMinimizeToTray.Name = "btnMinimizeToTray";
            this.btnMinimizeToTray.Size = new System.Drawing.Size(65, 36);
            this.btnMinimizeToTray.TabIndex = 4;
            this.btnMinimizeToTray.Text = "==";
            this.btnMinimizeToTray.UseVisualStyleBackColor = true;
            this.btnMinimizeToTray.Click += new System.EventHandler(this.btnMinimizeToTray_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMinimize.Location = new System.Drawing.Point(635, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(65, 36);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClose.Location = new System.Drawing.Point(700, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // notificationIcon
            // 
            this.notificationIcon.BalloonTipText = "Window Manager";
            this.notificationIcon.BalloonTipTitle = "Window Manager";
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "WindowManager";
            this.notificationIcon.Visible = true;
            this.notificationIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notificationIcon_MouseClick);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(186, 36);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(765, 541);
            this.pnlFormLoader.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnlControllWindow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRunningState)).EndInit();
            this.pnlControllWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Label lblQuerytime;
        private System.Windows.Forms.PictureBox imgRunningState;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlControllWindow;
        private System.Windows.Forms.Button btnMinimizeToTray;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Button btnLog;
    }
}

