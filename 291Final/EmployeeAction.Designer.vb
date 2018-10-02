<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeAction
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.car = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.branch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 186)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(380, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Make Reservation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Action"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 256)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(380, 38)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Edit Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(268, 558)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(380, 38)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Report"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(39, 32)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 38)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Sign Out"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'car
        '
        Me.car.Location = New System.Drawing.Point(268, 332)
        Me.car.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(380, 38)
        Me.car.TabIndex = 5
        Me.car.Text = "Edit Car"
        Me.car.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(268, 483)
        Me.Button6.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(380, 38)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Check Out"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(678, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'branch
        '
        Me.branch.Location = New System.Drawing.Point(268, 411)
        Me.branch.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.branch.Name = "branch"
        Me.branch.Size = New System.Drawing.Size(380, 38)
        Me.branch.TabIndex = 8
        Me.branch.Text = "Branch info"
        Me.branch.UseVisualStyleBackColor = True
        '
        'EmployeeAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 654)
        Me.Controls.Add(Me.branch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "EmployeeAction"
        Me.Text = "EmployeeAction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents car As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents branch As Button
End Class
