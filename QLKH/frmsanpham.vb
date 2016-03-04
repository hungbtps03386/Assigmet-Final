Imports System.Data.SqlClient
Imports System.Data.DataTable
Class frmsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=hung;Initial Catalog=hungbtps03386;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select Ma_SP,Ten_SP,So_Luong,Mo_Ta,Ma_LSP from dbo.San_Pham", conn)
        db.Clear()
        refesh.Fill(db)
        drvsanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        conn.Open()
        Dim sql As String = "select * from dbo.San_Pham where Ten_SP like '%" & txttimkiem.Text & "%' "
        Dim danhsach As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        drvsanpham.DataSource = db.DefaultView
        db.Clear()
        danhsach.Fill(db)
        conn.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs)

    End Sub
End Class