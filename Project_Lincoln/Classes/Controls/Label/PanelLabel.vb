Public Class PanelLabel
    Inherits System.Windows.Forms.Label

    Public Sub New(ByVal size As Size, ByVal location As Point, Optional ByVal value As String = "", Optional ByVal fontStyle As FontStyle = FontStyle.Regular, Optional ByVal fontSize As Single = 8.25)
        MyBase.New()

        Dim newFont = New Font(Me.Font.Name, fontSize, fontStyle)

        With Me
            .Size = size
            .Location = location
            .Text = value
            .Font = newFont
        End With
    End Sub
End Class
