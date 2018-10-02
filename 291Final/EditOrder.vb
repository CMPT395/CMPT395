Imports System.Data.SqlClient

Public Class EditOrder
    Public Sub LoadGrid()
        Dim carid, cus, dropoff, fromm As String
        carid = " and VIN = "
        cus = " and CUSID = "
        dropoff = " and BID_T = "
        fromm = " and BID_F = "
        If CIDText.Text = "" Then
            carid = ""
        End If
        If CUSIDText.Text = "" Then
            cus = ""
        End If
        If BID_TTEXT.Text.ToString = "" Then
            dropoff = ""
        End If
        If BID_FText.Text.ToString = "" Then
            fromm = ""
        End If

        login.SQL.ExecQuery("SELECT RID,VIN,CUSID,BID_F as From_Branch,BID_T as Return_Branch,from_date as Rent_Date,
                            to_date as Return_Date,Cost FROM rental where RID =RID" & carid & CIDText.Text.ToString &
                            cus & CUSIDText.Text.ToString & dropoff & BID_TTEXT.Text.ToString & fromm & BID_FText.Text.ToString)
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        EmployeeAction.Show()

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to cancel this order", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Deleted")
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        LoadGrid()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Changes updated!")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
    Private Sub Form_Unload(Cancel As Integer)
        End '程序整个结束
    End Sub
End Class