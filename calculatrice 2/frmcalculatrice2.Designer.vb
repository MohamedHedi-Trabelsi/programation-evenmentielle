<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcalculatrice2
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
        lbl_result = New Label()
        Btn_0 = New Button()
        btn_1 = New Button()
        btn_2 = New Button()
        btn_3 = New Button()
        btn_4 = New Button()
        btn_5 = New Button()
        btn_6 = New Button()
        btn_7 = New Button()
        btn_8 = New Button()
        btn_9 = New Button()
        btn_reset = New Button()
        btn_result = New Button()
        btn_plus = New Button()
        btn_minus = New Button()
        btn_mult = New Button()
        btn_div = New Button()
        txt_result = New TextBox()
        SuspendLayout()
        ' 
        ' lbl_result
        ' 
        lbl_result.AutoSize = True
        lbl_result.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_result.ForeColor = SystemColors.ActiveCaption
        lbl_result.Location = New Point(110, 23)
        lbl_result.Name = "lbl_result"
        lbl_result.Size = New Size(218, 50)
        lbl_result.TabIndex = 0
        lbl_result.Text = "RESULTAT"
        ' 
        ' Btn_0
        ' 
        Btn_0.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_0.ForeColor = SystemColors.ActiveCaptionText
        Btn_0.Location = New Point(87, 119)
        Btn_0.Name = "Btn_0"
        Btn_0.Size = New Size(72, 47)
        Btn_0.TabIndex = 1
        Btn_0.Text = "0"
        Btn_0.UseVisualStyleBackColor = True
        ' 
        ' btn_1
        ' 
        btn_1.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_1.Location = New Point(234, 119)
        btn_1.Name = "btn_1"
        btn_1.Size = New Size(77, 47)
        btn_1.TabIndex = 2
        btn_1.Text = "1"
        btn_1.UseVisualStyleBackColor = True
        ' 
        ' btn_2
        ' 
        btn_2.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_2.Location = New Point(401, 119)
        btn_2.Name = "btn_2"
        btn_2.Size = New Size(80, 47)
        btn_2.TabIndex = 3
        btn_2.Text = "2"
        btn_2.UseVisualStyleBackColor = True
        ' 
        ' btn_3
        ' 
        btn_3.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_3.Location = New Point(560, 119)
        btn_3.Name = "btn_3"
        btn_3.Size = New Size(68, 47)
        btn_3.TabIndex = 4
        btn_3.Text = "3"
        btn_3.UseVisualStyleBackColor = True
        ' 
        ' btn_4
        ' 
        btn_4.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_4.Location = New Point(87, 210)
        btn_4.Name = "btn_4"
        btn_4.Size = New Size(72, 44)
        btn_4.TabIndex = 5
        btn_4.Text = "4"
        btn_4.UseVisualStyleBackColor = True
        ' 
        ' btn_5
        ' 
        btn_5.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_5.Location = New Point(234, 210)
        btn_5.Name = "btn_5"
        btn_5.Size = New Size(77, 44)
        btn_5.TabIndex = 6
        btn_5.Text = "5"
        btn_5.UseVisualStyleBackColor = True
        ' 
        ' btn_6
        ' 
        btn_6.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_6.Location = New Point(401, 210)
        btn_6.Name = "btn_6"
        btn_6.Size = New Size(80, 44)
        btn_6.TabIndex = 7
        btn_6.Text = "6"
        btn_6.UseVisualStyleBackColor = True
        ' 
        ' btn_7
        ' 
        btn_7.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_7.Location = New Point(560, 210)
        btn_7.Name = "btn_7"
        btn_7.Size = New Size(68, 44)
        btn_7.TabIndex = 8
        btn_7.Text = "7"
        btn_7.UseVisualStyleBackColor = True
        ' 
        ' btn_8
        ' 
        btn_8.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_8.Location = New Point(87, 288)
        btn_8.Name = "btn_8"
        btn_8.Size = New Size(72, 49)
        btn_8.TabIndex = 9
        btn_8.Text = "8"
        btn_8.UseVisualStyleBackColor = True
        ' 
        ' btn_9
        ' 
        btn_9.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_9.Location = New Point(234, 288)
        btn_9.Name = "btn_9"
        btn_9.Size = New Size(77, 49)
        btn_9.TabIndex = 10
        btn_9.Text = "9"
        btn_9.UseVisualStyleBackColor = True
        ' 
        ' btn_reset
        ' 
        btn_reset.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_reset.Location = New Point(401, 288)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(80, 49)
        btn_reset.TabIndex = 11
        btn_reset.Text = "c"
        btn_reset.UseVisualStyleBackColor = True
        ' 
        ' btn_result
        ' 
        btn_result.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_result.Location = New Point(560, 288)
        btn_result.Name = "btn_result"
        btn_result.Size = New Size(68, 49)
        btn_result.TabIndex = 12
        btn_result.Text = "="
        btn_result.UseVisualStyleBackColor = True
        ' 
        ' btn_plus
        ' 
        btn_plus.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_plus.Location = New Point(87, 366)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(72, 47)
        btn_plus.TabIndex = 13
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = True
        ' 
        ' btn_minus
        ' 
        btn_minus.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_minus.Location = New Point(234, 366)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(77, 47)
        btn_minus.TabIndex = 14
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = True
        ' 
        ' btn_mult
        ' 
        btn_mult.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_mult.Location = New Point(401, 366)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(80, 47)
        btn_mult.TabIndex = 15
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = True
        ' 
        ' btn_div
        ' 
        btn_div.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_div.Location = New Point(560, 366)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(68, 47)
        btn_div.TabIndex = 16
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = True
        ' 
        ' txt_result
        ' 
        txt_result.Location = New Point(398, 46)
        txt_result.Name = "txt_result"
        txt_result.Size = New Size(256, 27)
        txt_result.TabIndex = 17
        ' 
        ' frmcalculatrice2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txt_result)
        Controls.Add(btn_div)
        Controls.Add(btn_mult)
        Controls.Add(btn_minus)
        Controls.Add(btn_plus)
        Controls.Add(btn_result)
        Controls.Add(btn_reset)
        Controls.Add(btn_9)
        Controls.Add(btn_8)
        Controls.Add(btn_7)
        Controls.Add(btn_6)
        Controls.Add(btn_5)
        Controls.Add(btn_4)
        Controls.Add(btn_3)
        Controls.Add(btn_2)
        Controls.Add(btn_1)
        Controls.Add(Btn_0)
        Controls.Add(lbl_result)
        Name = "frmcalculatrice2"
        Text = "calculatrice 2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_result As Label
    Friend WithEvents Btn_0 As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_result As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents txt_result As TextBox

End Class
