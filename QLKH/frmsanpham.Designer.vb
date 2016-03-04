<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Me.btntim = New System.Windows.Forms.Button()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.lbltimkiem = New System.Windows.Forms.Label()
        Me.drvsanpham = New System.Windows.Forms.DataGridView()
        CType(Me.drvsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btntim
        '
        Me.btntim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntim.Location = New System.Drawing.Point(429, 34)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(86, 28)
        Me.btntim.TabIndex = 10
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(110, 32)
        Me.txttimkiem.Multiline = True
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(300, 32)
        Me.txttimkiem.TabIndex = 9
        '
        'lbltimkiem
        '
        Me.lbltimkiem.AutoSize = True
        Me.lbltimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimkiem.Location = New System.Drawing.Point(30, 37)
        Me.lbltimkiem.Name = "lbltimkiem"
        Me.lbltimkiem.Size = New System.Drawing.Size(69, 18)
        Me.lbltimkiem.TabIndex = 8
        Me.lbltimkiem.Text = "Tìm kiếm"
        '
        'drvsanpham
        '
        Me.drvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drvsanpham.Location = New System.Drawing.Point(29, 76)
        Me.drvsanpham.Name = "drvsanpham"
        Me.drvsanpham.Size = New System.Drawing.Size(567, 295)
        Me.drvsanpham.TabIndex = 7
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 402)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.lbltimkiem)
        Me.Controls.Add(Me.drvsanpham)
        Me.Name = "frmsanpham"
        Me.Text = "Sản Phẩm"
        CType(Me.drvsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents lbltimkiem As System.Windows.Forms.Label
    Friend WithEvents drvsanpham As System.Windows.Forms.DataGridView
End Class
