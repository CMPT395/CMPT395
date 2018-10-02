Imports System.Data.SqlClient
Public Class customer_history_ratings
    Public SQL As New Sqlcon
    Private Sub vbnet_rentHistory_values_from_Sql_load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL.ExecQuery("SELECT RID, make,  model, from_date, to_date  FROM  rental, car WHERE rental.CUSID=" & login.idshow & "and rental.VIN = car.VIN")

        userHistoryComboBox.DataSource = SQL.DBDS.Tables(0)

        SQL.DBDS.Tables(0).Columns.Add("displayCol", GetType(String), "RID+' '+make+' '+model+' from '+from_date+' to '+to_date")
        userHistoryComboBox.DisplayMember = "displayCol"
        userHistoryComboBox.ValueMember = "RID"

        generalRateBox.Items.Add("1")
        generalRateBox.Items.Add("2")
        generalRateBox.Items.Add("3")
        generalRateBox.Items.Add("4")
        generalRateBox.Items.Add("5")


        vehicleRateBox.Items.Add("1")
        vehicleRateBox.Items.Add("2")
        vehicleRateBox.Items.Add("3")
        vehicleRateBox.Items.Add("4")
        vehicleRateBox.Items.Add("5")


        serviceRateBox.Items.Add("1")
        serviceRateBox.Items.Add("2")
        serviceRateBox.Items.Add("3")
        serviceRateBox.Items.Add("4")
        serviceRateBox.Items.Add("5")





    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        customer_search.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userHistoryComboBox.SelectedIndexChanged

    End Sub

    Private Sub HistoryComboBoxFormat(sender As Object, e As ListControlConvertEventArgs) Handles userHistoryComboBox.Format

    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        If (generalRateBox.SelectedIndex >= 0 And generalRateBox.SelectedIndex < 5) And
             (vehicleRateBox.SelectedIndex >= 0 And vehicleRateBox.SelectedIndex < 5) And
                 (serviceRateBox.SelectedIndex >= 0 And serviceRateBox.SelectedIndex < 5) Then
            SQL.ExecQuery("UPDATE rental
                           SET rating=" & generalRateBox.SelectedIndex + 1 & ", car_rating=" & vehicleRateBox.SelectedIndex + 1 & ", service_rating = " & serviceRateBox.SelectedIndex + 1 & "
                           WHERE rental.CUSID=" & login.idshow & " and rental.RID=" & userHistoryComboBox.SelectedValue)

            MsgBox("Thank you for feedback!")

        Else
            MsgBox("please select all three feedback and try again")
        End If

    End Sub
End Class