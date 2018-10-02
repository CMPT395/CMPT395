Public Class signup
    Public SQL As New Sqlcon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim q As String
        Dim d As String
        d = Replace(DOB.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        'Label11.Text = d
        q = FName.Text & "','" & LName.Text & "','" & License.Text & "','" & d & "','" &
            Streetnum.Text & "','" & Street.Text & "','" & City.Text & "','" & Province.Text & "','" &
            Country.Text & "','"
        ' & "," & Phone.Text & "," & Password.Text
        'test.Text = q
        'SQL.ExecQuery("INSERT INTO Customer VALUES(" & q & Phone.Text & Password.Text & ");")
        SQL.ExecQuery("
        INSERT INTO Customer(first_name,last_name,license,DOB,street_num,street_address,city,province,country,phone_primary,passwords)
        VALUES ('" & q & Phone.Text & "','" & Password.Text & "')")
        MsgBox("Done")
    End Sub

    Private Sub DOB_ValueChanged(sender As Object, e As EventArgs) Handles DOB.ValueChanged

    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class