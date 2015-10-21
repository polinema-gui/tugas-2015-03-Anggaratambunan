Public Class Form3

    Dim input1, input2 As Integer
    Dim hasil As String

    Private Sub barisString_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles operasi.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Input1 = Convert.ToInt64(input1String.Text)
        Input2 = Convert.ToInt64(input2String.Text)
        If operasi.Text = "Tambah" Then
            hasil = input1 + input2
        Else
            hasil = input1 - input2
        End If
        hasilBox.Text = hasil
    End Sub
End Class