<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStates = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStateName = New System.Windows.Forms.Label()
        Me.lblStateAbbreviation = New System.Windows.Forms.Label()
        Me.lblStateCapital = New System.Windows.Forms.Label()
        Me.lblStateLongitude = New System.Windows.Forms.Label()
        Me.lblStateLatitude = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select:"
        '
        'cboStates
        '
        Me.cboStates.FormattingEnabled = True
        Me.cboStates.Location = New System.Drawing.Point(57, 6)
        Me.cboStates.Name = "cboStates"
        Me.cboStates.Size = New System.Drawing.Size(215, 21)
        Me.cboStates.TabIndex = 1
        Me.cboStates.Text = "States..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Abbreviation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capital:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Longitude:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Latitude:"
        '
        'lblStateName
        '
        Me.lblStateName.AutoSize = True
        Me.lblStateName.Location = New System.Drawing.Point(87, 45)
        Me.lblStateName.Name = "lblStateName"
        Me.lblStateName.Size = New System.Drawing.Size(10, 13)
        Me.lblStateName.TabIndex = 4
        Me.lblStateName.Text = " "
        '
        'lblStateAbbreviation
        '
        Me.lblStateAbbreviation.AutoSize = True
        Me.lblStateAbbreviation.Location = New System.Drawing.Point(87, 66)
        Me.lblStateAbbreviation.Name = "lblStateAbbreviation"
        Me.lblStateAbbreviation.Size = New System.Drawing.Size(10, 13)
        Me.lblStateAbbreviation.TabIndex = 5
        Me.lblStateAbbreviation.Text = " "
        '
        'lblStateCapital
        '
        Me.lblStateCapital.AutoSize = True
        Me.lblStateCapital.Location = New System.Drawing.Point(87, 87)
        Me.lblStateCapital.Name = "lblStateCapital"
        Me.lblStateCapital.Size = New System.Drawing.Size(10, 13)
        Me.lblStateCapital.TabIndex = 6
        Me.lblStateCapital.Text = " "
        '
        'lblStateLongitude
        '
        Me.lblStateLongitude.AutoSize = True
        Me.lblStateLongitude.Location = New System.Drawing.Point(87, 108)
        Me.lblStateLongitude.Name = "lblStateLongitude"
        Me.lblStateLongitude.Size = New System.Drawing.Size(10, 13)
        Me.lblStateLongitude.TabIndex = 7
        Me.lblStateLongitude.Text = " "
        '
        'lblStateLatitude
        '
        Me.lblStateLatitude.AutoSize = True
        Me.lblStateLatitude.Location = New System.Drawing.Point(87, 129)
        Me.lblStateLatitude.Name = "lblStateLatitude"
        Me.lblStateLatitude.Size = New System.Drawing.Size(10, 13)
        Me.lblStateLatitude.TabIndex = 8
        Me.lblStateLatitude.Text = " "
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 186)
        Me.Controls.Add(Me.lblStateLatitude)
        Me.Controls.Add(Me.lblStateLongitude)
        Me.Controls.Add(Me.lblStateCapital)
        Me.Controls.Add(Me.lblStateAbbreviation)
        Me.Controls.Add(Me.lblStateName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboStates)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMain"
        Me.Text = "State Capitols"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboStates As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStateName As Label
    Friend WithEvents lblStateAbbreviation As Label
    Friend WithEvents lblStateCapital As Label
    Friend WithEvents lblStateLongitude As Label
    Friend WithEvents lblStateLatitude As Label
End Class
