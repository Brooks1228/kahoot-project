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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.openQuestionJson = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 20000
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Red
        Me.btn1.Location = New System.Drawing.Point(12, 285)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(394, 95)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "answer 1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn4.Location = New System.Drawing.Point(422, 386)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(394, 95)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "answer 4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Blue
        Me.btn2.Location = New System.Drawing.Point(422, 285)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(394, 95)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "answer 2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Yellow
        Me.btn3.Location = New System.Drawing.Point(12, 386)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(394, 95)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "answer 3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Purple
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(36, 124)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(60, 57)
        Me.lblTimer.TabIndex = 4
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuestion
        '
        Me.lblQuestion.Location = New System.Drawing.Point(-3, 17)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(836, 70)
        Me.lblQuestion.TabIndex = 5
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label1.Location = New System.Drawing.Point(726, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore.Location = New System.Drawing.Point(726, 154)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(2, 29)
        Me.lblScore.TabIndex = 7
        '
        'openQuestionJson
        '
        Me.openQuestionJson.DefaultExt = "json"
        Me.openQuestionJson.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.kahoot_project_thing.My.Resources.Resources.R
        Me.ClientSize = New System.Drawing.Size(832, 498)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HollyHoot!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents openQuestionJson As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
End Class
