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
        Me.addProcess = New System.Windows.Forms.Button()
        Me.processSize = New System.Windows.Forms.TextBox()
        Me.selectedProcess = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.removeProcess = New System.Windows.Forms.Button()
        Me.selectedAlgorithm = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.compactMemory = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.maxSize = New System.Windows.Forms.TextBox()
        Me.changeSize = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'addProcess
        '
        Me.addProcess.Location = New System.Drawing.Point(76, 256)
        Me.addProcess.Name = "addProcess"
        Me.addProcess.Size = New System.Drawing.Size(139, 23)
        Me.addProcess.TabIndex = 1
        Me.addProcess.Text = "Add Selected Process"
        Me.addProcess.UseVisualStyleBackColor = True
        '
        'processSize
        '
        Me.processSize.Location = New System.Drawing.Point(12, 230)
        Me.processSize.Name = "processSize"
        Me.processSize.Size = New System.Drawing.Size(281, 20)
        Me.processSize.TabIndex = 2
        '
        'selectedProcess
        '
        Me.selectedProcess.FormattingEnabled = True
        Me.selectedProcess.Items.AddRange(New Object() {"P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "P10"})
        Me.selectedProcess.Location = New System.Drawing.Point(36, 135)
        Me.selectedProcess.Name = "selectedProcess"
        Me.selectedProcess.Size = New System.Drawing.Size(100, 21)
        Me.selectedProcess.TabIndex = 3
        Me.selectedProcess.Text = "P1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Process:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter size (in KB) of process:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(340, 303)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(302, 134)
        Me.ListBox1.TabIndex = 6
        '
        'removeProcess
        '
        Me.removeProcess.Location = New System.Drawing.Point(65, 285)
        Me.removeProcess.Name = "removeProcess"
        Me.removeProcess.Size = New System.Drawing.Size(164, 23)
        Me.removeProcess.TabIndex = 7
        Me.removeProcess.Text = "Remove Selected Process"
        Me.removeProcess.UseVisualStyleBackColor = True
        '
        'selectedAlgorithm
        '
        Me.selectedAlgorithm.FormattingEnabled = True
        Me.selectedAlgorithm.Items.AddRange(New Object() {"First Fit"})
        Me.selectedAlgorithm.Location = New System.Drawing.Point(174, 135)
        Me.selectedAlgorithm.Name = "selectedAlgorithm"
        Me.selectedAlgorithm.Size = New System.Drawing.Size(100, 21)
        Me.selectedAlgorithm.TabIndex = 8
        Me.selectedAlgorithm.Text = "First Fit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Select Algorithm:"
        '
        'compactMemory
        '
        Me.compactMemory.Location = New System.Drawing.Point(433, 440)
        Me.compactMemory.Name = "compactMemory"
        Me.compactMemory.Size = New System.Drawing.Size(100, 26)
        Me.compactMemory.TabIndex = 10
        Me.compactMemory.Text = "Compact Memory"
        Me.compactMemory.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Enter max. size of memory (default 4096 KB):"
        '
        'maxSize
        '
        Me.maxSize.Location = New System.Drawing.Point(12, 25)
        Me.maxSize.Name = "maxSize"
        Me.maxSize.Size = New System.Drawing.Size(281, 20)
        Me.maxSize.TabIndex = 12
        '
        'changeSize
        '
        Me.changeSize.Location = New System.Drawing.Point(46, 51)
        Me.changeSize.Name = "changeSize"
        Me.changeSize.Size = New System.Drawing.Size(219, 23)
        Me.changeSize.TabIndex = 13
        Me.changeSize.Text = "Change max. size of memory"
        Me.changeSize.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(567, 501)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 14
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(654, 545)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.changeSize)
        Me.Controls.Add(Me.maxSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.compactMemory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.selectedAlgorithm)
        Me.Controls.Add(Me.removeProcess)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectedProcess)
        Me.Controls.Add(Me.processSize)
        Me.Controls.Add(Me.addProcess)
        Me.Name = "Form1"
        Me.Text = "Memory Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addProcess As Button
    Friend WithEvents processSize As TextBox
    Friend WithEvents selectedProcess As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents removeProcess As Button
    Friend WithEvents selectedAlgorithm As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents compactMemory As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents maxSize As TextBox
    Friend WithEvents changeSize As Button
    Friend WithEvents exitButton As Button
End Class
