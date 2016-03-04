<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcapnhatkh
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
        Me.dgvkh = New System.Windows.Forms.DataGridView()
        Me.lblmkh = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btntim = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvkh
        '
        Me.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkh.Location = New System.Drawing.Point(12, 199)
        Me.dgvkh.Name = "dgvkh"
        Me.dgvkh.Size = New System.Drawing.Size(465, 241)
        Me.dgvkh.TabIndex = 0
        '
        'lblmkh
        '
        Me.lblmkh.AutoSize = True
        Me.lblmkh.Location = New System.Drawing.Point(14, 117)
        Me.lblmkh.Name = "lblmkh"
        Me.lblmkh.Size = New System.Drawing.Size(43, 13)
        Me.lblmkh.TabIndex = 1
        Me.lblmkh.Text = "Mã KH:"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(63, 109)
        Me.txtmakh.Multiline = True
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(233, 30)
        Me.txtmakh.TabIndex = 2
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(63, 145)
        Me.txttenkh.Multiline = True
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(233, 30)
        Me.txttenkh.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tên KH:"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(376, 109)
        Me.txtdiachi.Multiline = True
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(233, 30)
        Me.txtdiachi.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Địa Chỉ :"
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(376, 145)
        Me.txtsdt.Multiline = True
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(233, 30)
        Me.txtsdt.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SĐT :"
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(82, 36)
        Me.txttimkiem.Multiline = True
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(307, 30)
        Me.txttimkiem.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tìm kiếm :"
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(402, 38)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 27)
        Me.btntim.TabIndex = 11
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(523, 220)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 27)
        Me.btnthem.TabIndex = 12
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(523, 279)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 27)
        Me.btnsua.TabIndex = 13
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(523, 344)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 27)
        Me.btnxoa.TabIndex = 14
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'frmcapnhatkh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 452)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.lblmkh)
        Me.Controls.Add(Me.dgvkh)
        Me.Name = "frmcapnhatkh"
        Me.Text = "Cập nhật khách hàng"
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvkh As System.Windows.Forms.DataGridView
    Friend WithEvents lblmkh As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
End Class
