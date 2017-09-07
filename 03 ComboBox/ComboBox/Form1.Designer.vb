<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cbxContact = New System.Windows.Forms.ComboBox()
        Me.tbxOutput = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxContact
        '
        Me.cbxContact.FormattingEnabled = True
        Me.cbxContact.Items.AddRange(New Object() {"Cell Phone", "Work Phone", "Address", "Website"})
        Me.cbxContact.Location = New System.Drawing.Point(12, 167)
        Me.cbxContact.Name = "cbxContact"
        Me.cbxContact.Size = New System.Drawing.Size(121, 21)
        Me.cbxContact.TabIndex = 0
        '
        'tbxOutput
        '
        Me.tbxOutput.Enabled = False
        Me.tbxOutput.Location = New System.Drawing.Point(140, 167)
        Me.tbxOutput.Name = "tbxOutput"
        Me.tbxOutput.Size = New System.Drawing.Size(226, 20)
        Me.tbxOutput.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(111, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(166, 39)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Jay Scafe"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(84, 57)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(225, 25)
        Me.lblCompany.TabIndex = 3
        Me.lblCompany.Text = "Terra-Dome Corperation"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 261)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tbxOutput)
        Me.Controls.Add(Me.cbxContact)
        Me.Name = "frmMain"
        Me.Text = "Contact Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxContact As System.Windows.Forms.ComboBox
    Friend WithEvents tbxOutput As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCompany As Label
End Class
