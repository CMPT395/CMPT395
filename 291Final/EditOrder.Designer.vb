<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BID_FText = New System.Windows.Forms.TextBox()
        Me.CIDText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CUSIDText = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.BID_TTEXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.TableHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.SearchHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.AddHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.EditHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.DeleteHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.ClearHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.DateHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.PriveHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pick-Up Branch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Car ID"
        '
        'BID_FText
        '
        Me.TextHelpProvider.SetHelpString(Me.BID_FText, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.BID_FText.Location = New System.Drawing.Point(503, 93)
        Me.BID_FText.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BID_FText.Name = "BID_FText"
        Me.TextHelpProvider.SetShowHelp(Me.BID_FText, True)
        Me.BID_FText.Size = New System.Drawing.Size(115, 28)
        Me.BID_FText.TabIndex = 26
        '
        'CIDText
        '
        Me.TextHelpProvider.SetHelpString(Me.CIDText, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.CIDText.Location = New System.Drawing.Point(185, 93)
        Me.CIDText.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CIDText.Name = "CIDText"
        Me.TextHelpProvider.SetShowHelp(Me.CIDText, True)
        Me.CIDText.Size = New System.Drawing.Size(115, 28)
        Me.CIDText.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 18)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Customer ID"
        '
        'CUSIDText
        '
        Me.TextHelpProvider.SetHelpString(Me.CUSIDText, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.CUSIDText.Location = New System.Drawing.Point(344, 93)
        Me.CUSIDText.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CUSIDText.Name = "CUSIDText"
        Me.TextHelpProvider.SetShowHelp(Me.CUSIDText, True)
        Me.CUSIDText.Size = New System.Drawing.Size(115, 28)
        Me.CUSIDText.TabIndex = 39
        '
        'UpdateButton
        '
        Me.EditHelpProvider.SetHelpString(Me.UpdateButton, "Click to save edits to changed rental from table")
        Me.UpdateButton.Location = New System.Drawing.Point(503, 146)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.UpdateButton.Name = "UpdateButton"
        Me.EditHelpProvider.SetShowHelp(Me.UpdateButton, True)
        Me.UpdateButton.Size = New System.Drawing.Size(115, 32)
        Me.UpdateButton.TabIndex = 60
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteHelpProvider.SetHelpString(Me.DeleteButton, "Click to delete branch")
        Me.DeleteButton.Location = New System.Drawing.Point(343, 146)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteHelpProvider.SetShowHelp(Me.DeleteButton, True)
        Me.DeleteButton.Size = New System.Drawing.Size(116, 32)
        Me.DeleteButton.TabIndex = 57
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchHelpProvider.SetHelpString(Me.SearchButton, "Click to search for desired rental based upon what is typed in the text boxes")
        Me.SearchButton.Location = New System.Drawing.Point(184, 146)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchHelpProvider.SetShowHelp(Me.SearchButton, True)
        Me.SearchButton.Size = New System.Drawing.Size(115, 32)
        Me.SearchButton.TabIndex = 56
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(56, 12)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(111, 39)
        Me.BackButton.TabIndex = 47
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'BID_TTEXT
        '
        Me.TextHelpProvider.SetHelpString(Me.BID_TTEXT, "Type in what you want to search for. If left blank, it won't search based upon th" &
        "at attribute")
        Me.BID_TTEXT.Location = New System.Drawing.Point(662, 93)
        Me.BID_TTEXT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BID_TTEXT.Name = "BID_TTEXT"
        Me.TextHelpProvider.SetShowHelp(Me.BID_TTEXT, True)
        Me.BID_TTEXT.Size = New System.Drawing.Size(115, 28)
        Me.BID_TTEXT.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(660, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 18)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Drop-Off Branch"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 220)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(1134, 217)
        Me.DataGridView1.TabIndex = 74
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.title.Location = New System.Drawing.Point(604, 18)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(130, 24)
        Me.title.TabIndex = 75
        Me.title.Text = "Edit Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label2.Location = New System.Drawing.Point(976, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Branch 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label5.Location = New System.Drawing.Point(976, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Branch 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label6.Location = New System.Drawing.Point(976, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Branch 4:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label9.Location = New System.Drawing.Point(976, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Branch 3:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label10.Location = New System.Drawing.Point(976, 151)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Branch 5:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label11.Location = New System.Drawing.Point(1070, 151)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Jasper"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label12.Location = New System.Drawing.Point(1070, 133)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 18)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Banff"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label13.Location = New System.Drawing.Point(1070, 114)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 18)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Calgary"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label14.Location = New System.Drawing.Point(1070, 96)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Red Deer"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label15.Location = New System.Drawing.Point(1070, 78)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 18)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Edmonton"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label16.Location = New System.Drawing.Point(1009, 48)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 18)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Branch Code:"
        '
        'EditOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1221, 467)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BID_TTEXT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CUSIDText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CIDText)
        Me.Controls.Add(Me.BID_FText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "EditOrder"
        Me.Text = "EditOrder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BID_FText As TextBox
    Friend WithEvents CIDText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CUSIDText As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents BID_TTEXT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextHelpProvider As HelpProvider
    Friend WithEvents TableHelpProvider As HelpProvider
    Friend WithEvents SearchHelpProvider As HelpProvider
    Friend WithEvents AddHelpProvider As HelpProvider
    Friend WithEvents EditHelpProvider As HelpProvider
    Friend WithEvents DeleteHelpProvider As HelpProvider
    Friend WithEvents ClearHelpProvider As HelpProvider
    Friend WithEvents DateHelpProvider As HelpProvider
    Friend WithEvents PriveHelpProvider As HelpProvider
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
