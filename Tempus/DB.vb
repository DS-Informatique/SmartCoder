Imports System.ComponentModel

Public Class DB
    Private Sub DB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bar2.Text = "Status"
    End Sub
#Region "<1> [Property]"
#Region "<01.00> <Property> [Current|SmartCoder.DataBase]"
    Private _Current As SmartCoder.DataBase
    Public Property Current() As SmartCoder.DataBase
        Get
            Return _Current
        End Get
        Set(ByVal value As SmartCoder.DataBase)
            _Current = value
            If Not IsNothing(value) Then
                Input_FilePath.Text = value.Target
                If Input_Password.Text.Length > 1 Then
                    value.Password = Input_Password.Text
                Else
                    Input_Password.Text = value.Password
                End If
                Output_Line.Text = value.Line.Line
                AdvPropertyGrid1.SelectedObject = value

            End If
        End Set
    End Property
#End Region
#Region "<01.01> <Property> [Target|String]"
    Private _Target As String
    Public Property Target() As String
        Get
            Return _Target
        End Get
        Set(ByVal value As String)
            _Target = value
            If Not IsNothing(value) Then
                If value.Length > 1 Then
                    If IO.File.Exists(value) Then
                        Test_File.Value = True
                        Current = New SmartCoder.M_FileManager.DataBase(value, Password, False)

                    Else
                        Test_File.Value = False
                    End If
                End If
            End If
        End Set
    End Property
#End Region
    Public Property JobReady As Boolean = False
#Region "<01.02> <Property> [Target|String]"
    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
            If Not IsNothing(value) Then
                If value.Length > 1 Then
                    Input_Password.Text = value
                End If
            End If
        End Set
    End Property

    Private Sub Btn_Test_Click(sender As Object, e As EventArgs) Handles Btn_Test.Click
        Test_File.Value = False
        Test_Importation.Value = False
        Test_Line.Value = False




        Test_File.Value = IO.File.Exists(Target)
        If Not IsNothing(Current) Then
            If Current.TableCount > 1 Then
                Test_Importation.Value = True
            Else
                Test_Importation.Value = False
            End If
            Output_Line.Text = Current.Line.Line
            If Current.Line.Line.Length > 1 Then
                Test_Line.Value = True
            Else
                Test_Line.Value = False

            End If
            If Not IsNothing(Current.Tables) Then
                SGC.PrimaryGrid.DataSource = Current.Tables
            End If
        Else
            Test_Importation.Value = False
            Test_Line.Value = False
        End If

        If Test_File.Value = True And Test_Importation.Value = True And Test_Line.Value = True Then
            Pb_Test.Image = My.Resources.check_mark
            JobReady = True
        Else

            Pb_Test.Image = My.Resources.close
        End If

    End Sub

    Private Sub DataBaseConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False

    End Sub
    Public Sub ReleaseMemory()
        If Not IsNothing(Current) Then
            Current.Tables = New List(Of SmartCoder.M_FileManager.Table)
            GC.Collect()
        End If
    End Sub
    Private Sub Btn_Define_Click(sender As Object, e As EventArgs) Handles Btn_Define.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = DialogResult.OK Then
            JobReady = False
            Target = OFD.FileName
        End If
        Btn_Test.PerformClick()

    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Btn_Load.Enabled = False
        Current.GetTables(False)
    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        Btn_Test.PerformClick()
        Btn_Load.Enabled = True
    End Sub

    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click
        If BW.IsBusy = True Then
        Else
            BW.RunWorkerAsync()
        End If
    End Sub


#End Region

#End Region
End Class
