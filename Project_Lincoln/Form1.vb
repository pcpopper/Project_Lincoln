Public Class Form1


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim truckPanel1 = New TruckPanel(Panel1, 0)
        Panel1.Controls.Add(truckPanel1)
    End Sub
End Class
