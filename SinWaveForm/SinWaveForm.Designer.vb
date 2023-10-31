<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SinWaveForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinFunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CosFunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TanFunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBDrawing = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawToolStripMenuItem, Me.SelectColorToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DrawToolStripMenuItem
        '
        Me.DrawToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinFunctionToolStripMenuItem, Me.CosFunctionToolStripMenuItem, Me.TanFunctionToolStripMenuItem})
        Me.DrawToolStripMenuItem.Name = "DrawToolStripMenuItem"
        Me.DrawToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DrawToolStripMenuItem.Text = "Draw"
        '
        'SinFunctionToolStripMenuItem
        '
        Me.SinFunctionToolStripMenuItem.Name = "SinFunctionToolStripMenuItem"
        Me.SinFunctionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SinFunctionToolStripMenuItem.Text = "Sin Function"
        '
        'CosFunctionToolStripMenuItem
        '
        Me.CosFunctionToolStripMenuItem.Name = "CosFunctionToolStripMenuItem"
        Me.CosFunctionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CosFunctionToolStripMenuItem.Text = "Cos Function"
        '
        'TanFunctionToolStripMenuItem
        '
        Me.TanFunctionToolStripMenuItem.Name = "TanFunctionToolStripMenuItem"
        Me.TanFunctionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TanFunctionToolStripMenuItem.Text = "Tan Function"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'PBDrawing
        '
        Me.PBDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBDrawing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBDrawing.Location = New System.Drawing.Point(0, 28)
        Me.PBDrawing.Name = "PBDrawing"
        Me.PBDrawing.Size = New System.Drawing.Size(800, 432)
        Me.PBDrawing.TabIndex = 1
        Me.PBDrawing.TabStop = False
        '
        'SinWaveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PBDrawing)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SinWaveForm"
        Me.Text = "SinWaveForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PBDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PBDrawing As PictureBox
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinFunctionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CosFunctionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TanFunctionToolStripMenuItem As ToolStripMenuItem
End Class
