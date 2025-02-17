<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher2
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
        dgv_livre = New DataGridView()
        isbn = New DataGridViewTextBoxColumn()
        TITRE = New DataGridViewTextBoxColumn()
        Auteur = New DataGridViewTextBoxColumn()
        CType(dgv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_livre
        ' 
        dgv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_livre.Columns.AddRange(New DataGridViewColumn() {isbn, TITRE, Auteur})
        dgv_livre.Location = New Point(0, 0)
        dgv_livre.Name = "dgv_livre"
        dgv_livre.RowHeadersWidth = 51
        dgv_livre.Size = New Size(549, 188)
        dgv_livre.TabIndex = 0
        ' 
        ' isbn
        ' 
        isbn.HeaderText = "ISBN"
        isbn.MinimumWidth = 6
        isbn.Name = "isbn"
        isbn.Width = 125
        ' 
        ' TITRE
        ' 
        TITRE.HeaderText = "TITRE"
        TITRE.MinimumWidth = 6
        TITRE.Name = "TITRE"
        TITRE.Width = 125
        ' 
        ' Auteur
        ' 
        Auteur.HeaderText = "Auteur"
        Auteur.MinimumWidth = 6
        Auteur.Name = "Auteur"
        Auteur.Width = 125
        ' 
        ' frm_afficher2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_livre)
        Name = "frm_afficher2"
        Text = "frm_afficher2"
        CType(dgv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_livre As DataGridView
    Friend WithEvents isbn As DataGridViewTextBoxColumn
    Friend WithEvents TITRE As DataGridViewTextBoxColumn
    Friend WithEvents Auteur As DataGridViewTextBoxColumn
End Class
