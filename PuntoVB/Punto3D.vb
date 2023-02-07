Public Class Punto3D

    Inherits Punto2D

    Private z1 As Integer

    Public Sub New()
        x1 = 0
        y1 = 0
        z1 = 0
    End Sub
    Public Sub New(x As Integer, y As Integer, z As Integer)
        x1 = x
        y1 = y
        z1 = z
    End Sub

    Public Property Z() As Integer
        Get
            Return z1
        End Get

        Set(ByVal value As Integer)
            z1 = value
        End Set
    End Property

    Public Overloads Function Distancia(p As Punto3D) As Double
        Dim resultado As Double = 0
        Dim xp = (x1 - p.X) * (x1 - p.X)
        Dim yp = (y1 - p.Y) * (y1 - p.Y)
        Dim zp = (z1 - p.Z) * (z1 - p.Z)
        resultado = Math.Sqrt(xp + yp + zp)
        Return resultado
    End Function
    Public Overrides Function ToString() As String
        Return "(" + x1 + "," + y1 + "," + z1 + ")"
    End Function
End Class
