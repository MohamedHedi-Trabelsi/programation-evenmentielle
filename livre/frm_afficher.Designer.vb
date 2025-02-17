<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lst_isbn = New ListBox()
        lst_auteur = New ListBox()
        lst_titre = New ListBox()
        btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 20)
        Label1.TabIndex = 0
        Label1.Text = "isbn"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(603, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 1
        Label2.Text = "titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(308, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 2
        Label3.Text = "auteur"
        ' 
        ' lst_isbn
        ' 
        lst_isbn.FormattingEnabled = True
        lst_isbn.Items.AddRange(New Object() {"lst_isbn"})
        lst_isbn.Location = New Point(41, 82)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(150, 104)
        lst_isbn.TabIndex = 3
        ' 
        ' lst_auteur
        ' 
        lst_auteur.FormattingEnabled = True
        lst_auteur.Items.AddRange(New Object() {"lst_auteur"})
        lst_auteur.Location = New Point(270, 82)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(150, 104)
        lst_auteur.TabIndex = 4
        ' 
        ' lst_titre
        ' 
        lst_titre.FormattingEnabled = True
        lst_titre.Items.AddRange(New Object() {"lst_titre"})
        lst_titre.Location = New Point(560, 82)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(150, 104)
        lst_titre.TabIndex = 5
        ' 
        ' btn_afficher
        ' 
        btn_afficher.Location = New Point(340, 308)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(94, 29)
        btn_afficher.TabIndex = 6
        btn_afficher.Text = "afficher"
        btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' frm_afficher
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_afficher)
        Controls.Add(lst_titre)
        Controls.Add(lst_auteur)
        Controls.Add(lst_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_afficher"
        Text = "frm_afficher"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents btn_afficher As Button
End Class
