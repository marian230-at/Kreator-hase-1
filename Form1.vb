
Public Class Form1
    Public znakiA As String = "1234567890POIUYTREWQASDFGH?)(*&^%$#@!JKLMNBVCXZpoiuytrewqasdfghjklmnbvcxz"
    Public znakibig As String = "poiuytrewqasdfghjklmnbvcxz"
    Public znaki As String = "1234567890"
    Public specialznaki As String = "?)(*&^%$#@!"
    Public LiczbaLosowana As New Random
    Public ZmiennaLosowa As Integer
    Public haslo As String
    Public calehaslo As String
    Public znakidohasla As String
    Public wartosc As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        For i As Byte = 0 To 8
            ZmiennaLosowa = LiczbaLosowana.Next(0, 73)

            haslo = znakiA.Substring(ZmiennaLosowa, 1)
            Console.WriteLine(haslo)
            calehaslo = calehaslo + haslo
        Next

        RichTextBox1.AppendText(calehaslo & vbNewLine)
        calehaslo = 0
        haslo = 0
        Console.WriteLine("   Nowe hasło")
        Console.WriteLine(wartosc)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


    End Sub

    Private Sub NumericUpDown1_ValueChanged_2(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        wartosc = NumericUpDown1.Value


    End Sub
End Class
