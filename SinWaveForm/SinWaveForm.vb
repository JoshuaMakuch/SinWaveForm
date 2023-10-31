'Joshua Makuch
'RCET 3371
'October 31, 2023
'SinWaveform
'https://github.com/JoshuaMakuch/SinWaveForm

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class SinWaveForm

    Public CenterX, CenterY, CurrentX, CurrentY, LastX, LastY As Integer
    Public PI2 As Double = (2 * Math.PI)
    Dim g As Graphics = Me.CreateGraphics
    Dim myPen As Pen = New Pen(Color.Black)
    Dim bmp As Bitmap

    'Handles Sin function tool strip menu item click
    Private Sub SinFunctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinFunctionToolStripMenuItem.Click
        CenterX = PBDrawing.Width / 2
        CenterY = PBDrawing.Height / 2

        'Clears the current image
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp

        Using g As Graphics = Graphics.FromImage(PBDrawing.Image)
            LastY = CenterY
            LastX = 0
            CurrentX = 0
            For i As Integer = 0 To PBDrawing.Width
                CurrentX += 1
                CurrentY = (CenterY / 2) * Math.Sin((i * PI2) / CenterX + (2 * CenterX)) + CenterY
                g.DrawLine(myPen, LastX, LastY, CurrentX, CurrentY)
                LastX = CurrentX
                LastY = CurrentY
            Next
        End Using
    End Sub

    'Handles Cos function tool strip menu item click
    Private Sub CosinFunctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CosFunctionToolStripMenuItem.Click
        CenterX = PBDrawing.Width / 2
        CenterY = PBDrawing.Height / 2

        'Clears the current image
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp

        Using g As Graphics = Graphics.FromImage(PBDrawing.Image)
            LastY = CenterY
            LastX = 0
            CurrentX = 0

            For i As Integer = 0 To PBDrawing.Width
                CurrentX += 1
                CurrentY = (CenterY / 2) * Math.Cos((i * PI2) / CenterX + (2 * CenterX)) + CenterY
                g.DrawLine(myPen, LastX, LastY, CurrentX, CurrentY)
                LastX = CurrentX
                LastY = CurrentY
            Next
        End Using
    End Sub

    'Handles Tan function tool strip menu item click
    Private Sub TanFunctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TanFunctionToolStripMenuItem.Click
        CenterX = PBDrawing.Width / 2
        CenterY = PBDrawing.Height / 2

        'Clears the current image
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp

        Using g As Graphics = Graphics.FromImage(PBDrawing.Image)
            LastY = CenterY
            LastX = 0
            CurrentX = 0
            For i As Integer = 0 To PBDrawing.Width
                CurrentX += 1

                CurrentY = (CenterY / 8) * Math.Tan((i * PI2) / CenterX + (2 * CenterX)) + CenterY

                If Math.Abs(CurrentY) > (PBDrawing.Height + 100) Then Else g.DrawLine(myPen, LastX, LastY, CurrentX, CurrentY)

                LastY = CurrentY
                LastX = CurrentX
            Next
        End Using
    End Sub

    'Handles the clear tool strip menu item click
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clears the current image
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp
    End Sub

    'Handles the select color tool strip menu item click
    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        'Uses the color dialog function of VB to select a new color
        Dim NewDialog As New ColorDialog()
        If (NewDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            myPen.Color = NewDialog.Color
        End If
    End Sub

    'Handles the exit tool strup menu item click
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
