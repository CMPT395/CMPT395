Public Class Report
    Public SQL As New Sqlcon


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If Sql.HasConnection = True Then
            EmployeeAction.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PopularCarsButton_Click(sender As Object, e As EventArgs) Handles PopularCarsButton.Click
        SQL.ExecQuery("SELECT temp.VIN, make,model,description, rentalTimes
                        FROM
                            (SELECT VIN, count(VIN) AS rentalTimes
                            FROM Rental
                            WHERE from_date > '" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "' 
                                AND from_date < '" & DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") & "' 
                            GROUP BY VIN
                            ) as temp, Car, CarType
                         WHERE temp.VIN = Car.VIN and Car.CTID = CarType.CTID 
                                
                        ORDER BY rentalTimes DESC")
        'WHERE Rental.VIN = Car.VIN and Car.CTID = CarType.CTID
        DataGridView1.DataSource = SQL.DBDS.Tables(0)
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub PopularBranchButton_Click(sender As Object, e As EventArgs) Handles PopularBranchButton.Click
        SQL.ExecQuery("SELECT temp.BID_F, street_address, city, province, rentalFromTimes
                        FROM
                            (SELECT BID_F, count(BID_F) AS rentalFromTimes
                            FROM Rental
                            WHERE from_date > '" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "' 
                                AND from_date < '" & DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") & "'                       
                            GROUP BY BID_F
                            ) as temp, Branch
                         WHERE temp.BID_F = Branch.BID
                        ORDER BY rentalFromTimes DESC")
        'WHERE Rental.VIN = Car.VIN and Car.CTID = CarType.CTID
        DataGridView1.DataSource = SQL.DBDS.Tables(0)
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
    End Sub

    Private Sub CustomerRatingBtn_Click(sender As Object, e As EventArgs) Handles CustomerRatingBtn.Click
        SQL.ExecQuery("SELECT temp.BID_F, street_address, city, province, ratingAVG
                        FROM
                            (SELECT BID_F, AVG(rating) AS ratingAVG
                            FROM Rental
                            WHERE from_date > '" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "' 
                                AND from_date < '" & DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") & "'                       
                            GROUP BY BID_F
                            ) as temp, Branch
                         WHERE temp.BID_F = Branch.BID
                        ORDER BY ratingAVG DESC")
        'WHERE Rental.VIN = Car.VIN and Car.CTID = CarType.CTID
        DataGridView1.DataSource = SQL.DBDS.Tables(0)
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class