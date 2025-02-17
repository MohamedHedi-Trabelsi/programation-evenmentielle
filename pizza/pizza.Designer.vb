<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pizza
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
        lst_demande = New ComboBox()
        Chk_ch = New CheckBox()
        Chk_ol = New CheckBox()
        Chk_po = New CheckBox()
        Chk_fr = New CheckBox()
        rd_fine = New RadioButton()
        rd_classique = New RadioButton()
        rd_epaise = New RadioButton()
        btn_affiche = New Button()
        SuspendLayout()
        ' 
        ' lst_demande
        ' 
        lst_demande.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lst_demande.ForeColor = SystemColors.HotTrack
        lst_demande.FormattingEnabled = True
        lst_demande.Items.AddRange(New Object() {"Grande", "Moyenne ", "Petite"})
        lst_demande.Location = New Point(98, 38)
        lst_demande.Name = "lst_demande"
        lst_demande.Size = New Size(200, 26)
        lst_demande.TabIndex = 0
        ' 
        ' Chk_ch
        ' 
        Chk_ch.AutoSize = True
        Chk_ch.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Chk_ch.ForeColor = SystemColors.ActiveCaption
        Chk_ch.ImageAlign = ContentAlignment.BottomCenter
        Chk_ch.Location = New Point(176, 176)
        Chk_ch.Name = "Chk_ch"
        Chk_ch.Size = New Size(178, 35)
        Chk_ch.TabIndex = 1
        Chk_ch.Text = "Champignon"
        Chk_ch.UseVisualStyleBackColor = True
        ' 
        ' Chk_ol
        ' 
        Chk_ol.AutoSize = True
        Chk_ol.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Chk_ol.ForeColor = SystemColors.ActiveCaption
        Chk_ol.ImageAlign = ContentAlignment.BottomCenter
        Chk_ol.Location = New Point(176, 217)
        Chk_ol.Name = "Chk_ol"
        Chk_ol.Size = New Size(109, 35)
        Chk_ol.TabIndex = 2
        Chk_ol.Text = "OLives"
        Chk_ol.UseVisualStyleBackColor = True
        ' 
        ' Chk_po
        ' 
        Chk_po.AutoSize = True
        Chk_po.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Chk_po.ForeColor = SystemColors.ActiveCaption
        Chk_po.ImageAlign = ContentAlignment.BottomCenter
        Chk_po.Location = New Point(176, 258)
        Chk_po.Name = "Chk_po"
        Chk_po.Size = New Size(131, 35)
        Chk_po.TabIndex = 3
        Chk_po.Text = "Poivrons"
        Chk_po.UseVisualStyleBackColor = True
        ' 
        ' Chk_fr
        ' 
        Chk_fr.AutoSize = True
        Chk_fr.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Chk_fr.ForeColor = SystemColors.ActiveCaption
        Chk_fr.ImageAlign = ContentAlignment.BottomCenter
        Chk_fr.Location = New Point(176, 299)
        Chk_fr.Name = "Chk_fr"
        Chk_fr.Size = New Size(308, 35)
        Chk_fr.TabIndex = 4
        Chk_fr.Text = "Fromage supplimentaire"
        Chk_fr.UseVisualStyleBackColor = True
        ' 
        ' rd_fine
        ' 
        rd_fine.AutoSize = True
        rd_fine.Font = New Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rd_fine.ForeColor = SystemColors.HotTrack
        rd_fine.Location = New Point(53, 124)
        rd_fine.Name = "rd_fine"
        rd_fine.Size = New Size(154, 27)
        rd_fine.TabIndex = 5
        rd_fine.TabStop = True
        rd_fine.Text = "Croute fine"
        rd_fine.UseVisualStyleBackColor = True
        ' 
        ' rd_classique
        ' 
        rd_classique.AutoSize = True
        rd_classique.Font = New Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rd_classique.ForeColor = SystemColors.HotTrack
        rd_classique.Location = New Point(242, 124)
        rd_classique.Name = "rd_classique"
        rd_classique.Size = New Size(213, 27)
        rd_classique.TabIndex = 6
        rd_classique.TabStop = True
        rd_classique.Text = "Croute classique"
        rd_classique.UseVisualStyleBackColor = True
        ' 
        ' rd_epaise
        ' 
        rd_epaise.AutoSize = True
        rd_epaise.Font = New Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rd_epaise.ForeColor = SystemColors.HotTrack
        rd_epaise.Location = New Point(483, 124)
        rd_epaise.Name = "rd_epaise"
        rd_epaise.Size = New Size(176, 27)
        rd_epaise.TabIndex = 7
        rd_epaise.TabStop = True
        rd_epaise.Text = "Croute épaise"
        rd_epaise.UseVisualStyleBackColor = True
        ' 
        ' btn_affiche
        ' 
        btn_affiche.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_affiche.ForeColor = SystemColors.MenuText
        btn_affiche.Location = New Point(176, 382)
        btn_affiche.Name = "btn_affiche"
        btn_affiche.Size = New Size(329, 39)
        btn_affiche.TabIndex = 8
        btn_affiche.Text = "Afficher la commande"
        btn_affiche.UseVisualStyleBackColor = True
        ' 
        ' pizza
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(btn_affiche)
        Controls.Add(rd_epaise)
        Controls.Add(rd_classique)
        Controls.Add(rd_fine)
        Controls.Add(Chk_fr)
        Controls.Add(Chk_po)
        Controls.Add(Chk_ol)
        Controls.Add(Chk_ch)
        Controls.Add(lst_demande)
        Name = "pizza"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lst_demande As ComboBox
    Friend WithEvents Chk_ch As CheckBox
    Friend WithEvents Chk_ol As CheckBox
    Friend WithEvents Chk_po As CheckBox
    Friend WithEvents Chk_fr As CheckBox
    Friend WithEvents rd_fine As RadioButton
    Friend WithEvents rd_classique As RadioButton
    Friend WithEvents rd_epaise As RadioButton
    Friend WithEvents btn_affiche As Button

End Class
