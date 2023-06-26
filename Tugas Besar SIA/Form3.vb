Imports System.Data.SqlClient

Public Class Form3
    Dim conn As SqlConnection = New SqlConnection("Data Source=NICHOLASSAGALA; " &
                    "user id=sa; password=12345678; Integrated Security=True; " & "database=SIA")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub

    Private Sub tambahBtn_Click(sender As Object, e As EventArgs) Handles tambahBtn.Click
        ' Cek apakah semua field telah diisi
        If String.IsNullOrWhiteSpace(nimField.Text) OrElse
            String.IsNullOrWhiteSpace(idMatkulField.Text) OrElse
            String.IsNullOrWhiteSpace(nilaiField.Text) Then
            MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buat query untuk memasukkan data ke tabel "nilai"
        Dim query As String = "INSERT INTO nilai (nim, idMatkul, nilai) VALUES (@nim, @idMatkul, @nilai)"

        ' Buat objek SqlCommand dan sambungkan dengan koneksi
        Dim cmd As New SqlCommand(query, conn)

        ' Tambahkan parameter ke query
        cmd.Parameters.AddWithValue("@nim", nimField.Text)
        cmd.Parameters.AddWithValue("@idMatkul", idMatkulField.Text)
        cmd.Parameters.AddWithValue("@nilai", nilaiField.Text)

        Try
            ' Buka koneksi ke database
            conn.Open()

            ' Eksekusi perintah SQL untuk menambahkan data
            cmd.ExecuteNonQuery()

            ' Tampilkan data melalui DataGridView
            RefreshDataGridView()

            ' Kosongkan TextBox setelah data berhasil ditambahkan
            nimField.Text = ""
            idMatkulField.Text = ""
            nilaiField.Text = ""

            MessageBox.Show("Data berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi ke database
            conn.Close()
        End Try
    End Sub

    Private Sub RefreshDataGridView()
        ' Kosongkan DataSet sebelum mengisi dengan data baru
        DS.Clear()

        ' Buat query untuk mengambil data dari tabel "nilai"
        Dim query As String = "SELECT * FROM nilai"

        ' Buat objek SqlDataAdapter dan sambungkan dengan koneksi
        ADP = New SqlDataAdapter(query, conn)

        ' Isi DataSet dengan data dari tabel "nilai"
        ADP.Fill(DS, "nilai")

        ' Tampilkan data dalam DataGridView
        dgv.DataSource = DS.Tables("nilai")
    End Sub

    Private Sub hapusBtn_Click(sender As Object, e As EventArgs) Handles hapusBtn.Click
        ' Cek apakah NIM dan ID Matkul telah diisi
        If String.IsNullOrWhiteSpace(nimField.Text) OrElse
            String.IsNullOrWhiteSpace(idMatkulField.Text) Then
            MessageBox.Show("Harap isi NIM dan ID Mata Kuliah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Konfirmasi penghapusan data
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data dengan NIM dan ID Mata Kuliah ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna mengonfirmasi penghapusan data, lanjutkan dengan proses penghapusan
        If result = DialogResult.Yes Then
            ' Buat query untuk menghapus data dari tabel "nilai"
            Dim query As String = "DELETE FROM nilai WHERE nim = @nim AND idMatkul = @idMatkul"

            ' Buat objek SqlCommand dan sambungkan dengan koneksi
            Dim cmd As New SqlCommand(query, conn)

            ' Tambahkan parameter ke query
            cmd.Parameters.AddWithValue("@nim", nimField.Text)
            cmd.Parameters.AddWithValue("@idMatkul", idMatkulField.Text)

            Try
                ' Buka koneksi ke database
                conn.Open()

                ' Eksekusi perintah SQL untuk menghapus data
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Tampilkan data melalui DataGridView
                RefreshDataGridView()

                ' Kosongkan TextBox setelah data berhasil dihapus
                nimField.Text = ""
                idMatkulField.Text = ""
                nilaiField.Text = ""

                If rowsAffected > 0 Then
                    MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Tutup koneksi ke database
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub formMhsBtn_Click(sender As Object, e As EventArgs) Handles formMhsBtn.Click
        Dim form1 As New Form1() ' Membuat objek Form1 baru
        form1.Show() ' Menampilkan Form1
    End Sub

    Private Sub formLaporanBtn_Click(sender As Object, e As EventArgs) Handles formLaporanBtn.Click
        Dim form4 As New Form4()
        form4.Show()
    End Sub

    Private Sub formMatkulBtn_Click(sender As Object, e As EventArgs) Handles formMatkulBtn.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub
End Class
