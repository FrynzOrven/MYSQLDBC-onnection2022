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
        btnTest = New Button()
        Label1 = New Label()
        TextBox_UN = New TextBox()
        Label2 = New Label()
        TextBox_PASS = New TextBox()
        Login = New Button()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.BackColor = SystemColors.Control
        btnTest.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTest.Location = New Point(12, 12)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(265, 40)
        btnTest.TabIndex = 0
        btnTest.Text = "Check Connection"
        btnTest.TextAlign = ContentAlignment.MiddleRight
        btnTest.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 25)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' TextBox_UN
        ' 
        TextBox_UN.Location = New Point(270, 86)
        TextBox_UN.Name = "TextBox_UN"
        TextBox_UN.Size = New Size(196, 34)
        TextBox_UN.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(150, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 25)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' TextBox_PASS
        ' 
        TextBox_PASS.Location = New Point(270, 140)
        TextBox_PASS.Name = "TextBox_PASS"
        TextBox_PASS.PasswordChar = "✅"c
        TextBox_PASS.Size = New Size(196, 34)
        TextBox_PASS.TabIndex = 4
        ' 
        ' Login
        ' 
        Login.Location = New Point(293, 209)
        Login.Name = "Login"
        Login.Size = New Size(153, 40)
        Login.TabIndex = 5
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 504)
        Controls.Add(Login)
        Controls.Add(TextBox_PASS)
        Controls.Add(Label2)
        Controls.Add(TextBox_UN)
        Controls.Add(Label1)
        Controls.Add(btnTest)
        Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_UN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_PASS As TextBox
    Friend WithEvents Login As Button

End Class
