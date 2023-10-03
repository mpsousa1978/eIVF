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
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        btnInsert = New Button()
        txtDescription = New TextBox()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        txtAmount = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtPrice = New TextBox()
        Price = New Label()
        btnExport = New Button()
        ProgressBar1 = New ProgressBar()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(635, 196)
        DataGridView1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(230, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(497, 285)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(80, 27)
        btnInsert.TabIndex = 2
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(189, 285)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(130, 27)
        txtDescription.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 262)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 20)
        Label1.TabIndex = 4
        Label1.Text = "Type"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 285)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(171, 28)
        ComboBox2.TabIndex = 5
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(325, 285)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(84, 27)
        txtAmount.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(189, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 7
        Label2.Text = "Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(330, 260)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 8
        Label3.Text = "Amount"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(415, 285)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(76, 27)
        txtPrice.TabIndex = 9
        ' 
        ' Price
        ' 
        Price.AutoSize = True
        Price.Location = New Point(419, 261)
        Price.Name = "Price"
        Price.Size = New Size(41, 20)
        Price.TabIndex = 10
        Price.Text = "Price"
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(653, 52)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(90, 43)
        btnExport.TabIndex = 11
        btnExport.Text = "Export CSV"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 348)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(635, 29)
        ProgressBar1.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(858, 406)
        Controls.Add(ProgressBar1)
        Controls.Add(btnExport)
        Controls.Add(Price)
        Controls.Add(txtPrice)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAmount)
        Controls.Add(ComboBox2)
        Controls.Add(Label1)
        Controls.Add(txtDescription)
        Controls.Add(btnInsert)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Price As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
