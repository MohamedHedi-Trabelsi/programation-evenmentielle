Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles

Public Class frmcalculatrice2
    Dim A As String
    Dim B As String
    Dim op = ""

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        txt_result.Text = A + "" + op + "" + B
    End Sub
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

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_result.Text = ""
        A = ""
        B = ""
        op = ""
    End Sub

    Private Sub btn_result_Click(sender As Object, e As EventArgs) Handles btn_result.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)



            If op = "+" Then
                res = va + vb

            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = A / B

            Else
                MessageBox.Show("division par 0")
            End If
        Else
            MessageBox.Show(" A et B doivent être entier ")
            test = False
        End If


        If test Then
            txt_result.Text = txt_result.Text + "=" + res.ToString
        End If


    End Sub
End Class
