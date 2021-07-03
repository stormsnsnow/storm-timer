using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    [DesignerGenerated()]
    public partial class BreakForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakForm));
            _BreakTimer = new Timer(components);
            _BreakTimer.Tick += new EventHandler(TTab_Tick);
            lbldate = new Label();
            lblbackon = new Label();
            lblhour = new Label();
            lblwait = new Label();
            ImageList1 = new ImageList(components);
            BreakPanel = new Panel();
            Label1 = new Label();
            lbltime = new Label();
            lblsecondsbreak = new Label();
            lblsecondbreak = new Label();
            lblminutesandbreak = new Label();
            lblhoursandbreak = new Label();
            lblsec = new Label();
            lblminute = new Label();
            lblhourandbreak = new Label();
            lblminuteandbreak = new Label();
            Panel1 = new Panel();
            Label2 = new Label();
            _UnlockButton = new Button();
            _UnlockButton.Click += new EventHandler(UnlockButton_Click_1);
            _PauseButton = new Button();
            _PauseButton.Click += new EventHandler(UnlockButton_Click);
            BreakPanel.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BreakTimer
            // 
            _BreakTimer.Interval = 1000;
            // 
            // lbldate
            // 
            lbldate.Anchor = AnchorStyles.None;
            lbldate.AutoSize = true;
            lbldate.FlatStyle = FlatStyle.System;
            lbldate.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lbldate.ForeColor = Color.Black;
            lbldate.Location = new Point(34, 73);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(238, 23);
            lbldate.TabIndex = 58;
            lbldate.Text = "Monday January 1 2022";
            lbldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblbackon
            // 
            lblbackon.Anchor = AnchorStyles.None;
            lblbackon.AutoSize = true;
            lblbackon.FlatStyle = FlatStyle.System;
            lblbackon.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblbackon.ForeColor = Color.Black;
            lblbackon.Location = new Point(218, 50);
            lblbackon.Name = "lblbackon";
            lblbackon.Size = new Size(54, 23);
            lblbackon.TabIndex = 57;
            lblbackon.Text = "until";
            // 
            // lblhour
            // 
            lblhour.Anchor = AnchorStyles.None;
            lblhour.AutoSize = true;
            lblhour.FlatStyle = FlatStyle.System;
            lblhour.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblhour.ForeColor = Color.Black;
            lblhour.Location = new Point(75, 27);
            lblhour.Name = "lblhour";
            lblhour.Size = new Size(26, 23);
            lblhour.TabIndex = 56;
            lblhour.Text = "--";
            // 
            // lblwait
            // 
            lblwait.Anchor = AnchorStyles.None;
            lblwait.AutoSize = true;
            lblwait.FlatStyle = FlatStyle.System;
            lblwait.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblwait.ForeColor = Color.Black;
            lblwait.Location = new Point(14, 27);
            lblwait.Name = "lblwait";
            lblwait.Size = new Size(55, 23);
            lblwait.TabIndex = 55;
            lblwait.Text = "Wait";
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "23F8.png");
            ImageList1.Images.SetKeyName(1, "23F9.png");
            // 
            // BreakPanel
            // 
            BreakPanel.Anchor = AnchorStyles.None;
            BreakPanel.BackColor = Color.White;
            BreakPanel.BorderStyle = BorderStyle.FixedSingle;
            BreakPanel.Controls.Add(Label1);
            BreakPanel.Controls.Add(lbltime);
            BreakPanel.Controls.Add(lblsecondsbreak);
            BreakPanel.Controls.Add(lblsecondbreak);
            BreakPanel.Controls.Add(lblminutesandbreak);
            BreakPanel.Controls.Add(lblhoursandbreak);
            BreakPanel.Controls.Add(lblsec);
            BreakPanel.Controls.Add(lblminute);
            BreakPanel.Controls.Add(lblwait);
            BreakPanel.Controls.Add(lblhour);
            BreakPanel.Controls.Add(lblbackon);
            BreakPanel.Controls.Add(lbldate);
            BreakPanel.Controls.Add(lblhourandbreak);
            BreakPanel.Controls.Add(lblminuteandbreak);
            BreakPanel.ForeColor = Color.Black;
            BreakPanel.Location = new Point(177, 238);
            BreakPanel.Name = "BreakPanel";
            BreakPanel.Size = new Size(524, 101);
            BreakPanel.TabIndex = 63;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.FlatStyle = FlatStyle.System;
            Label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(125, 4);
            Label1.Name = "Label1";
            Label1.Size = new Size(253, 23);
            Label1.TabIndex = 76;
            Label1.Text = "It is time to take a break.";
            // 
            // lbltime
            // 
            lbltime.Anchor = AnchorStyles.None;
            lbltime.AutoSize = true;
            lbltime.FlatStyle = FlatStyle.System;
            lbltime.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lbltime.ForeColor = Color.Black;
            lbltime.Location = new Point(278, 73);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(157, 23);
            lbltime.TabIndex = 75;
            lbltime.Text = "at 12:00:00 AM";
            lbltime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsecondsbreak
            // 
            lblsecondsbreak.Anchor = AnchorStyles.None;
            lblsecondsbreak.AutoSize = true;
            lblsecondsbreak.FlatStyle = FlatStyle.System;
            lblsecondsbreak.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblsecondsbreak.ForeColor = Color.Black;
            lblsecondsbreak.Location = new Point(415, 27);
            lblsecondsbreak.Name = "lblsecondsbreak";
            lblsecondsbreak.Size = new Size(87, 23);
            lblsecondsbreak.TabIndex = 73;
            lblsecondsbreak.Text = "seconds";
            // 
            // lblsecondbreak
            // 
            lblsecondbreak.Anchor = AnchorStyles.None;
            lblsecondbreak.AutoSize = true;
            lblsecondbreak.FlatStyle = FlatStyle.System;
            lblsecondbreak.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblsecondbreak.ForeColor = Color.Black;
            lblsecondbreak.Location = new Point(415, 27);
            lblsecondbreak.Name = "lblsecondbreak";
            lblsecondbreak.Size = new Size(77, 23);
            lblsecondbreak.TabIndex = 72;
            lblsecondbreak.Text = "second";
            // 
            // lblminutesandbreak
            // 
            lblminutesandbreak.Anchor = AnchorStyles.None;
            lblminutesandbreak.AutoSize = true;
            lblminutesandbreak.FlatStyle = FlatStyle.System;
            lblminutesandbreak.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblminutesandbreak.ForeColor = Color.Black;
            lblminutesandbreak.Location = new Point(250, 27);
            lblminutesandbreak.Name = "lblminutesandbreak";
            lblminutesandbreak.Size = new Size(128, 23);
            lblminutesandbreak.TabIndex = 70;
            lblminutesandbreak.Text = "minutes and";
            // 
            // lblhoursandbreak
            // 
            lblhoursandbreak.Anchor = AnchorStyles.None;
            lblhoursandbreak.AutoSize = true;
            lblhoursandbreak.FlatStyle = FlatStyle.System;
            lblhoursandbreak.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblhoursandbreak.ForeColor = Color.Black;
            lblhoursandbreak.Location = new Point(107, 27);
            lblhoursandbreak.Name = "lblhoursandbreak";
            lblhoursandbreak.Size = new Size(105, 23);
            lblhoursandbreak.TabIndex = 68;
            lblhoursandbreak.Text = "hours and";
            // 
            // lblsec
            // 
            lblsec.Anchor = AnchorStyles.None;
            lblsec.AutoSize = true;
            lblsec.FlatStyle = FlatStyle.System;
            lblsec.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblsec.ForeColor = Color.Black;
            lblsec.Location = new Point(384, 27);
            lblsec.Name = "lblsec";
            lblsec.Size = new Size(26, 23);
            lblsec.TabIndex = 67;
            lblsec.Text = "--";
            // 
            // lblminute
            // 
            lblminute.Anchor = AnchorStyles.None;
            lblminute.AutoSize = true;
            lblminute.FlatStyle = FlatStyle.System;
            lblminute.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblminute.ForeColor = Color.Black;
            lblminute.Location = new Point(218, 27);
            lblminute.Name = "lblminute";
            lblminute.Size = new Size(26, 23);
            lblminute.TabIndex = 66;
            lblminute.Text = "--";
            // 
            // lblhourandbreak
            // 
            lblhourandbreak.Anchor = AnchorStyles.None;
            lblhourandbreak.AutoSize = true;
            lblhourandbreak.FlatStyle = FlatStyle.System;
            lblhourandbreak.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblhourandbreak.ForeColor = Color.Black;
            lblhourandbreak.Location = new Point(107, 27);
            lblhourandbreak.Name = "lblhourandbreak";
            lblhourandbreak.Size = new Size(95, 23);
            lblhourandbreak.TabIndex = 69;
            lblhourandbreak.Text = "hour and";
            // 
            // lblminuteandbreak
            // 
            lblminuteandbreak.Anchor = AnchorStyles.None;
            lblminuteandbreak.AutoSize = true;
            lblminuteandbreak.FlatStyle = FlatStyle.System;
            lblminuteandbreak.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblminuteandbreak.ForeColor = Color.Black;
            lblminuteandbreak.Location = new Point(250, 27);
            lblminuteandbreak.Name = "lblminuteandbreak";
            lblminuteandbreak.Size = new Size(118, 23);
            lblminuteandbreak.TabIndex = 71;
            lblminuteandbreak.Text = "minute and";
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.None;
            Panel1.BackColor = Color.White;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(_UnlockButton);
            Panel1.Controls.Add(_PauseButton);
            Panel1.ForeColor = Color.Black;
            Panel1.Location = new Point(177, 345);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(524, 69);
            Panel1.TabIndex = 77;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.BackColor = Color.White;
            Label2.FlatStyle = FlatStyle.System;
            Label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(176, 5);
            Label2.Name = "Label2";
            Label2.Size = new Size(145, 23);
            Label2.TabIndex = 77;
            Label2.Text = "Break Options";
            // 
            // UnlockButton
            // 
            _UnlockButton.Anchor = AnchorStyles.None;
            _UnlockButton.FlatStyle = FlatStyle.Flat;
            _UnlockButton.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _UnlockButton.ImageAlign = ContentAlignment.MiddleLeft;
            _UnlockButton.ImageKey = "23F9.png";
            _UnlockButton.ImageList = ImageList1;
            _UnlockButton.Location = new Point(261, 31);
            _UnlockButton.Name = "_UnlockButton";
            _UnlockButton.Size = new Size(241, 33);
            _UnlockButton.TabIndex = 76;
            _UnlockButton.Text = "Unlock Break";
            _UnlockButton.TextAlign = ContentAlignment.MiddleRight;
            _UnlockButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            _UnlockButton.UseVisualStyleBackColor = true;
            // 
            // PauseButton
            // 
            _PauseButton.Anchor = AnchorStyles.None;
            _PauseButton.FlatStyle = FlatStyle.Flat;
            _PauseButton.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _PauseButton.ImageAlign = ContentAlignment.MiddleLeft;
            _PauseButton.ImageKey = "23F8.png";
            _PauseButton.ImageList = ImageList1;
            _PauseButton.Location = new Point(18, 31);
            _PauseButton.Name = "_PauseButton";
            _PauseButton.Size = new Size(216, 33);
            _PauseButton.TabIndex = 75;
            _PauseButton.Text = "Pause Break";
            _PauseButton.TextAlign = ContentAlignment.MiddleRight;
            _PauseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            _PauseButton.UseVisualStyleBackColor = true;
            // 
            // BreakForm
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(853, 620);
            Controls.Add(Panel1);
            Controls.Add(BreakPanel);
            DoubleBuffered = true;
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BreakForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ultimate Timer - Breaktime in Progress";
            WindowState = FormWindowState.Maximized;
            BreakPanel.ResumeLayout(false);
            BreakPanel.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(FrmBreak_Load);
            ResumeLayout(false);
        }

        private Timer _BreakTimer;

        internal Timer BreakTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BreakTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BreakTimer != null)
                {
                    _BreakTimer.Tick -= TTab_Tick;
                }

                _BreakTimer = value;
                if (_BreakTimer != null)
                {
                    _BreakTimer.Tick += TTab_Tick;
                }
            }
        }

        private Label lbldate;
        private Label lblbackon;
        private Label lblhour;
        private Label lblwait;
        private Panel BreakPanel;
        private Label lblsecondsbreak;
        private Label lblsecondbreak;
        private Label lblminuteandbreak;
        private Label lblminutesandbreak;
        private Label lblhourandbreak;
        private Label lblhoursandbreak;
        private Label lblsec;
        private Label lblminute;
        private Label lbltime;
        private ImageList ImageList1;
        private Label Label1;
        private Panel Panel1;
        private Label Label2;
        private Button _UnlockButton;

        internal Button UnlockButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UnlockButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UnlockButton != null)
                {
                    _UnlockButton.Click -= UnlockButton_Click_1;
                }

                _UnlockButton = value;
                if (_UnlockButton != null)
                {
                    _UnlockButton.Click += UnlockButton_Click_1;
                }
            }
        }

        private Button _PauseButton;

        internal Button PauseButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PauseButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PauseButton != null)
                {
                    _PauseButton.Click -= UnlockButton_Click;
                }

                _PauseButton = value;
                if (_PauseButton != null)
                {
                    _PauseButton.Click += UnlockButton_Click;
                }
            }
        }
    }
}