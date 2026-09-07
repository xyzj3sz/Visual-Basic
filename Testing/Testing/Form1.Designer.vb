<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        L1 = New Label()
        TextBox1 = New TextBox()
        L2 = New Label()
        TextBox2 = New TextBox()
        B1 = New Button()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' L1
        ' 
        L1.AutoSize = True
        L1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        L1.Location = New Point(27, 129)
        L1.Name = "L1"
        L1.Size = New Size(153, 37)
        L1.TabIndex = 1
        L1.Text = "Username:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        TextBox1.Location = New Point(204, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(234, 43)
        TextBox1.TabIndex = 2
        ' 
        ' L2
        ' 
        L2.AutoSize = True
        L2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        L2.Location = New Point(27, 211)
        L2.Name = "L2"
        L2.Size = New Size(146, 37)
        L2.TabIndex = 3
        L2.Text = "Password:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        TextBox2.Location = New Point(204, 211)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(234, 43)
        TextBox2.TabIndex = 4
        ' 
        ' B1
        ' 
        B1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        B1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        B1.Location = New Point(223, 282)
        B1.Name = "B1"
        B1.Size = New Size(189, 54)
        B1.TabIndex = 5
        B1.Text = "Enter"
        B1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(510, 389)
        Controls.Add(B1)
        Controls.Add(TextBox2)
        Controls.Add(L2)
        Controls.Add(TextBox1)
        Controls.Add(L1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents L1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents L2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents B1 As Button

End Class
