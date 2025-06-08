Public Class PrintException
    Public Sub New(ByRef ex As Exception, Optional ByVal Test As TestItem = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Prop_Exception.SelectedObject = ex
        Prop_HelpLink.SelectedObject = ex.HelpLink
        Prop_StackTrace.SelectedObject = ex.StackTrace
        Prop_TargetSite.SelectedObject = ex.TargetSite
        HelpLink.Text = ex.HelpLink
        Stacktrace.Text = ex.StackTrace
        Message.Text = ex.Message
        TargetSite.Text = ex.TargetSite.ToString
        If IsNothing(Test) Then
        Else

        End If
    End Sub
End Class