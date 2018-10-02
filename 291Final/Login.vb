Public Class login
    Public SQL As New Sqlcon
    Public idshow As String
    Public empBID As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CUSLLOGIN.Click
        If SQL.HasConnection = True Then
            If CUSLog() = True Then
                MsgBox("Login as Customer successful!")
                Customer_search.Show()
                Me.Hide()
                idshow = TextBox1.Text
            End If
        End If
    End Sub

    Private Function CUSLog() As Boolean
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        If Len(TextBox1.Text) <> 0! Or Len(TextBox2.Text) <> 0! Then
            SQL.ExecQuery("SELECT Count(CUSID) As userCount FROM Customer WHERE CUSID=" & TextBox1.Text &
        " AND PASSWORDS='" & TextBox2.Text & "'")

            If SQL.DBDS.Tables(0).Rows(0).Item("userCount") = 1 Then
                Return True
            End If

            MsgBox("Invalid id or password", MsgBoxStyle.Critical, "Failed!")
            Return False
        End If
        MsgBox("There is Nothing")
        Return False
    End Function

    Private Function EMPLog() As Boolean
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        If Len(TextBox1.Text) <> 0! Or Len(TextBox2.Text) <> 0! Then
            SQL.ExecQuery("SELECT Count(EID) As userCount FROM Employee WHERE EID=" & TextBox1.Text &
            " AND PASSWORDS='" & TextBox2.Text & "'")
            If SQL.DBDS.Tables(0).Rows(0).Item("userCount") = 1 Then
                '
                Return True
            End If
            MsgBox("Invalid id or password", MsgBoxStyle.Critical, "Failed!")
            Return False
        End If
        MsgBox("you entered nothing")
        Return False
    End Function

    Private Sub EMPLOGIN_Click(sender As Object, e As EventArgs) Handles EMPLOGIN.Click
        If SQL.HasConnection = True Then
            If EMPLog() = True Then
                SQL.ExecQuery("SELECT BID FROM Employee WHERE EID=" & TextBox1.Text)
                empBID = SQL.DBDS.Tables(0).Rows(0).Item("BID")
                MsgBox("Login as Employee successful!")
                EmployeeAction.Show()
                Me.Hide()
                idshow = TextBox1.Text
                EmployeeAction.Label2.Text = "Employee ID:" & TextBox1.Text
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        signup.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
