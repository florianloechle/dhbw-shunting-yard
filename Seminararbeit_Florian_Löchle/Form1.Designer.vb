<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.txtEquation = New System.Windows.Forms.TextBox()
        Me.lblResultDesc = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEquation
        '
        Me.lblEquation.AutoSize = True
        Me.lblEquation.Location = New System.Drawing.Point(30, 23)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(57, 18)
        Me.lblEquation.TabIndex = 0
        Me.lblEquation.Text = "Formel"
        '
        'txtEquation
        '
        Me.txtEquation.Location = New System.Drawing.Point(109, 20)
        Me.txtEquation.Name = "txtEquation"
        Me.txtEquation.Size = New System.Drawing.Size(321, 26)
        Me.txtEquation.TabIndex = 1
        '
        'lblResultDesc
        '
        Me.lblResultDesc.AutoSize = True
        Me.lblResultDesc.Location = New System.Drawing.Point(30, 62)
        Me.lblResultDesc.Name = "lblResultDesc"
        Me.lblResultDesc.Size = New System.Drawing.Size(71, 18)
        Me.lblResultDesc.TabIndex = 2
        Me.lblResultDesc.Text = "Ergebnis"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(107, 62)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 18)
        Me.lblResult.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(436, 20)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 26)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Rechnen"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(560, 284)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblResultDesc)
        Me.Controls.Add(Me.txtEquation)
        Me.Controls.Add(Me.lblEquation)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formel Interpreter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEquation As Label
    Friend WithEvents txtEquation As TextBox
    Friend WithEvents lblResultDesc As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
End Class
