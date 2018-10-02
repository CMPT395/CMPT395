<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup
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
        Me.lfn = New System.Windows.Forms.Label()
        Me.FName = New System.Windows.Forms.TextBox()
        Me.License = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LName = New System.Windows.Forms.TextBox()
        Me.lln = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.Streetnum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Street = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Province = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Country = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Password2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lfn
        '
        Me.lfn.AutoSize = True
        Me.lfn.Location = New System.Drawing.Point(39, 23)
        Me.lfn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lfn.Name = "lfn"
        Me.lfn.Size = New System.Drawing.Size(65, 12)
        Me.lfn.TabIndex = 0
        Me.lfn.Text = "First Name"
        '
        'FName
        '
        Me.FName.Location = New System.Drawing.Point(117, 22)
        Me.FName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(56, 21)
        Me.FName.TabIndex = 1
        '
        'License
        '
        Me.License.Location = New System.Drawing.Point(117, 64)
        Me.License.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.License.Name = "License"
        Me.License.Size = New System.Drawing.Size(56, 21)
        Me.License.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "License Number"
        '
        'LName
        '
        Me.LName.Location = New System.Drawing.Point(286, 22)
        Me.LName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(56, 21)
        Me.LName.TabIndex = 5
        '
        'lln
        '
        Me.lln.AutoSize = True
        Me.lln.Location = New System.Drawing.Point(213, 23)
        Me.lln.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lln.Name = "lln"
        Me.lln.Size = New System.Drawing.Size(59, 12)
        Me.lln.TabIndex = 4
        Me.lln.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Birthday"
        '
        'DOB
        '
        Me.DOB.Location = New System.Drawing.Point(252, 64)
        Me.DOB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(111, 21)
        Me.DOB.TabIndex = 7
        Me.DOB.Value = New Date(2018, 6, 7, 0, 51, 24, 0)
        '
        'Streetnum
        '
        Me.Streetnum.Location = New System.Drawing.Point(117, 106)
        Me.Streetnum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Streetnum.Name = "Streetnum"
        Me.Streetnum.Size = New System.Drawing.Size(56, 21)
        Me.Streetnum.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Street Number"
        '
        'Street
        '
        Me.Street.Location = New System.Drawing.Point(286, 106)
        Me.Street.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Street.Multiline = True
        Me.Street.Name = "Street"
        Me.Street.Size = New System.Drawing.Size(56, 19)
        Me.Street.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Street"
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(117, 151)
        Me.City.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(56, 21)
        Me.City.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 151)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "City"
        '
        'Province
        '
        Me.Province.Location = New System.Drawing.Point(286, 151)
        Me.Province.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Province.Name = "Province"
        Me.Province.Size = New System.Drawing.Size(56, 21)
        Me.Province.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 151)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Province"
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(286, 198)
        Me.Phone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(56, 21)
        Me.Phone.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Phone"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(117, 251)
        Me.Password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(56, 21)
        Me.Password.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 251)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Password"
        '
        'Country
        '
        Me.Country.Location = New System.Drawing.Point(117, 197)
        Me.Country.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(56, 21)
        Me.Country.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 198)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 12)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Country"
        '
        'Password2
        '
        Me.Password2.Location = New System.Drawing.Point(286, 249)
        Me.Password2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Password2.Name = "Password2"
        Me.Password2.Size = New System.Drawing.Size(56, 21)
        Me.Password2.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 253)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 12)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Re-enter Password"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(215, 304)
        Me.Submit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(63, 18)
        Me.Submit.TabIndex = 24
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 304)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 18)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 358)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Password2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Province)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Street)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Streetnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.lln)
        Me.Controls.Add(Me.License)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FName)
        Me.Controls.Add(Me.lfn)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "signup"
        Me.Text = "signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lfn As Label
    Friend WithEvents FName As TextBox
    Friend WithEvents License As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LName As TextBox
    Friend WithEvents lln As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Streetnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Street As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents City As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Province As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Phone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Country As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Password2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Submit As Button
    Friend WithEvents Button1 As Button
End Class
