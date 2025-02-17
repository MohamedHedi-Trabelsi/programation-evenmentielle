Public Class frm_livre



    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim l As livre
        l.ISBN = txt_isbn.Text
        l.titre = txt_titre.Text
        l.auteur = txt_auteur.Text

        If AjouterLivre(l) Then
            MessageBox.Show("ajout du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé")
        End If
    End Sub

    Private Sub btn_affiche_Click(sender As Object, e As EventArgs) Handles btn_affiche.Click
        frm_afficher.Show()
        frm_afficher2.Show()

    End Sub


End Class
