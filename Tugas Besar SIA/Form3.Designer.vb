<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        formLaporanBtn = New Button()
        formMatkulBtn = New Button()
        formMhsBtn = New Button()
        Label8 = New Label()
        dgv = New DataGridView()
        hapusBtn = New Button()
        ubahBtn = New Button()
        tambahBtn = New Button()
        nilaiField = New TextBox()
        Label4 = New Label()
        nimField = New TextBox()
        Label3 = New Label()
        idMatkulField = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(256, 504)
        Label6.Name = "Label6"
        Label6.Size = New Size(303, 45)
        Label6.TabIndex = 55
        Label6.Text = "TOMBOL ARAHAN"
        ' 
        ' formLaporanBtn
        ' 
        formLaporanBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formLaporanBtn.Location = New Point(509, 552)
        formLaporanBtn.Name = "formLaporanBtn"
        formLaporanBtn.Size = New Size(120, 60)
        formLaporanBtn.TabIndex = 54
        formLaporanBtn.Text = "FORM LAPORAN"
        formLaporanBtn.UseVisualStyleBackColor = True
        ' 
        ' formMatkulBtn
        ' 
        formMatkulBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formMatkulBtn.Location = New Point(382, 552)
        formMatkulBtn.Name = "formMatkulBtn"
        formMatkulBtn.Size = New Size(120, 60)
        formMatkulBtn.TabIndex = 53
        formMatkulBtn.Text = "FORM MATKUL"
        formMatkulBtn.UseVisualStyleBackColor = True
        ' 
        ' formMhsBtn
        ' 
        formMhsBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formMhsBtn.Location = New Point(256, 552)
        formMhsBtn.Name = "formMhsBtn"
        formMhsBtn.Size = New Size(120, 60)
        formMhsBtn.TabIndex = 52
        formMhsBtn.Text = "FORM MHS"
        formMhsBtn.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(782, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(374, 45)
        Label8.TabIndex = 51
        Label8.Text = "TAMPILAN DATA NILAI"
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(698, 115)
        dgv.Name = "dgv"
        dgv.RowTemplate.Height = 25
        dgv.Size = New Size(739, 497)
        dgv.TabIndex = 50
        ' 
        ' hapusBtn
        ' 
        hapusBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        hapusBtn.Location = New Point(508, 273)
        hapusBtn.Name = "hapusBtn"
        hapusBtn.Size = New Size(120, 47)
        hapusBtn.TabIndex = 49
        hapusBtn.Text = "HAPUS"
        hapusBtn.UseVisualStyleBackColor = True
        ' 
        ' ubahBtn
        ' 
        ubahBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ubahBtn.Location = New Point(382, 273)
        ubahBtn.Name = "ubahBtn"
        ubahBtn.Size = New Size(120, 47)
        ubahBtn.TabIndex = 48
        ubahBtn.Text = "UBAH"
        ubahBtn.UseVisualStyleBackColor = True
        ' 
        ' tambahBtn
        ' 
        tambahBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        tambahBtn.Location = New Point(256, 273)
        tambahBtn.Name = "tambahBtn"
        tambahBtn.Size = New Size(120, 47)
        tambahBtn.TabIndex = 47
        tambahBtn.Text = "TAMBAH"
        tambahBtn.UseVisualStyleBackColor = True
        ' 
        ' nilaiField
        ' 
        nilaiField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        nilaiField.Location = New Point(250, 205)
        nilaiField.Name = "nilaiField"
        nilaiField.Size = New Size(379, 39)
        nilaiField.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(100, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 32)
        Label4.TabIndex = 43
        Label4.Text = "NILAI"
        ' 
        ' nimField
        ' 
        nimField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        nimField.Location = New Point(250, 160)
        nimField.Name = "nimField"
        nimField.Size = New Size(379, 39)
        nimField.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(100, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 32)
        Label3.TabIndex = 41
        Label3.Text = "NIM MHS"
        ' 
        ' idMatkulField
        ' 
        idMatkulField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        idMatkulField.Location = New Point(250, 115)
        idMatkulField.Name = "idMatkulField"
        idMatkulField.Size = New Size(379, 39)
        idMatkulField.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(100, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 32)
        Label2.TabIndex = 39
        Label2.Text = "ID MATKUL"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(25, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 45)
        Label1.TabIndex = 38
        Label1.Text = "INPUT DATA NILAI"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1462, 639)
        Controls.Add(Label6)
        Controls.Add(formLaporanBtn)
        Controls.Add(formMatkulBtn)
        Controls.Add(formMhsBtn)
        Controls.Add(Label8)
        Controls.Add(dgv)
        Controls.Add(hapusBtn)
        Controls.Add(ubahBtn)
        Controls.Add(tambahBtn)
        Controls.Add(nilaiField)
        Controls.Add(Label4)
        Controls.Add(nimField)
        Controls.Add(Label3)
        Controls.Add(idMatkulField)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents formLaporanBtn As Button
    Friend WithEvents formMatkulBtn As Button
    Friend WithEvents formMhsBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents hapusBtn As Button
    Friend WithEvents ubahBtn As Button
    Friend WithEvents tambahBtn As Button
    Friend WithEvents nilaiField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nimField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents idMatkulField As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
