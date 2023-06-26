<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label2 = New Label()
        nimField = New TextBox()
        namaField = New TextBox()
        Label3 = New Label()
        kelasField = New TextBox()
        Label4 = New Label()
        jurusanField = New TextBox()
        Label5 = New Label()
        prodiField = New TextBox()
        Label6 = New Label()
        tambahBtn = New Button()
        ubahBtn = New Button()
        hapusBtn = New Button()
        dgv = New DataGridView()
        Label8 = New Label()
        formLaporanBtn = New Button()
        formNilaiBtn = New Button()
        formMatkulBtn = New Button()
        Label7 = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(30, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(422, 45)
        Label1.TabIndex = 0
        Label1.Text = "INPUT DATA MAHASISWA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(105, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 32)
        Label2.TabIndex = 1
        Label2.Text = "NIM (UID)"
        ' 
        ' nimField
        ' 
        nimField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        nimField.Location = New Point(255, 125)
        nimField.Name = "nimField"
        nimField.Size = New Size(379, 39)
        nimField.TabIndex = 2
        ' 
        ' namaField
        ' 
        namaField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        namaField.Location = New Point(255, 170)
        namaField.Name = "namaField"
        namaField.Size = New Size(379, 39)
        namaField.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(105, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 32)
        Label3.TabIndex = 3
        Label3.Text = "NAMA"
        ' 
        ' kelasField
        ' 
        kelasField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        kelasField.Location = New Point(255, 215)
        kelasField.Name = "kelasField"
        kelasField.Size = New Size(379, 39)
        kelasField.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(105, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 32)
        Label4.TabIndex = 5
        Label4.Text = "KELAS"
        ' 
        ' jurusanField
        ' 
        jurusanField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        jurusanField.Location = New Point(255, 260)
        jurusanField.Name = "jurusanField"
        jurusanField.Size = New Size(379, 39)
        jurusanField.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(105, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 32)
        Label5.TabIndex = 7
        Label5.Text = "JURUSAN"
        ' 
        ' prodiField
        ' 
        prodiField.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        prodiField.Location = New Point(255, 305)
        prodiField.Name = "prodiField"
        prodiField.Size = New Size(379, 39)
        prodiField.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(105, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 32)
        Label6.TabIndex = 9
        Label6.Text = "PRODI"
        ' 
        ' tambahBtn
        ' 
        tambahBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        tambahBtn.Location = New Point(262, 370)
        tambahBtn.Name = "tambahBtn"
        tambahBtn.Size = New Size(120, 47)
        tambahBtn.TabIndex = 13
        tambahBtn.Text = "TAMBAH"
        tambahBtn.UseVisualStyleBackColor = True
        ' 
        ' ubahBtn
        ' 
        ubahBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ubahBtn.Location = New Point(388, 370)
        ubahBtn.Name = "ubahBtn"
        ubahBtn.Size = New Size(120, 47)
        ubahBtn.TabIndex = 14
        ubahBtn.Text = "UBAH"
        ubahBtn.UseVisualStyleBackColor = True
        ' 
        ' hapusBtn
        ' 
        hapusBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        hapusBtn.Location = New Point(514, 370)
        hapusBtn.Name = "hapusBtn"
        hapusBtn.Size = New Size(120, 47)
        hapusBtn.TabIndex = 15
        hapusBtn.Text = "HAPUS"
        hapusBtn.UseVisualStyleBackColor = True
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(703, 125)
        dgv.Name = "dgv"
        dgv.RowTemplate.Height = 25
        dgv.Size = New Size(739, 497)
        dgv.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(787, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(491, 45)
        Label8.TabIndex = 17
        Label8.Text = "TAMPILAN DATA MAHASISWA"
        ' 
        ' formLaporanBtn
        ' 
        formLaporanBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formLaporanBtn.Location = New Point(515, 562)
        formLaporanBtn.Name = "formLaporanBtn"
        formLaporanBtn.Size = New Size(120, 60)
        formLaporanBtn.TabIndex = 39
        formLaporanBtn.Text = "FORM LAPORAN"
        formLaporanBtn.UseVisualStyleBackColor = True
        ' 
        ' formNilaiBtn
        ' 
        formNilaiBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formNilaiBtn.Location = New Point(388, 562)
        formNilaiBtn.Name = "formNilaiBtn"
        formNilaiBtn.Size = New Size(120, 60)
        formNilaiBtn.TabIndex = 38
        formNilaiBtn.Text = "FORM NILAI"
        formNilaiBtn.UseVisualStyleBackColor = True
        ' 
        ' formMatkulBtn
        ' 
        formMatkulBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        formMatkulBtn.Location = New Point(262, 562)
        formMatkulBtn.Name = "formMatkulBtn"
        formMatkulBtn.Size = New Size(120, 60)
        formMatkulBtn.TabIndex = 37
        formMatkulBtn.Text = "FORM MATKUL"
        formMatkulBtn.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(262, 514)
        Label7.Name = "Label7"
        Label7.Size = New Size(303, 45)
        Label7.TabIndex = 40
        Label7.Text = "TOMBOL ARAHAN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1454, 634)
        Controls.Add(Label7)
        Controls.Add(formLaporanBtn)
        Controls.Add(formNilaiBtn)
        Controls.Add(formMatkulBtn)
        Controls.Add(Label8)
        Controls.Add(dgv)
        Controls.Add(hapusBtn)
        Controls.Add(ubahBtn)
        Controls.Add(tambahBtn)
        Controls.Add(prodiField)
        Controls.Add(Label6)
        Controls.Add(jurusanField)
        Controls.Add(Label5)
        Controls.Add(kelasField)
        Controls.Add(Label4)
        Controls.Add(namaField)
        Controls.Add(Label3)
        Controls.Add(nimField)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nimField As TextBox
    Friend WithEvents namaField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kelasField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents jurusanField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents prodiField As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tambahBtn As Button
    Friend WithEvents ubahBtn As Button
    Friend WithEvents hapusBtn As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents formLaporanBtn As Button
    Friend WithEvents formNilaiBtn As Button
    Friend WithEvents formMatkulBtn As Button
    Friend WithEvents Label7 As Label
End Class
