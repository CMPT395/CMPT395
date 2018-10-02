<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_history_ratings
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
        Me.userHistoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.generalRateBox = New System.Windows.Forms.ComboBox()
        Me.serviceRateBox = New System.Windows.Forms.ComboBox()
        Me.vehicleRateBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'userHistoryComboBox
        '
        Me.userHistoryComboBox.FormattingEnabled = True
        Me.userHistoryComboBox.Location = New System.Drawing.Point(70, 117)
        Me.userHistoryComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.userHistoryComboBox.Name = "userHistoryComboBox"
        Me.userHistoryComboBox.Size = New System.Drawing.Size(652, 26)
        Me.userHistoryComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "choose your rent history "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 243)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "General"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 243)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Vehicle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(714, 243)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Service"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(38, 28)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 35)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Go Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'submit_btn
        '
        Me.submit_btn.Location = New System.Drawing.Point(842, 504)
        Me.submit_btn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(113, 73)
        Me.submit_btn.TabIndex = 46
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'generalRateBox
        '
        Me.generalRateBox.FormattingEnabled = True
        Me.generalRateBox.Location = New System.Drawing.Point(134, 276)
        Me.generalRateBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.generalRateBox.Name = "generalRateBox"
        Me.generalRateBox.Size = New System.Drawing.Size(162, 26)
        Me.generalRateBox.TabIndex = 47
        '
        'serviceRateBox
        '
        Me.serviceRateBox.FormattingEnabled = True
        Me.serviceRateBox.Location = New System.Drawing.Point(718, 276)
        Me.serviceRateBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.serviceRateBox.Name = "serviceRateBox"
        Me.serviceRateBox.Size = New System.Drawing.Size(162, 26)
        Me.serviceRateBox.TabIndex = 48
        '
        'vehicleRateBox
        '
        Me.vehicleRateBox.FormattingEnabled = True
        Me.vehicleRateBox.Location = New System.Drawing.Point(415, 276)
        Me.vehicleRateBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.vehicleRateBox.Name = "vehicleRateBox"
        Me.vehicleRateBox.Size = New System.Drawing.Size(155, 26)
        Me.vehicleRateBox.TabIndex = 49
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.LightSlateGray
        Me.TextBox1.Location = New System.Drawing.Point(134, 324)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(575, 21)
        Me.TextBox1.TabIndex = 50
        Me.TextBox1.Text = "1-awful    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2-forgetable    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3-good    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4-excellent    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5-awesome    "
        '
        'customer_history_ratings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 606)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.vehicleRateBox)
        Me.Controls.Add(Me.serviceRateBox)
        Me.Controls.Add(Me.generalRateBox)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userHistoryComboBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "customer_history_ratings"
        Me.Text = "My rent history and ratings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userHistoryComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents submit_btn As Button
    Friend WithEvents generalRateBox As ComboBox
    Friend WithEvents serviceRateBox As ComboBox
    Friend WithEvents vehicleRateBox As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
