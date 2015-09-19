Public Class TruckPanel
    Inherits System.Windows.Forms.Panel

    Dim truckPanel As Panel

    ' label that will store the values
    Dim valSerial, valModel, valNomenm, valWeapon, valComm, valDggr, valBFT
    Dim lblSerial, lblModel, lblNomenm, lblWeapon, lblComm, lblDggr, lblBFT

    Public Sub New(ByRef parentPanel As Panel, ByVal number As Integer)
        MyBase.New()

        Dim lblSerial = New PanelLabel(New Drawing.Size(119, 31), New Point(3, 1), "SERIAL:", , 20.25)
        Dim valSerial = New PanelLabel(New Drawing.Size(110, 31), New Point(116, 1), , FontStyle.Bold, 20.25)

        Dim parentSize As Size = parentPanel.Size
        parentSize.Height = 36

        Dim startPos As New Point(0, (36 * number))

        Dim labels = New Control() {
            lblSerial,
            valSerial
            }

        With Me
            .Size = parentSize
            .Location = startPos
            .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            .Controls.AddRange(labels)
        End With
    End Sub

End Class
