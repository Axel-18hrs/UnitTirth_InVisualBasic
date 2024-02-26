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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        label1 = New Label()
        dgvTableCSV = New DataGridView()
        label9 = New Label()
        btnDeleteCSV = New Button()
        btnSearchCSV = New Button()
        txtSearchCSV = New TextBox()
        btnSaveCSV = New Button()
        btnOpenCSV = New Button()
        TabPage2 = New TabPage()
        tvJSON = New TreeView()
        btnOpenJSON = New Button()
        label2 = New Label()
        TabPage3 = New TabPage()
        tvXML = New TreeView()
        btnOpenXML = New Button()
        label3 = New Label()
        TabPage4 = New TabPage()
        label6 = New Label()
        lstDocumentTXT = New ListBox()
        btnOpenTXT = New Button()
        label5 = New Label()
        txtSearchTXT = New TextBox()
        label4 = New Label()
        btnSearchTXT = New Button()
        lstResultados = New ListBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvTableCSV, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(-2, -2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(966, 457)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gray
        TabPage1.Controls.Add(label1)
        TabPage1.Controls.Add(dgvTableCSV)
        TabPage1.Controls.Add(label9)
        TabPage1.Controls.Add(btnDeleteCSV)
        TabPage1.Controls.Add(btnSearchCSV)
        TabPage1.Controls.Add(txtSearchCSV)
        TabPage1.Controls.Add(btnSaveCSV)
        TabPage1.Controls.Add(btnOpenCSV)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(958, 424)
        TabPage1.TabIndex = 0
        TabPage1.Text = "CSV"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(90, 42)
        label1.Name = "label1"
        label1.Size = New Size(225, 46)
        label1.TabIndex = 42
        label1.Text = "CSV Manager"
        ' 
        ' dgvTableCSV
        ' 
        dgvTableCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableCSV.Location = New Point(90, 91)
        dgvTableCSV.Name = "dgvTableCSV"
        dgvTableCSV.RowHeadersVisible = False
        dgvTableCSV.RowHeadersWidth = 51
        dgvTableCSV.Size = New Size(531, 228)
        dgvTableCSV.TabIndex = 41
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Font = New Font("Arial Narrow", 12F)
        label9.Location = New Point(663, 127)
        label9.Name = "label9"
        label9.Size = New Size(114, 24)
        label9.TabIndex = 40
        label9.Text = "Text to search"
        ' 
        ' btnDeleteCSV
        ' 
        btnDeleteCSV.Font = New Font("Arial Narrow", 10.8F)
        btnDeleteCSV.Location = New Point(663, 258)
        btnDeleteCSV.Name = "btnDeleteCSV"
        btnDeleteCSV.Size = New Size(160, 46)
        btnDeleteCSV.TabIndex = 39
        btnDeleteCSV.Text = "Delete"
        btnDeleteCSV.UseVisualStyleBackColor = True
        ' 
        ' btnSearchCSV
        ' 
        btnSearchCSV.Font = New Font("Arial Narrow", 10.8F)
        btnSearchCSV.Location = New Point(663, 206)
        btnSearchCSV.Name = "btnSearchCSV"
        btnSearchCSV.Size = New Size(160, 46)
        btnSearchCSV.TabIndex = 38
        btnSearchCSV.Text = "Search"
        btnSearchCSV.UseVisualStyleBackColor = True
        ' 
        ' txtSearchCSV
        ' 
        txtSearchCSV.Location = New Point(663, 154)
        txtSearchCSV.Name = "txtSearchCSV"
        txtSearchCSV.Size = New Size(205, 27)
        txtSearchCSV.TabIndex = 37
        ' 
        ' btnSaveCSV
        ' 
        btnSaveCSV.Font = New Font("Arial Narrow", 10.8F)
        btnSaveCSV.Location = New Point(256, 337)
        btnSaveCSV.Name = "btnSaveCSV"
        btnSaveCSV.Size = New Size(160, 46)
        btnSaveCSV.TabIndex = 36
        btnSaveCSV.Text = "Save"
        btnSaveCSV.UseVisualStyleBackColor = True
        ' 
        ' btnOpenCSV
        ' 
        btnOpenCSV.Font = New Font("Arial Narrow", 10.8F)
        btnOpenCSV.Location = New Point(90, 337)
        btnOpenCSV.Name = "btnOpenCSV"
        btnOpenCSV.Size = New Size(160, 45)
        btnOpenCSV.TabIndex = 35
        btnOpenCSV.Text = "Open"
        btnOpenCSV.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Gray
        TabPage2.Controls.Add(tvJSON)
        TabPage2.Controls.Add(btnOpenJSON)
        TabPage2.Controls.Add(label2)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(958, 424)
        TabPage2.TabIndex = 1
        TabPage2.Text = "JSON"
        ' 
        ' tvJSON
        ' 
        tvJSON.Location = New Point(102, 71)
        tvJSON.Name = "tvJSON"
        tvJSON.Size = New Size(756, 290)
        tvJSON.TabIndex = 39
        ' 
        ' btnOpenJSON
        ' 
        btnOpenJSON.Font = New Font("Arial Narrow", 10.8F)
        btnOpenJSON.Location = New Point(101, 367)
        btnOpenJSON.Name = "btnOpenJSON"
        btnOpenJSON.Size = New Size(160, 45)
        btnOpenJSON.TabIndex = 38
        btnOpenJSON.Text = "Open"
        btnOpenJSON.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(101, 12)
        label2.Name = "label2"
        label2.Size = New Size(217, 46)
        label2.TabIndex = 37
        label2.Text = "JSON Viewer"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Gray
        TabPage3.Controls.Add(tvXML)
        TabPage3.Controls.Add(btnOpenXML)
        TabPage3.Controls.Add(label3)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(958, 424)
        TabPage3.TabIndex = 2
        TabPage3.Text = "XML"
        ' 
        ' tvXML
        ' 
        tvXML.Location = New Point(102, 71)
        tvXML.Name = "tvXML"
        tvXML.Size = New Size(756, 290)
        tvXML.TabIndex = 42
        ' 
        ' btnOpenXML
        ' 
        btnOpenXML.Font = New Font("Arial Narrow", 10.8F)
        btnOpenXML.Location = New Point(101, 367)
        btnOpenXML.Name = "btnOpenXML"
        btnOpenXML.Size = New Size(160, 45)
        btnOpenXML.TabIndex = 41
        btnOpenXML.Text = "Open"
        btnOpenXML.UseVisualStyleBackColor = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label3.Location = New Point(101, 12)
        label3.Name = "label3"
        label3.Size = New Size(196, 46)
        label3.TabIndex = 40
        label3.Text = "XML Viewer"
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.Gray
        TabPage4.Controls.Add(label6)
        TabPage4.Controls.Add(lstDocumentTXT)
        TabPage4.Controls.Add(btnOpenTXT)
        TabPage4.Controls.Add(label5)
        TabPage4.Controls.Add(txtSearchTXT)
        TabPage4.Controls.Add(label4)
        TabPage4.Controls.Add(btnSearchTXT)
        TabPage4.Controls.Add(lstResultados)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(958, 424)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TXT"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label6.Location = New Point(695, 21)
        label6.Name = "label6"
        label6.Size = New Size(128, 46)
        label6.TabIndex = 53
        label6.Text = "Results"
        ' 
        ' lstDocumentTXT
        ' 
        lstDocumentTXT.FormattingEnabled = True
        lstDocumentTXT.Location = New Point(19, 70)
        lstDocumentTXT.Name = "lstDocumentTXT"
        lstDocumentTXT.Size = New Size(405, 284)
        lstDocumentTXT.TabIndex = 52
        ' 
        ' btnOpenTXT
        ' 
        btnOpenTXT.Font = New Font("Arial Narrow", 10.8F)
        btnOpenTXT.Location = New Point(19, 359)
        btnOpenTXT.Name = "btnOpenTXT"
        btnOpenTXT.Size = New Size(160, 45)
        btnOpenTXT.TabIndex = 51
        btnOpenTXT.Text = "Open"
        btnOpenTXT.UseVisualStyleBackColor = True
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label5.Location = New Point(19, 21)
        label5.Name = "label5"
        label5.Size = New Size(270, 46)
        label5.TabIndex = 50
        label5.Text = "TEXT Document "
        ' 
        ' txtSearchTXT
        ' 
        txtSearchTXT.Location = New Point(430, 97)
        txtSearchTXT.Name = "txtSearchTXT"
        txtSearchTXT.Size = New Size(205, 27)
        txtSearchTXT.TabIndex = 49
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Arial Narrow", 12F)
        label4.Location = New Point(430, 70)
        label4.Name = "label4"
        label4.Size = New Size(114, 24)
        label4.TabIndex = 48
        label4.Text = "Text to search"
        ' 
        ' btnSearchTXT
        ' 
        btnSearchTXT.Font = New Font("Arial Narrow", 10.8F)
        btnSearchTXT.Location = New Point(430, 130)
        btnSearchTXT.Name = "btnSearchTXT"
        btnSearchTXT.Size = New Size(160, 45)
        btnSearchTXT.TabIndex = 47
        btnSearchTXT.Text = "Search"
        btnSearchTXT.UseVisualStyleBackColor = True
        ' 
        ' lstResultados
        ' 
        lstResultados.FormattingEnabled = True
        lstResultados.Location = New Point(695, 70)
        lstResultados.Name = "lstResultados"
        lstResultados.Size = New Size(244, 284)
        lstResultados.TabIndex = 46
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 450)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvTableCSV, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents label1 As Label
    Private WithEvents dgvTableCSV As DataGridView
    Private WithEvents label9 As Label
    Private WithEvents btnDeleteCSV As Button
    Private WithEvents btnSearchCSV As Button
    Private WithEvents txtSearchCSV As TextBox
    Private WithEvents btnSaveCSV As Button
    Private WithEvents btnOpenCSV As Button
    Private WithEvents tvJSON As TreeView
    Private WithEvents btnOpenJSON As Button
    Private WithEvents label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Private WithEvents tvXML As TreeView
    Private WithEvents btnOpenXML As Button
    Private WithEvents label3 As Label
    Private WithEvents label6 As Label
    Private WithEvents lstDocumentTXT As ListBox
    Private WithEvents btnOpenTXT As Button
    Private WithEvents label5 As Label
    Private WithEvents txtSearchTXT As TextBox
    Private WithEvents label4 As Label
    Private WithEvents btnSearchTXT As Button
    Private WithEvents lstResultados As ListBox

End Class
