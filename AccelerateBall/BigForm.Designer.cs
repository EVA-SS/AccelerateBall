namespace AccelerateBall
{
    partial class BigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigForm));
            this.title = new System.Windows.Forms.Label();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.ballControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pi = new System.Windows.Forms.PictureBox();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.processListBox = new System.Windows.Forms.CheckedListBox();
            this.systemResources = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.computer = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.DetailsPanel.SuspendLayout();
            this.ballControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).BeginInit();
            this.progressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(14, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(65, 12);
            this.title.TabIndex = 0;
            this.title.Text = "电脑加速球";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseDown);
            this.title.MouseEnter += new System.EventHandler(this.DetailsPanel_MouseEnter);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseUp);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(172)))), ((int)(((byte)(117)))));
            this.DetailsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DetailsPanel.Controls.Add(this.ballControl);
            this.DetailsPanel.Controls.Add(this.progressPanel);
            this.DetailsPanel.Controls.Add(this.greenLabel);
            this.DetailsPanel.Controls.Add(this.computer);
            this.DetailsPanel.Controls.Add(this.closeBtn);
            this.DetailsPanel.Controls.Add(this.clearBtn);
            this.DetailsPanel.Controls.Add(this.title);
            this.DetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(285, 394);
            this.DetailsPanel.TabIndex = 1;
            this.DetailsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DetailsPanel_Paint);
            this.DetailsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseDown);
            this.DetailsPanel.MouseEnter += new System.EventHandler(this.DetailsPanel_MouseEnter);
            this.DetailsPanel.MouseLeave += new System.EventHandler(this.DetailsPanel_MouseLeave);
            this.DetailsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseMove);
            this.DetailsPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseUp);
            // 
            // ballControl
            // 
            this.ballControl.BackgroundImage = global::AccelerateBall.Properties.Resources.lobei;
            this.ballControl.Controls.Add(this.label1);
            this.ballControl.Controls.Add(this.pi);
            this.ballControl.Location = new System.Drawing.Point(9, 36);
            this.ballControl.Name = "ballControl";
            this.ballControl.Size = new System.Drawing.Size(105, 105);
            this.ballControl.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F);
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 45);
            this.label1.TabIndex = 12;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.Color.Transparent;
            this.pi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pi.Location = new System.Drawing.Point(0, 0);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(105, 105);
            this.pi.TabIndex = 11;
            this.pi.TabStop = false;
            this.pi.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.White;
            this.progressPanel.Controls.Add(this.processListBox);
            this.progressPanel.Controls.Add(this.systemResources);
            this.progressPanel.Location = new System.Drawing.Point(-1, 147);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(287, 247);
            this.progressPanel.TabIndex = 7;
            this.progressPanel.MouseEnter += new System.EventHandler(this.DetailsPanel_MouseEnter);
            this.progressPanel.MouseLeave += new System.EventHandler(this.DetailsPanel_MouseLeave);
            // 
            // processListBox
            // 
            this.processListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.processListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processListBox.CheckOnClick = true;
            this.processListBox.ForeColor = System.Drawing.Color.DimGray;
            this.processListBox.FormattingEnabled = true;
            this.processListBox.Location = new System.Drawing.Point(13, 31);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(264, 208);
            this.processListBox.TabIndex = 1;
            this.processListBox.MouseEnter += new System.EventHandler(this.DetailsPanel_MouseEnter);
            this.processListBox.MouseLeave += new System.EventHandler(this.DetailsPanel_MouseLeave);
            // 
            // systemResources
            // 
            this.systemResources.AutoSize = true;
            this.systemResources.BackColor = System.Drawing.Color.White;
            this.systemResources.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.systemResources.ForeColor = System.Drawing.Color.DimGray;
            this.systemResources.Location = new System.Drawing.Point(8, 9);
            this.systemResources.Name = "systemResources";
            this.systemResources.Size = new System.Drawing.Size(109, 12);
            this.systemResources.TabIndex = 0;
            this.systemResources.Text = "可选择关闭的程序";
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.greenLabel.ForeColor = System.Drawing.Color.White;
            this.greenLabel.Location = new System.Drawing.Point(149, 28);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(123, 32);
            this.greenLabel.TabIndex = 4;
            this.greenLabel.Text = "充满活力";
            this.greenLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseDown);
            this.greenLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseMove);
            this.greenLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseUp);
            // 
            // computer
            // 
            this.computer.AutoSize = true;
            this.computer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.computer.ForeColor = System.Drawing.Color.White;
            this.computer.Location = new System.Drawing.Point(114, 41);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(41, 16);
            this.computer.TabIndex = 3;
            this.computer.Text = "电脑";
            this.computer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseDown);
            this.computer.MouseEnter += new System.EventHandler(this.DetailsPanel_MouseEnter);
            this.computer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseMove);
            this.computer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DetailsPanel_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AccelerateBall.Properties.Resources.close_normal;
            this.closeBtn.Location = new System.Drawing.Point(259, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(172)))), ((int)(((byte)(117)))));
            this.clearBtn.Location = new System.Drawing.Point(121, 100);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 35);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "一键加速";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // BigForm
            // 
            this.AcceptButton = this.clearBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(172)))), ((int)(((byte)(117)))));
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(285, 388);
            this.Controls.Add(this.DetailsPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Properties.Resources.favicon;
            this.Name = "BigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AccelerateBall";
            this.TopMost = true;
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.ballControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pi)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label computer;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label systemResources;
        private System.Windows.Forms.CheckedListBox processListBox;
        private System.Windows.Forms.Panel ballControl;
        private System.Windows.Forms.PictureBox pi;
        private System.Windows.Forms.Label label1;
    }
}