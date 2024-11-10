Module CipherMod
    Function Encrypt(ByVal Text As String, Shift As Integer)
        Dim Result As String = ""

        ' Define the range of printable ASCII characters
        Dim asciiMin As Integer = 32
        Dim asciiMax As Integer = 126
        Dim Range As Integer = asciiMax - asciiMin + 1

        ' Shift each character in the text
        For Each ch As Char In Text
            ' Only shift if within the printable ASCII range
            If AscW(ch) >= asciiMin AndAlso AscW(ch) <= asciiMax Then
                ' Apply the shift and wrap within the ASCII printable range
                Dim ShiftedChar As Char = ChrW(asciiMin + ((AscW(ch) - asciiMin + Shift) Mod Range + Range) Mod Range)
                Result &= ShiftedChar
            Else
                ' If outside printable ASCII range
                Result &= ch
            End If
        Next
        Return Result
    End Function

    Function Decrypt(ByVal Text As String, Shift As Integer)
        ' Decryption uses the negative shift
        Return Encrypt(Text, -Shift)
    End Function

    Function dgvWrite(ByVal InputText As String, Action As String, ProcessedText As String)
        Return Form1.dgv_Results.Rows.Add(InputText, Action, ProcessedText)
    End Function

    'Function dgvLoad()
    '    Dim FilePath As String = "C:\Users\xstop\source\repos\CipherApp\CipherApp\ProcessedText.txt"
    'End Function

    Function FileWrite(ByVal Action As String, InputText As String, ProcessedText As String)
        Dim FilePath As String = "C:\Users\xstop\source\repos\CipherApp\CipherApp\ProcessedText.txt"
        Try
            Using Writer As New System.IO.StreamWriter(FilePath, True)
                Writer.WriteLine($"Action: {Action}")
                Writer.WriteLine($"Input Text: {InputText}")
                Writer.WriteLine($"Processed Text: {ProcessedText}")
                Writer.WriteLine("-------------------------------------")
            End Using
            'MessageBox.Show($"Processed text saved to {FilePath}.")
            Return True
        Catch ex As Exception
            MessageBox.Show("An error occurred while writing to the file: " & ex.Message)
            Return False
        End Try
    End Function

End Module
