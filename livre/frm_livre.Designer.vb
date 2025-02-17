<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_livre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lbl_isbn = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt_isbn = New TextBox()
        txt_auteur = New TextBox()
        txt_titre = New TextBox()
        btn_affiche = New Button()
        btn_ajout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' lbl_isbn
        ' 
        lbl_isbn.AutoSize = True
        lbl_isbn.Location = New Point(23, 18)
        lbl_isbn.Name = "lbl_isbn"
        lbl_isbn.Size = New Size(36, 20)
        lbl_isbn.TabIndex = 1
        lbl_isbn.Text = "isbn"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 2
        Label3.Text = "auteur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 3
        Label4.Text = "Titre"
        ' 
        ' txt_isbn
        ' 
        txt_isbn.Location = New Point(104, 18)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(125, 27)
        txt_isbn.TabIndex = 4
        ' 
        ' txt_auteur
        ' 
        txt_auteur.Location = New Point(104, 94)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(125, 27)
        txt_auteur.TabIndex = 5
        ' 
        ' txt_titre
        ' 
        txt_titre.Location = New Point(104, 182)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(125, 27)
        txt_titre.TabIndex = 6
        ' 
        ' btn_affiche
        ' 
        btn_affiche.Location = New Point(218, 340)
        btn_affiche.Name = "btn_affiche"
        btn_affiche.Size = New Size(94, 29)
        btn_affiche.TabIndex = 7
        btn_affiche.Text = "afficher"
        btn_affiche.UseVisualStyleBackColor = True
        ' 
        ' btn_ajout
        ' 
        btn_ajout.Location = New Point(403, 340)
        btn_ajout.Name = "btn_ajout"
        btn_ajout.Size = New Size(94, 29)
        btn_ajout.TabIndex = 8
        btn_ajout.Text = "ajouter"
        btn_ajout.UseVisualStyleBackColor = True
        ' 
        ' frm_livre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_ajout)
        Controls.Add(btn_affiche)
        Controls.Add(txt_titre)
        Controls.Add(txt_auteur)
        Controls.Add(txt_isbn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lbl_isbn)
        Controls.Add(Label1)
        Name = "frm_livre"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_isbn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents btn_affiche As Button
    Friend WithEvents btn_ajout As Button

End Class
