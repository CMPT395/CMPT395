Imports System.Data.SqlClient

Public Class Branch_update
    Public Sub LoadGrid()
        login.SQL.ExecQuery("SELECT * FROM Branch where BID = " & login.empBID)
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
    Private Sub View_Click(sender As Object, e As EventArgs) Handles View.Click
        LoadGrid()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Changes updated!")
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        EmployeeAction.Show()

    End Sub

    Private Sub Branch_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class