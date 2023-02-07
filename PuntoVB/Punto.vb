Public Class Punto
    Protected x1 As Integer
    Public Property X() As Integer
        Get
            Return x1
        End Get

        Set(ByVal value As Integer)
            x1 = value
        End Set
    End Property
    Public Sub New()
        x1 = 0

    End Sub
    Public Sub New(x As Integer)
        x1 = x

    End Sub
    Public Function Distancia(p As Punto) As Double
        Dim resultado As Double = (x1 - p.X)
        Return resultado
    End Function
    Public Overrides Function ToString() As String
        Return "(" + x1 + ")"
    End Function
End Class
