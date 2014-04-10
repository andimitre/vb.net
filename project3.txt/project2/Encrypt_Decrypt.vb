Imports System.IO



Public Class Encrypt_Decrypt

    Dim objShift As New clsSecurity


    Dim path As String = "C:\Users\am484\Documents\here.txt"


    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Try
            Dim read As IO.StreamReader = IO.File.OpenText("C:\Users\am484\Documents\keys.txt")
            Do While read.Peek <> -1
                For i = 0 To objShift.KeyNum
                    objShift.KeyString = read.ReadLine
                Next
                ComboBox1.Items.Add(objShift.KeyString)


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

    End Sub
    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click



        For i = 0 To encrypttxt.Text.Length - 1
            objShift.CurrentChar = encrypttxt.Text.Substring(i, 1)
            If Asc(objShift.CurrentChar) = 13 Then
                encrypttxt.Text = encrypttxt.Text + Chr(13)
            ElseIf Asc(objShift.CurrentChar) = 10 Then
                encrypttxt.Text = encrypttxt.Text + Chr(10)
            Else
                objShift.KeyDigit = i Mod 5
                Dim here As String = objShift.Encrypt(encrypttxt.Text)
                ciphertxt1.Text = ciphertxt1.Text + Chr(here)

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

    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPushText.Click
        Dim ctext As String
        ctext = ciphertxt1.Text
        ciphertxt2.Text = ctext
        writeLabel.Text = path
    End Sub

    Public Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click


        For i = 0 To ciphertxt2.Text.Length - 1
            objShift.CurrentChar = ciphertxt2.Text.Substring(i, 1)
            If Asc(objShift.CurrentChar) = 13 Then
                ciphertxt2.Text = ciphertxt2.Text + Chr(13)
            ElseIf Asc(objShift.CurrentChar) = 10 Then
                ciphertxt2.Text = ciphertxt2.Text + Chr(10)
            Else
                objShift.KeyDigit = i Mod 5
                Dim result As String = objShift.Decrypt(ciphertxt2.Text)
                decrypttxt.Text = decrypttxt.Text + Chr(result)
            End If
        Next

    End Sub

    Public Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        encrypttxt.Text = ""
        decrypttxt.Text = ""
        writeLabel.Text = ""
        ciphertxt1.Text = ""
        ciphertxt2.Text = ""
        readLabel.Text = ""
    End Sub
End Class
