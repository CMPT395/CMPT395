<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Me.PopularCarsButton = New System.Windows.Forms.Button()
        Me.PopularBranchButton = New System.Windows.Forms.Button()
        Me.PopularCarsHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.BranchHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.PopularBranchHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.BiggestBranchHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.CustomerRatingBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(80, 85)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(6)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(150, 44)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PopularCarsButton
        '
        Me.PopularCarsHelpProvider.SetHelpString(Me.PopularCarsButton, "Click To view the most rented cars")
        Me.PopularCarsButton.Location = New System.Drawing.Point(116, 169)
        Me.PopularCarsButton.Margin = New System.Windows.Forms.Padding(6)
        Me.PopularCarsButton.Name = "PopularCarsButton"
        Me.PopularCarsHelpProvider.SetShowHelp(Me.PopularCarsButton, True)
        Me.PopularCarsButton.Size = New System.Drawing.Size(150, 92)
        Me.PopularCarsButton.TabIndex = 1
        Me.PopularCarsButton.Text = "Most Popular Cars"
        Me.PopularCarsButton.UseVisualStyleBackColor = True
        '
        'PopularBranchButton
        '
        Me.PopularBranchHelpProvider.SetHelpString(Me.PopularBranchButton, "Click to view which branches are the most popular to pick up from")
        Me.PopularBranchButton.Location = New System.Drawing.Point(312, 169)
        Me.PopularBranchButton.Margin = New System.Windows.Forms.Padding(6)
        Me.PopularBranchButton.Name = "PopularBranchButton"
        Me.PopularBranchHelpProvider.SetShowHelp(Me.PopularBranchButton, True)
        Me.PopularBranchButton.Size = New System.Drawing.Size(176, 92)
        Me.PopularBranchButton.TabIndex = 3
        Me.PopularBranchButton.Text = "Most Popular Branch"
        Me.PopularBranchButton.UseVisualStyleBackColor = True
        '
        'CustomerRatingBtn
        '
        Me.CustomerRatingBtn.Location = New System.Drawing.Point(529, 169)
        Me.CustomerRatingBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.CustomerRatingBtn.Name = "CustomerRatingBtn"
        Me.CustomerRatingBtn.Size = New System.Drawing.Size(178, 92)
        Me.CustomerRatingBtn.TabIndex = 60
        Me.CustomerRatingBtn.Text = "Customer Ratings"
        Me.CustomerRatingBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(116, 383)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(1458, 602)
        Me.DataGridView1.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 25)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Select one report type above, and data will show below."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 25)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Most Popular Cars Report - popular to unpopular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(524, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 25)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Most Popular Branch Report - popular to unpopular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(731, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(375, 25)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Customer Ratings Report - high to low"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(810, 230)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 31)
        Me.DateTimePicker1.TabIndex = 82
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(1115, 230)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 31)
        Me.DateTimePicker2.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(810, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Date from"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1110, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 25)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "To"
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1720, 1054)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CustomerRatingBtn)
        Me.Controls.Add(Me.PopularBranchButton)
        Me.Controls.Add(Me.PopularCarsButton)
        Me.Controls.Add(Me.BackButton)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents PopularCarsButton As Button
    Friend WithEvents PopularBranchButton As Button
    Friend WithEvents PopularCarsHelpProvider As HelpProvider
    Friend WithEvents BranchHelpProvider As HelpProvider
    Friend WithEvents PopularBranchHelpProvider As HelpProvider
    Friend WithEvents BiggestBranchHelpProvider As HelpProvider
    Friend WithEvents CustomerRatingBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
