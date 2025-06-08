Public Class CalculTime
    Public Structure TimeInfo
        Public Hours As Integer
        Public Minutes As Integer
    End Structure
    Public Sub Calculate()
        Dim TimeStart As New TimeInfo
        TimeStart.Hours = D0_H.Value
        TimeStart.Minutes = D0_M.Value

        Dim TimeEnd As New TimeInfo
        TimeEnd.Hours = D1_H.Value
        TimeEnd.Minutes = D1_M.Value

        Dim TimeTotal As New TimeInfo
        TimeTotal.Hours = TimeEnd.Hours - TimeStart.Hours
        TimeTotal.Minutes = TimeEnd.Minutes - TimeStart.Minutes
        DF_H.Value = TimeTotal.Hours
        DF_M.Value = TimeTotal.Minutes


        Total100.Text = Math.Round(TimeTotal.Hours + (TimeTotal.Minutes) / 60, 2)

    End Sub

    Private Sub D0_H_ValueChanged(sender As Object, e As EventArgs) Handles D0_H.ValueChanged
        Calculate()
    End Sub

    Private Sub D0_M_ValueChanged(sender As Object, e As EventArgs) Handles D0_M.ValueChanged
        Calculate()
    End Sub

    Private Sub D1_H_ValueChanged(sender As Object, e As EventArgs) Handles D1_H.ValueChanged
        Calculate()
    End Sub

    Private Sub D1_M_ValueChanged(sender As Object, e As EventArgs) Handles D1_M.ValueChanged
        Calculate()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        D0_H.Value = 0
        D0_M.Value = 0
        D1_H.Value = 0
        D1_M.Value = 0
        Total100.Text = 0

    End Sub
End Class