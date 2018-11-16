Public Class BildGroesse
    Public Function AutoSizeImage(ByVal oBitmap As Image,
  ByVal maxWidth As Integer,
  ByVal maxHeight As Integer,
  Optional ByVal bStretch As Boolean = False) As Image

        ' Größenverhältnis der max. Dimension
        Dim maxRatio As Single = maxWidth / maxHeight

        ' Bildgröße und aktuelles Größenverhältnis
        Dim imgWidth As Integer = oBitmap.Width
        Dim imgHeight As Integer = oBitmap.Height
        Dim imgRatio As Single = imgWidth / imgHeight

        ' Bild anpassen?
        If (imgWidth > maxWidth Or imgHeight > maxHeight) Or (bStretch) Then
            If imgRatio <= maxRatio Then
                ' Größenverhältnis des Bildes ist kleiner als die
                ' maximale Größe, in der das Bild angezeigt werden kann.
                ' In diesem Fall muss die Bildbreite angepasst werden.
                imgWidth = imgWidth / (imgHeight / maxHeight)
                imgHeight = maxHeight
            Else
                ' Größenverhältnis des Bildes ist größer als die 
                ' maximale Größe, in der das Bild angezeigt werden kann.
                ' In diesem Fall muss die Bildhöhe angepasst werden.
                imgHeight = imgHeight / (imgWidth / maxWidth)
                imgWidth = maxWidth
            End If

            ' Bitmap-Objekt in der neuen Größe erstellen
            Dim oImage As New Bitmap(imgWidth, imgHeight)

            ' Bild interpolieren, damit die Qualität erhalten bleibt
            Using g As Graphics = Graphics.FromImage(oImage)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(oBitmap, New Rectangle(0, 0, imgWidth, imgHeight))
            End Using

            ' neues Bitmap zurückgeben
            Return oImage
        Else
            ' unverändertes Originalbild zurückgeben
            Return oBitmap
        End If
    End Function
End Class
