using Microsoft.VisualBasic.Devices;

namespace UTimer.My
{
    // The following events are available for MyApplication:
    // Startup: Raised when the application starts, before the startup form is created.
    // Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    // UnhandledException: Raised if the application encounters an unhandled exception.
    // StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    // NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    internal partial class MyApplication
    {
        private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
        {
            MyProject.Forms.UnhandledExceptionForm.exce = e.Exception;
            MyProject.Forms.UnhandledExceptionForm.Show();
            e.ExitApplication = false;
        }

        private void MyApplication_NetworkAvailabilityChanged(object sender, NetworkAvailableEventArgs e)
        {
        }
    }
}