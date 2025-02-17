Module gestion_livres

    Public Structure livre
            Dim ISBN As Integer
            Dim titre As String
            Dim auteur As String
        End Structure

        Public bibliotheque(100) As livre
        Dim Nb As Integer = 0

        Function AjouterLivre(l As livre) As Boolean
            If Nb < bibliotheque.Length Then
                bibliotheque(Nb) = l
                Nb += 1
                Return True
            Else
                Return False
            End If
        End Function

        Sub afficher_Livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
            For i As Integer = 0 To Nb - 1
                l1.Items.Add(bibliotheque(i).ISBN)
                l2.Items.Add(bibliotheque(i).titre)
                l3.Items.Add(bibliotheque(i).auteur)
            Next
        End Sub
        Sub afficher2_livre(dgv_livre As DataGridView)
        For i As Integer = 0 To Nb - 1
            Dim livre As livre = bibliotheque(i)
            dgv_livre.Rows.Add(livre.ISBN, livre.titre, livre.auteur)
        Next
    End Sub

    End Module


