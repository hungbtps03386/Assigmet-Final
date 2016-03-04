<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcapnhatsp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.lblmota = New System.Windows.Forms.Label()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.lblsoluong = New System.Windows.Forms.Label()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.lblmsp = New System.Windows.Forms.Label()
        Me.dgvsp = New System.Windows.Forms.DataGridView()
        Me.txtmlsp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(577, 331)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 27)
        Me.btnxoa.TabIndex = 29
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(577, 266)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 27)
        Me.btnsua.TabIndex = 28
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(577, 207)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 27)
        Me.btnthem.TabIndex = 27
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(440, 24)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 27)
        Me.btntim.TabIndex = 26
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(120, 22)
        Me.txttimkiem.Multiline = True
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(307, 30)
        Me.txttimkiem.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Tìm kiếm :"
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(414, 108)
        Me.txtmota.Multiline = True
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(233, 30)
        Me.txtmota.TabIndex = 23
        '
        'lblmota
        '
        Me.lblmota.AutoSize = True
        Me.lblmota.Location = New System.Drawing.Point(365, 116)
        Me.lblmota.Name = "lblmota"
        Me.lblmota.Size = New System.Drawing.Size(40, 13)
        Me.lblmota.TabIndex = 22
        Me.lblmota.Text = "Mô tả :"
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(414, 72)
        Me.txtsoluong.Multiline = True
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(233, 30)
        Me.txtsoluong.TabIndex = 21
        '
        'lblsoluong
        '
        Me.lblsoluong.AutoSize = True
        Me.lblsoluong.Location = New System.Drawing.Point(358, 80)
        Me.lblsoluong.Name = "lblsoluong"
        Me.lblsoluong.Size = New System.Drawing.Size(59, 13)
        Me.lblsoluong.TabIndex = 20
        Me.lblsoluong.Text = "Số Lượng :"
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(101, 108)
        Me.txttensp.Multiline = True
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(233, 30)
        Me.txttensp.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tên SP:"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(101, 72)
        Me.txtmasp.Multiline = True
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(233, 30)
        Me.txtmasp.TabIndex = 17
        '
        'lblmsp
        '
        Me.lblmsp.AutoSize = True
        Me.lblmsp.Location = New System.Drawing.Point(52, 80)
        Me.lblmsp.Name = "lblmsp"
        Me.lblmsp.Size = New System.Drawing.Size(42, 13)
        Me.lblmsp.TabIndex = 16
        Me.lblmsp.Text = "Mã SP:"
        '
        'dgvsp
        '
        Me.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsp.Location = New System.Drawing.Point(12, 185)
        Me.dgvsp.Name = "dgvsp"
        Me.dgvsp.Size = New System.Drawing.Size(526, 241)
        Me.dgvsp.TabIndex = 15
        '
        'txtmlsp
        '
        Me.txtmlsp.Location = New System.Drawing.Point(101, 147)
        Me.txtmlsp.Multiline = True
        Me.txtmlsp.Name = "txtmlsp"
        Me.txtmlsp.Size = New System.Drawing.Size(233, 30)
        Me.txtmlsp.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Mã Loại SP :"
        '
        'frmcapnhatsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 440)
        Me.Controls.Add(Me.txtmlsp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.lblmota)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.lblsoluong)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.lblmsp)
        Me.Controls.Add(Me.dgvsp)
        Me.Name = "frmcapnhatsp"
        Me.Text = "Cập nhật sản phẩm"
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents lblmota As System.Windows.Forms.Label
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents lblsoluong As System.Windows.Forms.Label
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents lblmsp As System.Windows.Forms.Label
    Friend WithEvents dgvsp As System.Windows.Forms.DataGridView
    Friend WithEvents txtmlsp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
