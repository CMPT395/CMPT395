<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.SearchHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.AddHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.EditHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.DeleteHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.ClearHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.TableHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(73, 61)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(90, 23)
        Me.BackButton.TabIndex = 20
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddHelpProvider.SetHelpString(Me.AddButton, "Click to add entry from table to car")
        Me.AddButton.Location = New System.Drawing.Point(664, 139)
        Me.AddButton.Name = "AddButton"
        Me.AddHelpProvider.SetShowHelp(Me.AddButton, True)
        Me.AddButton.Size = New System.Drawing.Size(75, 21)
        Me.AddButton.TabIndex = 38
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 12)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "BID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "CTID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(425, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Make"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(556, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Model"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(254, 9)
        Me.Label12.MaximumSize = New System.Drawing.Size(500, 462)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 57)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Edit Car"
        '
        'TextBox2
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox2, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox2.Location = New System.Drawing.Point(185, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox2, True)
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 79
        '
        'TextBox3
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox3, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox3.Location = New System.Drawing.Point(305, 90)
        Me.TextBox3.Name = "TextBox3"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox3, True)
        Me.TextBox3.Size = New System.Drawing.Size(100, 21)
        Me.TextBox3.TabIndex = 99
        '
        'TextBox4
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox4, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox4.Location = New System.Drawing.Point(427, 90)
        Me.TextBox4.Name = "TextBox4"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox4, True)
        Me.TextBox4.Size = New System.Drawing.Size(100, 21)
        Me.TextBox4.TabIndex = 100
        '
        'TextBox5
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox5, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox5.Location = New System.Drawing.Point(558, 90)
        Me.TextBox5.Name = "TextBox5"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox5, True)
        Me.TextBox5.Size = New System.Drawing.Size(100, 21)
        Me.TextBox5.TabIndex = 101
        '
        'TextBox6
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox6, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox6.Location = New System.Drawing.Point(73, 139)
        Me.TextBox6.Name = "TextBox6"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox6, True)
        Me.TextBox6.Size = New System.Drawing.Size(100, 21)
        Me.TextBox6.TabIndex = 102
        '
        'TextBox7
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox7, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox7.Location = New System.Drawing.Point(185, 139)
        Me.TextBox7.Name = "TextBox7"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox7, True)
        Me.TextBox7.Size = New System.Drawing.Size(100, 21)
        Me.TextBox7.TabIndex = 103
        '
        'TextBox8
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox8, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox8.Location = New System.Drawing.Point(305, 139)
        Me.TextBox8.Name = "TextBox8"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox8, True)
        Me.TextBox8.Size = New System.Drawing.Size(100, 21)
        Me.TextBox8.TabIndex = 104
        '
        'TextBox9
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox9, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox9.Location = New System.Drawing.Point(427, 139)
        Me.TextBox9.Name = "TextBox9"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox9, True)
        Me.TextBox9.Size = New System.Drawing.Size(100, 21)
        Me.TextBox9.TabIndex = 105
        '
        'TextBox10
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox10, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox10.Location = New System.Drawing.Point(558, 139)
        Me.TextBox10.Name = "TextBox10"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox10, True)
        Me.TextBox10.Size = New System.Drawing.Size(100, 21)
        Me.TextBox10.TabIndex = 106
        '
        'TextBox11
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox11, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox11.Location = New System.Drawing.Point(73, 189)
        Me.TextBox11.Name = "TextBox11"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox11, True)
        Me.TextBox11.Size = New System.Drawing.Size(100, 21)
        Me.TextBox11.TabIndex = 107
        '
        'TextBox12
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox12, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox12.Location = New System.Drawing.Point(185, 189)
        Me.TextBox12.Name = "TextBox12"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox12, True)
        Me.TextBox12.Size = New System.Drawing.Size(100, 21)
        Me.TextBox12.TabIndex = 108
        '
        'TextBox13
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox13, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox13.Location = New System.Drawing.Point(305, 189)
        Me.TextBox13.Name = "TextBox13"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox13, True)
        Me.TextBox13.Size = New System.Drawing.Size(100, 21)
        Me.TextBox13.TabIndex = 109
        '
        'TextBox14
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox14, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox14.Location = New System.Drawing.Point(427, 189)
        Me.TextBox14.Name = "TextBox14"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox14, True)
        Me.TextBox14.Size = New System.Drawing.Size(100, 21)
        Me.TextBox14.TabIndex = 110
        '
        'TextBox15
        '
        Me.TextHelpProvider.SetHelpString(Me.TextBox15, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.TextBox15.Location = New System.Drawing.Point(558, 189)
        Me.TextBox15.Name = "TextBox15"
        Me.TextHelpProvider.SetShowHelp(Me.TextBox15, True)
        Me.TextBox15.Size = New System.Drawing.Size(100, 21)
        Me.TextBox15.TabIndex = 111
        '
        'DeleteButton
        '
        Me.AddHelpProvider.SetHelpString(Me.DeleteButton, "Click to add entry from table to car")
        Me.DeleteButton.Location = New System.Drawing.Point(664, 299)
        Me.DeleteButton.Name = "DeleteButton"
        Me.AddHelpProvider.SetShowHelp(Me.DeleteButton, True)
        Me.DeleteButton.Size = New System.Drawing.Size(75, 21)
        Me.DeleteButton.TabIndex = 77
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.AddHelpProvider.SetHelpString(Me.UpdateButton, "Click to add entry from table to car")
        Me.UpdateButton.Location = New System.Drawing.Point(664, 354)
        Me.UpdateButton.Name = "UpdateButton"
        Me.AddHelpProvider.SetShowHelp(Me.UpdateButton, True)
        Me.UpdateButton.Size = New System.Drawing.Size(75, 21)
        Me.UpdateButton.TabIndex = 112
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.AddHelpProvider.SetHelpString(Me.SearchButton, "Click to add entry from table to car")
        Me.SearchButton.Location = New System.Drawing.Point(664, 189)
        Me.SearchButton.Name = "SearchButton"
        Me.AddHelpProvider.SetShowHelp(Me.SearchButton, True)
        Me.SearchButton.Size = New System.Drawing.Size(75, 21)
        Me.SearchButton.TabIndex = 113
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(73, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(585, 222)
        Me.DataGridView1.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(556, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(425, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 12)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Additional_cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(556, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Transmission"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(425, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Engine"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(303, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Drive_type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(303, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 12)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Plate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(183, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 12)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Mileage"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(71, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 12)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Year"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(183, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 12)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Fuel"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(71, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 12)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Color"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(303, 227)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 12)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "Car Information List"
        '
        'EditCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 486)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "EditCar"
        Me.Text = "EditCar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TableHelpProvider As HelpProvider
    Friend WithEvents TextHelpProvider As HelpProvider
    Friend WithEvents SearchHelpProvider As HelpProvider
    Friend WithEvents AddHelpProvider As HelpProvider
    Friend WithEvents EditHelpProvider As HelpProvider
    Friend WithEvents DeleteHelpProvider As HelpProvider
    Friend WithEvents ClearHelpProvider As HelpProvider
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DeleteButton As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label17 As Label
End Class
