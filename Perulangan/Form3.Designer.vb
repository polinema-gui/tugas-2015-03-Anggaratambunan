<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.input1String = New System.Windows.Forms.TextBox()
        Me.operasi = New System.Windows.Forms.ComboBox()
        Me.input2String = New System.Windows.Forms.TextBox()
        Me.hasilBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matriks 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matriks 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'input1String
        '
        Me.input1String.Location = New System.Drawing.Point(74, 12)
        Me.input1String.Multiline = True
        Me.input1String.Name = "input1String"
        Me.input1String.Size = New System.Drawing.Size(352, 89)
        Me.input1String.TabIndex = 4
        '
        'operasi
        '
        Me.operasi.FormattingEnabled = True
        Me.operasi.Items.AddRange(New Object() {"tambah", "kurang"})
        Me.operasi.Location = New System.Drawing.Point(74, 110)
        Me.operasi.Name = "operasi"
        Me.operasi.Size = New System.Drawing.Size(352, 21)
        Me.operasi.TabIndex = 5
        '
        'input2String
        '
        Me.input2String.Location = New System.Drawing.Point(77, 140)
        Me.input2String.Multiline = True
        Me.input2String.Name = "input2String"
        Me.input2String.Size = New System.Drawing.Size(348, 93)
        Me.input2String.TabIndex = 6
        '
        'hasilBox
        '
        Me.hasilBox.Location = New System.Drawing.Point(77, 244)
        Me.hasilBox.Multiline = True
        Me.hasilBox.Name = "hasilBox"
        Me.hasilBox.Size = New System.Drawing.Size(348, 92)
        Me.hasilBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hasilBox)
        Me.Controls.Add(Me.input2String)
        Me.Controls.Add(Me.operasi)
        Me.Controls.Add(Me.input1String)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents input1String As System.Windows.Forms.TextBox
    Friend WithEvents operasi As System.Windows.Forms.ComboBox
    Friend WithEvents input2String As System.Windows.Forms.TextBox
    Friend WithEvents hasilBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
