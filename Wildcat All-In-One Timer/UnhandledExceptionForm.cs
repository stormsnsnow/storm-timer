using System;
using System.Drawing;
using System.Windows.Forms;

namespace UTimer
{
    public partial class UnhandledExceptionForm
    {
        public UnhandledExceptionForm()
        {
            InitializeComponent();
            _ExceptionLabel.Name = "ExceptionLabel";
            _ExitButton.Name = "ExitButton";
        }

        public object exce;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnhandledExceptionForm_Load(object sender, EventArgs e)
        {
            ExceptionLabel.Text = "Click to see exception details.";
            BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
        }

        private void ExceptionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(exce.Message.ToString(), "Kill Code " + exce.hresult.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}