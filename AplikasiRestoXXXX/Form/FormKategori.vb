Public Class FormKategori
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        GroupBox1.Enabled = st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKategori.Rows(br)
                txtIDKategori.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
            End With
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = kontrolKategori.TampilData.ToTable
        DGKategori.DataSource = DTGrid
    End Sub
    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class