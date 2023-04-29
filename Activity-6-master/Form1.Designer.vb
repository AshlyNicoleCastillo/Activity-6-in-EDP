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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.BtnBackUp = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnNewFile = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(540, 341)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox1.Location = New System.Drawing.Point(18, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(540, 43)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Data Grid View"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(595, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Loading"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(613, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "By Ashly Nicole C. Castillo"
        '
        'BtnUpload
        '
        Me.BtnUpload.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnUpload.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpload.Location = New System.Drawing.Point(613, 90)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(145, 35)
        Me.BtnUpload.TabIndex = 5
        Me.BtnUpload.Text = "UPLOAD"
        Me.BtnUpload.UseVisualStyleBackColor = False
        '
        'BtnBackUp
        '
        Me.BtnBackUp.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnBackUp.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBackUp.Location = New System.Drawing.Point(613, 146)
        Me.BtnBackUp.Name = "BtnBackUp"
        Me.BtnBackUp.Size = New System.Drawing.Size(145, 35)
        Me.BtnBackUp.TabIndex = 6
        Me.BtnBackUp.Text = "BACKUP"
        Me.BtnBackUp.UseVisualStyleBackColor = False
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.Color.Plum
        Me.BtnView.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnView.Location = New System.Drawing.Point(613, 201)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(145, 35)
        Me.BtnView.TabIndex = 7
        Me.BtnView.Text = "VIEW"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'BtnNewFile
        '
        Me.BtnNewFile.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnNewFile.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNewFile.Location = New System.Drawing.Point(613, 259)
        Me.BtnNewFile.Name = "BtnNewFile"
        Me.BtnNewFile.Size = New System.Drawing.Size(145, 35)
        Me.BtnNewFile.TabIndex = 8
        Me.BtnNewFile.Text = "NEW FILE"
        Me.BtnNewFile.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelete.Location = New System.Drawing.Point(613, 318)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(145, 35)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.Cyan
        Me.BtnPrint.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPrint.Location = New System.Drawing.Point(613, 380)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(145, 35)
        Me.BtnPrint.TabIndex = 10
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnNewFile)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.BtnBackUp)
        Me.Controls.Add(Me.BtnUpload)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Data Loading, Conversion and Database Backup"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUpload As Button
    Friend WithEvents BtnBackUp As Button
    Friend WithEvents BtnView As Button
    Friend WithEvents BtnNewFile As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnPrint As Button
End Class
