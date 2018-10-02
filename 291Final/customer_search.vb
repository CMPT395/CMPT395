Imports System.Data.SqlClient

Public Class customer_search
    Public SQL As New Sqlcon
    Public Sub LoadGrid()
        Dim VT, B, T As String
        VT = "where AA.description = '" & carTypeBox.SelectedItem & "'"
        'Label5.Text = VT
        B = " and AA.city = '" & BranchBox.SelectedItem & "'"
        T = " and AA.transmission = '" & TransmissionBox.SelectedItem & "'"

        If carTypeBox.SelectedItem = "All" Then
            VT = "where AA.description = description"
        End If

        If BranchBox.SelectedItem = "All" Then
            B = ""
        End If
        If TransmissionBox.SelectedItem = "All" Then
            T = ""
        End If

        SQL.ExecQuery("SELECT
                            VIN, make, description, model, transmission, street_address, city, province, email, phone
                            
                        FROM (SELECT 
                                VIN, make, description, model, transmission, street_address, city, province, email, phone

                              FROM Car,CarType,Branch 
                              WHERE Car.CTID = CarType.CTID and Branch.BID = car.BID) As AA " & VT & T & B) 'and " & VT & "  and " & B & "and " & T & " and Car.status = 'a'")

        DataGridView1.DataSource = Sql.DBDS.Tables(0)
    End Sub

    Private Sub CS_Search_button_Click(sender As Object, e As EventArgs) Handles CS_Search_button.Click
        LoadGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        customer_history_ratings.Show()
    End Sub

    Private Sub customer_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class