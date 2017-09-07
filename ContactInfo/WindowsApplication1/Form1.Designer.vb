<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnContact = New System.Windows.Forms.Button()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.btnPhone = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnContact
        '
        Me.btnContact.Location = New System.Drawing.Point(13, 13)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(200, 23)
        Me.btnContact.TabIndex = 0
        Me.btnContact.Text = "Contact Person"
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'btnDepartment
        '
        Me.btnDepartment.Location = New System.Drawing.Point(13, 43)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(200, 23)
        Me.btnDepartment.TabIndex = 1
        Me.btnDepartment.Text = "Department"
        Me.btnDepartment.UseVisualStyleBackColor = True
        '
        'btnPhone
        '
        Me.btnPhone.Location = New System.Drawing.Point(13, 73)
        Me.btnPhone.Name = "btnPhone"
        Me.btnPhone.Size = New System.Drawing.Size(200, 23)
        Me.btnPhone.TabIndex = 2
        Me.btnPhone.Text = "Phone"
        Me.btnPhone.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(221, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(352, 31)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Press Button for Information"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(221, 44)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 31)
        Me.lblInfo.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 118)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnPhone)
        Me.Controls.Add(Me.btnDepartment)
        Me.Controls.Add(Me.btnContact)
        Me.Name = "Form1"
        Me.Text = "Contact Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContact As Button
    Friend WithEvents btnDepartment As Button
    Friend WithEvents btnPhone As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInfo As Label
End Class
