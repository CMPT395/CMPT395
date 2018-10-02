Public Class CheckOut
    Public SQL As New Sqlcon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Sql.HasConnection = True Then
            EmployeeAction.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inputRIDBox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inputRIDBox.TextChanged

    End Sub

    Public Sub checkOutSearchBtn_Click(sender As Object, e As EventArgs) Handles checkOutSearchBtn.Click

        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        SQL.ExecQuery("SELECT BID_F, BID_T, from_Date, to_date, monthly_cost, weekly_cost, daily_cost,
                        from_Date, to_Date
                        FROM  rental, Car, CarType WHERE rental.VIN = Car.VIN and Car.CTID = CarType.CTID and rental.RID =" & inputRIDBox.Text)
        Try


            pricePerMonTextBox.Text = SQL.DBDS.Tables(0).Rows(0).Item("monthly_cost").ToString
            pricePerWeekTextBox.Text = SQL.DBDS.Tables(0).Rows(0).Item("weekly_cost").ToString
            pricePerDayTextBox.Text = SQL.DBDS.Tables(0).Rows(0).Item("daily_cost").ToString
            latePricePerDayTextBox.Text = SQL.DBDS.Tables(0).Rows(0).Item("daily_cost").ToString

            Dim from_Date As Date
            Dim to_Date As Date
            Dim return_date As Date
            Dim diffDate As Integer
            Dim lateDate As Integer

            from_Date = SQL.DBDS.Tables(0).Rows(0).Item("from_date").ToString
            planFromDateTextBox.Text = from_Date

            to_Date = SQL.DBDS.Tables(0).Rows(0).Item("to_date").ToString
            planToDateTextBox.Text = to_Date

            return_date = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
            Dim span = to_Date - from_Date
            Dim span2 = return_date - to_Date

            diffDate = span.TotalDays
            lateDate = span2.TotalDays

            Dim planRentMonth As Integer
            Dim planRentWeek As Integer
            Dim planRentDay As Integer

            planRentMonth = diffDate / 30
            planRentWeek = (diffDate - planRentMonth * 30) / 7
            planRentDay = diffDate - planRentMonth * 30 - planRentWeek * 7

            darMon.Text = planRentMonth
            darWeek.Text = planRentWeek
            darDays.Text = planRentDay
            lateDarDays.Text = lateDate

            Dim monthlyTotalNum As Integer
            Dim weeklyTotalNum As Integer
            Dim dailyTotalNum As Integer
            Dim lateTotalNum As Integer

            monthlyTotalNum = planRentMonth * pricePerMonTextBox.Text
            weeklyTotalNum = planRentWeek * pricePerWeekTextBox.Text
            dailyTotalNum = planRentDay * pricePerDayTextBox.Text
            lateTotalNum = latePricePerDayTextBox.Text * lateDarDays.Text

            monthlyTotal.Text = monthlyTotalNum
            weekTotal.Text = weeklyTotalNum
            dailyTotal.Text = dailyTotalNum

            lateTotal.Text = lateTotalNum

            Dim rentCostTotal As Integer
            rentCostTotal = monthlyTotalNum + weeklyTotalNum + dailyTotalNum + lateTotalNum
            rentTotalBox.Text = rentCostTotal

            Dim transitFee As Integer
            If (SQL.DBDS.Tables(0).Rows(0).Item("BID_F").ToString = SQL.DBDS.Tables(0).Rows(0).Item("BID_T").ToString) Then
                transitFee = 50
            Else
                transitFee = 0
            End If
            transitFeeBox.Text = transitFee

            Dim totalCost As Integer
            totalCost = rentCostTotal + transitFee
            totalCostBox.Text = totalCost

            Dim tax As Double
            tax = totalCost * 0.05
            taxBox.Text = tax

            Dim totalPayment As Double
            totalPayment = totalCost + tax
            totalPaymentBox.Text = totalPayment


        Catch ex As Exception
            MsgBox("Invalid Rental ID", MsgBoxStyle.Critical, "Failed!")
        End Try

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Public Sub gotMoneyBtn_Click(sender As Object, e As EventArgs) Handles gotMoneyBtn.Click
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        SQL.ExecQuery("UPDATE Car
                        SET Car.status = 'T'
                        FROM  rental, Car
                        WHERE Car.VIN = rental.VIN and RID =" & inputRIDBox.Text)
        SQL.ExecQuery("UPDATE rental
                        SET rental.paid = " & totalPaymentBox.Text & "
                        FROM  rental
                        WHERE RID =" & inputRIDBox.Text)
        MsgBox("The vehicle has update to avaliable, and pamyment has been record.")
    End Sub
End Class