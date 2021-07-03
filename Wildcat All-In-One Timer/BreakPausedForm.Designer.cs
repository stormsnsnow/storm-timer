using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    [DesignerGenerated()]
    public partial class BreakPausedForm : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakPausedForm));
            PictureBox1 = new PictureBox();
            Label1 = new Label();
            Label2 = new Label();
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(13, 13);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(74, 68);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(94, 13);
            Label1.Name = "Label1";
            Label1.Size = new Size(301, 23);
            Label1.TabIndex = 1;
            Label1.Text = "Breaktime is currently paused.";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(98, 41);
            Label2.Name = "Label2";
            Label2.Size = new Size(130, 13);
            Label2.TabIndex = 2;
            Label2.Text = "Click OK to resume break.";
            // 
            // Button1
            // 
            _Button1.FlatStyle = FlatStyle.Flat;
            _Button1.Location = new Point(343, 112);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(75, 23);
            _Button1.TabIndex = 3;
            _Button1.Text = "&OK";
            _Button1.UseVisualStyleBackColor = true;
            // 
            // BreakPausedForm
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 147);
            Controls.Add(_Button1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BreakPausedForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paused Break Alert";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(BreakDialog_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox PictureBox1;
        private Label Label1;
        private Label Label2;
        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
                    _Button1.Click -= Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += Button1_Click;
                }
            }
        }
    }
}