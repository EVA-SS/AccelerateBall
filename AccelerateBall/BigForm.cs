using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace AccelerateBall
{
    public partial class BigForm : Form
    {

        public enum ShowCommands
        {
            HIDE = 1,
        }
        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile,
            string lpParameters, string lpDirectory, ShowCommands nShowCmd);
        [DllImport("shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr handle, string root, int falgs);

        private bool isMouseDown = false;
        public bool isMouseEnter = false;

        private Point mouseOffset;
        private MiniForm miniForm;

        public BigForm(MiniForm miniForm)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            pi.Parent = ballControl;
            this.miniForm = miniForm;
            Thread s = new Thread(loging); s.IsBackground = true; s.Start();
        }
        int txtRotate = 0;
        int txtRotates = 180;
        int a = 4;
        public void loging()
        {
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    Thread.Sleep(30);
                    if (txtRotate >= 360) { txtRotate = 0; }
                    if (txtRotates <= -180) { txtRotates = 180; }
                    txtRotate += a + 1;
                    txtRotates -= a;
                    try
                    {
                        Rotate(txtRotate); Rotatet(txtRotates);
                    }
                    catch (Exception) { }
                }
            }));
            t.IsBackground = true;
            t.Start();
        }
        bool jIa = false;
        #region 图片旋转函数
        /// <summary>
        /// 以逆时针为方向对图像进行旋转
        /// </summary>
        /// <param name="angle">旋转角度[0,360](前台给的)</param>
        /// <returns></returns>
        public void Rotate(int angle)
        {
            try
            {
                Image ing = Properties.Resources.loing;
                angle = angle % 360;
                //弧度转换
                double radian = angle * Math.PI / 180.0;
                double cos = Math.Cos(radian);
                double sin = Math.Sin(radian);
                //原图的宽和高
                int w = 105;
                int h = 105;
                int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
                int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
                //目标位图
                Bitmap dsImage = new Bitmap(W, H);
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //计算偏移量
                Point Offset = new Point((W - w) / 2, (H - h) / 2);
                //构造图像显示区域：让图像的中心与窗口的中心点一致
                Rectangle rect = new Rectangle(0, 0, w, h);
                Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                g.TranslateTransform(center.X, center.Y);
                g.RotateTransform(360 - angle);
                //恢复图像在水平和垂直方向的平移
                g.TranslateTransform(-center.X, -center.Y);
                g.DrawImage(ing, rect);
                //重至绘图的所有变换
                g.ResetTransform();
                g.Save();
                g.Dispose();
                //dsImage.Save("yuancd.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                pi.Image = dsImage;
            }
            catch (Exception) { }
        }

        public void Rotatet(int angle)
        {
            try
            {
                Image ing = Properties.Resources.loing;
                angle = angle % 360;
                //弧度转换
                double radian = angle * Math.PI / 180.0;
                double cos = Math.Cos(radian);
                double sin = Math.Sin(radian);
                //原图的宽和高
                int w = 105;
                int h = 105;
                int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
                int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
                //目标位图
                Bitmap dsImage = new Bitmap(W, H);
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //计算偏移量
                Point Offset = new Point((W - w) / 2, (H - h) / 2);
                //构造图像显示区域：让图像的中心与窗口的中心点一致
                Rectangle rect = new Rectangle(0, 0, w, h);
                Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                g.TranslateTransform(center.X, center.Y);
                g.RotateTransform(360 - angle);
                //恢复图像在水平和垂直方向的平移
                g.TranslateTransform(-center.X, -center.Y);
                g.DrawImage(ing, rect);
                //重至绘图的所有变换
                g.ResetTransform();
                g.Save();
                g.Dispose();
                //dsImage.Save("yuancd.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                pi.BackgroundImage = dsImage;
            }
            catch (Exception) { }
        }
        #endregion 图片旋转函数

        #region 按钮不同状态的图标
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = new Bitmap(Properties.Resources.close_press);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = new Bitmap(Properties.Resources.close_normal);
        }
        #endregion

        #region DetailsPanel和ballControl的鼠标事件
        private void DetailsPanel_MouseLeave(object sender, EventArgs e)
        {
            Point p = MousePosition;
            if (p.X - 10 <= this.Left || p.X + 10 >= this.Right || p.Y - 10 <= this.Top || p.Y >= this.Top + this.Height)
            {
                isMouseEnter = false;
                Thread th = new Thread(hideDetailsFormTimer);
                th.Start();
            }
        }

        private void DetailsPanel_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter = true;
            miniForm.TopLevel = this.TopLevel;
        }

        private void DetailsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void DetailsPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void DetailsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            miniForm.isMouseEnter = false;
            if (isMouseDown == true)
            {
                this.Location = getDetailFormMoveLocation();
                miniForm.Location = getMiniBallMoveLocation();
            }
        }

        private void ballControl_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void ballControl_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        /*隐藏DetailsForm的定时器*/
        public void hideDetailsFormTimer()
        {
            if (!isMouseEnter && !miniForm.isMouseEnter)
            {
                this.Hide();
            }
            return;
        }

        /*获取小球出现的位置*/
        private Point getMiniBallMoveLocation()
        {
            int x = 0, y = 0;
            if (this.Location.Y <= miniForm.Location.Y)
            {
                if (miniForm.miniFormLocation == MiniForm.MiniFormLocation.bottomRight)
                    x = this.Location.X + this.Width - miniForm.miniFormWidth;
                else
                    x = this.Location.X;
                y = this.Location.Y + this.Height + miniForm.miniBigFormSpace;
            }
            else
            {
                if (miniForm.miniFormLocation == MiniForm.MiniFormLocation.topRigh)
                    x = this.Location.X + this.Width - miniForm.miniFormWidth;
                else
                    x = this.Location.X;
                y = this.Location.Y - miniForm.miniFormHeight - miniForm.miniBigFormSpace;
            }
            return new Point(x, y);
        }

        /*获取DetailForm出现的位置*/
        private Point getDetailFormMoveLocation()
        {
            int x = MousePosition.X - mouseOffset.X;
            int y = MousePosition.Y - mouseOffset.Y;
            if (x < 0)
            {
                x = 0;
            }
            if (miniForm.Top > this.Top && y < 0)
            {
                y = 0;
            }
            if (miniForm.Top < this.Top && y < miniForm.miniFormHeight + miniForm.miniBigFormSpace)
            { //minBall在上面
                y = miniForm.miniFormHeight + miniForm.miniBigFormSpace;
            }

            if (Screen.PrimaryScreen.WorkingArea.Width - x < this.Width)
            {
                x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            }
            if (miniForm.Top < this.Top && Screen.PrimaryScreen.WorkingArea.Height - y < this.Height)
            { //minBall在上面               
                y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            }
            if (miniForm.Top > this.Top && Screen.PrimaryScreen.WorkingArea.Height - y < (this.Height + miniForm.miniFormHeight + miniForm.miniBigFormSpace))
            { //minBall在下面
                y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - miniForm.miniFormHeight - miniForm.miniBigFormSpace;
            }
            return new Point(x, y);
        }
        #endregion

        #region 单击事件
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region 刷新进程和服务列表
        public void refreshThread()
        {
            this.processListBox.Items.Clear();
            Thread refreshListThread = new Thread(refresh);
            refreshListThread.Start();
        }

        private void refresh()
        {
            refreshProcess();
            refreshService();
        }

        public void refreshProcess()
        {
            Process[] processs = Process.GetProcesses();
            StringCollection collection = systemProcess();
            foreach (Process p in processs)
            {
                if (!collection.Contains(p.ProcessName.ToLower())) //不添加系统进程
                    processListBox.Items.Add(p.ProcessName.ToLower());
            }
        }

        public void refreshService()
        {
            ServiceController[] scs = ServiceController.GetServices();
            foreach (ServiceController sc in scs)
            {
                if (sc.Status.ToString().Equals("Running")) //只添加正在运行的服务
                    processListBox.Items.Add(sc.DisplayName + " "); //加一个空格是为了区分进程和服务的标志，结束进程和服务时用到
                sc.Close();
            }
        }

        public StringCollection systemProcess()
        {
            StringCollection collection = new StringCollection();
            String[] systemProcesss = { "svchost", "csrss", "rundll32", "snmp", "lserver", "wins",
                                       "ismserv", "internat", "explorer", "dwm", "idle", "system",
                                       "smss", "winlogon", "services", "mstask", "winmgmt", "inetinfo",
                                       "tlntsvr", "dns","dfssvc", "msdtc", "dmadmin", "msiexec", "rsvp",
                                       "dllhost", "wmiprvse", "dashost", "devenv", "msmpeng", "lsass",
                                       "spoolsv", "wininit", "taskhostex", "runtimebroker", "searchindexer",
                                       "taskmgr", "searchfilterhost", "searchprotocolhost", "AccelerateBall", "acceleration"};
            foreach (string process in systemProcesss)
            {
                collection.Add(process);
            }
            return collection;
        }
        #endregion

        #region 加速操作（内存、IE临时文件、回收站等加速）
        private void accelerate()
        {
            KillProcessServices();
            //clearIETemporaryFile();
            Acc s = new Acc();
            s.ClearMemory();
            Thread th = new Thread(PVisible);
            Thread.Sleep(1000);
            th.Start();
        }

        public void KillProcessServices()
        {
            int count = processListBox.CheckedItems.Count;
            for (int i = count - 1; i > -1; i--)
            {
                string name = processListBox.CheckedItems[i].ToString();
                processListBox.Items.Remove(processListBox.CheckedItems[i]);
                if (name.EndsWith(" "))
                { //区分进程和服务                   
                    killServices(name.TrimEnd());
                }
                else
                {
                    killProcess(name);
                }
            }
        }

        private void killServices(string serviceName)
        {
            try
            {
                ServiceController[] scs = ServiceController.GetServices();
                foreach (ServiceController sc in scs)
                {
                    if (sc.DisplayName.Equals(serviceName))
                    {
                        sc.Stop();
                        sc.WaitForStatus(ServiceControllerStatus.Stopped);
                    }
                    sc.Refresh();
                    sc.Close();
                }
            }
            catch (Win32Exception)
            {
            }
            catch (InvalidOperationException)
            {
            }
        }

        private void killProcess(string processName)
        {
            Process[] ps = Process.GetProcessesByName(processName);
            if (ps.Length > 0)
            {
                foreach (Process p in ps)
                {
                    try
                    {
                        p.Kill();
                    }
                    catch (Win32Exception)
                    {
                    }
                    catch (NotSupportedException)
                    {
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
            }
        }

        //private void clearRecycleBin() {
        //    SHEmptyRecycleBin(this.Handle, "", 0x000007);
        //}

        //private void clearIETemporaryFile() {
        //    ShellExecute(IntPtr.Zero, "open", "rundll32.exe", " InetCpl.cpl,ClearMyTracksByProcess 8", "", ShowCommands.HIDE);
        //}
        #endregion

        #region 单击加速按钮事件
        public void jias()
        {
            if (jIa)
            {
                a += 3;
                if (a <= 30)
                { Thread j = new Thread(jias); Thread.Sleep(50); j.Start(); }
                else
                {
                    return;
                }
            }
            else
            {
                a--;
                if (a > 4)
                {
                    Thread j = new Thread(jias); Thread.Sleep(100); j.Start();
                }
                else
                {
                    a = 4;
                    return;
                }
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            jIa = true; Thread j = new Thread(jias); j.Start();
            clearBtn.Enabled = false;
            Thread th = new Thread(accelerate);
            th.IsBackground = true;
            th.Start();
        }
        #endregion

        /*画分割线*/
        private void DetailsPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.FromArgb(220, 220, 220));
            g.DrawLine(p, new Point(0, 145), new Point(285, 145));
            g.Dispose();
        }

        /*刷新大球里的内存使用率*/
        public void paintBigBallControl(string usedMemoryRate)
        {
            label1.Text = usedMemoryRate;
            if (Int32.Parse(usedMemoryRate) > 90)
            {
                DetailsPanel.BackColor = Color.FromArgb(101, 172, 117);
                greenLabel.Text = "卡爆了";
            }
            else if (Int32.Parse(usedMemoryRate) > 70)
            {
                DetailsPanel.BackColor = Color.FromArgb(71, 172, 117);
                greenLabel.Text = "有点小卡";
            }
            else
            {
                DetailsPanel.BackColor = Color.FromArgb(31, 172, 117);
                greenLabel.Text = "充满活力";
            }
        }

        public void PVisible()
        {
            clearBtn.Enabled = true;
            jIa = false; Thread j = new Thread(jias); j.Start();
        }
    }
}
