Public Class Form1
    Private Sub btn_Process_Click(sender As Object, e As EventArgs) Handles btn_Process.Click
        Dim InputText = txt_Text.Text
        Dim ShiftValue As Integer = num_Shift.Value
        Dim Action = cmb_Actions.SelectedItem?.ToString
        Dim ProcessedText = ""

        If String.IsNullOrEmpty(Action) Then
            MessageBox.Show("Please select an action.")
            Return
        End If

        Select Case Action
            Case "Encrypt"
                ProcessedText = Encrypt(InputText, ShiftValue)
            Case "Decrypt"
                ProcessedText = Decrypt(InputText, ShiftValue)
            Case Else
                MessageBox.Show("Invalid action selected.")
                Return
        End Select

        dgvWrite(InputText, Action, ProcessedText)
        FileWrite(Action, InputText, ProcessedText)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_Results.ColumnCount = 3
        dgv_Results.Columns(0).Name = "Original Text"
        dgv_Results.Columns(1).Name = "Action"
        dgv_Results.Columns(2).Name = "Processed Text"
    End Sub
End Class
