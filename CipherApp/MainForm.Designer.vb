<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txt_Text = New TextBox()
        lbl_Text = New Label()
        lbl_Shift = New Label()
        cmb_Actions = New ComboBox()
        num_Shift = New NumericUpDown()
        lbl_Actions = New Label()
        GroupBox1 = New GroupBox()
        dgv_Results = New DataGridView()
        btn_Process = New Button()
        Label1 = New Label()
        CType(num_Shift, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgv_Results, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_Text
        ' 
        txt_Text.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_Text.BackColor = SystemColors.Window
        txt_Text.ForeColor = SystemColors.WindowText
        txt_Text.Location = New Point(127, 41)
        txt_Text.Margin = New Padding(3, 4, 3, 4)
        txt_Text.Name = "txt_Text"
        txt_Text.Size = New Size(273, 27)
        txt_Text.TabIndex = 1
        ' 
        ' lbl_Text
        ' 
        lbl_Text.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_Text.AutoSize = True
        lbl_Text.Font = New Font("Berlin Sans FB", 14.5F)
        lbl_Text.Location = New Point(7, 41)
        lbl_Text.Name = "lbl_Text"
        lbl_Text.Size = New Size(57, 27)
        lbl_Text.TabIndex = 2
        lbl_Text.Text = "Text"
        ' 
        ' lbl_Shift
        ' 
        lbl_Shift.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_Shift.AutoSize = True
        lbl_Shift.Font = New Font("Berlin Sans FB", 14.5F)
        lbl_Shift.Location = New Point(7, 80)
        lbl_Shift.Name = "lbl_Shift"
        lbl_Shift.Size = New Size(123, 27)
        lbl_Shift.TabIndex = 2
        lbl_Shift.Text = "Shift Value"
        ' 
        ' cmb_Actions
        ' 
        cmb_Actions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmb_Actions.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_Actions.Items.AddRange(New Object() {"", "Encrypt", "Decrypt"})
        cmb_Actions.Location = New Point(127, 119)
        cmb_Actions.Margin = New Padding(3, 4, 3, 4)
        cmb_Actions.Name = "cmb_Actions"
        cmb_Actions.Size = New Size(273, 28)
        cmb_Actions.TabIndex = 3
        ' 
        ' num_Shift
        ' 
        num_Shift.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        num_Shift.Location = New Point(127, 80)
        num_Shift.Margin = New Padding(3, 4, 3, 4)
        num_Shift.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        num_Shift.Name = "num_Shift"
        num_Shift.Size = New Size(273, 27)
        num_Shift.TabIndex = 2
        ' 
        ' lbl_Actions
        ' 
        lbl_Actions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_Actions.AutoSize = True
        lbl_Actions.Font = New Font("Berlin Sans FB", 14.5F)
        lbl_Actions.Location = New Point(7, 119)
        lbl_Actions.Name = "lbl_Actions"
        lbl_Actions.Size = New Size(86, 27)
        lbl_Actions.TabIndex = 2
        lbl_Actions.Text = "Actions"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(dgv_Results)
        GroupBox1.Controls.Add(btn_Process)
        GroupBox1.Controls.Add(cmb_Actions)
        GroupBox1.Controls.Add(num_Shift)
        GroupBox1.Controls.Add(txt_Text)
        GroupBox1.Controls.Add(lbl_Text)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lbl_Actions)
        GroupBox1.Controls.Add(lbl_Shift)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(407, 544)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' dgv_Results
        ' 
        dgv_Results.AllowUserToAddRows = False
        dgv_Results.AllowUserToDeleteRows = False
        dgv_Results.AllowUserToResizeColumns = False
        dgv_Results.AllowUserToResizeRows = False
        dgv_Results.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_Results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgv_Results.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgv_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_Results.Location = New Point(7, 244)
        dgv_Results.Margin = New Padding(3, 4, 3, 4)
        dgv_Results.Name = "dgv_Results"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgv_Results.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgv_Results.RowHeadersVisible = False
        dgv_Results.RowHeadersWidth = 51
        dgv_Results.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Results.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgv_Results.Size = New Size(393, 292)
        dgv_Results.TabIndex = 5
        dgv_Results.TabStop = False
        ' 
        ' btn_Process
        ' 
        btn_Process.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_Process.Font = New Font("Berlin Sans FB", 10F)
        btn_Process.Location = New Point(7, 157)
        btn_Process.Margin = New Padding(3, 4, 3, 4)
        btn_Process.Name = "btn_Process"
        btn_Process.Size = New Size(393, 31)
        btn_Process.TabIndex = 4
        btn_Process.Text = "Process Text"
        btn_Process.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Berlin Sans FB", 12F)
        Label1.Location = New Point(1, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 23)
        Label1.TabIndex = 2
        Label1.Text = "Processed Text"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(434, 576)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Cipher App"
        CType(num_Shift, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgv_Results, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_Text As TextBox
    Friend WithEvents lbl_Text As Label
    Friend WithEvents lbl_Shift As Label
    Friend WithEvents cmb_Actions As ComboBox
    Friend WithEvents num_Shift As NumericUpDown
    Friend WithEvents lbl_Actions As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Process As Button
    Friend WithEvents dgv_Results As DataGridView
    Friend WithEvents Label1 As Label

End Class

