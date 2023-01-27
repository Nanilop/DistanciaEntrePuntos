Public Class Punto
    Private x1 As Integer

    Private y1 As Integer

    Public Sub New()
        x1 = 0
        y1 = 0
    End Sub
    Public Sub New(x As Integer, y As Integer)
        x1 = x
        y1 = y
    End Sub

    Public Property X() As Integer
        Get
            Return x1
        End Get

        Set(ByVal value As Integer)
            x1 = value
        End Set
    End Property

    Public Property Y() As Integer
        Get
            Return y1
        End Get

        Set(ByVal value As Integer)
            y1 = value
        End Set
    End Property

    Public Function Distancia(p As Punto) As Double
        Dim resultado As Double = 0
        Dim xp = (x1 - p.X) * (x1 - p.X)
        Dim yp = (y1 - p.Y) * (y1 - p.Y)
        resultado = Math.Sqrt(xp + yp)
        Return resultado
    End Function
End Class
