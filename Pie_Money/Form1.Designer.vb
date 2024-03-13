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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.lstStudentDon = New System.Windows.Forms.ListBox()
        Me.TxtStuTot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClassTotal = New System.Windows.Forms.Label()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'TxtDon
        '
        Me.TxtDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDon.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDon.Location = New System.Drawing.Point(309, 26)
        Me.TxtDon.Name = "TxtDon"
        Me.TxtDon.Size = New System.Drawing.Size(130, 22)
        Me.TxtDon.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Donation Amount:"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Noto Sans", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnAdd.Location = New System.Drawing.Point(457, 26)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(83, 22)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'cboStudents
        '
        Me.cboStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudents.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(15, 26)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(121, 23)
        Me.cboStudents.Sorted = True
        Me.cboStudents.TabIndex = 5
        '
        'lstStudentDon
        '
        Me.lstStudentDon.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lstStudentDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstStudentDon.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentDon.FormattingEnabled = True
        Me.lstStudentDon.ItemHeight = 14
        Me.lstStudentDon.Location = New System.Drawing.Point(15, 70)
        Me.lstStudentDon.Name = "lstStudentDon"
        Me.lstStudentDon.Size = New System.Drawing.Size(296, 72)
        Me.lstStudentDon.TabIndex = 7
        '
        'TxtStuTot
        '
        Me.TxtStuTot.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TxtStuTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStuTot.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStuTot.Location = New System.Drawing.Point(121, 151)
        Me.TxtStuTot.Name = "TxtStuTot"
        Me.TxtStuTot.ReadOnly = True
        Me.TxtStuTot.Size = New System.Drawing.Size(84, 22)
        Me.TxtStuTot.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Student Total:"
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRemove.Font = New System.Drawing.Font("Noto Sans", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnRemove.Location = New System.Drawing.Point(323, 70)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 10
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total Donations:"
        '
        'lblClassTotal
        '
        Me.lblClassTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lblClassTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClassTotal.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassTotal.Location = New System.Drawing.Point(445, 229)
        Me.lblClassTotal.Name = "lblClassTotal"
        Me.lblClassTotal.Size = New System.Drawing.Size(169, 25)
        Me.lblClassTotal.TabIndex = 12
        '
        'lblHigh
        '
        Me.lblHigh.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lblHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHigh.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHigh.Location = New System.Drawing.Point(420, 105)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(218, 114)
        Me.lblHigh.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Noto Sans", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(417, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Highest Donors:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 210)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 327)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.lblClassTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtStuTot)
        Me.Controls.Add(Me.lstStudentDon)
        Me.Controls.Add(Me.cboStudents)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDon)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Pie Money"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents lstStudentDon As ListBox
    Friend WithEvents TxtStuTot As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRemove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblClassTotal As Label
    Friend WithEvents lblHigh As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
