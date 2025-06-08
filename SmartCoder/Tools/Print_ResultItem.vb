Imports System.Windows.Forms

Public Class Print_ResultItem
#Region "<0> [Property]"
#Region "<00.00> <Property> [TestItem]"
#Region "<00.00.00> <Property> <TestItem> [Analyse | TestItem]"
    Private _Analyse As TestItem
    Public Property Analyse() As TestItem
        Get
            Return _Analyse
        End Get
        Set(ByVal value As TestItem)
            If IsNothing(value) Then
            Else

            End If
            _Analyse = value
        End Set
    End Property


#End Region
#End Region

#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal Test As TestItem)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Analyse = Test
        RefreshTest()
    End Sub
    Public Sub RefreshTest()
        Text = Analyse.Name
        '   L_TestName.ForeColor = Color.White
        '
        'Retrieve Results Percentage
        '
        ' Txt_Fail.Text = "(" & Analyse.Percentage_Fail & " %)"
        'Txt_Pass.Text = "(" & Analyse.Percentage_Pass & " %)"
        'Txt_Nul.Text = "(" & Analyse.Percentage_Nul & " %)"
        'Txt_Warning.Text = "(" & Analyse.Percentage_Warning & " %)"
        '   >Printing results also in small report
        Txt_Fail2.Text = "(" & Analyse.Percentage_Fail & " %)"
        Txt_Nul2.Text = "(" & Analyse.Percentage_Nul & " %)"
        Txt_Pass2.Text = "(" & Analyse.Percentage_Pass & " %)"
        Txt_Erreur2.Text = "(" & Analyse.Percentage_Warning & " %)"
        '
        'Format Node1 for DevComponents.DotNetBar.AdvTree
        '
        'Node1.Text = "[Analyse] " & Analyse.Name
        'Node1.ImageIndex = 10
        'Node1.Tag = Analyse
        'Node1.Tooltip = Analyse.Hypothesis
        '
        'Format Node 2 for DevComponents.DotNetBar.Tree
        '
        Node2.Text = "[Analyse] " & Analyse.Name
        Node2.ImageIndex = 10
        Node2.Tag = Analyse
        ' Node2.Nodes.Add(Analyse.NodeG.DeepCopy)
        '
        'Clip the Properties in the PropertyGrid
        '
        iProperty.SelectedObject = Analyse
        '
        'Print the Hypothesis
        '
        Hypothesis.Text = Analyse.Hypothesis
        '
        'Print Input Variables
        '
        '   >For Input
        Txt_InputString.Text = Analyse.InputString
        Input_Prop.SelectedObject = Analyse.Input
        '   >For Output
        Txt_OutputString.Text = Analyse.InputString
        Prop_Output.SelectedObject = Analyse.Output
        '   >For Object Analysed
        Prop_Object_Analysed.SelectedObject = Analyse.Input
        '
        'Preparing Status
        '   >Check if items are not empty of CB_Status
        If CB_Status.Items.Count - 1 >= 0 Then
            CB_Status.Items.Clear()
        End If
        '   >Populating CB_Status
        CB_Status.Items.Add(Status.Broken.ToString)
        CB_Status.Items.Add(Status.Finished.ToString)
        CB_Status.Items.Add(Status.IsNothing.ToString)
        CB_Status.Items.Add(Status.NotTested.ToString)
        CB_Status.Items.Add(Status.Offline.ToString)
        CB_Status.Items.Add(Status.Online.ToString)
        CB_Status.Items.Add(Status.Running.ToString)
        CB_Status.Items.Add(Status.StandBye.ToString)
        CB_Status.Items.Add(Status.Warning.ToString)
        '   >Storing the actual Analyse
        CB_Status.Text = Analyse.Status.ToString
        '
        'Preparing List_Results
        '   >Clear content if any
        If List_Results.Items.Count - 1 > 0 Then
            List_Results.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.Results is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.Results) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.Results
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Results.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Results.Items.Add(it)
                Next
            End If

        End If
        '
        'Preparing List_Fail
        '   >Clear content if any
        If List_Fail.Items.Count - 1 > 0 Then
            List_Fail.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Fail <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Fails is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Fails) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Fails
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Fail.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Fail.Items.Add(it)
                Next
            End If
        End If
        '
        'Preparing List_Success
        '   >Clear content if any
        If List_Success.Items.Count - 1 > 0 Then
            List_Success.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Pass <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Pass is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Pass) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Pass
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Success.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Success.Items.Add(it)
                Next
            End If

        End If
        '
        'Preparing List_Warning
        '   >Clear content if any
        If List_Warning.Items.Count - 1 > 0 Then
            List_Warning.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Warning <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Warning is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Warning) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Warning
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Warning.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Warning.Items.Add(it)
                Next
            End If

        End If
        '
        'Preparing List_Nul
        '   >Clear content if any
        If List_Nul.Items.Count - 1 > 0 Then
            List_Nul.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Pass <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Pass is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Nul) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Nul
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Nul.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Nul.Items.Add(it)
                Next
            End If

        End If
        '
        'Printing the report track Analyse
        Why.Text = Analyse.Why
        '
        'Printing the body
        Body.Text = Analyse.Body
        '
        'Preparing List_Events
        '   >Clear content if any
        If List_Events.Items.Count - 1 > 0 Then
            List_Events.Items.Clear()
        End If
        'verifiying this statement by analysing if Analyse.List_Fails is nothing
        'to avoid exception during runtime.
        If IsNothing(Analyse.Events) Then
            'Exception captured. Count is not properly set
            MsgBox("Exception captured. Count is not properly set")
        Else
            'sub test recorded
            For Each Element As TestItem.Evenement In Analyse.Events
                'Creating a New ListViewItem
                Dim it As New ListViewItem
                With it
                    .Name = Element.Name
                    .ImageIndex = Element.Status
                    .Text = Element.ID '
                    .SubItems.Add(Element.Name)
                    .SubItems.Add(FormatDateTime(Element.Time))
                    .SubItems.Add(Element.Status.ToString)
                    .SubItems.Add(Element.Description)
                    .SubItems.Add(Element.Hypothesis)
                    .SubItems.Add(Element.Ref)
                    .Tag = Element.Tag
                    .ToolTipText = Element.Hypothesis
                End With
                List_Events.Items.Add(it)
            Next
        End If
        '
        'Preparing List_Events
        '   >Clear content if any
        If List_Exceptions.Items.Count - 1 > 0 Then
            List_Exceptions.Items.Clear()
        End If
        'verifiying this statement by analysing if Analyse.List_Fails is nothing
        'to avoid exception during runtime.
        If IsNothing(Analyse.Bugs) Then
            'Exception captured. Count is not properly set
            MsgBox("Exception captured. Count is not properly set")
        Else
            'sub test recorded
            For Each Element As TestItem.Bug In Analyse.Bugs
                'Creating a New ListViewItem
                Dim it As New ListViewItem
                With it
                    .Name = Element.Name
                    .ImageIndex = Status.Warning
                    .Text = Element.ID '
                    .SubItems.Add(FormatDateTime(Element.Time))
                    .SubItems.Add(Element.Name)
                    .SubItems.Add(Element.Source)
                    .SubItems.Add(Element.Message)
                    .SubItems.Add(Element.TargetSite)
                    .SubItems.Add(Element.StackTrace)
                    .SubItems.Add(Element.HelpLink)
                    .Tag = Element
                    .ToolTipText = Element.Message
                End With
                List_Exceptions.Items.Add(it)
            Next
        End If
        '
#Region "<Printing Variables>"
        Analyse.Report(True)
        'Node1.Nodes.Add(Analyse.Node.DeepCopy)
        Node2.Nodes.Add(Analyse.NodeG.DeepCopy)
#End Region

    End Sub
    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click
        Analyse.Email_Saadry()
    End Sub
    Public Property SelectedTest As TestItem
    Private Sub List_Exceptions_Click(sender As Object, e As EventArgs) Handles List_Exceptions.Click
        If IsNothing(List_Exceptions.SelectedItems(0).Tag) Then
        Else
            Dim B As TestItem.Bug
            B = List_Exceptions.SelectedItems(0).Tag
            Dim PrintBug As New PrintException(B.SelectedException)
            PrintBug.Show()
        End If

    End Sub
    Private Sub List_Fail_DoubleClick(sender As Object, e As EventArgs) Handles List_Fail.DoubleClick
        If IsNothing(List_Fail.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Fail.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Fail.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Results_DoubleClick(sender As Object, e As EventArgs) Handles List_Results.DoubleClick
        If IsNothing(List_Results.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Results.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Results.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Success_DoubleClick(sender As Object, e As EventArgs) Handles List_Success.DoubleClick
        If IsNothing(List_Success.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Success.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Success.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Warning_DoubleClick(sender As Object, e As EventArgs) Handles List_Warning.DoubleClick
        If IsNothing(List_Warning.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Warning.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Warning.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Nul_DoubleClick(sender As Object, e As EventArgs) Handles List_Nul.DoubleClick
        If IsNothing(List_Nul.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Nul.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Nul.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub
End Class