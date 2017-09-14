<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnService = New System.Windows.Forms.RadioButton()
        Me.rbnDeposit = New System.Windows.Forms.RadioButton()
        Me.rbnCheck = New System.Windows.Forms.RadioButton()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.tblTransaction = New System.Data.DataSet()
        Me.lbxTransactions = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tbxTotal = New System.Windows.Forms.TextBox()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tblTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnService)
        Me.GroupBox1.Controls.Add(Me.rbnDeposit)
        Me.GroupBox1.Controls.Add(Me.rbnCheck)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit Type"
        '
        'rbnService
        '
        Me.rbnService.AutoSize = True
        Me.rbnService.Location = New System.Drawing.Point(135, 19)
        Me.rbnService.Name = "rbnService"
        Me.rbnService.Size = New System.Drawing.Size(98, 17)
        Me.rbnService.TabIndex = 2
        Me.rbnService.TabStop = True
        Me.rbnService.Text = "Service Charge"
        Me.rbnService.UseVisualStyleBackColor = True
        '
        'rbnDeposit
        '
        Me.rbnDeposit.AutoSize = True
        Me.rbnDeposit.Location = New System.Drawing.Point(68, 19)
        Me.rbnDeposit.Name = "rbnDeposit"
        Me.rbnDeposit.Size = New System.Drawing.Size(61, 17)
        Me.rbnDeposit.TabIndex = 1
        Me.rbnDeposit.TabStop = True
        Me.rbnDeposit.Text = "Deposit"
        Me.rbnDeposit.UseVisualStyleBackColor = True
        '
        'rbnCheck
        '
        Me.rbnCheck.AutoSize = True
        Me.rbnCheck.Location = New System.Drawing.Point(6, 19)
        Me.rbnCheck.Name = "rbnCheck"
        Me.rbnCheck.Size = New System.Drawing.Size(56, 17)
        Me.rbnCheck.TabIndex = 0
        Me.rbnCheck.TabStop = True
        Me.rbnCheck.Text = "Check"
        Me.rbnCheck.UseVisualStyleBackColor = True
        '
        'tbxInput
        '
        Me.tbxInput.Location = New System.Drawing.Point(116, 65)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(129, 20)
        Me.tbxInput.TabIndex = 1
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(12, 68)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(102, 13)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Transaction Amount"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(13, 107)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(94, 107)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(175, 107)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 151)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Overdrafting your account will result in a service charge of $10"
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Location = New System.Drawing.Point(291, 20)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(68, 13)
        Me.lblTransactions.TabIndex = 8
        Me.lblTransactions.Text = "Transactions"
        '
        'tblTransaction
        '
        Me.tblTransaction.DataSetName = "Transaction"
        '
        'lbxTransactions
        '
        Me.lbxTransactions.FormattingEnabled = True
        Me.lbxTransactions.Location = New System.Drawing.Point(294, 37)
        Me.lbxTransactions.Name = "lbxTransactions"
        Me.lbxTransactions.Size = New System.Drawing.Size(179, 329)
        Me.lbxTransactions.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(294, 373)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 20)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total"
        '
        'tbxTotal
        '
        Me.tbxTotal.Enabled = False
        Me.tbxTotal.Location = New System.Drawing.Point(345, 373)
        Me.tbxTotal.Name = "tbxTotal"
        Me.tbxTotal.Size = New System.Drawing.Size(128, 20)
        Me.tbxTotal.TabIndex = 11
        Me.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(94, 201)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(75, 23)
        Me.btnSummary.TabIndex = 12
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(492, 420)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.tbxTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lbxTransactions)
        Me.Controls.Add(Me.lblTransactions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMainMenu"
        Me.Text = "CheckingApp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tblTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbnService As RadioButton
    Friend WithEvents rbnDeposit As RadioButton
    Friend WithEvents rbnCheck As RadioButton
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents lblInput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTransactions As Label
    Friend WithEvents tblTransaction As DataSet
    Friend WithEvents lbxTransactions As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents tbxTotal As TextBox
    Friend WithEvents btnSummary As Button
End Class
