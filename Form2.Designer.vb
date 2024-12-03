<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar10 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar9 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 16
        Me.ListBox8.Location = New System.Drawing.Point(3, 12)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(120, 84)
        Me.ListBox8.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(3, 108)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 16
        Me.ListBox9.Location = New System.Drawing.Point(278, 12)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(120, 84)
        Me.ListBox9.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProgressBar10
        '
        Me.ProgressBar10.Location = New System.Drawing.Point(149, 41)
        Me.ProgressBar10.Name = "ProgressBar10"
        Me.ProgressBar10.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar10.TabIndex = 3
        '
        'ProgressBar9
        '
        Me.ProgressBar9.Location = New System.Drawing.Point(140, 12)
        Me.ProgressBar9.Name = "ProgressBar9"
        Me.ProgressBar9.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar9.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.ProgressBar9)
        Me.Controls.Add(Me.ProgressBar10)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListBox8)
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar10 As ProgressBar
    Friend WithEvents ProgressBar9 As ProgressBar
End Class
