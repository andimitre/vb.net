Imports System.IO
Public Class Encrypt_Decrypt
    'Private strwriter As New StreamWriter("H:\public_html")
    Dim key(4) As Integer
    Dim path As String = "C:\Users\am484\Documents\here.txt"
    Dim KeyString As String
    'keystring =  combobox 
    'each substring was value of key
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim readfile2 As StreamReader
        'Dim strInput1 As String
        'readfile2 = IO.File.OpenText("C:\Users\am484\Documents\keys.txt")
        'Do While readfile2.Peek <> -1
        '    strInput1 = readfile2.ReadToEnd
        '    ComboBox1.Items.Add(strInput1)
        'Loop
        'readfile2.Close()

        Dim KeyNum, i As Integer

        Try
            Dim read As IO.StreamReader = IO.File.OpenText("C:\Users\am484\Documents\keys.txt")
            Do While read.Peek <> -1
                For i = 0 To KeyNum
                    KeyString = read.ReadLine
                Next
                ComboBox1.Items.Add(KeyString)
            Loop
            read.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetText.Click
        OpenFileDialog1.ShowDialog()
        readLabel.Text = OpenFileDialog1.FileName

        Dim readfile As StreamReader
        Dim strInput As String
        Try
            readfile = IO.File.OpenText(OpenFileDialog1.FileName)

            Do While readfile.Peek <> -1
                strInput = readfile.ReadLine
                encrypttxt.Text = encrypttxt.Text & strInput & vbCrLf
            Loop
            readfile.Close()
        Catch ex As Exception
        End Try

        'Do While readfile.Peek <> -1
        '    strInput = readfile.ReadToEnd
        '    TextBox1.Text = strInput
        'Loop
        'readfile.Close()



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypttxt.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim keystring2 As String
        keystring2 = ComboBox1.Text
        key(0) = keystring2.Substring(0, 1)
        key(1) = keystring2.Substring(1, 1)
        key(2) = keystring2.Substring(2, 1)
        key(3) = keystring2.Substring(3, 1)
        key(4) = keystring2.Substring(4, 1)
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ciphertxt2.TextChanged

    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        Dim i, KeyDigit, CharASC As Integer
        Dim currChar As String

        For i = 0 To encrypttxt.Text.Length - 1
            currChar = encrypttxt.Text.Substring(i, 1)
            If Asc(currChar) = 13 Then
                encrypttxt.Text = encrypttxt.Text + Chr(13)
            ElseIf Asc(currChar) = 10 Then
                encrypttxt.Text = encrypttxt.Text + Chr(10)
            Else
                KeyDigit = i Mod 5
                CharASC = Asc(currChar) + key(KeyDigit)

                If CharASC > 126 Then
                    CharASC = CharASC - 95
                End If

                ciphertxt1.Text = ciphertxt1.Text + Chr(CharASC)
            End If
        Next

        If ciphertxt1.Text <> "" Then
            Try
                Dim strwriter As StreamWriter

                strwriter = File.CreateText(path)
                strwriter.WriteLine(ciphertxt1.Text)
                strwriter.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPushText.Click
        Dim ctext As String
        ctext = ciphertxt1.Text
        ciphertxt2.Text = ctext
        writeLabel.Text = path
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        Dim start, KeyDigit, CharASC As Integer
        Dim currChar As String

        For start = 0 To ciphertxt2.Text.Length - 1

            currChar = ciphertxt2.Text.Substring(start, 1)

            If Asc(currChar) = 13 Then
                ciphertxt2.Text = ciphertxt2.Text + Chr(13)
            ElseIf Asc(currChar) = 10 Then
                ciphertxt2.Text = ciphertxt2.Text + Chr(10)
            Else
                KeyDigit = start Mod 5

                CharASC = Asc(currChar) - key(KeyDigit)

                If CharASC > 126 Then
                    CharASC = CharASC - 95
                End If

                decrypttxt.Text = decrypttxt.Text + Chr(CharASC)
            End If
        Next

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        encrypttxt.Text = ""
        decrypttxt.Text = ""
        writeLabel.Text = ""
        ciphertxt1.Text = ""
        ciphertxt2.Text = ""
        readLabel.Text = ""
    End Sub
End Class
