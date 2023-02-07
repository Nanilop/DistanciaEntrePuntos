
Imports System.Security
Imports PuntoVB

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPunto1.Text = ""
        txtPunto2.Text = ""
        txtResult.Text = ""
        adver.Visible = False
    End Sub

    Private Sub txtPunto1_TextChanged(sender As Object, e As EventArgs) Handles txtPunto1.TextChanged
        If (String.IsNullOrWhiteSpace(txtPunto1.Text) Or String.IsNullOrEmpty(txtPunto1.Text)) Then
            p1.Visible = True
        Else
            p1.Visible = False
        End If
    End Sub
    Private Sub txtPunto2_TextChanged(sender As Object, e As EventArgs) Handles txtPunto2.TextChanged
        If (String.IsNullOrWhiteSpace(txtPunto2.Text) Or String.IsNullOrEmpty(txtPunto2.Text)) Then
            p2.Visible = True
        Else
            p2.Visible = False
        End If
    End Sub
    Private Sub TextChange(sender As Object, e As EventArgs) Handles txtPunto1.TextChanged, txtPunto2.TextChanged

        Dim punto1 As String = txtPunto1.Text.Replace(" ", "")
        Dim punto2 As String = txtPunto2.Text.Replace(" ", "")
        If (punto1.StartsWith("(") And punto2.StartsWith("(") And punto1.EndsWith(")") And punto2.EndsWith(")")) Then
            For i As Integer = 1 To punto1.Length - 2 Step 1
                Dim punto = punto1.Substring(i, 1)
                If punto1.Substring(i, 1) <> "," And punto1.Substring(i, 1) <> "1" And punto1.Substring(i, 1) <> "2" And
                    punto1.Substring(i, 1) <> "3" And punto1.Substring(i, 1) <> "4" And punto1.Substring(i, 1) <> "5" And
                    punto1.Substring(i, 1) <> "6" And punto1.Substring(i, 1) <> "7" And punto1.Substring(i, 1) <> "8" And
                    punto1.Substring(i, 1) <> "9" And punto1.Substring(i, 1) <> "0" And punto1.Substring(i, 1) <> "-" Then
                    adver.Visible = True
                    btnCalcular.Enabled = False
                    Exit Sub
                Else
                    adver.Visible = False
                    btnCalcular.Enabled = True
                End If

            Next

            For i As Integer = 1 To punto2.Length - 2 Step 1
                Dim punto = punto2.Substring(i, 1)
                If punto2.Substring(i, 1) <> "," And punto2.Substring(i, 1) <> "1" And punto2.Substring(i, 1) <> "2" And
                    punto2.Substring(i, 1) <> "3" And punto2.Substring(i, 1) <> "4" And punto2.Substring(i, 1) <> "5" And
                    punto2.Substring(i, 1) <> "6" And punto2.Substring(i, 1) <> "7" And punto2.Substring(i, 1) <> "8" And
                    punto2.Substring(i, 1) <> "9" And punto2.Substring(i, 1) <> "0" And punto2.Substring(i, 1) <> "-" Then
                    adver.Visible = True
                    btnCalcular.Enabled = False
                    Exit Sub
                Else
                    adver.Visible = False
                    btnCalcular.Enabled = True

                End If

            Next
        Else
            adver.Visible = True
            btnCalcular.Enabled = False
        End If
        If p1.Visible = True Or p2.Visible = True Then
            adver.Visible = False
            btnCalcular.Enabled = False
        End If

    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If adver.Visible = False Then
            Dim x1 As Integer = 0
            Dim x2 As Integer = 0
            Dim y1 As Integer = 0
            Dim y2 As Integer = 0
            Dim z1 As Integer = 0
            Dim z2 As Integer = 0
            Dim part As Integer = 0
            Dim aux As String = ""
            For i As Integer = 0 To txtPunto1.Text.Length - 1 Step 1
                If (part = 0) Then
                    If (txtPunto1.Text.Substring(i, 1) = ",") Then
                        part = 1
                        x1 = Convert.ToInt32(aux)
                        aux = ""
                    Else
                        If (txtPunto1.Text.Substring(i, 1) <> "(") Then
                            aux += txtPunto1.Text.Substring(i, 1)
                        End If
                    End If
                ElseIf (part = 1) Then

                    If (txtPunto1.Text.Substring(i, 1) = ",") Then
                        part = 2
                        y1 = Convert.ToInt32(aux)
                        aux = ""
                    Else
                        aux += txtPunto1.Text.Substring(i, 1)
                    End If
                Else
                    If (txtPunto1.Text.Substring(i, 1) = ")") Then
                        part = 0
                        z1 = Convert.ToInt32(aux)
                        aux = ""
                    Else
                        aux += txtPunto1.Text.Substring(i, 1)
                    End If
                End If



            Next

            For i As Integer = 0 To txtPunto2.Text.Length - 1 Step 1
                If (part = 0) Then
                    If (txtPunto2.Text.Substring(i, 1) = ",") Then
                        part = 1
                        x2 = Convert.ToInt32(aux)
                        aux = ""
                    Else
                        If (txtPunto2.Text.Substring(i, 1) <> "(") Then
                            aux += txtPunto2.Text.Substring(i, 1)
                        End If
                    End If
                ElseIf (part = 1) Then

                    If (txtPunto2.Text.Substring(i, 1) = ",") Then
                        part = 2
                        y2 = Convert.ToInt32(aux)
                        aux = ""
                    Else
                        aux += txtPunto2.Text.Substring(i, 1)
                    End If
                Else
                    If (txtPunto2.Text.Substring(i, 1) = ")") Then
                        part = 0
                        z2 = Convert.ToInt32(aux)
                        aux = ""
                    Else
                        aux += txtPunto2.Text.Substring(i, 1)
                    End If
                End If
            Next

            Dim Punto1 As Punto3D = New Punto3D(x1, y1, z1)
            Dim Punto2 As Punto3D = New Punto3D(x2, y2, z2)
            txtResult.Text = Math.Round(Punto2.Distancia(Punto1), 4).ToString()
        End If
    End Sub
End Class
