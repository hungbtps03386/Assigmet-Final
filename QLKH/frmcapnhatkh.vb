Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class frmcapnhatkh
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=hung;Initial Catalog=hungbtps03386;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmthem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select Ma_KH,Ten_KH,Dia_Chi,SDT from dbo.Khach_Hang", conn)
        db.Clear()
        refesh.Fill(db)
        dgvkh.DataSource = db.DefaultView
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into Khach_Hang values(@Ma_KH,@Ten_KH,@Dia_Chi,@SDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        ' Try
        txtmakh.Focus()
        If txtmakh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            txtmakh.Focus()
            If txttenkh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtdiachi.Focus()
                If txtdiachi.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập địa chỉ ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtdiachi.Focus()
                    If txtsdt.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        txtsdt.Focus()
                    Else
                        save.Parameters.AddWithValue("@Ma_KH", txtmakh.Text)
                        save.Parameters.AddWithValue("@Ten_KH", txttenkh.Text)
                        save.Parameters.AddWithValue("@Dia_Chi", txtdiachi.Text)
                        save.Parameters.AddWithValue("@SDT", txtsdt.Text)
                        save.ExecuteNonQuery()
                        MessageBox.Show("Lưu thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                        txtmakh.Text = Nothing
                        txttenkh.Text = Nothing
                        txtdiachi.Text = Nothing
                        txtsdt.Text = Nothing


                    End If
                End If
            End If
        End If
        ' Catch ex As Exception  'Ngược lại báo lỗi
        ' MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        ' End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select Ma_KH ,Ten_KH , Dia_chi, SDT from Khach_Hang", conn)
        db.Clear()
        refesh.Fill(db)
        dgvkh.DataSource = db.DefaultView

    End Sub
    'thêm sự kiên load Data
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select Ma_KH ,Ten_KH, Dia_Chi, SDT from dbo.Khach_Hang", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update dbo.Khach_Hang set Ma_KH = @Ma_KH,Ten_KH = @Ten_KH,Dia_Chi = @Dia_Chi,SDT = @SDT where Ma_KH=@Ma_KH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        'Try
        txtmakh.Focus()
        If txtmakh.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            txtmakh.Focus()
            If txttenkh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txttenkh.Focus()
                If txtdiachi.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtsdt.Focus()
                    If txtsdt.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else

                        addupdate.Parameters.AddWithValue("@MA_KH", txtmakh.Text)
                        addupdate.Parameters.AddWithValue("@TEN_KH", txttenkh.Text)
                        addupdate.Parameters.AddWithValue("@DIA_CHI", txtdiachi.Text)
                        addupdate.Parameters.AddWithValue("@SDT", txtsdt.Text)
                        addupdate.ExecuteNonQuery()
                        conn.Close() 'đóng kết nối
                        MessageBox.Show("Cập nhật thành công")
                        txtmakh.Text = Nothing
                        txttenkh.Text = Nothing
                        txtdiachi.Text = Nothing
                        txtsdt.Text = Nothing

                    End If
                End If
            End If
        End If
        'Catch ex As Exception
        ' MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvkh.DataSource = db
        dgvkh.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click

        Dim delquery As String = " delete from ChiTiet_HD delete from Hoa_Don Where Ma_KH=@Ma_KH delete from Khach_Hang where Ma_KH=@Ma_KH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        ' Try
        If txtmakh.Text = "" Then
            MessageBox.Show("Bạn cần nhập vào tên khách hàng muốn xóa", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtmakh.Focus()
        Else
            If resulft = Windows.Forms.DialogResult.Yes Then
                delete.Parameters.AddWithValue("@MA_KH", txtmakh.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                txtmakh.Text = Nothing
                txttenkh.Text = Nothing
                txtdiachi.Text = Nothing
                txtsdt.Text = Nothing
                txtmakh.Focus()
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
        dgvkh.DataSource = db
        dgvkh.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        conn.Open()
        Dim sql As String = "select * from Khach_Hang where Ten_KH like '%" & txttimkiem.Text & "%' "
        Dim danhsach As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        dgvkh.DataSource = db.DefaultView
        db.Clear()
        danhsach.Fill(db)
        conn.Close()
    End Sub

    Private Sub dgvkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkh.CellContentClick

    End Sub
End Class