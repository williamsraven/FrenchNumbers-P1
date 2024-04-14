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
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnFour = New Button()
        BtnFive = New Button()
        btnExit = New Button()
        TextBox2 = New TextBox()
        lblFrenchOne = New Button()
        lblFrenchTwo = New Button()
        lblFrenchThree = New Button()
        lblFrenchFour = New Button()
        lblFrenchFive = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        OpenFileDialog1 = New OpenFileDialog()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOne
        ' 
        btnOne.Location = New Point(226, 325)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(112, 34)
        btnOne.TabIndex = 1
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Location = New Point(406, 325)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(112, 34)
        btnTwo.TabIndex = 2
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Location = New Point(579, 325)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(112, 34)
        btnThree.TabIndex = 3
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Location = New Point(754, 325)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(112, 34)
        btnFour.TabIndex = 4
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' BtnFive
        ' 
        BtnFive.Location = New Point(910, 325)
        BtnFive.Name = "BtnFive"
        BtnFive.Size = New Size(112, 34)
        BtnFive.TabIndex = 5
        BtnFive.Text = "5"
        BtnFive.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(579, 515)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(406, 193)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(447, 75)
        TextBox2.TabIndex = 8
        TextBox2.Text = "Do you know thr French words for the numbers 1-5? Click the buttons below to see."
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblFrenchOne
        ' 
        lblFrenchOne.BackColor = Color.Lime
        lblFrenchOne.Location = New Point(579, 460)
        lblFrenchOne.Name = "lblFrenchOne"
        lblFrenchOne.Size = New Size(112, 34)
        lblFrenchOne.TabIndex = 9
        lblFrenchOne.Text = "un"
        lblFrenchOne.UseVisualStyleBackColor = False
        lblFrenchOne.Visible = False
        ' 
        ' lblFrenchTwo
        ' 
        lblFrenchTwo.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        lblFrenchTwo.Location = New Point(579, 460)
        lblFrenchTwo.Name = "lblFrenchTwo"
        lblFrenchTwo.Size = New Size(112, 34)
        lblFrenchTwo.TabIndex = 11
        lblFrenchTwo.Text = "deux"
        lblFrenchTwo.UseVisualStyleBackColor = False
        lblFrenchTwo.Visible = False
        ' 
        ' lblFrenchThree
        ' 
        lblFrenchThree.BackColor = Color.Lime
        lblFrenchThree.Location = New Point(579, 460)
        lblFrenchThree.Name = "lblFrenchThree"
        lblFrenchThree.Size = New Size(112, 34)
        lblFrenchThree.TabIndex = 12
        lblFrenchThree.Text = "trois"
        lblFrenchThree.UseVisualStyleBackColor = False
        ' 
        ' lblFrenchFour
        ' 
        lblFrenchFour.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        lblFrenchFour.Location = New Point(579, 460)
        lblFrenchFour.Name = "lblFrenchFour"
        lblFrenchFour.Size = New Size(112, 34)
        lblFrenchFour.TabIndex = 13
        lblFrenchFour.Text = "quatre"
        lblFrenchFour.UseVisualStyleBackColor = False
        ' 
        ' lblFrenchFive
        ' 
        lblFrenchFive.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        lblFrenchFive.ForeColor = Color.Black
        lblFrenchFive.Location = New Point(579, 460)
        lblFrenchFive.Name = "lblFrenchFive"
        lblFrenchFive.Size = New Size(112, 34)
        lblFrenchFive.TabIndex = 14
        lblFrenchFive.Text = "cinq"
        lblFrenchFive.UseVisualStyleBackColor = False
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1260, 670)
        Controls.Add(lblFrenchFive)
        Controls.Add(lblFrenchFour)
        Controls.Add(lblFrenchThree)
        Controls.Add(lblFrenchTwo)
        Controls.Add(lblFrenchOne)
        Controls.Add(TextBox2)
        Controls.Add(btnExit)
        Controls.Add(BtnFive)
        Controls.Add(btnFour)
        Controls.Add(btnThree)
        Controls.Add(btnTwo)
        Controls.Add(btnOne)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Form1"
        Text = "French Numbers"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents BtnFive As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblFrenchOne As Button
    Friend WithEvents lblFrenchTwo As Button
    Friend WithEvents lblFrenchThree As Button
    Friend WithEvents lblFrenchFour As Button
    Friend WithEvents lblFrenchFive As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents OpenFileDialog1 As OpenFileDialog


End Class
