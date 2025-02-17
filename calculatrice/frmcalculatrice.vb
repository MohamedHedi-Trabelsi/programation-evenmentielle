Public Class frmcalculatrice
    Dim op As Char
    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        op = "-"
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        op = "/"
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then
            Dim a = Integer.Parse(txt_A.Text)
            Dim b = Integer.Parse(txt_B.Text)
            Dim test = True
            Dim res As Double
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" And Not b = 0 Then
                res = a / b
                test = False
            Else
                MessageBox.Show("Veuillez vérifiezbvos donnés")

            End If
            If test Then
                lbl_res.Text = a.ToString + "" + op + "" + b.ToString + "=" + res.ToString
            End If
        Else
            MessageBox.Show("A et B doivent etre entier")
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_A.Text = ""
        txt_B.Text = ""
        lbl_res.Text = ""
        op = Char.MinValue
    End Sub
End Class

