Imports System.Data.SqlClient

Public Class EditCar
    'Public SQL As New Sqlcon

    Public Sub LoadGrid()
        login.SQL.ExecQuery("SELECT * FROM Car")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If login.SQL.HasConnection = True Then
            EmployeeAction.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            login.SQL.ExecQuery("
            INSERT INTO Car(BID,CTID,make,model,color,fuel,drive_type,engine,transmission,year,mileage,plate,additional_cost,status)
            VALUES ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" &
                         TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" &
                         TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "')")
            MsgBox("Car Information Updated!")
        Catch ex As Exception
            MessageBox.Show("Please Input Information!")
        End Try
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("Add a new car information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Updated")
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("Delete this car information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
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

    Private Sub EditCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class