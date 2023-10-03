Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Second Class 3 October 2023"
        Me.BackColor = Color.YellowGreen
        Me.MaximizeBox = True
        Me.MinimizeBox = False
        Me.Size = New Size(800, 400)
        Me.Opacity = 0.85                   'Makes it Transparent
        Me.CenterToParent()                 'Center the Execution box
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
