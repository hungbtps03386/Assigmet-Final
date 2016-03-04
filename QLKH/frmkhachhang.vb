Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmkhachhang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=hung;Initial Catalog=hungbtps03386;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select Ma_KH,Ten_KH,Dia_Chi,SDT from dbo.Khach_Hang", conn)
        db.Clear()
        refesh.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
    End Sub

    Private Sub dgvkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick

    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        conn.Open()
        Dim sql As String = "select * from Khach_Hang where Ten_KH like '%" & txttimkiem.Text & "%' "
        Dim danhsach As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        dgvkhachhang.DataSource = db.DefaultView
        db.Clear()
        danhsach.Fill(db)
        conn.Close()
    End Sub
End Class