Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class frmcapnhatsp
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=hung;Initial Catalog=hungbtps03386;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmthem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select Ma_SP,Ten_SP,So_Luong,Mo_Ta,Ma_LSP from dbo.San_Pham", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsp.DataSource = db.DefaultView
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into San_Pham values(@Ma_SP,@Ten_SP,@So_Luong,@Mo_Ta,@Ma_LSP)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        ' Try
        txtmasp.Focus()
        If txtmasp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            txtmasp.Focus()
            If txttensp.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Else
                txtsoluong.Focus()
                If txtsoluong.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập địa chỉ ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else
                    txtsoluong.Focus()
                    If txtmota.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Else
                        txtmota.Focus()
                        If txtmlsp.Text = " " Then
                            MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                    Else
                            save.Parameters.AddWithValue("@Ma_SP", txtmasp.Text)
                            save.Parameters.AddWithValue("@Ten_SP", txttensp.Text)
                            save.Parameters.AddWithValue("@So_Luong", txtsoluong.Text)
                            save.Parameters.AddWithValue("@Mo_Ta", txtmota.Text)
                            save.Parameters.AddWithValue("@Ma_LSP", txtmlsp.Text)
                        save.ExecuteNonQuery()
                        MessageBox.Show("Lưu thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtmasp.Text = Nothing
                            txttensp.Text = Nothing
                            txtsoluong.Text = Nothing
                            txtmota.Text = Nothing
                            txtmlsp.Text = Nothing
                        End If
                    End If
                End If
            End If
        End If
        ' Catch ex As Exception  'Ngược lại báo lỗi
        ' MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        ' End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select Ma_SP ,Ten_SP , So_Luong, Mo_Ta, Ma_LSP from dbo.San_Pham", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsp.DataSource = db.DefaultView

    End Sub
    'thêm sự kiên load Data
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select Ma_SP ,Ten_SP,So_Luong,Mo_Ta,Ma_LSP from dbo.San_Pham", conn)

        conn.Open()
        load.Fill(db)
        dgvsp.DataSource = db.DefaultView
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update dbo.San_Pham set Ma_SP = @Ma_SP,Ten_SP = @Ten_SP,So_Luong = @So_Luong,Mo_Ta = @Mo_Ta,Ma_LSP = @Ma_LSP where Ma_SP=@Ma_SP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        'Try
        txtmasp.Focus()
        If txtmasp.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            If txttensp.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txttensp.Focus()
                If txtsoluong.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtmota.Focus()
                    If txtmota.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập miêu tả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtmlsp.Focus()
                        If txtmlsp.Text = " " Then
                            MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        Else
                            addupdate.Parameters.AddWithValue("@MA_SP", txtmasp.Text)
                            addupdate.Parameters.AddWithValue("@TEN_SP", txttensp.Text)
                            addupdate.Parameters.AddWithValue("@So_Luong", txtsoluong.Text)
                            addupdate.Parameters.AddWithValue("@Mo_Ta", txtmota.Text)
                            addupdate.Parameters.AddWithValue("@Ma_LSP", txtmlsp.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtmasp.Text = Nothing
                            txttensp.Text = Nothing
                            txtsoluong.Text = Nothing
                            txtmota.Text = Nothing
                            txtmlsp.Text = Nothing
                        End If
                    End If
                End If
            End If
        End If
        'Catch ex As Exception
        ' MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvsp.DataSource = db
        dgvsp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from San_Pham where Ma_SP=@MA_SP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        ' Try
        If txtmasp.Text = "" Then
            MessageBox.Show("Bạn cần nhập vào tên sản phẩm muốn xóa", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtmasp.Focus()
        Else
            If resulft = Windows.Forms.DialogResult.Yes Then
                delete.Parameters.AddWithValue("@MA_SP", txtmasp.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                txtmasp.Text = Nothing
                txttensp.Text = Nothing
                txtsoluong.Text = Nothing
                txtmota.Text = Nothing
                txtmlsp.Text = Nothing
                txtmasp.Focus()
            End If
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End If
        ' Catch ex As Exception
        ' MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'làm mới bảng
        db.Clear()
        dgvsp.DataSource = db
        dgvsp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        conn.Open()
        Dim sql As String = "select Ma_SP,Ten_SP,So_Luong,Mo_Ta,Ma_LSP from San_Pham where Ten_SP like '%" & txttimkiem.Text & "%' "
        Dim danhsach As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        dgvsp.DataSource = db.DefaultView
        db.Clear()
        danhsach.Fill(db)
        conn.Close()
    End Sub

    Private Sub dgvsp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsp.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtmlsp.TextChanged

    End Sub
End Class