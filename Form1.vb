Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ΕνάρξηToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΕνάρξηToolStripMenuItem.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Write your HellasCoin Address")
        End If
        Shell("core/cgminer.exe --scrypt -o grmine.eu:3032 -u " + TextBox1.Text + " -p x ")
    End Sub

    Private Sub ΕξοδοςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΕξοδοςToolStripMenuItem.Click
        End
    End Sub

    Private Sub ΒοηθειαToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΒοηθειαToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Write your HellasCoin Address")
        End If
        Shell("core/cgminer.exe --scrypt -o grmine.eu:3032 -u " + TextBox1.Text + " -p x ")
    End Sub

    Private Sub ΣχετικαToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΣχετικαToolStripMenuItem.Click
        Dim oForm As Form2
        oForm = New Form2()
        oForm.Show()
        oForm = Nothing
    End Sub




    Private Sub ΡυθμίσειςToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
