<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label6 = New Label()
        formNilaiBtn = New Button()
        formMatkulBtn = New Button()
        formMhsBtn = New Button()
        Label8 = New Label()
        dgv = New DataGridView()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(13, 518)
        Label6.Name = "Label6"
        Label6.Size = New Size(303, 45)
        Label6.TabIndex = 71
        Label6.Text = "TOMBOL ARAHAN"
        ' 
        ' formNilaiBtn
        ' 
        formNilaiBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formNilaiBtn.Location = New Point(266, 566)
        formNilaiBtn.Name = "formNilaiBtn"
        formNilaiBtn.Size = New Size(120, 60)
        formNilaiBtn.TabIndex = 70
        formNilaiBtn.Text = "FORM NILAI"
        formNilaiBtn.UseVisualStyleBackColor = True
        ' 
        ' formMatkulBtn
        ' 
        formMatkulBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formMatkulBtn.Location = New Point(139, 566)
        formMatkulBtn.Name = "formMatkulBtn"
        formMatkulBtn.Size = New Size(120, 60)
        formMatkulBtn.TabIndex = 69
        formMatkulBtn.Text = "FORM MATKUL"
        formMatkulBtn.UseVisualStyleBackColor = True
        ' 
        ' formMhsBtn
        ' 
        formMhsBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formMhsBtn.Location = New Point(13, 566)
        formMhsBtn.Name = "formMhsBtn"
        formMhsBtn.Size = New Size(120, 60)
        formMhsBtn.TabIndex = 68
        formMhsBtn.Text = "FORM MHS"
        formMhsBtn.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(604, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(374, 45)
        Label8.TabIndex = 67
        Label8.Text = "TAMPILAN DATA NILAI"
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(392, 78)
        dgv.Name = "dgv"
        dgv.RowTemplate.Height = 25
        dgv.Size = New Size(1022, 548)
        dgv.TabIndex = 66
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1426, 638)
        Controls.Add(Label6)
        Controls.Add(formNilaiBtn)
        Controls.Add(formMatkulBtn)
        Controls.Add(formMhsBtn)
        Controls.Add(Label8)
        Controls.Add(dgv)
        Name = "Form4"
        Text = "Form4"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents formNilaiBtn As Button
    Friend WithEvents formMatkulBtn As Button
    Friend WithEvents formMhsBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv As DataGridView
End Class
