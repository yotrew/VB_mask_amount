<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_get_data = New System.Windows.Forms.Button()
        Me.tb_content = New System.Windows.Forms.TextBox()
        Me.tb_query = New System.Windows.Forms.TextBox()
        Me.lbl_query = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_get_data
        '
        Me.btn_get_data.Location = New System.Drawing.Point(155, 325)
        Me.btn_get_data.Name = "btn_get_data"
        Me.btn_get_data.Size = New System.Drawing.Size(112, 23)
        Me.btn_get_data.TabIndex = 0
        Me.btn_get_data.Text = "取得口罩資料"
        Me.btn_get_data.UseVisualStyleBackColor = True
        '
        'tb_content
        '
        Me.tb_content.Location = New System.Drawing.Point(47, 40)
        Me.tb_content.Multiline = True
        Me.tb_content.Name = "tb_content"
        Me.tb_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_content.Size = New System.Drawing.Size(448, 279)
        Me.tb_content.TabIndex = 3
        '
        'tb_query
        '
        Me.tb_query.Location = New System.Drawing.Point(61, 12)
        Me.tb_query.Name = "tb_query"
        Me.tb_query.Size = New System.Drawing.Size(434, 22)
        Me.tb_query.TabIndex = 5
        Me.tb_query.Text = "高雄市新興區"
        '
        'lbl_query
        '
        Me.lbl_query.AutoSize = True
        Me.lbl_query.Location = New System.Drawing.Point(2, 15)
        Me.lbl_query.Name = "lbl_query"
        Me.lbl_query.Size = New System.Drawing.Size(53, 12)
        Me.lbl_query.TabIndex = 4
        Me.lbl_query.Text = "查詢區域"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "關閉程式(&C)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 360)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_query)
        Me.Controls.Add(Me.lbl_query)
        Me.Controls.Add(Me.tb_content)
        Me.Controls.Add(Me.btn_get_data)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_get_data As Button
    Friend WithEvents tb_content As TextBox
    Friend WithEvents tb_query As TextBox
    Friend WithEvents lbl_query As Label
    Friend WithEvents Button1 As Button
End Class
