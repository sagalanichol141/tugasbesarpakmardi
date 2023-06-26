Imports System.Data.SqlClient

Public Class Form2
    Dim conn As SqlConnection = New SqlConnection("Data Source=NICHOLASSAGALA; " &
                    "user id=sa; password=12345678; Integrated Security=True; " & "database=SIA")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub

    Private Sub tambahBtn_Click(sender As Object, e As EventArgs) Handles tambahBtn.Click
        ' Cek apakah semua field telah diisi
        If String.IsNullOrWhiteSpace(idField.Text) OrElse
            String.IsNullOrWhiteSpace(namaField.Text) OrElse
            String.IsNullOrWhiteSpace(sksField.Text) OrElse
            String.IsNullOrWhiteSpace(semesterField.Text) Then
            MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buat query untuk memasukkan data ke tabel "matkul"
        Dim query As String = "INSERT INTO matkul (id, nama, sks, semester) VALUES (@id, @nama, @sks, @semester)"

        ' Buat objek SqlCommand dan sambungkan dengan koneksi
        Dim cmd As New SqlCommand(query, conn)

        ' Tambahkan parameter ke query
        cmd.Parameters.AddWithValue("@id", idField.Text)
        cmd.Parameters.AddWithValue("@nama", namaField.Text)
        cmd.Parameters.AddWithValue("@sks", sksField.Text)
        cmd.Parameters.AddWithValue("@semester", semesterField.Text)

        Try
            ' Buka koneksi ke database
            conn.Open()

            ' Eksekusi perintah SQL untuk menambahkan data
            cmd.ExecuteNonQuery()

            ' Tampilkan data melalui DataGridView
            RefreshDataGridView()

            ' Kosongkan TextBox setelah data berhasil ditambahkan
            idField.Text = ""
            namaField.Text = ""
            sksField.Text = ""
            semesterField.Text = ""

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

        ' Buat query untuk mengambil data dari tabel "matkul"
        Dim query As String = "SELECT * FROM matkul"

        ' Buat objek SqlDataAdapter dan sambungkan dengan koneksi
        ADP = New SqlDataAdapter(query, conn)

        ' Isi DataSet dengan data dari tabel "matkul"
        ADP.Fill(DS, "matkul")

        ' Tampilkan data dalam DataGridView
        dgv.DataSource = DS.Tables("matkul")
    End Sub

    Private Sub ubahBtn_Click(sender As Object, e As EventArgs) Handles ubahBtn.Click
        ' Cek apakah ID telah diisi
        If String.IsNullOrWhiteSpace(idField.Text) Then
            MessageBox.Show("Harap isi ID.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek apakah semua field telah diisi
        If String.IsNullOrWhiteSpace(namaField.Text) OrElse
            String.IsNullOrWhiteSpace(sksField.Text) OrElse
            String.IsNullOrWhiteSpace(semesterField.Text) Then
            MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buat query untuk mengubah data dalam tabel "matkul"
        Dim query As String = "UPDATE matkul SET nama = @nama, sks = @sks, semester = @semester WHERE id = @id"

        ' Buat objek SqlCommand dan sambungkan dengan koneksi
        Dim cmd As New SqlCommand(query, conn)

        ' Tambahkan parameter ke query
        cmd.Parameters.AddWithValue("@nama", namaField.Text)
        cmd.Parameters.AddWithValue("@sks", sksField.Text)
        cmd.Parameters.AddWithValue("@semester", semesterField.Text)
        cmd.Parameters.AddWithValue("@id", idField.Text)

        Try
            ' Buka koneksi ke database
            conn.Open()

            ' Eksekusi perintah SQL untuk mengubah data
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Cek jumlah baris yang terpengaruh
            If rowsAffected > 0 Then
                ' Tampilkan data melalui DataGridView setelah perubahan berhasil
                RefreshDataGridView()

                MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data dengan ID tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi ke database
            conn.Close()
        End Try
    End Sub

    Private Sub hapusBtn_Click(sender As Object, e As EventArgs) Handles hapusBtn.Click
        ' Cek apakah ID telah diisi
        If String.IsNullOrWhiteSpace(idField.Text) Then
            MessageBox.Show("Harap isi ID.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Konfirmasi penghapusan data
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data dengan ID ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Buat query untuk menghapus data dalam tabel "matkul"
            Dim query As String = "DELETE FROM matkul WHERE id = @id"

            ' Buat objek SqlCommand dan sambungkan dengan koneksi
            Dim cmd As New SqlCommand(query, conn)

            ' Tambahkan parameter ke query
            cmd.Parameters.AddWithValue("@id", idField.Text)

            Try
                ' Buka koneksi ke database
                conn.Open()

                ' Eksekusi perintah SQL untuk menghapus data
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Cek jumlah baris yang terpengaruh
                If rowsAffected > 0 Then
                    ' Tampilkan data melalui DataGridView setelah penghapusan berhasil
                    RefreshDataGridView()

                    MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data dengan ID tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub formNilaiBtn_Click(sender As Object, e As EventArgs) Handles formNilaiBtn.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub

    Private Sub formLaporanBtn_Click(sender As Object, e As EventArgs) Handles formLaporanBtn.Click
        Dim form4 As New Form4()
        form4.Show()
    End Sub
End Class
