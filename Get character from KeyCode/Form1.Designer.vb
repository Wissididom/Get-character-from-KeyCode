Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.NudKeyCode = New System.Windows.Forms.NumericUpDown()
        CType(Me.NudKeyCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_OK
        '
        Me.Btn_Ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ok.Location = New System.Drawing.Point(256, 9)
        Me.Btn_Ok.Name = "btn_OK"
        Me.Btn_Ok.Size = New System.Drawing.Size(209, 116)
        Me.Btn_Ok.TabIndex = 0
        Me.Btn_Ok.Text = "Get"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'nud_KeyCode
        '
        Me.NudKeyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudKeyCode.Location = New System.Drawing.Point(12, 9)
        Me.NudKeyCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NudKeyCode.Name = "nud_KeyCode"
        Me.NudKeyCode.Size = New System.Drawing.Size(238, 116)
        Me.NudKeyCode.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 131)
        Me.Controls.Add(Me.NudKeyCode)
        Me.Controls.Add(Me.Btn_Ok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get character from KeyCode"
        CType(Me.NudKeyCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Ok As Button
    Friend WithEvents NudKeyCode As NumericUpDown
End Class
