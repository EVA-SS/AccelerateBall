namespace AccelerateBall
{
    partial class MiniForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.showStyle1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showStyle2 = new System.Windows.Forms.ToolStripMenuItem();
            this.transparecy = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity95 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity85 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity80 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity75 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity50 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadRate = new System.Windows.Forms.Label();
            this.downloadRate = new System.Windows.Forms.Label();
            this.rateUnit1 = new System.Windows.Forms.Label();
            this.rateUnit2 = new System.Windows.Forms.Label();
            this.showDetailFormTimer = new System.Windows.Forms.Timer(this.components);
            this.hideDetailFormTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.up_down_image = new System.Windows.Forms.PictureBox();
            this.la = new System.Windows.Forms.Label();
            this.miniBallControl = new AccelerateBall.MainBallControl();
            this.mainContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.up_down_image)).BeginInit();
            this.miniBallControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStyle,
            this.transparecy,
            this.toolStripSeparator1,
            this.quit});
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(125, 76);
            // 
            // showStyle
            // 
            this.showStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStyle1,
            this.showStyle2});
            this.showStyle.Name = "showStyle";
            this.showStyle.Size = new System.Drawing.Size(124, 22);
            this.showStyle.Text = "显示方式";
            // 
            // showStyle1
            // 
            this.showStyle1.Name = "showStyle1";
            this.showStyle1.Size = new System.Drawing.Size(172, 22);
            this.showStyle1.Text = "不在前端显示";
            this.showStyle1.Click += new System.EventHandler(this.showStyle1_Click);
            // 
            // showStyle2
            // 
            this.showStyle2.Name = "showStyle2";
            this.showStyle2.Size = new System.Drawing.Size(172, 22);
            this.showStyle2.Text = "在其他窗口前显示";
            this.showStyle2.Click += new System.EventHandler(this.showStyle2_Click);
            // 
            // transparecy
            // 
            this.transparecy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacity100,
            this.opacity95,
            this.opacity85,
            this.opacity80,
            this.opacity75,
            this.opacity50,
            this.opacity25});
            this.transparecy.Name = "transparecy";
            this.transparecy.ShowShortcutKeys = false;
            this.transparecy.Size = new System.Drawing.Size(124, 22);
            this.transparecy.Text = "透明度";
            // 
            // opacity100
            // 
            this.opacity100.AutoSize = false;
            this.opacity100.Name = "opacity100";
            this.opacity100.ShowShortcutKeys = false;
            this.opacity100.Size = new System.Drawing.Size(152, 22);
            this.opacity100.Text = "不透明";
            this.opacity100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opacity100.Click += new System.EventHandler(this.opacity100_Click);
            // 
            // opacity95
            // 
            this.opacity95.Name = "opacity95";
            this.opacity95.ShowShortcutKeys = false;
            this.opacity95.Size = new System.Drawing.Size(104, 22);
            this.opacity95.Text = "95";
            this.opacity95.Click += new System.EventHandler(this.opacity95_Click);
            // 
            // opacity85
            // 
            this.opacity85.Name = "opacity85";
            this.opacity85.ShowShortcutKeys = false;
            this.opacity85.Size = new System.Drawing.Size(104, 22);
            this.opacity85.Text = "85";
            this.opacity85.Click += new System.EventHandler(this.opacity85_Click);
            // 
            // opacity80
            // 
            this.opacity80.Name = "opacity80";
            this.opacity80.ShowShortcutKeys = false;
            this.opacity80.Size = new System.Drawing.Size(104, 22);
            this.opacity80.Text = "80";
            this.opacity80.Click += new System.EventHandler(this.opacity80_Click);
            // 
            // opacity75
            // 
            this.opacity75.Name = "opacity75";
            this.opacity75.ShowShortcutKeys = false;
            this.opacity75.Size = new System.Drawing.Size(104, 22);
            this.opacity75.Text = "75";
            this.opacity75.Click += new System.EventHandler(this.opacity75_Click);
            // 
            // opacity50
            // 
            this.opacity50.Name = "opacity50";
            this.opacity50.ShowShortcutKeys = false;
            this.opacity50.Size = new System.Drawing.Size(104, 22);
            this.opacity50.Text = "50";
            this.opacity50.Click += new System.EventHandler(this.opacity50_Click);
            // 
            // opacity25
            // 
            this.opacity25.Name = "opacity25";
            this.opacity25.ShowShortcutKeys = false;
            this.opacity25.Size = new System.Drawing.Size(104, 22);
            this.opacity25.Text = "25";
            this.opacity25.Click += new System.EventHandler(this.opacity25_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.ShowShortcutKeys = false;
            this.quit.Size = new System.Drawing.Size(124, 22);
            this.quit.Text = "退出";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // uploadRate
            // 
            this.uploadRate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.uploadRate.BackColor = System.Drawing.Color.Transparent;
            this.uploadRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(138)));
            this.uploadRate.ForeColor = System.Drawing.Color.DimGray;
            this.uploadRate.Location = new System.Drawing.Point(42, 5);
            this.uploadRate.Margin = new System.Windows.Forms.Padding(0);
            this.uploadRate.Name = "uploadRate";
            this.uploadRate.Size = new System.Drawing.Size(30, 16);
            this.uploadRate.TabIndex = 3;
            this.uploadRate.Text = "0";
            this.uploadRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uploadRate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseDown);
            this.uploadRate.MouseEnter += new System.EventHandler(this.miniBigFormSpace_MouseEnter);
            this.uploadRate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseMove);
            this.uploadRate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseUp);
            // 
            // downloadRate
            // 
            this.downloadRate.BackColor = System.Drawing.Color.Transparent;
            this.downloadRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(138)));
            this.downloadRate.ForeColor = System.Drawing.Color.DimGray;
            this.downloadRate.Location = new System.Drawing.Point(42, 19);
            this.downloadRate.Margin = new System.Windows.Forms.Padding(0);
            this.downloadRate.Name = "downloadRate";
            this.downloadRate.Size = new System.Drawing.Size(30, 16);
            this.downloadRate.TabIndex = 4;
            this.downloadRate.Text = "0";
            this.downloadRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadRate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseDown);
            this.downloadRate.MouseEnter += new System.EventHandler(this.miniBigFormSpace_MouseEnter);
            this.downloadRate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseMove);
            this.downloadRate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseUp);
            // 
            // rateUnit1
            // 
            this.rateUnit1.BackColor = System.Drawing.Color.Transparent;
            this.rateUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateUnit1.ForeColor = System.Drawing.Color.DimGray;
            this.rateUnit1.Location = new System.Drawing.Point(70, 5);
            this.rateUnit1.Margin = new System.Windows.Forms.Padding(0);
            this.rateUnit1.Name = "rateUnit1";
            this.rateUnit1.Size = new System.Drawing.Size(20, 16);
            this.rateUnit1.TabIndex = 7;
            this.rateUnit1.Text = "K/S";
            this.rateUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rateUnit1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseDown);
            this.rateUnit1.MouseEnter += new System.EventHandler(this.miniBigFormSpace_MouseEnter);
            this.rateUnit1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseMove);
            this.rateUnit1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseUp);
            // 
            // rateUnit2
            // 
            this.rateUnit2.BackColor = System.Drawing.Color.Transparent;
            this.rateUnit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rateUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateUnit2.ForeColor = System.Drawing.Color.DimGray;
            this.rateUnit2.Location = new System.Drawing.Point(70, 19);
            this.rateUnit2.Margin = new System.Windows.Forms.Padding(0);
            this.rateUnit2.Name = "rateUnit2";
            this.rateUnit2.Size = new System.Drawing.Size(20, 16);
            this.rateUnit2.TabIndex = 8;
            this.rateUnit2.Text = "K/S";
            this.rateUnit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rateUnit2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseDown);
            this.rateUnit2.MouseEnter += new System.EventHandler(this.miniBigFormSpace_MouseEnter);
            this.rateUnit2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseMove);
            this.rateUnit2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseUp);
            // 
            // showDetailFormTimer
            // 
            this.showDetailFormTimer.Interval = 700;
            this.showDetailFormTimer.Tick += new System.EventHandler(this.showDetailFormTimer_Tick);
            // 
            // hideDetailFormTimer
            // 
            this.hideDetailFormTimer.Interval = 700;
            this.hideDetailFormTimer.Tick += new System.EventHandler(this.hideDetailFormTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.mainContextMenu;
            this.notifyIcon.Icon = global::AccelerateBall.Properties.Resources.favicon;
            this.notifyIcon.Text = "电脑加速球";
            this.notifyIcon.Visible = true;
            // 
            // up_down_image
            // 
            this.up_down_image.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.up_down_image.BackColor = System.Drawing.Color.Transparent;
            this.up_down_image.Image = global::AccelerateBall.Properties.Resources.up_and_down;
            this.up_down_image.Location = new System.Drawing.Point(39, 5);
            this.up_down_image.Name = "up_down_image";
            this.up_down_image.Size = new System.Drawing.Size(7, 30);
            this.up_down_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.up_down_image.TabIndex = 2;
            this.up_down_image.TabStop = false;
            this.up_down_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseDown);
            this.up_down_image.MouseEnter += new System.EventHandler(this.miniBigFormSpace_MouseEnter);
            this.up_down_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseMove);
            this.up_down_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseUp);
            // 
            // la
            // 
            this.la.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.la.BackColor = System.Drawing.Color.Transparent;
            this.la.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la.ForeColor = System.Drawing.Color.White;
            this.la.Location = new System.Drawing.Point(3, 11);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(33, 17);
            this.la.TabIndex = 9;
            this.la.Text = "50%";
            this.la.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.la.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.miniBallControl_MouseDoubleClick);
            this.la.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseDown);
            this.la.MouseEnter += new System.EventHandler(this.miniBigFormSpace_MouseEnter);
            this.la.MouseLeave += new System.EventHandler(this.miniBigFormSpace_MouseLeave);
            this.la.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseMove);
            this.la.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseUp);
            // 
            // miniBallControl
            // 
            this.miniBallControl.BackColor = System.Drawing.Color.Gainsboro;
            this.miniBallControl.Controls.Add(this.la);
            this.miniBallControl.Controls.Add(this.rateUnit2);
            this.miniBallControl.Controls.Add(this.up_down_image);
            this.miniBallControl.Controls.Add(this.rateUnit1);
            this.miniBallControl.Controls.Add(this.uploadRate);
            this.miniBallControl.Controls.Add(this.downloadRate);
            this.miniBallControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miniBallControl.Location = new System.Drawing.Point(0, 0);
            this.miniBallControl.Name = "miniBallControl";
            this.miniBallControl.Size = new System.Drawing.Size(96, 40);
            this.miniBallControl.TabIndex = 5;
            this.miniBallControl.Text = "miniBallControl";
            this.miniBallControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.miniBallControl_MouseDoubleClick);
            this.miniBallControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseDown);
            this.miniBallControl.MouseEnter += new System.EventHandler(this.miniBigFormSpace_MouseEnter);
            this.miniBallControl.MouseLeave += new System.EventHandler(this.miniBigFormSpace_MouseLeave);
            this.miniBallControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseMove);
            this.miniBallControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBigFormSpace_MouseUp);
            // 
            // MiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(96, 40);
            this.ContextMenuStrip = this.mainContextMenu;
            this.Controls.Add(this.miniBallControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::AccelerateBall.Properties.Resources.favicon;
            this.Name = "MiniForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "加速球";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.mainContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.up_down_image)).EndInit();
            this.miniBallControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem transparecy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.PictureBox up_down_image;
        private System.Windows.Forms.Label uploadRate;
        private System.Windows.Forms.Label downloadRate;
        private MainBallControl miniBallControl;
        private System.Windows.Forms.Label rateUnit1;
        private System.Windows.Forms.Label rateUnit2;
        private System.Windows.Forms.Timer showDetailFormTimer;
        private System.Windows.Forms.Timer hideDetailFormTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem opacity95;
        private System.Windows.Forms.ToolStripMenuItem opacity85;
        private System.Windows.Forms.ToolStripMenuItem opacity80;
        private System.Windows.Forms.ToolStripMenuItem opacity75;
        private System.Windows.Forms.ToolStripMenuItem opacity50;
        private System.Windows.Forms.ToolStripMenuItem opacity25;
        private System.Windows.Forms.ToolStripMenuItem opacity100;
        private System.Windows.Forms.ToolStripMenuItem showStyle;
        private System.Windows.Forms.ToolStripMenuItem showStyle1;
        private System.Windows.Forms.ToolStripMenuItem showStyle2;
        private System.Windows.Forms.Label la;
    }
}

