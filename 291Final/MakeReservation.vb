Imports System.Data.SqlClient

Public Class MakeReservation
    'Public SQL As New Sqlcon
    Public Sub LoadGrid()
        login.SQL.ExecQuery("SELECT *  FROM Rental")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
    Public Sub LoadGridcar()
        login.SQL.ExecQuery("SELECT VIN,daily_cost,weekly_cost,monthly_cost,status  FROM Car, CarType WHERE Car.CTID = CARType.CTID and car.status = 'a'")
        DataGridView2.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If login.SQL.HasConnection = True Then
            EmployeeAction.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As String
        Dim t As String
        f = Replace(from_date.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        t = Replace(to_date.Value.Date.ToString("yyyy/MM/dd"), "/", "-")

        login.SQL.ExecQuery("
        INSERT INTO Rental(VIN,CUSID,BID_F,BID_T,from_date,to_date,Cost)
        VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & f & "','" & t & "','" & TextBox5.Text & "')")
        MsgBox("Reservation Processed!")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadGrid()
    End Sub

    Private Sub carList_Click(sender As Object, e As EventArgs) Handles carList.Click
        LoadGridcar()
    End Sub
End Class