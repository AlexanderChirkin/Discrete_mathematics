

Imports GeneralLogic

Public Class Form1
    Dim Array As ArrayInt

    Private Sub txtNumberOfItem_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfItem.TextChanged
        Dim n As Integer
        If Integer.TryParse(txtNumberOfItem.Text, n) Then
            Array = New ArrayInt(n)
        End If
    End Sub

    Private Sub ShowArray()
        Dim i As Integer
        If DataGridView.Rows.Count > 1 Then
            For i = DataGridView.Rows.Count - 1 To 1 Step -1
                DataGridView.Rows.RemoveAt(i - 1)
            Next
        End If

        For i = 0 To Array.Length - 1
            DataGridView.Rows.Add()
            DataGridView(0, i).Value = i
            DataGridView(1, i).Value = Array.Values(i)
        Next
    End Sub

    Private Sub btnFillRandom_Click(sender As Object, e As EventArgs) Handles btnFillRandom.Click
        Dim min, max As Integer
        If Integer.TryParse(txtMax.Text, max) And Integer.TryParse(txtMin.Text, min) And min < max Then
            Array.RandomFill(min, max)
        End If
        ShowArray()
    End Sub
End Class
