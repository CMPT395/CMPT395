<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.ID = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CUSLLOGIN = New System.Windows.Forms.Button()
        Me.EMPLOGIN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(183, 100)
        Me.ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(26, 18)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(152, 171)
        Me.Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(80, 18)
        Me.Password.TabIndex = 1
        Me.Password.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(254, 98)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 28)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(254, 168)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 28)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'CUSLLOGIN
        '
        Me.CUSLLOGIN.Location = New System.Drawing.Point(202, 261)
        Me.CUSLLOGIN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CUSLLOGIN.Name = "CUSLLOGIN"
        Me.CUSLLOGIN.Size = New System.Drawing.Size(88, 33)
        Me.CUSLLOGIN.TabIndex = 4
        Me.CUSLLOGIN.Text = "Customer"
        Me.CUSLLOGIN.UseVisualStyleBackColor = True
        '
        'EMPLOGIN
        '
        Me.EMPLOGIN.Location = New System.Drawing.Point(312, 261)
        Me.EMPLOGIN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.EMPLOGIN.Name = "EMPLOGIN"
        Me.EMPLOGIN.Size = New System.Drawing.Size(88, 33)
        Me.EMPLOGIN.TabIndex = 5
        Me.EMPLOGIN.Text = "Employee"
        Me.EMPLOGIN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 269)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Login as"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 325)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Customer?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 320)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Sign up Here"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 408)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EMPLOGIN)
        Me.Controls.Add(Me.CUSLLOGIN)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.ID)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID As Label
    Friend WithEvents Password As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CUSLLOGIN As Button
    Friend WithEvents EMPLOGIN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
