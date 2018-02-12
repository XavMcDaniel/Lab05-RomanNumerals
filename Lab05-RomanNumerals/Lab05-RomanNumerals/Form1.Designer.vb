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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a decimal integer in the range 1 - 10:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equivalent Roman Numeral"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(163, 9)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(144, 20)
        Me.txtInput.TabIndex = 2
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(48, 97)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(87, 36)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 97)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 36)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(163, 49)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(144, 20)
        Me.lblOutput.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 145)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput As Label
End Class
