using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    [DesignerGenerated()]
    public partial class UnhandledExceptionForm : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UnhandledExceptionForm));
            StopWDLCTImage = new PictureBox();
            ConciseErrorLabel = new Label();
            DetailedErrorLabel = new Label();
            _ExceptionLabel = new Label();
            _ExceptionLabel.Click += new EventHandler(ExceptionLabel_Click);
            _ExitButton = new Button();
            _ExitButton.Click += new EventHandler(ExitButton_Click);
            ((System.ComponentModel.ISupportInitialize)StopWDLCTImage).BeginInit();
            SuspendLayout();
            // 
            // StopWDLCTImage
            // 
            StopWDLCTImage.Image = (Image)resources.GetObject("StopWDLCTImage.Image");
            StopWDLCTImage.Location = new Point(12, 12);
            StopWDLCTImage.Name = "StopWDLCTImage";
            StopWDLCTImage.Size = new Size(64, 64);
            StopWDLCTImage.SizeMode = PictureBoxSizeMode.StretchImage;
            StopWDLCTImage.TabIndex = 0;
            StopWDLCTImage.TabStop = false;
            // 
            // ConciseErrorLabel
            // 
            ConciseErrorLabel.AutoSize = true;
            ConciseErrorLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            ConciseErrorLabel.Location = new Point(83, 13);
            ConciseErrorLabel.Name = "ConciseErrorLabel";
            ConciseErrorLabel.Size = new Size(384, 24);
            ConciseErrorLabel.TabIndex = 1;
            ConciseErrorLabel.Text = "Unfortunately, Ultimate Timer must close";
            // 
            // DetailedErrorLabel
            // 
            DetailedErrorLabel.AutoSize = true;
            DetailedErrorLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DetailedErrorLabel.Location = new Point(84, 37);
            DetailedErrorLabel.Name = "DetailedErrorLabel";
            DetailedErrorLabel.Size = new Size(456, 26);
            DetailedErrorLabel.TabIndex = 2;
            DetailedErrorLabel.Text = "An unhandled exception has occured that causes the application to close. We are s" + "orry for the " + '\r' + '\n' + "inconvience.";
            // 
            // ExceptionLabel
            // 
            _ExceptionLabel.AutoSize = true;
            _ExceptionLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExceptionLabel.Location = new Point(84, 63);
            _ExceptionLabel.Name = "_ExceptionLabel";
            _ExceptionLabel.Size = new Size(181, 13);
            _ExceptionLabel.TabIndex = 4;
            _ExceptionLabel.Text = "Please click to see exception details.";
            // 
            // ExitButton
            // 
            _ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _ExitButton.Location = new Point(457, 70);
            _ExitButton.Name = "_ExitButton";
            _ExitButton.Size = new Size(75, 23);
            _ExitButton.TabIndex = 5;
            _ExitButton.Text = "Exit";
            _ExitButton.UseVisualStyleBackColor = true;
            // 
            // UnhandledExceptionForm
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(544, 105);
            Controls.Add(_ExitButton);
            Controls.Add(_ExceptionLabel);
            Controls.Add(DetailedErrorLabel);
            Controls.Add(ConciseErrorLabel);
            Controls.Add(StopWDLCTImage);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnhandledExceptionForm";
            Text = "An Error Ocurred";
            ((System.ComponentModel.ISupportInitialize)StopWDLCTImage).EndInit();
            Load += new EventHandler(UnhandledExceptionForm_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox StopWDLCTImage;
        private Label ConciseErrorLabel;
        private Label DetailedErrorLabel;
        private Label _ExceptionLabel;

        internal Label ExceptionLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExceptionLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExceptionLabel != null)
                {
                    _ExceptionLabel.Click -= ExceptionLabel_Click;
                }

                _ExceptionLabel = value;
                if (_ExceptionLabel != null)
                {
                    _ExceptionLabel.Click += ExceptionLabel_Click;
                }
            }
        }

        private Button _ExitButton;

        internal Button ExitButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitButton != null)
                {
                    _ExitButton.Click -= ExitButton_Click;
                }

                _ExitButton = value;
                if (_ExitButton != null)
                {
                    _ExitButton.Click += ExitButton_Click;
                }
            }
        }
    }
}