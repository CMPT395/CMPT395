<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inputRIDBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.gotMoneyBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkOutSearchBtn = New System.Windows.Forms.Button()
        Me.rentTotalBox = New System.Windows.Forms.TextBox()
        Me.transitFeeBox = New System.Windows.Forms.TextBox()
        Me.totalCostBox = New System.Windows.Forms.TextBox()
        Me.taxBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalPaymentBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.darDays = New System.Windows.Forms.TextBox()
        Me.darWeek = New System.Windows.Forms.TextBox()
        Me.darMon = New System.Windows.Forms.TextBox()
        Me.pricePerDayTextBox = New System.Windows.Forms.TextBox()
        Me.pricePerWeekTextBox = New System.Windows.Forms.TextBox()
        Me.pricePerMonTextBox = New System.Windows.Forms.TextBox()
        Me.monthlyTotal = New System.Windows.Forms.TextBox()
        Me.weekTotal = New System.Windows.Forms.TextBox()
        Me.dailyTotal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.planToDateTextBox = New System.Windows.Forms.TextBox()
        Me.lateDarDays = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.latePricePerDayTextBox = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lateTotal = New System.Windows.Forms.TextBox()
        Me.planFromDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(239, 344)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 25)
        Me.Label15.TabIndex = 105
        Me.Label15.Text = "Return Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(239, 263)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 25)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Rental ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1183, 393)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 25)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(911, 393)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 25)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Total Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1183, 320)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 25)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(485, 833)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 25)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "$"
        '
        'inputRIDBox
        '
        Me.inputRIDBox.Location = New System.Drawing.Point(475, 263)
        Me.inputRIDBox.Margin = New System.Windows.Forms.Padding(6)
        Me.inputRIDBox.Name = "inputRIDBox"
        Me.inputRIDBox.Size = New System.Drawing.Size(196, 31)
        Me.inputRIDBox.TabIndex = 94
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(370, 7)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.MaximumSize = New System.Drawing.Size(1000, 962)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(835, 224)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Search Order and Check Out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(911, 320)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Transit Fee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 833)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Rental Cost"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(475, 339)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 31)
        Me.DateTimePicker1.TabIndex = 89
        '
        'gotMoneyBtn
        '
        Me.gotMoneyBtn.Location = New System.Drawing.Point(985, 717)
        Me.gotMoneyBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.gotMoneyBtn.Name = "gotMoneyBtn"
        Me.gotMoneyBtn.Size = New System.Drawing.Size(298, 48)
        Me.gotMoneyBtn.TabIndex = 88
        Me.gotMoneyBtn.Text = "Got payment"
        Me.gotMoneyBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 79)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 48)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'checkOutSearchBtn
        '
        Me.checkOutSearchBtn.Location = New System.Drawing.Point(277, 390)
        Me.checkOutSearchBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.checkOutSearchBtn.Name = "checkOutSearchBtn"
        Me.checkOutSearchBtn.Size = New System.Drawing.Size(298, 48)
        Me.checkOutSearchBtn.TabIndex = 106
        Me.checkOutSearchBtn.Text = "Search"
        Me.checkOutSearchBtn.UseVisualStyleBackColor = True
        '
        'rentTotalBox
        '
        Me.rentTotalBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.rentTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rentTotalBox.Location = New System.Drawing.Point(550, 827)
        Me.rentTotalBox.Name = "rentTotalBox"
        Me.rentTotalBox.Size = New System.Drawing.Size(156, 31)
        Me.rentTotalBox.TabIndex = 107
        '
        'transitFeeBox
        '
        Me.transitFeeBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.transitFeeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.transitFeeBox.Location = New System.Drawing.Point(1216, 317)
        Me.transitFeeBox.Name = "transitFeeBox"
        Me.transitFeeBox.Size = New System.Drawing.Size(156, 31)
        Me.transitFeeBox.TabIndex = 109
        '
        'totalCostBox
        '
        Me.totalCostBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.totalCostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalCostBox.Location = New System.Drawing.Point(1216, 390)
        Me.totalCostBox.Name = "totalCostBox"
        Me.totalCostBox.Size = New System.Drawing.Size(156, 31)
        Me.totalCostBox.TabIndex = 110
        '
        'taxBox
        '
        Me.taxBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.taxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxBox.Location = New System.Drawing.Point(1216, 457)
        Me.taxBox.Name = "taxBox"
        Me.taxBox.Size = New System.Drawing.Size(156, 31)
        Me.taxBox.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1183, 460)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 25)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(911, 460)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 25)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "tax"
        '
        'totalPaymentBox
        '
        Me.totalPaymentBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.totalPaymentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPaymentBox.Location = New System.Drawing.Point(1216, 623)
        Me.totalPaymentBox.Name = "totalPaymentBox"
        Me.totalPaymentBox.Size = New System.Drawing.Size(156, 31)
        Me.totalPaymentBox.TabIndex = 116
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1173, 623)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 25)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(911, 623)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 25)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "total payment"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(187, 544)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 25)
        Me.Label16.TabIndex = 117
        Me.Label16.Text = "months"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(443, 544)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 25)
        Me.Label17.TabIndex = 118
        Me.Label17.Text = "$/month"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(190, 620)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 25)
        Me.Label18.TabIndex = 119
        Me.Label18.Text = "weeks"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(443, 620)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 25)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "$/week"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(443, 689)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 25)
        Me.Label20.TabIndex = 121
        Me.Label20.Text = "$/day"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(190, 689)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 25)
        Me.Label22.TabIndex = 122
        Me.Label22.Text = "days"
        '
        'darDays
        '
        Me.darDays.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.darDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.darDays.Location = New System.Drawing.Point(85, 687)
        Me.darDays.Name = "darDays"
        Me.darDays.Size = New System.Drawing.Size(87, 31)
        Me.darDays.TabIndex = 123
        '
        'darWeek
        '
        Me.darWeek.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.darWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.darWeek.Location = New System.Drawing.Point(85, 618)
        Me.darWeek.Name = "darWeek"
        Me.darWeek.Size = New System.Drawing.Size(87, 31)
        Me.darWeek.TabIndex = 124
        '
        'darMon
        '
        Me.darMon.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.darMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.darMon.Location = New System.Drawing.Point(85, 542)
        Me.darMon.Name = "darMon"
        Me.darMon.Size = New System.Drawing.Size(87, 31)
        Me.darMon.TabIndex = 125
        '
        'pricePerDayTextBox
        '
        Me.pricePerDayTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pricePerDayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pricePerDayTextBox.Location = New System.Drawing.Point(317, 689)
        Me.pricePerDayTextBox.Name = "pricePerDayTextBox"
        Me.pricePerDayTextBox.Size = New System.Drawing.Size(117, 31)
        Me.pricePerDayTextBox.TabIndex = 126
        '
        'pricePerWeekTextBox
        '
        Me.pricePerWeekTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pricePerWeekTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pricePerWeekTextBox.Location = New System.Drawing.Point(317, 618)
        Me.pricePerWeekTextBox.Name = "pricePerWeekTextBox"
        Me.pricePerWeekTextBox.Size = New System.Drawing.Size(117, 31)
        Me.pricePerWeekTextBox.TabIndex = 127
        '
        'pricePerMonTextBox
        '
        Me.pricePerMonTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pricePerMonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pricePerMonTextBox.Location = New System.Drawing.Point(317, 544)
        Me.pricePerMonTextBox.Name = "pricePerMonTextBox"
        Me.pricePerMonTextBox.Size = New System.Drawing.Size(117, 31)
        Me.pricePerMonTextBox.TabIndex = 128
        '
        'monthlyTotal
        '
        Me.monthlyTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.monthlyTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monthlyTotal.Location = New System.Drawing.Point(589, 544)
        Me.monthlyTotal.Name = "monthlyTotal"
        Me.monthlyTotal.Size = New System.Drawing.Size(117, 31)
        Me.monthlyTotal.TabIndex = 129
        '
        'weekTotal
        '
        Me.weekTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.weekTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.weekTotal.Location = New System.Drawing.Point(589, 618)
        Me.weekTotal.Name = "weekTotal"
        Me.weekTotal.Size = New System.Drawing.Size(117, 31)
        Me.weekTotal.TabIndex = 130
        '
        'dailyTotal
        '
        Me.dailyTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.dailyTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dailyTotal.Location = New System.Drawing.Point(589, 689)
        Me.dailyTotal.Name = "dailyTotal"
        Me.dailyTotal.Size = New System.Drawing.Size(117, 31)
        Me.dailyTotal.TabIndex = 131
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(80, 472)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(139, 25)
        Me.Label21.TabIndex = 132
        Me.Label21.Text = "Planned from"
        '
        'planToDateTextBox
        '
        Me.planToDateTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.planToDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.planToDateTextBox.Location = New System.Drawing.Point(517, 475)
        Me.planToDateTextBox.Name = "planToDateTextBox"
        Me.planToDateTextBox.Size = New System.Drawing.Size(189, 31)
        Me.planToDateTextBox.TabIndex = 133
        '
        'lateDarDays
        '
        Me.lateDarDays.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lateDarDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lateDarDays.Location = New System.Drawing.Point(85, 751)
        Me.lateDarDays.Name = "lateDarDays"
        Me.lateDarDays.Size = New System.Drawing.Size(87, 31)
        Me.lateDarDays.TabIndex = 135
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(190, 753)
        Me.Label23.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 25)
        Me.Label23.TabIndex = 134
        Me.Label23.Text = "late days"
        '
        'latePricePerDayTextBox
        '
        Me.latePricePerDayTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.latePricePerDayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.latePricePerDayTextBox.Location = New System.Drawing.Point(317, 753)
        Me.latePricePerDayTextBox.Name = "latePricePerDayTextBox"
        Me.latePricePerDayTextBox.Size = New System.Drawing.Size(117, 31)
        Me.latePricePerDayTextBox.TabIndex = 137
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(443, 753)
        Me.Label24.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 25)
        Me.Label24.TabIndex = 136
        Me.Label24.Text = "$/day"
        '
        'lateTotal
        '
        Me.lateTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lateTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lateTotal.Location = New System.Drawing.Point(589, 756)
        Me.lateTotal.Name = "lateTotal"
        Me.lateTotal.Size = New System.Drawing.Size(117, 31)
        Me.lateTotal.TabIndex = 138
        '
        'planFromDateTextBox
        '
        Me.planFromDateTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.planFromDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.planFromDateTextBox.Location = New System.Drawing.Point(244, 475)
        Me.planFromDateTextBox.Name = "planFromDateTextBox"
        Me.planFromDateTextBox.Size = New System.Drawing.Size(190, 31)
        Me.planFromDateTextBox.TabIndex = 139
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(455, 475)
        Me.Label25.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 25)
        Me.Label25.TabIndex = 140
        Me.Label25.Text = "To"
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 937)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.planFromDateTextBox)
        Me.Controls.Add(Me.lateTotal)
        Me.Controls.Add(Me.latePricePerDayTextBox)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lateDarDays)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.planToDateTextBox)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.dailyTotal)
        Me.Controls.Add(Me.weekTotal)
        Me.Controls.Add(Me.monthlyTotal)
        Me.Controls.Add(Me.pricePerMonTextBox)
        Me.Controls.Add(Me.pricePerWeekTextBox)
        Me.Controls.Add(Me.pricePerDayTextBox)
        Me.Controls.Add(Me.darMon)
        Me.Controls.Add(Me.darWeek)
        Me.Controls.Add(Me.darDays)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.totalPaymentBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.taxBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.totalCostBox)
        Me.Controls.Add(Me.transitFeeBox)
        Me.Controls.Add(Me.rentTotalBox)
        Me.Controls.Add(Me.checkOutSearchBtn)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.inputRIDBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.gotMoneyBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "CheckOut"
        Me.Text = "CheckOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents inputRIDBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents gotMoneyBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents checkOutSearchBtn As Button
    Friend WithEvents rentTotalBox As TextBox
    Friend WithEvents transitFeeBox As TextBox
    Friend WithEvents totalCostBox As TextBox
    Friend WithEvents taxBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalPaymentBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents darDays As TextBox
    Friend WithEvents darWeek As TextBox
    Friend WithEvents darMon As TextBox
    Friend WithEvents pricePerDayTextBox As TextBox
    Friend WithEvents pricePerWeekTextBox As TextBox
    Friend WithEvents pricePerMonTextBox As TextBox
    Friend WithEvents monthlyTotal As TextBox
    Friend WithEvents weekTotal As TextBox
    Friend WithEvents dailyTotal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents planToDateTextBox As TextBox
    Friend WithEvents lateDarDays As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents latePricePerDayTextBox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents lateTotal As TextBox
    Friend WithEvents planFromDateTextBox As TextBox
    Friend WithEvents Label25 As Label
End Class
