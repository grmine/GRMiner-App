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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ΑρχείοToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΕνάρξηToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΕξοδοςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΒοηθειαToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΣχετικαToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HLC Διεύθυνση"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(12, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Εξόρυξη"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΑρχείοToolStripMenuItem, Me.ΒοηθειαToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ΑρχείοToolStripMenuItem
        '
        Me.ΑρχείοToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΕνάρξηToolStripMenuItem, Me.ΕξοδοςToolStripMenuItem})
        Me.ΑρχείοToolStripMenuItem.Name = "ΑρχείοToolStripMenuItem"
        Me.ΑρχείοToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ΑρχείοToolStripMenuItem.Text = "Αρχείο"
        '
        'ΕνάρξηToolStripMenuItem
        '
        Me.ΕνάρξηToolStripMenuItem.Name = "ΕνάρξηToolStripMenuItem"
        Me.ΕνάρξηToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ΕνάρξηToolStripMenuItem.Text = "Έναρξη"
        '
        'ΕξοδοςToolStripMenuItem
        '
        Me.ΕξοδοςToolStripMenuItem.Name = "ΕξοδοςToolStripMenuItem"
        Me.ΕξοδοςToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ΕξοδοςToolStripMenuItem.Text = "Έξοδος"
        '
        'ΒοηθειαToolStripMenuItem
        '
        Me.ΒοηθειαToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΣχετικαToolStripMenuItem})
        Me.ΒοηθειαToolStripMenuItem.Name = "ΒοηθειαToolStripMenuItem"
        Me.ΒοηθειαToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ΒοηθειαToolStripMenuItem.Text = "Βοήθεια"
        '
        'ΣχετικαToolStripMenuItem
        '
        Me.ΣχετικαToolStripMenuItem.Name = "ΣχετικαToolStripMenuItem"
        Me.ΣχετικαToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ΣχετικαToolStripMenuItem.Text = "Σχετικά"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 127)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GRMiner"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ΑρχείοToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΕνάρξηToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΕξοδοςToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΒοηθειαToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΣχετικαToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
