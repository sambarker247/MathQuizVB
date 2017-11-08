<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathsProblemForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MathsProblemForm))
        Me.OpNameLabel = New System.Windows.Forms.Label()
        Me.OperandLabel1 = New System.Windows.Forms.Label()
        Me.OpLabel = New System.Windows.Forms.Label()
        Me.OperandLabel2 = New System.Windows.Forms.Label()
        Me.EqualsLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerButton = New System.Windows.Forms.Button()
        Me.NewProblemButton = New System.Windows.Forms.Button()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.OpDropdown = New System.Windows.Forms.ComboBox()
        Me.CurrentMsgLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpNameLabel
        '
        Me.OpNameLabel.AccessibleName = ""
        Me.OpNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpNameLabel.Location = New System.Drawing.Point(0, 0)
        Me.OpNameLabel.Name = "OpNameLabel"
        Me.OpNameLabel.Size = New System.Drawing.Size(384, 181)
        Me.OpNameLabel.TabIndex = 0
        Me.OpNameLabel.Text = "ADDITION"
        Me.OpNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OperandLabel1
        '
        Me.OperandLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OperandLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperandLabel1.Location = New System.Drawing.Point(12, 70)
        Me.OperandLabel1.Name = "OperandLabel1"
        Me.OperandLabel1.Size = New System.Drawing.Size(100, 29)
        Me.OperandLabel1.TabIndex = 1
        Me.OperandLabel1.Text = "Oprnd1"
        '
        'OpLabel
        '
        Me.OpLabel.AutoSize = True
        Me.OpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpLabel.Location = New System.Drawing.Point(104, 70)
        Me.OpLabel.Name = "OpLabel"
        Me.OpLabel.Size = New System.Drawing.Size(27, 29)
        Me.OpLabel.TabIndex = 2
        Me.OpLabel.Text = "+"
        '
        'OperandLabel2
        '
        Me.OperandLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OperandLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperandLabel2.Location = New System.Drawing.Point(137, 70)
        Me.OperandLabel2.Name = "OperandLabel2"
        Me.OperandLabel2.Size = New System.Drawing.Size(100, 29)
        Me.OperandLabel2.TabIndex = 3
        Me.OperandLabel2.Text = "Oprnd2"
        '
        'EqualsLabel
        '
        Me.EqualsLabel.AutoSize = True
        Me.EqualsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EqualsLabel.Location = New System.Drawing.Point(229, 70)
        Me.EqualsLabel.Name = "EqualsLabel"
        Me.EqualsLabel.Size = New System.Drawing.Size(27, 29)
        Me.EqualsLabel.TabIndex = 4
        Me.EqualsLabel.Text = "="
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.AcceptsReturn = True
        Me.AnswerTextBox.BackColor = System.Drawing.SystemColors.Menu
        Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AnswerTextBox.Location = New System.Drawing.Point(262, 69)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(100, 30)
        Me.AnswerTextBox.TabIndex = 5
        '
        'AnswerButton
        '
        Me.AnswerButton.Location = New System.Drawing.Point(262, 126)
        Me.AnswerButton.Name = "AnswerButton"
        Me.AnswerButton.Size = New System.Drawing.Size(100, 23)
        Me.AnswerButton.TabIndex = 6
        Me.AnswerButton.Text = "Answer"
        Me.AnswerButton.UseVisualStyleBackColor = True
        '
        'NewProblemButton
        '
        Me.NewProblemButton.Location = New System.Drawing.Point(12, 126)
        Me.NewProblemButton.Name = "NewProblemButton"
        Me.NewProblemButton.Size = New System.Drawing.Size(100, 23)
        Me.NewProblemButton.TabIndex = 7
        Me.NewProblemButton.Text = "New Problem"
        Me.NewProblemButton.UseVisualStyleBackColor = True
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(323, 110)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(37, 13)
        Me.AnswerLabel.TabIndex = 8
        Me.AnswerLabel.Text = "          "
        Me.AnswerLabel.Visible = False
        '
        'OpDropdown
        '
        Me.OpDropdown.BackColor = System.Drawing.SystemColors.Menu
        Me.OpDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OpDropdown.FormattingEnabled = True
        Me.OpDropdown.Items.AddRange(New Object() {"Add", "Subtract", "Multiply", "Divide"})
        Me.OpDropdown.Location = New System.Drawing.Point(137, 126)
        Me.OpDropdown.Name = "OpDropdown"
        Me.OpDropdown.Size = New System.Drawing.Size(100, 21)
        Me.OpDropdown.TabIndex = 9
        '
        'CurrentMsgLabel
        '
        Me.CurrentMsgLabel.AutoSize = True
        Me.CurrentMsgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentMsgLabel.Location = New System.Drawing.Point(8, 152)
        Me.CurrentMsgLabel.Name = "CurrentMsgLabel"
        Me.CurrentMsgLabel.Size = New System.Drawing.Size(0, 24)
        Me.CurrentMsgLabel.TabIndex = 10
        '
        'MathsProblemForm
        '
        Me.AcceptButton = Me.AnswerButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 181)
        Me.Controls.Add(Me.CurrentMsgLabel)
        Me.Controls.Add(Me.OpDropdown)
        Me.Controls.Add(Me.AnswerLabel)
        Me.Controls.Add(Me.NewProblemButton)
        Me.Controls.Add(Me.AnswerButton)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.EqualsLabel)
        Me.Controls.Add(Me.OperandLabel2)
        Me.Controls.Add(Me.OpLabel)
        Me.Controls.Add(Me.OperandLabel1)
        Me.Controls.Add(Me.OpNameLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 220)
        Me.MinimumSize = New System.Drawing.Size(400, 220)
        Me.Name = "MathsProblemForm"
        Me.Text = "Maths Problem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpNameLabel As Label
    Friend WithEvents OperandLabel1 As Label
    Friend WithEvents OpLabel As Label
    Friend WithEvents OperandLabel2 As Label
    Friend WithEvents EqualsLabel As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents AnswerButton As Button
    Friend WithEvents NewProblemButton As Button
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents OpDropdown As ComboBox
    Friend WithEvents CurrentMsgLabel As Label
End Class
