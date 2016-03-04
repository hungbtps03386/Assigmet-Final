Public Class frmgiaodienchinh
    
    
    Private Sub tsmcapnhat_Click(sender As Object, e As EventArgs) Handles tsmcapnhat.Click
        frmcapnhatsp.Show()
    End Sub

    Private Sub CậpNhậtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CậpNhậtToolStripMenuItem1.Click
        frmcapnhatkh.Show()
    End Sub

    Private Sub frmgiaodienchinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub XemThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemThôngTinToolStripMenuItem.Click
        frmsanpham.Show()
    End Sub

    Private Sub XemThôngTinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles XemThôngTinToolStripMenuItem1.Click
        frmkhachhang.Show()
    End Sub
End Class
