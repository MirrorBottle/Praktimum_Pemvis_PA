Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If UserHelper.IsLogin() Then
                ' If login is successful, show the main form
                Dim mainForm As New AdminDashboardForm()
                mainForm.ShowDialog()
            End If
        End Sub

        Private Sub MyApplication_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Shutdown
            ' Check if the closing form is the main form
            If MainForm IsNot Nothing AndAlso MainForm.Visible Then
                ' Display a confirmation prompt when closing the main form
                Dim result As DialogResult = MessageBox.Show("Do you want to close the application?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' If the user chooses not to close the form, cancel the shutdown event
                If result = DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        End Sub
    End Class
End Namespace
