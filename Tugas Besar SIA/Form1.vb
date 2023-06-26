Imports System.Data.SqlClient

Public Class Form1
    Dim conn As SqlConnection = New SqlConnection("Data Source=NICHOLASSAGALA; " &
                    "user id=sa; password=12345678; Integrated Security=True; " & "database=SIA")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub

    Private Sub tambahBtn_Click(sender As Object, e As EventArgs) Handles tambahBtn.Click
        ' Cek apakah semua field telah diisi
        If String.IsNullOrWhiteSpace(nimField.Text) OrElse
            String.IsNullOrWhiteSpace(namaField.Text) OrElse
            String.IsNullOrWhiteSpace(kelasField.Text) OrElse
            String.IsNullOrWhiteSpace(jurusanField.Text) OrElse
            String.IsNullOrWhiteSpace(prodiField.Text) Then
            MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buat query untuk memasukkan data ke tabel "mhs"
        Dim query As String = "INSERT INTO mhs (nim, nama, kelas, jurusan, prodi) VALUES (@nim, @nama, @kelas, @jurusan, @prodi)"

        ' Buat objek SqlCommand dan sambungkan dengan koneksi
        Dim cmd As New SqlCommand(query, conn)

        ' Tambahkan parameter ke query
        cmd.Parameters.AddWithValue("@nim", nimField.Text)
        cmd.Parameters.AddWithValue("@nama", namaField.Text)
        cmd.Parameters.AddWithValue("@kelas", kelasField.Text)
        cmd.Parameters.AddWithValue("@jurusan", jurusanField.Text)
        cmd.Parameters.AddWithValue("@prodi", prodiField.Text)

        Try
            ' Buka koneksi ke database
            conn.Open()

            ' Eksekusi perintah SQL untuk menambahkan data
            cmd.ExecuteNonQuery()

            ' Tampilkan data melalui DataGridView
            RefreshDataGridView()

            ' Kosongkan TextBox setelah data berhasil ditambahkan
            nimField.Text = ""
            namaField.Text = ""
            kelasField.Text = ""
            jurusanField.Text = ""
            prodiField.Text = ""

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

        ' Buat query untuk mengambil data dari tabel "mhs"
        Dim query As String = "SELECT * FROM mhs"

        ' Buat objek SqlDataAdapter dan sambungkan dengan koneksi
        ADP = New SqlDataAdapter(query, conn)

        ' Isi DataSet dengan data dari tabel "mhs"
        ADP.Fill(DS, "mhs")

        ' Tampilkan data dalam DataGridView
        dgv.DataSource = DS.Tables("mhs")
    End Sub

    Private Sub ubahBtn_Click(sender As Object, e As EventArgs) Handles ubahBtn.Click
        ' Cek apakah NIM telah diisi
        If String.IsNullOrWhiteSpace(nimField.Text) Then
            MessageBox.Show("Harap isi NIM.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek apakah semua field telah diisi
        If String.IsNullOrWhiteSpace(namaField.Text) OrElse
            String.IsNullOrWhiteSpace(kelasField.Text) OrElse
            String.IsNullOrWhiteSpace(jurusanField.Text) OrElse
            String.IsNullOrWhiteSpace(prodiField.Text) Then
            MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buat query untuk mengubah data dalam tabel "mhs"
        Dim query As String = "UPDATE mhs SET nama = @nama, kelas = @kelas, jurusan = @jurusan, prodi = @prodi WHERE nim = @nim"

        ' Buat objek SqlCommand dan sambungkan dengan koneksi
        Dim cmd As New SqlCommand(query, conn)

        ' Tambahkan parameter ke query
        cmd.Parameters.AddWithValue("@nama", namaField.Text)
        cmd.Parameters.AddWithValue("@kelas", kelasField.Text)
        cmd.Parameters.AddWithValue("@jurusan", jurusanField.Text)
        cmd.Parameters.AddWithValue("@prodi", prodiField.Text)
        cmd.Parameters.AddWithValue("@nim", nimField.Text)

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
                MessageBox.Show("Data dengan NIM tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi ke database
            conn.Close()
        End Try
    End Sub

    Private Sub hapusBtn_Click(sender As Object, e As EventArgs) Handles hapusBtn.Click
        ' Cek apakah NIM telah diisi
        If String.IsNullOrWhiteSpace(nimField.Text) Then
            MessageBox.Show("Harap isi NIM.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Konfirmasi penghapusan data
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data dengan NIM ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Buat query untuk menghapus data dalam tabel "mhs"
            Dim query As String = "DELETE FROM mhs WHERE nim = @nim"

            ' Buat objek SqlCommand dan sambungkan dengan koneksi
            Dim cmd As New SqlCommand(query, conn)

            ' Tambahkan parameter ke query
            cmd.Parameters.AddWithValue("@nim", nimField.Text)

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
                    MessageBox.Show("Data dengan NIM tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Tutup koneksi ke database
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub formMatkulBtn_Click(sender As Object, e As EventArgs) Handles formMatkulBtn.Click
        Dim form2 As New Form2()
        form2.Show()
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