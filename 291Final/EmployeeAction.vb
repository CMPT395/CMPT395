Public Class EmployeeAction
    Public SQL As New Sqlcon

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SQL.HasConnection = True Then
            MakeReservation.Show()
            Me.Hide()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SQL.HasConnection = True Then
            EditOrder.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SQL.HasConnection = True Then
            Report.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If SQL.HasConnection = True Then
            login.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles car.Click
        If SQL.HasConnection = True Then
            EditCar.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If SQL.HasConnection = True Then
            CheckOut.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Branch_Click(sender As Object, e As EventArgs) Handles branch.Click
        Me.Close()
        Branch_update.Show()

    End Sub
End Class
