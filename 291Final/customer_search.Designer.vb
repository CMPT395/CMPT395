<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer_search
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
        Me.CS_Search_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.carTypeBox = New System.Windows.Forms.ComboBox()
        Me.BranchBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TransmissionBox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CS_Search_button
        '
        Me.CS_Search_button.Location = New System.Drawing.Point(166, 545)
        Me.CS_Search_button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CS_Search_button.Name = "CS_Search_button"
        Me.CS_Search_button.Size = New System.Drawing.Size(172, 51)
        Me.CS_Search_button.TabIndex = 0
        Me.CS_Search_button.Text = "Search"
        Me.CS_Search_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 43)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Vehicle type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 43)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Branch"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(43, 47)
        Me.Button4.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 47)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Log out"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'carTypeBox
        '
        Me.carTypeBox.FormattingEnabled = True
        Me.carTypeBox.Items.AddRange(New Object() {"SUV", "Sedan", "Coupe", "Van", "Sport", "All"})
        Me.carTypeBox.Location = New System.Drawing.Point(129, 221)
        Me.carTypeBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.carTypeBox.Name = "carTypeBox"
        Me.carTypeBox.Size = New System.Drawing.Size(239, 33)
        Me.carTypeBox.TabIndex = 33
        '
        'BranchBox
        '
        Me.BranchBox.FormattingEnabled = True
        Me.BranchBox.Items.AddRange(New Object() {"Edmonton", "Red Deer", "Calgary", "Banff", "Jasper", "All"})
        Me.BranchBox.Location = New System.Drawing.Point(129, 343)
        Me.BranchBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BranchBox.Name = "BranchBox"
        Me.BranchBox.Size = New System.Drawing.Size(239, 33)
        Me.BranchBox.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 43)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Transmission"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TransmissionBox
        '
        Me.TransmissionBox.FormattingEnabled = True
        Me.TransmissionBox.Items.AddRange(New Object() {"AUTOMATIC", "MANUAL", "All"})
        Me.TransmissionBox.Location = New System.Drawing.Point(129, 479)
        Me.TransmissionBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransmissionBox.Name = "TransmissionBox"
        Me.TransmissionBox.Size = New System.Drawing.Size(239, 33)
        Me.TransmissionBox.TabIndex = 36
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(483, 43)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1242, 527)
        Me.DataGridView1.TabIndex = 37
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(135, 628)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(267, 25)
        Me.LinkLabel1.TabIndex = 43
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "My rent history and ratings"
        '
        'customer_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1799, 678)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TransmissionBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BranchBox)
        Me.Controls.Add(Me.carTypeBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CS_Search_button)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "customer_search"
        Me.Text = "customer search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CS_Search_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents carTypeBox As ComboBox
    Friend WithEvents BranchBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TransmissionBox As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
