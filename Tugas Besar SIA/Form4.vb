Imports System.Data.SqlClient

Public Class Form4
    Dim conn As SqlConnection = New SqlConnection("Data Source=NICHOLASSAGALA; " &
                    "user id=sa; password=12345678; Integrated Security=True; " & "database=SIA")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub

    Private Sub RefreshDataGridView()
        ' Kosongkan DataSet sebelum mengisi dengan data baru
        DS.Clear()

        ' Buat query untuk mengambil data dari tabel "nilai"
        Dim query As String = "SELECT m.nim, m.nama, mk.nama AS 'matkul', n.nilai FROM mhs m " &
                              "INNER JOIN nilai n ON m.nim = n.nim " &
                              "INNER JOIN matkul mk ON n.idMatkul = mk.id"

        ' Buat objek SqlDataAdapter dan sambungkan dengan koneksi
        ADP = New SqlDataAdapter(query, conn)

        ' Isi DataSet dengan data dari tabel "nilai"
        ADP.Fill(DS, "nilai")

        ' Tampilkan data dalam DataGridView
        dgv.DataSource = DS.Tables("nilai")
    End Sub

    Private Sub formMhsBtn_Click(sender As Object, e As EventArgs) Handles formMhsBtn.Click
        Dim form1 As New Form1() ' Membuat objek Form1 baru
        form1.Show() ' Menampilkan Form1
    End Sub

    Private Sub formMatkulBtn_Click(sender As Object, e As EventArgs) Handles formMatkulBtn.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    Private Sub formNilaiBtn_Click(sender As Object, e As EventArgs) Handles formNilaiBtn.Click
        Dim form1 As New Form1()
        form1.Show()
    End Sub

End Class
