<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label8 = New Label()
        dgv = New DataGridView()
        hapusBtn = New Button()
        ubahBtn = New Button()
        tambahBtn = New Button()
        semesterField = New TextBox()
        Label5 = New Label()
        sksField = New TextBox()
        Label4 = New Label()
        namaField = New TextBox()
        Label3 = New Label()
        idField = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        formMhsBtn = New Button()
        formNilaiBtn = New Button()
        formLaporanBtn = New Button()
        Label6 = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(768, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(420, 45)
        Label8.TabIndex = 33
        Label8.Text = "TAMPILAN DATA MATKUL"
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(684, 111)
        dgv.Name = "dgv"
        dgv.RowTemplate.Height = 25
        dgv.Size = New Size(739, 497)
        dgv.TabIndex = 32
        ' 
        ' hapusBtn
        ' 
        hapusBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        hapusBtn.Location = New Point(494, 317)
        hapusBtn.Name = "hapusBtn"
        hapusBtn.Size = New Size(120, 47)
        hapusBtn.TabIndex = 31
        hapusBtn.Text = "HAPUS"
        hapusBtn.UseVisualStyleBackColor = True
        ' 
        ' ubahBtn
        ' 
        ubahBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ubahBtn.Location = New Point(368, 317)
        ubahBtn.Name = "ubahBtn"
        ubahBtn.Size = New Size(120, 47)
        ubahBtn.TabIndex = 30
        ubahBtn.Text = "UBAH"
        ubahBtn.UseVisualStyleBackColor = True
        ' 
        ' tambahBtn
        ' 
        tambahBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        tambahBtn.Location = New Point(242, 317)
        tambahBtn.Name = "tambahBtn"
        tambahBtn.Size = New Size(120, 47)
        tambahBtn.TabIndex = 29
        tambahBtn.Text = "TAMBAH"
        tambahBtn.UseVisualStyleBackColor = True
        ' 
        ' semesterField
        ' 
        semesterField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        semesterField.Location = New Point(236, 246)
        semesterField.Name = "semesterField"
        semesterField.Size = New Size(379, 39)
        semesterField.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(86, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 32)
        Label5.TabIndex = 25
        Label5.Text = "SEMESTER"
        ' 
        ' sksField
        ' 
        sksField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        sksField.Location = New Point(236, 201)
        sksField.Name = "sksField"
        sksField.Size = New Size(379, 39)
        sksField.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(86, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 32)
        Label4.TabIndex = 23
        Label4.Text = "SKS"
        ' 
        ' namaField
        ' 
        namaField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        namaField.Location = New Point(236, 156)
        namaField.Name = "namaField"
        namaField.Size = New Size(379, 39)
        namaField.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(86, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 32)
        Label3.TabIndex = 21
        Label3.Text = "NAMA"
        ' 
        ' idField
        ' 
        idField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        idField.Location = New Point(236, 111)
        idField.Name = "idField"
        idField.Size = New Size(379, 39)
        idField.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(86, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 32)
        Label2.TabIndex = 19
        Label2.Text = "ID (UID)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(11, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 45)
        Label1.TabIndex = 18
        Label1.Text = "INPUT DATA MATKUL"
        ' 
        ' formMhsBtn
        ' 
        formMhsBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formMhsBtn.Location = New Point(242, 548)
        formMhsBtn.Name = "formMhsBtn"
        formMhsBtn.Size = New Size(120, 60)
        formMhsBtn.TabIndex = 34
        formMhsBtn.Text = "FORM MHS"
        formMhsBtn.UseVisualStyleBackColor = True
        ' 
        ' formNilaiBtn
        ' 
        formNilaiBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formNilaiBtn.Location = New Point(368, 548)
        formNilaiBtn.Name = "formNilaiBtn"
        formNilaiBtn.Size = New Size(120, 60)
        formNilaiBtn.TabIndex = 35
        formNilaiBtn.Text = "FORM NILAI"
        formNilaiBtn.UseVisualStyleBackColor = True
        ' 
        ' formLaporanBtn
        ' 
        formLaporanBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formLaporanBtn.Location = New Point(495, 548)
        formLaporanBtn.Name = "formLaporanBtn"
        formLaporanBtn.Size = New Size(120, 60)
        formLaporanBtn.TabIndex = 36
        formLaporanBtn.Text = "FORM LAPORAN"
        formLaporanBtn.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(242, 500)
        Label6.Name = "Label6"
        Label6.Size = New Size(303, 45)
        Label6.TabIndex = 37
        Label6.Text = "TOMBOL ARAHAN"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1443, 635)
        Controls.Add(Label6)
        Controls.Add(formLaporanBtn)
        Controls.Add(formNilaiBtn)
        Controls.Add(formMhsBtn)
        Controls.Add(Label8)
        Controls.Add(dgv)
        Controls.Add(hapusBtn)
        Controls.Add(ubahBtn)
        Controls.Add(tambahBtn)
        Controls.Add(semesterField)
        Controls.Add(Label5)
        Controls.Add(sksField)
        Controls.Add(Label4)
        Controls.Add(namaField)
        Controls.Add(Label3)
        Controls.Add(idField)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents hapusBtn As Button
    Friend WithEvents ubahBtn As Button
    Friend WithEvents tambahBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents semesterField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sksField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents namaField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents idField As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents formMhsBtn As Button
    Friend WithEvents formNilaiBtn As Button
    Friend WithEvents formLaporanBtn As Button
End Class
